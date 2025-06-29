using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObjectBase
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValidLowLevel(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValidLowLevelFast(IntPtr instance, csbool bRecursive);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_GetUniqueID(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetOuter(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetStatID(IntPtr instance, out TStatId result);

	[MonoNativeFunctionWrapper]
	public delegate EObjectFlags Del_GetFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AtomicallySetFlags(IntPtr instance, EObjectFlags flagsToAdd);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AtomicallyClearFlags(IntPtr instance, EObjectFlags flagsToClear);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UObjectForceRegistration(IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessNewlyLoadedUObjects();

	public static Del_IsValidLowLevel IsValidLowLevel;

	public static Del_IsValidLowLevelFast IsValidLowLevelFast;

	public static Del_GetUniqueID GetUniqueID;

	public static Del_GetClass GetClass;

	public static Del_GetOuter GetOuter;

	public static Del_GetFName GetFName;

	public static Del_GetStatID GetStatID;

	public static Del_GetFlags GetFlags;

	public static Del_AtomicallySetFlags AtomicallySetFlags;

	public static Del_AtomicallyClearFlags AtomicallyClearFlags;

	public static Del_UObjectForceRegistration UObjectForceRegistration;

	public static Del_ProcessNewlyLoadedUObjects ProcessNewlyLoadedUObjects;
}
