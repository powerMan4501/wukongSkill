using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class ManagedUnrealTypes
{
	public abstract class ManagedTypeBase
	{
		public abstract EPropertyType TypeCode { get; }

		public IntPtr Package { get; set; }

		public string PackageName { get; set; }

		public string Name { get; set; }

		public string Path => PackageName + "." + Name;

		public ManagedUnrealModuleInfo ModuleInfo { get; set; }

		public ManagedUnrealTypeInfo TypeInfo { get; set; }

		public Type Type { get; set; }

		public IntPtr Address { get; set; }

		public IntPtr OldAddress { get; set; }

		public bool Changed { get; set; }

		public bool ChangedByRef { get; set; }

		public bool HasChanged
		{
			get
			{
				if (!Changed)
				{
					return ChangedByRef;
				}
				return true;
			}
		}

		public bool Linked { get; set; }
	}

	public class ManagedClass : ManagedTypeBase
	{
		public delegate void USharpClassConstructorType(IntPtr classAddr, IntPtr objectInitializer);

		private delegate void Del_InvokeFunctionStatic(IntPtr obj, IntPtr stackPtr, IntPtr result);

		private Dictionary<ManagedUnrealFunctionInfo, UFunction.FuncInvokerManaged> managedInvokersByFunctionInfo;

		private Dictionary<long, UFunction.FuncInvokerManaged> managedInvokersByAddress;

		public bool IsInterface => TypeCode == EPropertyType.Interface;

		public override EPropertyType TypeCode => EPropertyType.Object;

		public static USharpClassConstructorType USharpClassConstructor { get; private set; }

		public USharpClassConstructorType LocalUSharpClassConstructor { get; private set; }

		public static UFunction.FuncInvokerNative USharpClassFunctionInvoker { get; private set; }

		public IntPtr NativeParentClassConstructor { get; private set; }

		public IntPtr NativeParentClass { get; private set; }

		public ManagedClass()
		{
			LocalUSharpClassConstructor = Constructor2;
			USharpClassFunctionInvoker = InvokeFunctionStatic;
			USharpClassConstructor = ConstructorStatic;
		}

		public void ResolveNativeParentClass()
		{
			NativeParentClassConstructor = IntPtr.Zero;
			if (base.Address == IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = Native_UClass.GetSuperClass(base.Address);
			while (intPtr != IntPtr.Zero)
			{
				if (!Native_UObjectBaseUtility.IsA(intPtr, UnrealEngine.Runtime.Classes.USharpClass))
				{
					NativeParentClass = intPtr;
					NativeParentClassConstructor = Native_UClass.Get_ClassConstructor(intPtr);
					break;
				}
				intPtr = Native_UClass.GetSuperClass(intPtr);
			}
		}

		[MonoPInvokeCallback(typeof(Del_VoidIntPtrIntPtr))]
		internal static void ConstructorStatic(IntPtr classAddr, IntPtr objectInitializerPtr)
		{
			try
			{
				if (ClassesByAddress.TryGetValue(classAddr.ToInt64(), out var value))
				{
					value.Constructor(objectInitializerPtr);
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		private void Constructor2(IntPtr classAddr, IntPtr objectInitializerPtr)
		{
			ClassConstructor(this, objectInitializerPtr);
		}

		private void Constructor(IntPtr objectInitializerPtr)
		{
			ClassConstructor(this, objectInitializerPtr);
		}

		public void SetFallbackInvokers()
		{
			if (managedInvokersByAddress == null)
			{
				return;
			}
			foreach (long key in managedInvokersByAddress.Keys)
			{
				IntPtr function = (IntPtr)key;
				Native_USharpClass.SetFallbackFunctionInvoker(base.Address, function);
			}
		}

		public void AddInvoker(ManagedUnrealFunctionInfo functionInfo, IntPtr function)
		{
			if (managedInvokersByFunctionInfo == null)
			{
				managedInvokersByFunctionInfo = new Dictionary<ManagedUnrealFunctionInfo, UFunction.FuncInvokerManaged>();
				managedInvokersByAddress = new Dictionary<long, UFunction.FuncInvokerManaged>();
				Dictionary<string, ManagedUnrealFunctionInfo> dictionary = new Dictionary<string, ManagedUnrealFunctionInfo>();
				foreach (ManagedUnrealFunctionInfo function2 in base.TypeInfo.Functions)
				{
					dictionary[function2.Path] = function2;
				}
				BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
				MethodInfo[] methods = base.Type.GetMethods(bindingAttr);
				foreach (MethodInfo methodInfo in methods)
				{
					UFunctionInvokerAttribute customAttribute = methodInfo.GetCustomAttribute<UFunctionInvokerAttribute>(inherit: false);
					if (customAttribute != null && !string.IsNullOrEmpty(customAttribute.Path) && dictionary.TryGetValue(customAttribute.Path, out var value))
					{
						UFunction.FuncInvokerManaged value2 = (UFunction.FuncInvokerManaged)Delegate.CreateDelegate(typeof(UFunction.FuncInvokerManaged), methodInfo);
						managedInvokersByFunctionInfo[value] = value2;
					}
				}
			}
			if (managedInvokersByFunctionInfo.TryGetValue(functionInfo, out var value3))
			{
				managedInvokersByAddress.Add(function.ToInt64(), value3);
				UFunctionAddrToClasses.Add(function.ToInt64(), this);
			}
		}

		[MonoPInvokeCallback(typeof(Del_InvokeFunctionStatic))]
		[HandleProcessCorruptedStateExceptions]
		internal unsafe static void InvokeFunctionStatic(IntPtr obj, IntPtr stackPtr, IntPtr result)
		{
			try
			{
				FFrame* ptr = (FFrame*)(void*)stackPtr;
				if (UFunctionAddrToClasses.TryGetValue(ptr->CurrentNativeFunction.ToInt64(), out var value))
				{
					value.InvokeFunction(obj, stackPtr, result);
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		private void InvokeFunction(IntPtr obj, IntPtr stackPtr, IntPtr result)
		{
			try
			{
				InvokeFunctionImpl(obj, stackPtr, result);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.InvokeFunction);
			}
		}

		private unsafe void InvokeFunctionImpl(IntPtr obj, IntPtr stackPtr, IntPtr result)
		{
			FFrame* ptr = (FFrame*)(void*)stackPtr;
			if (managedInvokersByAddress.TryGetValue(ptr->CurrentNativeFunction.ToInt64(), out var value))
			{
				if (ptr->Code != IntPtr.Zero)
				{
					HandleInvokeFunctionFromBP(obj, ptr, result, value);
				}
				else
				{
					HandleInvokeFunctionFromNative(obj, ptr, result, value);
				}
			}
			else if (ptr->Code != IntPtr.Zero)
			{
				Native_UObject.SkipFunction(ptr->Object, stackPtr, result, ptr->CurrentNativeFunction);
			}
			else
			{
				HandleInvokeFunctionFromNative(obj, ptr, result, null);
			}
		}

		private unsafe void HandleInvokeFunctionFromBP(IntPtr obj, FFrame* stack, IntPtr result, UFunction.FuncInvokerManaged managedFunctionInvoker)
		{
			IntPtr currentNativeFunction = stack->CurrentNativeFunction;
			int num = Native_UFunction.Get_ParmsSize(currentNativeFunction);
			int num2 = Native_UFunction.Get_NumParms(currentNativeFunction);
			bool flag = Native_UFunction.HasAnyFunctionFlags(currentNativeFunction, EFunctionFlags.HasOutParms);
			IntPtr* ptr = stackalloc IntPtr[num2];
			IntPtr intPtr = (IntPtr)stackalloc byte[(int)(uint)num];
			FMemory.Memzero(intPtr, num);
			if (flag)
			{
				int num3 = 0;
				foreach (IntPtr item in new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, currentNativeFunction, includeSuper: false))
				{
					stack->MostRecentPropertyAddress = IntPtr.Zero;
					int num4 = Native_FProperty.GetOffset_ForUFunction(item);
					stack->Step(stack->Object, intPtr + num4);
					if (stack->MostRecentPropertyAddress != IntPtr.Zero && (bool)Native_FField.HasAnyCastFlags(item, 1048576uL))
					{
						int count = Native_FProperty.GetSize(item);
						FMemory.Memcpy(intPtr + num4, stack->MostRecentPropertyAddress, count);
					}
					ptr[num3] = stack->MostRecentPropertyAddress;
					if ((bool)Native_FProperty.HasAnyPropertyFlags(item, EPropertyFlags.ReturnParm))
					{
						ptr[num3] = result;
					}
					num3++;
				}
			}
			else
			{
				foreach (IntPtr item2 in new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, currentNativeFunction, includeSuper: false))
				{
					int num5 = Native_FProperty.GetOffset_ForUFunction(item2);
					IntPtr mostRecentPropertyAddress = stack->MostRecentPropertyAddress;
					stack->Step(stack->Object, intPtr + num5);
					if (mostRecentPropertyAddress != stack->MostRecentPropertyAddress && stack->MostRecentPropertyAddress != IntPtr.Zero && (bool)Native_FField.HasAnyCastFlags(item2, 1048576uL))
					{
						int count2 = Native_FProperty.GetSize(item2);
						FMemory.Memcpy(intPtr + num5, stack->MostRecentPropertyAddress, count2);
					}
				}
			}
			stack->PFinish();
			managedFunctionInvoker(intPtr, obj);
			int num6 = 0;
			foreach (IntPtr item3 in new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, currentNativeFunction, includeSuper: false))
			{
				EPropertyFlags ePropertyFlags = Native_FProperty.GetPropertyFlags(item3);
				if ((ePropertyFlags & EPropertyFlags.OutParm) == EPropertyFlags.OutParm && (ePropertyFlags & EPropertyFlags.ConstParm) != EPropertyFlags.ConstParm)
				{
					FMemory.Memcpy(ptr[num6], intPtr + Native_FProperty.GetOffset_ForUFunction(item3), Native_FProperty.Get_ElementSize(item3));
				}
				else
				{
					Native_FProperty.DestroyValue_InContainer(item3, intPtr);
				}
				num6++;
			}
		}

		private unsafe void HandleInvokeFunctionFromNative(IntPtr obj, FFrame* stack, IntPtr result, UFunction.FuncInvokerManaged managedFunctionInvoker)
		{
			IntPtr currentNativeFunction = stack->CurrentNativeFunction;
			IntPtr locals = stack->Locals;
			managedFunctionInvoker(locals, obj);
			if (!Native_UFunction.HasAnyFunctionFlags(currentNativeFunction, EFunctionFlags.HasOutParms))
			{
				return;
			}
			FOutParmRec* ptr = stack->OutParmsPtr;
			foreach (IntPtr item in new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, currentNativeFunction, includeSuper: false))
			{
				EPropertyFlags ePropertyFlags = Native_FProperty.GetPropertyFlags(item);
				if ((ePropertyFlags & EPropertyFlags.OutParm) == EPropertyFlags.OutParm && (ePropertyFlags & EPropertyFlags.ConstParm) != EPropertyFlags.ConstParm && (ePropertyFlags & EPropertyFlags.ReturnParm) != EPropertyFlags.ReturnParm)
				{
					if (ptr->Property != item)
					{
						FProperty fProperty = new FProperty(ptr->Property);
						FProperty fProperty2 = new FProperty(item);
						_ = "error: different props : " + fProperty.GetNameCPP() + " " + fProperty2.GetNameCPP() + " " + fProperty.GetPathName() + " " + fProperty2.GetPathName();
					}
					else
					{
						FMemory.Memcpy(ptr->PropAddr, locals + Native_FProperty.GetOffset_ForUFunction(item), Native_FProperty.Get_ElementSize(item));
					}
					ptr = ptr->NextOutParamPtr;
					if (ptr == null)
					{
						break;
					}
				}
				else if ((ePropertyFlags & EPropertyFlags.ReturnParm) == EPropertyFlags.ReturnParm)
				{
					FMemory.Memcpy(result, locals + Native_FProperty.GetOffset_ForUFunction(item), Native_FProperty.Get_ElementSize(item));
				}
			}
		}
	}

	public class ManagedInterface : ManagedClass
	{
		public override EPropertyType TypeCode => EPropertyType.Interface;
	}

	public class ManagedStruct : ManagedTypeBase
	{
		public override EPropertyType TypeCode => EPropertyType.Struct;
	}

	public class ManagedEnum : ManagedTypeBase
	{
		public override EPropertyType TypeCode => EPropertyType.Enum;
	}

	public class ManagedDelegateSignature : ManagedTypeBase
	{
		public override EPropertyType TypeCode => EPropertyType.Delegate;
	}

	private static List<ManagedClass> classesToReinstance;

	private static Dictionary<IntPtr, IntPtr> hotReloadedClasses;

	private static bool ctorsAvailable;

	private static int numChangedTypes;

	private static bool FirstTimeLoadEnum;

	private static DateTime lastInitializerException;

	private static TimeSpan initializerExceptionPopupDelay;

	private static Dictionary<string, Dictionary<FName, string>> metaDataMap;

	private static HashSet<Type> metaDataProcessedTypes;

	private static bool metaDataEnabled;

	private static HashSet<Type> registeredTypes;

	public static bool SkipReinstance { get; private set; }

	public static bool SkipBroadcastHotReload { get; private set; }

	public static Dictionary<Type, ManagedClass> Classes { get; private set; }

	public static Dictionary<long, ManagedClass> ClassesByAddress { get; private set; }

	public static Dictionary<long, ManagedClass> UFunctionAddrToClasses { get; private set; }

	public static Dictionary<Type, ManagedInterface> Interfaces { get; private set; }

	public static Dictionary<long, ManagedInterface> InterfacesByAddress { get; private set; }

	public static Dictionary<Type, ManagedStruct> Structs { get; private set; }

	public static Dictionary<long, ManagedStruct> StructsByAddress { get; private set; }

	public static Dictionary<Type, ManagedEnum> Enums { get; private set; }

	public static Dictionary<long, ManagedEnum> EnumsByAddress { get; private set; }

	public static Dictionary<Type, ManagedDelegateSignature> DelegateSignatures { get; private set; }

	public static Dictionary<long, ManagedDelegateSignature> DelegateSignaturesByAddress { get; private set; }

	public static void Load()
	{
		NativeReflectionCached.Clear();
		numChangedTypes = 0;
		SkipReinstance = false;
		SkipBroadcastHotReload = false;
		VTableHacks.Load();
		foreach (KeyValuePair<Type, USharpPathAttribute> item in UnrealTypes.Managed)
		{
			InitType(item.Key, item.Value);
		}
		BuildTypes();
	}

	public static void OnUnload()
	{
		VTableHacks.Unload();
		foreach (ManagedClass value in Classes.Values)
		{
			if (value.Address != IntPtr.Zero)
			{
				Native_USharpClass.Set_ManagedConstructor(value.Address, IntPtr.Zero);
				value.SetFallbackInvokers();
			}
		}
		ClassesByAddress.Clear();
		UFunctionAddrToClasses.Clear();
	}

	private static bool GetCachedType(string path, out string hash, out IntPtr obj)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(path);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		obj = IntPtr.Zero;
		bool result = Native_ManagedUnrealType.GetType(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref obj);
		hash = fStringUnsafe2.Value;
		return result;
	}

	private static void AddCachedType(string path, string hash, IntPtr obj)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(path);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(hash);
		Native_ManagedUnrealType.AddType(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, obj);
	}

	private static void RemoveCachedType(string path)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(path);
		Native_ManagedUnrealType.RemoveType(ref fStringUnsafe.Array);
	}

	private static void BuildEnums()
	{
		int num = 0;
		int num2 = 0;
		foreach (ManagedEnum value in Enums.Values)
		{
			if (!value.Changed)
			{
				continue;
			}
			num++;
			ManagedUnrealEnumInfo managedUnrealEnumInfo = value.TypeInfo as ManagedUnrealEnumInfo;
			IntPtr address = value.Address;
			Dictionary<FName, long> dictionary = new Dictionary<FName, long>();
			int num3 = Native_UEnum.NumEnums(address) - 1;
			for (int i = 0; i < num3; i++)
			{
				Native_UEnum.GetNameByIndex(address, i, out var result);
				dictionary[result] = Native_UEnum.GetValueByIndex(address, i);
			}
			Dictionary<FName, long> dictionary2 = new Dictionary<FName, long>();
			foreach (ManagedUnrealEnumValueInfo enumValue in managedUnrealEnumInfo.EnumValues)
			{
				using (FStringUnsafe fStringUnsafe = new FStringUnsafe(enumValue.Name))
				{
					using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
					Native_UEnum.GenerateFullEnumName(address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
					dictionary2[new FName(fStringUnsafe2.Value)] = (long)enumValue.Value;
				}
				num2++;
			}
			using (TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>())
			{
				using TArrayUnsafe<long> tArrayUnsafe2 = new TArrayUnsafe<long>();
				tArrayUnsafe.AddRange(dictionary2.Keys.ToArray());
				tArrayUnsafe2.AddRange(dictionary2.Values.ToArray());
				Native_UEnum.SetEnums(address, tArrayUnsafe.Address, tArrayUnsafe2.Address, UEnum.ECppForm.EnumClass, true);
			}
			if (!FBuild.WithEditor)
			{
				continue;
			}
			SetAllMetaData(address, bIsUObject: true, managedUnrealEnumInfo, UMeta.Target.Enum);
			if (FirstTimeLoadEnum)
			{
				continue;
			}
			using TArrayUnsafe<FName> tArrayUnsafe3 = new TArrayUnsafe<FName>();
			using TArrayUnsafe<long> tArrayUnsafe4 = new TArrayUnsafe<long>();
			tArrayUnsafe3.AddRange(dictionary.Keys.ToArray());
			tArrayUnsafe4.AddRange(dictionary.Values.ToArray());
			Native_SharpHotReloadUtils.UpdateEnum(address, tArrayUnsafe3.Address, tArrayUnsafe4.Address, true);
		}
		FirstTimeLoadEnum = false;
	}

	private static void BuildStruct(ManagedStruct managedStruct)
	{
		IntPtr address = managedStruct.Address;
		if (address == IntPtr.Zero || !managedStruct.HasChanged)
		{
			return;
		}
		EStructFlags structFlags = managedStruct.TypeInfo.StructFlags;
		Native_UScriptStruct.Set_StructFlags(address, structFlags);
		foreach (ManagedUnrealPropertyInfo item in Enumerable.Reverse(managedStruct.TypeInfo.Properties))
		{
			CreateProperty(address, managedStruct.TypeCode, item, addToOuter: true);
		}
		SetAllMetaData(address, bIsUObject: true, managedStruct.TypeInfo, UMeta.Target.Struct);
		Native_UField.Bind(address);
		Native_UStruct.StaticLink(address, true);
		managedStruct.Linked = true;
		if (managedStruct.TypeInfo.IsBlittable)
		{
			structFlags = Native_UScriptStruct.Get_StructFlags(address);
			structFlags.HasFlag(EStructFlags.IsPlainOldData);
		}
	}

	private static void BuildStructAndDependencies(ManagedStruct managedStruct, Dictionary<ManagedStruct, HashSet<ManagedStruct>> depends, HashSet<ManagedStruct> compiledStructs)
	{
		while (depends[managedStruct].Count > 0)
		{
			ManagedStruct managedStruct2 = depends[managedStruct].First();
			if (!compiledStructs.Contains(managedStruct2))
			{
				BuildStructAndDependencies(managedStruct2, depends, compiledStructs);
			}
			depends[managedStruct].Remove(managedStruct2);
		}
		BuildStruct(managedStruct);
		compiledStructs.Add(managedStruct);
	}

	private static void BuildStructs()
	{
		Dictionary<string, ManagedStruct> dictionary = new Dictionary<string, ManagedStruct>();
		foreach (ManagedStruct value2 in Structs.Values)
		{
			if (value2.HasChanged)
			{
				dictionary[value2.Path] = value2;
			}
		}
		ManagedUnrealTypeInfoReference[] array = new ManagedUnrealTypeInfoReference[3];
		Dictionary<ManagedStruct, HashSet<ManagedStruct>> dictionary2 = new Dictionary<ManagedStruct, HashSet<ManagedStruct>>();
		foreach (ManagedStruct value3 in dictionary.Values)
		{
			HashSet<ManagedStruct> hashSet = new HashSet<ManagedStruct>();
			dictionary2.Add(value3, hashSet);
			foreach (ManagedUnrealPropertyInfo property in value3.TypeInfo.Properties)
			{
				array[0] = property.Type;
				array[1] = ((property.GenericArgs.Count > 0) ? property.GenericArgs[0] : null);
				array[2] = ((property.GenericArgs.Count > 1) ? property.GenericArgs[1] : null);
				ManagedUnrealTypeInfoReference[] array2 = array;
				foreach (ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference in array2)
				{
					if (managedUnrealTypeInfoReference != null && managedUnrealTypeInfoReference.TypeCode == EPropertyType.Struct && !string.IsNullOrEmpty(managedUnrealTypeInfoReference.Path) && dictionary.TryGetValue(managedUnrealTypeInfoReference.Path, out var value))
					{
						hashSet.Add(value);
					}
				}
			}
		}
		IntPtr outBlueprintsToRecompile = IntPtr.Zero;
		IntPtr outChangedStructsBP = IntPtr.Zero;
		if (FBuild.WithEditor)
		{
			using TArrayUnsafe<IntPtr> tArrayUnsafe = new TArrayUnsafe<IntPtr>();
			foreach (ManagedStruct key in dictionary2.Keys)
			{
				if (key.OldAddress != IntPtr.Zero)
				{
					tArrayUnsafe.Add(key.OldAddress);
				}
			}
			using (HotReload.Timing.Create("SharpHotReloadUtils.PreUpdateStructs"))
			{
				Native_SharpHotReloadUtils.PreUpdateStructs(tArrayUnsafe.Address, ref outBlueprintsToRecompile, ref outChangedStructsBP);
			}
		}
		HashSet<ManagedStruct> hashSet2 = new HashSet<ManagedStruct>();
		foreach (ManagedStruct key2 in dictionary2.Keys)
		{
			if (!hashSet2.Contains(key2))
			{
				BuildStructAndDependencies(key2, dictionary2, hashSet2);
			}
		}
		if (!FBuild.WithEditor)
		{
			return;
		}
		using TArrayUnsafe<IntPtr> tArrayUnsafe2 = new TArrayUnsafe<IntPtr>();
		using TArrayUnsafe<IntPtr> tArrayUnsafe3 = new TArrayUnsafe<IntPtr>();
		foreach (ManagedStruct item in hashSet2)
		{
			if (item.OldAddress != IntPtr.Zero)
			{
				tArrayUnsafe2.Add(item.OldAddress);
				tArrayUnsafe3.Add(item.Address);
			}
		}
		using (HotReload.Timing.Create("SharpHotReloadUtils.PostUpdateStructs"))
		{
			Native_SharpHotReloadUtils.PostUpdateStructs(tArrayUnsafe2.Address, tArrayUnsafe3.Address, outBlueprintsToRecompile, outChangedStructsBP);
		}
	}

	private static void ClassConstructor(ManagedClass managedClass, IntPtr objectInitializerPtr)
	{
		IntPtr address = managedClass.Address;
		if (!(address != IntPtr.Zero))
		{
			return;
		}
		FObjectInitializer initializer = new FObjectInitializer(objectInitializerPtr);
		GCHelper.ManagedObjectBeingInitialized = initializer.ObjectAddress;
		UObject obj = initializer.GetObj();
		GCHelper.ManagedObjectBeingInitialized = IntPtr.Zero;
		IntPtr objectAddress = initializer.ObjectAddress;
		foreach (IntPtr item in new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, address))
		{
			if (Native_UObjectBase.GetClass(Native_FField.GetOwnerClass(item)) != UnrealEngine.Runtime.Classes.USharpClass)
			{
				break;
			}
			if (!Native_FProperty.HasAnyPropertyFlags(item, EPropertyFlags.ZeroConstructor))
			{
				Native_FProperty.InitializeValue_InContainer(item, objectAddress);
			}
		}
		Native_UClass.Call_ClassConstructorDirectly(managedClass.NativeParentClassConstructor, objectInitializerPtr);
		VTableHacks.HackVTable(obj);
		if (managedClass.IsInterface || !managedClass.TypeInfo.OverridesObjectInitializerHierarchical)
		{
			return;
		}
		try
		{
			obj.Initialize(initializer);
		}
		catch (Exception ex)
		{
			string text = null;
			try
			{
				text = Environment.StackTrace;
			}
			catch
			{
			}
			string message = "An exception occured in " + obj.GetType()?.ToString() + ".Initialize() There cannot be any unhandled exceptions in the initializer. " + Environment.NewLine + Environment.NewLine + "Exception:" + Environment.NewLine + Environment.NewLine + ex?.ToString() + Environment.NewLine + Environment.NewLine + "Callstack:" + Environment.NewLine + Environment.NewLine + text;
			if (lastInitializerException < DateTime.Now - initializerExceptionPopupDelay)
			{
				FMessage.OpenDialog(message);
				lastInitializerException = DateTime.Now;
			}
			FMessage.Log(ELogVerbosity.Error, message);
		}
	}

	private static void BuildInterfaces()
	{
		BuildClassesInterfaces(Interfaces);
	}

	private static void BuildClasses()
	{
		BuildClassesInterfaces(Classes);
	}

	private static void BuildClassAndBaseHierarchical<T>(ManagedClass managedClass, Dictionary<Type, T> collection, HashSet<ManagedClass> compiledClasses, Dictionary<string, ManagedClass> classesByPath) where T : ManagedClass
	{
		if (compiledClasses.Contains(managedClass))
		{
			return;
		}
		ManagedUnrealTypeInfo typeInfo = managedClass.TypeInfo;
		IntPtr address = managedClass.Address;
		if (!managedClass.IsInterface)
		{
			if (SharedRuntimeState.IsAOT)
			{
				Native_USharpClass.SetSharpClassConstructor(address, Marshal.GetFunctionPointerForDelegate(ManagedClass.USharpClassConstructor));
			}
			else
			{
				Native_USharpClass.SetSharpClassConstructor(address, Marshal.GetFunctionPointerForDelegate(managedClass.LocalUSharpClassConstructor));
			}
		}
		if (!managedClass.HasChanged)
		{
			if (managedClass.TypeInfo.IsClass && managedClass.TypeInfo.OverridesObjectInitializerHierarchical)
			{
				classesToReinstance.Add(managedClass);
			}
			return;
		}
		foreach (ManagedUnrealTypeInfoReference baseType in managedClass.TypeInfo.BaseTypes)
		{
			if (baseType.TypeCode == managedClass.TypeCode && classesByPath.TryGetValue(baseType.Path, out var value) && !compiledClasses.Contains(value))
			{
				BuildClassAndBaseHierarchical(value, collection, compiledClasses, classesByPath);
			}
		}
		bool flag = false;
		UMeta.Target target = UMeta.Target.Class;
		if (managedClass.TypeCode == EPropertyType.Interface)
		{
			flag = true;
			target = UMeta.Target.Interface;
		}
		TArrayUnsafe<FImplementedInterface> tArrayUnsafe = null;
		if (typeInfo.AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.ImplementsInterface))
		{
			tArrayUnsafe = new TArrayUnsafe<FImplementedInterface>();
		}
		IntPtr intPtr = IntPtr.Zero;
		foreach (ManagedUnrealTypeInfoReference baseType2 in typeInfo.BaseTypes)
		{
			if (baseType2.TypeCode == EPropertyType.Interface)
			{
				IntPtr classAddress = UClass.GetClassAddress(baseType2.Path);
				tArrayUnsafe.Add(new FImplementedInterface(classAddress, 0, implementedByK2: true));
			}
			else
			{
				intPtr = UClass.GetClassAddress(baseType2.Path);
			}
		}
		if (intPtr == IntPtr.Zero)
		{
			intPtr = ((!flag) ? UnrealEngine.Runtime.Classes.UObject : UnrealEngine.Runtime.Classes.UInterface);
		}
		SetClassParent(address, intPtr);
		managedClass.ResolveNativeParentClass();
		if (!flag)
		{
			Native_USharpClass.UpdateNativeParentConstructor(address);
		}
		if (tArrayUnsafe != null)
		{
			Native_UClass.Set_Interfaces(address, tArrayUnsafe.Address);
			tArrayUnsafe.Dispose();
			tArrayUnsafe = null;
		}
		EClassFlags eClassFlags = Native_UClass.GetClassFlags(intPtr) & EClassFlags.ScriptInherit;
		eClassFlags |= managedClass.TypeInfo.ClassFlags;
		eClassFlags |= EClassFlags.Native;
		Native_UClass.Set_ClassFlags(address, eClassFlags);
		foreach (ManagedUnrealFunctionInfo item in Enumerable.Reverse(managedClass.TypeInfo.Functions))
		{
			IntPtr intPtr2 = CreateFunction(address, intPtr, item, ManagedClass.USharpClassFunctionInvoker);
			if (intPtr2 != IntPtr.Zero)
			{
				managedClass.AddInvoker(item, intPtr2);
				SetAllMetaData(intPtr2, bIsUObject: true, item, UMeta.Target.Function);
			}
		}
		if (!flag)
		{
			foreach (ManagedUnrealPropertyInfo item2 in Enumerable.Reverse(managedClass.TypeInfo.Properties))
			{
				CreateProperty(address, managedClass.TypeCode, item2, addToOuter: true);
			}
		}
		SetAllMetaData(address, bIsUObject: true, managedClass.TypeInfo, target);
		Native_UField.Bind(address);
		Native_UStruct.StaticLink(address, true);
		Native_UClass.AssembleReferenceTokenStream(address, true);
		managedClass.Linked = true;
		if (managedClass.OldAddress != IntPtr.Zero)
		{
			classesToReinstance.Add(managedClass);
		}
		compiledClasses.Add(managedClass);
	}

	private static void BuildClassesInterfaces<T>(Dictionary<Type, T> collection) where T : ManagedClass
	{
		HashSet<ManagedClass> compiledClasses = new HashSet<ManagedClass>();
		Dictionary<string, ManagedClass> dictionary = new Dictionary<string, ManagedClass>();
		List<ManagedClass> list = new List<ManagedClass>();
		foreach (T value in collection.Values)
		{
			if (value.HasChanged)
			{
				dictionary[value.Path] = value;
			}
			else
			{
				list.Add(value);
			}
		}
		foreach (T value2 in collection.Values)
		{
			BuildClassAndBaseHierarchical(value2, collection, compiledClasses, dictionary);
		}
		foreach (ManagedClass item in list)
		{
			if (item.NativeParentClass == IntPtr.Zero)
			{
				item.ResolveNativeParentClass();
			}
			if (item.TypeInfo.Functions.Count <= 0)
			{
				continue;
			}
			IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate(ManagedClass.USharpClassFunctionInvoker);
			foreach (ManagedUnrealFunctionInfo function in item.TypeInfo.Functions)
			{
				using FStringUnsafe fStringUnsafe = new FStringUnsafe(function.GetName());
				IntPtr intPtr = Native_USharpClass.SetFunctionInvoker(item.Address, ref fStringUnsafe.Array, functionPointerForDelegate);
				if (intPtr != IntPtr.Zero)
				{
					item.AddInvoker(function, intPtr);
				}
			}
		}
	}

	private static void BuildDelegates()
	{
		using TArrayUnsafe<IntPtr> tArrayUnsafe = new TArrayUnsafe<IntPtr>();
		foreach (ManagedDelegateSignature value in DelegateSignatures.Values)
		{
			IntPtr address = value.Address;
			if (address == IntPtr.Zero)
			{
				continue;
			}
			if (value.HasChanged)
			{
				tArrayUnsafe.Add(address);
			}
			if (value.Changed)
			{
				if (value.Linked)
				{
					CleanAndSanitizeDelegate(value.Address);
				}
				ManagedUnrealFunctionInfo managedUnrealFunctionInfo = value.TypeInfo.Functions[0];
				EFunctionFlags functionFlags = managedUnrealFunctionInfo.Flags;
				if (managedUnrealFunctionInfo.ReturnProp != null)
				{
					CreateFunctionParam(managedUnrealFunctionInfo, address, ref functionFlags, managedUnrealFunctionInfo.ReturnProp);
				}
				foreach (ManagedUnrealPropertyInfo item in Enumerable.Reverse(managedUnrealFunctionInfo.Params))
				{
					CreateFunctionParam(managedUnrealFunctionInfo, address, ref functionFlags, item);
				}
				Native_UFunction.Set_FunctionFlags(address, functionFlags);
				SetAllMetaData(address, bIsUObject: true, value.TypeInfo, UMeta.Target.Delegate);
				Native_UField.Bind(address);
				Native_UStruct.StaticLink(address, true);
				value.Linked = true;
			}
			else if (value.ChangedByRef)
			{
				Native_UField.Bind(address);
				Native_UStruct.StaticLink(address, true);
				value.Linked = true;
			}
		}
		if (FBuild.WithEditor)
		{
			Native_SharpHotReloadUtils.UpdateDelegates(tArrayUnsafe.Address);
		}
	}

	private static void CleanAndSanitizeDelegate(IntPtr sharpFunction)
	{
		string name = "TRASHDELEGATE_" + NativeReflection.GetUFieldFName(sharpFunction).ToString();
		FName name2 = NativeReflection.MakeUniqueObjectName(NativeReflection.GetTransientPackage(), UnrealEngine.Runtime.Classes.UDelegateFunction, new FName(name));
		IntPtr newOuter = NativeReflection.NewObject(NativeReflection.GetTransientPackage(), UnrealEngine.Runtime.Classes.UDelegateFunction, name2, EObjectFlags.Public | EObjectFlags.Transient, (IntPtr)0, copyTransientsFromClassDefaults: false, (IntPtr)0);
		IntPtr[] objectsWithOuter = NativeReflection.GetObjectsWithOuter(sharpFunction, includeNestedObjects: false);
		ERenameFlags flags = ERenameFlags.DontCreateRedirectors;
		IntPtr[] array = objectsWithOuter;
		foreach (IntPtr intPtr in array)
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(NativeReflection.GetUFieldFName(intPtr).ToString());
			Native_UObject.Rename(intPtr, ref fStringUnsafe.Array, newOuter, flags);
		}
		Native_UStruct.SetSuperStruct(sharpFunction, IntPtr.Zero);
		Native_UStruct.Set_ChildProperties(sharpFunction, IntPtr.Zero);
		Native_UStruct.Set_Children(sharpFunction, IntPtr.Zero);
		new TArrayUnsafeRef<byte>(Native_UStruct.Get_Script(sharpFunction)).Clear();
		Native_UStruct.Set_MinAlignment(sharpFunction, 0);
		Native_UStruct.Set_RefLink(sharpFunction, IntPtr.Zero);
		Native_UStruct.Set_PropertyLink(sharpFunction, IntPtr.Zero);
		Native_UStruct.Set_DestructorLink(sharpFunction, IntPtr.Zero);
		new TArrayUnsafeRef<UObject>(Native_UStruct.Get_ScriptObjectReferences(sharpFunction)).Clear();
		Native_UFunction.Set_NumParms(sharpFunction, 0);
		Native_UFunction.Set_ParmsSize(sharpFunction, 0);
		Native_UFunction.Set_ReturnValueOffset(sharpFunction, ushort.MaxValue);
		Native_UFunction.Set_RPCId(sharpFunction, 0);
		Native_UFunction.Set_RPCResponseId(sharpFunction, 0);
		Native_UFunction.Set_FirstPropertyToInit(sharpFunction, IntPtr.Zero);
		Native_UFunction.Set_FunctionFlags(sharpFunction, ~EFunctionFlags.AllFlags);
		Native_UFunction.SetNativeFunc(sharpFunction, IntPtr.Zero);
	}

	private static void BuildTypes()
	{
		hotReloadedClasses.Clear();
		classesToReinstance.Clear();
		ctorsAvailable = false;
		Dictionary<Type, ManagedTypeBase> dictionary = new Dictionary<Type, ManagedTypeBase>();
		Dictionary<Type, ManagedTypeBase> changedTypes = new Dictionary<Type, ManagedTypeBase>();
		Dictionary<Type, ManagedTypeBase> unchangedTypes = new Dictionary<Type, ManagedTypeBase>();
		CollectTypes(Classes, dictionary, changedTypes, unchangedTypes);
		CollectTypes(Interfaces, dictionary, changedTypes, unchangedTypes);
		CollectTypes(Structs, dictionary, changedTypes, unchangedTypes);
		CollectTypes(Enums, dictionary, changedTypes, unchangedTypes);
		CollectTypes(DelegateSignatures, dictionary, changedTypes, unchangedTypes);
		foreach (KeyValuePair<Type, ManagedClass> @class in Classes)
		{
			ClassesByAddress.Add(@class.Value.Address.ToInt64(), @class.Value);
		}
		Dictionary<string, ManagedTypeBase> dictionary2 = new Dictionary<string, ManagedTypeBase>();
		foreach (ManagedTypeBase value in dictionary.Values)
		{
			dictionary2[value.Path] = value;
		}
		ChainChangedDependencies(dictionary2, dictionary, changedTypes, unchangedTypes);
		if ((numChangedTypes == 0 && HotReload.MinimalReload) || !FBuild.WithEditor)
		{
			SkipReinstance = true;
			SkipBroadcastHotReload = true;
		}
		foreach (ManagedTypeBase value2 in dictionary.Values)
		{
			IntPtr intPtr = IntPtr.Zero;
			if (value2.HasChanged && value2.Linked && value2.OldAddress == IntPtr.Zero && value2.Address != IntPtr.Zero)
			{
				switch (value2.TypeInfo.TypeCode)
				{
				case EPropertyType.Struct:
					intPtr = UnrealEngine.Runtime.Classes.USharpStruct;
					break;
				case EPropertyType.Interface:
					intPtr = UnrealEngine.Runtime.Classes.UClass;
					break;
				case EPropertyType.Object:
					intPtr = UnrealEngine.Runtime.Classes.USharpClass;
					break;
				}
			}
			if (intPtr != IntPtr.Zero)
			{
				IntPtr address = value2.Address;
				if (value2.TypeInfo.IsStruct)
				{
					Native_UObjectBaseUtility.ClearFlags(address, EObjectFlags.Public | EObjectFlags.Standalone);
					Native_UObjectBaseUtility.RemoveFromRoot(address);
					using (FStringUnsafe fStringUnsafe = new FStringUnsafe(NativeReflection.MakeUniqueObjectName(NativeReflection.GetTransientPackage(), Native_UObjectBase.GetClass(address), new FName("USharpHotReloaded_" + NativeReflection.GetUFieldFName(address).ToString())).ToString()))
					{
						Native_UObject.Rename(address, ref fStringUnsafe.Array, NativeReflection.GetTransientPackage(), ERenameFlags.None);
					}
					UMeta.RemoveMetaData(address, MDStruct.BlueprintType);
				}
				else
				{
					Native_UObjectBaseUtility.RemoveFromRoot(address);
					Native_UObjectBaseUtility.ClearFlags(address, EObjectFlags.Public | EObjectFlags.Standalone);
					IntPtr intPtr2 = Native_UClass.GetDefaultObject(address, false);
					if (intPtr2 != IntPtr.Zero)
					{
						Native_UObjectBaseUtility.RemoveFromRoot(intPtr2);
						Native_UObjectBaseUtility.ClearFlags(intPtr2, EObjectFlags.Public | EObjectFlags.Standalone);
					}
					using (FStringUnsafe fStringUnsafe2 = new FStringUnsafe(NativeReflection.MakeUniqueObjectName(NativeReflection.GetTransientPackage(), Native_UObjectBase.GetClass(address), new FName("USharpHotReloaded_" + NativeReflection.GetUFieldFName(address).ToString())).ToString()))
					{
						Native_UObject.Rename(address, ref fStringUnsafe2.Array, NativeReflection.GetTransientPackage(), ERenameFlags.None);
					}
					Native_UObjectBaseUtility.SetFlags(address, EObjectFlags.Transient);
					Native_UObjectBaseUtility.AddToRoot(address);
				}
				value2.OldAddress = address;
				EObjectFlags flags = EObjectFlags.Public | EObjectFlags.Standalone;
				value2.Address = NativeReflection.NewObject(value2.Package, intPtr, new FName(value2.Name), flags, (IntPtr)0, copyTransientsFromClassDefaults: false, (IntPtr)0);
				if (value2.TypeInfo.IsStruct)
				{
					Native_USharpStruct.CreateGuid(value2.Address);
				}
				else
				{
					hotReloadedClasses[address] = value2.Address;
				}
				AddCachedType(value2.TypeInfo.Path, value2.TypeInfo.Hash, value2.Address);
			}
			if (value2.Address != IntPtr.Zero && (value2.TypeInfo.IsClass || value2.TypeInfo.IsInterface))
			{
				UClass.RegisterManagedClass(value2.Address, value2.Type);
			}
		}
		if (hotReloadedClasses.Count > 0)
		{
			UpdateClassReferences(dictionary);
			hotReloadedClasses.Clear();
		}
		using (HotReload.Timing.Create("BuildTypes.BuildEnum"))
		{
			BuildEnums();
		}
		using (HotReload.Timing.Create("BuildTypes.BuildStructs"))
		{
			BuildStructs();
		}
		using (HotReload.Timing.Create("BuildTypes.BuildOthers"))
		{
			BuildInterfaces();
			BuildClasses();
			BuildDelegates();
		}
		foreach (Type key in dictionary.Keys)
		{
			OnTypeRegistered(key);
			if (UnrealTypes.LazyLoadingEnabled && !UnrealTypes.HasCCtorBeenCalled(key))
			{
				continue;
			}
			Type type = key;
			if (key.IsInterface)
			{
				USharpPathAttribute customAttribute = key.GetCustomAttribute<USharpPathAttribute>(inherit: false);
				if (customAttribute != null && customAttribute.InterfaceImpl != null)
				{
					type = customAttribute.InterfaceImpl;
				}
			}
			MethodInfo method = type.GetMethod("LoadNativeType", BindingFlags.Static | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(null, null);
			}
		}
		ctorsAvailable = true;
		foreach (ManagedClass value3 in Classes.Values)
		{
			CreateCDO(value3);
		}
		foreach (ManagedInterface value4 in Interfaces.Values)
		{
			CreateCDO(value4);
		}
		if (!SkipReinstance)
		{
			using (HotReload.Timing.Create("ManagedUnrealTypes.ReinstanceClasses"))
			{
				classesToReinstance.Sort(delegate(ManagedClass a, ManagedClass b)
				{
					int num2 = 0;
					int num3 = 0;
					Type type2 = a.Type;
					while (type2.BaseType != typeof(UObject) && type2.BaseType != null)
					{
						type2 = type2.BaseType;
						num2++;
					}
					type2 = b.Type;
					while (type2.BaseType != typeof(UObject) && type2.BaseType != null)
					{
						type2 = type2.BaseType;
						num3++;
					}
					if (num2 == num3)
					{
						return 0;
					}
					return (num2 <= num3) ? 1 : (-1);
				});
				Native_SharpHotReloadUtils.BeginGuardIsHotReload(true);
				FMessage.Log(ELogVerbosity.Log, $"Reload BuildTypes ClassesToReinstance TotalCount : {classesToReinstance.Count}");
				for (int num = 0; num < classesToReinstance.Count; num++)
				{
					ManagedClass managedClass = classesToReinstance[num];
					IntPtr zero = IntPtr.Zero;
					zero = Native_SharpHotReloadUtils.CreateClassReinstancer(managedClass.Address, (managedClass.OldAddress != IntPtr.Zero) ? managedClass.OldAddress : managedClass.Address);
					Native_SharpHotReloadUtils.ReinstanceClass(zero);
				}
				Native_SharpHotReloadUtils.EndGuardIsHotReload();
			}
			using (HotReload.Timing.Create("SharpHotReloadUtils.FinalizeClasses"))
			{
				Native_SharpHotReloadUtils.FinalizeClasses();
			}
		}
		classesToReinstance.Clear();
		foreach (ManagedTypeBase value5 in dictionary.Values)
		{
			value5.Changed = false;
			value5.ChangedByRef = false;
		}
		ClearTypeMetaData();
	}

	private static void CreateCDO(ManagedClass managedClass)
	{
		IntPtr instance = Native_UObjectBaseUtility.GetOutermost(managedClass.Address);
		bool num = Native_UPackage.HasAnyPackageFlags(instance, EPackageFlags.CompiledIn);
		if (num)
		{
			Native_UPackage.ClearPackageFlags(instance, EPackageFlags.CompiledIn);
		}
		Native_UClass.GetDefaultObject(managedClass.Address, true);
		if (num)
		{
			Native_UPackage.SetPackageFlags(instance, EPackageFlags.CompiledIn);
		}
	}

	private static void UpdateClassReferences(Dictionary<Type, ManagedTypeBase> allTypes)
	{
		foreach (ManagedTypeBase value in allTypes.Values)
		{
			if (value.Address != IntPtr.Zero)
			{
				UpdateClassReferences(value.Address);
			}
		}
	}

	private static void UpdateClassReferences(IntPtr field)
	{
		if ((bool)Native_UObjectBaseUtility.IsA(field, UnrealEngine.Runtime.Classes.UClass) || (bool)Native_UObjectBaseUtility.IsA(field, UnrealEngine.Runtime.Classes.UScriptStruct) || (bool)Native_UObjectBaseUtility.IsA(field, UnrealEngine.Runtime.Classes.UFunction))
		{
			IntPtr intPtr = Native_UStruct.Get_ChildProperties(field);
			while (intPtr != IntPtr.Zero)
			{
				UpdatePropertyReferences(intPtr);
				intPtr = Native_FField.Get_Next(intPtr);
			}
			IntPtr intPtr2 = Native_UStruct.Get_Children(field);
			while (intPtr2 != IntPtr.Zero)
			{
				UpdateClassReferences(intPtr2);
				intPtr2 = Native_UField.Get_Next(intPtr2);
			}
		}
	}

	private static void UpdatePropertyReferences(IntPtr field)
	{
		if (!Native_FField.IsA(field, UnrealEngine.Runtime.Classes.FProperty))
		{
			return;
		}
		switch (NativeReflection.GetPropertyType(field))
		{
		case EPropertyType.SoftClass:
		{
			if (hotReloadedClasses.TryGetValue(Native_FSoftClassProperty.Get_MetaClass(field), out var value4))
			{
				Native_FSoftClassProperty.Set_MetaClass(field, value4);
			}
			break;
		}
		case EPropertyType.Class:
		{
			if (hotReloadedClasses.TryGetValue(Native_FClassProperty.Get_MetaClass(field), out var value2))
			{
				Native_FClassProperty.Set_MetaClass(field, value2);
			}
			break;
		}
		case EPropertyType.Interface:
		{
			if (hotReloadedClasses.TryGetValue(Native_FInterfaceProperty.Get_InterfaceClass(field), out var value3))
			{
				Native_FInterfaceProperty.Set_InterfaceClass(field, value3);
			}
			break;
		}
		case EPropertyType.Object:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftObject:
		{
			if (hotReloadedClasses.TryGetValue(Native_FObjectPropertyBase.Get_PropertyClass(field), out var value))
			{
				Native_FObjectPropertyBase.Set_PropertyClass(field, value);
			}
			break;
		}
		case EPropertyType.Struct:
			break;
		}
	}

	private static void SetClassParent(IntPtr sharpClass, IntPtr parentClass)
	{
		IntPtr intPtr = Native_UClass.Get_ClassWithin(parentClass);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = UnrealEngine.Runtime.Classes.UObject;
		}
		FName result;
		if ((bool)Native_UObjectBaseUtility.IsNative(sharpClass))
		{
			Native_UClass.Get_ClassConfigName(sharpClass, out result);
		}
		else
		{
			Native_UClass.Get_ClassConfigName(parentClass, out result);
		}
		Native_UStruct.Set_PropertyLink(sharpClass, Native_UStruct.Get_PropertyLink(parentClass));
		Native_UStruct.SetSuperStruct(sharpClass, parentClass);
		Native_UClass.Set_ClassWithin(sharpClass, intPtr);
		Native_UClass.Set_ClassConfigName(sharpClass, ref result);
	}

	private static IntPtr CreateFunction(IntPtr outer, IntPtr parentClass, ManagedUnrealFunctionInfo functionInfo, UFunction.FuncInvokerNative funcInvoker)
	{
		EObjectFlags flags = EObjectFlags.Public | EObjectFlags.MarkAsNative | EObjectFlags.Transient;
		IntPtr intPtr = NativeReflection.NewObject(outer, UnrealEngine.Runtime.Classes.UFunction, new FName(functionInfo.GetName()), flags, (IntPtr)0, copyTransientsFromClassDefaults: false, (IntPtr)0);
		IntPtr intPtr2 = IntPtr.Zero;
		EFunctionFlags eFunctionFlags = EFunctionFlags.Native;
		eFunctionFlags |= functionInfo.Flags;
		eFunctionFlags |= EFunctionFlags.Public;
		if (!functionInfo.IsVirtual)
		{
			_ = functionInfo.IsOverride;
		}
		EFunctionFlags eFunctionFlags2 = EFunctionFlags.FuncInherit | EFunctionFlags.NetFuncFlags | EFunctionFlags.AccessSpecifiers;
		if (functionInfo.AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.InterfaceImplementation))
		{
			eFunctionFlags |= EFunctionFlags.Const;
		}
		else if (functionInfo.IsOverride)
		{
			FName inName = new FName(functionInfo.GetName());
			intPtr2 = Native_UClass.FindFunctionByName(parentClass, ref inName, true);
			if (!(intPtr2 == IntPtr.Zero))
			{
				Native_UStruct.SetSuperStruct(intPtr, intPtr2);
				EFunctionFlags eFunctionFlags3 = Native_UFunction.Get_FunctionFlags(intPtr2);
				eFunctionFlags |= eFunctionFlags3 & eFunctionFlags2;
			}
		}
		if (functionInfo.ReturnProp != null)
		{
			CreateFunctionParam(functionInfo, intPtr, ref eFunctionFlags, functionInfo.ReturnProp);
		}
		foreach (ManagedUnrealPropertyInfo item in Enumerable.Reverse(functionInfo.Params))
		{
			CreateFunctionParam(functionInfo, intPtr, ref eFunctionFlags, item);
		}
		Native_UFunction.Set_FunctionFlags(intPtr, eFunctionFlags);
		IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate(funcInvoker);
		using (FStringUnsafe fStringUnsafe = new FStringUnsafe(functionInfo.GetName()))
		{
			Native_UClass.AddNativeFunction(outer, ref fStringUnsafe.Array, functionPointerForDelegate);
		}
		FName funcName = NativeReflection.GetUFieldFName(intPtr);
		Native_UClass.AddFunctionToFunctionMap(outer, intPtr, ref funcName);
		Native_UField.Bind(intPtr);
		Native_UStruct.StaticLink(intPtr, true);
		Native_UField.Set_Next(intPtr, Native_UStruct.Get_Children(outer));
		Native_UStruct.Set_Children(outer, intPtr);
		if (functionInfo.IsOverride && intPtr2 != IntPtr.Zero)
		{
			FixupFunctionOverrideSignature(intPtr, intPtr2);
		}
		return intPtr;
	}

	private static void FixupFunctionOverrideSignature(IntPtr function, IntPtr parentFunction)
	{
		NativeReflection.NativeFFieldIterator.Enumerator enumerator = new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, function).GetEnumerator();
		NativeReflection.NativeFFieldIterator.Enumerator enumerator2 = new NativeReflection.NativeFFieldIterator(UnrealEngine.Runtime.Classes.FProperty, parentFunction).GetEnumerator();
		EPropertyFlags ePropertyFlags = EPropertyFlags.ConstParm | EPropertyFlags.ReferenceParm;
		EPropertyFlags ePropertyFlags2 = EPropertyFlags.ConstParm | EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm;
		while (enumerator.Current != IntPtr.Zero && Native_FProperty.Get_PropertyFlags(enumerator.Current).HasFlag(EPropertyFlags.Parm) && enumerator2.Current != IntPtr.Zero && Native_FProperty.Get_PropertyFlags(enumerator2.Current).HasFlag(EPropertyFlags.Parm))
		{
			IntPtr current = enumerator.Current;
			IntPtr current2 = enumerator2.Current;
			EPropertyFlags ePropertyFlags3 = Native_FProperty.Get_PropertyFlags(current2);
			if ((ePropertyFlags3 & ePropertyFlags) == ePropertyFlags)
			{
				Native_FProperty.SetPropertyFlags(current, ePropertyFlags3 & ePropertyFlags2);
			}
			enumerator.MoveNext();
			enumerator2.MoveNext();
		}
	}

	private static IntPtr CreateFunctionParam(ManagedUnrealFunctionInfo functionInfo, IntPtr function, ref EFunctionFlags functionFlags, ManagedUnrealPropertyInfo paramInfo)
	{
		IntPtr intPtr = CreateProperty(function, EPropertyType.Delegate, paramInfo, addToOuter: true);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return intPtr;
	}

	[Conditional("DEBUG")]
	private static void ValidateFunctionParamFlags(ManagedUnrealPropertyInfo paramInfo, IntPtr property, EFunctionFlags functionFlags)
	{
		EPropertyFlags ePropertyFlags = Native_FProperty.Get_PropertyFlags(property);
		if (!paramInfo.IsOut && !paramInfo.IsByRef)
		{
			_ = paramInfo.IsFunctionReturnValue;
		}
		ePropertyFlags.HasFlag(EPropertyFlags.OutParm);
	}

	private static IntPtr CreateProperty(IntPtr outer, EPropertyType outerType, ManagedUnrealPropertyInfo propertyInfo, bool addToOuter)
	{
		Type typeFromPropertyInfo = ManagedUnrealTypeInfo.GetTypeFromPropertyInfo(propertyInfo);
		IntPtr intPtr = CreateProperty(outer, outerType, typeFromPropertyInfo, propertyInfo.Type.TypeCode, propertyInfo.Name, propertyInfo.GenericArgs, propertyInfo.FixedSizeArrayDim, addToOuter);
		if (intPtr != IntPtr.Zero)
		{
			EPropertyFlags ePropertyFlags = Native_FProperty.Get_PropertyFlags(intPtr);
			ePropertyFlags |= propertyInfo.Flags;
			if ((ePropertyFlags & EPropertyFlags.RepNotify) == EPropertyFlags.RepNotify && !string.IsNullOrEmpty(propertyInfo.RepNotifyName))
			{
				FName value = new FName(propertyInfo.RepNotifyName);
				Native_FProperty.Set_RepNotifyFunc(intPtr, ref value);
			}
			EPropertyFlags ePropertyFlags2 = EPropertyFlags.ExportObject | EPropertyFlags.InstancedReference;
			if ((ePropertyFlags & ePropertyFlags2) == ePropertyFlags2)
			{
				LateAddMetaData(propertyInfo.Path, (FName)MDProp.EditInline.ToString(), "true", overwrite: false);
			}
			else if (InheritDefaultToInstance(propertyInfo, intPtr, UClass.GetClassAddress(typeFromPropertyInfo)))
			{
				ePropertyFlags |= ePropertyFlags2;
			}
			Native_FProperty.Set_PropertyFlags(intPtr, ePropertyFlags);
		}
		SetAllMetaData(intPtr, bIsUObject: false, propertyInfo, UMeta.Target.Property);
		return intPtr;
	}

	private static IntPtr CreateProperty(IntPtr outer, EPropertyType outerType, Type type, EPropertyType propertyType, string propertyName, List<ManagedUnrealTypeInfoReference> args, int fixedSizeArrayDim, bool addToOuter)
	{
		int num;
		if (propertyType != EPropertyType.InternalNativeFixedSizeArray)
		{
			num = ((propertyType == EPropertyType.InternalManagedFixedSizeArray) ? 1 : 0);
			if (num == 0)
			{
				goto IL_001f;
			}
		}
		else
		{
			num = 1;
		}
		propertyType = args[0].TypeCode;
		goto IL_001f;
		IL_001f:
		EObjectFlags flags = EObjectFlags.Public | EObjectFlags.MarkAsNative | EObjectFlags.Transient;
		IntPtr intPtr = NativeReflection.NewFProperty(outer, outerType, propertyType, new FName(propertyName), flags);
		if (num != 0 && fixedSizeArrayDim > 1)
		{
			Native_FProperty.Set_ArrayDim(intPtr, fixedSizeArrayDim);
		}
		switch (propertyType)
		{
		case EPropertyType.Array:
			CreateProperty(intPtr, propertyType, type.GenericTypeArguments[0], args[0].TypeCode, propertyName, null, 0, addToOuter: true);
			break;
		case EPropertyType.Set:
			Native_FSetProperty.Set_ElementProp(intPtr, CreateProperty(intPtr, propertyType, type.GenericTypeArguments[0], args[0].TypeCode, propertyName, null, 0, addToOuter: false));
			break;
		case EPropertyType.Map:
			Native_FMapProperty.Set_KeyProp(intPtr, CreateProperty(intPtr, propertyType, type.GenericTypeArguments[0], args[0].TypeCode, propertyName + "_Key", null, 0, addToOuter: false));
			Native_FMapProperty.Set_ValueProp(intPtr, CreateProperty(intPtr, propertyType, type.GenericTypeArguments[1], args[1].TypeCode, propertyName, null, 0, addToOuter: false));
			break;
		case EPropertyType.Interface:
		{
			IntPtr classAddress = UClass.GetClassAddress(type);
			Native_FInterfaceProperty.Set_InterfaceClass(intPtr, classAddress);
			break;
		}
		case EPropertyType.Class:
			Native_FClassProperty.SetMetaClass(intPtr, UClass.GetClassAddress(type.GenericTypeArguments[0]));
			if (type.IsSameOrSubclassOfGeneric(typeof(TSubclassOf<>)))
			{
				Native_FObjectPropertyBase.SetPropertyClass(intPtr, UClass.GetClassAddress(typeof(UClass)));
			}
			break;
		case EPropertyType.Object:
		{
			IntPtr classAddress2 = UClass.GetClassAddress(type);
			if (classAddress2 == IntPtr.Zero)
			{
				classAddress2 = UClass.GetClassAddress(typeof(UObject));
			}
			Native_FObjectPropertyBase.SetPropertyClass(intPtr, classAddress2);
			break;
		}
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftObject:
			Native_FObjectPropertyBase.SetPropertyClass(intPtr, UClass.GetClassAddress(type.GenericTypeArguments[0]));
			break;
		case EPropertyType.SoftClass:
			Native_FSoftClassProperty.SetMetaClass(intPtr, UClass.GetClassAddress(type.GenericTypeArguments[0]));
			break;
		case EPropertyType.Enum:
		{
			Native_FEnumProperty.SetEnum(intPtr, UEnum.GetEnumAddress(type));
			Type enumUnderlyingType = type.GetEnumUnderlyingType();
			EPropertyType propertyType2 = EPropertyType.Int;
			switch (Type.GetTypeCode(enumUnderlyingType))
			{
			case TypeCode.SByte:
				propertyType2 = EPropertyType.Int8;
				break;
			case TypeCode.Byte:
				propertyType2 = EPropertyType.Byte;
				break;
			case TypeCode.Int16:
				propertyType2 = EPropertyType.Int16;
				break;
			case TypeCode.UInt16:
				propertyType2 = EPropertyType.UInt16;
				break;
			case TypeCode.Int32:
				propertyType2 = EPropertyType.Int;
				break;
			case TypeCode.UInt32:
				propertyType2 = EPropertyType.UInt32;
				break;
			case TypeCode.Int64:
				propertyType2 = EPropertyType.Int64;
				break;
			case TypeCode.UInt64:
				propertyType2 = EPropertyType.UInt64;
				break;
			}
			CreateProperty(intPtr, propertyType, enumUnderlyingType, propertyType2, propertyName, null, 0, addToOuter: true);
			break;
		}
		case EPropertyType.Struct:
			Native_FStructProperty.Set_Struct(intPtr, UScriptStruct.ResolveStructAddress(type));
			break;
		case EPropertyType.Delegate:
			Native_FDelegateProperty.Set_SignatureFunction(intPtr, UFunction.GetDelegateSignatureAddress(type));
			break;
		case EPropertyType.MulticastDelegate:
			Native_FMulticastDelegateProperty.Set_SignatureFunction(intPtr, UFunction.GetDelegateSignatureAddress(type));
			break;
		}
		if (addToOuter)
		{
			if (outerType == EPropertyType.Enum || (uint)(outerType - 23) <= 2u)
			{
				Native_FField.AddCppProperty(outer, intPtr);
			}
			else
			{
				Native_UField.AddCppProperty(outer, intPtr);
			}
		}
		return intPtr;
	}

	private static bool InheritDefaultToInstance(ManagedUnrealPropertyInfo propertyInfo, IntPtr property, IntPtr unrealClass)
	{
		bool flag = false;
		IntPtr instance = unrealClass;
		while (!flag && unrealClass != IntPtr.Zero)
		{
			flag = Native_UClass.HasAnyClassFlags(instance, EClassFlags.DefaultToInstanced);
			unrealClass = Native_UClass.GetSuperClass(unrealClass);
		}
		if (flag)
		{
			Native_FProperty.SetPropertyFlags(property, EPropertyFlags.ExportObject | EPropertyFlags.InstancedReference);
			LateAddMetaData(propertyInfo.Path, (FName)MDProp.EditInline.ToString(), "true", overwrite: false);
		}
		return flag;
	}

	private static Guid CreateNameGuid(string name, HashSet<Guid> existingGuids = null)
	{
		using SHA256 sHA = SHA256.Create();
		byte[] src = sHA.ComputeHash(Encoding.Unicode.GetBytes(name));
		byte[] array = new byte[16];
		Buffer.BlockCopy(src, 0, array, 0, array.Length);
		if (existingGuids != null)
		{
			array[array.Length - 1] = 0;
			while (existingGuids.Contains(new Guid(array)))
			{
				array[array.Length - 1]++;
			}
		}
		return new Guid(array);
	}

	private static void CollectTypes<T>(Dictionary<Type, T> types, Dictionary<Type, ManagedTypeBase> allTypes, Dictionary<Type, ManagedTypeBase> changedTypes, Dictionary<Type, ManagedTypeBase> unchangedTypes) where T : ManagedTypeBase
	{
		foreach (KeyValuePair<Type, T> type in types)
		{
			allTypes.Add(type.Key, type.Value);
			if (type.Value.Changed)
			{
				changedTypes.Add(type.Key, type.Value);
			}
			else
			{
				unchangedTypes.Add(type.Key, type.Value);
			}
		}
	}

	private static void ChainChangedDependencies(Dictionary<string, ManagedTypeBase> allTypesByPath, Dictionary<Type, ManagedTypeBase> allTypes, Dictionary<Type, ManagedTypeBase> changedTypes, Dictionary<Type, ManagedTypeBase> unchangedTypes)
	{
		EPropertyType[] validTargetTypes = new EPropertyType[2]
		{
			EPropertyType.Struct,
			EPropertyType.Enum
		};
		EPropertyType[] validTargetTypes2 = new EPropertyType[2]
		{
			EPropertyType.Struct,
			EPropertyType.Enum
		};
		EPropertyType[] validTargetTypes3 = new EPropertyType[2]
		{
			EPropertyType.Object,
			EPropertyType.Interface
		};
		int num = 1;
		while (num > 0)
		{
			num = 0;
			foreach (ManagedTypeBase item in new List<ManagedTypeBase>(unchangedTypes.Values))
			{
				if (item.TypeCode == EPropertyType.Enum)
				{
					continue;
				}
				foreach (ManagedUnrealPropertyInfo property in item.TypeInfo.Properties)
				{
					if (TypeRefIsChangedType(item, property.Type, changedTypes, allTypesByPath, validTargetTypes))
					{
						item.ChangedByRef = true;
						break;
					}
				}
				if (!item.ChangedByRef)
				{
					foreach (ManagedUnrealFunctionInfo function in item.TypeInfo.Functions)
					{
						if (function.ReturnProp != null && TypeRefIsChangedType(item, function.ReturnProp.Type, changedTypes, allTypesByPath, validTargetTypes2))
						{
							item.ChangedByRef = true;
							break;
						}
						foreach (ManagedUnrealPropertyInfo property2 in item.TypeInfo.Properties)
						{
							if (TypeRefIsChangedType(item, property2.Type, changedTypes, allTypesByPath, validTargetTypes2))
							{
								item.ChangedByRef = true;
								break;
							}
						}
						if (item.ChangedByRef)
						{
							break;
						}
					}
				}
				if (!item.ChangedByRef && item.TypeCode == EPropertyType.Object)
				{
					foreach (ManagedUnrealTypeInfoReference baseType in item.TypeInfo.BaseTypes)
					{
						if (TypeRefIsChangedType(item, baseType, changedTypes, allTypesByPath, validTargetTypes3))
						{
							item.ChangedByRef = true;
							break;
						}
					}
				}
				if (item.ChangedByRef)
				{
					changedTypes.Add(item.Type, item);
					unchangedTypes.Remove(item.Type);
					num++;
				}
			}
		}
	}

	private static bool TypeRefIsChangedType(ManagedTypeBase managedType, ManagedUnrealTypeInfoReference typeRef, Dictionary<Type, ManagedTypeBase> changedTypes, Dictionary<string, ManagedTypeBase> allTypesByPath, params EPropertyType[] validTargetTypes)
	{
		if (typeRef == null || string.IsNullOrEmpty(typeRef.Path))
		{
			return false;
		}
		if (allTypesByPath.TryGetValue(typeRef.Path, out var value) && value.HasChanged && value != managedType && validTargetTypes.Contains(value.TypeCode))
		{
			return true;
		}
		return false;
	}

	private static void InitType(Type type, USharpPathAttribute pathAttribute)
	{
		if (type.IsSubclassOf(typeof(UObject)))
		{
			InitType<ManagedClass, USharpClass>(type, Classes, pathAttribute);
		}
		else if (type.IsEnum)
		{
			InitType<ManagedEnum, UEnum>(type, Enums, pathAttribute);
		}
		else if (typeof(IDelegateBase).IsAssignableFrom(type))
		{
			InitType<ManagedDelegateSignature, UDelegateFunction>(type, DelegateSignatures, pathAttribute);
		}
		else if (type.IsValueType)
		{
			InitType<ManagedStruct, USharpStruct>(type, Structs, pathAttribute);
		}
		else if (type.IsInterface)
		{
			InitType<ManagedInterface, UClass>(type, Interfaces, pathAttribute);
		}
		InitTypeMetaData(type);
	}

	private static void InitType<TManagedType, TNativeType>(Type type, Dictionary<Type, TManagedType> types, USharpPathAttribute pathAttribute) where TManagedType : ManagedTypeBase, new() where TNativeType : UObject
	{
		FPackageName.GetPathInfo(pathAttribute.Path, out var pathRoot, out var directory, out var moduleName, out var objectName, out var _);
		string text = "/" + pathRoot + "/" + directory;
		if (string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(objectName))
		{
			return;
		}
		IntPtr intPtr = NativeReflection.FindObject(UnrealEngine.Runtime.Classes.UPackage, IntPtr.Zero, text, exactClass: true);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = NativeReflection.CreatePackage(text);
			if (intPtr == IntPtr.Zero)
			{
				return;
			}
			Native_UPackage.SetPackageFlags(intPtr, EPackageFlags.CompiledIn);
			byte[] bytes = BitConverter.GetBytes(text.GetHashCode());
			byte[] array = new byte[16];
			Buffer.BlockCopy(bytes, 0, array, 0, Math.Min(array.Length, bytes.Length));
			Guid guid = new Guid(array);
			Native_UPackage.SetGuid(intPtr, ref guid);
		}
		if (intPtr == IntPtr.Zero || string.IsNullOrEmpty(text) || string.IsNullOrEmpty(objectName))
		{
			return;
		}
		ManagedUnrealModuleInfo managedUnrealModuleInfo = ManagedUnrealModuleInfo.FindModule(type);
		if (managedUnrealModuleInfo == null)
		{
			managedUnrealModuleInfo = ManagedUnrealModuleInfo.LoadModuleFromAssembly(type.Assembly);
			if (managedUnrealModuleInfo == null)
			{
				return;
			}
		}
		ManagedUnrealTypeInfo managedUnrealTypeInfo = managedUnrealModuleInfo.FindType(type);
		if (managedUnrealTypeInfo == null)
		{
			return;
		}
		types.TryGetValue(type, out var value);
		if (value != null && !FBuild.WithHotReload)
		{
			return;
		}
		string hash;
		IntPtr obj;
		bool cachedType = GetCachedType(pathAttribute.Path, out hash, out obj);
		if (value == null)
		{
			value = (types[type] = new TManagedType());
		}
		value.ModuleInfo = managedUnrealModuleInfo;
		value.TypeInfo = managedUnrealTypeInfo;
		value.Type = type;
		value.PackageName = text;
		value.Package = intPtr;
		value.Name = objectName;
		if (cachedType && hash == value.TypeInfo.Hash)
		{
			value.Address = obj;
			value.Changed = false;
		}
		else
		{
			value.Address = IntPtr.Zero;
			value.Changed = true;
		}
		if (value.Address == IntPtr.Zero)
		{
			value.Address = NativeReflection.FindObject(UnrealEngine.Runtime.Classes.UObject, IntPtr.Zero, managedUnrealTypeInfo.Path);
		}
		if (value.Address != IntPtr.Zero && !Native_UObjectBaseUtility.IsA(value.Address, UClass.GetClassAddress<TNativeType>()))
		{
			Debugger.Break();
		}
		if (value.Address == IntPtr.Zero)
		{
			EObjectFlags flags = EObjectFlags.Public | EObjectFlags.Standalone;
			value.Address = NativeReflection.NewObject(intPtr, UClass.GetClassAddress<TNativeType>(), new FName(objectName), flags, (IntPtr)0, copyTransientsFromClassDefaults: false, (IntPtr)0);
			switch (managedUnrealTypeInfo.TypeCode)
			{
			case EPropertyType.Enum:
			{
				using (TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>())
				{
					using TArrayUnsafe<long> tArrayUnsafe2 = new TArrayUnsafe<long>();
					Native_UEnum.SetEnums(value.Address, tArrayUnsafe.Address, tArrayUnsafe2.Address, UEnum.ECppForm.EnumClass, true);
				}
				break;
			}
			case EPropertyType.Struct:
				Native_USharpStruct.CreateGuid(value.Address);
				break;
			}
		}
		else
		{
			value.Linked = true;
		}
		if (value.HasChanged && !value.Linked)
		{
			numChangedTypes++;
		}
		if (value.Address != IntPtr.Zero && (!cachedType || obj != value.Address || hash != value.TypeInfo.Hash))
		{
			AddCachedType(managedUnrealTypeInfo.Path, managedUnrealTypeInfo.Hash, value.Address);
		}
	}

	private static void ClearTypeMetaData()
	{
		metaDataMap.Clear();
		metaDataProcessedTypes.Clear();
	}

	private static void InitTypeMetaData(Type type)
	{
		if (!FBuild.WithEditor || !metaDataEnabled || !UnrealTypes.All.TryGetValue(type, out var value))
		{
			return;
		}
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		IEnumerable<UMetaAttribute> customAttributes = type.GetCustomAttributes<UMetaAttribute>(inherit: false);
		if (customAttributes != null)
		{
			foreach (UMetaAttribute item in customAttributes)
			{
				dictionary[new FName(item.Key)] = item.Value;
			}
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes2 = type.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes2 != null)
		{
			foreach (ManagedUnrealAttributeBase item2 in customAttributes2)
			{
				if (item2.HasMetaData)
				{
					item2.SetMetaData(dictionary);
				}
			}
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		if (type.IsEnum)
		{
			MemberInfo[] members = type.GetMembers(bindingAttr);
			for (int i = 0; i < members.Length; i++)
			{
				InitEnumValueMetaData(members[i], dictionary);
			}
		}
		else
		{
			MemberInfo[] members = type.GetMembers(bindingAttr);
			for (int i = 0; i < members.Length; i++)
			{
				InitMetaData(members[i]);
			}
		}
		if (dictionary.Count > 0)
		{
			metaDataMap.Add(StringParseHelper.SafeToLower(value.Path), dictionary);
		}
	}

	private static void InitEnumValueMetaData(MemberInfo enumVal, Dictionary<FName, string> values)
	{
		IEnumerable<UMetaAttribute> customAttributes = enumVal.GetCustomAttributes<UMetaAttribute>(inherit: false);
		if (customAttributes == null)
		{
			return;
		}
		foreach (UMetaAttribute item in customAttributes)
		{
			values[new FName(enumVal.Name + "." + item.Key)] = item.Value;
		}
	}

	private static void InitMetaData(MemberInfo member)
	{
		UUnrealTypePathAttribute customAttribute = member.GetCustomAttribute<UUnrealTypePathAttribute>(inherit: false);
		if (customAttribute == null || string.IsNullOrEmpty(customAttribute.Path))
		{
			return;
		}
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		IEnumerable<UMetaAttribute> customAttributes = member.GetCustomAttributes<UMetaAttribute>(inherit: false);
		if (customAttributes != null)
		{
			foreach (UMetaAttribute item in customAttributes)
			{
				dictionary[new FName(item.Key)] = item.Value;
			}
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes2 = member.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes2 != null)
		{
			foreach (ManagedUnrealAttributeBase item2 in customAttributes2)
			{
				if (item2.HasMetaData)
				{
					item2.SetMetaData(dictionary);
				}
			}
		}
		if (dictionary.Count > 0)
		{
			metaDataMap.Add(StringParseHelper.SafeToLower(customAttribute.Path), dictionary);
		}
		MethodInfo methodInfo = member as MethodInfo;
		if (methodInfo != null)
		{
			if (methodInfo.ReturnParameter != null)
			{
				InitMetaData(customAttribute.Path, methodInfo.ReturnParameter);
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			foreach (ParameterInfo parameter in parameters)
			{
				InitMetaData(customAttribute.Path, parameter);
			}
		}
	}

	private static void InitMetaData(string path, ParameterInfo parameter)
	{
		string str = path + "." + (parameter.IsRetval ? "__return" : parameter.Name);
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		IEnumerable<UMetaAttribute> customAttributes = parameter.GetCustomAttributes<UMetaAttribute>(inherit: false);
		if (customAttributes != null)
		{
			foreach (UMetaAttribute item in customAttributes)
			{
				dictionary[new FName(item.Key)] = item.Value;
			}
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes2 = parameter.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes2 != null)
		{
			foreach (ManagedUnrealAttributeBase item2 in customAttributes2)
			{
				if (item2.HasMetaData)
				{
					item2.SetMetaData(dictionary);
				}
			}
		}
		if (dictionary.Count > 0)
		{
			metaDataMap.Add(StringParseHelper.SafeToLower(str), dictionary);
		}
	}

	private static void LateAddMetaData(ManagedUnrealReflectionBase field, IntPtr nativeField, string key)
	{
		FName key2 = new FName(key);
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UField.GetMetaDataF(nativeField, ref key2, ref fStringUnsafe.Array);
		string value = fStringUnsafe.Value;
		if (!string.IsNullOrEmpty(value))
		{
			LateAddMetaData(field.Path, key2, value, overwrite: false);
		}
	}

	private static void LateAddMetaData(string path, FName key, string value, bool overwrite)
	{
		path = StringParseHelper.SafeToLower(path);
		if (!metaDataMap.TryGetValue(path, out var value2))
		{
			metaDataMap.Add(path, value2 = new Dictionary<FName, string>());
		}
		if (overwrite)
		{
			value2[key] = value;
		}
		else if (!value2.ContainsKey(key))
		{
			value2.Add(key, value);
		}
	}

	private static void MetaDataMergeClassCategories(IntPtr metadata, IntPtr obj, Dictionary<FName, string> values)
	{
		HashSet<string> hashSet = new HashSet<string>();
		HashSet<string> hashSet2 = new HashSet<string>();
		HashSet<string> hashSet3 = new HashSet<string>();
		HashSet<string> hashSet4 = new HashSet<string>();
		HashSet<string> hashSet5 = new HashSet<string>();
		HashSet<string> hashSet6 = new HashSet<string>();
		HashSet<string> hashSet7 = new HashSet<string>();
		HashSet<string> hashSet8 = new HashSet<string>();
		HashSet<string> hashSet9 = new HashSet<string>();
		GetMetaDataItems(UMeta.GetKeyName(MDClass.ShowCategories), values, hashSet);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.HideCategories), values, hashSet2);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.ShowFunctions), values, hashSet4);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.HideFunctions), values, hashSet5);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.AutoExpandCategories), values, hashSet6);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.AutoCollapseCategories), values, hashSet7);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.DontAutoCollapseCategories), values, hashSet8);
		GetMetaDataItems(UMeta.GetKeyName(MDClass.ClassGroupNames), values, hashSet9);
		IntPtr parent = Native_UClass.GetSuperClass(obj);
		HashSet<string> hashSet10 = new HashSet<string>();
		HashSet<string> hashSet11 = new HashSet<string>();
		HashSet<string> hashSet12 = new HashSet<string>();
		HashSet<string> hashSet13 = new HashSet<string>();
		HashSet<string> hashSet14 = new HashSet<string>();
		GetParentMetaDataItems(metadata, parent, UMeta.GetKeyName(MDClass.HideCategories), hashSet10);
		GetParentMetaDataItems(metadata, parent, UMeta.GetKeyName(MDClass.ShowCategories), hashSet11);
		GetParentMetaDataItems(metadata, parent, UMeta.GetKeyName(MDClass.HideFunctions), hashSet12);
		GetParentMetaDataItems(metadata, parent, UMeta.GetKeyName(MDClass.AutoExpandCategories), hashSet13);
		GetParentMetaDataItems(metadata, parent, UMeta.GetKeyName(MDClass.AutoCollapseCategories), hashSet14);
		MetaDataMergeCollection(hashSet2, hashSet10);
		MetaDataMergeCollection(hashSet3, hashSet11);
		MetaDataMergeCollection(hashSet5, hashSet12);
		MetaDataMergeShowCategories(hashSet, hashSet2, hashSet3);
		foreach (string item in hashSet4)
		{
			hashSet5.Remove(item);
		}
		foreach (string item2 in hashSet8)
		{
			hashSet7.Remove(item2);
		}
		foreach (string item3 in hashSet6)
		{
			hashSet7.Remove(item3);
			hashSet14.Remove(item3);
		}
		foreach (string item4 in hashSet7)
		{
			hashSet6.Remove(item4);
			hashSet13.Remove(item4);
		}
		MetaDataMergeCollection(hashSet7, hashSet14);
		MetaDataMergeCollection(hashSet6, hashSet13);
		SetOrClearMetaDataClassCollection(MDClass.ClassGroupNames, values, hashSet9);
		SetOrClearMetaDataClassCollection(MDClass.AutoCollapseCategories, values, hashSet7);
		SetOrClearMetaDataClassCollection(MDClass.HideCategories, values, hashSet2);
		SetOrClearMetaDataClassCollection(MDClass.ShowCategories, values, hashSet3);
		SetOrClearMetaDataClassCollection(MDClass.HideFunctions, values, hashSet5);
		SetOrClearMetaDataClassCollection(MDClass.AutoExpandCategories, values, hashSet6);
	}

	private static void SetOrClearMetaDataClassCollection(MDClass key, Dictionary<FName, string> values, HashSet<string> collection)
	{
		if (collection.Count > 0)
		{
			values[UMeta.GetKeyName(key)] = string.Join(" ", collection);
		}
		else
		{
			values.Remove(UMeta.GetKeyName(key));
		}
	}

	private static void MetaDataMergeCollection(HashSet<string> collection, HashSet<string> mergeWith)
	{
		foreach (string item in mergeWith)
		{
			collection.Add(item);
		}
	}

	private static void MetaDataMergeShowCategories(HashSet<string> showCategories, HashSet<string> hideCategories, HashSet<string> showSubCategories)
	{
		foreach (string showCategory in showCategories)
		{
			if (hideCategories.Remove(showCategory))
			{
				continue;
			}
			string[] array = showCategory.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			string text = string.Empty;
			for (int i = 0; i < array.Length - 1; i++)
			{
				text += array[i];
				if (hideCategories.Contains(text))
				{
					showSubCategories.Add(showCategory);
					break;
				}
				text += "|";
			}
		}
	}

	private static void GetParentMetaDataItems(IntPtr metadata, IntPtr parent, FName key, HashSet<string> items)
	{
		if (HasMetaData(metadata, parent, key))
		{
			items.Add(GetMetaData(metadata, parent, key));
		}
	}

	private static void GetMetaDataItems(FName key, Dictionary<FName, string> values, HashSet<string> items)
	{
		if (!values.TryGetValue(key, out var value))
		{
			return;
		}
		string[] array = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (!string.IsNullOrEmpty(text))
			{
				items.Add(text);
			}
		}
	}

	private static void SetAllMetaData(IntPtr obj, bool bIsUObject, ManagedUnrealReflectionBase field, UMeta.Target target)
	{
		if (!FBuild.WithEditor || !metaDataEnabled || field == null || string.IsNullOrEmpty(field.Path))
		{
			return;
		}
		IntPtr intPtr = (bIsUObject ? Native_UObjectBaseUtility.GetOutermost(obj) : Native_FField.GetOutermost(obj));
		IntPtr intPtr2 = ((intPtr == IntPtr.Zero) ? IntPtr.Zero : Native_UPackage.GetMetaData(intPtr));
		if (intPtr2 == IntPtr.Zero)
		{
			return;
		}
		Dictionary<FName, string> value = null;
		if (!metaDataMap.TryGetValue(StringParseHelper.SafeToLower(field.Path), out value))
		{
			value = new Dictionary<FName, string>();
		}
		switch (target)
		{
		case UMeta.Target.Class:
		case UMeta.Target.Interface:
			if (!value.ContainsKey(UMeta.GetKeyName(MDClass.IsBlueprintBase)))
			{
				if (value.ContainsKey(UMeta.GetKeyName(MDClass.Blueprintable)))
				{
					value[UMeta.GetKeyName(MDClass.IsBlueprintBase)] = "true";
				}
				else if (value.ContainsKey(UMeta.GetKeyName(MDClass.NotBlueprintable)))
				{
					value[UMeta.GetKeyName(MDClass.IsBlueprintBase)] = "false";
				}
			}
			MetaDataMergeClassCategories(intPtr2, obj, value);
			break;
		case UMeta.Target.Function:
		{
			ManagedUnrealFunctionInfo managedUnrealFunctionInfo = field as ManagedUnrealFunctionInfo;
			if (managedUnrealFunctionInfo.IsOverride && managedUnrealFunctionInfo.IsBlueprintEvent)
			{
				value[UMeta.GetKeyName(MDFunc.BlueprintInternalUseOnly)] = "true";
			}
			break;
		}
		}
		SetMetaDataBlueprintability(value, target, field as ManagedUnrealTypeInfo);
		if (value.Count <= 0)
		{
			return;
		}
		if (bIsUObject)
		{
			using (TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>())
			{
				using TArrayUnsafe<string> tArrayUnsafe2 = new TArrayUnsafe<string>();
				tArrayUnsafe.AddRange(value.Keys.ToArray());
				tArrayUnsafe2.AddRange(value.Values.ToArray());
				Native_UMetaData.SetObjectValues(intPtr2, obj, tArrayUnsafe.Address, tArrayUnsafe2.Address);
				return;
			}
		}
		foreach (KeyValuePair<FName, string> item in value)
		{
			FName key = item.Key;
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(item.Value);
			Native_FField.SetMetaDataF(obj, ref key, ref fStringUnsafe.Array);
		}
	}

	private static void SetMetaDataBlueprintability(Dictionary<FName, string> values, UMeta.Target target, ManagedUnrealTypeInfo typeInfo)
	{
		ManagedUnrealVisibility.Type type = ManagedUnrealVisibility.Type.None;
		switch (target)
		{
		default:
			return;
		case UMeta.Target.Class:
			type = ManagedUnrealVisibility.Class;
			break;
		case UMeta.Target.Interface:
			type = ManagedUnrealVisibility.Interface;
			break;
		case UMeta.Target.Struct:
			type = ManagedUnrealVisibility.Struct;
			break;
		case UMeta.Target.Enum:
			type = ManagedUnrealVisibility.Enum;
			break;
		}
		if (type == ManagedUnrealVisibility.Type.None)
		{
			return;
		}
		if (type.HasFlag(ManagedUnrealVisibility.Type.BlueprintType))
		{
			if (typeInfo.AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.BlueprintTypeHierarchical))
			{
				values[UMeta.GetKeyName(MDClass.BlueprintType)] = "true";
				values.Remove(UMeta.GetKeyName(MDClass.NotBlueprintType));
			}
			else
			{
				values[UMeta.GetKeyName(MDClass.NotBlueprintType)] = "true";
				values.Remove(UMeta.GetKeyName(MDClass.BlueprintType));
			}
		}
		if (type.HasFlag(ManagedUnrealVisibility.Type.Blueprintable))
		{
			if (typeInfo.AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.BlueprintableHierarchical))
			{
				values[UMeta.GetKeyName(MDClass.Blueprintable)] = "true";
				values[UMeta.GetKeyName(MDClass.IsBlueprintBase)] = "true";
				values.Remove(UMeta.GetKeyName(MDClass.NotBlueprintable));
			}
			else
			{
				values[UMeta.GetKeyName(MDClass.NotBlueprintType)] = "true";
				values[UMeta.GetKeyName(MDClass.IsBlueprintBase)] = "false";
				values.Remove(UMeta.GetKeyName(MDClass.Blueprintable));
			}
		}
	}

	private static bool HasMetaData(IntPtr metadata, IntPtr obj, FName key)
	{
		return Native_UMetaData.HasValueFName(metadata, obj, ref key);
	}

	private static string GetMetaData(IntPtr metadata, IntPtr obj, FName key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UMetaData.GetValueFName(metadata, obj, ref key, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	static ManagedUnrealTypes()
	{
		classesToReinstance = new List<ManagedClass>();
		hotReloadedClasses = new Dictionary<IntPtr, IntPtr>();
		ctorsAvailable = false;
		numChangedTypes = 0;
		FirstTimeLoadEnum = true;
		initializerExceptionPopupDelay = TimeSpan.FromSeconds(10.0);
		metaDataMap = new Dictionary<string, Dictionary<FName, string>>();
		metaDataProcessedTypes = new HashSet<Type>();
		metaDataEnabled = true;
		registeredTypes = new HashSet<Type>();
		Classes = new Dictionary<Type, ManagedClass>();
		ClassesByAddress = new Dictionary<long, ManagedClass>();
		UFunctionAddrToClasses = new Dictionary<long, ManagedClass>();
		Interfaces = new Dictionary<Type, ManagedInterface>();
		InterfacesByAddress = new Dictionary<long, ManagedInterface>();
		Structs = new Dictionary<Type, ManagedStruct>();
		StructsByAddress = new Dictionary<long, ManagedStruct>();
		Enums = new Dictionary<Type, ManagedEnum>();
		EnumsByAddress = new Dictionary<long, ManagedEnum>();
		DelegateSignatures = new Dictionary<Type, ManagedDelegateSignature>();
		DelegateSignaturesByAddress = new Dictionary<long, ManagedDelegateSignature>();
	}

	private static void OnTypeRegistered(Type type)
	{
		registeredTypes.Add(type);
	}

	public static bool IsTypeRegistered(Type type)
	{
		return registeredTypes.Contains(type);
	}

	public static ManagedEnum GetManagedEnum(Type type)
	{
		Enums.TryGetValue(type, out var value);
		return value;
	}

	public static IntPtr GetEnumAddress(Type type)
	{
		return GetManagedEnum(type)?.Address ?? IntPtr.Zero;
	}

	public static UEnum GetEnum(Type type)
	{
		IntPtr enumAddress = GetEnumAddress(type);
		if (enumAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UEnum>(enumAddress);
		}
		return null;
	}

	public static ManagedStruct GetManagedStruct(Type type)
	{
		Structs.TryGetValue(type, out var value);
		return value;
	}

	public static IntPtr GetStructAddress(Type type)
	{
		return GetManagedStruct(type)?.Address ?? IntPtr.Zero;
	}

	public static UScriptStruct GetStruct(Type type)
	{
		IntPtr structAddress = GetStructAddress(type);
		if (structAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UScriptStruct>(structAddress);
		}
		return null;
	}

	public static ManagedDelegateSignature GetManagedDelegateSignature(Type type)
	{
		DelegateSignatures.TryGetValue(type, out var value);
		return value;
	}

	public static IntPtr GetDelegateSignatureAddress(Type type)
	{
		return GetManagedDelegateSignature(type)?.Address ?? IntPtr.Zero;
	}

	public static UFunction GetDelegateSignature(Type type)
	{
		IntPtr delegateSignatureAddress = GetDelegateSignatureAddress(type);
		if (delegateSignatureAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UFunction>(delegateSignatureAddress);
		}
		return null;
	}

	public static ManagedClass GetManagedClass(Type type)
	{
		if (!Classes.TryGetValue(type, out var value))
		{
			Interfaces.TryGetValue(type, out var value2);
			return value2;
		}
		return value;
	}

	public static IntPtr GetClassAddress(Type type)
	{
		return GetManagedClass(type)?.Address ?? IntPtr.Zero;
	}

	public static UClass GetClass(Type type)
	{
		IntPtr classAddress = GetClassAddress(type);
		if (classAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UClass>(classAddress);
		}
		return null;
	}

	public static ManagedInterface GetManagedInterface(Type type)
	{
		Interfaces.TryGetValue(type, out var value);
		return value;
	}

	public static IntPtr GetInterfaceAddress(Type type)
	{
		return GetManagedInterface(type)?.Address ?? IntPtr.Zero;
	}

	public static UClass GetInterface(Type type)
	{
		IntPtr interfaceAddress = GetInterfaceAddress(type);
		if (interfaceAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UClass>(interfaceAddress);
		}
		return null;
	}
}
