using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Diagnostics;

internal static class Log
{
	internal static Hashtable m_Hashtable;

	private static volatile bool m_fConsoleDeviceEnabled;

	private static LogMessageEventHandler _LogMessageEventHandler;

	private static volatile LogSwitchLevelHandler _LogSwitchLevelHandler;

	private static object locker;

	public static readonly LogSwitch GlobalSwitch;

	public static bool IsConsoleEnabled
	{
		get
		{
			return m_fConsoleDeviceEnabled;
		}
		set
		{
			m_fConsoleDeviceEnabled = value;
		}
	}

	static Log()
	{
		m_Hashtable = new Hashtable();
		m_fConsoleDeviceEnabled = false;
		locker = new object();
		GlobalSwitch = new LogSwitch("Global", "Global Switch for this log");
		GlobalSwitch.MinimumLevel = LoggingLevels.ErrorLevel;
	}

	public static void AddOnLogMessage(LogMessageEventHandler handler)
	{
		lock (locker)
		{
			_LogMessageEventHandler = (LogMessageEventHandler)Delegate.Combine(_LogMessageEventHandler, handler);
		}
	}

	public static void RemoveOnLogMessage(LogMessageEventHandler handler)
	{
		lock (locker)
		{
			_LogMessageEventHandler = (LogMessageEventHandler)Delegate.Remove(_LogMessageEventHandler, handler);
		}
	}

	public static void AddOnLogSwitchLevel(LogSwitchLevelHandler handler)
	{
		lock (locker)
		{
			_LogSwitchLevelHandler = (LogSwitchLevelHandler)Delegate.Combine(_LogSwitchLevelHandler, handler);
		}
	}

	public static void RemoveOnLogSwitchLevel(LogSwitchLevelHandler handler)
	{
		lock (locker)
		{
			_LogSwitchLevelHandler = (LogSwitchLevelHandler)Delegate.Remove(_LogSwitchLevelHandler, handler);
		}
	}

	internal static void InvokeLogSwitchLevelHandlers(LogSwitch ls, LoggingLevels newLevel)
	{
		_LogSwitchLevelHandler?.Invoke(ls, newLevel);
	}

	public static void LogMessage(LoggingLevels level, string message)
	{
		LogMessage(level, GlobalSwitch, message);
	}

	public static void LogMessage(LoggingLevels level, LogSwitch logswitch, string message)
	{
		if (logswitch == null)
		{
			throw new ArgumentNullException("LogSwitch");
		}
		if (level < LoggingLevels.TraceLevel0)
		{
			throw new ArgumentOutOfRangeException("level", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (logswitch.CheckLevel(level))
		{
			Debugger.Log((int)level, logswitch.strName, message);
			if (m_fConsoleDeviceEnabled)
			{
				Console.Write(message);
			}
		}
	}

	public static void Trace(LogSwitch logswitch, string message)
	{
		LogMessage(LoggingLevels.TraceLevel0, logswitch, message);
	}

	public static void Trace(string switchname, string message)
	{
		LogSwitch logswitch = LogSwitch.GetSwitch(switchname);
		LogMessage(LoggingLevels.TraceLevel0, logswitch, message);
	}

	public static void Trace(string message)
	{
		LogMessage(LoggingLevels.TraceLevel0, GlobalSwitch, message);
	}

	public static void Status(LogSwitch logswitch, string message)
	{
		LogMessage(LoggingLevels.StatusLevel0, logswitch, message);
	}

	public static void Status(string switchname, string message)
	{
		LogSwitch logswitch = LogSwitch.GetSwitch(switchname);
		LogMessage(LoggingLevels.StatusLevel0, logswitch, message);
	}

	public static void Status(string message)
	{
		LogMessage(LoggingLevels.StatusLevel0, GlobalSwitch, message);
	}

	public static void Warning(LogSwitch logswitch, string message)
	{
		LogMessage(LoggingLevels.WarningLevel, logswitch, message);
	}

	public static void Warning(string switchname, string message)
	{
		LogSwitch logswitch = LogSwitch.GetSwitch(switchname);
		LogMessage(LoggingLevels.WarningLevel, logswitch, message);
	}

	public static void Warning(string message)
	{
		LogMessage(LoggingLevels.WarningLevel, GlobalSwitch, message);
	}

	public static void Error(LogSwitch logswitch, string message)
	{
		LogMessage(LoggingLevels.ErrorLevel, logswitch, message);
	}

	public static void Error(string switchname, string message)
	{
		LogSwitch logswitch = LogSwitch.GetSwitch(switchname);
		LogMessage(LoggingLevels.ErrorLevel, logswitch, message);
	}

	public static void Error(string message)
	{
		LogMessage(LoggingLevels.ErrorLevel, GlobalSwitch, message);
	}

	public static void Panic(string message)
	{
		LogMessage(LoggingLevels.PanicLevel, GlobalSwitch, message);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void AddLogSwitch(LogSwitch logSwitch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void ModifyLogSwitch(int iNewLevel, string strSwitchName, string strParentName);
}
