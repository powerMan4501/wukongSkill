using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System;

internal static class BCLDebug
{
	internal static volatile bool m_registryChecked = false;

	internal static volatile bool m_loggingNotEnabled = false;

	internal static bool m_perfWarnings;

	internal static bool m_correctnessWarnings;

	internal static bool m_safeHandleStackTraces;

	internal static volatile PermissionSet m_MakeConsoleErrorLoggingWork;

	private static readonly SwitchStructure[] switches = new SwitchStructure[14]
	{
		new SwitchStructure("NLS", 1),
		new SwitchStructure("SER", 2),
		new SwitchStructure("DYNIL", 4),
		new SwitchStructure("REMOTE", 8),
		new SwitchStructure("BINARY", 16),
		new SwitchStructure("SOAP", 32),
		new SwitchStructure("REMOTINGCHANNELS", 64),
		new SwitchStructure("CACHE", 128),
		new SwitchStructure("RESMGRFILEFORMAT", 256),
		new SwitchStructure("PERF", 512),
		new SwitchStructure("CORRECTNESS", 1024),
		new SwitchStructure("MEMORYFAILPOINT", 2048),
		new SwitchStructure("DATETIME", 4096),
		new SwitchStructure("INTEROP", 8192)
	};

	private static readonly LogLevel[] levelConversions = new LogLevel[11]
	{
		LogLevel.Panic,
		LogLevel.Error,
		LogLevel.Error,
		LogLevel.Warning,
		LogLevel.Warning,
		LogLevel.Status,
		LogLevel.Status,
		LogLevel.Trace,
		LogLevel.Trace,
		LogLevel.Trace,
		LogLevel.Trace
	};

	internal static bool SafeHandleStackTracesEnabled => false;

	[Conditional("_DEBUG")]
	public static void Assert(bool condition, string message)
	{
	}

	[Conditional("_LOGGING")]
	[SecuritySafeCritical]
	public static void Log(string message)
	{
		if (!AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			if (!m_registryChecked)
			{
				CheckRegistry();
			}
			System.Diagnostics.Log.Trace(message);
			System.Diagnostics.Log.Trace(Environment.NewLine);
		}
	}

