using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_IPluginManager
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get();

	[MonoNativeFunctionWrapper]
	public delegate void Del_RefreshPluginsList(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_LoadModulesForEnabledPlugins(IntPtr instance, int loadingPhase);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetLocalizationPathsForEnabledPlugins(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AreRequiredPluginsAvailable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CheckModuleCompatibility(IntPtr instance, IntPtr outIncompatibleModules);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindPlugin(IntPtr instance, ref FScriptArray name, out FSharedPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetEnabledPlugins(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetEnabledPluginsWithContent(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDiscoveredPlugins(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddPluginSearchPath(IntPtr instance, ref FScriptArray extraDiscoveryPath, csbool refresh);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPluginsWithPakFile(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MountNewlyCreatedPlugin(IntPtr instance, ref FScriptArray pluginName);

	public static Del_Get Get;

	public static Del_RefreshPluginsList RefreshPluginsList;

	public static Del_LoadModulesForEnabledPlugins LoadModulesForEnabledPlugins;

	public static Del_GetLocalizationPathsForEnabledPlugins GetLocalizationPathsForEnabledPlugins;

	public static Del_AreRequiredPluginsAvailable AreRequiredPluginsAvailable;

	public static Del_CheckModuleCompatibility CheckModuleCompatibility;

	public static Del_FindPlugin FindPlugin;

	public static Del_GetEnabledPlugins GetEnabledPlugins;

	public static Del_GetEnabledPluginsWithContent GetEnabledPluginsWithContent;

	public static Del_GetDiscoveredPlugins GetDiscoveredPlugins;

	public static Del_AddPluginSearchPath AddPluginSearchPath;

	public static Del_GetPluginsWithPakFile GetPluginsWithPakFile;

	public static Del_MountNewlyCreatedPlugin MountNewlyCreatedPlugin;
}
