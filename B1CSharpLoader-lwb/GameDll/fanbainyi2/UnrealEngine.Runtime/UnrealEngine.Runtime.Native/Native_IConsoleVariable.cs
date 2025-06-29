using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_IConsoleVariable
{
	[MonoNativeFunctionWrapper]
	public delegate void FConsoleVariableDelegate(IntPtr consoleVariable);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetInt(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetFloat(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetString(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetOnChangedCallback(IntPtr instance, FConsoleVariableDelegate callback);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearOnChangedCallback(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetInt(IntPtr instance, int value, EConsoleVariableFlags setBy);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFloat(IntPtr instance, float value, EConsoleVariableFlags setBy);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetString(IntPtr instance, ref FScriptArray value, EConsoleVariableFlags setBy);

	public static Del_GetInt GetInt;

	public static Del_GetFloat GetFloat;

	public static Del_GetString GetString;

	public static Del_SetOnChangedCallback SetOnChangedCallback;

	public static Del_ClearOnChangedCallback ClearOnChangedCallback;

	public static Del_SetInt SetInt;

	public static Del_SetFloat SetFloat;

	public static Del_SetString SetString;
}
