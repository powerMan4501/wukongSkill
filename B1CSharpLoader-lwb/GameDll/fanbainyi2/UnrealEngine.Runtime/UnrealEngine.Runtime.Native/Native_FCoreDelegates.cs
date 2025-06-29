using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FCoreDelegates
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_CoreDelegates(IntPtr instance, IntPtr handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnControllerConnectionChange(csbool connected, int userId, int controllerIndex);

	[MonoNativeFunctionWrapper]
	public delegate void Del_JumpToDefinitionDelegate(ref FScriptArray ModuleName, ref FScriptArray ClassName, ref FScriptArray FunctionName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnControllerConnectionChange(IntPtr instance, Del_OnControllerConnectionChange handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnHandleSystemEnsure(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnHandleSystemError(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnShutdownAfterError(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnInit(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPostEngineInit(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnExit(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPreExit(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnBeginFrame(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnEndFrame(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationWillDeactivateDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationHasReactivatedDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationWillEnterBackgroundDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationHasEnteredForegroundDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationWillTerminateDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_JumpToDefinitionDelegate(IntPtr instance, Del_JumpToDefinitionDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationIsSystemUiOverlaidDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ApplicationNoSystemUiOverlaidDelegate(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	public static Del_Reg_CoreDelegates Reg_OnControllerConnectionChange;

	public static Del_Reg_CoreDelegates Reg_OnHandleSystemEnsure;

	public static Del_Reg_CoreDelegates Reg_OnHandleSystemError;

	public static Del_Reg_CoreDelegates Reg_OnShutdownAfterError;

	public static Del_Reg_CoreDelegates Reg_OnInit;

	public static Del_Reg_CoreDelegates Reg_OnPostEngineInit;

	public static Del_Reg_CoreDelegates Reg_OnExit;

	public static Del_Reg_CoreDelegates Reg_OnPreExit;

	public static Del_Reg_CoreDelegates Reg_OnBeginFrame;

	public static Del_Reg_CoreDelegates Reg_OnEndFrame;

	public static Del_Reg_CoreDelegates Reg_ApplicationWillDeactivateDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationHasReactivatedDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationWillEnterBackgroundDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationHasEnteredForegroundDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationWillTerminateDelegate;

	public static Del_Reg_CoreDelegates Reg_JumpToDefinitionDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationIsSystemUiOverlaidDelegate;

	public static Del_Reg_CoreDelegates Reg_ApplicationNoSystemUiOverlaidDelegate;
}
