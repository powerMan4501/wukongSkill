using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UScriptStruct
{
	[MonoNativeFunctionWrapper]
	public delegate EStructFlags Del_Get_StructFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_StructFlags(IntPtr instance, EStructFlags value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DeferCppStructOps(ref FName target, IntPtr inCppStructOps);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PrepareCppStructOps(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetCppStructOps(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearCppStructOps(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasDefaults(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldSerializeAtomically(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CompareScriptStruct(IntPtr instance, IntPtr a, IntPtr b, uint portFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyScriptStruct(IntPtr instance, IntPtr dest, IntPtr src, int arrayDim);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearScriptStruct(IntPtr instance, IntPtr dest, int arrayDim);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RecursivelyPreload(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCustomGuid(IntPtr instance, out Guid result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InitializeDefaultValue(IntPtr instance, byte[] inStructData);

	public static Del_Get_StructFlags Get_StructFlags;

	public static Del_Set_StructFlags Set_StructFlags;

	public static Del_DeferCppStructOps DeferCppStructOps;

	public static Del_PrepareCppStructOps PrepareCppStructOps;

	public static Del_GetCppStructOps GetCppStructOps;

	public static Del_ClearCppStructOps ClearCppStructOps;

	public static Del_HasDefaults HasDefaults;

	public static Del_ShouldSerializeAtomically ShouldSerializeAtomically;

	public static Del_CompareScriptStruct CompareScriptStruct;

	public static Del_CopyScriptStruct CopyScriptStruct;

	public static Del_ClearScriptStruct ClearScriptStruct;

	public static Del_RecursivelyPreload RecursivelyPreload;

	public static Del_GetCustomGuid GetCustomGuid;

	public static Del_InitializeDefaultValue InitializeDefaultValue;
}
