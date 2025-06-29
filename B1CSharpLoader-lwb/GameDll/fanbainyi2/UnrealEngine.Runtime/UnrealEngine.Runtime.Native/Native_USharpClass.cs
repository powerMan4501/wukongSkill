using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_USharpClass
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearFuncMapEx(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFallbackFunctionInvoker(IntPtr instance, IntPtr function);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_SetFunctionInvoker(IntPtr instance, ref FScriptArray functionName, IntPtr invoker);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetSharpClassConstructor(IntPtr instance, IntPtr managedConstructor);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ManagedConstructor(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ManagedConstructor(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateNativeParentConstructor(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_USharpAttachThread();

	[MonoNativeFunctionWrapper]
	public delegate void Del_USharpIL2CPP_GCStart();

	[MonoNativeFunctionWrapper]
	public delegate int Del_USharpIL2CPP_GCStep();

	public static Del_ClearFuncMapEx ClearFuncMapEx;

	public static Del_SetFallbackFunctionInvoker SetFallbackFunctionInvoker;

	public static Del_SetFunctionInvoker SetFunctionInvoker;

	public static Del_SetSharpClassConstructor SetSharpClassConstructor;

	public static Del_Get_ManagedConstructor Get_ManagedConstructor;

	public static Del_Set_ManagedConstructor Set_ManagedConstructor;

	public static Del_UpdateNativeParentConstructor UpdateNativeParentConstructor;

	public static Del_USharpAttachThread USharpAttachThread;

	public static Del_USharpIL2CPP_GCStart USharpIL2CPP_GCStart;

	public static Del_USharpIL2CPP_GCStep USharpIL2CPP_GCStep;
}