	[Conditional("_LOGGING")]
	[SecuritySafeCritical]
	public static void Log(string switchName, string message)
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			return;
		}
		if (!m_registryChecked)
		{
			CheckRegistry();
		}
		try
		{
			LogSwitch logSwitch = LogSwitch.GetSwitch(switchName);
			if (logSwitch != null)
			{
				System.Diagnostics.Log.Trace(logSwitch, message);
				System.Diagnostics.Log.Trace(logSwitch, Environment.NewLine);
			}
		}
		catch
		{
			System.Diagnostics.Log.Trace("Exception thrown in logging." + Environment.NewLine);
			System.Diagnostics.Log.Trace("Switch was: " + ((switchName == null) ? "<null>" : switchName) + Environment.NewLine);
			System.Diagnostics.Log.Trace("Message was: " + ((message == null) ? "<null>" : message) + Environment.NewLine);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int GetRegistryLoggingValues(out bool loggingEnabled, out bool logToConsole, out int logLevel, out bool perfWarnings, out bool correctnessWarnings, out bool safeHandleStackTraces);

	[SecuritySafeCritical]
	private static void CheckRegistry()
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize() || m_registryChecked)
		{
			return;
		}
		m_registryChecked = true;
		bool loggingEnabled;
		bool logToConsole;
		int logLevel;
		int registryLoggingValues = GetRegistryLoggingValues(out loggingEnabled, out logToConsole, out logLevel, out m_perfWarnings, out m_correctnessWarnings, out m_safeHandleStackTraces);
		if (!loggingEnabled)
		{
			m_loggingNotEnabled = true;
		}
		if (!loggingEnabled || levelConversions == null)
		{
			return;
		}
		try
		{
			logLevel = (int)levelConversions[logLevel];
			if (registryLoggingValues <= 0)
			{
				return;
			}
			for (int i = 0; i < switches.Length; i++)
			{
				if ((switches[i].value & registryLoggingValues) != 0)
				{
					LogSwitch logSwitch = new LogSwitch(switches[i].name, switches[i].name, System.Diagnostics.Log.GlobalSwitch);
					logSwitch.MinimumLevel = (LoggingLevels)logLevel;
				}
			}
			System.Diagnostics.Log.GlobalSwitch.MinimumLevel = (LoggingLevels)logLevel;
			System.Diagnostics.Log.IsConsoleEnabled = logToConsole;
		}
		catch
		{
		}
	}

	[SecuritySafeCritical]
	internal static bool CheckEnabled(string switchName)
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			return false;
		}
		if (!m_registryChecked)
		{
			CheckRegistry();
		}
		LogSwitch logSwitch = LogSwitch.GetSwitch(switchName);
		if (logSwitch == null)
		{
			return false;
		}
		return logSwitch.MinimumLevel <= LoggingLevels.TraceLevel0;
	}

	[SecuritySafeCritical]
	private static bool CheckEnabled(string switchName, LogLevel level, out LogSwitch logSwitch)
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			logSwitch = null;
			return false;
		}
		logSwitch = LogSwitch.GetSwitch(switchName);
		if (logSwitch == null)
		{
			return false;
		}
		return (int)logSwitch.MinimumLevel <= (int)level;
	}

	[Conditional("_LOGGING")]
	[SecuritySafeCritical]
	public static void Log(string switchName, LogLevel level, params object[] messages)
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			return;
		}
		if (!m_registryChecked)
		{
			CheckRegistry();
		}
		if (!CheckEnabled(switchName, level, out var logSwitch))
		{
			return;
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		for (int i = 0; i < messages.Length; i++)
		{
			string value;
			try
			{
				value = ((messages[i] != null) ? messages[i].ToString() : "<null>");
			}
			catch
			{
				value = "<unable to convert>";
			}
			stringBuilder.Append(value);
		}
		System.Diagnostics.Log.LogMessage((LoggingLevels)level, logSwitch, StringBuilderCache.GetStringAndRelease(stringBuilder));
	}

	[Conditional("_LOGGING")]
	public static void Trace(string switchName, params object[] messages)
	{
		if (m_loggingNotEnabled || !CheckEnabled(switchName, LogLevel.Trace, out var logSwitch))
		{
			return;
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		for (int i = 0; i < messages.Length; i++)
		{
			string value;
			try
			{
				value = ((messages[i] != null) ? messages[i].ToString() : "<null>");
			}
			catch
			{
				value = "<unable to convert>";
			}
			stringBuilder.Append(value);
		}
		stringBuilder.Append(Environment.NewLine);
		System.Diagnostics.Log.LogMessage(LoggingLevels.TraceLevel0, logSwitch, StringBuilderCache.GetStringAndRelease(stringBuilder));
	}

	[Conditional("_LOGGING")]
	public static void Trace(string switchName, string format, params object[] messages)
	{
		if (!m_loggingNotEnabled && CheckEnabled(switchName, LogLevel.Trace, out var logSwitch))
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire();
			stringBuilder.AppendFormat(format, messages);
			stringBuilder.Append(Environment.NewLine);
			System.Diagnostics.Log.LogMessage(LoggingLevels.TraceLevel0, logSwitch, StringBuilderCache.GetStringAndRelease(stringBuilder));
		}
	}

	[Conditional("_LOGGING")]
	public static void DumpStack(string switchName)
	{
		if (!m_registryChecked)
		{
			CheckRegistry();
		}
		if (CheckEnabled(switchName, LogLevel.Trace, out var logSwitch))
		{
			StackTrace stackTrace = new StackTrace();
			System.Diagnostics.Log.LogMessage(LoggingLevels.TraceLevel0, logSwitch, stackTrace.ToString());
		}
	}

	[SecuritySafeCritical]
	[Conditional("_DEBUG")]
	internal static void ConsoleError(string msg)
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			return;
		}
		if (m_MakeConsoleErrorLoggingWork == null)
		{
			PermissionSet permissionSet = new PermissionSet();
			permissionSet.AddPermission(new EnvironmentPermission(PermissionState.Unrestricted));
			permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, Path.GetFullPath(".")));
			m_MakeConsoleErrorLoggingWork = permissionSet;
		}
		m_MakeConsoleErrorLoggingWork.Assert();
		using TextWriter textWriter = File.AppendText("ConsoleErrors.log");
		textWriter.WriteLine(msg);
	}

	[Conditional("_DEBUG")]
	[SecuritySafeCritical]
	internal static void Perf(bool expr, string msg)
	{
		if (!AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			if (!m_registryChecked)
			{
				CheckRegistry();
			}
			if (m_perfWarnings)
			{
				System.Diagnostics.Assert.Check(expr, "BCL Perf Warning: Your perf may be less than perfect because...", msg);
			}
		}
	}

	[Conditional("_DEBUG")]
	internal static void Correctness(bool expr, string msg)
	{
	}

	[SecuritySafeCritical]
	internal static bool CorrectnessEnabled()
	{
		if (AppDomain.CurrentDomain.IsUnloadingForcedFinalize())
		{
			return false;
		}
		if (!m_registryChecked)
		{
			CheckRegistry();
		}
		return m_correctnessWarnings;
	}
}
