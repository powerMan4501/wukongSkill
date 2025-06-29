using System;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FMessage
{
	public const string LogNet = "LogNet";

	private static bool disableExceptionNotifier;

	private static DateTime lastFocusOutputLogTab;

	private static TimeSpan focusOutputLogTabDelay = TimeSpan.FromSeconds(20.0);

	public static EAppReturnType OpenDialog(string message)
	{
		return OpenDialog(message, null);
	}

	public static EAppReturnType OpenDialog(string message, string optTitle)
	{
		return OpenDialog(EAppMsgType.Ok, message, optTitle);
	}

	public static EAppReturnType OpenDialog(EAppMsgType messageType, string message, string optTitle)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(message);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(optTitle);
		return Native_FMessageDialog.Open(messageType, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static bool OpenDialogYesNoType(string message, string optTitle)
	{
		return OpenDialog(EAppMsgType.YesNo, message, optTitle) == EAppReturnType.Yes;
	}

	[Conditional("DEBUG")]
	public static void EnsureDebug(bool condition, string message)
	{
		if (!condition)
		{
			Log(ELogVerbosity.Warning, message);
		}
	}

	public static bool Ensure(bool condition, string message)
	{
		if (!condition)
		{
			Log(ELogVerbosity.Warning, message);
		}
		return condition;
	}

	public static bool Assert(bool condition, string message)
	{
		if (!condition)
		{
			Log(ELogVerbosity.Error, message);
		}
		return condition;
	}

	[Conditional("USE_INFOLOG")]
	public static void Log(string message)
	{
		Log(ELogVerbosity.Log, message);
	}

	[Conditional("USE_INFOLOG")]
	public static void Log(string message, string category)
	{
		Log(category, ELogVerbosity.Log, message);
	}

	public static void Log(ELogVerbosity verbosity, string message)
	{
		Log(null, verbosity, message);
	}

	public static void Log(string category, ELogVerbosity verbosity, string message)
	{
		if (verbosity == ELogVerbosity.Fatal)
		{
			string text = null;
			try
			{
				text = Environment.StackTrace;
			}
			catch
			{
			}
			OpenDialog("Fatal error from C# (USharp):" + Environment.NewLine + Environment.NewLine + message + Environment.NewLine + Environment.NewLine + "Callstack:" + Environment.NewLine + Environment.NewLine + text);
		}
		if (string.IsNullOrEmpty(category))
		{
			category = "USharp";
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(message);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(category);
		Native_FMessageDialog.Log(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, verbosity);
	}

	public static void LogShipping(ELogVerbosity verbosity, string message)
	{
		LogShipping(null, verbosity, message);
	}

	public static void LogShipping(string category, ELogVerbosity verbosity, string message)
	{
		if (verbosity == ELogVerbosity.Fatal)
		{
			string text = null;
			try
			{
				text = Environment.StackTrace;
			}
			catch
			{
			}
			OpenDialog("Fatal error from C# (USharp):" + Environment.NewLine + Environment.NewLine + message + Environment.NewLine + Environment.NewLine + "Callstack:" + Environment.NewLine + Environment.NewLine + text);
		}
		if (string.IsNullOrEmpty(category))
		{
			category = "USharp";
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(message);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(category);
		Native_FMessageDialog.LogShipping(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, verbosity);
	}

	public static void Crash(string message)
	{
		if (FGlobals.IsCriticalError)
		{
			FGlobals.IsCriticalError = false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(message);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe("USharp");
		Native_FMessageDialog.Log(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ELogVerbosity.Fatal);
	}

	internal static void LogException(string exceptionMessage)
	{
		Log(ELogVerbosity.Error, "Unhandled exception: " + exceptionMessage);
		FocusOutputLogTab();
	}

	internal static void LogException(Exception e, string message = null)
	{
		string text = ((!string.IsNullOrEmpty(message)) ? (" (" + message + ")") : string.Empty);
		Log(ELogVerbosity.Error, "Unhandled exception" + text + ": " + e);
		FocusOutputLogTab();
	}

	internal static void LogDelegateException(Exception e)
	{
		LogException(e, "native delegate callback");
		FocusOutputLogTab();
	}

	private static void FocusOutputLogTab()
	{
		if (!disableExceptionNotifier && lastFocusOutputLogTab < DateTime.Now - focusOutputLogTabDelay)
		{
			lastFocusOutputLogTab = DateTime.Now;
		}
	}

	internal static void OnNativeFunctionsRegistered()
	{
	}
}
