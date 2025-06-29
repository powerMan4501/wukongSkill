using System;
using AOT;
using UnrealEngine.InputCore;

namespace UnrealEngine.Runtime.Native;

public static class Native_FInputGestureBinding
{
	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_GestureValue(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GestureValue(IntPtr instance, float value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GestureKey(IntPtr instance, out FKey result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GestureKey(IntPtr instance, ref FKey value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GestureDelegate(IntPtr instance);

	public static Del_Get_GestureValue Get_GestureValue;

	public static Del_Set_GestureValue Set_GestureValue;

	public static Del_Get_GestureKey Get_GestureKey;

	public static Del_Set_GestureKey Set_GestureKey;

	public static Del_Get_GestureDelegate Get_GestureDelegate;
}
