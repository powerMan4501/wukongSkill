using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FInputBinding
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_bConsumeInput(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_bConsumeInput(IntPtr instance, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_bExecuteWhenPaused(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_bExecuteWhenPaused(IntPtr instance, csbool value);

	public static Del_Get_bConsumeInput Get_bConsumeInput;

	public static Del_Set_bConsumeInput Set_bConsumeInput;

	public static Del_Get_bExecuteWhenPaused Get_bExecuteWhenPaused;

	public static Del_Set_bExecuteWhenPaused Set_bExecuteWhenPaused;
}
