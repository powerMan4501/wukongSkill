using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FInputAxisBinding
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_AxisName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_AxisName(IntPtr instance, ref FName value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_AxisDelegate(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_AxisValue(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_AxisValue(IntPtr instance, float value);

	public static Del_Get_AxisName Get_AxisName;

	public static Del_Set_AxisName Set_AxisName;

	public static Del_Get_AxisDelegate Get_AxisDelegate;

	public static Del_Get_AxisValue Get_AxisValue;

	public static Del_Set_AxisValue Set_AxisValue;
}
