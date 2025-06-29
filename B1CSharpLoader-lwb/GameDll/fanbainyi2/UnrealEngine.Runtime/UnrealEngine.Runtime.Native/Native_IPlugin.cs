using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_IPlugin
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetName(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDescriptorFileName(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetBaseDir(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetContentDir(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetMountedAssetPath(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetType(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEnabled(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEnabledByDefault(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsHidden(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanContainContent(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetLoadedFrom(IntPtr instance);

	public static Del_GetName GetName;

	public static Del_GetDescriptorFileName GetDescriptorFileName;

	public static Del_GetBaseDir GetBaseDir;

	public static Del_GetContentDir GetContentDir;

	public static Del_GetMountedAssetPath GetMountedAssetPath;

	public new static Del_GetType GetType;

	public static Del_IsEnabled IsEnabled;

	public static Del_IsEnabledByDefault IsEnabledByDefault;

	public static Del_IsHidden IsHidden;

	public static Del_CanContainContent CanContainContent;

	public static Del_GetLoadedFrom GetLoadedFrom;
}
