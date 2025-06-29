using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FEnumProperty
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_SetEnum(IntPtr instance, IntPtr inEnum);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetEnum(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetUnderlyingProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_SetEnum SetEnum;

	public static Del_GetEnum GetEnum;

	public static Del_GetUnderlyingProperty GetUnderlyingProperty;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
