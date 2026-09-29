using System;
using System.Collections.Generic;
using System.Threading;
using b1;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 动画播放位置（Montage Position）监听器。
    /// 采样玩家当前 Montage 的播放头位置（秒），命中 SweepCheck 配置里 position_actions 的
    /// Position（带容差）时执行对应动作，实现"动画播到第 N.00 秒执行自定义 actions"。
    /// 不依赖 AnimNotify / Harmony（EnableJit=0 下可用）。
    /// </summary>
    /// <remarks>
    /// 性能约定（只在"有 Montage 在播"的那一小段时间里才轮询，其余时刻零开销）：
    ///   1. 事件驱动：Evt_PlayMontageCallback 的 OnStarted 才起定时器；
    ///      a) 没 Montage 在播 → 立刻停表，之后没有定时器、零开销；
    ///      b) 播的动画没配对应的 position_actions（规则匹配为空）→ 连表都不起，零开销；
    ///      c) 播完 / 中途换成没配的动画 → 立刻停表；
    ///   2. 没配 position_actions 就永远不起定时器；
    ///   3. 去重：上一次采样还没被执行就跳过本次投递，避免回调堆积、也把采样率自然压到"每帧一次"；
    ///   4. 用 RunOnGameThreadAsync 而不是 RunOnGameThread：后者会 WaitForComplete 阻塞调用线程；
    ///   5. 缓存 Montage 的 PathName、缓存 路径→规则 的匹配结果，避免每次采样都分配字符串 / 全表字符串比较。
    /// </remarks>
    public static class MontagePositionWatcher
    {
        /// <summary>采样间隔（毫秒）。60fps 一帧约 16ms，取 10ms 保证每帧至少采一次。</summary>
        private const int ActiveTickMs = 10;


        /// <summary>默认容差（秒）：播放头进入 Position-Tolerance 即算命中。</summary>
        private const float DefaultTolerance = 0.03f;

        /// <summary>位置回退超过该值视为重新播放（循环 / 再次出招）。</summary>
        private const float RestartBackwardThreshold = 0.05f;

        /// <summary>单次采样内位置前跳超过该值视为"跳秒"（cast_actions 的 Montage_SetPosition），跳过去的时间点不补触发。</summary>
        private const float SeekForwardThreshold = 0.25f;

        private static Timer? _timer;

        /// <summary>是否已有"已投递但还没执行"的采样，用于去重（0/1，Interlocked 操作）。</summary>
        private static int _pending = 0;

        /// <summary>是否配了 position_actions。没配就完全不起定时器。</summary>
        private static bool _enabled = false;

        /// <summary>当前正在跟踪的动画（OnStarted 时记下），用于和结束事件对上再停表。</summary>
        private static string _trackedPath = "";

        /// <summary>本次播放已经触发过的动作组（引用判等）。</summary>
        private static readonly HashSet<PositionActionGroup> _firedGroups = new HashSet<PositionActionGroup>();

        private static string _lastAnimationPath = "";
        private static float _lastPosition = -1f;
        private static bool _hasSample = false;

        /// <summary>PathName 缓存：同一个 Montage 只取一次，避免每次采样都分配一个长字符串。</summary>
        private static UAnimMontage? _cachedMontage;
        private static string _cachedPath = "";

        /// <summary>动画路径 → 命中规则（懒加载）。避免每次采样遍历全部绑定做 Contains 比较。</summary>
        private static readonly Dictionary<string, List<MatchedRule>> _ruleCache =
            new Dictionary<string, List<MatchedRule>>(StringComparer.OrdinalIgnoreCase);

        private static long _lastErrorLogMs = 0;

        private class MatchedRule
        {
            public string Animation = "";
            public List<PositionActionGroup> Groups = new List<PositionActionGroup>();
        }

        /// <summary>配置里是否存在 position_actions，决定是否值得启动轮询。</summary>
        public static bool HasPositionConfig(List<SweepCheckBindingConfig>? bindings)
        {
            if (bindings == null) return false;
            foreach (var binding in bindings)
            {
                if (binding?.position_actions != null && binding.position_actions.Count > 0) return true;
            }
            return false;
        }

        /// <summary>绑定配置重新加载后调用，清掉路径/规则缓存（否则会沿用旧配置）。</summary>
        public static void InvalidateCache()
        {
            _ruleCache.Clear();
            _cachedMontage = null;
            _cachedPath = "";
        }

        /// <summary>配置是否启用（由 InitSweepCheckBindings 决定）。没配 position_actions 就永远不起定时器。</summary>
        public static void SetEnabled(bool enabled)
        {
            _enabled = enabled;
            if (!enabled) Stop();
        }

        /// <summary>
        /// 动画开始播放（Evt_PlayMontageCallback 的 OnStarted）时调用：
        /// 标记一次全新播放 + 起定时器。没 Montage 播时定时器是停的，不做任何巡查。
        /// </summary>
        public static void OnMontageStarted(string? animationPath)
        {
            if (!_enabled) return;

            var path = animationPath ?? "";
            // 这条动画根本没配 position_actions：连表都不用起，耗时为 0
            if (path.Length == 0 || GetRules(path).Count == 0) return;

            Stop(); // 上一轮还在跑就先停，保证这次从 0 开始重新判定
            _trackedPath = path;
            _lastAnimationPath = path;

            _pending = 0; // 起新的一次跟踪前放开去重标记，避免上一次的标记卡住后续采样
            _timer = new Timer(_ => OnTimerTick(), null, ActiveTickMs, ActiveTickMs);
        }

        /// <summary>
        /// 动画播放结束（OnCompleted / OnInterrupted / OnPlayFailed）时调用：
        /// 路径对得上才停，避免上一个 Montage 的结束事件把刚起的新 Montage 停掉。
        /// </summary>
        public static void OnMontageEnded(string? animationPath)
        {
            if (_trackedPath.Length > 0 &&
                !string.Equals(animationPath ?? "", _trackedPath, StringComparison.OrdinalIgnoreCase)) return;
            Stop();
        }

        /// <summary>停止轮询并清空状态（动画播完 / Mod 卸载重载时调用）。</summary>
        public static void Stop()
        {
            _timer?.Dispose();
            _timer = null;
            _trackedPath = "";
            ResetPlayState();
        }

        /// <summary>清空"本次播放"的状态，下一次采样重新开始判定。</summary>
        private static void ResetPlayState()
        {
            _firedGroups.Clear();
            _lastAnimationPath = "";
            _lastPosition = -1f;
            _hasSample = false;
        }

        /// <summary>定时器回调（在线程池线程上）。只负责"投递"，不阻塞。</summary>
        private static void OnTimerTick()
        {
            // 上一次采样还没被游戏线程执行 → 本次直接跳过，避免回调堆积
            if (Interlocked.CompareExchange(ref _pending, 1, 0) != 0) return;

            // 异步投递：RunOnGameThread 会 WaitForComplete 阻塞调用线程，这里不需要等结果
            FThreading.RunOnGameThreadAsync(Tick);
        }

        private static void Tick()
        {
            try
            {
                if (_timer == null) return; // 已停止（Mod 重载中）

                var character = ModHelper.GetCharacter();
                if (character == null || character.IsNullOrDestroyed())
                {
                    Stop(); // 角色没了，停表，等下一个 OnStarted 再起
                    return;
                }

                UAnimMontage? montage = character.GetCurrentMontage();
                if (montage == null || montage.IsNullOrDestroyed())
                {
                    Stop(); // 没有 Montage 在播：立即停表，之后零开销，直到下一个 OnStarted
                    return;
                }

                // PathName 只在 Montage 换了的时候取一次，避免每次采样分配字符串
                string animationPath = GetCachedPath(montage);
                if (animationPath.Length == 0)
                {
                    Stop();
                    return;
                }

                // 当前播的动画没配对应的 position_actions（比如换了个没配的 Montage）：直接停表，不用继续巡查
                if (GetRules(animationPath).Count == 0)
                {
                    Stop();
                    return;
                }

                var mesh = character.Mesh;
                if (mesh == null || mesh.IsNullOrDestroyed()) return;

                UAnimInstance? anim = mesh.GetAnimInstance();
                if (anim == null) return;

                Check(character, animationPath, anim.Montage_GetPosition(montage));
            }
            catch (Exception e)
            {
                LogThrottled(e);
            }
            finally
            {
                Interlocked.Exchange(ref _pending, 0);
            }
        }

        /// <summary>取 Montage 的 PathName（同一个 Montage 只取一次，避免每次采样分配字符串）。</summary>
        private static string GetCachedPath(UAnimMontage montage)
        {
            if (ReferenceEquals(_cachedMontage, montage) && _cachedPath.Length > 0) return _cachedPath;
            _cachedMontage = montage;
            _cachedPath = montage.PathName ?? "";
            return _cachedPath;
        }

        /// <summary>按当前播放位置匹配 position_actions 并执行。</summary>
        private static void Check(BGUPlayerCharacterCS character, string animationPath, float position)
        {
            var rules = GetRules(animationPath);
            if (rules.Count == 0) { ResetPlayState(); return; }

            // 换了个 Montage，或播放头明显回退（重播 / 循环）→ 视为一次新播放
            bool restarted = _hasSample && (
                !string.Equals(animationPath, _lastAnimationPath, StringComparison.OrdinalIgnoreCase)
                || position < _lastPosition - RestartBackwardThreshold);
            if (restarted) ResetPlayState();

            // 单次采样内大幅前跳说明是 Montage_SetPosition 跳秒，跳过去的时间点不该补触发
            bool seeked = _hasSample && position - _lastPosition > SeekForwardThreshold;

            bool firstSample = !_hasSample;
            _lastAnimationPath = animationPath;
            if (!_hasSample || Math.Abs(position - _lastPosition) > 0.0001f) _lastPosition = position; // 只记不同的位置
            _hasSample = true;

            for (int ri = 0; ri < rules.Count; ri++)
            {
                var rule = rules[ri];
                var groups = rule.Groups;

                for (int gi = 0; gi < groups.Count; gi++)
                {
                    var group = groups[gi];
                    if (group == null || group.Actions == null || group.Actions.Count == 0) continue;

                    float tolerance = group.Tolerance ?? DefaultTolerance;
                    // 播放头到达或越过 Position-tolerance 即算命中；容差只用来"提前一点"，
                    // 配合下面的"已触发"标记，低帧率或高播放速率都不会漏触发，也不会重复触发
                    if (position < group.Position - tolerance) continue;
                    if (_firedGroups.Contains(group)) continue;
                    _firedGroups.Add(group);

                    // 首次采样（Mod 刚重载 / 动画已经播到中途）或跳秒落到中间时，
                    // 已经明显越过的时间点不补放，避免瞬间刷一堆动作
                    if ((firstSample || seeked) && position > group.Position + tolerance) continue;

                    Log.Info($"[MagicMod] 动画位置命中 '{rule.Animation}' Position={group.Position} 当前={position:F3} -> 执行 {group.Actions.Count} 个动作 {group.name ?? ""}");
                    ActionExecutor.DoActions(character, group.Actions);
                }
            }
        }

        /// <summary>取某条动画路径命中的规则（结果缓存，同一路径只匹配一次）。</summary>
        private static List<MatchedRule> GetRules(string animationPath)
        {
            if (_ruleCache.TryGetValue(animationPath, out var cached)) return cached;

            var rules = new List<MatchedRule>();
            var bindings = ActionExecutor._sweepCheckBindings;
            if (bindings != null)
            {
                foreach (var binding in bindings)
                {
                    if (binding == null || string.IsNullOrEmpty(binding.Animation)) continue;
                    if (binding.position_actions == null || binding.position_actions.Count == 0) continue;
                    if (animationPath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) < 0) continue;

                    rules.Add(new MatchedRule { Animation = binding.Animation, Groups = binding.position_actions });
                }
            }

            _ruleCache[animationPath] = rules;
            return rules;
        }

        /// <summary>高频采样下异常不能直接刷屏，限制 5 秒最多打一条。</summary>
        private static void LogThrottled(Exception e)
        {
            long now = Environment.TickCount;
            if (now - _lastErrorLogMs < 5000) return;
            _lastErrorLogMs = now;
            Log.Error($"[MagicMod] MontagePositionWatcher 异常: {e.Message}");
        }
    }
}
