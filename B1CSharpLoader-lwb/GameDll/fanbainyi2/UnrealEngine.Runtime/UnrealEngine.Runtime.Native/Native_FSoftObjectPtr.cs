using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSoftObjectPtr
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUObject(ref FSoftObjectPtrUnsafe instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFWeakObjectPtr(ref FSoftObjectPtrUnsafe instance, ref FWeakObjectPtr value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsPending(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsStale(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNull(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_LoadSynchronous(ref FSoftObjectPtrUnsafe instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Equals(ref FSoftObjectPtrUnsafe instance, ref FSoftObjectPtrUnsafe compare);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_GetTypeHash(ref FSoftObjectPtrUnsafe instance);

	public static Del_Get Get;

	public static Del_SetUObject SetUObject;

	public static Del_SetFWeakObjectPtr SetFWeakObjectPtr;

	public static Del_IsPending IsPending;

	public static Del_IsValid IsValid;

	public static Del_IsStale IsStale;

	public static Del_IsNull IsNull;

	public static Del_Reset Reset;

	public static Del_LoadSynchronous LoadSynchronous;

	public new static Del_Equals Equals;

	public static Del_GetTypeHash GetTypeHash;
}
