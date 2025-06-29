using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FWorldDelegates
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_WorldEvent(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate void Del_WorldInitializationEvent(IntPtr world, IntPtr ivs);

	[MonoNativeFunctionWrapper]
	public delegate void Del_WorldCleanupEvent(IntPtr world, csbool sessionEnded, csbool cleanupResources);

	[MonoNativeFunctionWrapper]
	public delegate void Del_WorldPostDuplicateEvent(IntPtr world, csbool duplicateForPIE, IntPtr replacementMap, IntPtr objectsToFixReferences);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SeamlessTravelTransition(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SeamlessTravelStart(IntPtr world, IntPtr LevelnamePtr);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReceiveCloseReason(IntPtr world, string CloseReason);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPostWorldCreation(IntPtr instance, Del_WorldEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPreWorldInitialization(IntPtr instance, Del_WorldInitializationEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPostWorldInitialization(IntPtr instance, Del_WorldInitializationEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPostDuplicate(IntPtr instance, Del_WorldPostDuplicateEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnWorldCleanup(IntPtr instance, Del_WorldCleanupEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPostWorldCleanup(IntPtr instance, Del_WorldCleanupEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPreWorldFinishDestroy(IntPtr instance, Del_WorldEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnSeamlessTravelTransition(IntPtr instance, Del_SeamlessTravelTransition handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnSeamlessTravelStart(IntPtr instance, Del_SeamlessTravelStart handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnReceiveCloseReason(IntPtr instance, Del_ReceiveCloseReason handler, ref FDelegateHandle handle, csbool enable);

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPostWorldCreation;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPreWorldInitialization;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPostWorldInitialization;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPostDuplicate;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnWorldCleanup;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPostWorldCleanup;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPreWorldFinishDestroy;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnSeamlessTravelTransition;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnSeamlessTravelStart;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnReceiveCloseReason;
}
