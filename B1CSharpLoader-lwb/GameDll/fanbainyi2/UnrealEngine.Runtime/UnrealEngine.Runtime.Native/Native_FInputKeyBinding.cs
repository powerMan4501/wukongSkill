using System;
using AOT;
using UnrealEngine.InputCore;

namespace UnrealEngine.Runtime.Native;

public static class Native_FInputKeyBinding
{
	[MonoNativeFunctionWrapper]
	public delegate byte Del_Get_KeyEvent(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_KeyEvent(IntPtr instance, byte value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_ChordEx(IntPtr instance, out FKey key, out csbool shift, out csbool ctrl, out csbool alt, out csbool cmd);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ChordEx(IntPtr instance, ref FKey key, csbool shift, csbool ctrl, csbool alt, csbool cmd);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_KeyDelegate(IntPtr instance);

	public static Del_Get_KeyEvent Get_KeyEvent;

	public static Del_Set_KeyEvent Set_KeyEvent;

	public static Del_Get_ChordEx Get_ChordEx;

	public static Del_Set_ChordEx Set_ChordEx;

	public static Del_Get_KeyDelegate Get_KeyDelegate;
}
