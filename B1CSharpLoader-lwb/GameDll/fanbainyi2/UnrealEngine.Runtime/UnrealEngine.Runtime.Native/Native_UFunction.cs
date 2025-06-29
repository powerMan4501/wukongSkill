using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UFunction
{
	[MonoNativeFunctionWrapper]
	public delegate EFunctionFlags Del_Get_FunctionFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_FunctionFlags(IntPtr instance, EFunctionFlags value);

	[MonoNativeFunctionWrapper]
	public delegate byte Del_Get_NumParms(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_NumParms(IntPtr instance, byte value);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_Get_ParmsSize(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ParmsSize(IntPtr instance, ushort value);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_Get_ReturnValueOffset(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ReturnValueOffset(IntPtr instance, ushort value);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_Get_RPCId(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_RPCId(IntPtr instance, ushort value);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_Get_RPCResponseId(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_RPCResponseId(IntPtr instance, ushort value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_FirstPropertyToInit(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_FirstPropertyToInit(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetNativeFunc(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetNativeFunc(IntPtr instance, IntPtr inFunc);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Invoke(IntPtr instance, IntPtr obj, IntPtr stack, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InitializeDerivedMembers(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetSuperFunction(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetReturnProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyFunctionFlags(IntPtr instance, EFunctionFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllFunctionFlags(IntPtr instance, EFunctionFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate EPropertyFlags Del_GetDefaultIgnoredSignatureCompatibilityFlags();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsSignatureCompatibleWith(IntPtr instance, IntPtr otherFunction);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsSignatureCompatibleWithFlags(IntPtr instance, IntPtr otherFunction, EFunctionFlags ignoreFlags);

	public static Del_Get_FunctionFlags Get_FunctionFlags;

	public static Del_Set_FunctionFlags Set_FunctionFlags;

	public static Del_Get_NumParms Get_NumParms;

	public static Del_Set_NumParms Set_NumParms;

	public static Del_Get_ParmsSize Get_ParmsSize;

	public static Del_Set_ParmsSize Set_ParmsSize;

	public static Del_Get_ReturnValueOffset Get_ReturnValueOffset;

	public static Del_Set_ReturnValueOffset Set_ReturnValueOffset;

	public static Del_Get_RPCId Get_RPCId;

	public static Del_Set_RPCId Set_RPCId;

	public static Del_Get_RPCResponseId Get_RPCResponseId;

	public static Del_Set_RPCResponseId Set_RPCResponseId;

	public static Del_Get_FirstPropertyToInit Get_FirstPropertyToInit;

	public static Del_Set_FirstPropertyToInit Set_FirstPropertyToInit;

	public static Del_GetNativeFunc GetNativeFunc;

	public static Del_SetNativeFunc SetNativeFunc;

	public static Del_Invoke Invoke;

	public static Del_InitializeDerivedMembers InitializeDerivedMembers;

	public static Del_GetSuperFunction GetSuperFunction;

	public static Del_GetReturnProperty GetReturnProperty;

	public static Del_HasAnyFunctionFlags HasAnyFunctionFlags;

	public static Del_HasAllFunctionFlags HasAllFunctionFlags;

	public static Del_GetDefaultIgnoredSignatureCompatibilityFlags GetDefaultIgnoredSignatureCompatibilityFlags;

	public static Del_IsSignatureCompatibleWith IsSignatureCompatibleWith;

	public static Del_IsSignatureCompatibleWithFlags IsSignatureCompatibleWithFlags;
}
