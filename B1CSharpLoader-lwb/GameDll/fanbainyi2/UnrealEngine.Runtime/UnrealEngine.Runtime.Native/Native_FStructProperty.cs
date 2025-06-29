using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FStructProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_Struct(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Struct(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_Struct Get_Struct;

	public static Del_Set_Struct Set_Struct;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
