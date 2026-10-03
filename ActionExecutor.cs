using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using b1;
using b1.BGW;
using BtlB1;
using BtlShare;
using CSharpModBase;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 简易日志开关：ActionsMod 只实现"读取配置→按键触发→执行动作"这一条路径，
    /// 高频日志默认关闭（这些回调每秒触发几十次，常态开启会持续占用游戏线程）。
    /// </summary>
    internal static class ModLog
    {
        public static bool Verbose;
        public static void Info(string msg) => Log.Info(msg);
    }

    /// <summary>
    /// 动作执行器：根据 ActionType 分发并执行动作。
    /// 已实现的动作类型：Buff / Skill / Magic（含 soulBossConfig 自定义外观）/ Trans /
    /// AddItem / AddItemRange / Rushskill（幻影突进）/ range_buff（范围加 Buff）/ JingDouYun（筋斗云）/
    /// ChangeMoveSpeed（修改移动速度，复用 BUEffectChangeMoveSpd 底层属性）/
    /// out_magic（退出幻化）/ change_to_dasheng（变身齐天大圣）/ trans_back（结束原生变身）/
    /// addallsummonlifetime（延长召唤物存活）/ Montage_SetPosition（跳转 Montage 播放位置）/
    /// setMagicBack（幻化是否自动变回）/ bullet（生成弹体，见 bulletConfig）/
    /// RegEvents / UnRegEvents（订阅/解绑游戏事件，配合 SweepCheck / BuffActions /
    /// EffectActions / Projectile 目录里的配置驱动）/
    /// PlaySound（播放音效）/ PlayDialogue（按 AiConversationContentDesc ID 播台词）/
    /// SpeakDialogue（按 FUStDialogueDesc 台词 ID 播台词）/ Subtitle（只显示字幕）。
    /// 其余动作类型执行时打印 TODO 占位日志。
    /// </summary>
    public static class ActionExecutor
    {
        private static readonly object _typeLock = new object();

        // Skill / Magic 动作节流（0.3 秒）
        private static readonly Dictionary<ActionType, long> _lastExecuteTime = new Dictionary<ActionType, long>();
        private const long ThrottleIntervalMs = 300;

        // 递归深度闸门：Skill/Magic/Trans 等动作会再次触发游戏事件回到 DoActions，防止配置成环导致无界递归
        // 按线程统计嵌套层数：事件回调在游戏线程执行，延迟/重复任务在线程池执行，
        // 用 ThreadLocal 可以让两条调用链的层数互不影响
        private const int MaxActionDepth = 3;
        private static readonly ThreadLocal<int> _actionDepth = new ThreadLocal<int>(() => 0);

        // Type=Actions 动作组的嵌套层数闸门：配置里自己嵌套自己时会无界递归，单独限一层上限
        // （不占用上面的事件递归深度，因为动作组是配置显式写的，不会像游戏事件那样自发成环）
        private const int MaxNestDepth = 8;
        private static readonly ThreadLocal<int> _nestDepth = new ThreadLocal<int>(() => 0);

        // 子弹命中回调（HitActions）关联桥：DoBulletAction 在调用 SpawnProjectile 生成"应当携带命中回调的子弹"之前，
        // 把该 bulletConfig 的 HitActions 暂存到这里；ModEvents.OnNotifyMasterProjectileSpawned 在子弹同步生成后
        // 取出并为本发子弹挂上 Evt_OnProjectileBeHitted 监听。生成调用返回后立即清零，确保不污染其它子弹。
        // 仅在游戏线程同步赋值/读取（生成是同步的），无需加锁。
        public static List<ActionConfig>? PendingBulletHitActions { get; set; }

        /// <summary>
        /// 同一组里是否需要对"同类型重复动作"去重。
        /// 不去重的类型：bullet（一次配多个弹体）、PlaySound（多个音效）、
        /// Actions（多个动作组，每组条件不同，去重会让第二组永远执行不到）。
        /// </summary>
        private static bool NeedDedup(ActionType type)
            => type != ActionType.bullet && type != ActionType.PlaySound && type != ActionType.Actions;

        // ChangeMoveSpeed 当前生效的句柄：再次修改或到期自动还原时用于复位
        private static uint _moveSpeedHandle = 0;

        /// <summary>执行一组动作</summary>
        public static int DoActions(BGUPlayerCharacterCS? character, List<ActionConfig> actions, FEffectInstReq? effectInstReq = null)
        {
            if (character == null || actions == null || actions.Count == 0) return 0;

            if (_actionDepth.Value >= MaxActionDepth)
            {
                Log.Warn($"[ActionsMod] DoActions 递归深度达到上限 {MaxActionDepth}，本次忽略（疑似配置成环）");
                return 0;
            }

            _actionDepth.Value++;
            try
            {
                return RunGroupCore(character, actions, effectInstReq);
            }
            finally
            {
                _actionDepth.Value--;
            }
        }

        /// <summary>
        /// 执行一个动作组的主体（先普通动作，全不满足才走兜底）。
        /// 事件入口 DoActions 与嵌套入口 RunNestedGroup 共用。
        /// </summary>
        private static int RunGroupCore(BGUPlayerCharacterCS character, List<ActionConfig> actions, FEffectInstReq? effectInstReq)
        {
            HashSet<ActionType> executedTypes = new HashSet<ActionType>();

            // 兜底动作（"default": true）不参与首轮执行
            List<ActionConfig> normalActions = actions.Where(a => a == null || a.Default != true).ToList();
            List<ActionConfig> fallbackActions = actions.Where(a => a != null && a.Default == true).ToList();

            int executed = RunActionList(character, normalActions, executedTypes, effectInstReq);

            // 没有任何一个普通动作执行成功（条件不满足等），且有兜底动作 → 执行兜底
            if (executed == 0 && fallbackActions.Count > 0)
            {
                Log.Info($"[ActionsMod] 无动作满足条件，执行 {fallbackActions.Count} 个兜底动作");
                RunActionList(character, fallbackActions, executedTypes, effectInstReq);
            }
            return executed;
        }

        /// <summary>
        /// 执行 Type=Actions 的嵌套动作组，返回其中真正执行成功的子动作数量。
        /// 走独立的嵌套深度计数，不消耗事件递归深度（动作组是配置显式嵌套，不是事件回环）。
        /// </summary>
        private static int RunNestedGroup(BGUPlayerCharacterCS character, List<ActionConfig>? actions, FEffectInstReq? effectInstReq)
        {
            if (character == null || actions == null || actions.Count == 0) return 0;

            if (_nestDepth.Value >= MaxNestDepth)
            {
                Log.Warn($"[ActionsMod] Actions 动作组嵌套层数达到上限 {MaxNestDepth}，本次忽略（请检查配置是否自我嵌套）");
                return 0;
            }

            _nestDepth.Value++;
            try
            {
                return RunGroupCore(character, actions, effectInstReq);
            }
            finally
            {
                _nestDepth.Value--;
            }
        }

        /// <summary>执行一组动作，返回真正执行成功的动作数量（延迟动作视为已安排）</summary>
        private static int RunActionList(BGUPlayerCharacterCS character, List<ActionConfig> actions,
            HashSet<ActionType> executedTypes, FEffectInstReq? effectInstReq = null)
        {
            if (character == null || actions == null || actions.Count == 0) return 0;

            int executed = 0;
            foreach (var action in actions)
            {
                if (action == null) continue;
                int delay = action.Delay ?? 0;
                if (delay > 0)
                {
                    _ = ExecuteDelayed(character, action, executedTypes, effectInstReq);
                    executed++;
                }
                else
                {
                    lock (_typeLock)
                    {
                        // bullet / PlaySound / Actions 允许同类型多次执行；其余同类型只执行第一个满足条件的
                        bool needDedup = NeedDedup(action.Type);
                        if (needDedup && executedTypes.Contains(action.Type))
                        {
                            if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 跳过重复动作 Type={action.Type}，同类型只执行第一个满足条件的");
                            continue;
                        }
                        if (DoAction(character, action, effectInstReq))
                        {
                            if (needDedup) executedTypes.Add(action.Type);
                            executed++;
                        }
                    }
                }
            }
            return executed;
        }

        /// <summary>执行单个动作（根据 ActionType 分发），返回是否实际执行了动作</summary>
        public static bool DoAction(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq = null)
        {
            if (character == null) return false;
            BUC_UnitStateData? readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(character);
            if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead))
            {
                return false;
            }
            if (!CheckActionConditions(character, action))
            {
                return false;
            }

            // MagicMaps：按当前元素挑一个分支，覆盖到本动作上
            action = ResolveMagicMap(character, action);

            // 重复执行：duration(总时长ms) + interval(间隔ms) → 次数 = duration / interval（至少 1 次）
            if (action.RepeatDuration > 0 && action.RepeatInterval > 0)
            {
                const int MaxRepeatCount = 512;
                const int MinRepeatIntervalMs = 16;

                int count = Math.Max(1, (int)(action.RepeatDuration / action.RepeatInterval));
                if (count > MaxRepeatCount)
                {
                    Log.Warn($"[ActionsMod] 动作 Type={action.Type} 重复次数 {count} 超过上限 {MaxRepeatCount}，已钳制");
                    count = MaxRepeatCount;
                }
                if (action.RepeatInterval < MinRepeatIntervalMs)
                {
                    Log.Warn($"[ActionsMod] 动作 Type={action.Type} 重复间隔 {action.RepeatInterval}ms 过小，已按 {MinRepeatIntervalMs}ms 处理");
                    count = Math.Min(count, MaxRepeatCount);
                }
                ExecuteActionCore(character, action, effectInstReq, true);
                if (count > 1)
                {
                    _ = Task.Run(async () => await RepeatActionLoop(character, action, effectInstReq, count));
                }
                return true;
            }

            return ExecuteActionCore(character, action, effectInstReq, false);
        }

        /// <summary>单个动作的实际执行体（DoAction 与重复执行循环共用）</summary>
        private static bool ExecuteActionCore(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq, bool skipThrottle)
        {
            // 节流控制：Skill 和 Magic 类型动作 0.3 秒内最多触发一次
            if (!skipThrottle && (action.Type == ActionType.Skill || action.Type == ActionType.Magic))
            {
                long currentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;
                if (_lastExecuteTime.TryGetValue(action.Type, out long lastTime) && (currentTime - lastTime) < ThrottleIntervalMs)
                {
                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 动作节流中 Type={action.Type}，距上次执行不足0.3秒");
                    return false;
                }
                _lastExecuteTime[action.Type] = currentTime;
            }

            try
            {
                switch (action.Type)
                {
                    case ActionType.Buff:
                        DoBuffAction(character, action);
                        break;
                    case ActionType.Skill:
                        DoSkillAction(character, action);
                        break;
                    case ActionType.Magic:
                        if (ModHelper.IsWuKong(character))
                            DoMagicAction(character, action);
                        break;
                    case ActionType.range_buff:
                        DoRangeBuffAction(character, action);
                        break;
                    case ActionType.Rushskill:
                        if (ModHelper.IsWuKong(character))
                            DoRushskillAction(character, action);
                        break;
                    case ActionType.ChangeMoveSpeed:
                        DoChangeMoveSpeedAction(character, action);
                        break;
                    case ActionType.JingDouYun:
                        if (ModHelper.IsWuKong(character))
                            BUS_EventCollectionCS.Get(character)?.Evt_ToggleCloudMove.Invoke();
                        break;
                    case ActionType.Trans:
                        if (ModHelper.IsWuKong(character))
                            DoTransAction(character, action);
                        break;
                    case ActionType.AddItem:
                        DoAddItemAction(character, action);
                        break;
                    case ActionType.AddItemRange:
                        DoAddItemRangeAction(character, action);
                        break;
                    case ActionType.out_magic:
                        ModHelper.magicallyChangeBack();
                        break;
                    case ActionType.change_to_dasheng:
                        ModHelper.change_to_dasheng(action.Value > 0 ? action.Value : (int?)null);
                        break;
                    case ActionType.trans_back:
                        ModHelper.TransBack();
                        break;
                    case ActionType.addallsummonlifetime:
                        DoAddAllSummonLifeTimeAction(character, action);
                        break;
                    case ActionType.Montage_SetPosition:
                        DoMontageSetPositionAction(action);
                        break;
                    case ActionType.setMagicBack:
                        ModHelper.setMagicBack(character, action.Value > 0);
                        break;
                    case ActionType.bullet:
                        DoBulletAction(character, action, effectInstReq);
                        break;
                    case ActionType.RegEvents:
                        ModEvents.RegPlayerTransEvent();
                        ModEvents.RegSweepCheckBeginEvent();
                        ModEvents.EnableAutoRemount();
                        Log.Info("[ActionsMod] RegEvents：已订阅 SweepCheck/Buff/Effect/Projectile/Montage 事件（并开启跨地图自动重挂载）");
                        break;
                    case ActionType.UnRegEvents:
                        ModEvents.UnRegPlayerTransEvent();
                        ModEvents.UnSweepCheckBeginEvent();
                        ModEvents.DisableAutoRemount();
                        Log.Info("[ActionsMod] UnRegEvents：已解绑全部事件（并关闭跨地图自动重挂载）");
                        break;
                    case ActionType.add_attr:
                        DoAddAttrAction(character, action);
                        break;
                    case ActionType.reflect_damage:
                        DoReflectDamageAction(character, action);
                        break;
                    case ActionType.RedirectInputSkill:
                        EventBindings.RunAllInputCastActions(character);
                        break;
                    case ActionType.CastImmobilize:
                        EventBindings.RunAllImmobilizeActions(character);
                        break;
                    case ActionType.SkillCostDmg:
                        EventBindings.RunAllSkillCostDmgActions(character);
                        break;
                    case ActionType.ext_lifesaving:
                        ModHelper.ActiveExtLifeSaving(character);
                        break;
                    case ActionType.ShowHotKeys:
                        HotKeyRegistry.DumpTable();
                        break;
                    case ActionType.PlaySound:
                        SoundActions.PlaySound(character, action);
                        break;
                    case ActionType.PlayDialogue:
                        SoundActions.PlayDialogue(character, action);
                        break;
                    case ActionType.SpeakDialogue:
                        SoundActions.SpeakDialogue(character, action);
                        break;
                    case ActionType.Subtitle:
                        SoundActions.Subtitle(character, action);
                        break;
                    case ActionType.SayLine:
                        SoundActions.SayLine(character, action);
                        break;
                    case ActionType.ProbeVoice:
                        SoundActions.ProbeVoice(character, action);
                        break;
                    case ActionType.ProbeSoundAssets:
                        SoundAssetIndex.Dump(character, action);
                        break;
                    case ActionType.combo_save:
                        ComboKeeper.Save(character);
                        break;
                    case ActionType.combo_restore:
                        DoComboRestoreAction(character, action);
                        break;
                    case ActionType.SetCamera:
                        CameraActions.SetCamera(character, action);
                        break;
                    case ActionType.ResetCamera:
                        CameraActions.ResetCamera(character, action);
                        break;
                    case ActionType.summon:
                        ModHelper.SummonReq(action);
                        break;
                    case ActionType.SummonAvatar:
                        AvatarSystem.SummonAvatar(character, action);
                        break;
                    case ActionType.AvatarSkill:
                        AvatarSystem.CastAvatarSkill(character, action);
                        break;
                    case ActionType.AvatarRecall:
                        AvatarSystem.Recall();
                        break;
                    case ActionType.BossBarOffset:
                        BossBarOffsetAction.Run(action);
                        break;
                    case ActionType.TeleportTargetToFront:
                        DoTeleportTargetToFrontAction(action);
                        break;
                    case ActionType.CalcAMScale:
                        DoCalcAMScaleAction(action);
                        break;
                    // 动作组：自身只做条件判定，通过后把子动作交给 RunNestedGroup 执行（支持继续嵌套）。
                    // 子动作一个都没真正执行时本组算"未执行"，好让上层的兜底（Default）逻辑照常生效。
                    case ActionType.Actions:
                        return RunNestedGroup(character, action.Actions, effectInstReq) > 0;
                    default:
                        Log.Warn($"[ActionsMod] 动作类型 {action.Type} 暂未实现（当前仅迁移 Buff/Skill/Magic/Trans/AddItem/bullet/RegEvents/UnRegEvents）");
                        break;
                }
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 执行动作失败 Type={action.Type} Value={action.Value}: {e.Message}");
            }
            return true;
        }

        /// <summary>重复执行循环：第 1 次已在 DoAction 立即执行，这里补齐剩余次数（基于游戏世界时间）</summary>
        private static async Task RepeatActionLoop(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq, int count)
        {
            float intervalSec = Math.Max(16, action.RepeatInterval ?? 16) / 1000f;
            for (int i = 1; i < count; i++)
            {
                await WaitForGameTime(intervalSec);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        ExecuteActionCore(character, action, effectInstReq, true);
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"[ActionsMod] 重复动作执行异常（角色可能已销毁）: {ex.Message}");
                    }
                });
            }
        }

        /// <summary>延迟执行动作（基于游戏世界时间，随时缓/暂停同步）</summary>
        private static async Task ExecuteDelayed(BGUPlayerCharacterCS character, ActionConfig action, HashSet<ActionType> executedTypes, FEffectInstReq? effectInstReq)
        {
            await WaitForGameTime((action.Delay ?? 0) / 1000f);
            Utils.TryRunOnGameThread(() =>
            {
                var player = ModHelper.GetCharacter();
                if (player != null)
                {
                    lock (_typeLock)
                    {
                        bool needDedup = NeedDedup(action.Type);
                        if (needDedup && executedTypes.Contains(action.Type))
                        {
                            if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 跳过重复动作 Type={action.Type}（延迟执行）");
                            return;
                        }
                        if (DoAction(player, action, effectInstReq))
                        {
                            if (needDedup) executedTypes.Add(action.Type);
                        }
                    }
                }
            });
        }

        /// <summary>基于游戏世界时间等待指定秒数（读取 UWorld.TimeSeconds，随时缓/暂停冻结；墙钟兜底）</summary>
        internal static async Task WaitForGameTime(float seconds)
        {
            if (seconds <= 0f) return;

            IntPtr worldAddress = EngineLoop.WorldTime.WorldAddress;
            if (worldAddress == IntPtr.Zero)
            {
                await Task.Delay((int)(seconds * 1000f));
                return;
            }

            float targetTime = WorldTimeHelper.GetTimeSeconds(worldAddress) + seconds;
            int wallClockLimitMs = Math.Max(1000, (int)(seconds * 1000f * 3));
            System.Diagnostics.Stopwatch wallClock = System.Diagnostics.Stopwatch.StartNew();

            const int pollIntervalMs = 8;
            while (true)
            {
                if (EngineLoop.WorldTime.WorldAddress != worldAddress) break;
                if (WorldTimeHelper.GetTimeSeconds(worldAddress) >= targetTime) break;
                if (wallClock.ElapsedMilliseconds >= wallClockLimitMs)
                {
                    Log.Warn($"[ActionsMod] WaitForGameTime 超过墙钟上限 {wallClockLimitMs}ms 仍未等到游戏时间 {seconds}s（可能处于暂停/时缓），提前退出");
                    break;
                }
                await Task.Delay(pollIntervalMs);
            }
        }

        // ===================== 条件检查 =====================

        /// <summary>
        /// 校验一个动作上的全部条件：Condition（单条件，兼容旧配置）+ Conditions（多条件）。
        /// 两者都写时都要满足（AND）。
        /// </summary>
        private static bool CheckActionConditions(BGUPlayerCharacterCS character, ActionConfig action)
        {
            if (action.Condition != null && !CheckCondition(character, action.Condition))
            {
                return false;
            }
            if (action.Conditions != null)
            {
                foreach (var cond in action.Conditions)
                {
                    if (cond == null) continue;
                    if (!CheckCondition(character, cond)) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// MagicMaps 解析：Type=Magic 且配了 MagicMaps 时，按当前"冰火毒雷"挑一个分支。
        /// 命中顺序：① 元素匹配的那一项 → ② Type 写 "default"（或留空）的兜底项 → ③ 第一项。
        /// 命中项的 Value / magicSkill / magicBackSkill / DAPath / name 覆盖到动作副本上返回
        /// （用副本，避免把常驻缓存里的配置对象改坏）。
        /// </summary>
        private static ActionConfig ResolveMagicMap(BGUPlayerCharacterCS character, ActionConfig action)
        {
            var maps = action.MagicMaps;
            if (action.Type != ActionType.Magic || maps == null || maps.Count == 0) return action;

            MagicMapConfig? first = null;
            foreach (var m in maps)
            {
                if (m != null) { first = m; break; }
            }
            if (first == null) return action;

            string curElem = getCurrentElemt(character);

            MagicMapConfig? picked = null;
            MagicMapConfig? fallback = null;
            foreach (var m in maps)
            {
                if (m == null) continue;
                string key = (m.Type ?? m.Elem ?? "").Trim().ToLowerInvariant();
                if (key.Length == 0 || key == "default")
                {
                    fallback ??= m;
                    continue;
                }
                if (_elemAliasMap.TryGetValue(key, out string want) && want == curElem)
                {
                    picked = m;
                    break;
                }
            }
            picked ??= fallback ?? first;

            ActionConfig copy = action.ShallowCopy();
            if (picked.Value.HasValue) copy.Value = picked.Value;
            if (picked.magicSkill.HasValue) copy.magicSkill = picked.magicSkill;
            if (picked.magicBackSkill.HasValue) copy.magicBackSkill = picked.magicBackSkill;
            if (!string.IsNullOrEmpty(picked.DAPath)) copy.DAPath = picked.DAPath;
            if (!string.IsNullOrEmpty(picked.name)) copy.name = (action.name ?? "") + picked.name;

            if (ModLog.Verbose)
                ModLog.Info($"[ActionsMod] MagicMaps 选中「{picked.Type ?? picked.Elem ?? "(第一项)"}」→ Value={copy.Value} magicSkill={copy.magicSkill}（当前元素={curElem}）");
            return copy;
        }

        /// <summary>校验动作触发条件</summary>
        private static bool CheckCondition(BGUPlayerCharacterCS character, ConditionConfig condition)
        {
            if (condition == null) return true;

            // 组合条件：Type="any" 时子条件满足任一即可，其余（含 "all" / 留空）要求全部满足
            if (condition.Conditions != null && condition.Conditions.Count > 0)
            {
                bool anyMode = string.Equals(condition.Type, "any", StringComparison.OrdinalIgnoreCase);
                foreach (var sub in condition.Conditions)
                {
                    if (sub == null) continue;
                    bool ok = CheckCondition(character, sub);
                    if (anyMode && ok) return true;
                    if (!anyMode && !ok) return false;
                }
                return !anyMode;
            }

            if (string.IsNullOrEmpty(condition.Type))
            {
                return true;
            }

            string[] paramList = condition.Params?.Split(',') ?? new string[0];

            switch (condition.Type)
            {
                case "LastSkillID":
                    int lastSkillId = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(character)?.GetLastSkillID() ?? 0;
                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 检查 LastSkillID: {lastSkillId} 是否在 {condition.Params} 中");
                    foreach (var param in paramList)
                    {
                        if (int.TryParse(param.Trim(), out int skillId) && skillId == lastSkillId)
                            return true;
                    }
                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 检查 LastSkillID: {lastSkillId} 不在 {condition.Params} 中");
                    return false;

                case "hasAnyBuff":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int buffId);
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, buffId))
                            return true;
                    }
                    return false;

                case "noHasAnyBuff":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int buffId);
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, buffId))
                            return false;
                    }
                    return true;

                case "hasAnyTalent":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int talentId);
                        if (BGUFunctionLibraryCS.BGUHasTalentByID(character, talentId))
                            return true;
                    }
                    return false;

                case "bullet_fire":
                case "bullet_ice":
                case "bullet_thunder":
                case "bullet_poison":
                    return getCurrentElemt(character) == condition.Type;

                // 元素条件（可一次写多个，命中任意一个即满足）：
                //   params: "fire,ice,thunder,poison,none"，也可以直接写 "bullet_fire" 这种全称
                //   none = 当前没带任何元素（getCurrentElemt 返回空）
                case "elem":
                    string curElem = getCurrentElemt(character);
                    foreach (var param in paramList)
                    {
                        string key = param.Trim().ToLowerInvariant();
                        if (_elemAliasMap.TryGetValue(key, out string want) && want == curElem)
                            return true;
                    }
                    return false;

                case "skillCDReady":
                    // Params 里任一技能已完成冷却即成立
                    foreach (var param in paramList)
                    {
                        if (int.TryParse(param.Trim(), out int skillId) && ModHelper.IsSkillCDFinished(skillId, character))
                            return true;
                    }
                    return false;

                case "skillCDNotReady":
                    // Params 里任一技能仍在冷却中即成立（用于"技能在CD时改放别的"这类重定向）
                    foreach (var param in paramList)
                    {
                        if (int.TryParse(param.Trim(), out int skillId) && !ModHelper.IsSkillCDFinished(skillId, character))
                            return true;
                    }
                    return false;

                default:
                    Log.Warn($"[ActionsMod] 未知的 Condition Type: {condition.Type}");
                    return false;
            }
        }

        // ===================== 元素判定（用于 bullet_* 条件）=====================

        private const int ElemCacheWindowMs = 50;
        private static BGUPlayerCharacterCS? _elemCacheChar;
        private static string _elemCacheValue = "";
        private static int _elemCacheMs = 0;

        // TalentID -> 元素类型 映射表
        private static readonly Dictionary<int, string> _talentElementMap = new Dictionary<int, string>
        {
            { 106039, "bullet_fire" }, // 满堂红
            { 106022, "bullet_ice" },  // 辟水珠
            { 106015, "bullet_poison" }, // 三清令
            { 106028, "bullet_thunder" }, // 博山炉

            { 105002, "bullet_fire" }, // 金箍棒
            { 105011, "bullet_fire" }, // 业火棍
            { 105016, "bullet_fire" }, // 混铁棍
            { 105022, "bullet_fire" }, // 兽棍·诸相

            { 105101, "bullet_ice" },  // 三尖两刃枪
            { 105102, "bullet_ice" },  // 楮白枪
            { 105004, "bullet_poison" }, // 兽棍·熊罴
            { 105006, "bullet_poison" }, // 几丁棍
            { 105007, "bullet_poison" }, // 昆棍·百眼
            { 105008, "bullet_poison" }, // 出云棍
            { 105009, "bullet_poison" }, // 兽棍·貂鼠
            { 105012, "bullet_poison" }, // 狼牙棒
            { 105013, "bullet_poison" }, // 昆棍·蛛仙
            { 105018, "bullet_poison" }, // 昆棍·通天
            { 105019, "bullet_poison" }, // 兽棍·金睛
            { 105020, "bullet_poison" }, // 磬槌

            { 105003, "bullet_thunder" }, // 鳞棍·双蛇
            { 105014, "bullet_thunder" }, // 鳞棍·亢金
            { 105015, "bullet_thunder" }, // 飞龙宝杖
            { 105017, "bullet_thunder" }, // 天龙棍
        };

        // elem 条件里 params 的别名 -> 内部元素标识（空串 = 无元素）
        private static readonly Dictionary<string, string> _elemAliasMap = new Dictionary<string, string>
        {
            { "fire", "bullet_fire" },
            { "ice", "bullet_ice" },
            { "thunder", "bullet_thunder" },
            { "poison", "bullet_poison" },
            { "none", "" },
            { "", "" },
            { "bullet_fire", "bullet_fire" },
            { "bullet_ice", "bullet_ice" },
            { "bullet_thunder", "bullet_thunder" },
            { "bullet_poison", "bullet_poison" },
            // 中文也能写
            { "火", "bullet_fire" },
            { "冰", "bullet_ice" },
            { "雷", "bullet_thunder" },
            { "毒", "bullet_poison" },
            { "无", "" },
        };

        public static string getCurrentElemt(BGUPlayerCharacterCS character)
        {
            int now = Environment.TickCount;
            if (ReferenceEquals(_elemCacheChar, character)
                && (now - _elemCacheMs) < ElemCacheWindowMs)
            {
                return _elemCacheValue;
            }

            string result = "";
            foreach (var kvp in _talentElementMap)
            {
                if (BGUFunctionLibraryCS.BGUHasTalentByID(character, kvp.Key))
                {
                    result = kvp.Value;
                    break;
                }
            }

            _elemCacheChar = character;
            _elemCacheValue = result;
            _elemCacheMs = now;
            return result;
        }

        // ===================== 已迁移的动作处理器 =====================

        /// <summary>Buff 动作：添加指定 Buff</summary>
        private static void DoBuffAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            List<int> buffIds = action.Values ?? new List<int> { action.Value.GetValueOrDefault() };
            int duration = (int)(action.Duration > 0 ? action.Duration : 0);

            if (buffIds == null || buffIds.Count == 0)
            {
                Log.Warn("[ActionsMod] Buff ID 无效");
                return;
            }

            try
            {
                foreach (var item in buffIds)
                {
                    BGUFunctionLibraryCS.BGUAddBuff(character, character, item, EBuffSourceType.GM, duration);
                }
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 添加 Buff 失败: {e.Message}");
            }
        }

        /// <summary>Skill 动作：释放指定技能</summary>
        private static void DoSkillAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int skillId = (int)(action.Value ?? 0);
            if (skillId <= 0)
            {
                Log.Warn("[ActionsMod] Skill ID 无效");
                return;
            }

            BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                skillId, null, EMontageBindReason.NormalSkill, false);
            if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 释放技能 ID={skillId}");
        }

        /// <summary>
        /// Magic 动作：释放法术/变化技能。
        /// 优先使用 soulBossConfig 中的自定义外观配置（按 magicId 匹配），未命中时回退到 DAPath 加载。
        /// </summary>
        private static void DoMagicAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            string daPath = action.DAPath ?? string.Empty;
            int magicSkillId = action.magicSkill.GetValueOrDefault();
            int recoverSkillId = action.magicBackSkill.GetValueOrDefault();
            int magicId = (int)(action.Value ?? 0);

            // 查找 soulBossConfig 中的自定义外观配置（soulConfigList）
            SoulBossConfig? soulConfig = SoulBossLogic.GetSoulConfig(magicId);

            if (magicId > 0)
            {
                SoulSkillDesc? soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(magicId);
                if (soulSkillDesc is SoulSkillDesc sd)
                {
                    if (sd.DAPath != null) daPath = sd.DAPath;
                    if (magicSkillId <= 0) magicSkillId = sd.SkillId;
                    // 命中自定义外观配置时，Buff 改用 soulConfig.BuffId 附加
                    if (soulConfig == null && sd.BuffId > 0)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, sd.BuffId, EBuffSourceType.GM, 5000);
                    }
                }
            }
            if (recoverSkillId <= 0) recoverSkillId = 10199;
            if (magicSkillId <= 0 || recoverSkillId <= 0)
            {
                Log.Warn($"[ActionsMod] Magic 技能ID无效 变身ID={magicSkillId}, 还原ID={recoverSkillId}");
                return;
            }

            BGWDataAsset_MagicallyChangeConfig? config = null;
            if (soulConfig != null)
            {
                // 命中 soulConfigList，使用自定义数据构造配置
                config = SoulBossLogic.GetMagicConfig(character, magicId);
                if (config != null)
                {
                    Log.Info($"[ActionsMod] 使用 soulBossConfig 自定义配置 MagicID={magicId}");
                    if (soulConfig.BuffId > 0)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, (int)soulConfig.BuffId, EBuffSourceType.GM, 5000);
                    }
                }
                else
                {
                    Log.Warn($"[ActionsMod] soulBossConfig 配置构造失败 MagicID={magicId}，回退到 DAPath 加载");
                }
            }
            if (config == null)
            {
                if (string.IsNullOrEmpty(daPath))
                {
                    Log.Warn("[ActionsMod] Magic DAPath 无效");
                    return;
                }

                config = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(daPath, ELoadResourceType.SyncLoadAndCache);
                if (config == null)
                {
                    Log.Warn($"[ActionsMod] 加载幻化变身配置失败 DAPath={daPath}");
                    return;
                }
            }

            // 连招保护：幻化会走 StopAllMontages → SkillBreak，先把连招状态存档
            bool keepCombo = action.KeepCombo == true;
            if (keepCombo)
            {
                ComboKeeper.Save(character);
            }

            BUS_EventCollectionCS.Get(character)?.Evt_OnCastMagicallyChangeSkill.Invoke(config, magicSkillId, recoverSkillId);
            // 幻化套用后，按配置隐藏玩家装备部件（如残躯被玩家头盖住导致秃头）
            SoulBossLogic.ApplyMagicHideMeshes(character, soulConfig);

            // 打断流程跑完后再回灌，否则会被随后的 SolveLeaveSkillMontage / ComboGraphReset 覆盖
            if (keepCombo)
            {
                ScheduleComboRestore(character, action);
            }
        }

        /// <summary>combo_restore 动作：回灌 combo_save 抓到的连招状态</summary>
        private static void DoComboRestoreAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            float holdMs = action.KeepComboHold ?? ReadParamFloat(action, "HoldMs", 2500f);
            ComboKeeper.Restore(character, holdMs / 1000f);
        }

        /// <summary>KeepCombo 模式：施放后延迟一段时间再回灌连招（等打断流程跑完）</summary>
        private static void ScheduleComboRestore(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int delayMs = Math.Max(0, action.KeepComboDelay ?? 600);
            float holdMs = Math.Max(0f, action.KeepComboHold ?? 2500f);

            _ = Task.Run(async () =>
            {
                if (delayMs > 0) await WaitForGameTime(delayMs / 1000f);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        var player = ModHelper.GetCharacter();
                        if (player != null) ComboKeeper.Restore(player, holdMs / 1000f);
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"[ActionsMod] 连招回灌失败: {ex.Message}");
                    }
                });
            });
        }

        private static float ReadParamFloat(ActionConfig action, string key, float fallback)
        {
            if (action.Params != null && action.Params.TryGetValue(key, out var v) && float.TryParse(v?.ToString(), out var f))
            {
                return f;
            }
            return fallback;
        }

        /// <summary>
        /// Trans 动作：原生变身。
        /// （transConfig 自定义变身配置属于"其余逻辑"，尚未迁移；这里只走原生变身路径）
        /// </summary>
        private static void DoTransAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int ResId = (int)(action.Value ?? 0);
            if (ResId <= 0)
            {
                Log.Warn("[ActionsMod] Trans ID 无效");
                return;
            }

            int spawnSkillId = (int)(action.magicSkill ?? 0);
            var beginType = EPlayerTransBeginType.SkillEffect;

            BPS_EventCollectionCS.Get(character.PlayerState)
                .Evt_TriggerPlayerTransBegin.Invoke(beginType, new PlayerTransParam
                {
                    TargetResId = ResId,
                    SpawnSkillId = spawnSkillId,
                    NeedBlend = true
                });
        }

        /// <summary>AddItem 动作：添加物品到背包</summary>
        private static void DoAddItemAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int itemId = (int)(action.Value ?? 0);
            int count = action.Count.GetValueOrDefault(1);

            if (itemId <= 0)
            {
                Log.Warn("[ActionsMod] AddItem ID 无效");
                return;
            }

            try
            {
                ModHelper.gain_item(itemId, count);
                Log.Info($"[ActionsMod] 添加物品 ID={itemId}, 数量={count}");
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 添加物品失败 ID={itemId}: {e.Message}");
            }
        }

        /// <summary>AddItemRange 动作：批量添加一段连续 ID 的物品</summary>
        private static void DoAddItemRangeAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            if (action.Values == null || action.Values.Count == 0)
            {
                Log.Warn("[ActionsMod] AddItemRange 缺少 Values（[起始ID,结束ID] 或 ID 列表）");
                return;
            }

            int perCount = action.Count.GetValueOrDefault(1);
            if (perCount < 1) perCount = 1;

            List<int> ids = new List<int>();
            if (action.Values.Count == 2)
            {
                int start = action.Values[0];
                int end = action.Values[1];
                if (start > end) { int tmp = start; start = end; end = tmp; }
                if (end - start > 5000)
                {
                    Log.Warn($"[ActionsMod] AddItemRange 区间过大（{start}~{end}），已截断到 5000 个");
                    end = start + 5000;
                }
                for (int id = start; id <= end; id++) ids.Add(id);
            }
            else
            {
                ids.AddRange(action.Values);
            }

            try
            {
                int added = ModHelper.gain_items(ids, perCount);
                Log.Info($"[ActionsMod] 批量添加物品 {added} 种，每种 {perCount} 个，区间 {ids[0]}~{ids[ids.Count - 1]}");
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 批量添加物品失败: {e.Message}");
            }
        }

        /// <summary>
        /// bullet 动作：生成弹体（子弹 / 法术场）。
        /// 配置了 ProjectileIDs 列表时逐个生成一次，否则按单个 ProjectileID 生成。
        /// 携带了 effectInstReq（来自技能效果触发）时下发给弹体，使其挂在技能效果点上。
        /// </summary>
        private static void DoBulletAction(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq)
        {
            bulletConfig? config = action.bulletConfig;
            if (config == null)
            {
                Log.Warn("[ActionsMod] bullet 动作缺少 bulletConfig");
                return;
            }

            bool hasPenetrate = HasPenetrate(config);
            // 存在独立穿透弹时，命中回调交给穿透弹负责（避免与激光盒重叠造成重复触发）；否则主弹体负责
            List<ActionConfig>? mainHit = (!hasPenetrate && config.HitActions != null) ? config.HitActions : null;

            if (config.ProjectileIDs != null && config.ProjectileIDs.Count > 0)
            {
                foreach (var item in config.ProjectileIDs)
                {
                    config.ProjectileID = item;
                    config.effectInstReq = effectInstReq;
                    PendingBulletHitActions = mainHit;
                    ModHelper.SpawnProjectile(character, config);
                    PendingBulletHitActions = null;
                }
            }
            else
            {
                config.effectInstReq = effectInstReq;
                PendingBulletHitActions = mainHit;
                ModHelper.SpawnProjectile(character, config);
                PendingBulletHitActions = null;
            }

            // 独立穿透伤害弹体：保留主弹体（如激光外观）的同时，额外生成一发可穿透障碍的弹体，
            // 用于命中墙/场景物背后的敌人（激光弹的 BulletCanThroughBlockage 只能穿透角色，无法穿透障碍）。
            // 复用同一份 bulletConfig（同出生插槽/朝向/path），仅替换 ProjectileID 为穿透弹体，
            // 且不复制 penetrateDamageProjectileID 以免递归重复生成。命中回调（HitActions）由穿透弹承担。
            if (hasPenetrate)
            {
                var penConfig = ResolvePenetrateConfig(config);
                PendingBulletHitActions = penConfig.HitActions;
                ModHelper.SpawnProjectile(character, penConfig);
                PendingBulletHitActions = null;
            }
        }

        /// <summary>penetrateDamageProjectileID 是否配置了独立穿透弹（兼容整数 ID 与 bulletConfig 对象两种写法）</summary>
        private static bool HasPenetrate(bulletConfig config)
        {
            var t = config.penetrateDamageProjectileID;
            if (t == null || t.Type == JTokenType.Null) return false;
            if (t.Type == JTokenType.Integer) return t.Value<int>() > 0;
            return t.Type == JTokenType.Object;
        }

        /// <summary>
        /// 解析穿透弹配置：整数写法沿用旧逻辑（仅替换 ProjectileID，其余继承主配置）；
        /// 对象写法以主配置为基底继承所有字段，再用对象里显式给出的字段覆盖（可独立调 BulletFlySpd / HitActions 等）。
        /// 两种写法都会清空 penetrateDamageProjectileID 以避免递归/重复生成。
        /// </summary>
        private static bulletConfig ResolvePenetrateConfig(bulletConfig main)
        {
            var t = main.penetrateDamageProjectileID!;
            if (t.Type == JTokenType.Integer)
            {
                return new bulletConfig
                {
                    ProjectileID = t.Value<int>(),
                    type = main.type,
                    ProjectileNumInOneWave = main.ProjectileNumInOneWave,
                    BulletFlySpd = main.BulletFlySpd ?? 8000,
                    spawnBaseType = main.spawnBaseType,
                    targetBaseType = main.targetBaseType,
                    targetBaseUseSocket = main.targetBaseUseSocket,
                    AttachToSpawnBase = main.AttachToSpawnBase,
                    targetBasSocketName = main.targetBasSocketName,
                    spawnBaseSocketName = main.spawnBaseSocketName,
                    path = main.path,
                    BuffIDList = main.BuffIDList,
                    BornDirOffsetX = main.BornDirOffsetX,
                    BornDirOffsetY = main.BornDirOffsetY,
                    BornDirOffsetZ = main.BornDirOffsetZ,
                    SpawnOffsetX = main.SpawnOffsetX,
                    SpawnOffsetY = main.SpawnOffsetY,
                    SpawnOffsetZ = main.SpawnOffsetZ,
                    effectInstReq = main.effectInstReq,
                    distance = main.distance,
                    HitActions = main.HitActions,
                };
            }

            // 对象写法：以主配置为基底继承，再用对象显式字段覆盖
            var pen = new bulletConfig
            {
                ProjectileID = main.ProjectileID,
                type = main.type,
                ProjectileNumInOneWave = main.ProjectileNumInOneWave,
                BulletFlySpd = main.BulletFlySpd,
                spawnBaseType = main.spawnBaseType,
                targetBaseType = main.targetBaseType,
                targetBaseUseSocket = main.targetBaseUseSocket,
                AttachToSpawnBase = main.AttachToSpawnBase,
                targetBasSocketName = main.targetBasSocketName,
                spawnBaseSocketName = main.spawnBaseSocketName,
                path = main.path,
                BuffIDList = main.BuffIDList,
                BornDirOffsetX = main.BornDirOffsetX,
                BornDirOffsetY = main.BornDirOffsetY,
                BornDirOffsetZ = main.BornDirOffsetZ,
                SpawnOffsetX = main.SpawnOffsetX,
                SpawnOffsetY = main.SpawnOffsetY,
                SpawnOffsetZ = main.SpawnOffsetZ,
                distance = main.distance,
                HitActions = main.HitActions,
                effectInstReq = main.effectInstReq,
            };
            try
            {
                JsonConvert.PopulateObject(t.ToString(Formatting.None), pen);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 解析 penetrateDamageProjectileID 对象失败: {e.Message}");
            }
            pen.penetrateDamageProjectileID = null; // 关闭递归
            return pen;
        }

        /// <summary>Rushskill 动作：重置影子突进(10095)冷却后立即触发一次幻影突进</summary>
        private static void DoRushskillAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            // 重置影子突进冷却，使其可立即再次触发
            BUS_EventCollectionCS.Get(character)?.Evt_ModifyCD.Invoke(10095, true, -150f);
            ESkillDirection dir = action.RushDir switch
            {
                "Backward" => ESkillDirection.Backward,
                "Left" => ESkillDirection.Left,
                "Right" => ESkillDirection.Right,
                _ => ESkillDirection.Forward,
            };
            BUS_EventCollectionCS.Get(character)?.Evt_TriggerPhantomRush.Invoke(dir);
        }

        /// <summary>
        /// ChangeMoveSpeed 动作：直接修改角色移动速度（复用 BUEffectChangeMoveSpd 的底层属性：EPropType.Movement_SpeedCtrlInfo）。
        /// 三档（慢跑/跑步/疾跑）整组覆盖（非叠加），再次触发会先复位上一次修改。
        /// Duration>0 时到期自动还原为默认速度；Duration<=0（或 -1）则常驻，直到再次触发本动作。
        /// 注：仅支持同时存在一个 ChangeMoveSpeed 修改，新修改会替换旧的。
        /// </summary>
        private static void DoChangeMoveSpeedAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            float walk = action.MoveSpeedWalk ?? 0f;
            float run = action.MoveSpeedRun ?? 0f;
            float sprint = action.MoveSpeedSprint ?? 0f;

            IBUC_PropMgrData? propData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(character);
            if (propData == null)
            {
                Log.Warn("[ActionsMod] ChangeMoveSpeed 获取 PropMgrData 失败");
                return;
            }
            var evt = BUS_EventCollectionCS.Get(character);
            if (evt == null) return;

            // 先复位上一次修改，避免句柄堆积（整组替换语义）
            if (_moveSpeedHandle != 0)
            {
                evt.Evt_ResetProperty.Invoke(_moveSpeedHandle);
                _moveSpeedHandle = 0;
            }

            // FVector 分量顺序：(疾跑, 跑步, 慢跑)，与 BUEffectChangeMoveSpd 一致
            evt.Evt_SetVectorProperty.Invoke(EPropType.Movement_SpeedCtrlInfo, new FVector(sprint, run, walk));
            uint handle = propData.GetLastHandleID();
            _moveSpeedHandle = handle;

            int duration = action.Duration ?? 0;
            if (duration > 0)
            {
                uint capturedHandle = handle;
                _ = Task.Run(async () =>
                {
                    await WaitForGameTime(duration / 1000f);
                    Utils.TryRunOnGameThread(() =>
                    {
                        var e = BUS_EventCollectionCS.Get(character);
                        e?.Evt_ResetProperty.Invoke(capturedHandle);
                        if (_moveSpeedHandle == capturedHandle) _moveSpeedHandle = 0;
                    });
                });
            }

            Log.Info($"[ActionsMod] 修改移动速度 walk={walk} run={run} sprint={sprint} ({(duration > 0 ? $"持续{duration}ms" : "常驻")})");
        }

        /// <summary>range_buff 动作：给范围内(默认 3000cm)所有角色批量加 Buff</summary>
        private static void DoRangeBuffAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            List<int> buffIds = action.Values ?? new List<int> { action.Value.GetValueOrDefault() };
            int duration = (int)(action.Duration > 0 ? action.Duration : 0);

            if (buffIds == null || buffIds.Count == 0)
            {
                Log.Warn("[ActionsMod] Buff ID 无效");
                return;
            }
            var rangValue = action.range ?? 3000;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(rangValue);

            try
            {
                foreach (var actor in allActorsOfClassList)
                {
                    foreach (var item in buffIds)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, actor, item, EBuffSourceType.GM, duration);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 添加 Buff 失败: {e.Message}");
            }
        }

        /// <summary>addallsummonlifetime 动作：给玩家所有召唤物延长存活时间（秒，缺省 100）</summary>
        private static void DoAddAllSummonLifeTimeAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            float lifeTime = (float)(action.SummonAliveTime ?? 100);
            BUS_EventCollectionCS.Get(character)?.Evt_AddAllSummonLifeTime.Invoke(lifeTime);
            Log.Info($"[ActionsMod] 延长所有召唤物存活时间 {lifeTime}s");
        }

        /// <summary>Montage_SetPosition 动作：把当前正在播放的 Montage 跳到 Value/1000 秒处</summary>
        private static void DoMontageSetPositionAction(ActionConfig action)
        {
            if (action.Value == null)
            {
                Log.Warn("[ActionsMod] Montage_SetPosition 缺少 Value（目标位置，单位毫秒）");
                return;
            }
            float posSec = (float)action.Value / 1000f;
            ModHelper.Montage_SetPosition(posSec);
            Log.Info($"[ActionsMod] 设置当前 Montage 播放位置 {posSec}s");
        }

        /// <summary>
        /// TeleportTargetToFront 动作：把锁定的目标拉到自己正前方指定距离处。
        /// Value 或 Params.Distance = 距离（默认 500）；Params.Facing = away(默认)/face/keep；Params.GroundSnap = 是否贴地（默认 true）
        /// </summary>
        private static void DoTeleportTargetToFrontAction(ActionConfig action)
        {
            float distance = 500f;
            string facing = "away";
            bool groundSnap = true;

            if (action.Value.HasValue) distance = action.Value.Value;

            if (action.Params != null)
            {
                if (action.Params.TryGetValue("Distance", out var dObj) && float.TryParse(dObj?.ToString(), out var dVal)) distance = dVal;
                if (action.Params.TryGetValue("Facing", out var fObj) && fObj != null) facing = fObj.ToString() ?? "away";
                if (action.Params.TryGetValue("GroundSnap", out var gObj) && bool.TryParse(gObj?.ToString(), out var gVal)) groundSnap = gVal;
            }

            ModHelper.TeleportTargetToFront(distance, facing, groundSnap);
        }

        /// <summary>
        /// CalcAMScale 动作：计算并设置 AMScale 缩放率（需要当前有 Montage 在播才生效）。
        /// Params：TotalDuration / NotifyBeginTime / NotifyEndTime / MinRate / MaxRate / MoveOffset / MoveOffsetZ
        /// </summary>
        private static void DoCalcAMScaleAction(ActionConfig action)
        {
            float totalDuration = 0.3f;
            float notifyBeginTime = 0f;
            float notifyEndTime = 0.3f;
            float minRate = 0.01f;
            float maxRate = 20f;
            float moveOffset = 0f;
            float moveOffsetZ = 0f;

            if (action.Params != null)
            {
                if (action.Params.TryGetValue("TotalDuration", out var td) && float.TryParse(td?.ToString(), out var tdVal)) totalDuration = tdVal;
                if (action.Params.TryGetValue("NotifyBeginTime", out var nbt) && float.TryParse(nbt?.ToString(), out var nbtVal)) notifyBeginTime = nbtVal;
                if (action.Params.TryGetValue("NotifyEndTime", out var net) && float.TryParse(net?.ToString(), out var netVal)) notifyEndTime = netVal;
                if (action.Params.TryGetValue("MinRate", out var minr) && float.TryParse(minr?.ToString(), out var minrVal)) minRate = minrVal;
                if (action.Params.TryGetValue("MaxRate", out var maxr) && float.TryParse(maxr?.ToString(), out var maxrVal)) maxRate = maxrVal;
                if (action.Params.TryGetValue("MoveOffset", out var mo) && float.TryParse(mo?.ToString(), out var moVal)) moveOffset = moVal;
                if (action.Params.TryGetValue("MoveOffsetZ", out var moz) && float.TryParse(moz?.ToString(), out var mozVal)) moveOffsetZ = mozVal;
            }

            ModHelper.CalcAMScale(totalDuration, notifyBeginTime, notifyEndTime, minRate, maxRate, moveOffset, moveOffsetZ);
        }

        /// <summary>add_attr 默认属性组合：血 / 蓝 / 四豆 / 法宝 / 元气（与 MagicMod increase_attr 一致）</summary>
        private static readonly EBGUAttrFloat[] DefaultAddAttrs =
        {
            EBGUAttrFloat.Hp,
            EBGUAttrFloat.Mp,
            EBGUAttrFloat.CurEnergy,
            EBGUAttrFloat.FabaoEnergy,
            EBGUAttrFloat.VigorEnergy
        };

        /// <summary>属性名 → 枚举（add_attr 的 AttrList 用，忽略大小写）</summary>
        private static readonly Dictionary<string, EBGUAttrFloat> AttrNameMap = new Dictionary<string, EBGUAttrFloat>(StringComparer.OrdinalIgnoreCase)
        {
            { "Hp", EBGUAttrFloat.Hp },
            { "HpMax", EBGUAttrFloat.HpMax },
            { "Mp", EBGUAttrFloat.Mp },
            { "MpMax", EBGUAttrFloat.MpMax },
            { "CurEnergy", EBGUAttrFloat.CurEnergy },
            { "Energy", EBGUAttrFloat.CurEnergy },
            { "FabaoEnergy", EBGUAttrFloat.FabaoEnergy },
            { "VigorEnergy", EBGUAttrFloat.VigorEnergy },
            { "VigorEnergyMax", EBGUAttrFloat.VigorEnergyMax },
            { "Shield", EBGUAttrFloat.Shield },
            { "BloodBottomNum", EBGUAttrFloat.BloodBottomNum }
        };

        /// <summary>
        /// add_attr 动作：回血回蓝 / 加资源（GM_AddAttr）。
        /// AttrValue = 固定值；AttrPercent = 按事件上下文伤害量的百分比（如 0.1 = 10%）+ AttrMin 保底。
        /// AttrList 为空时默认加 Hp / Mp / CurEnergy / FabaoEnergy / VigorEnergy。
        /// </summary>
        private static void DoAddAttrAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            float amount;
            if (action.AttrValue.HasValue)
            {
                amount = action.AttrValue.Value;
            }
            else if (action.AttrPercent.HasValue)
            {
                float baseDmg = EventBindings.LastDamageValue;
                if (baseDmg <= 0f)
                {
                    // 按键直接触发时没有伤害上下文，百分比模式无意义
                    Log.Warn("[ActionsMod] add_attr 用 AttrPercent 但当前没有伤害上下文（该动作只能由 SkillCostDmg / NormalDamageEffect 事件触发）");
                    return;
                }
                float min = action.AttrMin ?? 10f;
                amount = Math.Max(baseDmg * action.AttrPercent.Value, min);
            }
            else
            {
                Log.Warn("[ActionsMod] add_attr 缺少 AttrValue / AttrPercent");
                return;
            }

            List<EBGUAttrFloat> attrs = new List<EBGUAttrFloat>();
            if (action.AttrList != null && action.AttrList.Count > 0)
            {
                foreach (var n in action.AttrList)
                {
                    if (n == null) continue;
                    string key = n.Trim();
                    if (AttrNameMap.TryGetValue(key, out var attrType)) attrs.Add(attrType);
                    else Log.Warn($"[ActionsMod] add_attr 未知属性名: {n}");
                }
            }
            if (attrs.Count == 0) attrs.AddRange(DefaultAddAttrs);

            try
            {
                foreach (var attr in attrs)
                {
                    BGUFunctionLibraryCS.GM_AddAttr(character, attr, amount);
                }
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] add_attr 失败: {e.Message}");
            }
        }

        /// <summary>
        /// reflect_damage 动作：把最近一次受到的技能伤害原样返回给攻击者。
        /// 只在 Evt_TriggerNormalDamageEffect 的上下文里有效（其它场景拿不到伤害快照，会直接跳过）。
        /// </summary>
        private static void DoReflectDamageAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            var ctx = EventBindings.LastDamage;
            AActor? attacker = ctx.Attacker;
            if (attacker == null || attacker.IsNullOrDestroyed())
            {
                Log.Warn("[ActionsMod] reflect_damage 无有效伤害上下文，只能由 Evt_TriggerNormalDamageEffect 触发");
                return;
            }

            var skillDamageConfig = ctx.SkillDamageConfig;
            var attrMemData = ctx.AttrMemData;
            FEffectInstReq req = ctx.EffectInstReq;
            if (req.Attacker != null)
            {
                req.Attacker = character; // 反弹时施害者换成自己，避免伤害来源仍记在对方身上
            }

            BUS_EventCollectionCS.Get(attacker)?.Evt_TriggerNormalDamageEffect
                .Invoke(character, in skillDamageConfig, in req, in attrMemData);
        }

        /// <summary>以玩家为中心、半径 maxDistance 内的所有角色（用于 range_buff）</summary>
        private static List<ABGUCharacter> getMonsterByDistance(float maxDistance = 6000)
        {
            var play = ModHelper.GetCharacter();
            if (play == null || play.World == null) return new List<ABGUCharacter>();
            UBGUSelectUtil.SphereOverlapBGUCharacters(play, BGUFuncLibActorTransformCS.BGUGetActorLocation(play), maxDistance, out var outArray);
            return outArray;
        }
    }
}
