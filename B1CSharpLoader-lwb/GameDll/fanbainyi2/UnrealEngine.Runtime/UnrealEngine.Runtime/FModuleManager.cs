using System;
using System.Collections.Generic;
using System.Linq;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FModuleManager
{
	public class ModulesChangedHandler : NativeMulticastDelegate<Native_FModuleManager.Del_ModulesChanged, Native_FModuleManager.Del_Reg_ModulesChanged, ModulesChangedHandler.Signature>
	{
		public delegate void Signature(FName moduleName, EModuleChangeReason reason);

		public delegate void NativeDel(ref FName moduleName, EModuleChangeReason reason);

		[MonoPInvokeCallback(typeof(NativeDel))]
		private static void NativeCallback(ref FName moduleName, EModuleChangeReason reason)
		{
			try
			{
				NativeDelegate<Native_FModuleManager.Del_ModulesChanged, Native_FModuleManager.Del_Reg_ModulesChanged, Signature>.managed.Delegate?.Invoke(moduleName, reason);
			}
			catch (Exception e)
			{
				FMessage.LogDelegateException(e);
			}
		}
	}

	public class ProcessLoadedObjectsHandler : NativeMulticastDelegate<Native_FModuleManager.Del_ProcessLoadedObjectsHandler, Native_FModuleManager.Del_Reg_ProcessLoadedObjectsHandler, ProcessLoadedObjectsHandler.Signature>
	{
		public delegate void Signature(FName package, csbool canProcessNewlyLoadedObjects);

		public delegate void NativeDel(ref FName package, csbool canProcessNewlyLoadedObjects);

		[MonoPInvokeCallback(typeof(NativeDel))]
		private static void NativeCallback(ref FName package, csbool canProcessNewlyLoadedObjects)
		{
			try
			{
				NativeDelegate<Native_FModuleManager.Del_ProcessLoadedObjectsHandler, Native_FModuleManager.Del_Reg_ProcessLoadedObjectsHandler, Signature>.managed.Delegate?.Invoke(package, canProcessNewlyLoadedObjects);
			}
			catch (Exception e)
			{
				FMessage.LogDelegateException(e);
			}
		}
	}

	private static FModuleManager instance;

	public static ModulesChangedHandler ModulesChanged;

	public static ProcessLoadedObjectsHandler ProcessLoadedObjects;

	public IntPtr Address { get; internal set; }

	public static FModuleManager Instance => Get();

	public static FModuleManager Get()
	{
		if (instance == null)
		{
			instance = new FModuleManager();
			instance.Address = Native_FModuleManager.Get();
		}
		return instance;
	}

	public void AbandonModule(FName moduleName)
	{
		Native_FModuleManager.AbandonModule(Address, ref moduleName);
	}

	public void AddModule(FName moduleName)
	{
		Native_FModuleManager.AddModule(Address, ref moduleName);
	}

	public bool IsModuleLoaded(FName moduleName)
	{
		return Native_FModuleManager.IsModuleLoaded(Address, ref moduleName);
	}

	public IntPtr LoadModule(FName moduleName)
	{
		return Native_FModuleManager.LoadModule(Address, ref moduleName);
	}

	public IntPtr LoadModuleChecked(FName moduleName)
	{
		return Native_FModuleManager.LoadModuleChecked(Address, ref moduleName);
	}

	public bool LoadModuleWithCallback(FName moduleName)
	{
		return Native_FModuleManager.LoadModuleWithCallback(Address, ref moduleName, IntPtr.Zero);
	}

	public IntPtr LoadModuleWithFailureReason(FName moduleName, out EModuleLoadResult failureReason)
	{
		return Native_FModuleManager.LoadModuleWithFailureReason(Address, ref moduleName, out failureReason);
	}

	public bool QueryModule(FName moduleName, out FModuleStatus outModuleStatus)
	{
		FModuleStatusNative outModuleStatus2 = default(FModuleStatusNative);
		bool result = Native_FModuleManager.QueryModule(Address, ref moduleName, ref outModuleStatus2);
		outModuleStatus = new FModuleStatus(outModuleStatus2);
		outModuleStatus2.Dispose();
		return result;
	}

	public FModuleStatus[] QueryModules()
	{
		List<FModuleStatus> list = new List<FModuleStatus>();
		using (TArrayUnsafe<FModuleStatusNative> tArrayUnsafe = new TArrayUnsafe<FModuleStatusNative>())
		{
			Native_FModuleManager.QueryModules(Address, tArrayUnsafe.Address);
			foreach (FModuleStatusNative item in tArrayUnsafe)
			{
				list.Add(new FModuleStatus(item));
			}
		}
		return list.ToArray();
	}

	public FName[] FindModules(string wildcardWithoutExtension)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(wildcardWithoutExtension);
		using TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>();
		Native_FModuleManager.FindModules(Address, ref fStringUnsafe.Array, tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public bool ModuleExists(string moduleName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(moduleName);
		return Native_FModuleManager.ModuleExists(Address, ref fStringUnsafe.Array);
	}

	public int GetModuleCount()
	{
		return Native_FModuleManager.GetModuleCount(Address);
	}

	public void StartProcessingNewlyLoadedObjects()
	{
		Native_FModuleManager.StartProcessingNewlyLoadedObjects(Address);
	}

	public void AddBinariesDirectory(string inDirectory, bool isGameDirectory)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inDirectory);
		Native_FModuleManager.AddBinariesDirectory(Address, ref fStringUnsafe.Array, isGameDirectory);
	}

	public void SetGameBinariesDirectory(string inDirectory)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inDirectory);
		Native_FModuleManager.SetGameBinariesDirectory(Address, ref fStringUnsafe.Array);
	}

	public string GetGameBinariesDirectory()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FModuleManager.GetGameBinariesDirectory(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool IsModuleUpToDate(FName inModuleName)
	{
		if (Native_FModuleManager.IsModuleUpToDate == null)
		{
			return false;
		}
		return Native_FModuleManager.IsModuleUpToDate(Address, ref inModuleName);
	}

	public bool DoesLoadedModuleHaveUObjects(FName moduleName)
	{
		return Native_FModuleManager.DoesLoadedModuleHaveUObjects(Address, ref moduleName);
	}

	public string GetModuleFilename(FName moduleName)
	{
		if (Native_FModuleManager.IsModuleUpToDate == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FModuleManager.GetModuleFilename(Address, ref moduleName, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	static FModuleManager()
	{
		ModulesChanged = new ModulesChangedHandler();
		ProcessLoadedObjects = new ProcessLoadedObjectsHandler();
		HotReload.RegisterNativeDelegateManager(typeof(FModuleManager));
	}
}
