using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UnrealEngine.Runtime;

public static class CurrentAssemblyContext
{
	private static bool initialized = false;

	private static Action<KeyValuePair<long, long>> onUnloading = OnUnloading;

	private static Func<KeyValuePair<long, long>, AssemblyName, Assembly> onResolving = OnResolving;

	private static Dictionary<Assembly, string> assemblyPaths;

	private static Dictionary<string, Assembly> assemblyPathsReverse;

	public static AssemblyContextRef Reference { get; private set; }

	public static event Func<AssemblyName, Assembly> Resolving;

	public static event ResolveEventHandler AssemblyResolve;

	public static event AssemblyLoadEventHandler AssemblyLoad;

	internal static void Initialize(AssemblyContextRef reference)
	{
		initialized = true;
		Reference = reference;
		if (AssemblyContext.IsCoreCLR && !reference.IsInvalid)
		{
			AssemblyContextProxy.AddUnloadingEvent(reference, onUnloading);
			AssemblyContextProxy.AddUnloadingResolving(reference, onResolving);
			assemblyPaths = new Dictionary<Assembly, string>();
			assemblyPathsReverse = new Dictionary<string, Assembly>();
		}
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
	}

	public static string GetFilePath(Assembly assembly)
	{
		if (AssemblyContext.IsCoreCLR && !Reference.IsInvalid)
		{
			if (assemblyPaths.TryGetValue(assembly, out var value))
			{
				return value;
			}
		}
		else
		{
			string localPath = new Uri(assembly.CodeBase).LocalPath;
			if (File.Exists(localPath))
			{
				return Path.GetFullPath(localPath);
			}
		}
		return null;
	}

	public static Assembly[] GetAssemblies()
	{
		if (!initialized)
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		return Reference.GetAssemblies();
	}

	public static Assembly[] GetAllAssemblies()
	{
		return AppDomain.CurrentDomain.GetAssemblies();
	}

	public static Type GetType(string typeName)
	{
		return GetType(typeName, ignoreCase: false);
	}

	public static Type GetType(string typeName, bool ignoreCase)
	{
		StringComparison comparisonType = (ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
		Assembly[] assemblies = GetAssemblies();
		for (int i = 0; i < assemblies.Length; i++)
		{
			Type[] types = assemblies[i].GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName.Equals(typeName, comparisonType))
				{
					return type;
				}
			}
		}
		return null;
	}

	public static bool LoadFromAssmName(string AssemName, out Assembly Assem)
	{
		Assem = null;
		try
		{
			Assem = Assembly.Load(AssemName);
			if (Assem != null)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static Assembly LoadFromInternal(string assemblyPath)
	{
		string[] array = assemblyPath.Split('/', '\\');
		string text = array[array.Length - 1].Replace(".dll", "");
		Assembly Assem = null;
		if (LoadFromAssmName(text + ", Version = 1.0.0.0, Culture = neutral, PublicKeyToken = null", out Assem))
		{
			return Assem;
		}
		if (LoadFromAssmName(text + ", Version = 0.0.0.0, Culture = neutral, PublicKeyToken = null", out Assem))
		{
			return Assem;
		}
		return Assembly.LoadFrom(assemblyPath);
	}

	public static Assembly LoadFrom(string assemblyPath)
	{
		if (!initialized)
		{
			return LoadFromInternal(assemblyPath);
		}
		if (AssemblyContext.IsCoreCLR && !Reference.IsInvalid)
		{
			if (File.Exists(assemblyPath))
			{
				assemblyPath = Path.GetFullPath(assemblyPath);
				string key = StringParseHelper.SafeToLower(assemblyPath);
				if (assemblyPathsReverse.TryGetValue(key, out var value))
				{
					return value;
				}
				FileStream fileStream = File.OpenRead(assemblyPath);
				FileStream fileStream2 = null;
				try
				{
					string path = Path.ChangeExtension(assemblyPath, ".pdb");
					if (File.Exists(path))
					{
						fileStream2 = File.OpenRead(path);
					}
					Assembly assembly = Reference.LoadFromStream(fileStream, fileStream2);
					assemblyPaths[assembly] = assemblyPath;
					assemblyPathsReverse[key] = assembly;
					return assembly;
				}
				finally
				{
					fileStream.Close();
					fileStream2?.Close();
				}
			}
			return null;
		}
		return Reference.LoadFrom(assemblyPath);
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (CurrentAssemblyContext.AssemblyResolve != null)
		{
			return CurrentAssemblyContext.AssemblyResolve(sender, args);
		}
		return null;
	}

	private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
	{
		if ((!AssemblyContext.IsCoreCLR || !args.LoadedAssembly.FullName.Contains("B1UI_GSE.Script")) && CurrentAssemblyContext.AssemblyLoad != null)
		{
			CurrentAssemblyContext.AssemblyLoad(sender, args);
		}
	}

	private static void OnUnloading(KeyValuePair<long, long> contextRefPair)
	{
		AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyResolve;
		AppDomain.CurrentDomain.AssemblyLoad -= CurrentDomain_AssemblyLoad;
	}

	private static Assembly OnResolving(KeyValuePair<long, long> contextRefPair, AssemblyName assemblyName)
	{
		if (CurrentAssemblyContext.Resolving != null)
		{
			return CurrentAssemblyContext.Resolving(assemblyName);
		}
		return null;
	}
}
