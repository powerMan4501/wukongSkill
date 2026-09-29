using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

#pragma warning disable CS8600, CS8602, CS8604, CS8625

namespace MagicMod
{
    /// <summary>
    /// 抓投（AnimationSync）目标形态自动替换。
    /// 背景：被抓投方（Guest）在 BUS_AnimationSyncGuestComp 里会先 StopAnimMontage，
    /// 之后直接播放 Host 当前那条 Montage（OnGuestSyncMontage）。UAnimMontage 绑定具体 Skeleton，
    /// 目标骨骼不匹配就播不出来 —— 表现为"目标只是停住不动"。
    /// 本模块在自己（Host）抓投判定成功、真正开始播同步动画之前，把被投者的
    /// SkeletalMesh + AnimBP 临时替换成能播该 Montage 的形态（默认玩家本体/悟空），结束后还原。
    /// 走的是游戏自己"法相变身"用的同一条链路：
    /// BUS_EventCollectionCS.Evt_ChangeSkeletalMeshWithABP → BUS_ABPHelperComp.OnChangeSkeletalMeshWithABP。
    /// </summary>
    public static class GrabSyncGuestFix
    {
        #region 配置

        /// <summary>
        /// 总开关。
        /// 注意：即使为 true，抓投检测/接管也只在"投技窗口"内生效 —— 即动作里配了 grabConfig
        /// （或显式使用 grab / grabscan 动作）时才会打开窗口，普通技能完全不受影响。
        /// </summary>
        public static bool Enabled = true;

        /// <summary>轮询间隔（ms）：跟随受控 Pawn 变化重新订阅 + 兜底还原</summary>
        public static int TickMs = 200;

        /// <summary>兜底还原超时（秒）：超时没收到结束事件就强制还原，防止残留</summary>
        public static float SafetyTimeoutSec = 15f;

        /// <summary>优先使用玩家（你）变身前的本体形态作为被投形态</summary>
        public static bool UsePlayerOriginalForm = true;

        /// <summary>骨骼兼容优先：优先挑骨骼与同步动画一致的候选；都匹配不上时取第一个可用的</summary>
        public static bool AutoMatchSkeleton = true;

        /// <summary>强制指定被投形态的 SkeletalMesh 资源路径（留空不启用）</summary>
        public static string? ForcedSKMeshPath = null;

        /// <summary>强制指定被投形态的 AnimBP 资源（留空不启用）</summary>
        public static UClass? ForcedABPClass = null;

        #endregion

        /// <summary>被投者处理方式</summary>
        public enum GuestMode
        {
            /// <summary>换成能播同步动画的形态（原行为）</summary>
            Swap,
            /// <summary>整只隐藏，抓投结束恢复（吞入/抱入类投技防穿模）</summary>
            Hide
        }

        private static Timer? _timer;
        private static readonly object _lock = new object();

        private static BGUCharacterCS? _self;
        private static Del_NotifyEnterPreAnimationSyncingState? _preHandler;
        private static Del_NotifyEndSyncAnimation? _endHandler;

        // 玩家本体形态缓存（变身前记录，变身期间也能拿到）
        private static bool _hasCachedForm;
        private static USkeletalMesh? _cachedFormMesh;
        private static TSubclassOf<UAnimInstance> _cachedFormAbp;

        private sealed class SwapRecord
        {
            public AActor Guest = null!;
            public USkeletalMesh Mesh = null!;
            public TSubclassOf<UAnimInstance> Abp;
            public DateTime StartTime;

            /// <summary>本次是换形态还是隐藏</summary>
            public GuestMode Mode = GuestMode.Swap;

            /// <summary>隐藏前的可见状态（隐藏模式用，恢复时原样写回）</summary>
            public bool WasHidden;

            /// <summary>隐藏前的碰撞开关（仅 DisableCollision 生效时记录）</summary>
            public bool WasCollisionEnabled;

            /// <summary>隐藏时是否只隐藏了骨骼网格（false = 整只 Actor）</summary>
            public bool HiddenMeshOnly;

            /// <summary>隐藏时是否关过碰撞（决定结束时是否写回）</summary>
            public bool HiddenCollision;

            /// <summary>抓投期间加上的 Buff（结束时按需移除）</summary>
            public List<int>? AddedBuffs;

            /// <summary>结束时是否移除 AddedBuffs</summary>
            public bool RemoveBuffsOnEnd;

            /// <summary>缩放前的原始 Scale3D</summary>
            public FVector OrigScale = new FVector(1f, 1f, 1f);

            /// <summary>是否改过缩放（决定结束时是否还原）</summary>
            public bool ScaleChanged;

            /// <summary>抓投期间是否取消了镜头锁定</summary>
            public bool ClearLock;

            /// <summary>取消锁定时是否连单位目标信息一起清空</summary>
            public bool ClearTargetInfo;

            /// <summary>结束时是否重新锁定原目标</summary>
            public bool RelockOnEnd;

            /// <summary>取消锁定前原本锁定的目标（结束时用于重新锁定）</summary>
            public AActor? SavedLockTarget;
        }

        private static SwapRecord? _record;

        // ===== 动作下发的抓投配置（grabConfig）=====
        // 动作执行时先"预约"，抓投预检测成功（OnPreAnimationSyncOnHost）时消费一次。
        private static GrabConfig? _pendingCfg;
        private static DateTime _pendingUntil = DateTime.MinValue;

        // ===== 投技窗口 =====
        // 只有「动作里配了 grabConfig 的动作」执行时才打开本窗口（见 RequestGrab）。
        // 窗口打开期间才：订阅抓投事件、做 Montage 抓投诊断、走 200ms 抓投维护；
        // 窗口外（普通技能/普攻/连招）完全不碰抓投逻辑 —— 不订阅、不扫描 Notify、不诊断，
        // 这是之前"放技能就卡顿/卡死"的主要来源之一。
        private static DateTime _armedUntil = DateTime.MinValue;

        /// <summary>当前是否处于投技窗口内（配了 grabConfig 的动作刚执行过）</summary>
        private static bool IsArmed => DateTime.Now < _armedUntil;

        #region 生命周期

        public static void Init()
        {
            lock (_lock)
            {
                if (_timer != null) return;
                _timer = new Timer(_ => Utils.TryRunOnGameThread(Tick), null, TickMs, TickMs);
                Log.Info($"[GrabSync] 已启动（tick={TickMs}ms, 超时={SafetyTimeoutSec}s）");
            }
        }

        public static void DeInit()
        {
            lock (_lock)
            {
                try { Unsubscribe(); } catch { }
                try { Restore(); } catch { }
                _timer?.Dispose();
                _timer = null;
                _self = null;
                _pendingCfg = null;
                _pendingUntil = DateTime.MinValue;
                _armedUntil = DateTime.MinValue;
                Log.Info("[GrabSync] 已停止");
            }
        }

