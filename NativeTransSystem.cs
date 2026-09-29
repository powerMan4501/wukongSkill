using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CSharpModBase;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 原生变身系统：走游戏自己的 PlayerTrans（变身）流程，而不是"隐藏玩家 + 生成傀儡"的外挂实现。
    ///
    /// 游戏原生变身链路（见 b1 反编译）：
    ///   BPS_EventCollectionCS.Evt_TriggerPlayerTransBegin(beginType, param)
    ///     → BPS_TransSystemServer.OnPlayerTransBegin             (main/b1/BPS_TransSystemServer.cs)
    ///       → CheckCanTrans 后走 DoTransLogic：
    ///         默认分支 → Evt_TransBeginSpawnNewOne(TargetResId, BornSkillId, NeedBlend, beginType)
    ///           → BUS_PlayerTransComp.TriggerTransit             (main/b1/BUS_PlayerTransComp.cs)
    ///             → 读 FUStUnitTransCommDesc(当前ResID) 和 (目标ResID)，取目标 BPPath 加载 UClass
    ///             → SpawnAndPossessTransUnit → BGUFuncLibPlayer.SpwanAndPossesPlayerContrlledPawn
    ///               PC.Possess(新Pawn) + Evt_BPS_SwitchPlayerTransState(OldActor, TargetResId)（在 BeginPlay 前回调）
    ///             → TransferData：继承可传承 Buff / 重绑数据 / 通知单位切换
    ///             → DestroyOldUnit：隐藏旧单位 + Evt_UnitDead(EDeadReason.PlayerTrans)
    ///   结束：BPS_EventCollectionCS.Evt_TriggerPlayerTransEnd(endType, param) → TransBackSpawnNewOne 变回本尊。
    ///
    /// 关键限制：`PlayerControllerSystemBase.GetControlledPlayerCharacter()` 是
    /// `GetControlledPawn() as BGUPlayerCharacterCS`，游戏大量变身/转身相关系统都靠它拿当前角色，
    /// 因此原生变身的目标单位**最好是 BGUPlayerCharacterCS 子类**（游戏自带的变身单位都是，
    /// 见 BGUPlayerCharacterCS.Initialize 里 UnitTemplateType = EUnitTagType.TransitionPlayer）。
    /// 普通 Boss 单位不满足，直接 Direct 变身后续 부分 PDT 系统会失灵，故提供两种模式：
    ///   1) Reskin：变身到 BaseResId（原生可用单位）→ 变身完成后用 soulBossConfig 的幻化配置换外观
    ///      （受击/死亡/HUD/UI 全走原生），招式再用 Combo 链重定向。
    ///   2) Direct：注入 FUStUnitTransCommDesc 后直接变身到 BPPath 指向的单位，并尽量补齐
    ///      输入组件 / 相机 / 阵营，属于实验性路径。
    ///
    /// 全程不使用 Harmony 补丁（本机 EnableJit=0 补丁不生效）。
    /// </summary>
    public static class NativeTransSystem
    {
        /// <summary>出招硬直门控 buff：释放招式后加此 buff，期间忽略同类输入</summary>
        private const int LockBuffId = 302371;

        /// <summary>禁止 AI 自动攻击 buff</summary>
        private const int DisableAIBuffId = 412108;

        /// <summary>缺省的结束变身类型（SettingransBack：直接变回本尊、不播退出动画，且不受剧情限制）</summary>
        private const int DefaultTransBackEndType = (int)EPlayerTransEndType.SettingransBack;

        /// <summary>守护轮询间隔（毫秒）：检测变身单位是否死亡/失效</summary>
        private const int WatchdogIntervalMs = 40;

        /// <summary>变身完成后的延迟处理（毫秒）：此时新单位已经 BeginPlay，适合换皮/补组件</summary>
        private const int PostSetupDelayMs = 400;

        private static readonly object _lock = new object();

        private static BGP_PlayerControllerB1? _pc;
        private static APlayerState? _hookedPs;
        private static BGUPlayerCharacterCS? _originPlayer;
        private static BGUCharacterCS? _unit;
        private static BUTamerActor? _tamer = null;
        // TAMER 外壳的 GUID：销毁时要拿它走 Evt_RequestDestroyUnit，才能把 FTamerRef 从 TamerManager 里摘掉
        private static string _tamerGuid = "";
        private static TransConfig? _cfg;
        private static string _mode = "";
        private static int _teamId = 1;
        private static bool _pendingBegin;
        private static DateTime _beginTime;

        // 补挂的相机组件（结束时销毁）
        private static USceneComponent? _armComp;
        private static USceneComponent? _camComp;

        // Direct 模式：把玩家(悟空)的 CameraBoom 改挂到 boss Mesh 骨骼时，记录原挂载以便变回还原
        private static USceneComponent? _origCamParent;
        private static FName _origCamSocket = new FName("pelvis");

        // 相机臂长：CameraBoom.TargetArmLength 会被相机系统（BUS_PlayerCameraCompImpl）每帧按
        // BUC_CameraState 的默认臂长重算覆盖（b1/BUS_PlayerCameraCompImpl.cs:718），
        // 所以拉远相机必须同时改相机系统的数据源，只改组件属性会被打回原值（表现：视角贴脸、Boss 堵满屏幕）。
        private static float _camArmTarget;
        private static bool _camArmApplied;
        private static float _origArmLenDefault = -1f;
        private static float _origArmLenClose = -1f;
        private static float _origArmLenNormal = -1f;
        private static float _origArmLenFar = -1f;
        private static float _origArmLenSpeed = -1f;

        // 相机相对位置（'=DefaultArmLocation' 里的 X/Y/Z），同样会被相机系统每帧用(boom.SetRelativeLocation)覆盖
        private static FVector _camRelOffset = FVector.ZeroVector;
        private static bool _camRelApplied;
        private static FVector _origDefaultArmLocation = FVector.ZeroVector;
        private static float _origArmLocationZ = -1f;

        // 隐藏本尊前的组件级隐藏状态（actor 隐藏会把所有组件置成 bHiddenInGame=true，之后无法区分原始值）
        private static readonly Dictionary<IntPtr, bool> _playerHiddenBefore = new Dictionary<IntPtr, bool>();

        // 各输入的连招索引
        private static int _lightIdx, _heavyIdx, _dodgeIdx, _spell1Idx, _spell2Idx, _spell3Idx;
        private static readonly Dictionary<int, int> _spellSlotMap = new Dictionary<int, int>();

        private static Timer? _postTimer;
        private static Timer? _watchdog;
        private static int _tickCount = 0;

        /// <summary>是否已有"已投递但还没在游戏线程执行完"的守护 tick（0/1，Interlocked 操作），用于去重防止 40ms 高频下回调堆积</summary>
        private static int _watchdogPending = 0;

        /// <summary>是否处于原生变身状态（当前操控的单位已换成变身单位）</summary>
        public static bool IsActive { get; private set; }

        /// <summary>当前变身单位（无效/debuff 状态下可能为 null）</summary>
        public static BGUCharacterCS? Unit => _unit != null && !_unit.IsNullOrDestroyed() ? _unit : null;

        /// <summary>当前生效的配置</summary>
        public static TransConfig? Current => _cfg;

        /// <summary>当前实际使用的模式字符串（Reskin / Direct）</summary>
        public static string Mode => _mode;

        private static bool Gone(UObject? o) => o == null || o.IsNullOrDestroyed();

        // ---------------------------------------------------------------- 对外接口

        /// <summary>
        /// 开始一次原生变身。命中 transConfig 配置时按其模式处理。
        /// </summary>
        public static void StartTrans(TransConfig cfg)
        {
            lock (_lock)
            {
                if (IsActive)
                {
                    Log.Warn("[NativeTrans] 已处于变身状态，请先变回再切换");
                    return;
                }
                if (cfg == null || cfg.ID <= 0)
                {
                    Log.Warn("[NativeTrans] TransConfig 无效");
                    return;
                }

                BGP_PlayerControllerB1? pc = null;
                APawn? pawn = null;
                try
                {
                    pc = ModUtils.GetPlayerController();
                    if (pc != null && !pc.IsNullOrDestroyed()) pawn = pc.GetControlledPawn();
                }
                catch (Exception e) { Log.Error($"[NativeTrans] 获取玩家失败: {e.Message}"); }

                if (Gone(pc) || Gone(pawn))
                {
                    Log.Warn("[NativeTrans] 未找到玩家/控制器，无法变身");
                    return;
                }

                string mode = ResolveMode(cfg, out int baseResId);
                if (mode == "Reskin")
                {
                    // 基底 ResID 必须是游戏原生已有的变身单位，不能误注入覆盖
                    if (BGW_GameDB.GetUnitTransCommDesc(baseResId) == null)
                    {
                        Log.Error($"[NativeTrans] BaseResId={baseResId} 在游戏 UnitTransCommDesc 表中不存在，" +
                                  "请填一个游戏自带的变身单位 ResID（可用面板/日志里的 DumpTrans 查看）");
                        return;
                    }
                }
                else
                {
                    // Direct：需要注入自定义变身描述
                    if (!ActionExecutor.EnsureTransDescInjected(cfg.ID))
                    {
                        Log.Warn($"[NativeTrans] 变身描述注入失败，无法变身 TransID={cfg.ID}");
                        return;
                    }
                }

                _pc = pc;
                _originPlayer = pawn as BGUPlayerCharacterCS;
                _cfg = cfg;
                _mode = mode;
                _teamId = ((BGUCharacterCS)pawn!).GetTeamIDInCS();
                if (_teamId <= 0) _teamId = 1;
                ResetCombo();

                HookTransSwitch(pc!);

                // Direct：自定义生成新角色（支持 Boss 等非玩家类单位），绕过游戏原生变身系统对玩家类的依赖
                if (mode == "Direct")
                {
                    _beginTime = DateTime.Now;
                    DirectSpawnAndPossess(pc!, cfg);
                    return;
                }

                // Reskin / 原生变身：走游戏自己的 Evt_TriggerPlayerTransBegin
                int targetResId = baseResId;
                int beginType = cfg.TransBeginType ?? (int)EPlayerTransBeginType.Plot;
                var param = new PlayerTransParam
                {
                    TargetResId = targetResId,
                    SpawnSkillId = cfg.SpawnSkillId ?? 0,
                    NeedBlend = cfg.NeedBlend,
                };

                _pendingBegin = true;
                _beginTime = DateTime.Now;
                Log.Info($"[NativeTrans] 发起原生变身 mode={mode} TransID={cfg.ID} TargetResId={targetResId} " +
                         $"beginType={(EPlayerTransBeginType)beginType} blend={cfg.NeedBlend}");

                try
                {
                    var bps = BPS_EventCollectionCS.Get(pc!.PlayerState);
                    if (bps == null)
                    {
                        Log.Error("[NativeTrans] 获取 BPS_EventCollection 失败");
                        _pendingBegin = false;
                        return;
                    }
                    bps.Evt_TriggerPlayerTransBegin.Invoke((EPlayerTransBeginType)beginType, param);
                }
                catch (Exception e)
                {
                    _pendingBegin = false;
                    Log.Error($"[NativeTrans] 触发变身异常: {e.Message}");
                }
            }
        }

        /// <summary>
        /// Direct 模式：用游戏 API 直接生成指定 BPPath 的 Boss 单位，并保持 PC 仍控制已隐藏的悟空，
        /// 由输入驱动 boss 出招（不调用 PC.Possess(boss)）。
        /// 这样避开 Boss 单位走"玩家受控化"ECS 初始化（SpwanAndPossesPlayerContrlledPawn 内部
        /// BGUFinishSpawningActorAndECSBeginPlay 对缺玩家组件的单位空引用）的崩溃，同时 boss 正常受击/死亡。
        /// </summary>
        private static void DirectSpawnAndPossess(BGP_PlayerControllerB1 pc, TransConfig cfg)
        {
            try
            {
                UClass? bpClass = null;
                try { bpClass = ModUtils.LoadClass(cfg.BPPath); }
                catch (Exception e) { Log.Error($"[NativeTrans] 加载变身单位类失败 {cfg.BPPath}: {e.Message}"); }
                if (bpClass == null)
                {
                    Log.Error($"[NativeTrans] 变身单位 BPPath 加载失败，请检查路径是否正确: {cfg.BPPath}");
                    return;
                }

                var origin = _originPlayer;
                FVector loc = (Gone(origin) ? pc.GetControlledPawn()?.GetActorLocation() : origin!.GetActorLocation()) ?? FVector.ZeroVector;
                FRotator rot = Gone(origin) ? FRotator.ZeroRotator : origin!.GetActorRotation();
                // spawn 在玩家上方偏移处：巨型 Boss 的胶囊若直接生成在悟空位置会与受控 Pawn 重叠，
                // UE 的 Pawn 分离会把悟空从 Boss 体内弹出导致"疯狂前飞"。偏移生成后由 Watchdog 每帧瞬移跟随。
                loc = loc + new FVector(0f, 0f, 600f);

                // 游戏内置 Boss 变身机制：直接 SpawnActor/Deferred spawn 造 BGUCharacterCS Boss 都会 NRE（ECS entity 无法创建），
                // 必须造 TAMER 外壳，由它内部 MarkAsSpawnedTamer 流程创建并持有真正的 Boss（ECS 完整）。
                // 这里 spawn TAMER，再用 GetMonster() 取真正的 Boss 交给玩家 Possess。BPPath 必须填 TAMER_ 蓝图。
                //
                // 【顺序必须严格照官方 RequestSpawnUnit（main/b1/BGU_UnrealWorldUtil.cs:68-90）】
                //   BGUBeginDeferredActorSpawnFromClass  → 延迟生成，此刻还没 BeginPlay
                //   → MarkAsSpawnedTamer                 → 在 BeginPlay 之前把 TamerType 切成 Spawned
                //   → BGUFinishSpawningActor             → 这时才触发 BeginPlay → FTamerRef.Load → 注册到 SpawnedTamerStrategy
                // 旧写法用 BGUSpawnActor（非延迟）先跑完 BeginPlay 再 Mark：BeginPlay 时 TamerType 还是默认 LevelLoaded，
                // 会被注册进关卡怪的 ProcessChainTamerStrategy，之后又对已完成的 actor 再调一次 FinishSpawning。
                // 这会把这只变身 Boss 混进"关卡怪按距离加载/卸载"的处理链（该链在线程池跑且整条被 catch 吞异常），
                // 同帧其它关卡 Tamer 得不到推进、卡在 Visible/PreBegunPlay（单位 Actor 已生成但 ECS 没 BeginPlay）→ 打不死。
                Log.Info($"[NativeTrans] 自定义生成变身单位(外壳) BPPath='{cfg.BPPath}'");
                var tf = new FTransform(rot, loc, new FVector(1f, 1f, 1f));
                BUTamerActor? tamer = null;
                try
                {
                    tamer = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(
                        pc.World, new TSubclassOf<AActor>(bpClass), tf,
                        ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
                }
                catch (Exception e) { Log.Error($"[NativeTrans] 生成 TAMER 异常: {e.Message}"); }
                if (tamer == null)
                {
                    Log.Error($"[NativeTrans] 生成 TAMER 失败（BPPath 需为 TAMER_ 蓝图，当前可能填了 Unit_ 蓝图）: {cfg.BPPath}");
                    return;
                }

                try
                {
                    // 强制唯一 GUID：MarkAsSpawnedTamer 内部 GetFinalGuid() 会优先取蓝图配置的 UnitFixedGuid，
                    // 运行时从 BP Class 生成的 Tamer 拿到的是类默认固定 GUID，可能与关卡里同蓝图的实例撞号；
                    // 撞号时 FTamerRef.Load 会走 OnReload 劫持已有的 TamerRef（main/b1/FTamerRef.cs:279-282）。
                    // 先灌一个随机 GUID 进 SpawnedTamerGuid，GetFinalGuid() 会直接返回它，彻底规避撞号。
                    var guidComp = tamer.GetComponentByClass<BUS_GuidComp>();
                    guidComp?.GenerateRandomGuid();
                    if (guidComp != null && !string.IsNullOrEmpty(guidComp.UnitRandomGuid))
                        tamer.SpawnedTamerGuid = guidComp.UnitRandomGuid;

                    tamer.MarkAsSpawnedTamer(null);
                    // 只有这一次 FinishSpawning：由它触发 BeginPlay 完成 TAMER 注册
                    UBGUFunctionLibrary.BGUFinishSpawningActor(tamer, tf);
                    // ModUtils.processIfBossCantSpawnNormaly(tamer, loc);
                    BGUFuncLibAICS.SearchTargetSP(tamer);
                }
                catch (Exception e) { Log.Error($"[NativeTrans] TAMER 初始化异常: {e.Message}"); }

                _tamer = tamer;
                try { _tamerGuid = tamer.GetFinalGuid() ?? ""; }
                catch (Exception e) { Log.Warn($"[NativeTrans] 读取 TAMER Guid 失败: {e.Message}"); _tamerGuid = ""; }
                _mode = "Direct";
                // 在 Boss 落地/就绪前就先把本尊隐藏并关闭其碰撞：这样 TAMER 内部 Boss 落地或随后每帧跟随到本尊位置时，
                // 不会因胶囊重叠把受控的悟空弹飞（关键防"疯狂前飞"）。Boss 自身碰撞保持开启（受击正常、不穿空气墙）。
                try { HideOriginPlayer(_originPlayer); }
                catch (Exception e) { Log.Error($"[NativeTrans] 预隐藏本尊失败: {e.Message}"); }
                Log.Info($"[NativeTrans] 变身进行中，等待 TAMER 内部 Boss 就绪...");

                // TAMER 内部 Boss 是异步出怪（通常 2~5 秒），不阻塞变身触发线程：
                // 用 Task 轮询，GetMonster() 就绪后在游戏线程完成 Possess。
                Task.Run(async () =>
                {
                    BGUCharacterCS? u = null;
                    foreach (int delay in new[] { 200, 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 5000 })
                    {
                        await Task.Delay(delay);
                        bool ready = false;
                        Utils.TryRunOnGameThread(() =>
                        {
                            try
                            {
                                u = tamer.GetMonster() as BGUCharacterCS;
                                if (u != null) { FinalizeDirect(pc, tamer, u, cfg); ready = true; }
                            }
                            catch { }
                        });
                        if (ready) return;
                    }
                    Log.Error("[NativeTrans] TAMER 内部 Boss 未就绪（超时 5s），变身失败，恢复本尊");
                    Utils.TryRunOnGameThread(() =>
                    {
                        DestroyTamerShell(tamer);
                        try
                        {
                            if (_originPlayer != null)
                            {
                                _originPlayer.SetActorHiddenInGame(false);
                                _originPlayer.SetActorEnableCollision(true);
                            }
                        }
                        catch { }
                        _tamer = null;
                        _mode = "";
                        IsActive = false;
                    });
                });
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 自定义生成变身异常: {e}"); }
        }

        /// <summary>Direct 模式：TAMER 内部 Boss 就绪后在游戏线程完成"玩家化"（由异步轮询调用）</summary>
        private static void FinalizeDirect(BGP_PlayerControllerB1 pc, BUTamerActor tamer, BGUCharacterCS u, TransConfig cfg)
        {
            // Direct 模式直接 Possess Boss（与旧版 CustomTransSystem 一致）：让 Boss 成为受控 Pawn，
            // 玩家直接操控 Boss 移动/出招；悟空已隐藏且无碰撞，仅由 Watchdog 每帧 teleport 跟随 Boss（变回时归位）。
            // 若不 Possess（保持悟空受控），悟空隐藏后仍被移动系统驱动，而 Boss 又跟随悟空，表现为"自动前飞"。
            try { pc.Possess(u); }
            catch (Exception e) { Log.Error($"[NativeTrans] Possess Boss 异常: {e.Message}"); }
            // 清空 Boss 出生冲撞速度，避免无操作时自动漂移
            try
            {
                var mc = u.GetComponentByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UCharacterMovementComponent>()) as UCharacterMovementComponent;
                if (mc != null) mc.Velocity = FVector.ZeroVector;
            }
            catch (Exception ex) { Log.Warn($"[NativeTrans] 清 Boss 速度失败: {ex.Message}"); }
            ActivateUnit(u);
            Log.Info($"[NativeTrans] 自定义变身完成 Unit='{u.GetName()}' Tamer='{tamer.GetName()}'");
        }

        /// <summary>Direct 模式：变身时隐藏本尊（不销毁，变回时恢复）</summary>
        private static void HideOriginPlayer(BGUCharacterCS? u)
        {
            if (Gone(u)) return;
            try
            {
                // 先记录各组件的原始隐藏状态并关碰撞（必须在 SetActorHiddenInGame 之前读，
                // 否则所有组件都已经是 bHiddenInGame=true，恢复时会把本该隐藏的辅助/调试组件显示出来）
                try
                {
                    var primCls = UClass.GetClass<UPrimitiveComponent>();
                    _playerHiddenBefore.Clear();
                    foreach (var c in u.GetComponentsByClass((TSubclassOf<UActorComponent>)primCls))
                    {
                        if (c is not UPrimitiveComponent prim) continue;
                        var h = GetCompHidden(prim);
                        if (h.HasValue) _playerHiddenBefore[prim.Address] = h.Value;
                        // 直接关所有 PrimitiveComponent（含胶囊）碰撞：BGUCharacterCS 的碰撞挂在胶囊组件上，
                        // 仅靠 SetActorEnableCollision 可能关不掉，导致 Boss 每帧跟随到悟空位置时把悟空弹出（"自动前飞"）。
                        prim.SetCollisionEnabled(ECollisionEnabled.NoCollision);
                    }
                    Log.Info($"[NativeTrans] 已记录本尊组件隐藏状态 {_playerHiddenBefore.Count} 个");
                }
                catch (Exception ex) { Log.Warn($"[NativeTrans] 关本尊组件碰撞失败: {ex.Message}"); }

                u!.SetActorHiddenInGame(true);
                u.SetActorEnableCollision(false);
                // 清空移动速度，避免变身瞬间冲撞残留导致持续前飞
                try
                {
                    var mc = u.GetComponentByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UCharacterMovementComponent>()) as UCharacterMovementComponent;
                    if (mc != null) mc.Velocity = FVector.ZeroVector;
                }
                catch (Exception ex) { Log.Warn($"[NativeTrans] 清本尊速度失败: {ex.Message}"); }
                var ev = BUS_EventCollectionCS.Get(u);
                ev?.Evt_SetBoolProperty?.Invoke(EPropType.Mesh_PauseAnims, true);
                ev?.Evt_BuffAllRemove?.Invoke((EBuffEffectTriggerType)0);
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 隐藏本尊异常: {e.Message}"); }
        }

        /// <summary>Direct 模式：变回时销毁当前 Boss 单位</summary>
        private static void DestroyCurrentUnit(BGUCharacterCS? u)
        {
            if (Gone(u)) return;
            try
            {
                var ev = BUS_EventCollectionCS.Get(u!);
                ev?.Evt_BuffAllRemove?.Invoke((EBuffEffectTriggerType)0);
                ev?.Evt_UnitDead?.Invoke(null, EDeadReason.PlayerTrans);
                u!.DestroyActor();
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 销毁变身单位异常: {e.Message}"); }
            // 同时销毁 TAMER 外壳（内部 Boss 可能随外壳一起回收，这里兜底清理残留外壳）
            if (_tamer != null)
            {
                DestroyTamerShell(_tamer);
                _tamer = null;
            }
        }

        /// <summary>
        /// 正确销毁 TAMER 外壳：走 Evt_RequestDestroyUnit → BGS_TamerManagerSystem.OnRequestDestroyUnit
        /// → OnUnregisterTamer → FTamerRef.DestroyTamer()，把外壳从 BGC_TamerData.UnitGuid2Tamer /
        /// SpawnedTamerStrategy / LineTraceManager 里摘干净。
        /// 直接 DestroyActor 会在 TamerManager 里留下悬空 FTamerRef，后续 OnUnitDead / ResetAllTamers
        /// 处理到它时可能误伤其它怪（表现为别的怪状态错乱、打不死）。
        /// </summary>
        private static void DestroyTamerShell(BUTamerActor? tamer)
        {
            if (Gone(tamer)) return;
            bool requested = false;
            try
            {
                string guid = !string.IsNullOrEmpty(_tamerGuid) ? _tamerGuid : (tamer!.GetFinalGuid() ?? "");
                if (!string.IsNullOrEmpty(guid))
                {
                    BGU_UnrealWorldUtil.RequestDestroyUnit(tamer, guid);
                    requested = true;
                }
            }
            catch (Exception e) { Log.Warn($"[NativeTrans] 请求销毁 TAMER 失败，回退直接销毁: {e.Message}"); }
            _tamerGuid = "";
            // RequestDestroyUnit 只对已注册且 TamerType 为 Spawned/Summoned 的外壳生效，
            // 未注册时（生成失败/已被回收）兜底直接销毁，避免外壳泄漏。
            if (!requested || !Gone(tamer))
            {
                try { tamer!.DestroyActor(); } catch { }
            }
        }

        /// <summary>Direct 模式：变回时恢复隐藏的本尊（显示 + 重新 Possess + 恢复视角），本尊已失效则生成本尊</summary>
        private static void RestoreOriginPlayer(int backResId)
        {
            var wk = _originPlayer;

            // 变身期间本尊被隐藏 + 清 buff + 关组件碰撞，复用旧本尊偶尔会残留"部件/骨骼不完整"，
            // 需要最干净的结果时把 transConfig 的 TransBackRespawnPlayer 设为 true：销毁旧本尊、重新生成一个。
            if ((_cfg?.TransBackRespawnPlayer ?? false) && !Gone(wk))
            {
                Log.Info("[NativeTrans] TransBackRespawnPlayer=true：销毁旧本尊并重新生成");
                RestoreCamera(); // 必须在销毁前：臂长/相对位置的还原要用到本尊的相机组件
                try { wk!.DestroyActor(); } catch (Exception e) { Log.Warn($"[NativeTrans] 销毁旧本尊失败: {e.Message}"); }
                _originPlayer = null;
                SpawnDefaultPawn(backResId, Unit);
                return;
            }

            if (!Gone(wk))
            {
                try
                {
                    RestoreCamera();
                    wk!.SetActorHiddenInGame(false);
                    wk.SetActorEnableCollision(true);
                    RestorePlayerPrimitives(wk);
                    var ev = BUS_EventCollectionCS.Get(wk);
                    ev?.Evt_SetBoolProperty?.Invoke(EPropType.Mesh_PauseAnims, false);
                    ev?.Evt_AIPauseBT?.Invoke(false);
                    _pc?.SetViewTargetWithBlend(wk, 0f);
                    _pc?.Possess(wk);
                    Log.Info("[NativeTrans] 已恢复本尊");
                    return;
                }
                catch (Exception e)
                {
                    Log.Error($"[NativeTrans] 恢复本尊异常，改生成本尊: {e.Message}");
                }
            }
            SpawnDefaultPawn(backResId, Unit);
        }

        /// <summary>
        /// 恢复本尊的可见性/碰撞（变身时被逐个组件关掉的），并清掉可能残留的 MasterPoseComponent
        /// —— 若本尊 Mesh 的 pose 曾被指到变身单位（Boss）身上，Boss 销毁后骨骼姿态会缺失，表现为"身体一部分不可见"。
        /// </summary>
        private static void RestorePlayerPrimitives(BGUCharacterCS u)
        {
            int total = 0, fixedCnt = 0;
            try
            {
                var primCls = UClass.GetClass<UPrimitiveComponent>();
                foreach (var c in u.GetComponentsByClass((TSubclassOf<UActorComponent>)primCls))
                {
                    if (!(c is UPrimitiveComponent prim)) continue;
                    total++;
                    try
                    {
                        // 按变身时记录的原值精确写回；不要用 SetVisibility(true)，
                        // 那会把本尊身上本来 bVisible=false 的辅助/调试组件（线框等）显示出来
                        bool hidden = _playerHiddenBefore.TryGetValue(prim.Address, out var hb) && hb;
                        prim.SetHiddenInGame(hidden, false);
                        // 变身时我们对所有组件设了 NoCollision，这里把角色胶囊的碰撞恢复（其余装饰部件保持无碰撞）
                        if (prim is UCapsuleComponent) prim.SetCollisionEnabled(ECollisionEnabled.QueryAndPhysics);
                        fixedCnt++;
                    }
                    catch { }
                }
            }
            catch (Exception e) { Log.Warn($"[NativeTrans] 恢复本尊组件可见性异常: {e.Message}"); }

            try
            {
                if (u.Mesh != null)
                {
                    var mpM = FindMember(u.Mesh, "MasterPoseComponent");
                    object? master = null;
                    if (mpM != null) master = mpM.Value.Get(u.Mesh);
                    if (master != null && !ReferenceEquals(master, u.Mesh))
                    {
                        u.Mesh.SetMasterPoseComponent(null, true);
                        Log.Info("[NativeTrans] 已清除本尊 Mesh 的 MasterPoseComponent（变身残留，会导致骨骼缺失）");
                    }
                }
            }
            catch (Exception e) { Log.Warn($"[NativeTrans] 清理 MasterPose 异常: {e.Message}"); }

            _playerHiddenBefore.Clear();
            Log.Info($"[NativeTrans] 本尊可见性/碰撞已恢复：组件 {fixedCnt}/{total}");
        }

        /// <summary>读取组件当前的"游戏内隐藏"标记（CSharpLoader 里布尔属性可能带/不带 b 前缀）</summary>
        private static bool? GetCompHidden(UPrimitiveComponent p)
        {
            foreach (var n in new[] { "HiddenInGame", "bHiddenInGame", "Hidden" })
            {
                try
                {
                    var m = FindMember(p, n);
                    if (m != null && m.Value.Get(p) is bool b) return b;
                }
                catch { }
            }
            return null;
        }

        /// <summary>
        /// 结束变身：
        ///  - Direct（自定义生成）：销毁当前角色并恢复隐藏的本尊；
        ///  - Reskin / 原生变身：调用游戏自己的 Evt_TriggerPlayerTransEnd 变回本尊。
        /// </summary>
        public static void EndTrans()
        {
            TransConfig? cfg;
            APlayerState? ps;
            string mode;
            lock (_lock)
            {
                if (!IsActive && !_pendingBegin)
                {
                    ClearRuntime();
                    return;
                }
                cfg = _cfg;
                ps = _hookedPs;
                mode = _mode;
                IsActive = false;
                _pendingBegin = false;
            }

            UnsubscribeUnit(false);
            StopWatchdog();

            int backResId = 0;
            try { backResId = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid); }
            catch (Exception e) { Log.Error($"[NativeTrans] 读取本尊 ResID 失败: {e.Message}"); }

            // Direct 自定义生成：销毁当前角色并恢复隐藏的本尊
            if (mode == "Direct")
            {
                Log.Info("[NativeTrans] 自定义变身结束：恢复本尊");
                DestroyCurrentUnit(Unit);
                DestroyTamerShell(_tamer);
                _tamer = null;
                RestoreOriginPlayer(backResId);
                DestroyInjectedCamera();
                ClearRuntime();
                return;
            }

            int endType = cfg?.TransBackEndType ?? DefaultTransBackEndType;
            BGUCharacterCS? oldUnit = Unit;

            // 非玩家类单位（Boss 单位）走原生变回链路会静默失败，自行生本尊接管
            if (oldUnit != null && !(oldUnit is BGUPlayerCharacterCS))
            {
                Log.Info("[NativeTrans] 当前单位不是 BGUPlayerCharacterCS，改为自行生成本尊接管（不走原生变回）");
                RestoreCameraArmLength();
                HideAndKillUnit(oldUnit);
                SpawnDefaultPawn(backResId, oldUnit);
                DestroyInjectedCamera();
                ClearRuntime();
                return;
            }

            if (Gone(ps)) ps = TryGetPlayerState();
            if (!Gone(ps) && backResId > 0)
            {
                var param = new PlayerTransParam
                {
                    TargetResId = backResId,
                    SpawnSkillId = 0,
                    NeedBlend = cfg?.NeedBlend ?? true,
                };
                try
                {
                    Log.Info($"[NativeTrans] 触发原生变回 endType={(EPlayerTransEndType)endType} ResId={backResId}");
                    BPS_EventCollectionCS.Get(ps!)?.Evt_TriggerPlayerTransEnd.Invoke((EPlayerTransEndType)endType, param);
                }
                catch (Exception e) { Log.Error($"[NativeTrans] 触发变回异常: {e.Message}"); }
            }
            else
            {
                Log.Warn($"[NativeTrans] 无法触发原生变回（PlayerState/ResID 无效）：ps={Gone(ps)} resId={backResId}");
            }

            DestroyInjectedCamera();
            ClearRuntime();
        }

        /// <summary>隐藏并"杀掉"变身单位（对齐 BUS_PlayerTransComp.DestroyOldUnit 的处理）</summary>
        private static void HideAndKillUnit(BGUCharacterCS unit)
        {
            try
            {
                var ev = BUS_EventCollectionCS.Get(unit);
                ev?.Evt_SetBoolProperty?.Invoke(EPropType.Actor_ActorHiddenInGame, true);
                ev?.Evt_SetBoolProperty?.Invoke(EPropType.Mesh_PauseAnims, true);
                ev?.Evt_BuffAllRemove?.Invoke((EBuffEffectTriggerType)0);
                unit.SetActorEnableCollision(false);
                ev?.Evt_UnitDead?.Invoke(null, EDeadReason.PlayerTrans);
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 处理旧单位异常: {e.Message}"); }
        }

        /// <summary>
        /// 自行生成本尊 Pawn 并让控制器接管（Direct 模式下 Boss 单位无法走原生变回链路时的兜底）。
        /// 做法与 BUS_PlayerTransComp.SpawnAndPossessTransUnit 一致。
        /// </summary>
        private static void SpawnDefaultPawn(int resId, BGUCharacterCS oldUnit)
        {
            if (resId <= 0) { Log.Error("[NativeTrans] 本尊 ResID 无效，无法生成本尊"); return; }
            try
            {
                var pc = ModUtils.GetPlayerController();
                if (Gone(pc)) { Log.Error("[NativeTrans] 拿不到控制器，无法生成本尊"); return; }

                var desc = BGW_GameDB.GetUnitTransCommDesc(resId);
                if (desc == null || string.IsNullOrEmpty(desc.BPPath))
                {
                    Log.Error($"[NativeTrans] 取不到本尊变身描述 ResID={resId}");
                    return;
                }
                UClass? cls = BGW_PreloadAssetMgr.Get(pc!).TryGetCachedResourceObj<UClass>(desc.BPPath!, ELoadResourceType.SyncLoadAndCache);
                if (cls == null)
                {
                    Log.Error($"[NativeTrans] 加载本尊类失败: {desc.BPPath}");
                    return;
                }

                AActor anchor = oldUnit;
                if (Gone(anchor)) anchor = pc!.GetControlledPawn()!;
                FVector loc = Gone(anchor) ? FVector.ZeroVector : anchor.GetActorLocation();
                FRotator rot = Gone(anchor) ? FRotator.ZeroRotator : anchor.GetActorRotation();

                var blend = new BGUFuncLibPlayer.SpawnControlledPawnBlendParam
                {
                    NeedBlend = false,
                    PossessBlendTime = 0f,
                    PossessBlendFunc = 0,
                    PossessBlendExp = 0f,
                    EnableBlendViewTarget = false,
                };

                AActor billing = anchor;
                BGUFuncLibPlayer.SpwanAndPossesPlayerContrlledPawn(pc!, cls, new FTransform(rot, loc, new FVector(1f, 1f, 1f)), (APawn pawn) =>
                {
                    try
                    {
                        BPS_EventCollectionCS.Get(pc!)?.Evt_PlayerActorSpawn.Invoke();
                        BPS_EventCollectionCS.Get(pc!)?.Evt_BPS_SwitchPlayerTransState.Invoke(billing, resId);
                    }
                    catch (Exception e) { Log.Error($"[NativeTrans] 本尊生成回调异常: {e.Message}"); }
                }, blend);

                Log.Info($"[NativeTrans] 已生成本尊 ResID={resId} 并接管");
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 生成本尊异常: {e.Message}"); }
        }

        /// <summary>Mod 卸载时调用：强制收尾，避免状态残留</summary>
        public static void DeInit()
        {
            try
            {
                UnhookTransSwitch();
                UnsubscribeUnit(true);
                StopWatchdog();
                RestoreCameraArmLength();
                DestroyInjectedCamera();
            }
            catch (Exception e) { Log.Error($"[NativeTrans] DeInit 异常: {e.Message}"); }
            ClearRuntime();
        }

        /// <summary>
        /// 打印游戏 UnitTransCommDesc 表里所有变身单位，并标注其是否继承自 BGUPlayerCharacterCS
        /// （只有继承它的单位才能被游戏原生变身系统完整支持）。
        /// </summary>
        public static void DumpAvailableTransUnits()
        {
            try
            {
                var all = BGW_GameDB.GetAllUnitTransCommDesc();
                if (all == null || all.Count == 0)
                {
                    Log.Warn("[NativeTrans] UnitTransCommDesc 表为空或取不到");
                    return;
                }
                Log.Info($"[NativeTrans] UnitTransCommDesc 共 {all.Count} 条：");
                foreach (var kv in all)
                {
                    int id = kv.Key;
                    string bp = kv.Value?.BPPath ?? "";
                    string kind = "未知";
                    try
                    {
                        UObject? ctx = (UObject?)(object?)_unit ?? (UObject?)(object?)_pc;
                        UClass? cls = null;
                        if (!string.IsNullOrEmpty(bp) && !Gone(ctx))
                            cls = BGW_PreloadAssetMgr.Get(ctx!).TryGetCachedResourceObj<UClass>(bp, ELoadResourceType.SyncLoadAndCache);
                        if (cls != null)
                            kind = cls.IsChildOf<BGUPlayerCharacterCS>() ? "玩家可控(BGUPlayerCharacterCS)" : "非玩家单位";
                        else
                            kind = "类未加载(可能需先进对应关卡)";
                    }
                    catch { /* 个别资源加载失败不影响其它行 */ }
                    Log.Info($"[NativeTrans]   ResID={id} [{kind}] {bp}");
                }
            }
            catch (Exception e)
            {
                Log.Error($"[NativeTrans] Dump 变身表失败: {e.Message}");
            }
        }

        // ---------------------------------------------------------------- 模式解析 / 钩子

        private static string ResolveMode(TransConfig cfg, out int baseResId)
        {
            baseResId = cfg.BaseResId ?? 0;
            string? m = cfg.TransMode;
            if (!string.IsNullOrEmpty(m))
            {
                if (m!.Equals("Reskin", StringComparison.OrdinalIgnoreCase))
                {
                    if (baseResId <= 0)
                    {
                        Log.Warn("[NativeTrans] TransMode=Reskin 但未配 BaseResId，回退 Direct 模式");
                        return "Direct";
                    }
                    return "Reskin";
                }
                if (m!.Equals("Direct", StringComparison.OrdinalIgnoreCase)) return "Direct";
            }
            // 自动：配了基底 ResID → Reskin，否则 Direct
            if (baseResId > 0) return "Reskin";
            return "Direct";
        }

        private static void HookTransSwitch(APlayerController pc)
        {
            try
            {
                APlayerState? ps = pc.PlayerState;
                if (Gone(ps)) return;
                if (!ReferenceEquals(_hookedPs, ps))
                {
                    UnhookTransSwitch();
                    var col = BPS_EventCollectionCS.Get(ps!);
                    if (col == null) return;
                    col.Evt_BPS_SwitchPlayerTransState -= new Del_SwitchPlayerTransState(OnSwitchTransState);
                    col.Evt_BPS_SwitchPlayerTransState += new Del_SwitchPlayerTransState(OnSwitchTransState);
                    _hookedPs = ps;
                }
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 订阅变身切换事件失败: {e.Message}"); }
        }

        private static void UnhookTransSwitch()
        {
            try
            {
                if (!Gone(_hookedPs))
                {
                    var col = BPS_EventCollectionCS.Get(_hookedPs!);
                    if (col != null) col.Evt_BPS_SwitchPlayerTransState -= new Del_SwitchPlayerTransState(OnSwitchTransState);
                }
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 退订变身切换事件失败: {e.Message}"); }
            _hookedPs = null;
        }

        private static APlayerState? TryGetPlayerState()
        {
            try
            {
                if (!Gone(_pc)) return _pc!.PlayerState;
                var pc = ModUtils.GetPlayerController();
                return Gone(pc) ? null : pc!.PlayerState;
            }
            catch { return null; }
        }

        /// <summary>
        /// 游戏在 Possess 新单位之后、新单位 BeginPlay 之前回调（见 BUS_PlayerTransComp.SpawnAndPossessTransUnit）。
        /// 此时拿到新单位做"玩家化"改造最合适。
        /// </summary>
        private static void OnSwitchTransState(AActor OldActor, int NewActorResId)
        {
            if (!_pendingBegin || _cfg == null) return;

            try
            {
                var pc = _pc;
                if (Gone(pc)) return;
                APawn? pawn = pc!.GetControlledPawn();
                if (Gone(pawn)) return;

                var unit = pawn as BGUCharacterCS;
                if (unit == null)
                {
                    Log.Error($"[NativeTrans] 新的受控 Pawn 不是 BGUCharacterCS，无法继续");
                    _pendingBegin = false;
                    return;
                }

                int resId = unit.GetResID();
                int expect = _mode == "Reskin" ? (_cfg.BaseResId ?? _cfg.ID) : _cfg.ID;
                if (resId != expect)
                {
                    // 不是我们期待的变身（例如别的流程触发的），忽略
                    Log.Info($"[NativeTrans] 忽略非本次变身的角色切换 ResId={resId}（期待 {expect}）");
                    return;
                }

                _pendingBegin = false;
                double cost = (DateTime.Now - _beginTime).TotalMilliseconds;
                Log.Info($"[NativeTrans] 变身成功 mode={_mode} Unit='{unit.GetName()}' ResId={resId} " +
                         $"IsPlayerCharacter={(unit is BGUPlayerCharacterCS)} 耗时={cost:F0}ms");
                ActivateUnit(unit);
            }
            catch (Exception e)
            {
                Log.Error($"[NativeTrans] 处理变身切换异常: {e.Message}");
            }
        }

        /// <summary>统一的新单位"玩家化"激活流程（原生变身回调与 Direct 自定义 spawn 回调共用）</summary>
        private static void ActivateUnit(BGUCharacterCS unit)
        {
            _unit = unit;
            IsActive = true;
            ResetCombo();
            PrepareUnit(unit);
            SubscribeUnit(unit);
            StartWatchdog();
            SchedulePostSetup();
        }

        // ---------------------------------------------------------------- 单位改造

        /// <summary>把刚生成的新单位改成"可以当玩家用"（Possess 之后、BeginPlay 之前）</summary>
        private static void PrepareUnit(BGUCharacterCS unit)
        {
            var cfg = _cfg;

            // 1) 阵营：跟着变身前的玩家阵营，否则会被敌方当作同伙 / 打不到敌人
            try
            {
                int curTeam = unit.GetTeamIDInCS();
                if (curTeam != _teamId)
                {
                    unit.SetTeamIDInCS(_teamId);
                    Log.Info($"[NativeTrans] 阵营修正 {curTeam} -> {_teamId}");
                }
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 设置阵营失败: {e.Message}"); }

            // 2) 补挂玩家组件（Direct 模式下 Boss 单位才缺，Reskin 模式单位自带，重复挂载会 logged 失败但无副作用）
            if (cfg?.AttachPlayerComps ?? true)
            {
                AttachPlayerComps(unit, cfg);
            }

            // 3) 关 AI：避免自动追击/出招，招式由玩家输入驱动
            if (cfg?.DisableAI ?? true)
            {
                DisableUnitAI(unit);
            }

            // 4) 补相机（Direct 模式下 Boss 单位没有 CameraBoom/FollowCamera）
            if (cfg?.AttachCamera ?? true)
            {
                AttachInjectedCamera(unit, cfg);
            }
        }

        private static readonly string[] DefaultExtraComps =
        {
            "BUS_PlayerInputActionComp",
            "BUS_SmartCastSkillComp",
            "BUS_DodgeComp",
            "BUS_SkillSelectComp",
            "BUS_SkillRotateComp",
            "BUS_TransPlayerDataBindComp",
        };

        private static void AttachPlayerComps(BGUCharacterCS unit, TransConfig? cfg)
        {
            var names = new List<string>(DefaultExtraComps);
            if (cfg?.ExtraComps != null)
            {
                foreach (var n in cfg.ExtraComps!)
                    if (!string.IsNullOrEmpty(n) && !names.Contains(n!)) names.Add(n!);
            }

            foreach (var name in names)
            {
                int netRole = string.Equals(name, "BUS_PlayerInputActionComp", StringComparison.Ordinal) ? 16 : int.MaxValue;
                bool ok = TryAddComp(unit, name!, netRole);
                Log.Info($"[NativeTrans] 补挂组件 {name} -> {(ok ? "成功" : "失败/已存在")}");
            }
        }

        private static bool TryAddComp(BGUCharacterCS unit, string typeName, int netRole)
        {
            try
            {
                Type? t = ResolveType(typeName);
                if (t == null)
                {
                    Log.Warn($"[NativeTrans] 找不到组件类型: {typeName}");
                    return false;
                }
                if (FindComp(unit, t) != null) return false; // 已存在，避免重复

                object? comp = Activator.CreateInstance(t, true);
                if (comp == null) return false;

                MethodInfo? mi = typeof(UActorCompContainerCS)
                    .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                    .FirstOrDefault(m => m.Name == "AddComp" && m.IsGenericMethodDefinition && m.GetParameters().Length == 3);
                if (mi == null)
                {
                    Log.Error("[NativeTrans] 未找到 UActorCompContainerCS.AddComp<T>");
                    return false;
                }
                object? res = mi.MakeGenericMethod(t).Invoke(unit.ActorCompContainerCS, new object[] { comp, netRole, 0 });
                return res != null;
            }
            catch (Exception e)
            {
                Log.Error($"[NativeTrans] 挂载组件 {typeName} 异常: {e.Message}");
                return false;
            }
        }

        /// <summary>从 CompCSs 列表里找已挂载的组件（复用 ActionExecutor.FindActorCompByClass 同款反射思路）</summary>
        private static object? FindComp(BGUCharacterCS unit, Type? compType)
        {
            if (compType == null) return null;
            try
            {
                var container = unit.ActorCompContainerCS;
                if (container == null) return null;
                FieldInfo? field = typeof(UActorCompContainerCS)
                    .GetField("CompCSs", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?? typeof(UActorCompContainerCS).GetField("CompCSs", BindingFlags.Public | BindingFlags.Instance);
                var list = field?.GetValue(container) as List<UActorCompBaseCS>;
                if (list == null) return null;
                foreach (var c in list)
                    if (c != null && compType.IsInstanceOfType(c)) return c;
            }
            catch { }
            return null;
        }

        private static Type? ResolveType(string name)
        {
            string full = name.Contains('.') ? name : "b1." + name;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type? t = null;
                try { t = asm.GetType(full); } catch { }
                if (t != null) return t;
            }
            return null;
        }

        private static void DisableUnitAI(BGUCharacterCS unit)
        {
            try
            {
                var ev = BUS_EventCollectionCS.Get(unit);
                ev?.Evt_AIPerceptionSetting?.Invoke(false);
                ev?.Evt_AIPauseBT?.Invoke(true);
                BGUFunctionLibraryCS.BGUAddBuff(unit, unit, DisableAIBuffId, EBuffSourceType.GM, -1f);
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 关闭 AI 异常: {e}"); }
        }

        private static void AttachInjectedCamera(BGUCharacterCS unit, TransConfig? cfg)
        {
            if (unit is BGUPlayerCharacterCS)
            {
                try { _pc?.SetViewTargetWithBlend(unit, 0f); } catch { }
                return; // 原生变身单位自带 CameraBoom/FollowCamera
            }
            // Boss 单位：复用玩家(悟空)自己的 CameraBoom 挂到 boss Mesh 骨骼插槽（与旧傀儡附身方案一致，
            // 避免新建相机组件在 CSharpLoader 下无法注册导致警告/黑屏）。
            try { AttachPlayerCameraToBoss(unit, cfg?.CameraSocket); }
            catch (Exception e) { Log.Error($"[NativeTrans] 补挂相机异常: {e.Message}"); }
        }

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

        /// <summary>把玩家(悟空)自己的 CameraBoom 从玩家根组件改挂到 boss 的 Mesh 骨骼插槽，并记录原挂载以便还原</summary>
        private static void AttachPlayerCameraToBoss(BGUCharacterCS boss, string? socket)
        {
            var player = _originPlayer;
            if (Gone(player)) return;
            try
            {
                var boom = (USceneComponent)(object)player.CameraBoom1;
                if (boom == null) return;
                USceneComponent? mesh = boss.Mesh;
                if (mesh == null) return;

                _origCamParent = boom.GetAttachParent();
                _origCamSocket = boom.GetAttachSocketName();

                if (string.IsNullOrEmpty(socket)) socket = "pelvis";
                boom.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, true);
                boom.AttachToComponent(mesh, new FName(socket), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true);
                // 巨型 Boss 的 Mesh 插槽(pelvis)在身体内部，必须把相机臂长拉远退出身体，否则看不见外界。
                // 注意两点：
                //  1) CSharpLoader 绑定里 TargetArmLength/RelativeLocation/CapsuleHalfHeight 多为属性（property），
                //     不能只用 GetField 反射；且 CapsuleHalfHeight 常取不到，所以优先按 Actor 包围盒估体型。
                //  2) CameraBoom.TargetArmLength 每帧会被相机系统按 BUC_CameraState 里的默认臂长覆盖
                //     （b1/BUS_PlayerCameraCompImpl.cs:718），只改组件属性会被打回原值（表现：视角贴脸）。
                float camArm = ComputeBossCamArm(boss, _cfg, out string armDiag);
                try
                {
                    var armM = FindMember(boom, "TargetArmLength");
                    if (armM == null)
                    {
                        Log.Warn("[NativeTrans] CameraBoom 上未找到 TargetArmLength（属性/字段都没有），臂长未拉远");
                    }
                    else
                    {
                        armM.Value.Set(boom, camArm);
                    }
                    // 关闭相机碰撞测试：否则巨型 Boss 自身碰撞体把相机臂挡到贴脸（即使臂长设很大也被收紧，
                    // 表现就是 armnow 很大但相机实际距离小）。
                    // ⚠ CSharpLoader 绑定里布尔属性会去掉 b 前缀（DoCollisionTest），
                    //   只找 "bDoCollisionTest" 会静默失败 → 碰撞一直生效 → 怎么拉远都贴脸。
                    bool ctOk = false;
                    foreach (var n in new[] { "DoCollisionTest", "bDoCollisionTest" })
                    {
                        var ctM = FindMember(boom, n);
                        if (ctM == null) continue;
                        ctM.Value.Set(boom, false);
                        ctOk = true;
                        break;
                    }
                    // 探针半径降到 0，避免被环境/自身部件误挡
                    var psM = FindMember(boom, "ProbeSize");
                    if (psM != null) psM.Value.Set(boom, 0f);
                    Log.Info($"[NativeTrans][camarm] 关闭相机碰撞测试={(ctOk ? "成功" : "失败(未找到属性)")}");
                    // 相机相对挂载插槽的偏移（X 前后 / Y 左右 / Z 抬高）：
                    // 三轴一次配齐用 CameraRelativeLocation，旧字段 CameraOffsetX/Y、CameraHeightOffset 仍兼容并叠加
                    float hOff = _cfg?.CameraHeightOffset ?? 0f;
                    float xOff = _cfg?.CameraOffsetX ?? 0f;
                    float yOff = _cfg?.CameraOffsetY ?? 0f;
                    var rl = _cfg?.CameraRelativeLocation;
                    _camRelOffset = new FVector(xOff + (rl?.X ?? 0f), yOff + (rl?.Y ?? 0f), hOff + (rl?.Z ?? 0f));
                    if (Math.Abs(_camRelOffset.X) > 0.01f || Math.Abs(_camRelOffset.Y) > 0.01f || Math.Abs(_camRelOffset.Z) > 0.01f)
                    {
                        var rlM = FindMember(boom, "RelativeLocation");
                        if (rlM != null && rlM.Value.Get(boom) is FVector v)
                        {
                            rlM.Value.Set(boom, new FVector(v.X + _camRelOffset.X, v.Y + _camRelOffset.Y, v.Z + _camRelOffset.Z));
                        }
                        else
                        {
                            Log.Warn("[NativeTrans] CameraBoom 上未找到 RelativeLocation，相机偏移未生效");
                        }
                    }
                    else
                    {
                        _camRelOffset = FVector.ZeroVector;
                    }
                }
                catch (Exception ex) { Log.Warn($"[NativeTrans] 设置相机臂长失败: {ex.Message}"); }

                // 关键：把臂长写进相机系统数据源，使其成为持续生效的基准臂长（只改组件属性会被每帧覆盖）
                ApplyCameraArmLength(camArm);
                // FollowCamera 挂在 SpringArm 端点(SpringEndpoint)上，残留的相对偏移/ socket offset
                // 会把相机推离按臂长算出来的位置，这里统一清零，让相机严格落在"骨骼插槽 + 臂长"处
                try
                {
                    var follow = (USceneComponent?)(object?)player.FollowCamera;
                    if (follow != null)
                    {
                        var frlM = FindMember(follow, "RelativeLocation");
                        if (frlM != null) frlM.Value.Set(follow, FVector.ZeroVector);
                    }
                    var bsoM = FindMember(boom, "SocketOffset");
                    if (bsoM != null) bsoM.Value.Set(boom, FVector.ZeroVector);
                    var btoM = FindMember(boom, "TargetOffset");
                    if (btoM != null) btoM.Value.Set(boom, FVector.ZeroVector);
                }
                catch (Exception ex) { Log.Warn($"[NativeTrans] 清零相机端点偏移失败: {ex.Message}"); }
                // 相对位置也要写进相机系统(DefaultArmLocation)，否则每帧被 boom.SetRelativeLocation 覆盖回去
                ApplyCameraRelativeLocation(_camRelOffset);
                Log.Info($"[NativeTrans][camarm] {armDiag} relOff=({_camRelOffset.X:F0},{_camRelOffset.Y:F0},{_camRelOffset.Z:F0})");
                // ⚠ view target 必须设成"拥有 FollowCamera 的单位"（悟空本尊），而不是 Boss：
                // PlayerCameraManager 对没有 CameraComponent 的 view target 会退化成
                // GetActorEyesViewPoint（= Boss 自身位置），相机就被埋在 Boss 身体里，臂长再大也没用。
                // 设成本尊后 CalcCamera 会找到挂在 Boss 骨骼上的 FollowCamera，视角才真正由臂长决定。
                _pc?.SetViewTargetWithBlend(player, 0f);
                // 相机诊断：确认 boss/mesh/臂长/view target，便于排查"看不到角色"
                try
                {
                    float finalArm = -1f;
                    var armM2 = FindMember(boom, "TargetArmLength");
                    if (armM2 != null && armM2.Value.Get(boom) is float fa) finalArm = fa;
                    var vt = _pc?.GetViewTarget();
                    bool hidden = false;
                    try { var gm = boss.GetType().GetMethod("GetActorHiddenInGame"); if (gm != null) hidden = (bool)gm.Invoke(boss, null); } catch { }
                    Log.Info($"[NativeTrans][cam] boss='{boss.GetName()}' mesh={(boss.Mesh != null ? boss.Mesh.GetName() : "null")} " +
                             $"socket={socket} arm={finalArm:F0} hidden={(hidden ? 1 : 0)} vt={(vt != null ? vt.GetName() : "null")}");
                }
                catch (Exception ex) { Log.Warn($"[NativeTrans] 相机诊断失败: {ex.Message}"); }
                Log.Info($"[NativeTrans] 已将玩家镜头挂到 boss Mesh 插槽 {socket}（相机臂长已拉远）");
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 镜头挂载异常: {e.Message}"); }
        }

        /// <summary>变回时把玩家 CameraBoom 还原到原挂载点（并把相机系统臂长还原成变身前）</summary>
        private static void RestoreCamera()
        {
            RestoreCameraArmLength();
            var player = _originPlayer;
            if (Gone(player)) return;
            try
            {
                var boom = (USceneComponent)(object)player.CameraBoom1;
                if (boom == null) return;

                USceneComponent? parent = _origCamParent;
                FName socket = _origCamSocket;
                if (parent == null || Gone(parent))
                {
                    parent = player.GetRootComponent();
                    socket = new FName("pelvis");
                }
                if (parent == null) return;

                boom.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, true);
                boom.AttachToComponent(parent, socket, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, true);
                _pc?.SetViewTargetWithBlend(player, 0f);
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 镜头还原异常: {e.Message}"); }
        }

        // ---------------------------------------------------------------- 相机臂长（写进相机系统数据源）

        /// <summary>玩家(悟空)身上的相机组件 BUS_PlayerCameraCompImpl（相机参数由它每帧应用）</summary>
        private static object? GetPlayerCameraComp()
        {
            var p = _originPlayer;
            if (Gone(p)) return null;
            return FindComp(p!, ResolveType("BUS_PlayerCameraCompImpl"));
        }

        /// <summary>相机系统运行时状态 BUC_CameraState：臂长等相机参数的真正数据源</summary>
        private static object? GetCameraState()
        {
            try
            {
                var comp = GetPlayerCameraComp();
                if (comp == null) return null;
                var pdM = FindMember(comp, "PlayerCameraData");
                if (pdM == null) return null;
                object? data = pdM.Value.Get(comp);
                if (data == null) return null;
                var csM = FindMember(data, "CameraState");
                if (csM == null) return null;
                return csM.Value.Get(data);
            }
            catch { return null; }
        }

        private static float GetCamFloat(object state, string name, float def)
        {
            try
            {
                var m = FindMember(state, name);
                if (m == null) return def;
                return m.Value.Get(state) is float f ? f : def;
            }
            catch { return def; }
        }

        private static bool SetCamFloat(object state, string name, float value)
        {
            try
            {
                var m = FindMember(state, name);
                if (m == null) return false;
                m.Value.Set(state, value);
                return true;
            }
            catch { return false; }
        }

        private static FVector GetCamVec(object state, string name, FVector def)
        {
            try
            {
                var m = FindMember(state, name);
                if (m == null) return def;
                return m.Value.Get(state) is FVector v ? v : def;
            }
            catch { return def; }
        }

        private static bool SetCamVec(object state, string name, FVector value)
        {
            try
            {
                var m = FindMember(state, name);
                if (m == null) return false;
                m.Value.Set(state, value);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 相机相对位置偏移：写进 DefaultArmLocation。相机每帧会把 boom 的 RelativeLocation 设成这里的值
        /// （b1/BUS_PlayerCameraCompImpl.cs:717），只改组件属性会被覆盖回去。
        /// Z 轴要额外同步 OriginDefaultArmLocationZ，因为它每帧会被重算回 DefaultArmLocation.Z。
        /// </summary>
        private static void ApplyCameraRelativeLocation(FVector off)
        {
            if (Math.Abs(off.X) <= 0.01f && Math.Abs(off.Y) <= 0.01f && Math.Abs(off.Z) <= 0.01f) return;
            try
            {
                var st = GetCameraState();
                if (st == null)
                {
                    Log.Warn("[NativeTrans][camrel] 未取到 BUC_CameraState，相机相对位置可能每帧被覆盖");
                    return;
                }
                if (!_camRelApplied)
                {
                    _origDefaultArmLocation = GetCamVec(st, "DefaultArmLocation", FVector.ZeroVector);
                    _origArmLocationZ = GetCamFloat(st, "OriginDefaultArmLocationZ", -1f);
                    _camRelApplied = true;
                }
                SetCamVec(st, "DefaultArmLocation", new FVector(
                    _origDefaultArmLocation.X + off.X,
                    _origDefaultArmLocation.Y + off.Y,
                    _origDefaultArmLocation.Z + off.Z));
                if (_origArmLocationZ >= 0f) SetCamFloat(st, "OriginDefaultArmLocationZ", _origArmLocationZ + off.Z);
            }
            catch (Exception e) { Log.Warn($"[NativeTrans][camrel] 写入相机相对位置异常: {e.Message}"); }
        }

        /// <summary>变回时还原相机相对位置</summary>
        private static void RestoreCameraRelativeLocation()
        {
            if (!_camRelApplied) return;
            try
            {
                var st = GetCameraState();
                if (st != null)
                {
                    SetCamVec(st, "DefaultArmLocation", _origDefaultArmLocation);
                    if (_origArmLocationZ >= 0f) SetCamFloat(st, "OriginDefaultArmLocationZ", _origArmLocationZ);
                }
            }
            catch (Exception e) { Log.Warn($"[NativeTrans][camrel] 还原相机相对位置异常: {e.Message}"); }
            _camRelApplied = false;
            _camRelOffset = FVector.ZeroVector;
        }

        /// <summary>
        /// 用骨架 socket 位置粗估单位体型（TAMER 单位刚生成时 Actor 包围盒常只有几百，严重偏小；
        /// 骨架头/手 socket 到 Mesh 原点的距离更接近真实体型）。
        /// </summary>
        private static float EstimateUnitSize(BGUCharacterCS u)
        {
            float best = 0f;
            try
            {
                var mesh = u.Mesh;
                if (mesh == null) return 0f;
                var origin = mesh.GetWorldLocation();
                foreach (var n in new[] { "head", "Head", "Head_Socket", "Bip01_Head", "spine_03", "hand_r", "hand_l", "foot_r" })
                {
                    try
                    {
                        var p = mesh.GetSocketLocation(new FName(n));
                        float dx = p.X - origin.X, dy = p.Y - origin.Y, dz = p.Z - origin.Z;
                        float d = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
                        if (d > best && d < 100000f) best = d;
                    }
                    catch { }
                }
            }
            catch { }
            return best;
        }

        /// <summary>
        /// 计算 Boss 变身后的相机臂长：
        ///  体型半径 = max(Actor 包围盒半径, 胶囊半高, 骨架尺寸×0.5)，臂长 = 半径 × CameraDistanceMul；
        ///  配置的 CameraArmLength 作为**下限**，即自动值更大时用自动值，自动值偏小时用配置值兜底。
        /// </summary>
        private static float ComputeBossCamArm(BGUCharacterCS boss, TransConfig? cfg, out string diag)
        {
            float explicitLen = cfg?.CameraArmLength ?? 0f;
            float mul = cfg?.CameraDistanceMul ?? 0f;
            if (mul <= 0f) mul = 3.0f;

            // 包围盒：部分 Boss（尤其 TAMER 单位刚生成时）返回偏小，所以多个来源都取，按最大者结算
            float boundsR = 0f;
            try
            {
                boss.GetActorBounds(false, out FVector _, out FVector extent);
                boundsR = Math.Max(extent.X, Math.Max(extent.Y, extent.Z));
            }
            catch (Exception ex) { Log.Warn($"[NativeTrans] 取 Boss 包围盒失败: {ex.Message}"); }

            float capsuleHH = 0f;
            try
            {
                var cap = (object?)boss.GetType().GetProperty("CapsuleComponent")?.GetValue(boss)
                          ?? boss.GetType().GetField("CapsuleComponent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(boss);
                if (cap != null)
                {
                    var hhM = FindMember(cap, "CapsuleHalfHeight");
                    if (hhM != null && hhM.Value.Get(cap) is float hh && hh > 0f) capsuleHH = hh; // 半高，与包围盒半径同量级
                }
            }
            catch (Exception ex) { Log.Warn($"[NativeTrans] 取 Boss 尺寸失败: {ex.Message}"); }

            float socketSize = EstimateUnitSize(boss);

            float radius = Math.Max(Math.Max(boundsR, capsuleHH), socketSize * 0.5f);
            string src = boundsR >= capsuleHH && boundsR >= socketSize * 0.5f ? "bounds"
                       : capsuleHH >= socketSize * 0.5f ? "capsule"
                       : socketSize > 0f ? "socket" : "default";
            if (radius <= 0f) src = "default";

            float camArm = radius > 0f ? radius * mul : 2500f * mul;
            if (explicitLen > 0f) camArm = Math.Max(camArm, explicitLen); // 显式值当下限，不会被自动值改小，也不会把自动值压小
            camArm = Math.Min(Math.Max(camArm, 450f), 60000f);            // 450 为原默认下限；上限防异常值
            diag = $"src={src} boundsR={boundsR:F0} capsuleHH={capsuleHH:F0} socketS={socketSize:F0} " +
                   $"radius={radius:F0} mul={mul} explicit={explicitLen:F0} camArm={camArm:F0}";
            return camArm;
        }

        /// <summary>
        /// 把臂长写进相机系统数据源（BUC_CameraState）。相机每帧会用这里的默认臂长重算
        /// CameraBoom.TargetArmLength，只改组件属性会被立刻覆盖（表现：视角贴脸、Boss 堵满屏幕）。
        /// 四个距离档位全部改掉，避免当前档位不是 Default 时设置不生效。
        /// </summary>
        private static void ApplyCameraArmLength(float camArm)
        {
            if (camArm <= 0f) return;
            _camArmTarget = camArm;
            try
            {
                var st = GetCameraState();
                if (st == null)
                {
                    Log.Warn("[NativeTrans][camarm] 未取到 BUC_CameraState，臂长只改了 CameraBoom（可能被每帧覆盖）");
                    return;
                }
                if (!_camArmApplied)
                {
                    _origArmLenDefault = GetCamFloat(st, "OriginDefaultArmLengthDefault", -1f);
                    _origArmLenClose = GetCamFloat(st, "DefaultArmLengthClose", -1f);
                    _origArmLenNormal = GetCamFloat(st, "DefaultArmLengthNormal", -1f);
                    _origArmLenFar = GetCamFloat(st, "DefaultArmLengthFar", -1f);
                    _origArmLenSpeed = GetCamFloat(st, "DefaultArmLengthLerpSpeed", -1f);
                    _camArmApplied = true;
                }
                SetCamFloat(st, "OriginDefaultArmLengthDefault", camArm); // 每帧由它派生 DefaultArmLengthDefault
                SetCamFloat(st, "DefaultArmLengthDefault", camArm);
                SetCamFloat(st, "DefaultArmLengthClose", camArm);
                SetCamFloat(st, "DefaultArmLengthNormal", camArm);
                SetCamFloat(st, "DefaultArmLengthFar", camArm);
                float speed = _origArmLenSpeed > 0f ? _origArmLenSpeed : 6f;
                SetCamFloat(st, "DefaultArmLengthLerpSpeed", Math.Max(speed, 20f)); // 加快拉远过渡
            }
            catch (Exception e) { Log.Warn($"[NativeTrans][camarm] 写入相机臂长异常: {e.Message}"); }
        }

        /// <summary>相机表在切换相机 ID（走/跑/冲刺）时会被重新加载并覆盖臂长/相对位置，这里定期校正回来</summary>
        private static void KeepCameraArmLength()
        {
            if (!_camArmApplied && !_camRelApplied) return;
            var st = GetCameraState();
            if (st == null) return;

            if (_camArmApplied && _camArmTarget > 0f)
            {
                float cur = GetCamFloat(st, "OriginDefaultArmLengthDefault", _camArmTarget);
                if (Math.Abs(cur - _camArmTarget) > 1f) ApplyCameraArmLength(_camArmTarget);
            }

            if (_camRelApplied)
            {
                FVector want = new FVector(
                    _origDefaultArmLocation.X + _camRelOffset.X,
                    _origDefaultArmLocation.Y + _camRelOffset.Y,
                    _origDefaultArmLocation.Z + _camRelOffset.Z);
                FVector cur = GetCamVec(st, "DefaultArmLocation", want);
                if (Math.Abs(cur.X - want.X) > 1f || Math.Abs(cur.Y - want.Y) > 1f || Math.Abs(cur.Z - want.Z) > 1f)
                    ApplyCameraRelativeLocation(_camRelOffset);
            }
        }

        /// <summary>变回时把相机系统臂长还原成变身前的值</summary>
        private static void RestoreCameraArmLength()
        {
            RestoreCameraRelativeLocation();
            if (!_camArmApplied) return;
            try
            {
                var st = GetCameraState();
                if (st != null)
                {
                    if (_origArmLenDefault >= 0f)
                    {
                        SetCamFloat(st, "OriginDefaultArmLengthDefault", _origArmLenDefault);
                        SetCamFloat(st, "DefaultArmLengthDefault", _origArmLenDefault);
                    }
                    if (_origArmLenClose >= 0f) SetCamFloat(st, "DefaultArmLengthClose", _origArmLenClose);
                    if (_origArmLenNormal >= 0f) SetCamFloat(st, "DefaultArmLengthNormal", _origArmLenNormal);
                    if (_origArmLenFar >= 0f) SetCamFloat(st, "DefaultArmLengthFar", _origArmLenFar);
                    if (_origArmLenSpeed >= 0f) SetCamFloat(st, "DefaultArmLengthLerpSpeed", _origArmLenSpeed);
                    Log.Info($"[NativeTrans][camarm] 已还原相机臂长 default={_origArmLenDefault:F0} speed={_origArmLenSpeed:F0}");
                }
            }
            catch (Exception e) { Log.Warn($"[NativeTrans][camarm] 还原相机臂长异常: {e.Message}"); }
            _camArmApplied = false;
            _camArmTarget = 0f;
        }

        /// <summary>
        /// 运行时注册组件。本机引用程序集里 UActorComponent 没暴露 RegisterComponent，
        /// 这里用反射兼容（DLL 若有该方法就注册，没有则只记录日志）。
        /// </summary>
        private static void TryRegisterComponent(UActorComponent comp)
        {
            string[] candidates = { "RegisterComponent", "RegisterComponentWithWorld", "OnRegister" };
            foreach (var name in candidates)
            {
                try
                {
                    MethodInfo? mi = comp.GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                        null, Type.EmptyTypes, null);
                    if (mi != null)
                    {
                        mi.Invoke(comp, null);
                        return;
                    }
                }
                catch (Exception e) { Log.Warn($"[NativeTrans] {name} 调用失败: {e.Message}"); }
            }
            Log.Warn($"[NativeTrans] 未找到组件注册方法，组件可能不可用: {comp.GetType().Name}");
        }

        private static void DestroyInjectedCamera()
        {
            try { _camComp?.DestroyComponent(_camComp); } catch { }
            try { _armComp?.DestroyComponent(_armComp); } catch { }
            _camComp = null;
            _armComp = null;
        }

        // ---------------------------------------------------------------- 变身后的延迟处理（换皮 / 重试补组件）

        private static void SchedulePostSetup()
        {
            _postTimer?.Dispose();
            _postTimer = new Timer(_ =>
            {
                _postTimer?.Dispose();
                _postTimer = null;
                // PostSetup 里有换皮 / 建组件等 UObject 操作，必须投递到游戏线程
                try { FThreading.RunOnGameThreadAsync(PostSetup); } catch { }
            }, null, PostSetupDelayMs, Timeout.Infinite);
        }

        private static void PostSetup()
        {
            var unit = Unit;
            var cfg = _cfg;
            if (unit == null || cfg == null || !IsActive) return;

            // 1) Reskin：用 soulBossConfig 的幻化配置把基底单位的外观换成 Boss
            if (_mode == "Reskin" && (cfg.MagicId ?? 0) > 0)
            {
                try
                {
                    var conf = ActionExecutor.getMagicConfig(unit, cfg.MagicId!.Value);
                    if (conf == null)
                    {
                        Log.Warn($"[NativeTrans] 找不到幻化配置 MagicID={cfg.MagicId}，跳过换外观");
                    }
                    else
                    {
                        BUS_EventCollectionCS.Get(unit)?.Evt_OnCastMagicallyChangeSkill.Invoke(
                            conf, cfg.MagicSkillId ?? 0, cfg.MagicBackSkillId ?? 0);
                        Log.Info($"[NativeTrans] 已套用幻化外观 MagicID={cfg.MagicId}");
                    }
                }
                catch (Exception e) { Log.Error($"[NativeTrans] 套用幻化外观异常: {e.Message}"); }
            }

            // 2) Direct：BeginPlay 之后重试一次补组件（Possess 阶段 ECSWorld 可能还没就绪）
            if (_mode == "Direct" && cfg.AttachPlayerComps)
            {
                if (FindComp(unit, ResolveType("BUS_PlayerInputActionComp")) == null)
                {
                    Log.Info("[NativeTrans] BeginPlay 后重试补挂玩家组件");
                    AttachPlayerComps(unit, cfg);
                }
            }

            // 3) 变身加成 Buff
            if ((cfg.BuffId ?? 0) > 0)
            {
                try
                {
                    BGUFunctionLibraryCS.BGUAddBuff(unit, unit, cfg.BuffId!.Value, EBuffSourceType.GM, -1f);
                    Log.Info($"[NativeTrans] 变身附加 Buff={cfg.BuffId}");
                }
                catch (Exception e) { Log.Error($"[NativeTrans] 附加 Buff 异常: {e.Message}"); }
            }
        }

        // ---------------------------------------------------------------- 单位事件 / 输入打招

        private static void SubscribeUnit(BGUCharacterCS unit)
        {
            try
            {
                // 死亡事件始终订阅在变身单位(boss)上
                var ev = BUS_EventCollectionCS.Get(unit);
                if (ev != null)
                {
                    ev.Evt_UnitDead -= new Del_UnitDead(OnUnitDead);
                    ev.Evt_UnitDead += new Del_UnitDead(OnUnitDead);
                }

                // 输入来源：Direct 模式现在已 Possess Boss，Boss 本身就是受控 Pawn，输入直接来自 Boss，订阅变身单位即可；
                // Reskin/原生模式受控 pawn 也是变身单位本身。
                BGUCharacterCS inputSrc = unit;
                var iev = BUS_EventCollectionCS.Get(inputSrc);
                if (iev != null)
                {
                    iev.Evt_InputCastSkill -= new Del_InputCastSkill(OnUnitInputCastSkill);
                    iev.Evt_InputCastSkill += new Del_InputCastSkill(OnUnitInputCastSkill);
                }
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 订阅单位事件失败: {e.Message}"); }
        }

        private static void UnsubscribeUnit(bool destroyCam)
        {
            var unit = Unit;
            if (unit != null)
            {
                try
                {
                    var ev = BUS_EventCollectionCS.Get(unit);
                    if (ev != null)
                    {
                        ev.Evt_InputCastSkill -= new Del_InputCastSkill(OnUnitInputCastSkill);
                        ev.Evt_UnitDead -= new Del_UnitDead(OnUnitDead);
                    }
                }
                catch { }
            }
            // Direct 模式输入订阅在玩家(悟空)上，也要取消
            if (!Gone(_originPlayer) && !ReferenceEquals(_originPlayer, unit))
            {
                try
                {
                    var pev = BUS_EventCollectionCS.Get(_originPlayer);
                    if (pev != null) pev.Evt_InputCastSkill -= new Del_InputCastSkill(OnUnitInputCastSkill);
                }
                catch { }
            }
            if (destroyCam) DestroyInjectedCamera();
        }

        /// <summary>
        /// 变身单位的输入事件：按 transConfig 的连招链释放 Boss 技能。
        /// 单位若是游戏原生变身单位（自带玩家输入链路），这里就能拿到 LightAttack/HeavyAttack/Dodge 等输入。
        /// </summary>
        private static void OnUnitInputCastSkill(EInputActionType InputActionType, bool IsRelease, int SkillID, int DescID, int ItemID)
        {
            if (!IsActive || IsRelease) return;
            var unit = Unit;
            if (unit == null) return;

            TransConfig? cfg = _cfg;
            if (cfg == null)
            {
                int resId = unit.GetResID();
                cfg = ActionExecutor.GetTransConfig(resId);
                if (cfg != null) _cfg = cfg;
            }
            if (cfg == null) return;

            switch (InputActionType)
            {
                case EInputActionType.LightAttack:
                    CastCombo(cfg.LightAttackCombo, ref _lightIdx);
                    break;
                case EInputActionType.HeavyAttack:
                    CastCombo(cfg.HeavyAttackCombo, ref _heavyIdx);
                    break;
                case EInputActionType.Dodge:
                    if (cfg.UseGeneralDodge) return; // 保留原生位移闪避
                    CastCombo(cfg.DodgeCombo, ref _dodgeIdx);
                    break;
                case EInputActionType.UseVigorSkill:
                case EInputActionType.UseSkillByType:
                case EInputActionType.CastItemSkill:
                    {
                        int slot = GetSpellSlot(SkillID);
                        if (slot == 0) CastCombo(cfg.Spell1Combo, ref _spell1Idx);
                        else if (slot == 1) CastCombo(cfg.Spell2Combo, ref _spell2Idx);
                        else CastCombo(cfg.Spell3Combo, ref _spell3Idx);
                    }
                    break;
            }
        }

        /// <summary>释放连招链的当前步：断技能→清 CD→cast→加硬直 buff→索引前进循环</summary>
        private static void CastCombo(List<TransComboStep>? list, ref int idx)
        {
            if (list == null || list.Count == 0) return;
            var unit = Unit;
            if (unit == null) return;

            if (BGUFunctionLibraryCS.BGUHasBuffByID(unit, LockBuffId)) return; // 硬直期间忽略

            if (idx < 0 || idx >= list.Count) idx = 0;
            TransComboStep step = list[idx];
            try
            {
                BGUFunctionLibraryCS.BGUTriggerUnitState(unit, EBUStateTrigger.SkillBreak, -1f);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(unit, EBGUSimpleState.CancelSkillCD, false);
                BGUFunctionLibraryCS.BGUTryCastSpell(unit, step.SkillId, ECastSkillSourceType.Default);
                float lockTime = step.LockTime > 0f ? step.LockTime : 600f;
                BGUFunctionLibraryCS.BGUAddBuff(unit, unit, LockBuffId, EBuffSourceType.GM, lockTime);
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 出招异常 skill={step.SkillId}: {e.Message}"); }

            idx = (idx + 1) % list.Count;
        }

        /// <summary>法术键 SkillID → 槽位(0/1/2)：按首次出现顺序分配</summary>
        private static int GetSpellSlot(int skillId)
        {
            if (_spellSlotMap.TryGetValue(skillId, out int slot)) return slot;
            slot = _spellSlotMap.Count % 3;
            _spellSlotMap[skillId] = slot;
            return slot;
        }

        private static void ResetCombo()
        {
            _lightIdx = _heavyIdx = _dodgeIdx = _spell1Idx = _spell2Idx = _spell3Idx = 0;
            _spellSlotMap.Clear();
        }

        private static void OnUnitDead(AActor Attacker, EDeadReason DeadReason, int DmgID, int StiffLevel,
            UAnimMontage BeAttackedAM, FEffectInstReq EffectInstReq, bool bIsDotDmg, EAbnormalStateType AbnormalStateType)
        {
            Log.Info($"[NativeTrans] 变身单位死亡 reason={DeadReason}");
            bool autoBack = _cfg?.TransBackOnDeath ?? true;
            if (autoBack) EndTrans();
        }

        // ---------------------------------------------------------------- 守护轮询

        private static void StartWatchdog()
        {
            _watchdog?.Dispose();
            // WatchdogTick 里有 SetActorTransform / BGUAddBuff / 反射读属性等 UObject 读写，必须投递到游戏线程
            _watchdog = new Timer(_ => PostWatchdogTick(), null, WatchdogIntervalMs, WatchdogIntervalMs);
        }

        private static void StopWatchdog()
        {
            _watchdog?.Dispose();
            _watchdog = null;
        }

        /// <summary>
        /// 把一次守护 tick 投递到游戏线程（异步，不阻塞 Timer 线程）。
        /// 守护逻辑里有 SetActorTransform（带 sweep）、BGUAddBuff、GetAttrValue、反射读属性，
        /// 跨线程操作 UObject 会和游戏线程抢锁，是变身期间卡顿/卡死的高风险点。
        /// </summary>
        private static void PostWatchdogTick()
        {
            // 上一次投递还没执行完 → 跳过本次，避免 40ms 高频下回调堆积
            if (Interlocked.CompareExchange(ref _watchdogPending, 1, 0) != 0) return;
            try
            {
                FThreading.RunOnGameThreadAsync(() =>
                {
                    try { WatchdogTick(); }
                    catch (Exception e) { Log.Error($"[NativeTrans] 守护轮询异常: {e.Message}"); }
                    finally { Interlocked.Exchange(ref _watchdogPending, 0); }
                });
            }
            catch
            {
                Interlocked.Exchange(ref _watchdogPending, 0);
            }
        }

        private static void WatchdogTick()
        {
            if (!IsActive) { StopWatchdog(); return; }
            _tickCount++;

            var unit = Unit;
            if (unit == null)
            {
                Log.Warn("[NativeTrans] 变身单位失效，结束变身");
                EndTrans();
                return;
            }

            // 诊断：每 20 帧打印本尊与 Boss 位置，定位"自动前飞"到底是哪一方在动
            if (_tickCount % 20 == 0 && !Gone(_originPlayer))
            {
                var wp = _originPlayer!.GetActorLocation();
                var bp = unit.GetActorLocation();
                // 相机诊断：真实"相机→Boss"距离比 TargetArmLength 更能反映有没有贴脸
                string camInfo = "";
                try
                {
                    float armNow = -1f;
                    var boom = (USceneComponent?)(object?)_originPlayer!.CameraBoom1;
                    if (boom != null)
                    {
                        var am = FindMember(boom, "TargetArmLength");
                        if (am != null && am.Value.Get(boom) is float fa) armNow = fa;
                    }
                    float dist = -1f;
                    var follow = (USceneComponent?)(object?)_originPlayer!.FollowCamera;
                    if (follow != null)
                    {
                        var cp = follow.GetWorldLocation();
                        float dx = cp.X - bp.X, dy = cp.Y - bp.Y, dz = cp.Z - bp.Z;
                        dist = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
                    }
                    // POV = 真正用于渲染的相机位置（PlayerCameraManager），与 FollowCamera 位置对比就能看出
                    // 渲染相机到底用的是我们挂的那台，还是退化成了 Boss 位置
                    float povDist = -1f;
                    try
                    {
                        var camMgr = _pc?.PlayerCameraManager;
                        if (camMgr != null)
                        {
                            var pp = camMgr.GetCameraLocation();
                            float ax = pp.X - bp.X, ay = pp.Y - bp.Y, az = pp.Z - bp.Z;
                            povDist = (float)Math.Sqrt(ax * ax + ay * ay + az * az);
                        }
                    }
                    catch { }
                    string vtName = "";
                    try { vtName = _pc?.GetViewTarget()?.GetName() ?? "null"; } catch { }
                    if (vtName.Length > 20) vtName = vtName.Substring(0, 20);
                    camInfo = $" armNow={armNow:F0} followDist={dist:F0} povDist={povDist:F0} vtShort={vtName}";
                }
                catch { }
                Log.Info($"[NativeTrans][diag] wukong=({wp.X:F0},{wp.Y:F0},{wp.Z:F0}) boss=({bp.X:F0},{bp.Y:F0},{bp.Z:F0}){camInfo}");
            }

            try
            {
                var cfg = _cfg;
                // Direct 模式：Boss 不 Possess，由悟空（受控）驱动；这里每帧把 Boss 的 Transform 同步成悟空，
                // 使玩家"移动/转向"直接作用在 Boss 上。
                if (_mode == "Direct" && !Gone(_originPlayer) && !ReferenceEquals(_originPlayer, unit))
                {
                    // Possess Boss 后 Boss 自主移动（玩家直接操控），这里让隐藏的悟空每帧 teleport 跟随 Boss，
                    // 仅用于变回时悟空能正确归位；悟空无碰撞，不会与 Boss 互相干扰。
                    try
                    {
                        FHitResult sweepHit = new FHitResult();
                        _originPlayer.SetActorTransform(unit.GetActorTransform(), false, out sweepHit, true);
                    }
                    catch (Exception ex) { Log.Warn($"[NativeTrans] 本尊跟随同步异常: {ex.Message}"); }
                }

                // 相机表在切换相机 ID 时会被重载并覆盖臂长，定期校正回拉远值（每 3 次轮询 ≈ 120ms）
                if (_tickCount % 3 == 0) KeepCameraArmLength();

                // 持续封 AI（部分 buff 会被清）
                if ((cfg?.DisableAI ?? true) && !BGUFunctionLibraryCS.BGUHasBuffByID(unit, DisableAIBuffId))
                    BGUFunctionLibraryCS.BGUAddBuff(unit, unit, DisableAIBuffId, EBuffSourceType.GM, -1f);

                // 死亡兜底（Evt_UnitDead 订阅若因单位重复/事件顺序没触发，这里还能捡到）
                bool dead = false;
                try { dead = BGUFunctionLibraryCS.GetAttrValue(unit, (EBGUAttrFloat)151) <= 0f; } catch { }
                if (dead && (cfg?.TransBackOnDeath ?? true))
                {
                    Log.Info("[NativeTrans] 检测到变身单位血量归零，自动变回");
                    EndTrans();
                }
            }
            catch (Exception e) { Log.Error($"[NativeTrans] 守护轮询异常: {e.Message}"); }
        }

        private static void ClearRuntime()
        {
            IsActive = false;
            _pendingBegin = false;
            _unit = null;
            _tamer = null;
            _tamerGuid = "";
            _originPlayer = null;
            _cfg = null;
            _mode = "";
            _pc = null;
            _armComp = null;
            _camComp = null;
            _origCamParent = null;
            _camArmTarget = 0f;
            _camArmApplied = false;
            _camRelOffset = FVector.ZeroVector;
            _camRelApplied = false;
            ResetCombo();
        }
    }
}
