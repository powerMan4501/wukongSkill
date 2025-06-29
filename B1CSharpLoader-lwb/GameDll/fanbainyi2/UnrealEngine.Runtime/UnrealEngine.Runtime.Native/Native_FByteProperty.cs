using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FByteProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_Enum(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Enum(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_Enum Get_Enum;

	public static Del_Set_Enum Set_Enum;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
