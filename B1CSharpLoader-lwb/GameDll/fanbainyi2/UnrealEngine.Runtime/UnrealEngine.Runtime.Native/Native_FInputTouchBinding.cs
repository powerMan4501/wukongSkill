using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FInputTouchBinding
{
	[MonoNativeFunctionWrapper]
	public delegate byte Del_Get_KeyEvent(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_KeyEvent(IntPtr instance, byte value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_TouchDelegate(IntPtr instance);

	public static Del_Get_KeyEvent Get_KeyEvent;

	public static Del_Set_KeyEvent Set_KeyEvent;

	public static Del_Get_TouchDelegate Get_TouchDelegate;
}
