using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UClass(Flags = (ClassFlags)272629888uL)]
[UMetaPath("/Script/CoreUObject.Class")]
public class UClass : UStruct
{
	internal class VTableOriginalFunc
	{
		public IntPtr FuncAddress;

		public Delegate Func;

		public VTableOriginalFunc(IntPtr address)
		{
			FuncAddress = address;
			Func = null;
		}
	}

	private struct UClassRef
	{
		public UClass Class;

		public IntPtr Address;

		public static implicit operator UClassRef(UClass unrealClass)
		{
			return new UClassRef
			{
				Class = unrealClass,
				Address = unrealClass.Address
			};
		}
	}

	public delegate void ClassConstructorType(IntPtr objectInitializer);

	public delegate IntPtr ClassVTableHelperCtorCallerType(IntPtr vtableHelper);

	public delegate void ClassAddReferencedObjectsType(IntPtr inThis, IntPtr referenceCollector);

	private delegate void Del_OnModulesChanged(FName moduleName, EModuleChangeReason reason);

	private delegate void Del_ProcessLoadedObjects(FName package, csbool canProcessNewlyLoadedObjects);

	internal Dictionary<int, IntPtr> VTableOriginalFunctions;

	private static Dictionary<Type, UClassRef> classes = new Dictionary<Type, UClassRef>();

	private static Dictionary<IntPtr, Type> classesByAddress = new Dictionary<IntPtr, Type>();

	private static HashSet<Type> seenClasses = new HashSet<Type>();

	private static int lastModuleCount = -1;

	private static bool loaded = false;

	private CachedUObject<UClass> classWithin;

	private CachedUObject<UClass> classGeneratedBy;

	private CachedUObject<UObject> classDefaultObject;

	public EClassFlags ClassFlags
	{
		get
		{
			return Native_UClass.Get_ClassFlags(base.Address);
		}
		set
		{
			Native_UClass.Set_ClassFlags(base.Address, value);
		}
	}

	public EClassCastFlags ClassCastFlags
	{
		get
		{
			return Native_UClass.Get_ClassCastFlags(base.Address);
		}
		set
		{
			Native_UClass.Set_ClassCastFlags(base.Address, value);
		}
	}

	public int ClassUnique
	{
		get
		{
			return Native_UClass.Get_ClassUnique(base.Address);
		}
		set
		{
			Native_UClass.Set_ClassUnique(base.Address, value);
		}
	}

	public UClass ClassWithin
	{
		get
		{
			return classWithin.Update(Native_UClass.Get_ClassWithin(base.Address));
		}
		set
		{
			Native_UClass.Set_ClassWithin(base.Address, classWithin.Set(value));
		}
	}

	public UClass ClassGeneratedBy
	{
		get
		{
			return classGeneratedBy.Update(Native_UClass.Get_ClassGeneratedBy(base.Address));
		}
		set
		{
			Native_UClass.Set_ClassGeneratedBy(base.Address, classGeneratedBy.Set(value));
		}
	}

	public FName ClassConfigName
	{
		get
		{
			Native_UClass.Get_ClassConfigName(base.Address, out var result);
			return result;
		}
		set
		{
			Native_UClass.Set_ClassConfigName(base.Address, ref value);
		}
	}

	public UField[] NetFields
	{
		get
		{
			IntPtr intPtr = Native_UClass.Get_NetFields(base.Address);
			if (intPtr != IntPtr.Zero)
			{
				return new TArrayUnsafeRef<UField>(intPtr).ToArray();
			}
			return null;
		}
		set
		{
			using TArrayUnsafe<UField> tArrayUnsafe = new TArrayUnsafe<UField>();
			tArrayUnsafe.AddRange(value);
			Native_UClass.Set_NetFields(base.Address, tArrayUnsafe.Address);
		}
	}

	public UObject ClassDefaultObject
	{
		get
		{
			return classDefaultObject.Update(Native_UClass.Get_ClassDefaultObject(base.Address));
		}
		set
		{
			Native_UClass.Set_ClassDefaultObject(base.Address, classDefaultObject.Set(value));
		}
	}

	public bool Cooked
	{
		get
		{
			return Native_UClass.Get_bCooked(base.Address);
		}
		set
		{
			Native_UClass.Set_bCooked(base.Address, value);
		}
	}

