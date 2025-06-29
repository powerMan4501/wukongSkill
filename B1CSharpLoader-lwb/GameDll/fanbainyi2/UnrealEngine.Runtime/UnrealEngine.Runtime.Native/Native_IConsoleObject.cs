using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_IConsoleObject
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetHelp(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetHelp(IntPtr instance, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate EConsoleVariableFlags Del_GetFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFlags(IntPtr instance, EConsoleVariableFlags value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearFlags(IntPtr instance, EConsoleVariableFlags value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_TestFlags(IntPtr instance, EConsoleVariableFlags value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_AsVariable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_AsCommand(IntPtr instance);

	public static Del_GetHelp GetHelp;

	public static Del_SetHelp SetHelp;

	public static Del_GetFlags GetFlags;

	public static Del_SetFlags SetFlags;

	public static Del_ClearFlags ClearFlags;

	public static Del_TestFlags TestFlags;

	public static Del_AsVariable AsVariable;

	public static Del_AsCommand AsCommand;
}
