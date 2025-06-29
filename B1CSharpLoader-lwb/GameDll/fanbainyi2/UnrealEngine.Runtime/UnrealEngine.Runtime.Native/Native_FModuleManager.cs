using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FModuleManager
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get();

	[MonoNativeFunctionWrapper]
	public delegate void Del_AbandonModule(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddModule(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetModule(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsModuleLoaded(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_LoadModule(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_LoadModuleChecked(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_LoadModuleWithCallback(IntPtr instance, ref FName moduleName, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_LoadModuleWithFailureReason(IntPtr instance, ref FName moduleName, out EModuleLoadResult outFailureReason);

	internal delegate csbool Del_QueryModule(IntPtr instance, ref FName moduleName, ref FModuleStatusNative outModuleStatus);

	[MonoNativeFunctionWrapper]
	public delegate void Del_QueryModules(IntPtr instance, IntPtr outModuleStatuses);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindModules(IntPtr instance, ref FScriptArray wildcardWithoutExtension, IntPtr outModules);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ModuleExists(IntPtr instance, ref FScriptArray moduleName);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetModuleCount(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_StartProcessingNewlyLoadedObjects(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddBinariesDirectory(IntPtr instance, ref FScriptArray inDirectory, csbool isGameDirectory);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetGameBinariesDirectory(IntPtr instance, ref FScriptArray inDirectory);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetGameBinariesDirectory(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsModuleUpToDate(IntPtr instance, ref FName inModuleName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_DoesLoadedModuleHaveUObjects(IntPtr instance, ref FName moduleName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetModuleFilename(IntPtr instance, ref FName moduleName, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ModulesChanged(ref FName moduleName, EModuleChangeReason reason);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessLoadedObjectsHandler(ref FName package, csbool canProcessNewlyLoadedObjects);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ModulesChanged(IntPtr instance, Del_ModulesChanged handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ProcessLoadedObjectsHandler(IntPtr instance, Del_ProcessLoadedObjectsHandler handler, ref FDelegateHandle handle, csbool enable);

	public static Del_Get Get;

	public static Del_AbandonModule AbandonModule;

	public static Del_AddModule AddModule;

	public static Del_GetModule GetModule;

	public static Del_IsModuleLoaded IsModuleLoaded;

	public static Del_LoadModule LoadModule;

	public static Del_LoadModuleChecked LoadModuleChecked;

	public static Del_LoadModuleWithCallback LoadModuleWithCallback;

	public static Del_LoadModuleWithFailureReason LoadModuleWithFailureReason;

	internal static Del_QueryModule QueryModule;

	public static Del_QueryModules QueryModules;

	public static Del_FindModules FindModules;

	public static Del_ModuleExists ModuleExists;

	public static Del_GetModuleCount GetModuleCount;

	public static Del_StartProcessingNewlyLoadedObjects StartProcessingNewlyLoadedObjects;

	public static Del_AddBinariesDirectory AddBinariesDirectory;

	public static Del_SetGameBinariesDirectory SetGameBinariesDirectory;

	public static Del_GetGameBinariesDirectory GetGameBinariesDirectory;

	public static Del_IsModuleUpToDate IsModuleUpToDate;

	public static Del_DoesLoadedModuleHaveUObjects DoesLoadedModuleHaveUObjects;

	public static Del_GetModuleFilename GetModuleFilename;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_ModulesChanged;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_ProcessLoadedObjectsHandler;
}