	public FImplementedInterface[] Interfaces
	{
		get
		{
			using TArrayUnsafe<FImplementedInterface> tArrayUnsafe = new TArrayUnsafe<FImplementedInterface>();
			Native_UClass.Get_Interfaces(base.Address, tArrayUnsafe.Address);
			return tArrayUnsafe.ToArray();
		}
		set
		{
			using TArrayUnsafe<FImplementedInterface> tArrayUnsafe = new TArrayUnsafe<FImplementedInterface>();
			tArrayUnsafe.AddRange(value);
			Native_UClass.Set_Interfaces(base.Address, tArrayUnsafe.Address);
		}
	}

	public FNativeFunctionLookup[] NativeFunctionLookupTable
	{
		get
		{
			IntPtr intPtr = Native_UClass.Get_NativeFunctionLookupTable(base.Address);
			if (intPtr != IntPtr.Zero)
			{
				return new TArrayUnsafeRef<FNativeFunctionLookup>(intPtr).ToArray();
			}
			return null;
		}
		set
		{
			using TArrayUnsafe<FNativeFunctionLookup> tArrayUnsafe = new TArrayUnsafe<FNativeFunctionLookup>();
			tArrayUnsafe.AddRange(value);
			Native_UClass.Set_NativeFunctionLookupTable(base.Address, tArrayUnsafe.Address);
		}
	}

	internal static void Load()
	{
		bool num = !loaded;
		if (num)
		{
			loaded = true;
			FModuleManager.ModulesChanged.Bind(OnModulesChanged);
			FModuleManager.ProcessLoadedObjects.Bind(ProcessLoadedObjects);
		}
		classes.Clear();
		classesByAddress.Clear();
		seenClasses.Clear();
		LoadNative(num);
	}