        #endregion

        #region 轮询：绑定自己 / 兜底还原 / 缓存本体形态

        private static void Tick()
        {
            if (!Enabled)
            {
                Restore();
                return;
            }

            // 不在投技窗口内、也没有正在进行的抓投 → 本轮直接跳过，零开销。
            // 投技窗口只由「动作里配了 grabConfig」的动作打开（RequestGrab），
            // 所以普通技能 / 普攻 / 连招不会再触发抓投事件订阅、Montage 诊断扫描等逻辑。
            if (!IsArmed && _record == null)
            {
                if (_preHandler != null) Unsubscribe(); // 窗口结束：退订抓投事件，之后不再收到抓投回调
                return;
            }

            try
            {
                var self = SafeGetControlledPawn();
                if (self == null || self.IsNullOrDestroyed())
                {
                    Unsubscribe();
                    _self = null;
                    Restore();
                    return;
                }

                // 受控单位变化（傀儡附身 / 原生变身 / 切场景）→ 重新订阅到新的 Host
                if (!ReferenceEquals(_self, self))
                {
                    Unsubscribe();
                    _self = self;
                    Restore();
                    Subscribe();
                }

                CachePlayerOriginalForm(self);

                TraceMontageChange();

                var rec = _record;
                if (rec != null)
                {
                    if ((DateTime.Now - rec.StartTime).TotalSeconds > SafetyTimeoutSec)
                    {
                        Log.Warn("[GrabSync] 超时未收到同步结束事件，强制还原被投形态");
                        Restore();
                    }
                    else if (rec.Guest == null || rec.Guest.IsNullOrDestroyed())
                    {
                        Log.Warn("[GrabSync] 被投单位已失效，放弃还原");
                        _record = null;
                    }
                    else if (rec.ClearLock)
                    {
                        // 抓投期间持续清锁定：自动锁定/技能逻辑可能把目标抢回来，每 tick 刷一次
                        ClearLockOnHost(rec, false);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] Tick 异常: {e.Message}\n{e.StackTrace}");
            }
        }

        /// <summary>安全获取受控 Pawn，避免游戏加载初期 GetWorld/GetPlayerController 为空时空引用</summary>
        private static BGUCharacterCS? SafeGetControlledPawn()
        {
            try
            {
                return ModUtils.GetControlledPawn() as BGUCharacterCS;
            }
            catch (Exception e)
            {
                Log.Warn($"[GrabSync] 取受控单位失败: {e.Message}");
                return null;
            }
        }

        /// <summary>尽早把玩家的本体形态（Mesh + AnimBP）记下来，变身期间也能用</summary>
        private static void CachePlayerOriginalForm(BGUCharacterCS self)
        {
            try
            {
                if (self == null || self.IsNullOrDestroyed()) return;

                if (self is BGUPlayerCharacterCS pc && !pc.IsNullOrDestroyed()
                    && pc.Mesh != null && !pc.Mesh.IsNullOrDestroyed()
                    && ModHelper.IsWuKong(pc)
                    && pc.Mesh.SkeletalMesh != null)
                {
                    _cachedFormMesh = pc.Mesh.SkeletalMesh;
                    _cachedFormAbp = pc.Mesh.AnimClass;
                    _hasCachedForm = true;
                    return;
                }

                if (_hasCachedForm) return;

                // 变身中的玩家：BUS_MagicallyChangeComp.MagicallyChangeData.DefaultConfig 里存着变身前的形态
                TryCacheFromMagicallyChangeData(self);
            }
            catch (Exception e)
            {
                Log.Warn($"[GrabSync] 缓存本体形态失败: {e.Message}\n{e.StackTrace}");
            }
        }

        private static void TryCacheFromMagicallyChangeData(BGUCharacterCS character)
        {
            var comp = ModHelper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (comp == null) return;

            FieldInfo? fieldData = typeof(BUS_MagicallyChangeComp)
                .GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldData == null) return;

            if (fieldData.GetValue(comp) is BUC_MagicallyChangeData data && data.DefaultConfig != null)
            {
                USkeletalMesh? mesh = data.DefaultConfig.SKMesh?.Get();
                if (mesh == null || mesh.IsNullOrDestroyed()) return;
                _cachedFormMesh = mesh;
                _cachedFormAbp = data.DefaultConfig.ABPClass;
                _hasCachedForm = true;
            }
        }

        #endregion

        #region 抓投事件订阅

        private static void Subscribe()
        {
            if (_self == null) return;
            var bus = BUS_EventCollectionCS.Get(_self);
            if (bus == null)
            {
                Log.Warn("[GrabSync] 取不到自己的事件总线，订阅失败");
                return;
            }

            _preHandler = OnPreAnimationSyncOnHost;
            _endHandler = OnEndSyncAnimationOnHost;
            bus.Evt_NotifyEnterPreAnimationSyncingStateOnHost += _preHandler;
            bus.Evt_NotifyEndSyncAnimationOnHost += _endHandler;
            Log.Info($"[GrabSync] 已订阅抓投事件: {_self.GetName()}");
        }

        private static void Unsubscribe()
        {
            if (_self == null || _self.IsNullOrDestroyed()) return;
            var bus = BUS_EventCollectionCS.Get(_self);
            if (bus == null) return;
            if (_preHandler != null) bus.Evt_NotifyEnterPreAnimationSyncingStateOnHost -= _preHandler;
            if (_endHandler != null) bus.Evt_NotifyEndSyncAnimationOnHost -= _endHandler;
            _preHandler = null;
            _endHandler = null;
        }

        /// <summary>
        /// 抓投判定成功（BGS_AnimationSyncSystem.OnPreCheckSuccess → NotifyEnterPreAnimationSyncingState）。
        /// 这时距离真正播同步动画（OnGuestSyncMontage）还有 PreCheck notify 的整段时间，足够切换。
        /// </summary>
        private static void OnPreAnimationSyncOnHost(AActor guest, List<int> buffList)
        {
            // 不在投技窗口内（本次技能没配 grabConfig）→ 不接管被投者，交给游戏默认抓投流程
            if (!IsArmed)
            {
                CancelGrabRequest();
                return;
            }

            GrabConfig? cfg = ConsumePending();

            // 动作里配了 grabConfig.hideGuest：本次抓投改成隐藏被投者（吞进嘴里这类不会穿模）
            if (cfg != null && cfg.hideGuest)
            {
                HideGuest(guest, cfg);
                return;
            }
            ApplyGuestForm(guest, cfg);
        }

