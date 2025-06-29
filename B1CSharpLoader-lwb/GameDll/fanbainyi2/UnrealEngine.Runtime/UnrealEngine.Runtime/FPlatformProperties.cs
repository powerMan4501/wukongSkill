using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FPlatformProperties
{
	private static bool hasPlatformValue;

	private static EPlatform platform;

	public static string GetPhysicsFormat()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPlatformProperties.GetPhysicsFormat(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool HasEditorOnlyData()
	{
		return Native_FPlatformProperties.HasEditorOnlyData();
	}

	public static string IniPlatformName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPlatformProperties.IniPlatformName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool IsGameOnly()
	{
		return Native_FPlatformProperties.IsGameOnly();
	}

	public static bool IsServerOnly()
	{
		return Native_FPlatformProperties.IsServerOnly();
	}

	public static bool IsClientOnly()
	{
		return Native_FPlatformProperties.IsClientOnly();
	}

	public static bool IsMonolithicBuild()
	{
		return Native_FPlatformProperties.IsMonolithicBuild();
	}

	public static bool IsProgram()
	{
		return Native_FPlatformProperties.IsProgram();
	}

	public static bool IsLittleEndian()
	{
		return Native_FPlatformProperties.IsLittleEndian();
	}

	public static string PlatformName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FPlatformProperties.PlatformName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool RequiresCookedData()
	{
		return Native_FPlatformProperties.RequiresCookedData();
	}

	public static bool SupportsBuildTarget(EBuildTarget buildTarget)
	{
		return Native_FPlatformProperties.SupportsBuildTarget((int)buildTarget);
	}

	public static bool SupportsAutoSDK()
	{
		return Native_FPlatformProperties.SupportsAutoSDK();
	}

	public static bool SupportsGrayscaleSRGB()
	{
		return Native_FPlatformProperties.SupportsGrayscaleSRGB();
	}

	public static bool SupportsMultipleGameInstances()
	{
		return Native_FPlatformProperties.SupportsMultipleGameInstances();
	}

	public static bool SupportsTessellation()
	{
		return Native_FPlatformProperties.SupportsTessellation();
	}

	public static bool SupportsWindowedMode()
	{
		return Native_FPlatformProperties.SupportsWindowedMode();
	}

	public static bool AllowsFramerateSmoothing()
	{
		return Native_FPlatformProperties.AllowsFramerateSmoothing();
	}

	public static bool SupportsAudioStreaming()
	{
		return Native_FPlatformProperties.SupportsAudioStreaming();
	}

	public static bool SupportsHighQualityLightmaps()
	{
		return Native_FPlatformProperties.SupportsHighQualityLightmaps();
	}

	public static bool SupportsLowQualityLightmaps()
	{
		return Native_FPlatformProperties.SupportsLowQualityLightmaps();
	}

	public static bool SupportsDistanceFieldShadows()
	{
		return Native_FPlatformProperties.SupportsDistanceFieldShadows();
	}

	public static bool SupportsTextureStreaming()
	{
		return Native_FPlatformProperties.SupportsTextureStreaming();
	}

	public static bool HasFixedResolution()
	{
		return Native_FPlatformProperties.HasFixedResolution();
	}

	public static bool SupportsMinimize()
	{
		return Native_FPlatformProperties.SupportsMinimize();
	}

	public static bool SupportsQuit()
	{
		return Native_FPlatformProperties.SupportsQuit();
	}

	public static bool AllowsCallStackDumpDuringAssert()
	{
		return Native_FPlatformProperties.AllowsCallStackDumpDuringAssert();
	}

	public static EPlatform GetPlatform()
	{
		if (hasPlatformValue)
		{
			return platform;
		}
		string text = IniPlatformName();
		if (!string.IsNullOrEmpty(text))
		{
			switch (StringParseHelper.SafeToLower(text))
			{
			case "windows":
				platform = EPlatform.Windows;
				break;
			case "ps4":
				platform = EPlatform.PS4;
				break;
			case "ps5":
				platform = EPlatform.PS5;
				break;
			case "xboxone":
				platform = EPlatform.XboxOne;
				break;
			case "xsx":
				platform = EPlatform.XSX;
				break;
			case "mac":
				platform = EPlatform.Mac;
				break;
			case "ios":
				platform = EPlatform.IOS;
				break;
			case "android":
				platform = EPlatform.Android;
				break;
			case "uwp":
				platform = EPlatform.UWP;
				break;
			case "html5":
				platform = EPlatform.HTML5;
				break;
			case "linux":
				platform = EPlatform.Linux;
				break;
			case "switch":
				platform = EPlatform.Switch;
				break;
			default:
				platform = EPlatform.Unknown;
				break;
			}
		}
		hasPlatformValue = true;
		return platform;
	}
}
