using CSharpModBase;

namespace MagicMod
{
    /// <summary>
    /// Mod 日志包装：把「高频日志」和「常规日志」分开。
    ///
    /// 背景：Log.Info 是同步 Console.WriteLine（带锁 + DateTime.Now.ToString + 字符串插值），
    /// 而 SweepCheckBegin / OnSkillCostDmg / OnTriggerSkillEffect / 条件检查这类回调
    /// 在战斗中是每秒几十次地触发，无条件打日志会明显吃掉游戏线程时间。
    /// 所以这些位置的日志统一走 Trace，默认关闭，需要排查时打开开关即可。
    ///
    /// 开关：actions.json 根级 "verbose": true（改完重载 Mod 生效）。
    /// </summary>
    public static class ModLog
    {
        /// <summary>高频追踪日志开关。false 时所有 Trace 调用直接返回，不做任何字符串拼接。</summary>
        public static bool Verbose = false;

        /// <summary>高频路径专用的追踪日志（默认不输出）</summary>
        public static void Trace(string message)
        {
            if (!Verbose) return;
            Log.Info(message);
        }

        public static void Info(string message) => Log.Info(message);

        public static void Warn(string message) => Log.Warn(message);

        public static void Error(string message) => Log.Error(message);
    }
}