        /// <summary>同步动画结束（正常结束 / 被打断都会走这里）</summary>
        private static void OnEndSyncAnimationOnHost(List<int> preList, List<int> list)
        {
            Restore();
        }

        #endregion

        #region 替换 / 还原

        private static void ApplyGuestForm(AActor guest, GrabConfig? cfg = null)
        {
            if (!Enabled) return;
            if (_record != null) Restore();

            if (!(guest is BGUCharacterCS g) || g.IsNullOrDestroyed() || ReferenceEquals(g, _self)) return;
            if (g.Mesh == null || g.Mesh.IsNullOrDestroyed()) return;

            try
            {
                (USkeletalMesh? targetMesh, TSubclassOf<UAnimInstance> targetAbp) = ResolveTargetForm();
                if (targetMesh == null || targetAbp.Value == null)
                {
                    Log.Warn("[GrabSync] 没有可用的被投形态，跳过替换");
                    ApplyExtrasOnly(g, cfg);
                    return;
                }

                if (SameSkeleton(g.Mesh.SkeletalMesh, targetMesh))
                {
                    Log.Info("[GrabSync] 目标已经是可播形态，跳过替换");
                    ApplyExtrasOnly(g, cfg);
                    return;
                }

                _record = new SwapRecord
                {
                    Guest = g,
                    Mesh = g.Mesh.SkeletalMesh,
                    Abp = g.Mesh.AnimClass,
                    Mode = GuestMode.Swap,
                    StartTime = DateTime.Now
                };

                Log.Info($"[GrabSync] {NameOf(g)}: {NameOf(_record.Mesh)} -> {NameOf(targetMesh)}");
                ApplyMesh(g, targetMesh, targetAbp);
                ApplyExtras(_record, cfg);
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 替换被投形态失败: {e.Message}");
            }
        }

        /// <summary>
        /// 预约：紧接着的这次抓投按这份配置处理被投者。
        /// 典型用途：hideGuest（吞进嘴里/抱进怀里这类把目标塞进模型的投技，直接隐藏防穿模）、
        /// Scale3D（把被抓方缩小，塞进模型里更自然）、buffs（抓投期间附加 Buff）。
        /// </summary>
        public static void RequestGrab(GrabConfig cfg)
        {
            if (cfg == null) return;
            int ms = cfg.waitMs > 0 ? cfg.waitMs : 8000;
            _pendingCfg = cfg;
            _pendingUntil = DateTime.Now.AddMilliseconds(ms);
            // 打开投技窗口（多留 2 秒余量给同步动画收尾）并订阅抓投事件：
            // 只有走到这里（动作配了 grabConfig）才会启用抓投相关的全部逻辑。
            _armedUntil = DateTime.Now.AddMilliseconds(ms + 2000);
            ArmGrabDetection();
            Log.Info($"[GrabSync] 已预约抓投配置（窗口 {ms}ms, 隐藏={cfg.hideGuest}, " +
                     $"缩放={(cfg.Scale3D == null ? "无" : $"({cfg.Scale3D.X},{cfg.Scale3D.Y},{cfg.Scale3D.Z})")}, " +
                     $"Buff={(cfg.buffs == null || cfg.buffs.Count == 0 ? "无" : string.Join(",", cfg.buffs))}）");
        }

        /// <summary>
        /// 打开投技检测：绑定当前受控单位并订阅抓投事件。
        /// 只有动作里配了 grabConfig 的动作才会调用；窗口结束后 Tick 会自动退订。
        /// </summary>
        private static void ArmGrabDetection()
        {
            if (!Enabled) return;
            var self = SafeGetControlledPawn();
            if (self == null || self.IsNullOrDestroyed()) return;

            if (!ReferenceEquals(_self, self))
            {
                Unsubscribe();
                _self = self;
            }
            if (_preHandler == null) Subscribe();
            Log.Info($"[GrabSync] 投技窗口已开启（{_armedUntil:HH:mm:ss} 前有效），已启用抓投检测");
        }

        /// <summary>取消预约（同时关闭投技窗口）</summary>
        public static void CancelGrabRequest()
        {
            _pendingCfg = null;
            _pendingUntil = DateTime.MinValue;
            _armedUntil = DateTime.MinValue;
            if (_record == null) { try { Unsubscribe(); } catch { } }
        }

        /// <summary>取走预约（一次性），过期返回 null</summary>
        private static GrabConfig? ConsumePending()
        {
            GrabConfig? cfg = _pendingCfg;
            _pendingCfg = null;
            bool valid = cfg != null && DateTime.Now < _pendingUntil;
            _pendingUntil = DateTime.MinValue;
            return valid ? cfg : null;
        }

        /// <summary>隐藏被投者（不换形态）</summary>
        private static void HideGuest(AActor guest, GrabConfig? cfg = null)
        {
            if (!Enabled) return;
            if (guest == null || guest.IsNullOrDestroyed() || ReferenceEquals(guest, _self)) return;

            // 上一轮还没结束（极端情况：连续抓投）先还原
            if (_record != null) Restore();

            bool wholeActor = cfg?.hideActor ?? true;
            bool disableCollision = cfg?.disableCollision ?? false;

            try
            {
                var rec = new SwapRecord
                {
                    Guest = guest,
                    Mode = GuestMode.Hide,
                    StartTime = DateTime.Now,
                    WasHidden = GetActorHidden(guest)
                };

                if (wholeActor)
                {
                    rec.HiddenMeshOnly = false;
                    guest.SetActorHiddenInGame(true);
                }
                else if (guest is BGUCharacterCS cs && cs.Mesh != null && !cs.Mesh.IsNullOrDestroyed())
                {
                    rec.HiddenMeshOnly = true;
                    rec.WasHidden = GetHiddenFlag(cs.Mesh);
                    cs.Mesh.SetHiddenInGame(true, false);
                }

                if (disableCollision)
                {
                    rec.HiddenCollision = true;
                    rec.WasCollisionEnabled = IsCollisionEnabled(guest);
                    guest.SetActorEnableCollision(false);
                }

                _record = rec;
                Log.Info($"[GrabSync] 隐藏被投者 {NameOf(guest)}（整只={wholeActor}），抓投结束后恢复");

                ApplyExtras(rec, cfg);
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 隐藏被投者失败: {e.Message}");
            }
        }

