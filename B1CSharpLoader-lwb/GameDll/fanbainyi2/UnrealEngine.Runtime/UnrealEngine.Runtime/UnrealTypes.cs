using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnrealEngine.Runtime;

public static class UnrealTypes
{
	private static HashSet<Type> cctorCalled;

	public static bool LazyLoadingEnabled;

	private static bool gatheredUnrealTypes;

	private static HashSet<Assembly> processedAssemblies;

	public static Dictionary<Assembly, List<Type>> Assemblies { get; private set; }

	public static Dictionary<Assembly, Dictionary<Type, USharpPathAttribute>> AssembliesManagedTypes { get; private set; }

	public static Dictionary<Assembly, Dictionary<Type, UMetaPathAttribute>> AssembliesNativeTypes { get; private set; }

	public static Dictionary<Assembly, Type> AssemblySerializedModuleInfo { get; private set; }

	public static Dictionary<Type, UUnrealTypePathAttribute> All { get; private set; }

	public static Dictionary<Type, USharpPathAttribute> Managed { get; private set; }

	public static Dictionary<Type, UMetaPathAttribute> Native { get; private set; }

	public static Dictionary<string, Type> AllByPath { get; private set; }

	public static Dictionary<string, Type> ManagedByPath { get; private set; }

	public static Dictionary<string, Type> NativeByPath { get; private set; }

	public static string GameAssemblyPath { get; internal set; }

	public static string GameAssemblyDirectory { get; internal set; }

	static UnrealTypes()
	{
		cctorCalled = new HashSet<Type>();
		LazyLoadingEnabled = true;
		gatheredUnrealTypes = false;
		processedAssemblies = new HashSet<Assembly>();
		Assemblies = new Dictionary<Assembly, List<Type>>();
		AssembliesManagedTypes = new Dictionary<Assembly, Dictionary<Type, USharpPathAttribute>>();
		AssembliesNativeTypes = new Dictionary<Assembly, Dictionary<Type, UMetaPathAttribute>>();
		AssemblySerializedModuleInfo = new Dictionary<Assembly, Type>();
		All = new Dictionary<Type, UUnrealTypePathAttribute>();
		Managed = new Dictionary<Type, USharpPathAttribute>();
		Native = new Dictionary<Type, UMetaPathAttribute>();
		AllByPath = new Dictionary<string, Type>();
		ManagedByPath = new Dictionary<string, Type>();
		NativeByPath = new Dictionary<string, Type>();
	}

	public static void Clear()
	{
		gatheredUnrealTypes = false;
		Assemblies.Clear();
		AssembliesManagedTypes.Clear();
		AssembliesNativeTypes.Clear();
		AssemblySerializedModuleInfo.Clear();
		processedAssemblies.Clear();
		All.Clear();
		Managed.Clear();
		Native.Clear();
		AllByPath.Clear();
		ManagedByPath.Clear();
		NativeByPath.Clear();
	}

