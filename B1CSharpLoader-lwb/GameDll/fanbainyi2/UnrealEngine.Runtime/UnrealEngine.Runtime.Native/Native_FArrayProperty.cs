using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FArrayProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_Inner(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Inner(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_Inner Get_Inner;

	public static Del_Set_Inner Set_Inner;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
