using System;
using System.Diagnostics;
using System.IO;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BED_EditorStartupCheckEngineVer
{
	private static bool HasStartup = false;

	public static string BuildEngineVesion = "nan";

	public static string UsingBuildEngineType => "B1Engine";

	private static void LogOneFileInfo(string Message, string Path)
	{
		try
		{
			_ = new FileInfo(FPaths.Combine(Path)).LastWriteTime;
		}
		catch
		{
		}
	}

	private static void LogEditorVersion()
	{
		LogOneFileInfo("Editor Important Info: b1.Managed.dll", FPaths.Combine(USystemLibrary.GetProjectDirectory(), "Binaries/Managed/b1.Managed.dll"));
		LogOneFileInfo("Editor Important Info: GSBuild.version", FPaths.EngineDir + "Build/GSBuild.version");
		InitEditorCrashReporter();
	}

	private static void InitEditorCrashReporter()
	{
	}

	[Conditional("WITH_EDITOR")]
	public static void OnStartup()
	{
		if (!HasStartup)
		{
			LogEditorVersion();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 0; i < commandLineArgs.Length && !StringParseHelper.SafeToLower(commandLineArgs[i]).Contains("-run=") && !StringParseHelper.SafeToLower(commandLineArgs[i]).Contains("-Cmd.exe"); i++)
			{
			}
		}
	}
}