        /// <summary>
        /// 抓投开始时给被抓方附加的效果（缩放 / Buff）。
        /// 与隐藏/换形态独立：只要动作里配了 grabConfig 就会应用，抓投结束自动还原。
        /// </summary>
        private static void ApplyExtras(SwapRecord rec, GrabConfig? cfg)
        {
            if (cfg == null || rec?.Guest == null) return;
            AActor g = rec.Guest;
            if (g.IsNullOrDestroyed()) return;

            // 缩放：把被抓方缩小（或放大），塞进模型里更自然
            if (cfg.Scale3D != null)
            {
                try
                {
                    rec.OrigScale = g.GetActorTransform().Scale3D;
                    g.SetActorRelativeScale3D(new FVector(cfg.Scale3D.X, cfg.Scale3D.Y, cfg.Scale3D.Z));
                    rec.ScaleChanged = true;
                    Log.Info($"[GrabSync] 缩放被投者 {NameOf(g)} -> ({cfg.Scale3D.X},{cfg.Scale3D.Y},{cfg.Scale3D.Z})");
                }
                catch (Exception e)
                {
                    Log.Warn($"[GrabSync] 缩放被投者失败: {e.Message}");
                }
            }

            // 取消镜头锁定：投技动画期间继续锁着目标会让镜头跟着乱晃
            if (cfg.clearLock && _self != null && !_self.IsNullOrDestroyed())
            {
                rec.ClearLock = true;
                rec.ClearTargetInfo = cfg.clearTargetInfo;
                rec.RelockOnEnd = cfg.relockOnEnd;
                try
                {
                    rec.SavedLockTarget = BGUFunctionLibraryCS.BGUGetTarget(_self);
                }
                catch
                {
                    rec.SavedLockTarget = null;
                }
                ClearLockOnHost(rec, true);
            }

            // Buff：抓投期间附加（默认结束时移除，避免残留）
            if (cfg.buffs != null && cfg.buffs.Count > 0)
            {
                AActor caster = _self ?? g;
                float duration = cfg.buffDuration;
                foreach (int buffId in cfg.buffs)
                {
                    try
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(caster, g, buffId, EBuffSourceType.GM, duration);
                    }
                    catch (Exception e)
                    {
                        Log.Warn($"[GrabSync] 给被投者加 Buff {buffId} 失败: {e.Message}");
                    }
                }
                rec.AddedBuffs = new System.Collections.Generic.List<int>(cfg.buffs);
                rec.RemoveBuffsOnEnd = cfg.removeBuffsOnEnd;
                Log.Info($"[GrabSync] 给被投者 {NameOf(g)} 加 Buff: {string.Join(",", cfg.buffs)}（时长={duration}ms, 结束移除={cfg.removeBuffsOnEnd}）");
            }
        }

        /// <summary>只应用附加效果（跳过形态替换时也走这里）</summary>
        private static void ApplyExtrasOnly(AActor guest, GrabConfig? cfg)
        {
            if (cfg == null || guest == null || guest.IsNullOrDestroyed()) return;
            if (_record != null) return;

            var rec = new SwapRecord
            {
                Guest = guest,
                Mode = GuestMode.Swap,
                StartTime = DateTime.Now
            };
            _record = rec;
            ApplyExtras(rec, cfg);
        }

        /// <summary>取消抓投方（自己）的镜头锁定，必要时连单位目标信息一起清空</summary>
        private static void ClearLockOnHost(SwapRecord rec, bool log = true)
        {
            AActor? host = _self;
            if (host == null || host.IsNullOrDestroyed()) return;

            try
            {
                BUS_EventCollectionCS.Get(host)?.Evt_ClearCameraLock.Invoke();

                if (rec.ClearTargetInfo)
                {
                    BGUFunctionLibraryCS.BGUSetTargetInfo(false, host,
                        new UnitLockTargetInfo(null, ETargetSourceType.CameraLockUpdate));
                }

                if (log) Log.Info($"[GrabSync] 已取消抓投方镜头锁定（清空目标信息={rec.ClearTargetInfo}）");
            }
            catch (Exception e)
            {
                Log.Warn($"[GrabSync] 取消镜头锁定失败: {e.Message}");
            }
        }