	[MonoPInvokeCallback(typeof(Del_OnModulesChanged))]
	private static void OnModulesChanged(FName moduleName, EModuleChangeReason reason)
	{
		try
		{
			lastModuleCount = FModuleManager.Get().GetModuleCount();
			if (reason == EModuleChangeReason.ModuleUnloaded)
			{
				LoadNative(firstLoad: false);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_ProcessLoadedObjects))]
	private static void ProcessLoadedObjects(FName package, csbool canProcessNewlyLoadedObjects)
	{
		try
		{
			lastModuleCount = FModuleManager.Get().GetModuleCount();
			LoadNative(firstLoad: false);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	private static int LoadNative(bool firstLoad)
	{
		int count = classesByAddress.Count;
		foreach (KeyValuePair<Type, UMetaPathAttribute> item in UnrealTypes.Native)
		{
			Type key = item.Key;
			UMetaPathAttribute value = item.Value;
			if (!key.IsSameOrSubclassOf(typeof(UObject)) && !key.IsInterface)
			{
				continue;
			}
			IntPtr classAddress = GetClassAddress(value.Path);
			UClassRef value2;
			if (classAddress != IntPtr.Zero)
			{
				classesByAddress[classAddress] = key;
				if (!firstLoad)
				{
					seenClasses.Remove(key);
				}
			}
			else if (!firstLoad && classes.TryGetValue(key, out value2))
			{
				classesByAddress.Remove(value2.Address);
				classes.Remove(key);
			}
		}
		if (firstLoad)
		{
			GCHelper.Available = true;
		}
		int num = 0;
		foreach (KeyValuePair<IntPtr, Type> item2 in classesByAddress)
		{
			IntPtr key2 = item2.Key;
			Type value3 = item2.Value;
			UClass uClass = GCHelper.Find<UClass>(key2);
			if (uClass != null)
			{
				classes[value3] = uClass;
			}
			else
			{
				num++;
			}
		}
		if (num > 0)
		{
			foreach (KeyValuePair<IntPtr, Type> item3 in new Dictionary<IntPtr, Type>(classesByAddress))
			{
				if (!classes.ContainsKey(item3.Value))
				{
					classesByAddress.Remove(item3.Key);
				}
			}
		}
		return classesByAddress.Count - count;
	}

	internal static void Load(Assembly assembly)
	{
		if (!UnrealTypes.AssembliesNativeTypes.TryGetValue(assembly, out var value))
		{
			return;
		}
		Dictionary<IntPtr, Type> dictionary = new Dictionary<IntPtr, Type>();
		foreach (KeyValuePair<Type, UMetaPathAttribute> item in value)
		{
			Type key = item.Key;
			UMetaPathAttribute value2 = item.Value;
			if (key.IsSameOrSubclassOf(typeof(UObject)) || key.IsInterface)
			{
				IntPtr classAddress = GetClassAddress(value2.Path);
				if (classAddress != IntPtr.Zero)
				{
					classesByAddress[classAddress] = key;
					dictionary[classAddress] = key;
					seenClasses.Remove(key);
				}
			}
		}
		int num = 0;
		foreach (KeyValuePair<IntPtr, Type> item2 in dictionary)
		{
			IntPtr key2 = item2.Key;
			Type value3 = item2.Value;
			UClass uClass = GCHelper.Find<UClass>(key2);
			if (uClass != null)
			{
				classes[value3] = uClass;
			}
			else
			{
				num++;
			}
		}
		if (num <= 0)
		{
			return;
		}
		foreach (KeyValuePair<IntPtr, Type> item3 in new Dictionary<IntPtr, Type>(classesByAddress))
		{
			if (!classes.ContainsKey(item3.Value))
			{
				classesByAddress.Remove(item3.Key);
			}
		}
	}

	internal static void RegisterManagedClass(IntPtr classAddress, Type type)
	{
		if (classes.TryGetValue(type, out var value))
		{
			classes.Remove(type);
			classesByAddress.Remove(value.Address);
		}
		seenClasses.Remove(type);
		classesByAddress[classAddress] = type;
		UClass uClass = GCHelper.Find<UClass>(classAddress);
		if (uClass != null)
		{
			classes[type] = uClass;
		}
		else
		{
			classesByAddress.Remove(classAddress);
		}
		if (type.IsInterface)
		{
			UnrealInterfacePool.LoadType(type);
		}
	}

	public static IntPtr GetInterfaceClassAddress(string path)
	{
		IntPtr classAddress = GetClassAddress(path);
		if (classAddress != IntPtr.Zero && (bool)Native_UClass.HasAnyClassFlags(classAddress, EClassFlags.Interface))
		{
			return classAddress;
		}
		return IntPtr.Zero;
	}

	public static IntPtr GetInterfaceClassAddress<T>() where T : IInterface
	{
		return GetInterfaceClassAddress(typeof(T));
	}

	public static IntPtr GetInterfaceClassAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetInterfaceAddress(type);
			}
			UClass uClass = GetClass(type);
			if (uClass != null && uClass.HasAnyClassFlags(EClassFlags.Interface))
			{
				return uClass.Address;
			}
		}
		return IntPtr.Zero;
	}

	public static UClass GetInterfaceClass<T>() where T : IInterface
	{
		return GetInterfaceClass(typeof(T));
	}

	public static UClass GetInterfaceClass(Type type)
	{
		UClass uClass = GetClass(type);
		if (uClass != null && uClass.HasAnyClassFlags(EClassFlags.Interface))
		{
			return uClass;
		}
		return null;
	}

	public static IntPtr LoadClassAddress(string path)
	{
		return NativeReflection.LoadObject(Classes.UClass, IntPtr.Zero, path);
	}

	public static IntPtr ResolveClassAddress(string path)
	{
		IntPtr intPtr = GetClassAddress(path);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadClassAddress(path);
		}
		return intPtr;
	}

	public static IntPtr GetClassAddress<T>() where T : UObject
	{
		return GetClassAddress(typeof(T));
	}

	public static IntPtr GetClassAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetClassAddress(type);
			}
			UClass uClass = GetClass(type);
			if (uClass != null)
			{
				return uClass.Address;
			}
		}
		return IntPtr.Zero;
	}

	public static IntPtr GetClassAddress(string path)
	{
		IntPtr intPtr = NativeReflection.FindObject(Classes.UClass, IntPtr.Zero, path);
		if (intPtr == IntPtr.Zero)
		{
			FName fName = FLinkerLoad.FindNewNameForClass(new FName(path), isInstance: false);
			if (fName != FName.None)
			{
				intPtr = NativeReflection.FindObject(Classes.UClass, IntPtr.Zero, fName.ToString());
			}
		}
		return intPtr;
	}

	public static UClass GetClass<T>()
	{
		return GetClass(typeof(T));
	}

	public static UClass GetClass(Type type)
	{
		if (classes.TryGetValue(type, out var value))
		{
			return value.Class;
		}
		if (type.IsEnum || type.IsValueType || typeof(IDelegateBase).IsAssignableFrom(type))
		{
			IntPtr zero = IntPtr.Zero;
			zero = (type.IsEnum ? UEnum.GetEnumAddress(type) : ((!type.IsValueType) ? UFunction.GetDelegateSignatureAddress(type) : UScriptStruct.GetStructAddress(type)));
			if (zero != IntPtr.Zero)
			{
				return GetClass(zero);
			}
			return null;
		}
		if ((!type.IsSameOrSubclassOf(typeof(UObject)) && (!type.IsInterface || !typeof(IInterface).IsAssignableFrom(type))) || type == typeof(IInterface))
		{
			return null;
		}
		if (!seenClasses.Contains(type))
		{
			seenClasses.Add(type);
			if (UnrealTypes.Native.TryGetValue(type, out var value2))
			{
				IntPtr intPtr = GetClassAddress(value2.Path);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = NativeReflection.LoadObject(Classes.UClass, IntPtr.Zero, value2.Path);
				}
				if (intPtr != IntPtr.Zero)
				{
					UClass uClass = GCHelper.Find<UClass>(intPtr);
					if (uClass != null)
					{
						classesByAddress[intPtr] = type;
						classes[type] = uClass;
						return uClass;
					}
				}
			}
		}
		return null;
	}

	public static UClass GetClass(IntPtr objectAddress)
	{
		if (objectAddress == IntPtr.Zero)
		{
			return null;
		}
		return GCHelper.Find<UClass>(Native_UObjectBase.GetClass(objectAddress));
	}

	public static UClass GetClass(string path)
	{
		UClass uClass = UObject.FindObject<UClass>(UObject.AnyPackage, path);
		if (uClass == null)
		{
			FName fName = FLinkerLoad.FindNewNameForClass(new FName(path), isInstance: false);
			if (fName != FName.None)
			{
				uClass = UObject.FindObject<UClass>(UObject.AnyPackage, fName.ToString());
			}
		}
		return uClass;
	}

	public static Type GetType(UClass unrealClass)
	{
		classesByAddress.TryGetValue(unrealClass.Address, out var value);
		return value;
	}

	public static Type GetTypeFromClassAddress(IntPtr unrealClass)
	{
		classesByAddress.TryGetValue(unrealClass, out var value);
		return value;
	}

	public static Type GetFirstKnownType(UClass unrealClass, bool includeAbstract = true)
	{
		Type value = null;
		IntPtr intPtr = unrealClass.Address;
		while (value == null && intPtr != IntPtr.Zero)
		{
			classesByAddress.TryGetValue(intPtr, out value);
			if (value != null && !includeAbstract && value.IsAbstract)
			{
				value = null;
			}
			intPtr = Native_UStruct.GetSuperStruct(intPtr);
		}
		return value;
	}

	public static Type GetType(IntPtr objectAddress)
	{
		if (objectAddress == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr = Native_UObjectBase.GetClass(objectAddress);
		if (intPtr == Classes.UClass)
		{
			Type value = null;
			if (classesByAddress.TryGetValue(objectAddress, out value) && value.IsSubclassOf(typeof(UClass)))
			{
				return value;
			}
			return typeof(UClass);
		}
		if (intPtr != IntPtr.Zero)
		{
			Type value2 = null;
			classesByAddress.TryGetValue(intPtr, out value2);
			return value2;
		}
		return null;
	}

	public static Type GetFirstKnownType(IntPtr objectAddress, out bool isKnownType, bool includeAbstract = true)
	{
		isKnownType = true;
		if (objectAddress == IntPtr.Zero)
		{
			return null;
		}
		Type type = GetType(objectAddress);
		if (type != null && (!type.IsAbstract || includeAbstract))
		{
			return type;
		}
		type = null;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = Native_UObjectBase.GetClass(objectAddress);
		if (intPtr2 == Classes.UClass)
		{
			intPtr2 = objectAddress;
		}
		if (intPtr2 != IntPtr.Zero)
		{
			intPtr = Native_UStruct.GetSuperStruct(intPtr2);
		}
		while (type == null && intPtr != IntPtr.Zero)
		{
			isKnownType = false;
			classesByAddress.TryGetValue(intPtr, out type);
			if (type != null && type.IsAbstract && !includeAbstract)
			{
				type = null;
			}
			intPtr = Native_UStruct.GetSuperStruct(intPtr);
		}
		if (type == null && intPtr2 != IntPtr.Zero)
		{
			if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UStruct))
			{
				if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UClass))
				{
					if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UBlueprintGeneratedClass))
					{
						return typeof(UBlueprintGeneratedClass);
					}
					return typeof(UClass);
				}
				if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UScriptStruct))
				{
					if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UUserDefinedStruct))
					{
						return typeof(UUserDefinedStruct);
					}
					return typeof(UScriptStruct);
				}
				if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UEnum))
				{
					if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UUserDefinedEnum))
					{
						return typeof(UUserDefinedEnum);
					}
					return typeof(UEnum);
				}
				if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UFunction))
				{
					return typeof(UFunction);
				}
				return typeof(UStruct);
			}
			if ((bool)Native_UStruct.IsChildOf(intPtr2, Classes.UObject))
			{
				return typeof(UObject);
			}
		}
		return type;
	}

	public bool IsFunctionHidden(string inFunction)
	{
		if (Native_UClass.IsFunctionHidden == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inFunction);
		return Native_UClass.IsFunctionHidden(base.Address, ref fStringUnsafe.Array);
	}

	public bool IsAutoExpandCategory(string inCategory)
	{
		if (Native_UClass.IsAutoExpandCategory == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inCategory);
		return Native_UClass.IsAutoExpandCategory(base.Address, ref fStringUnsafe.Array);
	}

	public bool IsAutoCollapseCategory(string inCategory)
	{
		if (Native_UClass.IsAutoCollapseCategory == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inCategory);
		return Native_UClass.IsAutoCollapseCategory(base.Address, ref fStringUnsafe.Array);
	}

	public bool IsClassGroupName(string inGroupName)
	{
		if (Native_UClass.IsClassGroupName == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inGroupName);
		return Native_UClass.IsClassGroupName(base.Address, ref fStringUnsafe.Array);
	}

	public void PrependStreamWithSuperClass(UClass superClass)
	{
		Native_UClass.PrependStreamWithSuperClass(base.Address, (superClass == null) ? IntPtr.Zero : superClass.Address);
	}

	public bool ReplaceNativeFunction(FName inName, IntPtr inPointer, bool addToFunctionRemapTable)
	{
		if (Native_UClass.ReplaceNativeFunction == null)
		{
			return false;
		}
		return Native_UClass.ReplaceNativeFunction(base.Address, ref inName, inPointer, addToFunctionRemapTable);
	}

	public UClass GetAuthoritativeClass()
	{
		return GCHelper.Find<UClass>(Native_UClass.GetAuthoritativeClass(base.Address));
	}

	public void AddNativeFunction(string name, IntPtr pointer)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		Native_UClass.AddNativeFunction(base.Address, ref fStringUnsafe.Array, pointer);
	}

	public void AddFunctionToFunctionMap(UFunction function, FName funcName)
	{
		Native_UClass.AddFunctionToFunctionMap(base.Address, (function == null) ? IntPtr.Zero : function.Address, ref funcName);
	}

	public UFunction FindFunctionByName(FName name, bool includeSuper = true)
	{
		return GCHelper.Find<UFunction>(Native_UClass.FindFunctionByName(base.Address, ref name, includeSuper));
	}

	public string GetConfigName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UClass.GetConfigName(base.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public UClass GetSuperClass()
	{
		return GCHelper.Find<UClass>(Native_UClass.GetSuperClass(base.Address));
	}

	public int GetDefaultsCount()
	{
		return Native_UClass.GetDefaultsCount(base.Address);
	}

	public UObject GetDefaultObject(bool createIfNeeded = true)
	{
		return GCHelper.Find<UObject>(Native_UClass.GetDefaultObject(base.Address, createIfNeeded));
	}

	public FName GetDefaultObjectName()
	{
		Native_UClass.GetDefaultObjectName(base.Address, out var result);
		return result;
	}

	public UObject GetDefaultSubobjectByName(FName toFind)
	{
		return GCHelper.Find<UObject>(Native_UClass.GetDefaultSubobjectByName(base.Address, ref toFind));
	}

	public void AddDefaultSubobject(UObject newSubobject, UClass baseClass)
	{
		Native_UClass.AddDefaultSubobject(base.Address, (newSubobject == null) ? IntPtr.Zero : newSubobject.Address, (baseClass == null) ? IntPtr.Zero : baseClass.Address);
	}

	public void GetDefaultObjectSubobjects(out UObject[] outDefaultSubobjects)
	{
		using TArrayUnsafe<UObject> tArrayUnsafe = new TArrayUnsafe<UObject>();
		Native_UClass.GetDefaultObjectSubobjects(base.Address, tArrayUnsafe.Address);
		outDefaultSubobjects = tArrayUnsafe.ToArray();
	}

	public bool HasAnyClassFlags(EClassFlags flagsToCheck)
	{
		return Native_UClass.HasAnyClassFlags(base.Address, flagsToCheck);
	}

	public bool HasAllClassFlags(EClassFlags flagsToCheck)
	{
		return Native_UClass.HasAllClassFlags(base.Address, flagsToCheck);
	}

	public EClassFlags GetClassFlags()
	{
		return Native_UClass.GetClassFlags(base.Address);
	}

	public bool HasAnyCastFlag(EClassCastFlags flagToCheck)
	{
		return Native_UClass.HasAnyCastFlag(base.Address, flagToCheck);
	}

	public bool HasAllCastFlags(EClassCastFlags flagToCheck)
	{
		return Native_UClass.HasAllCastFlags(base.Address, flagToCheck);
	}

	public string GetDescription()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UClass.GetDescription(base.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void AssembleReferenceTokenStream(bool force = false)
	{
		Native_UClass.AssembleReferenceTokenStream(base.Address, force);
	}

	public bool ImplementsInterface<T>() where T : IInterface
	{
		return ImplementsInterface(typeof(T));
	}

	public bool ImplementsInterface(Type type)
	{
		return ImplementsInterface(GetInterfaceClass(type));
	}

	public bool ImplementsInterface(UClass someInterface)
	{
		if (someInterface != null && someInterface.HasAnyClassFlags(EClassFlags.Interface))
		{
			return Native_UClass.ImplementsInterface(base.Address, someInterface.Address);
		}
		return false;
	}

	public void PurgeClass(bool recompilingOnLoad)
	{
		Native_UClass.PurgeClass(base.Address, recompilingOnLoad);
	}

	public static UClass FindCommonBase(UClass inClassA, UClass inClassB)
	{
		return GCHelper.Find<UClass>(Native_UClass.FindCommonBase((inClassA == null) ? IntPtr.Zero : inClassA.Address, (inClassB == null) ? IntPtr.Zero : inClassB.Address));
	}

	public static UClass FindCommonBase(UClass[] inClasses)
	{
		using TArrayUnsafe<UClass> tArrayUnsafe = new TArrayUnsafe<UClass>();
		tArrayUnsafe.AddRange(inClasses);
		return GCHelper.Find<UClass>(Native_UClass.FindCommonBaseMany(tArrayUnsafe.Address));
	}

	public bool IsFunctionImplementedInScript(FName inFunctionName)
	{
		return Native_UClass.IsFunctionImplementedInScript(base.Address, ref inFunctionName);
	}

	public bool HasProperty(FProperty inProperty)
	{
		return Native_UClass.HasProperty(base.Address, (inProperty == null) ? IntPtr.Zero : inProperty.Address);
	}

	public UObject FindArchetype(UObject archetypeClass, FName archetypeName)
	{
		return GCHelper.Find<UObject>(Native_UClass.FindArchetype(base.Address, (archetypeClass == null) ? IntPtr.Zero : archetypeClass.Address, ref archetypeName));
	}

	public UObject GetArchetypeForCDO()
	{
		return GCHelper.Find<UObject>(Native_UClass.GetArchetypeForCDO(base.Address));
	}

	public UObject[] GetRequiredPreloadDependencies()
	{
		using TArrayUnsafe<UObject> tArrayUnsafe = new TArrayUnsafe<UObject>();
		Native_UClass.GetDefaultObjectPreloadDependencies(base.Address, tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public void SetUpRuntimeReplicationData()
	{
		Native_UClass.SetUpRuntimeReplicationData(base.Address);
	}

	public static bool IsSafeToSerializeToStructuredArchives(UClass unrealClass)
	{
		return Native_UClass.IsSafeToSerializeToStructuredArchives(unrealClass.Address);
	}
}
