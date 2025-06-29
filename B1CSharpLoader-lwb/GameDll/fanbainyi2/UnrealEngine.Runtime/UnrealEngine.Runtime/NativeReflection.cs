using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class NativeReflection
{
	public struct NativeUFieldIterator : IEnumerable<IntPtr>, IEnumerable
	{
		public struct Enumerator : IEnumerator<IntPtr>, IDisposable, IEnumerator
		{
			private NativeUFieldIterator iterator;

			private IntPtr unrealStruct;

			private IntPtr field;

			private int interfaceIndex;

			private bool first;

			public IntPtr Current => field;

			object IEnumerator.Current => Current;

			public Enumerator(ref NativeUFieldIterator iterator)
			{
				this.iterator = iterator;
				unrealStruct = iterator.targetStruct;
				interfaceIndex = -1;
				first = true;
				field = IntPtr.Zero;
				field = GetField(unrealStruct);
			}

			private IntPtr GetField(IntPtr unrealStruct)
			{
				if (unrealStruct == IntPtr.Zero)
				{
					return IntPtr.Zero;
				}
				return Native_UStruct.Get_Children(unrealStruct);
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				if (first)
				{
					first = false;
				}
				else if (field != IntPtr.Zero)
				{
					field = Native_UField.Get_Next(field);
				}
				IntPtr intPtr = field;
				IntPtr intPtr2 = unrealStruct;
				while (intPtr2 != IntPtr.Zero)
				{
					while (intPtr != IntPtr.Zero)
					{
						IntPtr instance = Native_UObjectBase.GetClass(intPtr);
						bool num = (iterator.allFieldTypeClassCastFlags ? Native_UClass.HasAllCastFlags(instance, iterator.fieldTypeClassCastFlags) : Native_UClass.HasAnyCastFlag(instance, iterator.fieldTypeClassCastFlags));
						bool flag = Native_UClass.HasAllCastFlags(instance, EClassCastFlags.FProperty);
						bool flag2 = Native_FProperty.HasAllPropertyFlags(intPtr, EPropertyFlags.Deprecated);
						if (num && (iterator.includeDeprecated || !flag || !flag2))
						{
							unrealStruct = intPtr2;
							field = intPtr;
							return true;
						}
						intPtr = Native_UField.Get_Next(intPtr);
					}
					if (iterator.includeInterface)
					{
						interfaceIndex++;
						using TArrayUnsafe<FImplementedInterface> tArrayUnsafe = new TArrayUnsafe<FImplementedInterface>();
						if (interfaceIndex < tArrayUnsafe.Count)
						{
							IntPtr interfaceClassAddress = tArrayUnsafe[interfaceIndex].InterfaceClassAddress;
							GetField(interfaceClassAddress);
							continue;
						}
					}
					if (!iterator.includeSuper)
					{
						break;
					}
					intPtr2 = Native_UStruct.GetInheritanceSuper(intPtr2);
					if (!(intPtr2 != IntPtr.Zero))
					{
						break;
					}
					intPtr = GetField(intPtr2);
					interfaceIndex = -1;
				}
				unrealStruct = intPtr2;
				field = intPtr;
				return field != IntPtr.Zero;
			}

			public void Reset()
			{
				unrealStruct = iterator.targetStruct;
				field = GetField(unrealStruct);
				interfaceIndex = -1;
				first = true;
			}
		}

		private IntPtr fieldTypeClass;

		private EClassCastFlags fieldTypeClassCastFlags;

		private bool allFieldTypeClassCastFlags;

		private IntPtr targetStruct;

		private bool includeSuper;

		private bool includeDeprecated;

		private bool includeInterface;

		private EFieldIteratorType iteratorType;

		public NativeUFieldIterator(IntPtr fieldTypeClass, IntPtr unrealStruct, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
			: this(fieldTypeClass, unrealStruct, EFieldIteratorType.Children, includeSuper, includeDeprecated, includeInterface)
		{
		}

		public NativeUFieldIterator(IntPtr fieldTypeClass, IntPtr unrealStruct, EFieldIteratorType iteratorType, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
		{
			this.fieldTypeClass = fieldTypeClass;
			fieldTypeClassCastFlags = Native_UClass.Get_ClassCastFlags(fieldTypeClass);
			allFieldTypeClassCastFlags = true;
			targetStruct = unrealStruct;
			this.iteratorType = iteratorType;
			this.includeSuper = includeSuper;
			this.includeDeprecated = includeDeprecated;
			this.includeInterface = includeInterface;
		}

		public NativeUFieldIterator(EClassCastFlags fieldTypeClassCastFlags, IntPtr unrealStruct, bool allFieldTypeClassCastFlags = true, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
			: this(fieldTypeClassCastFlags, unrealStruct, EFieldIteratorType.Children, allFieldTypeClassCastFlags, includeSuper, includeDeprecated, includeInterface)
		{
		}

		public NativeUFieldIterator(EClassCastFlags fieldTypeClassCastFlags, IntPtr unrealStruct, EFieldIteratorType iteratorType, bool allFieldTypeClassCastFlags = true, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
		{
			fieldTypeClass = IntPtr.Zero;
			this.fieldTypeClassCastFlags = fieldTypeClassCastFlags;
			this.allFieldTypeClassCastFlags = allFieldTypeClassCastFlags;
			targetStruct = unrealStruct;
			this.iteratorType = iteratorType;
			this.includeSuper = includeSuper;
			this.includeDeprecated = includeDeprecated;
			this.includeInterface = includeInterface;
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator(ref this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public struct NativeFFieldIterator : IEnumerable<IntPtr>, IEnumerable
	{
		public struct Enumerator : IEnumerator<IntPtr>, IDisposable, IEnumerator
		{
			private NativeFFieldIterator iterator;

			private IntPtr unrealStruct;

			private IntPtr field;

			private int interfaceIndex;

			private bool first;

			public IntPtr Current => field;

			object IEnumerator.Current => Current;

			public Enumerator(ref NativeFFieldIterator iterator)
			{
				this.iterator = iterator;
				unrealStruct = iterator.targetStruct;
				interfaceIndex = -1;
				first = true;
				field = IntPtr.Zero;
				field = GetField(unrealStruct);
			}

			private IntPtr GetField(IntPtr unrealStruct)
			{
				if (unrealStruct == IntPtr.Zero)
				{
					return IntPtr.Zero;
				}
				return Native_UStruct.Get_ChildProperties(unrealStruct);
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				if (first)
				{
					first = false;
				}
				else if (field != IntPtr.Zero)
				{
					field = Native_FField.Get_Next(field);
				}
				IntPtr intPtr = field;
				IntPtr intPtr2 = unrealStruct;
				while (intPtr2 != IntPtr.Zero)
				{
					while (intPtr != IntPtr.Zero)
					{
						bool num = (iterator.allFieldTypeClassCastFlags ? Native_FField.HasAllCastFlags(intPtr, iterator.fieldTypeClassCastFlags) : Native_FField.HasAnyCastFlags(intPtr, iterator.fieldTypeClassCastFlags));
						bool flag = Native_FField.HasAllCastFlags(intPtr, 32768uL);
						bool flag2 = Native_FProperty.HasAllPropertyFlags(intPtr, EPropertyFlags.Deprecated);
						if (num && (iterator.includeDeprecated || !flag || !flag2))
						{
							unrealStruct = intPtr2;
							field = intPtr;
							return true;
						}
						intPtr = Native_FField.Get_Next(intPtr);
					}
					if (iterator.includeInterface)
					{
						interfaceIndex++;
						using TArrayUnsafe<FImplementedInterface> tArrayUnsafe = new TArrayUnsafe<FImplementedInterface>();
						if (interfaceIndex < tArrayUnsafe.Count)
						{
							IntPtr interfaceClassAddress = tArrayUnsafe[interfaceIndex].InterfaceClassAddress;
							GetField(interfaceClassAddress);
							continue;
						}
					}
					if (!iterator.includeSuper)
					{
						break;
					}
					intPtr2 = Native_UStruct.GetInheritanceSuper(intPtr2);
					if (!(intPtr2 != IntPtr.Zero))
					{
						break;
					}
					intPtr = GetField(intPtr2);
					interfaceIndex = -1;
				}
				unrealStruct = intPtr2;
				field = intPtr;
				return field != IntPtr.Zero;
			}

			public void Reset()
			{
				unrealStruct = iterator.targetStruct;
				field = GetField(unrealStruct);
				interfaceIndex = -1;
				first = true;
			}
		}

		private IntPtr fieldTypeClass;

		private ulong fieldTypeClassCastFlags;

		private bool allFieldTypeClassCastFlags;

		private IntPtr targetStruct;

		private bool includeSuper;

		private bool includeDeprecated;

		private bool includeInterface;

		private EFieldIteratorType iteratorType;

		public NativeFFieldIterator(IntPtr fieldTypeClass, IntPtr unrealStruct, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
			: this(fieldTypeClass, unrealStruct, EFieldIteratorType.Children, includeSuper, includeDeprecated, includeInterface)
		{
		}

		public NativeFFieldIterator(IntPtr fieldTypeClass, IntPtr unrealStruct, EFieldIteratorType iteratorType, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
		{
			this.fieldTypeClass = fieldTypeClass;
			fieldTypeClassCastFlags = Native_FFieldClass.GetCastFlags(fieldTypeClass);
			allFieldTypeClassCastFlags = true;
			targetStruct = unrealStruct;
			this.iteratorType = iteratorType;
			this.includeSuper = includeSuper;
			this.includeDeprecated = includeDeprecated;
			this.includeInterface = includeInterface;
		}

		public NativeFFieldIterator(ulong fieldTypeClassCastFlags, IntPtr unrealStruct, bool allFieldTypeClassCastFlags = true, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
			: this(fieldTypeClassCastFlags, unrealStruct, EFieldIteratorType.Children, allFieldTypeClassCastFlags, includeSuper, includeDeprecated, includeInterface)
		{
		}

		public NativeFFieldIterator(ulong fieldTypeClassCastFlags, IntPtr unrealStruct, EFieldIteratorType iteratorType, bool allFieldTypeClassCastFlags = true, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
		{
			fieldTypeClass = IntPtr.Zero;
			this.fieldTypeClassCastFlags = fieldTypeClassCastFlags;
			this.allFieldTypeClassCastFlags = allFieldTypeClassCastFlags;
			targetStruct = unrealStruct;
			this.iteratorType = iteratorType;
			this.includeSuper = includeSuper;
			this.includeDeprecated = includeDeprecated;
			this.includeInterface = includeInterface;
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator(ref this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public struct NativeObjectIterator : IEnumerator<IntPtr>, IDisposable, IEnumerator
	{
		private IntPtr[] objectArray;

		private int index;

		public IntPtr Current
		{
			get
			{
				if (objectArray != null && index >= 0 && index < objectArray.Length)
				{
					return objectArray[index];
				}
				return IntPtr.Zero;
			}
		}

		object IEnumerator.Current => Current;

		public NativeObjectIterator(IntPtr unrealClass, EObjectFlags additionalExclusionFlags = EObjectFlags.ClassDefaultObject, bool includeDerivedClasses = true, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None)
		{
			index = -1;
			using TArrayUnsafe<IntPtr> tArrayUnsafe = new TArrayUnsafe<IntPtr>();
			Native_UObjectHash.GetObjectsOfClass(unrealClass, tArrayUnsafe.Address, includeDerivedClasses, additionalExclusionFlags, internalExclusionFlags);
			objectArray = tArrayUnsafe.ToArray();
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (objectArray == null)
			{
				return false;
			}
			if (++index < objectArray.Length)
			{
				_ = Current;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			index = -1;
		}

		public IEnumerator GetEnumerator()
		{
			return this;
		}
	}

	public static class LookupTable
	{
		public static Dictionary<MethodInfo, IntPtr> Functions { get; private set; }

		public static Dictionary<IntPtr, MethodInfo> FunctionsByAddress { get; private set; }

		public static Dictionary<IntPtr, Dictionary<MethodInfo, IntPtr>> FunctionsByClass { get; private set; }

		public static Dictionary<IntPtr, Dictionary<IntPtr, MethodInfo>> FunctionsAddressByClass { get; private set; }

		static LookupTable()
		{
			Functions = new Dictionary<MethodInfo, IntPtr>();
			FunctionsByAddress = new Dictionary<IntPtr, MethodInfo>();
			FunctionsByClass = new Dictionary<IntPtr, Dictionary<MethodInfo, IntPtr>>();
			FunctionsAddressByClass = new Dictionary<IntPtr, Dictionary<IntPtr, MethodInfo>>();
		}

		public static void ResetClass(IntPtr unrealClass)
		{
			if (!FunctionsByClass.TryGetValue(unrealClass, out var value))
			{
				return;
			}
			foreach (KeyValuePair<MethodInfo, IntPtr> item in value)
			{
				Functions.Remove(item.Key);
				FunctionsByAddress.Remove(item.Value);
			}
			FunctionsByClass.Remove(unrealClass);
			FunctionsAddressByClass.Remove(unrealClass);
		}

		public static IntPtr FindFunctionFromClass(IntPtr unrealClass, MethodInfo methodInfo, bool searchHierarchy = true)
		{
			if (methodInfo == null)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr = unrealClass;
			while (intPtr != IntPtr.Zero)
			{
				if (!FunctionsByClass.ContainsKey(intPtr))
				{
					Load(intPtr, methodInfo.DeclaringType);
				}
				if (FunctionsByClass.TryGetValue(intPtr, out var value) && value.TryGetValue(methodInfo, out var value2))
				{
					return value2;
				}
				if (!searchHierarchy)
				{
					break;
				}
				intPtr = Native_UClass.GetSuperClass(intPtr);
			}
			return IntPtr.Zero;
		}

		public static IntPtr FindFunction(IntPtr owner, MethodInfo methodInfo, bool searchHierarchy = true)
		{
			return FindFunctionFromClass(Native_UObjectBase.GetClass(owner), methodInfo, searchHierarchy);
		}

		public static IntPtr FindFunction(UObject owner, MethodInfo methodInfo, bool searchHierarchy = true)
		{
			return FindFunctionFromClass(Native_UObjectBase.GetClass(owner.Address), methodInfo, searchHierarchy);
		}

		private static void Load(IntPtr unrealClass, Type type)
		{
			Dictionary<MethodInfo, IntPtr> dictionary = new Dictionary<MethodInfo, IntPtr>();
			Dictionary<IntPtr, MethodInfo> dictionary2 = new Dictionary<IntPtr, MethodInfo>();
			FunctionsByClass.Add(unrealClass, dictionary);
			FunctionsAddressByClass.Add(unrealClass, dictionary2);
			if (!type.IsSubclassOf(typeof(UObject)))
			{
				return;
			}
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
			MethodInfo[] methods = type.GetMethods(bindingAttr);
			foreach (MethodInfo methodInfo in methods)
			{
				UUnrealTypePathAttribute customAttribute = methodInfo.GetCustomAttribute<UUnrealTypePathAttribute>(inherit: false);
				if (customAttribute != null && !string.IsNullOrEmpty(customAttribute.Path))
				{
					IntPtr function = GetFunction(customAttribute.Path);
					if (function != IntPtr.Zero)
					{
						Functions[methodInfo] = function;
						FunctionsByAddress[function] = methodInfo;
						dictionary[methodInfo] = function;
						dictionary2[function] = methodInfo;
					}
				}
			}
		}

		public static IntPtr GetFunctionAddress(Delegate del, bool searchHierarchy = true)
		{
			GetFunctionAddress(del, out var functionAddress, out var _, searchHierarchy);
			return functionAddress;
		}

		public static bool GetFunctionAddress(Delegate del, out IntPtr functionAddress, out UObject target, bool searchHierarchy = true)
		{
			if ((object)del != null)
			{
				target = del.Target as UObject;
				if (target != null)
				{
					functionAddress = FindFunction(target, del.Method, searchHierarchy);
					if (functionAddress != IntPtr.Zero)
					{
						return true;
					}
				}
			}
			target = null;
			functionAddress = IntPtr.Zero;
			return false;
		}
	}

	public static bool IsOptimized = true;

	public static bool IsDebugAssert = true;

	public static readonly IntPtr AnyPackage = new IntPtr(-1);

	private static Dictionary<IntPtr, EPropertyType> propertyTypesByClass = new Dictionary<IntPtr, EPropertyType>();

	public static IntPtr GetClass(string path)
	{
		return GetStructure(Classes.UClass, path);
	}

	public static IntPtr GetStruct(string path)
	{
		return GetStructure(Classes.UScriptStruct, path);
	}

	public static IntPtr GetStructure(string path)
	{
		return GetStructure(Classes.UStruct, path);
	}

	public static IntPtr GetFunction(string path)
	{
		return GetStructure(Classes.UFunction, path);
	}

	public static IntPtr GetStructure(IntPtr structureClass, string path, bool load = true)
	{
		if (structureClass == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = FindObject(structureClass, IntPtr.Zero, path);
		if (intPtr == IntPtr.Zero && FLinkerLoad.FindNewNameForClass(new FName(path), isInstance: false) != FName.None)
		{
			intPtr = FindObject(structureClass, IntPtr.Zero, path);
		}
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadObject(structureClass, IntPtr.Zero, path);
		}
		return intPtr;
	}

	public static int GetStructureSize(IntPtr unrealStruct)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return 0;
		}
		return Native_UStruct.GetStructureSize(unrealStruct);
	}

	public static int GetStructSize(IntPtr unrealStruct)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return 0;
		}
		if ((bool)Native_UObjectBaseUtility.IsA(unrealStruct, Classes.UScriptStruct))
		{
			IntPtr intPtr = Native_UScriptStruct.GetCppStructOps(unrealStruct);
			if (intPtr != IntPtr.Zero)
			{
				return Native_ICppStructOps.GetSize(intPtr);
			}
		}
		return GetStructureSize(unrealStruct);
	}

	public static IntPtr GetFunction(IntPtr unrealClass, string functionName)
	{
		return FindField(Classes.UFunction, unrealClass, bFindUField: true, functionName);
	}

	public static IntPtr GetFunctionFromInstance(IntPtr obj, string functionName)
	{
		if (obj == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		FName inName = new FName(functionName);
		return Native_UObject.FindFunctionChecked(obj, ref inName);
	}

	public static int GetFunctionParamsSize(IntPtr function)
	{
		if (function == IntPtr.Zero)
		{
			return 0;
		}
		return Native_UFunction.Get_ParmsSize(function);
	}

	public unsafe static IntPtr StackAllocAlign(byte* Address)
	{
		int num = (int)((ulong)Address % 16uL);
		return new IntPtr(Address + 16 - num);
	}

	public static void InvokeStaticFunctionOptimized(IntPtr unrealClass, IntPtr function, IntPtr args, int argsSize)
	{
		InvokeFunctionOptimized(unrealClass, function, args, argsSize);
	}

	[HandleProcessCorruptedStateExceptions]
	public static void InvokeFunctionOptimized(IntPtr unrealClass, IntPtr function, IntPtr args, int argsSize)
	{
		try
		{
			Native_UObject.ProcessEvent(unrealClass, function, args);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			throw;
		}
	}

	public static void InvokeStaticFunction(IntPtr obj, IntPtr function, IntPtr args, int argsSize)
	{
		InvokeFunction(Native_UField.GetOwnerClass(function), function, args, argsSize);
	}

	[HandleProcessCorruptedStateExceptions]
	public static void InvokeFunction(IntPtr obj, IntPtr function, IntPtr args, int argsSize)
	{
		if (obj == IntPtr.Zero)
		{
			throw new Exception("Trying to call function " + GetUFieldPathName(function) + " on destroyed unreal object");
		}
		try
		{
			Native_UObject.ProcessEvent(obj, function, args);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			throw;
		}
	}

	public static void InvokeFunction_InitAll(IntPtr function, IntPtr args)
	{
		foreach (IntPtr item in new NativeFFieldIterator(Classes.FProperty, function))
		{
			Native_FProperty.InitializeValue_InContainer(item, args);
		}
	}

	public static void InvokeFunction_DestroyAll(IntPtr function, IntPtr args)
	{
		foreach (IntPtr item in new NativeFFieldIterator(Classes.FProperty, function))
		{
			Native_FProperty.DestroyValue_InContainer(item, args);
		}
	}

	public static void InitializeValue_InContainer(IntPtr property, IntPtr container)
	{
		Native_FProperty.InitializeValue_InContainer(property, container);
	}

	public static void DestroyValue_InContainer(IntPtr property, IntPtr container)
	{
		Native_FProperty.DestroyValue_InContainer(property, container);
	}

	public static string GetUFieldPathName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetPathName(obj, IntPtr.Zero, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetUFieldName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return string.Empty;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetNameOut(obj, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static FName GetUFieldFName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return FName.None;
		}
		Native_UObjectBase.GetFName(obj, out var result);
		return result;
	}

	public static string GetFFieldPathName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetPathName(obj, IntPtr.Zero, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetFFieldName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return string.Empty;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetNameOut(obj, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static FName GetFFieldFName(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return FName.None;
		}
		Native_FField.GetFName(obj, out var result);
		return result;
	}

	public static IntPtr GetProperty(IntPtr unrealStruct, string propertyName)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return FindField(Classes.FProperty, unrealStruct, bFindUField: false, propertyName);
	}

	public static bool GetPropertyRef(ref FFieldAddress property, IntPtr unrealStruct, string propertyName)
	{
		if (property == null)
		{
			property = new FFieldAddress();
		}
		return property.Update(GetProperty(unrealStruct, propertyName));
	}

	public static bool HasProperty(IntPtr unrealStruct, string propertyName)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return false;
		}
		return GetProperty(unrealStruct, propertyName) != IntPtr.Zero;
	}

	public unsafe static int GetPropertyOffset(IntPtr unrealStruct, string propertyName)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return 0;
		}
		IntPtr intPtr = FindField(Classes.FProperty, unrealStruct, bFindUField: false, propertyName);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		int num = 0;
		IntPtr containerPtr = (IntPtr)(&num);
		return (int)(Native_FProperty.ContainerVoidPtrToValuePtr(intPtr, containerPtr, 0).ToInt64() - containerPtr.ToInt64());
	}

	public static ushort GetPropertyRepIndex(IntPtr unrealStruct, string propertyName)
	{
		IntPtr intPtr = FindField(Classes.FProperty, unrealStruct, bFindUField: false, propertyName);
		if (!(intPtr == IntPtr.Zero))
		{
			return Native_FProperty.Get_RepIndex(intPtr);
		}
		return 0;
	}

	public static int GetPropertyArrayElementSize(IntPtr unrealStruct, string propertyName)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return 0;
		}
		IntPtr intPtr = FindField(Classes.FArrayProperty, unrealStruct, bFindUField: false, propertyName);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		IntPtr instance = Native_FArrayProperty.Get_Inner(intPtr);
		return Native_FProperty.GetSize(instance);
	}

	public static int GetPropertyArrayDim(IntPtr unrealStruct, string propertyName)
	{
		IntPtr intPtr = FindField(Classes.FProperty, unrealStruct, bFindUField: false, propertyName);
		if (!(intPtr == IntPtr.Zero))
		{
			return Native_FProperty.Get_ArrayDim(intPtr);
		}
		return -1;
	}

	public static List<string> GetPropertyNames(IntPtr unrealStruct)
	{
		List<string> list = new List<string>();
		if (unrealStruct != IntPtr.Zero)
		{
			foreach (IntPtr item in new NativeFFieldIterator(Classes.FProperty, unrealStruct))
			{
				list.Add(GetFFieldFName(item).PlainName);
			}
		}
		return list;
	}

	public static Dictionary<string, EPropertyType> GetPropertyTypes(IntPtr unrealStruct)
	{
		Dictionary<string, EPropertyType> dictionary = new Dictionary<string, EPropertyType>();
		if (unrealStruct != IntPtr.Zero)
		{
			foreach (IntPtr item in new NativeFFieldIterator(Classes.FProperty, unrealStruct))
			{
				string plainName = GetFFieldFName(item).PlainName;
				EPropertyType propertyType = GetPropertyType(item);
				dictionary[plainName] = propertyType;
			}
		}
		return dictionary;
	}

	public static IntPtr FindField(IntPtr typeClass, IntPtr unrealStruct, bool bFindUField, string _fieldName)
	{
		FName fName = new FName(_fieldName);
		if (typeClass == IntPtr.Zero || unrealStruct == IntPtr.Zero || fName == FName.None)
		{
			return IntPtr.Zero;
		}
		if (bFindUField)
		{
			foreach (IntPtr item in new NativeUFieldIterator(typeClass, unrealStruct))
			{
				if (GetUFieldFName(item) == fName)
				{
					return item;
				}
			}
		}
		else
		{
			foreach (IntPtr item2 in new NativeFFieldIterator(typeClass, unrealStruct))
			{
				if (GetFFieldFName(item2) == fName)
				{
					return item2;
				}
			}
		}
		return IntPtr.Zero;
	}

	public static void ValidateBlittableStructSize(IntPtr unrealStruct, Type type)
	{
		FMessage.Assert(GetStructSize(unrealStruct) == Marshal.SizeOf(type), "Blittable struct size mismatch on '" + GetUFieldPathName(unrealStruct) + "'");
	}

	public static bool ValidatePropertyClass(IntPtr unrealStruct, string propertyName, IntPtr propertyClass)
	{
		IntPtr intPtr = FindField(Classes.FProperty, unrealStruct, bFindUField: false, propertyName);
		if (intPtr == IntPtr.Zero || !Native_FField.IsA(intPtr, Classes.FProperty))
		{
			return false;
		}
		IntPtr propertyClassByAddress = FProperty.GetPropertyClassByAddress(intPtr);
		if (propertyClassByAddress == propertyClass)
		{
			return true;
		}
		if (propertyClassByAddress != IntPtr.Zero && propertyClass == Classes.FEnumProperty && FProperty.PropertyIsChildOfNumericProperty(propertyClassByAddress))
		{
			return Native_FNumericProperty.IsEnum(intPtr);
		}
		if (propertyClass == Classes.FMulticastDelegateProperty)
		{
			return true;
		}
		return false;
	}

	public static void LogFunctionIsValid(string functionPath, bool isValid)
	{
	}

	public static void LogStructIsValid(string structPath, bool isValid)
	{
	}

	public static void LogInvalidPropertyAccessed(string propertyPath)
	{
	}

	public static void LogInvalidFunctionAccessed(string functionPath)
	{
	}

	public static void LogInvalidStructAccessed(string structPath)
	{
	}

	public static bool IsA(IntPtr obj, IntPtr unrealClass)
	{
		return Native_UObjectBaseUtility.IsA(obj, unrealClass);
	}

	public static FName MakeUniqueObjectName(ObjectOuter outer, IntPtr unrealClass, FName baseName = default(FName))
	{
		Native_UObjectGlobals.MakeUniqueObjectName(outer.Address, unrealClass, ref baseName, out var result);
		return result;
	}

	public static FName MakeUniqueObjectName(IntPtr outer, IntPtr unrealClass, FName baseName = default(FName))
	{
		Native_UObjectGlobals.MakeUniqueObjectName(outer, unrealClass, ref baseName, out var result);
		return result;
	}

	public static bool IsReferenced(IntPtr res, EObjectFlags keepFlags, EInternalObjectFlags internalKeepFlags, bool checkSubObjects = false)
	{
		return Native_UObjectGlobals.IsReferenced(res, keepFlags, internalKeepFlags, checkSubObjects, IntPtr.Zero);
	}

	public static IntPtr GetTransientPackage()
	{
		return Native_UObjectGlobals.GetTransientPackage();
	}

	public static IntPtr NewObject(IntPtr outer, IntPtr unrealClass, FName name = default(FName), EObjectFlags flags = EObjectFlags.NoFlags, IntPtr template = default(IntPtr), bool copyTransientsFromClassDefaults = false, IntPtr instanceGraph = default(IntPtr))
	{
		if (unrealClass == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (outer == IntPtr.Zero)
		{
			outer = GetTransientPackage();
		}
		if (name == FName.None)
		{
			FObjectInitializer.AssertIfInConstructor(outer);
		}
		return Native_UObjectGlobals.StaticConstructObject_Internal(unrealClass, outer, ref name, flags, EInternalObjectFlags.None, template, copyTransientsFromClassDefaults, instanceGraph);
	}

	public static IntPtr NewFProperty(IntPtr outer, EPropertyType outerType, EPropertyType propertyType, FName name = default(FName), EObjectFlags flags = EObjectFlags.NoFlags)
	{
		if (outer == IntPtr.Zero)
		{
			outer = GetTransientPackage();
		}
		if (name == FName.None)
		{
			FObjectInitializer.AssertIfInConstructor(outer);
		}
		bool bUObjectOuter = ((outerType != EPropertyType.Enum && (uint)(outerType - 23) > 2u) ? true : false);
		EClassCastFlags castFlags = EClassCastFlags.None;
		switch (propertyType)
		{
		case EPropertyType.Bool:
			castFlags = EClassCastFlags.FBoolProperty;
			break;
		case EPropertyType.Int:
			castFlags = EClassCastFlags.FIntProperty;
			break;
		case EPropertyType.Int64:
			castFlags = EClassCastFlags.FInt64Property;
			break;
		case EPropertyType.Byte:
			castFlags = EClassCastFlags.FByteProperty;
			break;
		case EPropertyType.UInt16:
			castFlags = EClassCastFlags.FUInt16Property;
			break;
		case EPropertyType.UInt32:
			castFlags = EClassCastFlags.FUInt32Property;
			break;
		case EPropertyType.UInt64:
			castFlags = EClassCastFlags.FUInt64Property;
			break;
		case EPropertyType.Double:
			castFlags = EClassCastFlags.FDoubleProperty;
			break;
		case EPropertyType.Float:
			castFlags = EClassCastFlags.FFloatProperty;
			break;
		case EPropertyType.Enum:
			castFlags = EClassCastFlags.FEnumProperty;
			break;
		case EPropertyType.Interface:
			castFlags = EClassCastFlags.FInterfaceProperty;
			break;
		case EPropertyType.Struct:
			castFlags = EClassCastFlags.FStructProperty;
			break;
		case EPropertyType.Class:
			castFlags = EClassCastFlags.FClassProperty;
			break;
		case EPropertyType.Object:
			castFlags = EClassCastFlags.FObjectProperty;
			break;
		case EPropertyType.LazyObject:
			castFlags = EClassCastFlags.FLazyObjectProperty;
			break;
		case EPropertyType.WeakObject:
			castFlags = EClassCastFlags.FWeakObjectProperty;
			break;
		case EPropertyType.SoftClass:
			castFlags = EClassCastFlags.FSoftClassProperty;
			break;
		case EPropertyType.SoftObject:
			castFlags = EClassCastFlags.FSoftObjectProperty;
			break;
		case EPropertyType.Delegate:
			castFlags = EClassCastFlags.FDelegateProperty;
			break;
		case EPropertyType.MulticastDelegate:
			castFlags = EClassCastFlags.FMulticastDelegateProperty;
			break;
		case EPropertyType.Array:
			castFlags = EClassCastFlags.FArrayProperty;
			break;
		case EPropertyType.Map:
			castFlags = EClassCastFlags.FMapProperty;
			break;
		case EPropertyType.Set:
			castFlags = EClassCastFlags.FSetProperty;
			break;
		case EPropertyType.Str:
			castFlags = EClassCastFlags.FStrProperty;
			break;
		case EPropertyType.Name:
			castFlags = EClassCastFlags.FNameProperty;
			break;
		case EPropertyType.Text:
			castFlags = EClassCastFlags.FTextProperty;
			break;
		}
		return Native_FProperty.ConstructByCastFlags(outer, bUObjectOuter, castFlags, ref name, flags);
	}

	public static IntPtr DuplicateObject(IntPtr sourceObject, IntPtr outer, FName name = default(FName), EObjectFlags flagMask = EObjectFlags.AllFlags, IntPtr destClass = default(IntPtr), EDuplicateMode duplicateMode = EDuplicateMode.Normal, EInternalObjectFlags internalFlagsMask = EInternalObjectFlags.AllFlags)
	{
		if (sourceObject == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (outer == IntPtr.Zero)
		{
			outer = GetTransientPackage();
		}
		return Native_UObjectGlobals.StaticDuplicateObject(sourceObject, outer, ref name, flagMask, destClass, duplicateMode, internalFlagsMask);
	}

	public static IntPtr FindObjectFast(IntPtr unrealClass, IntPtr outer, FName name, bool exactClass = false, bool anyPackage = false, EObjectFlags exclusiveFlags = EObjectFlags.NoFlags, EInternalObjectFlags exclusiveInternalFlags = EInternalObjectFlags.None)
	{
		return Native_UObjectGlobals.StaticFindObjectFast(unrealClass, outer, ref name, exactClass, anyPackage, exclusiveFlags, exclusiveInternalFlags);
	}

	public static IntPtr FindObject(IntPtr unrealClass, IntPtr outer, string name, bool exactClass = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return Native_UObjectGlobals.StaticFindObject(unrealClass, outer, ref fStringUnsafe.Array, exactClass);
	}

	public static IntPtr FindObjectChecked(IntPtr unrealClass, IntPtr outer, string name, bool exactClass = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return Native_UObjectGlobals.StaticFindObjectChecked(unrealClass, outer, ref fStringUnsafe.Array, exactClass);
	}

	public static IntPtr FindObjectSafe(IntPtr unrealClass, IntPtr outer, string name, bool exactClass = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return Native_UObjectGlobals.StaticFindObjectSafe(unrealClass, outer, ref fStringUnsafe.Array, exactClass);
	}

	public static IntPtr LoadObject(IntPtr unrealClass, IntPtr outer, string name, string filename = null, ELoadFlags loadFlags = ELoadFlags.None)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(filename);
		return Native_UObjectGlobals.StaticLoadObject(unrealClass, outer, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, loadFlags, IntPtr.Zero, true);
	}

	public static IntPtr LoadClass(IntPtr baseClass, IntPtr outer, string name, string filename, ELoadFlags loadFlags = ELoadFlags.None)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(filename);
		return Native_UObjectGlobals.StaticLoadClass(baseClass, outer, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, loadFlags, IntPtr.Zero);
	}

	public static IntPtr GetDefault(IntPtr unrealClass, bool createIfNeeded = true)
	{
		return Native_UClass.GetDefaultObject(unrealClass, createIfNeeded);
	}

	public static IntPtr LoadPackage(IntPtr outer, string longPackageName, ELoadFlags loadFlags)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		return Native_UObjectGlobals.LoadPackage(outer, ref fStringUnsafe.Array, loadFlags);
	}

	public static IntPtr FindPackage(IntPtr outer, string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return Native_UObjectGlobals.FindPackage(outer, ref fStringUnsafe.Array);
	}

	public static IntPtr CreatePackage(string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return Native_UObjectGlobals.CreatePackage(ref fStringUnsafe.Array);
	}

	public static IntPtr StaticAllocateObject(IntPtr unrealClass, IntPtr outer, FName name, out bool outReusedSubobject, EObjectFlags setFlags, EInternalObjectFlags internalSetFlags, bool canReuseSubobjects = false)
	{
		csbool outReusedSubobject2;
		IntPtr result = Native_UObjectGlobals.StaticAllocateObject(unrealClass, outer, ref name, setFlags, internalSetFlags, canReuseSubobjects, out outReusedSubobject2);
		outReusedSubobject = outReusedSubobject2;
		return result;
	}

	public static IntPtr[] GetObjectsWithOuter(IntPtr outer, bool includeNestedObjects = true, EObjectFlags exclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags exclusionInternalFlags = EInternalObjectFlags.None)
	{
		using TArrayUnsafe<IntPtr> tArrayUnsafe = new TArrayUnsafe<IntPtr>();
		Native_UObjectHash.GetObjectsWithOuter(outer, tArrayUnsafe.Address, includeNestedObjects, exclusionFlags, exclusionInternalFlags);
		return tArrayUnsafe.ToArray();
	}

	public static EPropertyType GetPropertyType(IntPtr propertyAddress)
	{
		if (propertyAddress != IntPtr.Zero)
		{
			return GetPropertyClassType(Native_UObjectBase.GetClass(propertyAddress));
		}
		return EPropertyType.Unknown;
	}

	public static EPropertyType GetPropertyClassType(IntPtr propertyClassAddress)
	{
		propertyTypesByClass.TryGetValue(propertyClassAddress, out var value);
		return value;
	}

	public static Type GetPropertyType(EPropertyType propertyType)
	{
		return propertyType switch
		{
			EPropertyType.Bool => typeof(FBoolProperty), 
			EPropertyType.Int8 => typeof(FInt8Property), 
			EPropertyType.Int16 => typeof(FInt16Property), 
			EPropertyType.Int => typeof(FIntProperty), 
			EPropertyType.Int64 => typeof(FInt64Property), 
			EPropertyType.Byte => typeof(FByteProperty), 
			EPropertyType.UInt16 => typeof(FUInt16Property), 
			EPropertyType.UInt32 => typeof(FUInt32Property), 
			EPropertyType.UInt64 => typeof(FUInt64Property), 
			EPropertyType.Double => typeof(FDoubleProperty), 
			EPropertyType.Float => typeof(FFloatProperty), 
			EPropertyType.Enum => typeof(FEnumProperty), 
			EPropertyType.Interface => typeof(FInterfaceProperty), 
			EPropertyType.Struct => typeof(FStructProperty), 
			EPropertyType.Class => typeof(FClassProperty), 
			EPropertyType.Object => typeof(FObjectProperty), 
			EPropertyType.LazyObject => typeof(FLazyObjectProperty), 
			EPropertyType.WeakObject => typeof(FWeakObjectProperty), 
			EPropertyType.SoftClass => typeof(FSoftClassProperty), 
			EPropertyType.SoftObject => typeof(FSoftObjectProperty), 
			EPropertyType.Delegate => typeof(FDelegateProperty), 
			EPropertyType.MulticastDelegate => typeof(FMulticastDelegateProperty), 
			EPropertyType.Array => typeof(FArrayProperty), 
			EPropertyType.Map => typeof(FMapProperty), 
			EPropertyType.Set => typeof(FSetProperty), 
			EPropertyType.Str => typeof(FStrProperty), 
			EPropertyType.Name => typeof(FNameProperty), 
			EPropertyType.Text => typeof(FTextProperty), 
			_ => null, 
		};
	}

	public static IntPtr GetPropertyClass(EPropertyType propertyType)
	{
		return propertyType switch
		{
			EPropertyType.Bool => Classes.FBoolProperty, 
			EPropertyType.Int8 => Classes.FInt8Property, 
			EPropertyType.Int16 => Classes.FInt16Property, 
			EPropertyType.Int => Classes.FIntProperty, 
			EPropertyType.Int64 => Classes.FInt64Property, 
			EPropertyType.Byte => Classes.FByteProperty, 
			EPropertyType.UInt16 => Classes.FUInt16Property, 
			EPropertyType.UInt32 => Classes.FUInt32Property, 
			EPropertyType.UInt64 => Classes.FUInt64Property, 
			EPropertyType.Double => Classes.FDoubleProperty, 
			EPropertyType.Float => Classes.FFloatProperty, 
			EPropertyType.Enum => Classes.FEnumProperty, 
			EPropertyType.Interface => Classes.FInterfaceProperty, 
			EPropertyType.Struct => Classes.FStructProperty, 
			EPropertyType.Class => Classes.FClassProperty, 
			EPropertyType.Object => Classes.FObjectProperty, 
			EPropertyType.LazyObject => Classes.FLazyObjectProperty, 
			EPropertyType.WeakObject => Classes.FWeakObjectProperty, 
			EPropertyType.SoftClass => Classes.FSoftClassProperty, 
			EPropertyType.SoftObject => Classes.FSoftObjectProperty, 
			EPropertyType.Delegate => Classes.FDelegateProperty, 
			EPropertyType.MulticastDelegate => Classes.FMulticastInlineDelegateProperty, 
			EPropertyType.Array => Classes.FArrayProperty, 
			EPropertyType.Map => Classes.FMapProperty, 
			EPropertyType.Set => Classes.FSetProperty, 
			EPropertyType.Str => Classes.FStrProperty, 
			EPropertyType.Name => Classes.FNameProperty, 
			EPropertyType.Text => Classes.FTextProperty, 
			_ => IntPtr.Zero, 
		};
	}

	public static string GetPropertyClassName(EPropertyType propertyType)
	{
		Type propertyType2 = GetPropertyType(propertyType);
		if (!(propertyType2 != null))
		{
			return null;
		}
		return propertyType2.Name;
	}

	public static bool TryGetPropertyClassName(EPropertyType propertyType, out string propertyClassName)
	{
		propertyClassName = GetPropertyClassName(propertyType);
		return !string.IsNullOrEmpty(propertyClassName);
	}

	internal static void OnNativeFunctionsRegistered()
	{
		propertyTypesByClass.Clear();
		propertyTypesByClass[Classes.FBoolProperty] = EPropertyType.Bool;
		propertyTypesByClass[Classes.FInt8Property] = EPropertyType.Int8;
		propertyTypesByClass[Classes.FInt16Property] = EPropertyType.Int16;
		propertyTypesByClass[Classes.FIntProperty] = EPropertyType.Int;
		propertyTypesByClass[Classes.FInt64Property] = EPropertyType.Int64;
		propertyTypesByClass[Classes.FByteProperty] = EPropertyType.Byte;
		propertyTypesByClass[Classes.FUInt16Property] = EPropertyType.UInt16;
		propertyTypesByClass[Classes.FUInt32Property] = EPropertyType.UInt32;
		propertyTypesByClass[Classes.FUInt64Property] = EPropertyType.UInt64;
		propertyTypesByClass[Classes.FDoubleProperty] = EPropertyType.Double;
		propertyTypesByClass[Classes.FFloatProperty] = EPropertyType.Float;
		propertyTypesByClass[Classes.FEnumProperty] = EPropertyType.Enum;
		propertyTypesByClass[Classes.FInterfaceProperty] = EPropertyType.Interface;
		propertyTypesByClass[Classes.FStructProperty] = EPropertyType.Struct;
		propertyTypesByClass[Classes.FClassProperty] = EPropertyType.Class;
		propertyTypesByClass[Classes.FObjectProperty] = EPropertyType.Object;
		propertyTypesByClass[Classes.FLazyObjectProperty] = EPropertyType.LazyObject;
		propertyTypesByClass[Classes.FWeakObjectProperty] = EPropertyType.WeakObject;
		propertyTypesByClass[Classes.FSoftClassProperty] = EPropertyType.SoftClass;
		propertyTypesByClass[Classes.FSoftObjectProperty] = EPropertyType.SoftObject;
		propertyTypesByClass[Classes.FDelegateProperty] = EPropertyType.Delegate;
		propertyTypesByClass[Classes.FMulticastDelegateProperty] = EPropertyType.MulticastDelegate;
		propertyTypesByClass[Classes.FArrayProperty] = EPropertyType.Array;
		propertyTypesByClass[Classes.FMapProperty] = EPropertyType.Map;
		propertyTypesByClass[Classes.FSetProperty] = EPropertyType.Set;
		propertyTypesByClass[Classes.FStrProperty] = EPropertyType.Str;
		propertyTypesByClass[Classes.FNameProperty] = EPropertyType.Name;
		propertyTypesByClass[Classes.FTextProperty] = EPropertyType.Text;
	}

	private static void PrintClassDebugMessage(string ClassPath, string FieldName)
	{
		IntPtr intPtr = GetClass(ClassPath);
		if (intPtr == IntPtr.Zero)
		{
			FMessage.OpenDialog($"class not found {ClassPath}");
			return;
		}
		IntPtr intPtr2 = FindField(Classes.FProperty, intPtr, bFindUField: false, FieldName);
		if (intPtr2 == IntPtr.Zero)
		{
			FMessage.OpenDialog($"field not found {ClassPath} {FieldName}");
			return;
		}
		EPropertyFlags ePropertyFlags = Native_FProperty.Get_PropertyFlags(intPtr2);
		IntPtr intPtr3 = Native_FObjectPropertyBase.Get_PropertyClass(intPtr2);
		FMessage.OpenDialog($"init {ClassPath} {FieldName} {ePropertyFlags.ToString()} {intPtr3.ToString()}");
	}

	public static void PrintDebugPropertyMessage()
	{
		PrintClassDebugMessage("/Script/b1-Managed.BGUPlayerCharacterCSX2", "CameraBoom0");
		PrintClassDebugMessage("/Script/b1-Managed.BGUPlayerCharacterCS", "CameraBoom0");
	}
}
