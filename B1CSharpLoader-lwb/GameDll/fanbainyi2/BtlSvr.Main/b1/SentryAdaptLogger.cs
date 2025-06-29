using System;
using Sentry;
using Sentry.Extensibility;
using UnrealEngine.Runtime;

namespace b1;

internal class SentryAdaptLogger : IDiagnosticLogger
{
	public bool IsEnabled(SentryLevel level)
	{
		if (!B1Global.GIsGameReleased)
		{
			return true;
		}
		if (FGlobals.IsRequestingExit)
		{
			return false;
		}
		return DebugConfig.SentryDebug;
	}

	public void Log(SentryLevel logLevel, string message, Exception exception = null, params object[] args)
	{
		if (!FGlobals.IsRequestingExit)
		{
			switch (logLevel)
			{
			case SentryLevel.Error:
				BGW_LogUtil.LogError(message);
				break;
			case SentryLevel.Fatal:
				BGW_LogUtil.LogError(message);
				break;
			}
			if (exception != null)
			{
				BGW_LogUtil.LogError($"sentry debug log exception:{exception}");
			}
		}
	}
}
