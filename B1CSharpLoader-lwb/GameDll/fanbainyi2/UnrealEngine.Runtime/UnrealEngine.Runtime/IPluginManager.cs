using System;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IPluginManager
{
	private static IPluginManager instance;

	public IntPtr Address { get; private set; }

	public static IPluginManager Instance => Get();

	public static IPluginManager Get()
	{
		if (instance == null)
		{
			instance = new IPluginManager();
			instance.Address = Native_IPluginManager.Get();
		}
		return instance;
	}

	public void RefreshPluginsList()
	{
		Native_IPluginManager.RefreshPluginsList(Address);
	}

	public bool LoadModulesForEnabledPlugins(ELoadingPhase loadingPhase)
	{
		return Native_IPluginManager.LoadModulesForEnabledPlugins(Address, (int)loadingPhase);
	}

	public string[] GetLocalizationPathsForEnabledPlugins()
	{
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		Native_IPluginManager.GetLocalizationPathsForEnabledPlugins(Address, tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public bool AreRequiredPluginsAvailable()
	{
		return Native_IPluginManager.AreRequiredPluginsAvailable(Address);
	}

	public bool CheckModuleCompatibility(out string[] incompatibleModules)
	{
		if (Native_IPluginManager.CheckModuleCompatibility == null)
		{
			incompatibleModules = null;
			return true;
		}
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		bool result = Native_IPluginManager.CheckModuleCompatibility(Address, tArrayUnsafe.Address);
		incompatibleModules = tArrayUnsafe.ToArray();
		return result;
	}

	public IPlugin FindPlugin(string name)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		Native_IPluginManager.FindPlugin(Address, ref fStringUnsafe.Array, out var result);
		if (result.IsValid())
		{
			return new IPlugin(result);
		}
		return null;
	}

	public IPlugin[] GetEnabledPlugins()
	{
		using TArrayUnsafe<FSharedPtr> tArrayUnsafe = new TArrayUnsafe<FSharedPtr>();
		Native_IPluginManager.GetEnabledPlugins(Address, tArrayUnsafe.Address);
		return GetPluginArray(tArrayUnsafe);
	}

	public IPlugin[] GetEnabledPluginsWithContent()
	{
		using TArrayUnsafe<FSharedPtr> tArrayUnsafe = new TArrayUnsafe<FSharedPtr>();
		Native_IPluginManager.GetEnabledPluginsWithContent(Address, tArrayUnsafe.Address);
		return GetPluginArray(tArrayUnsafe);
	}

	public IPlugin[] GetDiscoveredPlugins()
	{
		using TArrayUnsafe<FSharedPtr> tArrayUnsafe = new TArrayUnsafe<FSharedPtr>();
		Native_IPluginManager.GetDiscoveredPlugins(Address, tArrayUnsafe.Address);
		return GetPluginArray(tArrayUnsafe);
	}

	public void AddPluginSearchPath(string extraDiscoveryPath, bool refresh = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(extraDiscoveryPath);
		Native_IPluginManager.AddPluginSearchPath(Address, ref fStringUnsafe.Array, refresh);
	}

	public IPlugin[] GetPluginsWithPakFile()
	{
		using TArrayUnsafe<FSharedPtr> tArrayUnsafe = new TArrayUnsafe<FSharedPtr>();
		Native_IPluginManager.GetPluginsWithPakFile(Address, tArrayUnsafe.Address);
		return GetPluginArray(tArrayUnsafe);
	}

	public void MountNewlyCreatedPlugin(string pluginName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(pluginName);
		Native_IPluginManager.MountNewlyCreatedPlugin(Address, ref fStringUnsafe.Array);
	}

	private IPlugin[] GetPluginArray(TArrayUnsafe<FSharedPtr> sharedPtrs)
	{
		int count = sharedPtrs.Count;
		IPlugin[] array = new IPlugin[count];
		for (int i = 0; i < count; i++)
		{
			FSharedPtr sharedPtr = sharedPtrs[i];
			if (sharedPtr.IsValid())
			{
				array[i] = new IPlugin(sharedPtr);
			}
		}
		return array;
	}
}
