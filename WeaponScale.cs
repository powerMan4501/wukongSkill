using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 运行时整体放大玩家角色（Actor 缩放）：平A 期间放大，出招后还原。
    ///
    /// 关键架构结论（来自 BUS_SweepCheckHitComp 源码）：
    ///   原生 SweepCheck 命中体尺寸 =
    ///     ShapeParamFloat  = sweepCheckShape.Radius * Owner.GetActorScale3D().X
    ///     ShapeParamVector = sweepCheckShape.Scale
    ///   即判定体的“粗细/大小”【只认 Actor 缩放】。
    ///   - 只缩放 Mesh 组件（CharacterMesh0）的话：socket 世界变换含组件缩放 → 扫击的
    ///     位置/轨迹会被推远（够得远），但判定球/胶囊的半径一点不变（只变长、不变粗）。
    ///   - 缩放 Actor 本体（SetActorScale3D）：位置与半径一起放大 → 判定真正跟着变大。
    ///
    ///   另：在 Evt_SweepCheckBegin 里改 FUStCheckShape 是无效的，不用再手动改判定 ——
    ///   游戏组件在 BeginPlay(OnAttach) 就订阅了该事件，FUStCheckShape 又是 struct，
    ///   形状在派发时就被值拷贝进 FSweepCheckCombineInfo（默认 b.EnableCombineSweepCheckShape=1），
    ///   我们后执行的修改改不到那份拷贝。
    ///
    /// 已知副作用（已接受）：角色胶囊、移动/位移、受击判定、投技判定都会同步放大。
    ///   非等比缩放（如 {3,1,1}）会让胶囊变形，且判定半径只取 X 分量；
    ///   追求稳定手感建议用等比（如 {3,3,3}）。
    ///
    /// JSON 字段：
    ///   WeaponScale        —— VectorConfig 缩放向量 {X,Y,Z}，默认 {3,1,1}（建议等比）
    ///   WeaponScaleHoldMs  —— 保持放大毫秒数，到时开始还原；默认 600
    ///                          （&lt;=0 表示一直保持，直到下次本动作或 Reset/热重载时还原）
    ///   WeaponScaleRestoreMs —— 还原的过渡毫秒数，0/不填 = 瞬间还原
    ///                          （如 500 = 保持期结束后再用 500ms 缓缓缩回原状，先快后慢）
    /// </summary>
    public static class WeaponScale
    {
        private static readonly object _lock = new object();

        private class ActiveEntry
        {
            /// <summary>回弹插值用的周期定时器句柄（不用时 Stop，避免 16ms 定时器残留一直跑）</summary>
            public TimerPool.TimerHandle? Handle;
            public BGUPlayerCharacterCS Owner;
            /// <summary>放大前的 Actor 原始缩放（还原时直接写回，不受期间的其它改动影响）。</summary>
            public FVector Original;
            /// <summary>本次放大的倍率。</summary>
            public FVector ScaleVec;
            /// <summary>当前实际生效倍率（回弹过程中会逐帧逼近 1）。GetActiveScale 返回它。</summary>
            public FVector CurrentScale;
        }

        /// <summary>回弹插值的时间间隔（毫秒）。实际落点由游戏帧驱动，约等于每帧一次。</summary>
        private const int RestoreTickMs = 16;

        private static readonly Dictionary<int, ActiveEntry> _active = new Dictionary<int, ActiveEntry>();

        /// <summary>
        /// 整体放大玩家角色（Actor 缩放），命中判定会随 Actor 缩放一起变大。
        /// scale 为 null 时默认 X=3。返回是否成功应用。
        /// restoreMs &gt; 0 时，holdMs 到期不直接跳回原状，而是在 restoreMs 毫秒内平滑缩回。
        /// </summary>
        public static bool Scale(BGUPlayerCharacterCS chr, VectorConfig scale, int holdMs, int restoreMs = 0)
        {
            if (chr == null || chr.IsNullOrDestroyed()) return false;
            int key = chr.GetHashCode();

            // 若上一段放大还没结束，先还原，避免倍率叠加
            RestoreAndForget(key);

            float mx = scale?.X ?? 3f;
            float my = scale?.Y ?? 1f;
            float mz = scale?.Z ?? 1f;

            FVector orig;
            try { orig = chr.GetActorScale3D(); }
            catch (Exception e)
            {
                Log.Error($"[WeaponScale] 读取 Actor 缩放失败: {e.Message}");
                return false;
            }

            var entry = new ActiveEntry
            {
                Owner = chr,
                Original = orig,
                ScaleVec = new FVector(mx, my, mz),
                CurrentScale = new FVector(mx, my, mz)
            };

            if (!Apply(entry, mx, my, mz)) return false;

            if (Math.Abs(my - mx) > 0.001f || Math.Abs(mz - mx) > 0.001f)
                Log.Info($"[WeaponScale] 非等比缩放 ({mx},{my},{mz})：胶囊会变形，且判定半径只取 X={mx}；想要稳定手感建议改成等比。");

            Log.Info($"[WeaponScale] 整体放大角色 Actor：倍率 ({mx},{my},{mz})，原始缩放 ({orig.X},{orig.Y},{orig.Z})，保持 {holdMs}ms，回弹 {restoreMs}ms");

            lock (_lock)
            {
                _active[key] = entry;
            }

            if (holdMs > 0)
            {
                // 走 TimerPool：触发完自动清理，不会像以前那样把定时器引用长期挂在 entry 上
                TimerPool.Once(holdMs, () =>
                {
                    lock (_lock)
                    {
                        // 期间若已被新的放大替换/还原，这次回调作废，避免误缩别人
                        if (!_active.TryGetValue(key, out var cur) || !ReferenceEquals(cur, entry)) return;
                    }
                    try { Utils.TryRunOnGameThread(() => BeginRestore(key, restoreMs)); }
                    catch { }
                });
            }
            return true;
        }

        /// <summary>立即把玩家角色还原成原始大小。</summary>
        public static void Reset(BGUPlayerCharacterCS chr)
        {
            if (chr == null || chr.IsNullOrDestroyed()) return;
            RestoreAndForget(chr.GetHashCode());
        }

        /// <summary>还原所有仍在放大状态的角色（热重载/Mod 卸载时调用）。</summary>
        public static void ResetAll()
        {
            int[] keys;
            lock (_lock)
            {
                keys = _active.Keys.ToArray();
            }
            foreach (var k in keys)
                RestoreAndForget(k);
        }

        /// <summary>
        /// 返回该角色当前 WeaponScale 生效的倍率（未生效返回 null）。
        /// 供弹体 SpawnOffset 等共用，使“判定/攻击距离”随角色一起拉长。
        /// </summary>
        public static FVector? GetActiveScale(BGUPlayerCharacterCS chr)
        {
            if (chr == null || chr.IsNullOrDestroyed()) return null;
            lock (_lock)
            {
                if (_active.TryGetValue(chr.GetHashCode(), out var entry))
                    return entry.CurrentScale;
            }
            return null;
        }

        /// <summary>
        /// 开始回弹：在 restoreMs 毫秒内把倍率从当前值平滑缩回 1（先快后慢 easing）。
        /// restoreMs &lt;= 0 时退化为原来的瞬间还原。
        /// </summary>
        private static void BeginRestore(int key, int restoreMs)
        {
            lock (_lock)
            {
                if (!_active.TryGetValue(key, out var entry)) return;
                if (restoreMs <= 0)
                {
                    RestoreAndForget(key);
                    return;
                }

                // 保持期结束，换用高频插值 timer 逐帧逼近原始大小
                try { TimerPool.Stop(entry.Handle); } catch { }
                entry.Handle = null;

                var sw = System.Diagnostics.Stopwatch.StartNew();
                TimerPool.TimerHandle? handle = null;
                handle = TimerPool.Repeat(RestoreTickMs, () =>
                {
                    float p = (float)(sw.Elapsed.TotalMilliseconds / restoreMs);
                    if (p > 1f) p = 1f;
                    // k: 1 -> 0；easeOutCubic 让回弹先快后慢，收尾自然
                    float u = 1f - p;
                    float k = u * u * u;
                    bool done = p >= 1f;
                    try { Utils.TryRunOnGameThread(() => TickRestore(key, k, done)); }
                    catch { }
                    // 结束（或这一轮已被新的放大顶掉）就停表，避免 16ms 定时器一直空转
                    if (done) TimerPool.Stop(handle);
                });

                entry.Handle = handle;
            }
        }

        /// <summary>回弹过程中的一次插值：k 为剩余放大比例（1=完全放大，0=完全还原）。</summary>
        private static void TickRestore(int key, float k, bool done)
        {
            lock (_lock)
            {
                if (!_active.TryGetValue(key, out var entry)) return;

                var s = entry.ScaleVec;
                float mx = 1f + (s.X - 1f) * k;
                float my = 1f + (s.Y - 1f) * k;
                float mz = 1f + (s.Z - 1f) * k;
                entry.CurrentScale = new FVector(mx, my, mz);
                Apply(entry, mx, my, mz);

                if (done) RestoreAndForget(key);
            }
        }

        private static void RestoreAndForget(int key)
        {
            lock (_lock)
            {
                if (!_active.TryGetValue(key, out var entry)) return;
                _active.Remove(key);

                try { TimerPool.Stop(entry.Handle); } catch { }
                entry.Handle = null;

                // 倍率回 1 = 写回放大前的原始缩放
                Apply(entry, 1f, 1f, 1f);
            }
        }

        /// <summary>把「原始缩放 × 倍率」写到角色 Actor 上。</summary>
        private static bool Apply(ActiveEntry entry, float mx, float my, float mz)
        {
            var chr = entry?.Owner;
            if (chr == null || chr.IsNullOrDestroyed()) return false;
            try
            {
                var o = entry.Original;
                chr.SetActorScale3D(new FVector(mx * o.X, my * o.Y, mz * o.Z));
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[WeaponScale] SetActorScale3D 失败: {e.Message}");
                return false;
            }
        }
    }
}
