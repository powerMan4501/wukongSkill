using System;
using System.IO;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[USharpPath("/Script/b1-Managed.AutoTestLoggerLib")]
public class AutoTestLoggerLib : UBlueprintFunctionLibrary
{
	private static StreamWriter CurrentWriter;

	private static void QALog(UObject WorldContext, AutoTestLogLevel Level, string InString)
	{
		USystemLibrary.PrintString(WorldContext, InString, bPrintToScreen: true, bPrintToLog: false, FLinearColor.Aqua, 5f, new FName("None"));
		UGSE_EngineFuncLib.LogWLevel($"[AutoTest][{BIS_AutoTestManagerV2.Get(WorldContext).RunningCaseName}]{InString}", 4);
		string value = DateTime.Now.ToString() + "|" + Level.ToString() + "|" + InString;
		CurrentWriter?.WriteLine(value);
		CurrentWriter?.Flush();
	}

	public static void QALogStart(UObject WorldContext, string InString)
	{
		CurrentWriter?.Close();
		string path = BIS_AutoTestManagerV2.Get(WorldContext).LogFolderPath + "/" + BIS_AutoTestManagerV2.Get(WorldContext).RunningCaseName + ".log";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (BIS_AutoTestManagerV2.Get(WorldContext).AutoTestCanLog)
		{
			CurrentWriter = new StreamWriter(path, append: true)
			{
				AutoFlush = true
			};
		}
		QALog(WorldContext, AutoTestLogLevel.Start, InString);
	}

	public static void QALogEnd(UObject WorldContext, string InString)
	{
		QALog(WorldContext, AutoTestLogLevel.End, InString);
		CurrentWriter?.Close();
	}

	public static void QALogInfo(UObject WorldContext, string InString)
	{
		QALog(WorldContext, AutoTestLogLevel.Info, InString);
	}

	public static void QALogWarning(UObject WorldContext, string InString)
	{
		QALog(WorldContext, AutoTestLogLevel.Warning, InString);
	}

	public static void QALogError(UObject WorldContext, string InString)
	{
		QALog(WorldContext, AutoTestLogLevel.Error, InString);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTestLoggerLib");
	}

	static AutoTestLoggerLib()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AutoTestLoggerLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AutoTestLoggerLib));
	}
}