        /// <summary>抓投结束：还原缩放 + 移除附加 Buff</summary>
        private static void RestoreExtras(SwapRecord rec)
        {
            AActor g = rec.Guest;
            try
            {
                if (rec.ScaleChanged)
                {
                    g.SetActorRelativeScale3D(rec.OrigScale);
                    Log.Info($"[GrabSync] 还原被投者缩放 {NameOf(g)}");
                }

                if (rec.RemoveBuffsOnEnd && rec.AddedBuffs != null)
                {
                    foreach (int buffId in rec.AddedBuffs)
                    {
                        BGUFunctionLibraryCS.BGURemoveBuff(g, buffId, EBuffEffectTriggerType.None, 1);
                    }
                    Log.Info($"[GrabSync] 移除被投者附加 Buff: {string.Join(",", rec.AddedBuffs)}");
                }

                if (rec.ClearLock && rec.RelockOnEnd)
                {
                    var host = _self;
                    var saved = rec.SavedLockTarget;
                    if (host != null && !host.IsNullOrDestroyed()
                        && saved != null && !saved.IsNullOrDestroyed())
                    {
                        BUS_EventCollectionCS.Get(host)?
                            .Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(saved, ETargetSourceType.None));
                        Log.Info($"[GrabSync] 重新锁定原目标 {NameOf(saved)}");
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 还原抓投附加效果失败: {e.Message}");
            }
        }

        /// <summary>恢复被投者显示</summary>
        private static void ShowGuest(SwapRecord rec)
        {
            AActor g = rec.Guest;
            try
            {
                if (rec.HiddenMeshOnly && g is BGUCharacterCS cs && cs.Mesh != null && !cs.Mesh.IsNullOrDestroyed())
                {
                    cs.Mesh.SetHiddenInGame(rec.WasHidden, false);
                }
                else
                {
                    g.SetActorHiddenInGame(rec.WasHidden);
                }

                if (rec.HiddenCollision)
                {
                    g.SetActorEnableCollision(rec.WasCollisionEnabled);
                }

                Log.Info($"[GrabSync] 恢复被投者显示 {NameOf(g)}");
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 恢复被投者显示失败: {e.Message}");
            }
        }

        /// <summary>读对象当前的隐藏标记（不同版本布尔属性名不一致，反射容错）</summary>
        private static bool GetActorHidden(AActor actor)
        {
            return GetHiddenFlag(actor);
        }

        /// <summary>读任意对象（Actor / 组件）当前的隐藏标记</summary>
        private static bool GetHiddenFlag(object obj)
        {
            foreach (string name in new[] { "bHiddenInGame", "HiddenInGame", "bHidden", "Hidden" })
            {
                try
                {
                    object? v = obj.GetType()
                        .GetProperty(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                        ?.GetValue(obj);
                    if (v is bool b) return b;
                }
                catch
                {
                }
            }
            return false;
        }

        /// <summary>读 Actor 当前的碰撞开关</summary>
        private static bool IsCollisionEnabled(AActor actor)
        {
            try
            {
                object? v = actor.GetType()
                    .GetProperty("bActorEnableCollision", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.GetValue(actor);
                if (v is bool b) return b;
            }
            catch
            {
            }
            return true;
        }

        /// <summary>还原被投者的原始形态 / 恢复显示</summary>
        public static void Restore()
        {
            SwapRecord? rec = _record;
            _record = null;
            if (rec == null) return;

            AActor g = rec.Guest;
            if (g == null || g.IsNullOrDestroyed()) return;

            // 先还原抓投附加效果（缩放 / Buff），再恢复显示或形态
            RestoreExtras(rec);

            if (rec.Mode == GuestMode.Hide)
            {
                ShowGuest(rec);
                return;
            }

            if (rec.Mesh == null || rec.Mesh.IsNullOrDestroyed()) return;
            if (!(g is BGUCharacterCS gc)) return;

            try
            {
                if (SameSkeleton(gc.Mesh?.SkeletalMesh, rec.Mesh)) return;
                Log.Info($"[GrabSync] 还原 {NameOf(gc)} -> {NameOf(rec.Mesh)}");
                ApplyMesh(gc, rec.Mesh, rec.Abp);
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 还原失败: {e.Message}");
            }
        }

        /// <summary>
        /// 换模型 + AnimBP。优先走事件（会自动重建 AnimInst 缓存）；
        /// 有些单位没有 BUS_ABPHelperComp，事件无人处理，延迟校验后回退到直接设置。
        /// </summary>
        private static void ApplyMesh(BGUCharacterCS guest, USkeletalMesh mesh, TSubclassOf<UAnimInstance> abp)
        {
            if (guest == null || guest.IsNullOrDestroyed() || mesh == null) return;

            try
            {
                BUS_EventCollectionCS.Get(guest)?.Evt_ChangeSkeletalMeshWithABP.Invoke(mesh, abp);
                SyncMaterials(guest, mesh);
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 切换形态事件失败: {e.Message}");
            }

            var target = mesh;
            Task.Run(async () =>
            {
                await Task.Delay(120);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        if (guest == null || guest.IsNullOrDestroyed()) return;
                        if (SameSkeleton(guest.Mesh?.SkeletalMesh, target)) return;

                        Log.Warn("[GrabSync] 事件未生效（该单位可能没有 BUS_ABPHelperComp），回退到直接设置");
                        guest.Mesh.SetSkeletalMesh(target);
                        BUS_EventCollectionCS.Get(guest)?.Evt_OnChangeABP.Invoke(abp);
                        SyncMaterials(guest, target);
                    }
                    catch (Exception e)
                    {
                        Log.Error($"[GrabSync] 回退设置失败: {e.Message}");
                    }
                });
            });
        }

