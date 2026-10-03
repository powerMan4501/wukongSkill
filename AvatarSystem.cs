using System;
using System.Threading.Tasks;
using b1;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 化身（大圣残躯）系统：一种"不销毁主角"的变身方案。
    /// 主角与化身互斥显隐——主角现身则化身隐藏，化身现身则主角隐藏。
    ///
    /// 流程：
    /// 1) SummonAvatar：按 SummonID（默认 700221 大圣残躯）召唤一个常驻召唤物，
    ///    出生即隐藏待命；同时暂停其 AI，避免它自行索敌/乱动。
    /// 2) AvatarSkill：隐藏主角 → 解除化身隐藏并瞬移到主角位置 → 同步主角锁定目标给化身 →
    ///    令化身释放 Value 指定技能。Param.HideAfterSkill=true（默认）时技能结束自动收回
    ///    （隐藏化身 + 恢复主角）；=false 则保持现身，可继续用 AvatarSkill 连招。
    ///    化身未就绪时自动先召唤、出生后再出招。
    /// 3) AvatarRecall：手动隐藏化身、恢复主角现身（并恢复化身 AI）。用于连招结束或随时交还控制权。
    ///
    /// 实现要点：
    /// - 显隐用 AActor.SetActorHiddenInGame（仅视觉隐藏，主角不被销毁、仍受控，镜头自然跟在主角位置）。
    /// - 化身技能用 BUS_EventCollectionCS.Evt_RequestSmartCastSkill（对任意 BGUCharacterCS 都有效）。
    /// - 化身 AI 用 Evt_AIPauseBT / Evt_AIPauseFsm 暂停，使化身只执行我们手动指定的技能。
    /// - 技能结束用化身的 Evt_OnSkillEnd（事件驱动，非轮询）触发自动收回。
    /// - 化身阵亡用 Evt_UnitDead 兜底恢复主角，避免主角卡在隐藏状态。
    /// </summary>
    public static class AvatarSystem
    {
        /// <summary>默认化身召唤物 ID（大圣残躯）</summary>
        private const int DefaultAvatarSummonId = 700221;

        /// <summary>出生后查找化身实例的重试时间点（毫秒），异步出生需轮询</summary>
        private static readonly int[] FindAvatarDelays = { 100, 300, 600, 1000, 1800 };

        /// <summary>当前化身实例（已出生且未被销毁时为有效引用）</summary>
        private static BGUCharacterCS? _avatar;

        /// <summary>召唤者（玩家），用于按 GUID 找回化身实例</summary>
        private static BGUPlayerCharacterCS? _summoner;

        /// <summary>最近一次操作的主角强引用；恢复显隐时优先用它，
        /// 避免死亡/切图/读档瞬间 GetCharacter() 取不到受控 Pawn 而静默失败</summary>
        private static BGUPlayerCharacterCS? _player;

        /// <summary>本次召唤的 GUID，用于从 BGC_SummonData 取出化身实例</summary>
        private static FCalliopeGuid? _summonGuid;

        // ===== 技能结束自动收回的订阅（事件驱动，非轮询）=====
        private static Del_Void_Int? _skillEndHandler;
        private static BGUCharacterCS? _skillEndAvatar;
        private static bool _skillEndSubscribed;
        private static int _castSkillId;

        // ===== 化身阵亡兜底订阅 =====
        private static Del_UnitDead? _deathHandler;
        private static BGUCharacterCS? _deathAvatar;
        private static bool _deathSubscribed;

        // ===== 化身未就绪时缓存的待出招请求 =====
        private static int _pendingSkill;
        private static bool _pendingHide;
        private static BGUPlayerCharacterCS? _pendingPlayer;

        /// <summary>召唤化身（默认 700221）并立即隐藏待命；已存在则只确保隐藏</summary>
        public static void SummonAvatar(BGUPlayerCharacterCS player, ActionConfig action)
        {
            if (_avatar != null && !_avatar.IsNullOrDestroyed())
            {
                Log.Info("[ActionsMod] 化身已存在，跳过重复召唤");
                _avatar.SetActorHiddenInGame(true);
                return;
            }

            // 拷贝一份配置并补默认值：SummonID 默认大圣残躯，SummonAliveTime 默认 -1（永久）
            ActionConfig cfg = action.ShallowCopy();
            if (cfg.SummonID == null || cfg.SummonID <= 0) cfg.SummonID = DefaultAvatarSummonId;
            if (cfg.SummonAliveTime == null) cfg.SummonAliveTime = -1;

            FCalliopeGuid guid = ModHelper.SummonReq(cfg);
            _summonGuid = guid;
            _summoner = player;
            Log.Info($"[ActionsMod] 已请求召唤化身 SummonID={cfg.SummonID}（出生后自动隐藏待命）");

            ScheduleFindAvatar(player, guid);
        }

        /// <summary>化身出招：隐藏主角、显示化身、瞬移同步、释放技能</summary>
        public static void CastAvatarSkill(BGUPlayerCharacterCS player, ActionConfig action)
        {
            int skillId = action.Value ?? 0;
            if (skillId <= 0)
            {
                Log.Warn("[ActionsMod] AvatarSkill 缺少 Value（技能 ID）");
                return;
            }
            _player = player;
            bool hideAfter = ReadBool(action, "HideAfterSkill", true);

            // 确保化身实例存在（尝试用 GUID 找回，或自动先召唤）
            if (_avatar == null || _avatar.IsNullOrDestroyed())
            {
                if (_summonGuid.HasValue && _summoner != null)
                {
                    var units = ModHelper.GetSummonedUnits(_summoner, _summonGuid.Value);
                    if (units.Count > 0) { _avatar = units[0]; OnAvatarFound(player); }
                }
                if (_avatar == null || _avatar.IsNullOrDestroyed())
                {
                    Log.Info("[ActionsMod] 化身尚未就绪，先召唤并在出生后自动出招");
                    _pendingSkill = skillId;
                    _pendingHide = hideAfter;
                    _pendingPlayer = player;
                    SummonAvatar(player, action);
                    return;
                }
            }

            ActivateAndCast(player, skillId, hideAfter);
        }

        /// <summary>手动收回化身：隐藏化身、恢复主角现身，并恢复化身 AI</summary>
        public static void Recall()
        {
            Log.Info("[ActionsMod] 化身收回：隐藏化身，恢复主角现身");
            if (_avatar != null && !_avatar.IsNullOrDestroyed())
            {
                _avatar.SetActorHiddenInGame(true);
                PauseAvatarAI(false);
            }
            UnsubscribeSkillEnd();
            UnsubscribeDeath();
            ShowPlayer();
        }

        // ===================== 内部实现 =====================

        /// <summary>设置主角显隐：同时作用于 Actor 级 bHidden 与 Mesh 组件的 bHiddenInGame/bVisible。
        /// 只切 bHidden 时，若某处把玩家 Mesh 的 bVisible 关掉（如化身期间游戏内部显隐逻辑），
        /// 单纯 SetActorHiddenInGame(false) 无法恢复，会导致"恢复主角现身"后依旧隐身。</summary>
        private static void SetPlayerVisibility(BGUPlayerCharacterCS p, bool visible)
        {
            p.SetActorHiddenInGame(!visible);
            var mesh = p.Mesh;
            if (mesh != null && !mesh.IsNullOrDestroyed())
            {
                mesh.SetHiddenInGame(!visible, bPropagateToChildren: true);
                mesh.SetVisibility(visible, bPropagateToChildren: true);
            }
        }

        /// <summary>显示主角（解除隐藏）。恢复时优先用缓存的主角引用，避免死亡/切图瞬间取不到</summary>
        private static void ShowPlayer()
        {
            var p = _player ?? ModHelper.GetCharacter();
            if (p == null || p.IsNullOrDestroyed())
            {
                Log.Warn("[ActionsMod] 恢复主角现身失败：未能取得有效玩家引用");
                return;
            }
            SetPlayerVisibility(p, true);
        }

        /// <summary>把化身瞬移到主角位置并对齐水平朝向</summary>
        private static void SyncAvatarToPlayer(BGUPlayerCharacterCS player)
        {
            if (_avatar == null || _avatar.IsNullOrDestroyed()) return;
            try
            {
                FVector loc = BGUFuncLibActorTransformCS.BGUGetActorLocation(player);
                _avatar.BGUSetActorLocation(loc, bSweep: false, bTeleport: true);

                FRotator rot = BGUFuncLibActorTransformCS.BGUGetActorRotation(player);
                rot.Pitch = 0f;
                rot.Roll = 0f;
                _avatar.BGUSetActorRotation(rot, bTeleportPhysics: false);
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 同步化身位置失败: {e.Message}");
            }
        }

        /// <summary>暂停/恢复化身 AI（行为树 + 状态机），使其只执行我们手动指定的技能</summary>
        private static void PauseAvatarAI(bool pause)
        {
            if (_avatar == null || _avatar.IsNullOrDestroyed()) return;
            var be = BUS_EventCollectionCS.Get(_avatar);
            if (be == null) return;
            try { be.Evt_AIPauseBT.Invoke(pause); } catch { }
            try { be.Evt_AIPauseFsm.Invoke(pause); } catch { }
        }

        /// <summary>隐藏待命 + 暂停 AI + 订阅阵亡兜底</summary>
        private static void OnAvatarFound(BGUPlayerCharacterCS player)
        {
            if (_avatar == null || _avatar.IsNullOrDestroyed()) return;
            _avatar.SetActorHiddenInGame(true);
            PauseAvatarAI(true);
            SubscribeDeath(_avatar);
            Log.Info("[ActionsMod] 化身（大圣残躯）已就绪并隐藏待命");
        }

        /// <summary>核心：隐藏主角、显示化身、同步、出招、按需挂技能结束回调</summary>
        private static void ActivateAndCast(BGUPlayerCharacterCS player, int skillId, bool hideAfter)
        {
            if (_avatar == null || _avatar.IsNullOrDestroyed())
            {
                // 化身没了（阵亡等）→ 恢复主角
                Recall();
                return;
            }
            var avatar = _avatar;
            _player = player;

            SetPlayerVisibility(player, false);
            avatar.SetActorHiddenInGame(false);
            SyncAvatarToPlayer(player);

            // 把主角当前锁定目标同步给化身，使其技能打向同一目标
            try
            {
                UnitLockTargetInfo tgt = BGUFunctionLibraryCS.BGUGetTargetInfo(player);
                BUS_EventCollectionCS.Get(avatar)?.Evt_SetTargetInfo.Invoke(tgt);
            }
            catch (Exception e)
            {
                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 同步锁定目标给化身失败: {e.Message}");
            }

            PauseAvatarAI(true);
            _castSkillId = skillId;

            BUS_EventCollectionCS.Get(avatar)
                ?.Evt_RequestSmartCastSkill.Invoke(skillId, null, EMontageBindReason.NormalSkill, false);

            if (hideAfter) SubscribeSkillEnd(avatar, skillId);
            else UnsubscribeSkillEnd();

            Log.Info($"[ActionsMod] 化身出招 SkillID={skillId} HideAfterSkill={hideAfter}");
        }

        // ===== 出生查找（异步，重试）=====

        private static void ScheduleFindAvatar(BGUPlayerCharacterCS player, FCalliopeGuid guid)
        {
            _ = Task.Run(async () =>
            {
                foreach (int delay in FindAvatarDelays)
                {
                    await Task.Delay(delay);
                    BGUCharacterCS? found = null;
                    Utils.TryRunOnGameThread(() => { found = TryFindAvatar(player, guid); });
                    await Task.Delay(20);
                    if (found != null)
                    {
                        _avatar = found;
                        Utils.TryRunOnGameThread(() => OnAvatarFound(player));
                        if (_pendingSkill > 0)
                        {
                            int sk = _pendingSkill;
                            bool h = _pendingHide;
                            _pendingSkill = 0;
                            _pendingHide = false;
                            BGUPlayerCharacterCS? pp = _pendingPlayer;
                            _pendingPlayer = null;
                            if (pp != null)
                            {
                                Utils.TryRunOnGameThread(() => ActivateAndCast(pp, sk, h));
                            }
                        }
                        return;
                    }
                }
                Log.Warn("[ActionsMod] 化身出生超时，未取到实例（可重试 SummonAvatar）");
            });
        }

        private static BGUCharacterCS? TryFindAvatar(BGUPlayerCharacterCS player, FCalliopeGuid guid)
        {
            var units = ModHelper.GetSummonedUnits(player, guid);
            return units.Count > 0 ? units[0] : null;
        }

        // ===== 技能结束订阅（自动收回）=====

        private static void SubscribeSkillEnd(BGUCharacterCS avatar, int skillId)
        {
            if (_skillEndSubscribed) return;
            if (_skillEndHandler == null) _skillEndHandler = new Del_Void_Int(OnAvatarSkillEnd);
            var be = BUS_EventCollectionCS.Get(avatar);
            if (be == null) return;
            be.Evt_OnSkillEnd += _skillEndHandler;
            _skillEndAvatar = avatar;
            _skillEndSubscribed = true;
        }

        private static void UnsubscribeSkillEnd()
        {
            if (!_skillEndSubscribed || _skillEndHandler == null) return;
            var be = _skillEndAvatar != null ? BUS_EventCollectionCS.Get(_skillEndAvatar) : null;
            if (be != null)
            {
                try { be.Evt_OnSkillEnd -= _skillEndHandler; } catch { }
            }
            _skillEndSubscribed = false;
            _skillEndAvatar = null;
        }

        private static void OnAvatarSkillEnd(int endedSkillId)
        {
            if (!_skillEndSubscribed) return;
            // 只响应我们这次打出去的技能结束（AI 已暂停，正常只有这一个）
            if (_castSkillId != 0 && endedSkillId != _castSkillId) return;
            Recall();
        }

        // ===== 化身阵亡兜底订阅 =====

        private static void SubscribeDeath(BGUCharacterCS avatar)
        {
            if (_deathSubscribed) return;
            if (_deathHandler == null) _deathHandler = new Del_UnitDead(OnAvatarDead);
            var be = BUS_EventCollectionCS.Get(avatar);
            if (be == null) return;
            be.Evt_UnitDead += _deathHandler;
            _deathAvatar = avatar;
            _deathSubscribed = true;
        }

        private static void UnsubscribeDeath()
        {
            if (!_deathSubscribed || _deathHandler == null) return;
            var be = _deathAvatar != null ? BUS_EventCollectionCS.Get(_deathAvatar) : null;
            if (be != null)
            {
                try { be.Evt_UnitDead -= _deathHandler; } catch { }
            }
            _deathSubscribed = false;
            _deathAvatar = null;
        }

        // 注意：FEffectInstReq / EAbnormalStateType 定义在服务端程序集 BtlSvr.Main 中，客户端 AppDomain 在 mod 重写阶段不会加载它。
        // 因此本方法所有参数都必须是必选（不写默认值）：一旦给 BtlSvr.Main 类型的参数写默认值，CSharpLoader 用 Mono.Cecil
        // 重写 mod 时会去解析该类型来编码常量，解析不到就整体加载失败。它是事件处理器，运行时由游戏事件全量传入。
        private static void OnAvatarDead(AActor? attacker, EDeadReason deadReason, int dmgId, int stiffLevel,
            UAnimMontage? beAttackedAM, FEffectInstReq effectInstReq, bool bIsDotDmg,
            EAbnormalStateType abnormalStateType)
        {
            Log.Info("[ActionsMod] 化身（大圣残躯）已阵亡，恢复主角现身");
            _avatar = null;
            UnsubscribeSkillEnd();
            UnsubscribeDeath();
            ShowPlayer();
        }

        private static bool ReadBool(ActionConfig action, string key, bool fallback)
        {
            if (action.Params != null && action.Params.TryGetValue(key, out var o) && o != null)
            {
                if (o is bool b) return b;
                if (bool.TryParse(o.ToString(), out var pb)) return pb;
            }
            return fallback;
        }
    }
}
