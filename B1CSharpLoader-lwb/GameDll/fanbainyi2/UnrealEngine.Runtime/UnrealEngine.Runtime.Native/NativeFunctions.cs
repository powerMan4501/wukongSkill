using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;

namespace UnrealEngine.Runtime.Native;

internal static class NativeFunctions
{
	[MonoNativeFunctionWrapper]
	private delegate void Del_RegisterFunctions(IntPtr registerFuncCallback);

	private delegate void Del_RegisterFunction(IntPtr func, string name);

	private static Dictionary<string, FieldInfo> functions = new Dictionary<string, FieldInfo>();

	private static Del_RegisterFunction registerFunction = RegisterFunction;

	public static void RegisterFunctions(IntPtr registerFunctionsAddr)
	{
		if (!EntryPoint.Preloaded)
		{
			string text = typeof(NativeFunctions).Namespace;
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if (!type.IsClass || !type.IsAbstract || !type.IsSealed || !type.Name.StartsWith("Native_") || !(type.Namespace == text))
				{
					continue;
				}
				string text2 = "Export" + type.Name.Replace("Native", string.Empty) + "_";
				FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (FieldInfo fieldInfo in fields)
				{
					if (fieldInfo.IsStatic && fieldInfo.FieldType.IsSubclassOf(typeof(Delegate)))
					{
						functions.Add(text2 + fieldInfo.Name, fieldInfo);
					}
				}
			}
			((Del_RegisterFunctions)Marshal.GetDelegateForFunctionPointer(registerFunctionsAddr, typeof(Del_RegisterFunctions)))(Marshal.GetFunctionPointerForDelegate(registerFunction));
			FBuild.OnNativeFunctionsRegistered();
			FGlobals.OnNativeFunctionsRegistered();
			Classes.OnNativeFunctionsRegistered();
			BoolMarshaler.OnNativeFunctionsRegistered();
			FStringMarshaler.OnNativeFunctionsRegistered();
			FKey.OnNativeFunctionsRegistered();
			StructValidator.ValidateStructs();
		}
		if (!EntryPoint.Preloading)
		{
			if (FGlobals.GEngine == IntPtr.Zero)
			{
				FCoreDelegates.OnPostEngineInit.Bind(OnPostEngineInit);
			}
			GCHelper.OnNativeFunctionsRegistered();
			FTimerManagerCache.OnNativeFunctionsRegistered();
			WorldTimeHelper.OnNativeFunctionsRegistered();
			if (FGlobals.GEngine != IntPtr.Zero)
			{
				StaticVarManager.OnNativeFunctionsRegistered();
				Coroutine.OnNativeFunctionsRegistered();
			}
			NativeReflection.OnNativeFunctionsRegistered();
			OnNativeFunctionsRegistered();
			if (!SharedRuntimeState.IsAOT)
			{
				EngineLoop.OnNativeFunctionsRegistered();
				CodeGenerator.OnNativeFunctionsRegistered();
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnPostEngineInit()
	{
		try
		{
			StaticVarManager.OnNativeFunctionsRegistered();
			Coroutine.OnNativeFunctionsRegistered();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtrStr))]
	private static void RegisterFunction(IntPtr func, string name)
	{
		if (functions.TryGetValue(name, out var value))
		{
			try
			{
				value.SetValue(null, Marshal.GetDelegateForFunctionPointer(func, value.FieldType));
			}
			catch (Exception ex)
			{
				_ = "Failed to register native function \"" + name + "\" exception: " + ex;
			}
		}
	}

	private static void OnNativeFunctionsRegistered()
	{
		bool isReloading = HotReload.IsReloading;
		HotReload.MinimalReload = Native_SharpHotReloadUtils.Get_MinimalHotReload();
		IntPtr intPtr = NativeReflection.FindPackage(IntPtr.Zero, "/Script/USharp");
		if (intPtr != IntPtr.Zero)
		{
			Native_UPackage.ClearPackageFlags(intPtr, EPackageFlags.EditorOnly);
		}
		using (HotReload.Timing.Create("UnrealTypes.Load"))
		{
			UnrealTypes.Load();
		}
		if (HotReload.IsReloading)
		{
			HotReload.OnPreReloadBegin();
		}
		using (HotReload.Timing.Create("UnrealTypes.LoadNative"))
		{
			UnrealTypes.LoadNative();
		}
		using (HotReload.Timing.Create("UClass.Load"))
		{
			UClass.Load();
		}
		if (!AssemblyContext.IsCoreCLR || CurrentAssemblyContext.Reference.IsInvalid)
		{
			CurrentAssemblyContext.AssemblyResolve += CurrentDomain_AssemblyResolve;
		}
		CurrentAssemblyContext.AssemblyLoad += OnAssemblyLoad;
		CurrentAssemblyContext.Resolving += CurrentAssemblyContext_Resolving;
		using (HotReload.Timing.Create("NativeFunctions.LoadAssemblies"))
		{
			if (SharedRuntimeState.GetInitializedRuntimes() != EDotNetRuntime.IL2CPP)
			{
				LoadAssemblies();
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly in assemblies)
				{
					ManagedUnrealModuleInfo.PreProcessAssembly(assembly);
					UClass.Load(assembly);
				}
			}
		}
		if (HotReload.IsReloading)
		{
			HotReload.OnPreReloadEnd();
		}
		using (HotReload.Timing.Create("ManagedUnrealModuleInfo.Load"))
		{
			ManagedUnrealModuleInfo.Load();
		}
		using (HotReload.Timing.Create("ManagedUnrealTypes.Load"))
		{
			ManagedUnrealTypes.Load();
		}
		using (HotReload.Timing.Create("HotReload.OnReload"))
		{
			if (HotReload.IsReloading)
			{
				HotReload.OnReload();
			}
		}
		if (HotReload.Data != null)
		{
			HotReload.Data.Close();
			HotReload.Data = null;
		}
		if (FBuild.WithEditor && isReloading)
		{
			using (HotReload.Timing.Create("UObject.CollectGarbage"))
			{
				UObject.CollectGarbage(GCHelper.GarbageCollectionKeepFlags);
			}
			if (!ManagedUnrealTypes.SkipBroadcastHotReload)
			{
				using (HotReload.Timing.Create("SharpHotReloadUtils.BroadcastOnHotReload"))
				{
					Coroutine.StartCoroutine(null, DeferBroadcastHotReload());
				}
			}
		}
		using (HotReload.Timing.Create("GC.Collect"))
		{
			GC.Collect();
		}
	}

