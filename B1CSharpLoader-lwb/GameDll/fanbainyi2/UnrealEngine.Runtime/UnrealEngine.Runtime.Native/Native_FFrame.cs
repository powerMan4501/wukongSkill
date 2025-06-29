using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FFrame
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Step(IntPtr instance, IntPtr context, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_StepExplicitProperty(IntPtr instance, IntPtr result, IntPtr property);

	[MonoNativeFunctionWrapper]
	public delegate sbyte Del_ReadInt8(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate byte Del_ReadUInt8(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate short Del_ReadInt16(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_ReadUInt16(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_ReadInt32(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_ReadUInt32(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate long Del_ReadInt64(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_ReadUInt64(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate float Del_ReadFloat(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReadName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ReadObject(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_ReadCodeSkipCount(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_ReadVariableSize(IntPtr instance, IntPtr expressionField);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetStackTrace(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetScriptCallstack(ref FScriptArray result);

	public static Del_Step Step;

	public static Del_StepExplicitProperty StepExplicitProperty;

	public static Del_ReadInt8 ReadInt8;

	public static Del_ReadUInt8 ReadUInt8;

	public static Del_ReadInt16 ReadInt16;

	public static Del_ReadUInt16 ReadUInt16;

	public static Del_ReadInt32 ReadInt32;

	public static Del_ReadUInt32 ReadUInt32;

	public static Del_ReadInt64 ReadInt64;

	public static Del_ReadUInt64 ReadUInt64;

	public static Del_ReadFloat ReadFloat;

	public static Del_ReadName ReadName;

	public static Del_ReadObject ReadObject;

	public static Del_ReadCodeSkipCount ReadCodeSkipCount;

	public static Del_ReadVariableSize ReadVariableSize;

	public static Del_GetStackTrace GetStackTrace;

	public static Del_GetScriptCallstack GetScriptCallstack;
}