	public static void Load()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Assembly[] assemblies = CurrentAssemblyContext.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			LoadInternal(executingAssembly, assembly);
		}
		gatheredUnrealTypes = true;
	}

	public static void Load(Assembly assembly)
	{
		LoadInternal(Assembly.GetExecutingAssembly(), assembly);
	}

	private static void LoadInternal(Assembly thisAssembly, Assembly assembly)
	{
		if (processedAssemblies.Contains(assembly))
		{
			return;
		}
		processedAssemblies.Add(assembly);
		bool flag = false;
		if (assembly == thisAssembly)
		{
			flag = true;
		}
		else
		{
			AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
			for (int i = 0; i < referencedAssemblies.Length; i++)
			{
				if (referencedAssemblies[i].FullName == thisAssembly.FullName)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		List<Type> list = new List<Type>();
		Dictionary<Type, UMetaPathAttribute> dictionary = new Dictionary<Type, UMetaPathAttribute>();
		Dictionary<Type, USharpPathAttribute> dictionary2 = new Dictionary<Type, USharpPathAttribute>();
		Type type = null;
		Type[] types = assembly.GetTypes();
		foreach (Type type2 in types)
		{
			UUnrealTypePathAttribute customAttribute = type2.GetCustomAttribute<UUnrealTypePathAttribute>(inherit: false);
			if (customAttribute != null && !string.IsNullOrEmpty(customAttribute.Path))
			{
				if (customAttribute is USharpPathAttribute value)
				{
					AllByPath[customAttribute.Path] = type2;
					ManagedByPath[customAttribute.Path] = type2;
					All[type2] = value;
					Managed[type2] = value;
					list.Add(type2);
					dictionary2[type2] = value;
				}
				else if (customAttribute is UMetaPathAttribute value2)
				{
					AllByPath[customAttribute.Path] = type2;
					NativeByPath[customAttribute.Path] = type2;
					All[type2] = value2;
					Native[type2] = value2;
					list.Add(type2);
					dictionary[type2] = value2;
				}
			}
			if (typeof(ISerializedManagedUnrealModuleInfo).IsAssignableFrom(type2) && type2 != typeof(ISerializedManagedUnrealModuleInfo))
			{
				type = type2;
			}
		}
		if (list.Count > 0)
		{
			if (type == null)
			{
				SharedRuntimeState.GetInitializedRuntimes();
				_ = 8;
			}
			Assemblies[assembly] = list;
			AssembliesManagedTypes[assembly] = dictionary2;
			AssembliesNativeTypes[assembly] = dictionary;
			if (type != null)
			{
				AssemblySerializedModuleInfo[assembly] = type;
			}
		}
	}

	public static bool IsUnrealType(Type type)
	{
		return All.ContainsKey(type);
	}

	public static bool IsManagedUnrealType(Type type)
	{
		return Managed.ContainsKey(type);
	}

	public static bool IsNativeUnrealType(Type type)
	{
		return Native.ContainsKey(type);
	}

	public static UUnrealTypePathAttribute GetPathAttribute(Type type)
	{
		All.TryGetValue(type, out var value);
		return value;
	}

	public static UMetaPathAttribute GetNativePathAttribute(Type type)
	{
		Native.TryGetValue(type, out var value);
		return value;
	}

	public static USharpPathAttribute GetManagedPathAttribute(Type type)
	{
		Managed.TryGetValue(type, out var value);
		return value;
	}

	public static void OnCCtorCalled(Type type)
	{
		cctorCalled.Add(type);
	}

	public static bool HasCCtorBeenCalled(Type type)
	{
		return cctorCalled.Contains(type);
	}

	public static void LoadNative()
	{
		NativeReflectionCached.Clear();
		foreach (KeyValuePair<Type, UMetaPathAttribute> item in Native)
		{
			LoadNative(item.Key, item.Value);
		}
	}

	internal static void LoadNative(Assembly assembly)
	{
		NativeReflectionCached.Clear();
		if (!AssembliesNativeTypes.TryGetValue(assembly, out var value))
		{
			return;
		}
		foreach (KeyValuePair<Type, UMetaPathAttribute> item in value)
		{
			LoadNative(item.Key, item.Value);
		}
	}

	private static void LoadNative(Type type, UMetaPathAttribute pathAttribute)
	{
		UnrealInterfacePool.LoadType(type);
		if (!LazyLoadingEnabled || HasCCtorBeenCalled(type))
		{
			Type type2 = type;
			if (pathAttribute.InterfaceImpl != null)
			{
				type2 = pathAttribute.InterfaceImpl;
			}
			MethodInfo method = type2.GetMethod("LoadNativeType", BindingFlags.Static | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(null, null);
			}
		}
	}

	public static bool CanLazyLoadNativeType(Type type)
	{
		if (LazyLoadingEnabled)
		{
			return gatheredUnrealTypes;
		}
		return false;
	}

	public static bool CanLazyLoadManagedType(Type type)
	{
		if (LazyLoadingEnabled && gatheredUnrealTypes)
		{
			return ManagedUnrealTypes.IsTypeRegistered(type);
		}
		return false;
	}

	public static bool CanLazyLoadType(Type type)
	{
		if (!LazyLoadingEnabled)
		{
			return false;
		}
		if (All.TryGetValue(type, out var value))
		{
			if (value.IsManagedType)
			{
				return CanLazyLoadManagedType(type);
			}
			return CanLazyLoadNativeType(type);
		}
		return false;
	}
}