	private static IEnumerator DeferBroadcastHotReload()
	{
		yield return Coroutine.WaitForFrames(1uL);
		Native_SharpHotReloadUtils.BroadcastOnHotReload(true);
	}

	private static Assembly CurrentAssemblyContext_Resolving(AssemblyName arg)
	{
		return OnAssemblyResolve(arg.FullName);
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		return OnAssemblyResolve(args.Name);
	}

	private static Assembly OnAssemblyResolve(string assemblyName)
	{
		if (!string.IsNullOrEmpty(UnrealTypes.GameAssemblyDirectory))
		{
			for (int i = 0; i < 3; i++)
			{
				int num = assemblyName.LastIndexOf(',');
				if (num >= 0)
				{
					assemblyName = assemblyName.Substring(0, num);
				}
			}
			assemblyName += ".dll";
			if (AssemblyContext.IsCoreCLR && assemblyName == "UnrealBuildTool.dll")
			{
				assemblyName = "UnrealBuildTool.exe";
			}
			string text = Path.Combine(UnrealTypes.GameAssemblyDirectory, assemblyName);
			if (File.Exists(text))
			{
				if (AssemblyContext.IsCoreCLR)
				{
					return CurrentAssemblyContext.LoadFrom(text);
				}
				return Assembly.LoadFrom(text);
			}
		}
		return null;
	}

