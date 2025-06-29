using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FLazyObjectPtr
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUObject(ref FLazyObjectPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFLazyObjectPtr(ref FLazyObjectPtr instance, ref FLazyObjectPtr value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsPending(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsStale(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNull(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(ref FLazyObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Equals(ref FLazyObjectPtr instance, ref FLazyObjectPtr compare);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_GetTypeHash(ref FLazyObjectPtr instance);

	public static Del_Get Get;

	public static Del_SetUObject SetUObject;

	public static Del_SetFLazyObjectPtr SetFLazyObjectPtr;

	public static Del_IsPending IsPending;

	public static Del_IsValid IsValid;

	public static Del_IsStale IsStale;

	public static Del_IsNull IsNull;

	public static Del_Reset Reset;

	public new static Del_Equals Equals;

	public static Del_GetTypeHash GetTypeHash;
}
