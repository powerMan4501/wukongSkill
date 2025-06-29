using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FPlatformProperties
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPhysicsFormat(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasEditorOnlyData();

	[MonoNativeFunctionWrapper]
	public delegate void Del_IniPlatformName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsGameOnly();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsServerOnly();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsClientOnly();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsMonolithicBuild();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsProgram();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsLittleEndian();

	[MonoNativeFunctionWrapper]
	public delegate void Del_PlatformName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_RequiresCookedData();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsBuildTarget(int buildTarget);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsAutoSDK();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsGrayscaleSRGB();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsMultipleGameInstances();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsTessellation();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsWindowedMode();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AllowsFramerateSmoothing();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsAudioStreaming();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsHighQualityLightmaps();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsLowQualityLightmaps();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsDistanceFieldShadows();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsTextureStreaming();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasFixedResolution();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsMinimize();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SupportsQuit();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AllowsCallStackDumpDuringAssert();

	public static Del_GetPhysicsFormat GetPhysicsFormat;

	public static Del_HasEditorOnlyData HasEditorOnlyData;

	public static Del_IniPlatformName IniPlatformName;

	public static Del_IsGameOnly IsGameOnly;

	public static Del_IsServerOnly IsServerOnly;

	public static Del_IsClientOnly IsClientOnly;

	public static Del_IsMonolithicBuild IsMonolithicBuild;

	public static Del_IsProgram IsProgram;

	public static Del_IsLittleEndian IsLittleEndian;

	public static Del_PlatformName PlatformName;

	public static Del_RequiresCookedData RequiresCookedData;

	public static Del_SupportsBuildTarget SupportsBuildTarget;

	public static Del_SupportsAutoSDK SupportsAutoSDK;

	public static Del_SupportsGrayscaleSRGB SupportsGrayscaleSRGB;

	public static Del_SupportsMultipleGameInstances SupportsMultipleGameInstances;

	public static Del_SupportsTessellation SupportsTessellation;

	public static Del_SupportsWindowedMode SupportsWindowedMode;

	public static Del_AllowsFramerateSmoothing AllowsFramerateSmoothing;

	public static Del_SupportsAudioStreaming SupportsAudioStreaming;

	public static Del_SupportsHighQualityLightmaps SupportsHighQualityLightmaps;

	public static Del_SupportsLowQualityLightmaps SupportsLowQualityLightmaps;

	public static Del_SupportsDistanceFieldShadows SupportsDistanceFieldShadows;

	public static Del_SupportsTextureStreaming SupportsTextureStreaming;

	public static Del_HasFixedResolution HasFixedResolution;

	public static Del_SupportsMinimize SupportsMinimize;

	public static Del_SupportsQuit SupportsQuit;

	public static Del_AllowsCallStackDumpDuringAssert AllowsCallStackDumpDuringAssert;
}