	private static void OnAssemblyLoad(object sender, AssemblyLoadEventArgs args)
	{
		Assembly assembly = typeof(NativeFunctions).Assembly;
		Assembly loadedAssembly = args.LoadedAssembly;
		AssemblyName[] referencedAssemblies = loadedAssembly.GetReferencedAssemblies();
		for (int i = 0; i < referencedAssemblies.Length; i++)
		{
			if (!(referencedAssemblies[i].FullName == assembly.FullName))
			{
				continue;
			}
			try
			{
				ManagedUnrealModuleInfo.PreProcessAssembly(loadedAssembly);
				UClass.Load(loadedAssembly);
				break;
			}
			catch (ReflectionTypeLoadException ex)
			{
				Exception[] loaderExceptions = ex.LoaderExceptions;
				for (int j = 0; j < loaderExceptions.Length; j++)
				{
					_ = loaderExceptions[j];
				}
				Debugger.Break();
				break;
			}
			catch (Exception)
			{
				Debugger.Break();
				break;
			}
		}
	}

	private static void LoadAssemblies()
	{
		if (AssemblyContext.IsCoreCLR)
		{
			AppContext.SetSwitch("System.Net.DisableIPv6", isEnabled: true);
		}
		string text = null;
		HashSet<string> hashSet = new HashSet<string>();
		string text2 = Path.Combine(FPaths.ProjectDir, "Binaries", "Win64", "Managed");
		string text3 = FPaths.ProjectFilePath;
		if (!string.IsNullOrEmpty(text3))
		{
			text3 = Path.GetFileNameWithoutExtension(text3);
			text3 = "b1";
			if (FBuild.WithEditor && !Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			string text4 = "";
			if (Directory.Exists(text2))
			{
				text4 = Path.GetFullPath(Path.Combine(text2, text3 + ".Managed.dll"));
			}
			if (FGlobals.IsEditor && !SharedRuntimeState.IsAOT)
			{
				text4 = Path.GetFullPath(Path.Combine(text2, "Editor.Main.dll"));
			}
			if (File.Exists(text4))
			{
				text = text4;
			}
			hashSet.Add(text4);
		}
		string internalProjectName = FGlobals.InternalProjectName;
		if (string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(internalProjectName))
		{
			string text5 = internalProjectName + ".Managed.dll";
			if (File.Exists(text5))
			{
				text5 = Path.GetFullPath(internalProjectName + ".Managed.dll");
			}
			if (!File.Exists(text5) && Directory.Exists(Path.Combine("../", "Managed")))
			{
				text5 = Path.GetFullPath(Path.Combine("../", "Managed", internalProjectName + ".Managed.dll"));
			}
			if (File.Exists(text5) || SharedRuntimeState.IsAOT)
			{
				text = text5;
			}
			hashSet.Add(text5);
		}
		if (!string.IsNullOrEmpty(text) && (File.Exists(text) || SharedRuntimeState.IsAOT))
		{
			hashSet.Clear();
			hashSet.Add(text);
			UnrealTypes.GameAssemblyPath = text;
			UnrealTypes.GameAssemblyDirectory = Path.GetDirectoryName(UnrealTypes.GameAssemblyPath);
			Assembly assembly = CurrentAssemblyContext.LoadFrom(text);
			if (FGlobals.IsEditor)
			{
				CurrentAssemblyContext.LoadFrom(Path.GetFullPath(Path.Combine(text2, text3 + ".Managed.dll")));
				string name = "EntryPoint";
				string name2 = "DllMain";
				Type type = assembly.GetType(name);
				if (type != null)
				{
					MethodInfo method = type.GetMethod(name2);
					if (method != null)
					{
						method.Invoke(null, null);
					}
				}
			}
			string[] array = ResolveAssemblyDependencies(assembly);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		EntryPoint.HotReloadAssemblyPaths = hashSet.ToArray();
	}

	private static string[] ResolveAssemblyDependencies(Assembly assembly)
	{
		return new string[0];
	}
}
