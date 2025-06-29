using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FAssetData
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_TagsAndValues(ref FAssetDataNative instance, IntPtr outTags, IntPtr outValues);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FAssetDataNative instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsUAsset(ref FAssetDataNative instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRedirector(ref FAssetDataNative instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFullName(ref FAssetDataNative instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetExportTextName(ref FAssetDataNative instance, ref FScriptArray result);

	public static Del_Get_TagsAndValues Get_TagsAndValues;

	public static Del_IsValid IsValid;

	public static Del_IsUAsset IsUAsset;

	public static Del_IsRedirector IsRedirector;

	public static Del_GetFullName GetFullName;

	public static Del_GetExportTextName GetExportTextName;
}