        /// <summary>换 Mesh 后同步材质，避免紫模（与 BUS_MagicallyChangeComp.SetSKMesh 一致）</summary>
        private static void SyncMaterials(BGUCharacterCS guest, USkeletalMesh mesh)
        {
            if (guest == null || guest.Mesh == null || mesh == null) return;
            try
            {
                List<FSkeletalMaterial> materials = mesh.GetMaterials();
                for (int i = 0; i < materials.Count; i++)
                {
                    guest.Mesh.SetMaterial(i, materials[i].MaterialInterface);
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[GrabSync] 材质同步失败: {e.Message}");
            }
        }

        #endregion

        #region 形态候选与工具

        /// <summary>
        /// 这套抓投动画是成对的：Host 播 _monster 版，Guest 播 _Player 版。
        /// 所以挑"被投形态"必须按 GuestMontage（被抓方那条）的骨骼来选，不能按 Host 当前 Montage。
        /// </summary>
        private static UAnimMontage? GetGuestMontage(BGUCharacterCS? host)
        {
            UAnimMontage? hostMontage = GetHostSyncMontage(host);
            if (hostMontage == null || hostMontage.IsNullOrDestroyed()) return null;
            try
            {
                // TArrayUnsafe 底层是非托管数组，必须 Dispose（using），否则每次调用泄漏一份
                using (var list = new UnrealEngine.Runtime.TArrayUnsafe<FAnimNotifyEvent>())
                {
                    UGSE_AnimFuncLib.GetAllNotifyEvent(hostMontage, list);
                    if (list == null) return null;
                    foreach (FAnimNotifyEvent item in list)
                    {
                        object? ns = item.NotifyStateClass;
                        if (ns == null) continue;
                        if (ns.GetType().Name == "BANS_GSSyncAnimations")
                        {
                            return ReadProp(ns, "GuestMontage") as UAnimMontage;
                        }
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        /// <summary>被投方实际要播的那套骨骼：优先 GuestMontage，没有才退回 Host 当前 Montage</summary>
        private static USkeleton? GetWantedGuestSkeleton(BGUCharacterCS? host, out string source)
        {
            UAnimMontage? guestMontage = GetGuestMontage(host);
            if (guestMontage != null && !guestMontage.IsNullOrDestroyed())
            {
                try
                {
                    USkeleton? sk = UAnimationAssetExtensions.GetSkeleton(guestMontage);
                    if (sk != null)
                    {
                        source = $"GuestMontage={guestMontage.GetName()}";
                        return sk;
                    }
                }
                catch
                {
                }
            }
            source = "HostMontage（没有 GuestMontage，退回）";
            return GetHostSyncMontageSkeleton(host);
        }

        private static (USkeletalMesh?, TSubclassOf<UAnimInstance>) ResolveTargetForm()
        {
            var candidates = new List<(USkeletalMesh?, TSubclassOf<UAnimInstance>)>();

            // 1) 强制配置（优先级最高）
            if (!string.IsNullOrEmpty(ForcedSKMeshPath))
            {
                try
                {
                    var world = ModUtils.GetWorld();
                    if (world != null)
                    {
                        var mesh = UObject.LoadObject<USkeletalMesh>(world, ForcedSKMeshPath!);
                        var abp = default(TSubclassOf<UAnimInstance>);
                        if (ForcedABPClass != null) abp = new TSubclassOf<UAnimInstance>(ForcedABPClass);
                        if (mesh != null) candidates.Add((mesh, abp));
                    }
                }
                catch (Exception e)
                {
                    Log.Warn($"[GrabSync] 加载强制形态失败: {e.Message}");
                }
            }

            // 2) 玩家本体形态（针对玩家的抓投动画基本都是这套骨骼）
            if (UsePlayerOriginalForm && _hasCachedForm && _cachedFormMesh != null && !_cachedFormMesh.IsNullOrDestroyed())
            {
                candidates.Add((_cachedFormMesh, _cachedFormAbp));
            }

            // 3) 兜底：Host 自己的形态（骨骼必然与自己正在播的 Montage 一致）
            if (_self != null && _self.Mesh != null)
            {
                candidates.Add((_self.Mesh.SkeletalMesh, _self.Mesh.AnimClass));
            }

            if (candidates.Count == 0) return (null, default);

            if (AutoMatchSkeleton)
            {
                USkeleton? wanted = GetWantedGuestSkeleton(_self, out string source);
                if (wanted != null)
                {
                    Log.Info($"[GrabSync] 目标骨骼依据: {source} → {NameOf(wanted)}");
                    foreach (var c in candidates)
                    {
                        if (c.Item1 == null || c.Item2.Value == null) continue;
                        USkeleton? cs = SafeGetSkeleton(c.Item1);
                        if (cs != null && ReferenceEquals(cs, wanted)) return c;
                    }
                    Log.Warn("[GrabSync] 没有候选骨骼与被投动画骨骼匹配，使用第一个可用形态");
                }
            }

            foreach (var c in candidates)
            {
                if (c.Item1 != null && c.Item2.Value != null) return c;
            }
            return candidates[0];
        }

        /// <summary>取 Host 当前正在播的 Montage（Guest 播的就是这条）</summary>
        private static UAnimMontage? GetHostSyncMontage(BGUCharacterCS? host)
        {
            try
            {
                if (host == null || host.IsNullOrDestroyed() || host.Mesh == null) return null;
                return host.Mesh.GetAnimInstance()?.GetCurrentActiveMontage();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>Host 当前同步动画所属骨骼，用来判断该把被投者换成哪套模型</summary>
        private static USkeleton? GetHostSyncMontageSkeleton(BGUCharacterCS? host)
        {
            UAnimMontage? montage = GetHostSyncMontage(host);
            if (montage == null || montage.IsNullOrDestroyed()) return null;
            try
            {
                return UAnimationAssetExtensions.GetSkeleton(montage);
            }
            catch
            {
                return null;
            }
        }

        private static USkeleton? SafeGetSkeleton(USkeletalMesh mesh)
        {
            try
            {
                return mesh.IsNullOrDestroyed() ? null : mesh.GetSkeleton();
            }
            catch
            {
                return null;
            }
        }

        private static bool SameSkeleton(USkeletalMesh? a, USkeletalMesh? b)
        {
            if (a == null || b == null) return false;
            if (ReferenceEquals(a, b)) return true;
            USkeleton? sa = SafeGetSkeleton(a);
            USkeleton? sb = SafeGetSkeleton(b);
            return sa != null && sb != null && ReferenceEquals(sa, sb);
        }

        /// <summary>读取任意对象的同名公共属性（Notify 类是 internal，只能反射）</summary>
        private static object? ReadProp(object obj, string propName)
        {
            try
            {
                return obj.GetType()
                    .GetProperty(propName, BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(obj);
            }
            catch
            {
                return null;
            }
        }

        private static string NameOf(UObject? obj)
        {
            try
            {
                return obj == null || obj.IsNullOrDestroyed() ? "<null>" : obj.GetName();
            }
            catch
            {
                return "<unknown>";
            }
        }

        #endregion

        #region 诊断

        /// <summary>
        /// 播放新的 Montage 时自动打印抓投相关 Notify（用来确认某条技能是否自带抓投）。
        /// 只在"投技窗口"内生效（动作配了 grabConfig），普通技能不会再做全量 Notify 扫描。
        /// </summary>
        public static bool AutoDumpOnMontageChange = true;

        private static UAnimMontage? _lastTracedMontage;

        private static void TraceMontageChange()
        {
            if (!AutoDumpOnMontageChange) return;
            // 只在投技窗口内诊断：DumpMontageNotifyInfo 会遍历全部 AnimNotify 并反射读属性 + 打多条日志，
            // 之前每次换动画（连招每秒好几次）都跑，是明显的游戏线程开销。
            if (!IsArmed && _record == null) return;
            UAnimMontage? cur = GetHostSyncMontage(_self);
            if (ReferenceEquals(cur, _lastTracedMontage)) return;
            _lastTracedMontage = cur;
            if (cur != null) DumpMontageNotifyInfo(cur);
        }

        /// <summary>
        /// 打印一条 Montage 上是否带抓投所需的 AnimNotifyState：
        /// BANS_GSPreMontageSectionJumpDetection（PreCheck）+ BANS_GSSyncAnimations（同步动画）。
        /// 两者都在，这条 Montage 才会完整走抓投流程。
        /// </summary>
        public static void DumpMontageNotifyInfo(UAnimMontage montage)
        {
            if (montage == null || montage.IsNullOrDestroyed()) return;
            try
            {
                Log.Info($"[GrabSync] === Montage: {montage.GetName()} ===");
                // TArrayUnsafe 底层是非托管数组，必须 Dispose（using），否则每次调用泄漏一份
                using var list = new UnrealEngine.Runtime.TArrayUnsafe<FAnimNotifyEvent>();
                UGSE_AnimFuncLib.GetAllNotifyEvent(montage, list);

                bool foundPreCheck = false;
                bool foundSyncAnim = false;
                if (list != null)
                {
                    // 这两个 Notify 类在游戏 DLL 里是 internal，只能用类型名 + 反射读属性
                    foreach (FAnimNotifyEvent item in list)
                    {
                        object? ns = item.NotifyStateClass;
                        if (ns == null) continue;
                        string typeName = ns.GetType().Name;

                        if (typeName == "BANS_GSPreMontageSectionJumpDetection")
                        {
                            foundPreCheck = true;
                            Log.Info($"[GrabSync] 有抓投PreCheck: 强制命中={ReadProp(ns, "bForceSuccess")} " +
                                     $"圆心={ReadProp(ns, "DetectionCenterSocketName")} 半径={ReadProp(ns, "DetectionRadius")} " +
                                     $"失败跳转={ReadProp(ns, "JumpToSectionName")}");
                        }
                        else if (typeName == "BANS_GSSyncAnimations")
                        {
                            foundSyncAnim = true;
                            Log.Info($"[GrabSync] 有同步动画Notify: GuestMontage={NameOf(ReadProp(ns, "GuestMontage") as UObject)} " +
                                     $"强制同步IBM={ReadProp(ns, "bForceSyncDummyMeshAnimation")}");
                        }
                    }
                }

                string verdict = (foundPreCheck && foundSyncAnim)
                    ? "自带完整抓投，会自动触发本模块"
                    : "不带抓投，需要主动调用 TryGrab / TryCastGrabSkill";
                Log.Info($"[GrabSync] 判定: PreCheck={(foundPreCheck ? "有" : "无")}, " +
                         $"SyncAnimNotify={(foundSyncAnim ? "有" : "无")} → {verdict}");
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 打印 Montage 抓投信息失败: {e.Message}");
            }
        }

        /// <summary>手动打印当前正在播放的 Montage 的抓投信息</summary>
        public static void DumpCurrentMontage()
        {
            Utils.TryRunOnGameThread(() =>
            {
                UAnimMontage? m = GetHostSyncMontage(_self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS));
                if (m == null)
                {
                    Log.Warn("[GrabSync] 当前没有正在播放的 Montage");
                    return;
                }
                DumpMontageNotifyInfo(m);
            });
        }

        /// <summary>
        /// 把 Host 当前 Montage 的骨骼、玩家的本体形态骨骼、候选匹配情况打进日志。
        /// 用来确认"被投者到底应该换成哪套模型"。
        /// </summary>
        public static void DumpSkeletonInfo()
        {
            Utils.TryRunOnGameThread(() =>
            {
                try
                {
                    var self = _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
                    if (self == null)
                    {
                        Log.Warn("[GrabSync] 没有受控单位");
                        return;
                    }

                    UAnimMontage? montage = GetHostSyncMontage(self);
                    Log.Info($"[GrabSync] Host={NameOf(self)} 当前Montage={NameOf(montage)}");
                    Log.Info($"[GrabSync] 被投方应播的Montage={NameOf(GetGuestMontage(self))}");
                    Log.Info($"[GrabSync] 目标骨骼={NameOf(GetWantedGuestSkeleton(self, out string src))}（依据 {src}）");
                    Log.Info($"[GrabSync] 宿主动画骨骼={NameOf(GetHostSyncMontageSkeleton(self))}");
                    Log.Info($"[GrabSync] Host自带骨骼={NameOf(self.Mesh?.SkeletalMesh)}");
                    Log.Info($"[GrabSync] 缓存的本体形态={(_hasCachedForm ? NameOf(_cachedFormMesh) : "<未缓存>")}");

                    var rec = _record;
                    Log.Info($"[GrabSync] 当前替换记录={(rec == null ? "<无>" : NameOf(rec.Guest))}");
                }
                catch (Exception e)
                {
                    Log.Error($"[GrabSync] 诊断输出失败: {e.Message}");
                }
            });
        }

        /// <summary>
        /// 离线批量筛查：这些技能对应的 Montage 里有没有抓投 notify。
        /// 不用一个个手动放技能试。会同步加载资源，一次别给太多。
        /// </summary>
        public static void ScanGrabSkills(System.Collections.Generic.IEnumerable<int> skillIds)
        {
            Utils.TryRunOnGameThread(() =>
            {
                var self = _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
                if (self == null)
                {
                    Log.Warn("[GrabSync] 没有受控单位，无法扫描");
                    return;
                }
                foreach (int id in skillIds)
                {
                    Log.Info($"[GrabSync] 技能 {id} → {ProbeSkillGrab(id, self)}");
                }
                Log.Info("[GrabSync] 扫描结束");
            });
        }

        /// <summary>扫一段连续的技能 ID（含首尾）</summary>
        public static void ScanGrabSkillsInRange(int fromId, int toId)
        {
            var ids = new System.Collections.Generic.List<int>();
            for (int i = fromId; i <= toId; i++) ids.Add(i);
            ScanGrabSkills(ids);
        }

        /// <summary>
        /// 直接按 Montage 资源路径筛查有没有抓投 notify —— 不用释放技能，最快。
        /// 路径形如 /Game/00Main/Animation/xxx/AM_xxx.AM_xxx
        /// </summary>
        public static void ScanGrabMontages(System.Collections.Generic.IEnumerable<string> montagePaths)
        {
            Utils.TryRunOnGameThread(() =>
            {
                var self = _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
                if (self == null)
                {
                    Log.Warn("[GrabSync] 没有受控单位，无法扫描");
                    return;
                }
                foreach (string path in montagePaths)
                {
                    Log.Info($"[GrabSync] {path} → {ProbeMontageGrab(path, self)}");
                }
                Log.Info("[GrabSync] 扫描结束");
            });
        }

        /// <summary>检查单个技能是否自带抓投，返回可读结论</summary>
        private static string ProbeSkillGrab(int skillId, BGUCharacterCS owner)
        {
            try
            {
                FUStSkillSDesc? desc = BGW_GameDB.GetSkillSDesc(skillId, owner);
                if (desc == null) return "查无此技能";
                if (string.IsNullOrEmpty(desc.TemplatePath)) return "无 Montage（非蒙太奇技能）";
                return ProbeMontageGrab(desc.TemplatePath!, owner);
            }
            catch (Exception e)
            {
                return $"检查异常: {e.Message}";
            }
        }

        /// <summary>加载一条 Montage 并检查抓投 notify，返回可读结论</summary>
        private static string ProbeMontageGrab(string templatePath, BGUCharacterCS owner)
        {
            try
            {
                UAnimMontage? montage = BGW_PreloadAssetMgr.Get(owner)
                    .TryGetCachedResourceObj<UAnimMontage>(templatePath, ELoadResourceType.SyncLoadAndCache);
                if (montage == null) return "Montage 加载失败（路径不对？）";

                // TArrayUnsafe 底层是非托管数组，必须 Dispose（using），否则每次调用泄漏一份
                using var list = new UnrealEngine.Runtime.TArrayUnsafe<FAnimNotifyEvent>();
                UGSE_AnimFuncLib.GetAllNotifyEvent(montage, list);

                bool pre = false, sync = false;
                string preDetail = "";
                if (list != null)
                {
                    foreach (FAnimNotifyEvent item in list)
                    {
                        object? ns = item.NotifyStateClass;
                        if (ns == null) continue;
                        string n = ns.GetType().Name;
                        if (n == "BANS_GSPreMontageSectionJumpDetection")
                        {
                            pre = true;
                            preDetail = $" [强制命中={ReadProp(ns, "bForceSuccess")} 半径={ReadProp(ns, "DetectionRadius")}]";
                        }
                        else if (n == "BANS_GSSyncAnimations")
                        {
                            sync = true;
                        }
                    }
                }

                string flag = pre && sync ? "★自带抓投★" : "无抓投";
                return $"{flag}  PreCheck={pre}{preDetail} SyncAnim={sync}  Montage={montage.GetName()}";
            }
            catch (Exception e)
            {
                return $"检查异常: {e.Message}";
            }
        }

        #endregion

        #region 主动触发抓投

        /// <summary>
        /// 在游戏线程里发起一次抓投（异步包一层，按键回调里用这个最省事）。
        /// 会先给 Host 设置技能基准目标（抓投预检测只读它），再播放带
        /// BANS_GSPreMontageSectionJumpDetection + BANS_GSSyncAnimations 的 Montage。
        /// </summary>
        public static void ScheduleGrab(UAnimMontage montage, BGUCharacterCS? target = null, float searchRadius = 2000f)
        {
            Utils.TryRunOnGameThread(() => TryGrab(montage, target, searchRadius));
        }

        /// <summary>同步版本，必须在游戏线程调用（ScheduleGrab / Utils.TryRunOnGameThread 内部都可以）</summary>
        public static bool TryGrab(UAnimMontage montage, BGUCharacterCS? target = null, float searchRadius = 2000f)
        {
            try
            {
                var host = _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
                if (host == null || host.IsNullOrDestroyed())
                {
                    Log.Warn("[GrabSync] 找不到宿主单位");
                    return false;
                }
                if (montage == null || montage.IsNullOrDestroyed())
                {
                    Log.Warn("[GrabSync] Montage 为空");
                    return false;
                }
                if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(host, EBGUSimpleState.InAnimationSyncing)
                    || BGUFunctionLibraryCS.BGUHasUnitSimpleState(host, EBGUSimpleState.PreAnimationSyncing))
                {
                    Log.Warn("[GrabSync] 当前已在抓投流程中，忽略本次触发");
                    return false;
                }

                BGUCharacterCS? realTarget = target ?? FindNearestTarget(searchRadius, host);
                if (realTarget == null || realTarget.IsNullOrDestroyed())
                {
                    Log.Warn("[GrabSync] 找不到可抓投的目标");
                    return false;
                }
                if (BGUFunctionLibraryCS.BGUIsUnitDead(realTarget))
                {
                    Log.Warn("[GrabSync] 目标已死亡");
                    return false;
                }

                SetSkillBaseTarget(host, realTarget);

                float length = BGUFuncLibAnim.BGUActorTryPlayMontage(
                    host, montage, FName.None, EMontageBindReason.Default, 1f, 1f, 0f);

                Log.Info($"[GrabSync] 触发抓投 {NameOf(host)} -> {NameOf(realTarget)} montage={NameOf(montage)} 时长={length}");
                if (length <= 0f)
                {
                    Log.Warn("[GrabSync] Montage 播放失败（返回时长<=0）：当前 AnimBP 可能不认这条 Montage 的骨骼/Slot");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 触发抓投失败: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 走技能层发动抓投（会带上攻击状态、受击、 condemn 等完整技能逻辑）。
        /// skillId 填 Boss 那个带抓投 notify 的技能 ID。
        /// </summary>
        public static bool TryCastGrabSkill(int skillId, BGUCharacterCS? target = null, float searchRadius = 2000f)
        {
            try
            {
                var host = _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
                if (host == null || host.IsNullOrDestroyed()) return false;

                BGUCharacterCS? realTarget = target ?? FindNearestTarget(searchRadius, host);

                // 注意：释放技能时 BUS_SkillInstsCompSvr.OnUnitCastSkillTry 会在
                // !CSI.HasSetSkillBaseTarget 时按技能表重算目标并覆盖我们设的值，
                // 所以想"指定目标"必须自己构造 FCastSkillInfo 并把 HasSetSkillBaseTarget 置 true。
                bool manualTarget = realTarget != null && SetSkillBaseTarget(host, realTarget!);

                FCastSkillInfo csi = new FCastSkillInfo(skillId, ECastSkillSourceType.GM)
                {
                    HasSetSkillBaseTarget = manualTarget,
                    NeedCheckSkillCanCast = false,
                    Reason = EMontageBindReason.Default,
                    MontageStartSectionName = FName.None
                };
                BUS_EventCollectionCS.Get(host)?.Evt_UnitCastSkillTry.Invoke(csi);

                Log.Info($"[GrabSync] 释放抓投技能 {skillId} 目标={NameOf(realTarget)}（手动指定目标={manualTarget}）");
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[GrabSync] 释放抓投技能失败: {e.Message}");
                return false;
            }
        }

        /// <summary>给自己设置技能基准目标：抓投预检测（BGS_AnimationSyncSystem）只读这个槽</summary>
        public static bool SetSkillBaseTarget(BGUCharacterCS host, BGUCharacterCS target)
        {
            if (host == null || target == null || host.IsNullOrDestroyed() || target.IsNullOrDestroyed()) return false;

            var bus = BUS_EventCollectionCS.Get(host);
            if (bus == null) return false;

            FVector loc = BGUFuncLibActorTransformCS.BGUGetActorLocation(target);
            bus.Evt_SetSkillBaseTarget.Invoke(target, loc, ETargetSourceType.Target_AnimSyncAssignTarget, "");
            bus.Evt_AICatchTarget.Invoke(target, ETargetSourceType.Target_AnimSyncAssignTarget, false);
            return true;
        }

        /// <summary>找身边最近的可抓投单位（排除自己、死亡、免疫抓投的）</summary>
        public static BGUCharacterCS? FindNearestTarget(float radius = 2000f, BGUCharacterCS? host = null)
        {
            var h = host ?? _self ?? (ModUtils.GetControlledPawn() as BGUCharacterCS);
            if (h == null || h.IsNullOrDestroyed()) return null;

            FVector center = BGUFuncLibActorTransformCS.BGUGetActorLocation(h);
            var list = new List<ABGUCharacter>();
            try
            {
                UBGUSelectUtil.SphereOverlapBGUCharacters(h, center, radius, out list);
            }
            catch (Exception e)
            {
                Log.Warn($"[GrabSync] 搜索目标失败: {e.Message}");
                return null;
            }
            if (list == null) return null;

            BGUCharacterCS? best = null;
            float bestDist = float.MaxValue;
            foreach (var a in list)
            {
                if (a == null || a.IsNullOrDestroyed()) continue;
                if (ReferenceEquals(a, h)) continue;
                if (!(a is BGUCharacterCS cs)) continue;
                if (BGUFunctionLibraryCS.BGUIsUnitDead(a)) continue;
                if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(a, EBGUSimpleState.ImmueAnimationSyncing)) continue;

                FVector p = BGUFuncLibActorTransformCS.BGUGetActorLocation(a);
                float dx = center.X - p.X;
                float dy = center.Y - p.Y;
                float dz = center.Z - p.Z;
                float d = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
                if (d < bestDist)
                {
                    bestDist = d;
                    best = cs;
                }
            }
            return best;
        }

        #endregion
    }
}
