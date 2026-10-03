using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using b1;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 游戏事件订阅（对应 RegEvents / UnRegEvents 两个动作），移植自 MagicMod 的
    /// ModHelper.RegPlayerTransEvent / RegSweepCheckBeginEvent。
    /// 订阅后，事件回调会把控制权交给 EventBindings —— 由 SweepCheck/ / BuffActions/ / EffectActions/ /
    /// Projectile/ / InputCast/ / Immobilize/ / SkillCostDmg/ / NormalDamageEffect/ 里的
    /// JSON 配置决定具体执行哪些动作。没配这些文件夹时，订阅几乎没有额外开销（回调里第一次空表判断就返回了）。
    ///
    /// 与 MagicMod 的差别：MagicMod 把「技能重定向 / 定身激光弹 / 回血回蓝 / 反弹伤害」写死在代码里，
    /// 这里全部改成配置驱动 —— 分别对应 InputCast/、Immobilize/、SkillCostDmg/、NormalDamageEffect/ 四个目录。
    /// </summary>
    public static class ModEvents
    {
        // Notify 名比较用的 FName：缓存起来，避免每次遍历 Notify 都进 name table 做哈希
        private static readonly FName DodgeWindowNotifyName = new FName("BANS_GSDodgeWindow");
        private static readonly FName ComboWindowNotifyName = new FName("ComboWindow");

        // ===================== 跨地图自动重挂载 =====================
        // 进新地图时玩家角色 Actor 会被重建，导致 BUS_EventCollectionCS / BPS_GSEventCollection 上
        // 的订阅全部丢失（这就是"每次进新图要重按 F1"的根因）。
        // 对策：订阅 GameInstance 级、跨地图持久的 BGW_EventCollection 关卡切换事件，
        // 每次地图加载完成后自动把业务事件重新订阅到"新"的玩家角色上。
        private static bool _autoRemount = true;      // 是否自动跨地图重挂载（默认开，实现全自动）
        private static bool _globalSubscribed;        // 全局关卡事件是否已订阅（整局只订阅一次）
        private static int _lastReRegisterTick;       // 去重：同一地图切换的多个事件只处理一次
        private static Timer? _subscribeRetryTimer;   // 初始化时 World 未就绪则重试订阅

        /// <summary>注册变身（Player Trans）事件：变身开始/结束后重新绑定业务事件</summary>
        public static void RegPlayerTransEvent()
        {
            var character = ModHelper.GetCharacter();
            if (character == null || character.PlayerState == null) return;

            try
            {
                var ps = BPS_GSEventCollection.Get(character.PlayerState);
                ps.Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
                ps.Evt_TriggerPlayerTransBegin += new Del_PlayerTransBegin(OnEventTransBegin);
                ps.Evt_TriggerPlayerTransEnd -= new Del_PlayerTransEnd(OnEventTransEnd);
                ps.Evt_TriggerPlayerTransEnd += new Del_PlayerTransEnd(OnEventTransEnd);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] RegPlayerTransEvent 失败: {e.Message}");
            }
        }

        public static void UnRegPlayerTransEvent()
        {
            var character = ModHelper.GetCharacter();
            if (character == null || character.PlayerState == null) return;

            try
            {
                var ps = BPS_GSEventCollection.Get(character.PlayerState);
                ps.Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
                ps.Evt_TriggerPlayerTransEnd -= new Del_PlayerTransEnd(OnEventTransEnd);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] UnRegPlayerTransEvent 失败: {e.Message}");
            }
        }

        // ===================== 跨地图自动重挂载实现 =====================

        /// <summary>
        /// 开启"跨地图自动重挂载"：订阅 GameInstance 级（跨关卡持久）的关卡切换事件。
        /// 之后每次进新地图都会自动重新订阅玩家角色与 PlayerState 上的业务事件，无需再按 F1。
        /// 只在 World 就绪后订阅一次；若 Mod 加载过早（World 为空）则启动重试定时器。
        /// </summary>
        public static void EnableAutoRemount()
        {
            if (_globalSubscribed) return;
            _autoRemount = true;
            if (TrySubscribeGlobal()) { _globalSubscribed = true; return; }

            // World 还没就绪（Mod 加载早于首图）：每秒重试，直到订阅成功
            if (_subscribeRetryTimer == null)
            {
                _subscribeRetryTimer = new Timer(_ => TrySubscribeGlobalAndMark(), null, 1000, 1000);
            }
        }

        /// <summary>关闭自动重挂载（对应 UnRegEvents 动作 / F4），并退订全局关卡事件</summary>
        public static void DisableAutoRemount()
        {
            _autoRemount = false;
            _subscribeRetryTimer?.Dispose();
            _subscribeRetryTimer = null;
            if (!_globalSubscribed) return;
            _globalSubscribed = false;
            try
            {
                var world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
                var bgw = world != null ? BGW_EventCollection.Get(world) : null;
                if (bgw == null) return;
                bgw.Evt_PostLoadingScreenClose -= new Del_Void(OnLevelChanged);
                bgw.Evt_OnCurrentLevelChanged -= new Del_Void_Int(OnLevelChanged);
                Log.Info("[ActionsMod] 已关闭跨地图自动重挂载");
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] DisableAutoRemount 退订失败: {e.Message}");
            }
        }

        private static void TrySubscribeGlobalAndMark()
        {
            if (TrySubscribeGlobal())
            {
                _globalSubscribed = true;
                _subscribeRetryTimer?.Dispose();
                _subscribeRetryTimer = null;
            }
        }

        private static bool TrySubscribeGlobal()
        {
            try
            {
                var world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
                if (world == null) return false;
                var bgw = BGW_EventCollection.Get(world);
                if (bgw == null) return false;

                bgw.Evt_PostLoadingScreenClose -= new Del_Void(OnLevelChanged);
                bgw.Evt_PostLoadingScreenClose += new Del_Void(OnLevelChanged);
                bgw.Evt_OnCurrentLevelChanged -= new Del_Void_Int(OnLevelChanged);
                bgw.Evt_OnCurrentLevelChanged += new Del_Void_Int(OnLevelChanged);

                Log.Info("[ActionsMod] 已订阅跨地图事件（Evt_PostLoadingScreenClose / Evt_OnCurrentLevelChanged），进新图将自动重挂载");
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 全局关卡事件订阅失败: {e.Message}");
                return false;
            }
        }

        /// <summary>地图切换回调（Evt_PostLoadingScreenClose / Evt_OnCurrentLevelChanged 共用）</summary>
        private static void OnLevelChanged()
        {
            if (!_autoRemount) return;
            int now = Environment.TickCount;
            if (unchecked(now - _lastReRegisterTick) < 3000) return; // 同一地图切换的多个事件去重
            _lastReRegisterTick = now;
            Log.Info("[ActionsMod] 检测到地图切换，准备自动重挂载事件订阅（延迟 1.2s 等角色就绪）");
            _ = Task.Run(async () =>
            {
                await Task.Delay(1200);
                Utils.TryRunOnGameThread(() => ReRegisterAll());
            });
        }

        private static void OnLevelChanged(int levelId) => OnLevelChanged();

        /// <summary>重新订阅到"新"的玩家角色（BUS_EventCollectionCS）与 PlayerState（BPS_GSEventCollection）</summary>
        private static void ReRegisterAll()
        {
            try
            {
                RegPlayerTransEvent();
                RegSweepCheckBeginEvent();
                Log.Info("[ActionsMod] 地图切换后已自动重挂载全部业务事件订阅");
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 地图切换后自动重挂载失败: {e.Message}");
            }
        }

        /// <summary>注册 SweepCheck / Buff / Effect / Projectile / Montage 等业务事件</summary>
        public static void RegSweepCheckBeginEvent()
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            try
            {
                var evt = BUS_EventCollectionCS.Get(character);
                if (evt == null) return;

                evt.Evt_SweepCheckBegin -= new Del_SweepCheckBegin(SweepCheckBegin);
                evt.Evt_SweepCheckBegin += new Del_SweepCheckBegin(SweepCheckBegin);

                evt.Evt_RequestSmartCastSkill -= new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);
                evt.Evt_RequestSmartCastSkill += new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);

                evt.Evt_BuffAdd -= new Del_BuffAdd(BuffBegin);
                evt.Evt_BuffAdd += new Del_BuffAdd(BuffBegin);

                evt.Evt_TriggerSkillEffect -= new Del_TriggerSkillEffect(OnTriggerSkillEffect);
                evt.Evt_TriggerSkillEffect += new Del_TriggerSkillEffect(OnTriggerSkillEffect);

                evt.Evt_NotifyMasterProjectileSpawned -= new Del_Actor(OnNotifyMasterProjectileSpawned);
                evt.Evt_NotifyMasterProjectileSpawned += new Del_Actor(OnNotifyMasterProjectileSpawned);

                evt.Evt_OnNotifyStateSpawnProjectileObj -= new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);
                evt.Evt_OnNotifyStateSpawnProjectileObj += new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);

                evt.Evt_PlayMontageCallback -= new Del_PlayMontageCallback(OnPlayMontageCallback);
                evt.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);

                evt.Evt_InputCastSkill -= new Del_InputCastSkill(OnInputCastSkill);
                evt.Evt_InputCastSkill += new Del_InputCastSkill(OnInputCastSkill);

                evt.Evt_CastImmobilize -= new Del_Void_Int(OnCastImmobilize);
                evt.Evt_CastImmobilize += new Del_Void_Int(OnCastImmobilize);

                evt.Evt_OnSkillCostDmg -= new Del_OnSkillCostDmg(OnSkillCostDmg);
                evt.Evt_OnSkillCostDmg += new Del_OnSkillCostDmg(OnSkillCostDmg);

                evt.Evt_TriggerNormalDamageEffect -= new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);
                evt.Evt_TriggerNormalDamageEffect += new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] RegSweepCheckBeginEvent 失败: {e.Message}");
            }
        }

        public static void UnSweepCheckBeginEvent()
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            try
            {
                var evt = BUS_EventCollectionCS.Get(character);
                if (evt == null) return;

                evt.Evt_SweepCheckBegin -= new Del_SweepCheckBegin(SweepCheckBegin);
                evt.Evt_RequestSmartCastSkill -= new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);
                evt.Evt_BuffAdd -= new Del_BuffAdd(BuffBegin);
                evt.Evt_TriggerSkillEffect -= new Del_TriggerSkillEffect(OnTriggerSkillEffect);
                evt.Evt_NotifyMasterProjectileSpawned -= new Del_Actor(OnNotifyMasterProjectileSpawned);
                evt.Evt_OnNotifyStateSpawnProjectileObj -= new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);
                evt.Evt_PlayMontageCallback -= new Del_PlayMontageCallback(OnPlayMontageCallback);
                evt.Evt_InputCastSkill -= new Del_InputCastSkill(OnInputCastSkill);
                evt.Evt_CastImmobilize -= new Del_Void_Int(OnCastImmobilize);
                evt.Evt_OnSkillCostDmg -= new Del_OnSkillCostDmg(OnSkillCostDmg);
                evt.Evt_TriggerNormalDamageEffect -= new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] UnSweepCheckBeginEvent 失败: {e.Message}");
            }
        }

        // ===================== 事件回调 =====================

        private static void OnEventTransBegin(EPlayerTransBeginType UnitTransType, PlayerTransParam PlayerTransParam)
        {
            // 受控 Pawn 即将变成变身单位，等 1 秒拿到新 Pawn 后再重新绑定事件
            _ = Task.Run(async () =>
            {
                await Task.Delay(1000);
                Utils.TryRunOnGameThread(() => RegSweepCheckBeginEvent());
            });
        }

        private static void OnEventTransEnd(EPlayerTransEndType UnitTransType, PlayerTransParam PlayerTransParam)
        {
            RegSweepCheckBeginEvent();
        }

        public static void SweepCheckBegin(int ObjectID, int WeaponIndex, List<FUStCheckShape> SweepCheckShape,
            List<int> EffectIDList, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<int> EffectIDListForSceneItem,
            FHitDestructibleActorConfig HitDestructibleActorConfig, int HitChrAudioID, int HitChrFXWeight, FHitCheckConf HitCheckConf,
            bool CanHitBackBullet, float SweepCheckProtectTime, UAnimSequenceBase Animation, UAnimMontage AtkReboundingAM,
            UAnimMontage LowAtkReboundingAM, int SweepCheckGroupID, int FromInstanceID,
            List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<FTriggerEffectWithCondition> EffectsWithCondition_After,
            float NotifyBeginTime)
        {
            var character = ModHelper.GetCharacter();
            if (character == null || Animation == null) return;

            string pathName = Animation.GetPathName();
            EventBindings.DoSweepCheckActions(character, pathName, NotifyBeginTime);
        }

        public static void OnRequestSmartCastSkill(int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason,
            bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            FUStSkillSDesc? SkillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, character);
            if (SkillSDesc == null) return;

            EventBindings.DoCastActions(character, SkillSDesc.TemplatePath);
        }

        public static void BuffBegin(int BuffID, AActor Caster, AActor RootCaster, float Duration,
            EBuffSourceType BuffSourceType, bool bRecursed, FBattleAttrSnapShot BattleAttrSnapShot)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoBuffBeginActions(character, BuffID);
        }

        public static void OnTriggerSkillEffect(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget, bool bWithRPCEvent)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoSkillEffectActions(character, EffectID, EffectInstReq);
        }

        /// <summary>弹体/法术场 Actor 生成：按 PathName 应用缩放与法术场 Buff 覆盖</summary>
        public static void OnNotifyMasterProjectileSpawned(AActor owner)
        {
            if (owner == null) return;
            EventBindings.ApplyProjectileBindings(owner);

            // 子弹命中回调：若本次生成由配置了 HitActions 的 bulletConfig 触发，
            // 则为本发子弹挂上 Evt_OnProjectileBeHitted 监听，命中敌人时执行 HitActions。
            var hitActions = ActionExecutor.PendingBulletHitActions;
            if (hitActions != null && hitActions.Count > 0)
            {
                var character = ModHelper.GetCharacter();
                if (character != null)
                {
                    new BulletHitWatcher(owner, hitActions, character).Attach();
                }
            }
        }

        /// <summary>子弹生成：按当前 Montage + ProjectileID 执行 bullet_actions</summary>
        public static void OnNotifyStateSpawnProjectileObj(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo,
            bool bNeedHandleStopReq, EProjectileSpawnMethod SpawnMethod, int MethodUniqueID)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            UAnimMontage? currentMontage = character.GetCurrentMontage();
            string pathName = currentMontage?.PathName ?? "";
            int projectileId = ProjectileSpawnNSInfo.ProjectileID;

            EventBindings.DoBulletSpawnActions(character, pathName, projectileId);
        }

        /// <summary>输入技能被释放（Evt_InputCastSkill）：按 InputCast/ 配置做技能重定向 / 附加动作</summary>
        public static void OnInputCastSkill(EInputActionType InputActionType, bool IsRelease, int SkillID, int DescID, int ItemID = -1)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoInputCastActions(character, InputActionType, IsRelease, SkillID);
        }

        /// <summary>释放定身（Evt_CastImmobilize）：按 Immobilize/ 配置执行（典型是一次 bullet 激光弹）</summary>
        public static void OnCastImmobilize(int ConfigID)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoImmobilizeActions(character, ConfigID);
        }

        /// <summary>技能造成伤害（Evt_OnSkillCostDmg）：按 SkillCostDmg/ 配置执行（典型是 add_attr 回血回蓝）</summary>
        public static void OnSkillCostDmg(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit = false)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoSkillCostDmgActions(character, Victim, SkillID, FinalDmg, bIsCrit);
        }

        /// <summary>结算伤害（Evt_TriggerNormalDamageEffect）：按 NormalDamageEffect/ 配置执行（典型是把伤害反弹给攻击者）</summary>
        public static void OnTriggerNormalDamageEffect(AActor Attacker, in FSkillDamageConfig SkillDamageConfig,
            in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return;

            EventBindings.DoNormalDamageActions(character, Attacker, SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData);
        }

        /// <summary>
        /// Montage 播放回调：按 SweepCheck 配置里的 addRadius 放大该动画的 SweepCheck 碰撞体半径与组件缩放。
        /// （MagicMod 里还有一堆针对特定 Boss 动画的写死子弹参数改写，属于个人定制，未迁移。）
        /// </summary>
        public static void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
        {
            string animationPath = Montage?.PathName ?? "";
            if (Montage == null || animationPath.Length == 0) return;

            int? configRadius = EventBindings.GetAddRadius(animationPath);
            if (configRadius == null) return; // 没有命中任何 SweepCheck 配置，不遍历 Notify
            int addRadius = configRadius.Value;

            // TArrayUnsafe 底层是 Marshal.AllocHGlobal 的非托管数组，必须 Dispose；
            // 光靠 finalizer 要等 GC，而 GC 感知不到非托管压力（每次播 Montage 一份，会一路涨）
            using (TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>())
            {
                UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, AnimNotifyEventList);
                if (AnimNotifyEventList == null || AnimNotifyEventList.Count == 0) return;

                foreach (FAnimNotifyEvent item in AnimNotifyEventList)
                {
                    if (item.NotifyStateClass is BANS_GSSweepCheck sweepCheck)
                    {
                        for (int i = 0; i < sweepCheck.SweepCheckShape.Count; i++)
                        {
                            var sweepItem = sweepCheck.SweepCheckShape[i];
                            var addNum = sweepItem.Radius < addRadius ? addRadius : sweepItem.Radius;
                            sweepItem.Radius = addNum;
                            var scaleNum = Math.Round(addNum / sweepItem.Radius, 3);
                            if (scaleNum > 1)
                            {
                                sweepItem.SKComp.SetRelativeScale3D(new FVector(scaleNum, scaleNum, scaleNum));
                            }
                            sweepCheck.SweepCheckShape[i] = sweepItem;
                        }
                    }
                    else if (item.NotifyName == DodgeWindowNotifyName || item.NotifyName == ComboWindowNotifyName)
                    {
                        item.LinkValue = 0.1f; // 触发时间设为 0.1 秒
                    }
                }
            }
        }

        /// <summary>
        /// 子弹命中监听：为本发子弹在其自身 BUS_EventCollectionCS 上挂 Evt_OnProjectileBeHitted，
        /// 命中敌人时执行配置在 bulletConfig.HitActions 里的一组动作。
        /// 子弹销毁时其 BUS_EventCollectionCS 一并销毁，订阅随之失效，无需手动反注册。
        /// </summary>
        private sealed class BulletHitWatcher
        {
            private readonly AActor _projectile;
            private readonly List<ActionConfig> _hitActions;
            private readonly BGUPlayerCharacterCS _owner;

            public BulletHitWatcher(AActor projectile, List<ActionConfig> hitActions, BGUPlayerCharacterCS owner)
            {
                _projectile = projectile;
                _hitActions = hitActions;
                _owner = owner;
            }

            public void Attach()
            {
                var be = BUS_EventCollectionCS.Get(_projectile);
                if (be == null) return;
                be.Evt_OnProjectileBeHitted += OnHit;
            }

            private void OnHit(AActor hitActor, List<int> hitEffects)
            {
                try
                {
                    ActionExecutor.DoActions(_owner, _hitActions);
                }
                catch (Exception e)
                {
                    Log.Error($"[ActionsMod] HitActions 执行失败: {e.Message}");
                }
            }
        }
    }
}
