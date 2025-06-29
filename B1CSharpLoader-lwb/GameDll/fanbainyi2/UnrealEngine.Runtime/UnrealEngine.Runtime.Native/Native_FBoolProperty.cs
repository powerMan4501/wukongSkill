using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FBoolProperty
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_GetBoolSize();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetPropertyValue(IntPtr instance, IntPtr address);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPropertyValue(IntPtr instance, IntPtr address, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_GetBoolSize GetBoolSize;

	public static Del_GetPropertyValue GetPropertyValue;

	public static Del_SetPropertyValue SetPropertyValue;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
