using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_SharpHotReloadUtils
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateDelegates(IntPtr delegates);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateEnum(IntPtr unrealEnum, IntPtr oldNames, IntPtr oldValues, csbool resolveData);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreUpdateStructs(IntPtr sharpStructs, ref IntPtr outBlueprintsToRecompile, ref IntPtr outChangedStructsBP);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostUpdateStructs(IntPtr sharpChangedStructsOld, IntPtr sharpChangedStructsNew, IntPtr blueprintsToRecompile, IntPtr changedStructsBP);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreateClassReinstancer(IntPtr newClass, IntPtr oldClass);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetTempClass(IntPtr reinstancer, IntPtr trashedClass);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReinstanceClass(IntPtr reinstancer);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FinalizeClasses();

	[MonoNativeFunctionWrapper]
	public delegate void Del_BroadcastOnHotReload(csbool wasTriggeredAutomatically);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_MinimalHotReload();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_MinimalHotReload(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginGuardIsHotReload(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EndGuardIsHotReload();

	public static Del_UpdateDelegates UpdateDelegates;

	public static Del_UpdateEnum UpdateEnum;

	public static Del_PreUpdateStructs PreUpdateStructs;

	public static Del_PostUpdateStructs PostUpdateStructs;

	public static Del_CreateClassReinstancer CreateClassReinstancer;

	public static Del_SetTempClass SetTempClass;

	public static Del_ReinstanceClass ReinstanceClass;

	public static Del_FinalizeClasses FinalizeClasses;

	public static Del_BroadcastOnHotReload BroadcastOnHotReload;

	public static Del_Get_MinimalHotReload Get_MinimalHotReload;

	public static Del_Set_MinimalHotReload Set_MinimalHotReload;

	public static Del_BeginGuardIsHotReload BeginGuardIsHotReload;

	public static Del_EndGuardIsHotReload EndGuardIsHotReload;
}
