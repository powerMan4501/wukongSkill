using System;
using System.Collections.Generic;
using System.Reflection;
using b1;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CSharpModBase;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 自定义变身（傀儡附身）系统。
    ///
    /// 背景：boss 单位不满足游戏原生"可玩家附身单位"要求，走 Evt_TriggerPlayerTransBegin 会报错。
    /// 本系统不碰原生变身表，改为：直接生成 boss 的 BUTamerActor 傀儡 → 隐藏真玩家 →
    /// 把镜头挂到 boss 骨骼 → 技能直接 cast 在 boss 上 → 由逐帧游戏钩子驱动跟随/移动。
    /// 做法参考 爬塔mod反编译/Wukong_Challenge/PlayerTransSystem.cs，但不引入其神力/血量/等级等限制。
    ///
    /// 由 <see cref="TransConfig.UseTamerPossess"/> 开关启用；所有 UE API 调用均在游戏线程执行。
    /// </summary>
    public static class CustomTransSystem
    {
        /// <summary>出招硬直门控 buff（爬塔验证可用的全局 ID）：释放招式后加此 buff，期间忽略同类输入</summary>
        private const int LockBuffId = 302371;

        /// <summary>禁止 AI 自动攻击 buff（爬塔 PlayerTransSystem 验证可用）：附身期间常驻，防止 boss 抓到目标就自动出招</summary>
        private const int DisableAIBuffId = 412108;

        /// <summary>移动驱动时目标点相对 boss 的距离</summary>
        private const float MoveDistance = 400f;

        /// <summary>spawn 后延迟多少秒才开始同步玩家锁定目标给 boss（避免刚生成就触发 AI 抓目标）</summary>
        private const float DelaySetTargetSeconds = 1.0f;


        // boss 当前血量 / 最大血量属性（与爬塔一致的数值 ID：151=当前HP，1=最大HP）
        private static readonly EBGUAttrFloat AttrHpCur = (EBGUAttrFloat)151;
        private static readonly EBGUAttrFloat AttrHpMax = (EBGUAttrFloat)1;

        private static BGUPlayerCharacterCS? _player;
        private static BUTamerActor? _boss;
        private static BGUCharacterCS? _bossActor;
        private static TransConfig? _current;
        private static readonly object _lock = new object();

        /// <summary>boss 傅儡是否已就绪（Mesh 加载完成，已挂镜头/加保命状态）</summary>
        private static bool _bossReady;
        
        /// <summary>DriveMove 首次驱动诊断日志标志（每次附身重置）</summary>
        private static bool _moveLogged;

        /// <summary>附身后剩余的目标同步延迟秒数（&gt;0 期间不把玩家锁定目标同步给 boss）</summary>
        private static float _delaySetTarget;

        /// <summary>附身开始时记录的玩家 Z（传送隐藏玩家时固定 Z，避免 boss 动画上下微动导致锁定相机参考点抖动）</summary>
        private static float _recordedZ;

        /// <summary>上一次已同步给 boss 的锁定目标原生地址（仅在目标变化时才触发 Evt_AICatchTarget，避免每 tick 重复“抓目标”反复驱动 AI）；0 表示无目标</summary>
        private static IntPtr _lastSyncedTargetAddr;

        // 镜头原挂载信息（用于结束时还原）
        private static USceneComponent? _origCamParent;
        private static FName _origCamSocket;

        // 各输入的连招索引
        private static int _lightIdx, _heavyIdx, _dodgeIdx, _spell1Idx, _spell2Idx, _spell3Idx;

        // 法术键 SkillID → 槽位(0/1/2) 的首见分配（QS/SF/HM 都以 UseSkillByType 触发，靠 SkillID 区分）
        private static readonly Dictionary<int, int> _spellSlotMap = new Dictionary<int, int>();

        /// <summary>是否处于傀儡附身状态</summary>
        public static bool IsActive { get; private set; }

        /// <summary>判断 UE 对象是否已失效（null 或原生已销毁）</summary>
        private static bool Gone(UObject? o) => o == null || o.IsNullOrDestroyed();

        /// <summary>属性优先、字段兜底地查找实例成员（CSharpLoader 绑定中不少成员是 property 而非 field）。
        /// 若属性只读（无 setter），回退寻找同名/常见变体字段写入，确保臂长等能被真正设置。</summary>
        private static (Func<object, object?> Get, Action<object, object?> Set)? FindMember(object obj, string name)
        {
            var t = obj.GetType();
            var p = t.GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (p != null && p.CanRead)
            {
                Func<object, object?> get = o => p.GetValue(o)!;
                Action<object, object?>? set = null;
                if (p.CanWrite) set = (o, v) => p.SetValue(o, v);
                else
                {
                    foreach (var fn in new[] { name, "_" + name, "m_" + name, "k" + name })
                    {
                        var bf = t.GetField(fn, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        if (bf != null && !bf.IsInitOnly) { set = (o, v) => bf.SetValue(o, v); break; }
                    }
                }
                return (get, set ?? ((o, v) => { }));
            }
            var f = t.GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (f != null)
                return (o => f.GetValue(o)!, (o, v) => f.SetValue(o, v));
            return null;
        }

        /// <summary>
        /// 开始附身：生成 boss 傀儡、隐藏真玩家、启动跟随 tick。镜头挂载/保命状态在 boss Mesh 就绪后于 Tick 中完成。
        /// </summary>
        public static void StartTrans(TransConfig cfg)
        {
            lock (_lock)
            {
                if (IsActive)
                {
                    Log.Warn("[CustomTrans] 已处于附身状态，请先变回再切换");
                    return;
                }

                var player = ModHelper.GetCharacter();
                if (player == null)
                {
                    Log.Warn("[CustomTrans] 未找到玩家角色，无法附身");
                    return;
                }
                UWorld world = player.World;
                if (world == null)
                {
                    Log.Warn("[CustomTrans] 世界为空，无法附身");
                    return;
                }

                // spawn 资源必须是 TAMER_ 蓝图，优先 PossessAssetPath，回退 TamerPath/BPPath
                string asset = !string.IsNullOrEmpty(cfg.PossessAssetPath) ? cfg.PossessAssetPath!
                    : (!string.IsNullOrEmpty(cfg.TamerPath) ? cfg.TamerPath! : (cfg.BPPath ?? ""));
                if (string.IsNullOrEmpty(asset))
                {
                    Log.Warn("[CustomTrans] 缺少傀儡资源路径(PossessAssetPath/TamerPath/BPPath)");
                    return;
                }

                UClass? cls = null;
                try { cls = ModUtils.LoadClass(asset); }
                catch (Exception e) { Log.Error($"[CustomTrans] 加载傀儡类异常 {asset}: {e.Message}"); }
                if (cls == null)
                {
                    Log.Warn($"[CustomTrans] 无法加载傀儡类(需 TAMER_ 蓝图): {asset}");
                    return;
                }

                FVector loc = player.GetActorLocation();
                FRotator rot = player.GetActorRotation();
                BUTamerActor? boss = null;
                try { boss = BGUFunctionLibraryCS.BGUSpawnActor(world, cls, loc, rot) as BUTamerActor; }
                catch (Exception e) { Log.Error($"[CustomTrans] 生成傀儡异常: {e.Message}"); }
                if (boss == null)
                {
                    Log.Warn($"[CustomTrans] 生成傀儡失败(可能不是 TAMER_ 蓝图): {asset}");
                    return;
                }

                // FTamerRef 初始化（OnlySpawn / _phase=Loaded / TamerType=2），复用现有工具方法
                try
                {
                    ModUtils.processIfBossCantSpawnNormaly(boss, loc);
                    float s = cfg.PossessScale > 0f ? cfg.PossessScale : 1.0f;
                    boss.CurrentRef.TamerTransform.Scale3D = new FVector(s, s, s);
                }
                catch (Exception e) { Log.Error($"[CustomTrans] tamer 初始化异常: {e.Message}"); }

                _player = player;
                _boss = boss;
                _current = cfg;
                _bossReady = false;
                _moveLogged = false;
                _delaySetTarget = DelaySetTargetSeconds;
                _recordedZ = loc.Z;
                _lastSyncedTargetAddr = IntPtr.Zero;
                _origCamParent = null;
                _origCamSocket = default(FName);
                _lightIdx = _heavyIdx = _dodgeIdx = _spell1Idx = _spell2Idx = _spell3Idx = 0;
                _spellSlotMap.Clear();
                try { _bossActor = boss.GetMonster(); } catch { _bossActor = null; }

                // 立即隐藏真玩家（不依赖 boss Mesh 是否就绪）
                ApplyPlayerHidden(true);

                IsActive = true;
                // 附身维护逻辑改为由逐帧游戏钩子（TickInputForMovingPatch → FrameTick）驱动，与渲染帧同步，
                // 避免 33ms Timer 跨线程派发与逐帧锁定相机不同步导致的抖动（对齐爬塔 OnTick 逐帧执行）。
                Log.Info($"[CustomTrans] 附身开始: name={cfg.name} asset={asset} scale={cfg.PossessScale}");
            }
        }

        /// <summary>逐帧逻辑（由 TickInputForMovingPatch 在游戏线程每帧调用）：维持隐藏/跟随、boss 保命、目标同步；boss 或玩家失效则自动结束</summary>
        public static void FrameTick(float DeltaTime)
        {
            if (!IsActive) return;

            var boss = _boss;
            var player = _player;
            if (Gone(boss) || Gone(player))
            {
                EndTrans();
                return;
            }

            // boss 傀儡的 monster 可能在 spawn 后异步就绪，这里轮询获取
            if (Gone(_bossActor))
            {
                try { _bossActor = boss!.GetMonster(); } catch { _bossActor = null; }
                if (_bossActor == null) return;
            }
            var bossActor = _bossActor!;

            // 首次就绪：挂镜头 + boss 保命/队伍
            if (!_bossReady && bossActor.Mesh != null)
            {
                _bossReady = true;
                ApplyBossStates();
                AttachCameraToBoss(_current?.CameraSocket ?? "pelvis");
            }

            try
            {
                // 玩家保持隐藏在 boss 身后（防止 boss 因距离被卸载 / 玩家坠落）。
                // Z 固定为附身开始时记录值，不跟随 boss 动画上下微动，避免锁定相机参考点抖动（对齐爬塔 ZLocation+100）。
                // 保留 forward*-40 的水平间距（对齐爬塔）：若玩家与 boss 完全重叠，作为锁定相机取景参考点会落在 boss 体内，导致取景/近clip剔除异常（boss 看不见）。
                FVector bLoc = bossActor.GetActorLocation();
                bLoc.Z = _recordedZ + 100f;
                FVector pLoc = bLoc + bossActor.GetActorForwardVector() * -40.0;
                // 旋转同步为 boss 朝向（对齐爬塔）：不保留玩家自身旋转，避免锁定时原生持续把玩家转向移动目标、参考点随之摆动造成战斗时抖动。
                player!.Teleport(pLoc, bossActor.GetActorRotation());

                var pev = BUS_EventCollectionCS.Get(player);
                // 每帧清空玩家所有 buff（对齐爬塔）：相机会依据玩家 buff 275 把取景参考点从稳定的 root 插槽切到随待机动画微动的 pelvis 插槽，
                // 导致锁定时瞄准点抖动。清空 buff 保证 Has275Buff=false、参考点恒为 root。附身期间玩家隐藏/免伤（走 SimpleState 非 buff），清 buff 无副作用。
                pev?.Evt_BuffAllRemove?.Invoke((EBuffEffectTriggerType)0);
                // 每帧固定相机臂 Z 偏移（对齐爬塔 Evt_SetPlayerCameraParam(8,70f)），稳定锁定相机高度
                pev?.Evt_SetPlayerCameraParam?.Invoke((EPlayerCameraTableParamType)8, 70f);

                // boss 血量维持满（配合 CantBeDead/CantBeDead1HP 双保险）
                if (BGUFunctionLibraryCS.GetAttrValue(bossActor, AttrHpCur) <= 10f)
                    BGUFunctionLibraryCS.BGUSetAttrValue(bossActor, AttrHpCur, BGUFunctionLibraryCS.GetAttrValue(bossActor, AttrHpMax));

                // 每 tick 刷新禁 AI buff（与目标同步同频，参考爬塔 PlayerTransSystem.OnTick 每帧刷新）。
                // 刷新频率过低会导致 boss 在锁定目标时被反复拉回战斗/转向逻辑，而镜头挂在 boss 骨骼上会随之抖动。
                if (!BGUFunctionLibraryCS.BGUHasBuffByID(bossActor, DisableAIBuffId))
                    BGUFunctionLibraryCS.BGUAddBuff(bossActor, bossActor, DisableAIBuffId, EBuffSourceType.GM, -1f);

                // spawn 后延迟一段时间再同步目标（避免刚生成就触发 AI）
                if (_delaySetTarget > 0f)
                {
                    _delaySetTarget -= DeltaTime;
                }
                else
                {
                    // 把玩家的锁定目标同步给 boss：仅在目标发生变化时才触发 Evt_AICatchTarget，
                    // 稳态不重复“抓目标”，避免每 tick 反复驱动 boss 朝向/战斗逻辑导致镜头抖动。
                    // 玩家无目标时显式清除 boss 目标，防止 boss 保留旧目标自动追击/出招。
                    AActor? target = BGUFunctionLibraryCS.BGUGetTarget(player);
                    IntPtr targetAddr = (target != null && !target.IsNullOrDestroyed()) ? target.Address : IntPtr.Zero;
                    if (targetAddr != _lastSyncedTargetAddr)
                    {
                        if (targetAddr != IntPtr.Zero)
                            BUS_EventCollectionCS.Get(bossActor)?.Evt_AICatchTarget?.Invoke(target!, ETargetSourceType.Target_AssignPlayerAsTarget);
                        else
                            BGUFunctionLibraryCS.BGUSetTargetInfo(false, bossActor, new UnitLockTargetInfo(null, ETargetSourceType.CameraLockUpdate));
                        _lastSyncedTargetAddr = targetAddr;
                    }
                }
            }
            catch (Exception e) { Log.Error($"[CustomTrans] Tick 异常: {e.Message}"); }
        }

        /// <summary>
        /// 输入触发出招：依输入类型取对应连招链，按索引循环释放；出招硬直(302371)期间忽略。
        /// </summary>
        /// <param name="type">输入类型</param>
        /// <param name="skillId">法术键携带的原技能 ID（用于区分 QS/SF/HM 三槽）</param>
        public static void OnInput(EInputActionType type, int skillId)
        {
            if (!IsActive || _current == null || Gone(_bossActor)) return;
            switch (type)
            {
                case EInputActionType.LightAttack:
                    CastCombo(_current.LightAttackCombo, ref _lightIdx);
                    break;
                case EInputActionType.HeavyAttack:
                    CastCombo(_current.HeavyAttackCombo, ref _heavyIdx);
                    break;
                case EInputActionType.Dodge:
                    // 通用闪避：保留位移、不接招式
                    if (_current.UseGeneralDodge) return;
                    CastCombo(_current.DodgeCombo, ref _dodgeIdx);
                    break;
                case EInputActionType.UseVigorSkill:
                case EInputActionType.UseSkillByType:
                case EInputActionType.CastItemSkill:
                    {
                        int slot = GetSpellSlot(skillId);
                        if (slot == 0) CastCombo(_current.Spell1Combo, ref _spell1Idx);
                        else if (slot == 1) CastCombo(_current.Spell2Combo, ref _spell2Idx);
                        else CastCombo(_current.Spell3Combo, ref _spell3Idx);
                    }
                    break;
            }
        }

        /// <summary>释放连招链的当前步：断开当前技能→清 CD→cast→加硬直 buff→索引前进循环</summary>
        private static void CastCombo(List<TransComboStep>? list, ref int idx)
        {
            if (list == null || list.Count == 0) return;
            var boss = _bossActor;
            if (boss == null) return;

            // 出招硬直门控：带锁定 buff 时忽略本次输入
            if (BGUFunctionLibraryCS.BGUHasBuffByID(boss, LockBuffId)) return;

            if (idx < 0 || idx >= list.Count) idx = 0;
            TransComboStep step = list[idx];
            try
            {
                BGUFunctionLibraryCS.BGUTriggerUnitState(boss, EBUStateTrigger.SkillBreak, -1f);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(boss, EBGUSimpleState.CancelSkillCD, false);
                BGUFunctionLibraryCS.BGUTryCastSpell(boss, step.SkillId, ECastSkillSourceType.Default);
                float lockTime = step.LockTime > 0f ? step.LockTime : 600f;
                BGUFunctionLibraryCS.BGUAddBuff(boss, boss, LockBuffId, EBuffSourceType.GM, lockTime);
            }
            catch (Exception e) { Log.Error($"[CustomTrans] 出招异常 skill={step.SkillId}: {e.Message}"); }

            idx = (idx + 1) % list.Count;
        }

        /// <summary>法术键 SkillID → 槽位(0/1/2)：按首次出现的顺序分配，使三个法术键各自循环一条连招链</summary>
        private static int GetSpellSlot(int skillId)
        {
            if (_spellSlotMap.TryGetValue(skillId, out int slot)) return slot;
            slot = _spellSlotMap.Count % 3;
            _spellSlotMap[skillId] = slot;
            return slot;
        }

        /// <summary>
        /// 移动驱动（由 TickInputForMovingPatch 的 Postfix 调用，运行在游戏线程）：
        /// 按镜头前/右向量合成世界方向，驱动 boss 傀儡移动并朝向。
        /// </summary>
        public static void DriveMove(in FVector MoveInputAxis, float DeltaTime)
        {
            if (!IsActive) return;
            var bossActor = _bossActor;
            var player = _player;
            if (bossActor == null || player == null) return;
            if (MoveInputAxis.X == 0f && MoveInputAxis.Y == 0f) return;

            try
            {
                var pc = ModUtils.GetPlayerController();
                if (pc == null || pc.PlayerCameraManager == null) return;
                var cam = pc.PlayerCameraManager;

                FVector fwd = cam.GetActorForwardVector() * MoveInputAxis.Y;
                FVector right = cam.GetActorRightVector() * MoveInputAxis.X;
                FVector dir = fwd + right;
                FVector bLoc = bossActor.GetActorLocation();
                FVector dest = bLoc + dir * MoveDistance;

                // 朝向：有锁定目标且非通用闪避时面向镜头方向，否则面向移动方向
                AActor? lockTarget = BGUFunctionLibraryCS.BGUGetTarget(player);
                bool hasLock = lockTarget != null && !lockTarget.IsNullOrDestroyed();
                bool useGeneralDodge = _current != null && _current.UseGeneralDodge;
                if (hasLock && !useGeneralDodge)
                {
                    FRotator camRot = cam.GetCameraRotation();
                    camRot.Pitch = 0f;
                    camRot.Roll = 0f;
                    bossActor.SetActorRotation(camRot, true);
                }
                else
                {
                    FRotator look = UMathLibrary.FindLookAtRotation(bLoc, dest);
                    look.Pitch = 0f;
                    look.Roll = 0f;
                    bossActor.SetActorRotation(look, false);
                }

                // MotionMatching 步态：必须为非 None，否则 boss 运动匹配 locomotion 会进 idle 而不移动（参考爬塔 EstateType）
                // 同时需与“是否有锁定目标”匹配：无锁定时 Lock* 步态会因找不到对应动画而不移动，需自动降为 Free*
                EState_MM mmState = ParseMMState(_current?.MoveMMState, hasLock);
                int moveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocationWithMM(bossActor, dest, EAIMoveSpeedType.SPRINT, 2f, EBGUMoveAIType.None, true, true, mmState);
                if (!_moveLogged)
                {
                    _moveLogged = true;
                    Log.Info($"[CustomTrans] DriveMove 首次驱动 hasLock={hasLock} mmState={mmState} moveIdx={moveIdx} axis=({MoveInputAxis.X:F2},{MoveInputAxis.Y:F2}) dest={dest}");
                }
            }
            catch (Exception e) { Log.Error($"[CustomTrans] DriveMove 异常: {e.Message}"); }
        }

        /// <summary>
        /// 取消 boss 当前的 AI 移动请求（由 InputActionTriggerPatch 在 IA_B1MoveForward/IA_B1MoveSideways 的 Completed 事件时调用）。
        /// 参考爬塔 PlayerTransSystem.hookOnInputCastSkill：松开 WASD 后必须取消，否则 boss 会一直走向最后目的地，新按键也可能被旧请求屏蔽。
        /// </summary>
        public static void CancelMove()
        {
            if (!IsActive) return;
            var bossActor = _bossActor;
            if (bossActor == null) return;
            try { BGUFuncLibAICS.BGUCancelAICurrentMove(bossActor); }
            catch (Exception e) { Log.Error($"[CustomTrans] CancelMove 异常: {e.Message}"); }
        }

        /// <summary>
        /// 解析配置的 MoveMMState 字符串为 EState_MM（大小写不敏感），非法/空/None 则回退 LockRun。
        /// hasLock=false 且配的是 Lock* 系列时，自动降为对应的 Free* 系列（LockRun→FreeRun、LockWalk→FreeWalk、LockSprint→FreeSprint），
        /// 避免无锁定目标时 MotionMatching 找不到匹配动画导致 boss 不移动。
        /// </summary>
        private static EState_MM ParseMMState(string? s, bool hasLock)
        {
            EState_MM v;
            if (!string.IsNullOrEmpty(s) && Enum.TryParse<EState_MM>(s, true, out var parsed) && parsed != EState_MM.None)
                v = parsed;
            else
                v = EState_MM.LockRun;

            if (!hasLock)
            {
                switch (v)
                {
                    case EState_MM.LockRun: return EState_MM.FreeRun;
                    case EState_MM.LockWalk: return EState_MM.FreeWalk;
                    case EState_MM.LockSprint: return EState_MM.FreeSprint;
                    case EState_MM.Lock: return EState_MM.Free;
                }
            }
            return v;
        }

        /// <summary>
        /// 结束附身：还原玩家（显形/碰撞/重力/状态、镜头归位、传送到 boss 处）、注销 tamer、停 tick、清状态。
        /// </summary>
        public static void EndTrans()
        {
            lock (_lock)
            {
                if (!IsActive && _player == null && _boss == null) return;
                IsActive = false;

                var player = _player;
                var boss = _boss;
                var bossActor = _bossActor;
                try
                {
                    if (player != null && !player.IsNullOrDestroyed())
                    {
                        // 镜头还原到玩家
                        RestoreCamera();
                        // 传送到 boss 位置，避免玩家留在原地/悬空
                        if (bossActor != null && !bossActor.IsNullOrDestroyed())
                            player.Teleport(bossActor.GetActorLocation(), bossActor.GetActorRotation());
                        // 恢复显形/碰撞/重力/移除免伤
                        ApplyPlayerHidden(false);
                    }
                    // 注销 tamer（移除傀儡）
                    if (boss != null && !boss.IsNullOrDestroyed() && player != null)
                        BGS_EventCollectionCS.Get(player.World)?.Evt_UnregisterTamer.Invoke(boss.CurrentRef);
                }
                catch (Exception e) { Log.Error($"[CustomTrans] EndTrans 异常: {e.Message}"); }

                _player = null;
                _boss = null;
                _bossActor = null;
                _current = null;
                _bossReady = false;
                _lastSyncedTargetAddr = IntPtr.Zero;
                _origCamParent = null;
                _origCamSocket = default(FName);
                _spellSlotMap.Clear();
                Log.Info("[CustomTrans] 附身结束，玩家已恢复");
            }
        }

        /// <summary>隐藏/恢复真玩家：暂停动画、隐藏、碰撞、重力、免伤/免翻滚</summary>
        private static void ApplyPlayerHidden(bool hidden)
        {
            var player = _player;
            if (player == null) return;
            try
            {
                var ev = BUS_EventCollectionCS.Get(player);
                ev?.Evt_SetBoolProperty?.Invoke(EPropType.Mesh_PauseAnims, hidden);
                ev?.Evt_SetBoolProperty?.Invoke(EPropType.Actor_ActorHiddenInGame, hidden);
                player.SetActorEnableCollision(!hidden);
                var movement = player.CharacterMovement;
                if (movement != null) movement.GravityScale = hidden ? 0f : 4f;
                // hidden=true 时加免伤/免翻滚(IsRemove=false)；恢复时移除(IsRemove=true)
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.ImmueDamage, !hidden);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill, !hidden);
            }
            catch (Exception e) { Log.Error($"[CustomTrans] ApplyPlayerHidden 异常: {e.Message}"); }
        }

        /// <summary>boss 傀儡保命 + 与玩家同队（避免互殴、避免被击杀导致附身中断）+ 封 AI（避免自动追击/出招）</summary>
        private static void ApplyBossStates()
        {
            var bossActor = _bossActor;
            if (bossActor == null) return;
            try
            {
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(bossActor, EBGUSimpleState.CantBeDead, false);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(bossActor, EBGUSimpleState.CantBeDead1HP, false);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(bossActor, EBGUSimpleState.CantBeLock, false);
                bossActor.SetTeamIDInCS(1);

                // 封 AI：关闭感知 + 暂停行为树（参考爬塔 SpawnActorSystem 对友方 tamer 的做法）
                // 保证 boss 完全由玩家手动驱动出招，不会因锁定目标而自动追击/攻击
                var ev = BUS_EventCollectionCS.Get(bossActor);
                ev?.Evt_AIPerceptionSetting?.Invoke(false);
                ev?.Evt_AIPauseBT?.Invoke(true);

                // 双保险：加禁 AI 自动攻击 buff（爬塔 PlayerTransSystem 验证可用）
                BGUFunctionLibraryCS.BGUAddBuff(bossActor, bossActor, DisableAIBuffId, EBuffSourceType.GM, -1f);
            }
            catch (Exception e) { Log.Error($"[CustomTrans] ApplyBossStates 异常: {e.Message}"); }
        }

        /// <summary>把玩家镜头弹簧臂挂到 boss Mesh 的指定插槽，并记录原挂载以便还原</summary>
        private static void AttachCameraToBoss(string socket)
        {
            var player = _player;
            var bossActor = _bossActor;
            if (player == null || bossActor == null) return;
            try
            {
                var boom = (USceneComponent)(object)player.CameraBoom1;
                if (boom == null) return;
                USceneComponent? mesh = bossActor.Mesh;
                if (mesh == null) return;

                // 记录原挂载
                _origCamParent = boom.GetAttachParent();
                _origCamSocket = boom.GetAttachSocketName();

                if (string.IsNullOrEmpty(socket)) socket = "pelvis";
                boom.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, true);
                boom.AttachToComponent(mesh, new FName(socket), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true);

                // 巨型 Boss 的 Mesh 插槽(pelvis)在身体内部，需按 Boss 实际尺寸拉远相机臂长退出身体，否则看不见外界（贴脸）。
                // 注意：CSharpLoader 绑定中 TargetArmLength/RelativeLocation/CapsuleHalfHeight 多为属性（property），
                // 不能只用 GetField 反射，否则取不到成员、臂长从未生效（表现为视角贴脸、Boss 堵满整个屏幕）。
                try
                {
                    var armM = FindMember(boom, "TargetArmLength");
                    if (armM == null)
                    {
                        Log.Warn("[CustomTrans] CameraBoom 上未找到 TargetArmLength（属性/字段都没有），臂长未拉远");
                    }
                    else
                    {
                        // 距离倍数（CameraDistanceMul 为值类型，JSON 缺字段时为 0，必须显式回退默认而非依赖 ??）
                        float mul = _current?.CameraDistanceMul ?? 0f;
                        if (mul <= 0f) mul = 3.0f;
                        // 基准臂长：即便取不到 Boss 尺寸也保证足够远（巨型 Boss 不被贴脸）
                        float baseArm = 2500f * mul;
                        float camArm = baseArm;
                        try
                        {
                            var cap = (object?)(bossActor.GetType().GetProperty("CapsuleComponent")?.GetValue(bossActor))
                                      ?? bossActor.GetType().GetField("CapsuleComponent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(bossActor);
                            if (cap != null)
                            {
                                var hhM = FindMember(cap, "CapsuleHalfHeight");
                                if (hhM != null && hhM.Value.Get(cap) is float f && f > 0f)
                                    camArm = Math.Max(f * 4f * mul, baseArm);
                            }
                        }
                        catch (Exception ex) { Log.Warn($"[CustomTrans] 取 Boss 尺寸失败: {ex.Message}"); }
                        // 显式 CameraArmLength 覆盖自动计算
                        if ((_current?.CameraArmLength ?? 0f) > 0f) camArm = _current!.CameraArmLength!.Value;
                        float cur = (float)(armM.Value.Get(boom) ?? 0f);
                        armM.Value.Set(boom, Math.Max(cur, camArm));
                        float after = (float)(armM.Value.Get(boom) ?? 0f);
                        Log.Info($"[CustomTrans][camset] mul={mul} baseArm={baseArm} camArm={camArm} cur={cur} afterSet={after}");
                        // 关闭相机碰撞测试：否则巨型 Boss 自身碰撞体把相机臂挡到贴脸（即使臂长设很大也被收紧）
                        try
                        {
                            var ctM = FindMember(boom, "bDoCollisionTest");
                            if (ctM != null) ctM.Value.Set(boom, false);
                        }
                        catch { }
                        // 相机相对挂载插槽的偏移（X 前后 / Y 左右 / Z 抬高），全部可配置
                        float hOff = _current?.CameraHeightOffset ?? 0f;
                        float xOff = _current?.CameraOffsetX ?? 0f;
                        float yOff = _current?.CameraOffsetY ?? 0f;
                        if (hOff != 0f || xOff != 0f || yOff != 0f)
                        {
                            var rlM = FindMember(boom, "RelativeLocation");
                            if (rlM != null && rlM.Value.Get(boom) is FVector v)
                            {
                                v.X += xOff;
                                v.Y += yOff;
                                v.Z += hOff;
                                rlM.Value.Set(boom, v);
                            }
                            else
                            {
                                Log.Warn("[CustomTrans] CameraBoom 上未找到 RelativeLocation，相机偏移未生效");
                            }
                        }
                        Log.Info($"[CustomTrans][cam] socket={socket} arm={(float)(armM.Value.Get(boom) ?? 0f)}");
                    }
                }
                catch (Exception ex) { Log.Warn($"[CustomTrans] 设置相机臂长失败: {ex.Message}"); }
            }
            catch (Exception e) { Log.Error($"[CustomTrans] 镜头挂载异常: {e.Message}"); }
        }

        /// <summary>把玩家镜头弹簧臂还原到原挂载（无记录则回退到玩家根组件 pelvis）</summary>
        private static void RestoreCamera()
        {
            var player = _player;
            if (player == null) return;
            try
            {
                var boom = (USceneComponent)(object)player.CameraBoom1;
                if (boom == null) return;

                USceneComponent? parent = _origCamParent;
                FName socket = _origCamSocket;
                if (parent == null || parent.IsNullOrDestroyed())
                {
                    parent = player.GetRootComponent();
                    socket = new FName("pelvis");
                }
                if (parent == null) return;

                boom.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, true);
                boom.AttachToComponent(parent, socket, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true);
            }
            catch (Exception e) { Log.Error($"[CustomTrans] 镜头还原异常: {e.Message}"); }
        }
    }
}
