using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class NativeReflectionCached
{
	private struct CachedFieldInfo
	{
		public IntPtr Address;

		public int Offset;
	}

	private static Dictionary<string, CachedFieldInfo> lastUnrealStructChildren = new Dictionary<string, CachedFieldInfo>();

	private static IntPtr lastUnrealStruct;

	private static Dictionary<string, CachedFieldInfo> lastUnrealFunctionChildren = new Dictionary<string, CachedFieldInfo>();

	private static IntPtr lastUnrealFunction;

	private static FStringUnsafe nameUnsafe = new FStringUnsafe();

	public static void Clear()
	{
		lastUnrealStructChildren.Clear();
		lastUnrealFunctionChildren.Clear();
		lastUnrealStruct = IntPtr.Zero;
		lastUnrealFunction = IntPtr.Zero;
	}

	public static IntPtr GetFunction(IntPtr unrealClass, string functionName)
	{
		return FindField(Classes.UFunction, unrealClass, bFindUField: true, functionName);
	}

	public static IntPtr GetProperty(IntPtr unrealStruct, string propertyName)
	{
		if (unrealStruct == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return FindField(unrealStruct, propertyName);
	}

	public static bool GetPropertyRef(ref FFieldAddress property, IntPtr unrealStruct, string propertyName)
	{
		if (property == null)
		{
			property = new FFieldAddress();
		}
		return property.Update(GetProperty(unrealStruct, propertyName));
	}

	public static int GetPropertyOffset(IntPtr unrealStruct, string propertyName)
	{
		if (FindFieldInfo(Classes.FProperty, unrealStruct, bFindUField: true, propertyName, out var fieldInfo))
		{
			return fieldInfo.Offset;
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

	public static ushort GetPropertyRepIndex(IntPtr unrealStruct, string propertyName)
	{
		IntPtr intPtr = FindField(unrealStruct, propertyName);
		if (!(intPtr == IntPtr.Zero))
		{
			return Native_FProperty.Get_RepIndex(intPtr);
		}
		return 0;
	}

	public static IntPtr FindField(IntPtr unrealStruct, FName fieldName)
	{
		if (fieldName == FName.None)
		{
			return IntPtr.Zero;
		}
		return FindField(unrealStruct, fieldName.ToString());
	}

	public static IntPtr FindField(IntPtr typeClass, IntPtr unrealStruct, bool bFindUField, FName fieldName)
	{
		if (fieldName == FName.None)
		{
			return IntPtr.Zero;
		}
		return FindField(typeClass, unrealStruct, bFindUField, fieldName.ToString());
	}

	public static IntPtr FindField(IntPtr unrealStruct, string fieldName)
	{
		return FindField(Classes.FProperty, unrealStruct, bFindUField: false, fieldName);
	}

	public static IntPtr FindField(IntPtr typeClass, IntPtr unrealStruct, bool bFindUField, string fieldName)
	{
		if (FindFieldInfo(typeClass, unrealStruct, bFindUField, fieldName, out var fieldInfo))
		{
			return fieldInfo.Address;
		}
		return IntPtr.Zero;
	}

	private static bool FindFieldInfo(IntPtr typeClass, IntPtr unrealStruct, bool bFindUField, string fieldName, out CachedFieldInfo fieldInfo)
	{
		string text = StringParseHelper.SafeToLower(fieldName);
		if (typeClass == IntPtr.Zero || unrealStruct == IntPtr.Zero || string.IsNullOrEmpty(text))
		{
			fieldInfo = default(CachedFieldInfo);
			return false;
		}
		if (unrealStruct == lastUnrealStruct)
		{
			return lastUnrealStructChildren.TryGetValue(text, out fieldInfo);
		}
		if (unrealStruct == lastUnrealFunction)
		{
			return lastUnrealFunctionChildren.TryGetValue(text, out fieldInfo);
		}
		Dictionary<string, CachedFieldInfo> dictionary = null;
		bool includeSuper = false;
		if ((bool)Native_UObjectBaseUtility.IsA(unrealStruct, Classes.UFunction))
		{
			dictionary = lastUnrealFunctionChildren;
			lastUnrealFunction = unrealStruct;
		}
		else
		{
			includeSuper = Native_UObjectBaseUtility.IsA(unrealStruct, Classes.UScriptStruct);
			dictionary = lastUnrealStructChildren;
			lastUnrealStruct = unrealStruct;
		}
		dictionary.Clear();
		foreach (IntPtr item in new NativeReflection.NativeFFieldIterator(32768uL, unrealStruct, allFieldTypeClassCastFlags: false, includeSuper))
		{
			Native_FField.GetNameOut(item, ref nameUnsafe.Array);
			string key = StringParseHelper.SafeToLower(nameUnsafe.Value);
			_ = Debugger.IsAttached;
			dictionary[key] = new CachedFieldInfo
			{
				Address = item,
				Offset = Native_FProperty.GetOffset_ForInternal(item)
			};
		}
		foreach (IntPtr item2 in new NativeReflection.NativeUFieldIterator(EClassCastFlags.UFunction, unrealStruct, allFieldTypeClassCastFlags: false, includeSuper))
		{
			Native_UObjectBaseUtility.GetNameOut(item2, ref nameUnsafe.Array);
			string key2 = StringParseHelper.SafeToLower(nameUnsafe.Value);
			_ = Debugger.IsAttached;
			dictionary[key2] = new CachedFieldInfo
			{
				Address = item2,
				Offset = Native_FProperty.GetOffset_ForInternal(item2)
			};
		}
		return dictionary.TryGetValue(text, out fieldInfo);
	}

	public static bool ValidatePropertyClass(IntPtr unrealStruct, string propertyName, IntPtr propertyClass)
	{
		IntPtr intPtr = FindField(unrealStruct, propertyName);
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
}
