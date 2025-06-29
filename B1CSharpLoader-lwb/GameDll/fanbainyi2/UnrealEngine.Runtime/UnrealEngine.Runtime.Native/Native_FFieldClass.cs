using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FFieldClass
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllCastFlags(IntPtr instance, ulong flagToCheck);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyCastFlags(IntPtr instance, ulong flagToCheck);

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_GetCastFlags(IntPtr instance);

	public static Del_HasAllCastFlags HasAllCastFlags;

	public static Del_HasAnyCastFlags HasAnyCastFlags;

	public static Del_GetCastFlags GetCastFlags;
}
