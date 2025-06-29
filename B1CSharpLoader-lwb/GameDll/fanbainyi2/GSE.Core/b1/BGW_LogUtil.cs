using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_LogUtil
{
	public static bool IsPrintToScreen = true;

	private static bool bDebugConfigEnvIsProd = DebugConfig.Environment.Equals("prod");

	[Conditional("WOODDEBUG")]
	public static void LogDbgWood(UObject WorldContextObject, string format, params object[] args)
	{
		string text = string.Format(format, args);
		USystemLibrary.PrintString(WorldContextObject, text, bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 5f, FName.None);
		UGSE_EngineFuncLib.LogDbg(text, bPrintScreen: true, 5f);
	}

	[Conditional("WOODDEBUG")]
	public static void LogDbgWSim(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogDbg(string.Format("LogDbgWood:" + format, args), bPrintScreen: true, 3f);
	}

	[Conditional("HEXDEBUG")]
	public static void LogDbgHex(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("LogDbgHex:" + format, args));
	}

	[Conditional("DEREKDEBUG")]
	public static void LogDbgDerekWithTraceback(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("LogDbgDerekWithTraceback:" + format, args) + "\n" + new StackTrace().ToString());
	}

	[Conditional("AMENGDEBUG")]
	public static void LogDbgAmengTrace(string format, params object[] args)
	{
		StackTrace stackTrace = new StackTrace();
		UGSE_EngineFuncLib.LogError(string.Format("[Ameng][" + stackTrace.GetFrame(1).GetMethod()?.ToString() + "]:" + format, args) + "\n" + stackTrace.ToString());
	}

	[Conditional("AMENGDEBUG")]
	public static void LogDbgAmeng(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogDbg(string.Format("[Ameng]" + format, args), bPrintScreen: false, 0f);
	}

	[Conditional("GOOSEDEBUG")]
	public static void LogDbgGOOSEWithTraceback(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("LogDbgGOOSEWithTraceback:" + format, args) + "\n" + new StackTrace().ToString());
	}

	[Conditional("GOOSEDEBUG")]
	public static void LogDbgGOOSELogActorSeverityError(string format, AActor actor)
	{
		string empty = string.Empty;
		empty = ((!(actor == null)) ? string.Format(string.Format("LogDbgGOOSELogActorSeverityError: {0} at {1} {2} {3})", actor.GetName(), actor.GetActorLocation(), "\n", format) + new StackTrace().ToString()) : string.Format("LogDbgGOOSELogActorSeverityError: Actor is NULL \n" + new StackTrace().ToString()));
		UGSE_EngineFuncLib.LogError(empty);
	}

	[Conditional("DEBUG")]
	public static void LogDbgMiggeTrace(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("[Migge] " + format, args) + "\n" + new StackTrace().ToString());
	}

	public static void LogDbgMigge(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("[Migge] " + format, args));
	}

	[Conditional("CHRISDEBUG")]
	public static void LogDbgChris(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogError(string.Format("LogDbgChris:" + format, args));
	}

	public static void SetLogEnable(bool bEnableDbg, bool bEnableDbgDisplay, bool bEnableInfo)
	{
		UGSE_EngineFuncLib.SetLogEnable(bEnableDbg, bEnableDbgDisplay, bEnableInfo);
	}

	[Conditional("DEBUG")]
	public static void LogDetail(string Str, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
	{
	}

	[Conditional("DEBUG")]
	public static void LogDebug(string Str)
	{
		UGSE_EngineFuncLib.LogDbg(Str, bPrintScreen: false);
	}

	[Conditional("DEBUG")]
	public static void LogDbg<T1>(string Str, T1 P1)
	{
		UGSE_EngineFuncLib.LogDbg(string.Format(Str, P1), bPrintScreen: false);
	}

	[Conditional("DEBUG")]
	public static void LogDbg(string Str)
	{
		UGSE_EngineFuncLib.LogDbg(Str, bPrintScreen: true);
	}

	[Conditional("DEBUG")]
	public static void LogDbg(string Str, bool PrintScreen, UObject ContextObj, float DisplayTime = 2f, EBGULogColor EColor = EBGULogColor.White, int Key = -1)
	{
		if (ContextObj != null)
		{
			Str = "(" + ContextObj.GetName() + ") " + Str;
		}
		FColor color;
		switch (EColor)
		{
		case EBGULogColor.White:
			color = FColor.White;
			break;
		case EBGULogColor.Red:
			color = FColor.Red;
			DisplayTime = 30f;
			break;
		case EBGULogColor.Blue:
			color = FColor.Blue;
			break;
		case EBGULogColor.Black:
			color = FColor.Black;
			break;
		case EBGULogColor.Transparent:
			color = FColor.Transparent;
			break;
		case EBGULogColor.Green:
			color = FColor.Green;
			break;
		case EBGULogColor.Yellow:
			color = FColor.Yellow;
			break;
		case EBGULogColor.Cyan:
			color = FColor.Cyan;
			break;
		case EBGULogColor.Magenta:
			color = FColor.Magenta;
			break;
		case EBGULogColor.Orange:
			color = FColor.Orange;
			break;
		case EBGULogColor.Purple:
			color = FColor.Purple;
			break;
		case EBGULogColor.Turquoise:
			color = FColor.Turquoise;
			break;
		case EBGULogColor.Silver:
			color = FColor.Silver;
			break;
		case EBGULogColor.Emerald:
			color = FColor.Emerald;
			break;
		default:
			color = FColor.White;
			break;
		}
		UGSE_EngineFuncLib.LogDbgWithColor(Str, PrintScreen, DisplayTime, color, Key);
	}

	[Conditional("USE_INFOLOG")]
	public static void LogInfo<T1>(string Str, T1 P1)
	{
		UGSE_EngineFuncLib.LogInfo(string.Format(Str, P1));
	}

	[Conditional("USE_INFOLOG")]
	public static void LogInfo<T1, T2>(string Str, T1 P1, T2 P2)
	{
		UGSE_EngineFuncLib.LogInfo(string.Format(Str, P1, P2));
	}

	[Conditional("USE_INFOLOG")]
	public static void LogInfo(string Str)
	{
		UGSE_EngineFuncLib.LogInfo(Str);
	}

	[Conditional("USE_INFOLOG")]
	public static void LogInfoFormat(string Str, params object[] values)
	{
		UGSE_EngineFuncLib.LogInfo(string.Format(Str, values));
	}

	[Conditional("USE_INFOLOG")]
	public static void LogWarning(string Str)
	{
		UGSE_EngineFuncLib.LogWarning(Str);
	}

	[Conditional("USE_INFOLOG")]
	public static void LogWarning<T1>(string Str, T1 P1)
	{
		UGSE_EngineFuncLib.LogWarning(string.Format(Str, P1));
	}

	[Conditional("USE_INFOLOG")]
	public static void LogWarning<T1, T2>(string Str, T1 P1, T2 P2)
	{
		UGSE_EngineFuncLib.LogWarning(string.Format(Str, P1, P2));
	}

	public static void LogError(string Str)
	{
		if (!bDebugConfigEnvIsProd)
		{
			UGSE_EngineFuncLib.LogError(Str);
		}
	}

	public static void LogError<T1>(string Str, T1 P1)
	{
		if (!bDebugConfigEnvIsProd)
		{
			UGSE_EngineFuncLib.LogError(string.Format(Str, P1));
		}
	}

	public static void LogError<T1, T2>(string Str, T1 P1, T2 P2)
	{
		if (!bDebugConfigEnvIsProd)
		{
			UGSE_EngineFuncLib.LogError(string.Format(Str, P1, P2));
		}
	}

	public static void LogError<T1, T2, T3>(string Str, T1 P1, T2 P2, T3 P3)
	{
		if (!bDebugConfigEnvIsProd)
		{
			UGSE_EngineFuncLib.LogError(string.Format(Str, P1, P2, P3));
		}
	}

	public static void LogError<T1, T2, T3, T4>(string Str, T1 P1, T2 P2, T3 P3, T4 P4)
	{
		if (!bDebugConfigEnvIsProd)
		{
			UGSE_EngineFuncLib.LogError(string.Format(Str, P1, P2, P3, P4));
		}
	}

	public static void LogShipping(string Str)
	{
		UGSE_EngineFuncLib.LogShipping(Str);
	}

	public static void LogShippingError(string Str)
	{
		UGSE_EngineFuncLib.LogShippingError(Str);
	}

	[Conditional("DEBUG")]
	public static void LogDbgSim(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogDbg(string.Format(format, args), bPrintScreen: false, 5f);
	}

	[Conditional("DEBUG")]
	public static void LogDbgSimV2(UObject WorldContextObject, string format, params object[] args)
	{
		float unpausedTimeSeconds = UGameplayStatics.GetUnpausedTimeSeconds(WorldContextObject);
		UGSE_EngineFuncLib.LogDbg(string.Format($"{unpausedTimeSeconds} {format}", args), bPrintScreen: false, 5f);
	}

	[Conditional("DEBUG")]
	public static void LogDbgEason(string format, params object[] args)
	{
		UGSE_EngineFuncLib.LogDbg(string.Format("[ET] " + format, args), bPrintScreen: false);
	}

	[Conditional("DEBUG")]
	public static void LogDbgDerek(string Str)
	{
		UGSE_EngineFuncLib.LogError("derek:" + Str);
	}

	public static bool LogIfNull(object Obj, string Str)
	{
		if (Obj == null)
		{
			LogError(Str);
			return true;
		}
		return false;
	}

	public static bool LogIfNull<T1>(object Obj, string Str, T1 P1)
	{
		if (Obj == null)
		{
			return true;
		}
		return false;
	}

	public static bool LogIfNull<T1, T2>(object Obj, string Str, T1 P1, T2 P2)
	{
		if (Obj == null)
		{
			return true;
		}
		return false;
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogInfo(UObject WorldContext, string Text, in FName Catogary, bool bMessageLog = false)
	{
		UGSE_EngineFuncLib.VLogInfo(WorldContext, Catogary, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogWarning(UObject WorldContext, string Text, in FName Catogary)
	{
		UGSE_EngineFuncLib.VLogWarning(WorldContext, Catogary, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogError(UObject WorldContext, string Text, in FName Catogary)
	{
		UGSE_EngineFuncLib.VLogError(WorldContext, Catogary, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogLocationInfo(UObject WorldContext, string Text, in FName Catogary, FVector Location, FColor Color, float Radius = 10f)
	{
		UGSE_EngineFuncLib.VLogLocationInfo(WorldContext, Catogary, Location, Radius, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogLocationWarning(UObject WorldContext, string Text, in FName Catogary, FVector Location, FColor Color, float Radius = 10f)
	{
		UGSE_EngineFuncLib.VLogLocationWarning(WorldContext, Catogary, Location, Radius, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogLocationError(UObject WorldContext, string Text, in FName Catogary, FVector Location, FColor Color, float Radius = 10f)
	{
		UGSE_EngineFuncLib.VLogLocationError(WorldContext, Catogary, Location, Radius, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogBoxInfo(UObject WorldContext, string Text, in FName Catogary, FBox Box, FColor Color)
	{
		UGSE_EngineFuncLib.VLogBoxInfo(WorldContext, Catogary, Box, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogBoxWarning(UObject WorldContext, string Text, in FName Catogary, FBox Box, FColor Color)
	{
		UGSE_EngineFuncLib.VLogBoxWarning(WorldContext, Catogary, Box, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogBoxError(UObject WorldContext, string Text, in FName Catogary, FBox Box, FColor Color)
	{
		UGSE_EngineFuncLib.VLogBoxError(WorldContext, Catogary, Box, Color, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogSegmentInfo(UObject WorldContext, string Text, in FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness = 0f)
	{
		UGSE_EngineFuncLib.VLogSegmentInfo(WorldContext, Catogary, SegmentStart, SegmentEnd, Color, Thickness, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogSegmentWarning(UObject WorldContext, string Text, in FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness = 0f)
	{
		UGSE_EngineFuncLib.VLogSegmentWarning(WorldContext, Catogary, SegmentStart, SegmentEnd, Color, Thickness, Text);
	}

	[Conditional("USE_INFOLOG")]
	public static void VLogSegmentError(UObject WorldContext, string Text, in FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness = 0f)
	{
		UGSE_EngineFuncLib.VLogSegmentError(WorldContext, Catogary, SegmentStart, SegmentEnd, Color, Thickness, Text);
	}

	[Conditional("NEVER_COMPILE")]
	public static void TODO(string Msg)
	{
	}
}
