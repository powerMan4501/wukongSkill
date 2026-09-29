using System;
using System.Collections.Generic;
using System.Threading;
using CSharpModBase;

namespace MagicMod
{
    /// <summary>
    /// 定时器池：统一托管本 Mod 里所有 System.Threading.Timer。
    ///
    /// 背景（之前踩的坑）：BoneGlow / MaterialGlow / DbcFx / StaffTrailHelper 各自维护了一个
    /// static List&lt;Timer&gt;，只 Add 不 Remove 也不 Dispose。一次性 Timer 触发完就废了，
    /// 但因为还挂在静态列表里，它回调闭包捕获的 UObject（Niagara 组件 / AActor）就一直被
    /// root 住，UE GC 永远回收不掉 —— 表现为玩十几分钟越玩越卡直到卡死。
    ///
    /// 这里统一处理：一次性 Timer 触发后立刻 Dispose 并从池中移除（引用随之释放，
    /// 闭包里的 UObject 才能被回收）；周期性 Timer 通过句柄显式停止。
    /// 池本身只保留"还在跑"的 Timer。
    /// </summary>
    public static class TimerPool
    {
        private static readonly List<Timer> _timers = new List<Timer>();
        private static readonly object _lock = new object();

        /// <summary>周期性定时器的句柄，用于显式停止</summary>
        public sealed class TimerHandle
        {
            internal Timer? Timer;
        }

        /// <summary>
        /// 一次性定时任务：delayMs 后执行一次，执行完自动 Dispose 并移出池。
        /// </summary>
        public static void Once(int delayMs, Action callback)
        {
            if (callback == null) return;
            if (delayMs < 0) delayMs = 0;

            Timer? t = null;
            // 先创建成"不启动"状态，保证回调里能拿到 t（避免回调先于赋值执行）
            t = new Timer(_ =>
            {
                try { callback(); }
                catch (Exception e) { Log.Error($"[TimerPool] 定时任务异常: {e.Message}"); }
                finally { Release(t); }
            }, null, Timeout.Infinite, Timeout.Infinite);

            lock (_lock) { _timers.Add(t); }
            try { t.Change(delayMs, Timeout.Infinite); }
            catch (Exception e)
            {
                Log.Error($"[TimerPool] 启动定时任务失败: {e.Message}");
                Release(t);
            }
        }

        /// <summary>
        /// 周期性定时任务。必须保存返回的句柄，不用时 Stop，否则会一直跑。
        /// </summary>
        public static TimerHandle Repeat(int intervalMs, Action callback)
        {
            var handle = new TimerHandle();
            if (callback == null) return handle;
            if (intervalMs <= 0) intervalMs = 1;

            var t = new Timer(_ =>
            {
                try { callback(); }
                catch (Exception e) { Log.Error($"[TimerPool] 周期任务异常: {e.Message}"); }
            }, null, intervalMs, intervalMs);

            handle.Timer = t;
            lock (_lock) { _timers.Add(t); }
            return handle;
        }

        /// <summary>停止一个周期性定时器</summary>
        public static void Stop(TimerHandle? handle)
        {
            if (handle == null) return;
            var t = handle.Timer;
            handle.Timer = null;
            if (t == null) return;
            Release(t);
        }

        private static void Release(Timer? t)
        {
            if (t == null) return;
            lock (_lock) { _timers.Remove(t); }
            try { t.Dispose(); } catch { }
        }

        /// <summary>池中还在跑的定时器数量（排查泄漏用）</summary>
        public static int Count
        {
            get { lock (_lock) { return _timers.Count; } }
        }

        /// <summary>停掉并清空所有定时器（Mod 卸载 / 热重载时调用）</summary>
        public static void ClearAll()
        {
            List<Timer> snapshot;
            lock (_lock)
            {
                snapshot = new List<Timer>(_timers);
                _timers.Clear();
            }
            foreach (var t in snapshot)
            {
                try { t.Dispose(); } catch { }
            }
        }
    }
}
