using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FWeakObjectPtr
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get(ref FWeakObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetEvenIfUnreachable(ref FWeakObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUObject(ref FWeakObjectPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFWeakObjectPtr(ref FWeakObjectPtr instance, ref FWeakObjectPtr value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FWeakObjectPtr instance, csbool evenIfPendingKill, csbool threadsafeTest);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsStale(ref FWeakObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(ref FWeakObjectPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Equals(ref FWeakObjectPtr instance, ref FWeakObjectPtr compare);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_GetTypeHash(ref FWeakObjectPtr instance);

	public static Del_Get Get;

	public static Del_GetEvenIfUnreachable GetEvenIfUnreachable;

	public static Del_SetUObject SetUObject;

	public static Del_SetFWeakObjectPtr SetFWeakObjectPtr;

	public static Del_IsValid IsValid;

	public static Del_IsStale IsStale;

	public static Del_Reset Reset;

	public new static Del_Equals Equals;

	public static Del_GetTypeHash GetTypeHash;
}
