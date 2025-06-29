using System.Diagnostics;

namespace b1;

public static class SysLogUtil
{
	public class SysLogInstance
	{
		private string LogTag;

		public SysLogInstance(string LogTag)
		{
			this.LogTag = LogTag;
		}

		[Conditional("DEBUG")]
		public void LogDebug(string LogMessage)
		{
		}

		public void LogInfo(string LogMessage)
		{
		}

		public void LogError(string LogMessage)
		{
			BGW_LogUtil.LogError("[SYSTEM_LOG:" + LogTag + "]:" + LogMessage);
		}

		public void LogWarning(string LogMessage)
		{
		}

		public void LogShipping(string LogMessage)
		{
			BGW_LogUtil.LogShipping("[SYSTEM_LOG:" + LogTag + "]:" + LogMessage);
		}

		public void LogShippingError(string LogMessage)
		{
			BGW_LogUtil.LogShippingError("[SYSTEM_LOG:" + LogTag + "]:" + LogMessage);
		}
	}

	public static SysLogInstance ARCHIVE = new SysLogInstance("ARCHIVE");

	public static SysLogInstance GAME_PLAYER = new SysLogInstance("GAME_PLAYER");

	public static SysLogInstance ASYNC_EVENT = new SysLogInstance("GAMME_PLAYER:ASYNC_EVENT");

	public static SysLogInstance ONLINE_SUBSYSTEM = new SysLogInstance("ONLINE_SUBSYSTEM");

	public static SysLogInstance GSRPC = new SysLogInstance("GSRPC:CORE");

	public static SysLogInstance RPC_TRACING = new SysLogInstance("GSRPC:TRACING");

	public static SysLogInstance GSG = new SysLogInstance("GSG");

	public static SysLogInstance GSGBtl = new SysLogInstance("GSGBtl");

	public static SysLogInstance SHAOWEI_DEBUG = new SysLogInstance("SHAOWEI_DEBUG");

	public static SysLogInstance AARON_DEBUG = new SysLogInstance("AARON_DEBUG");
}
