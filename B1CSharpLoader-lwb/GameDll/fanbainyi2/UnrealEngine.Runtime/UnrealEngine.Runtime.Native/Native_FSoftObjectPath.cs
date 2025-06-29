using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSoftObjectPath
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_ToString(ref FSoftObjectPathUnsafe instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetLongPackageName(ref FSoftObjectPathUnsafe instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetAssetName(ref FSoftObjectPathUnsafe instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPath(ref FSoftObjectPathUnsafe instance, ref FScriptArray path);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_TryLoad(ref FSoftObjectPathUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ResolveObject(ref FSoftObjectPathUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(ref FSoftObjectPathUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FSoftObjectPathUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNull(ref FSoftObjectPathUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAsset(ref FSoftObjectPathUnsafe instance);

	public new static Del_ToString ToString;

	public static Del_GetLongPackageName GetLongPackageName;

	public static Del_GetAssetName GetAssetName;

	public static Del_SetPath SetPath;

	public static Del_TryLoad TryLoad;

	public static Del_ResolveObject ResolveObject;

	public static Del_Reset Reset;

	public static Del_IsValid IsValid;

	public static Del_IsNull IsNull;

	public static Del_IsAsset IsAsset;
}
