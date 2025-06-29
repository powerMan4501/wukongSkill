using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Enum", "CoreUObject", UnrealModuleType.Engine)]
public class UEnum : UField
{
	public enum ECppForm
	{
		Regular,
		Namespaced,
		EnumClass
	}

	public enum EGetByNameFlags
	{
		None,
		ErrorIfNotFound,
		CaseSensitive
	}

	public string CppType
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_UEnum.Get_CppType(base.Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_UEnum.Set_CppType(base.Address, ref fStringUnsafe.Array);
		}
	}

	public static IntPtr GetEnumAddress(string path)
	{
		IntPtr intPtr = NativeReflection.FindObject(Classes.UEnum, IntPtr.Zero, path);
		if (intPtr == IntPtr.Zero)
		{
			FName fName = FLinkerLoad.FindNewNameForEnum(new FName(path));
			if (fName != FName.None)
			{
				intPtr = NativeReflection.FindObject(Classes.UEnum, IntPtr.Zero, fName.ToString());
			}
		}
		return intPtr;
	}

	public static UEnum GetEnum(string path)
	{
		IntPtr enumAddress = GetEnumAddress(path);
		if (enumAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UEnum>(enumAddress);
		}
		return null;
	}

	public static IntPtr GetEnumAddress<T>() where T : struct, IConvertible
	{
		return GetEnumAddress(typeof(T));
	}

	public static IntPtr GetEnumAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetEnumAddress(type);
			}
			return GetEnumAddress(pathAttribute.Path);
		}
		return IntPtr.Zero;
	}

	public static UEnum GetEnum<T>() where T : struct, IConvertible
	{
		return GetEnum(typeof(T));
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

	public static IntPtr LoadEnumAddress(string path)
	{
		return NativeReflection.LoadObject(Classes.UEnum, IntPtr.Zero, path);
	}

	public static UEnum LoadEnum(string path)
	{
		IntPtr intPtr = LoadEnumAddress(path);
		if (intPtr != IntPtr.Zero)
		{
			return GCHelper.Find<UEnum>(intPtr);
		}
		return null;
	}

	public static IntPtr LoadEnumAddress<T>() where T : struct, IConvertible
	{
		return LoadEnumAddress(typeof(T));
	}

	public static IntPtr LoadEnumAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetEnumAddress(type);
			}
			return LoadEnumAddress(pathAttribute.Path);
		}
		return IntPtr.Zero;
	}

	public static UEnum LoadEnum<T>() where T : struct, IConvertible
	{
		return LoadEnum(typeof(T));
	}

	public static UEnum LoadEnum(Type type)
	{
		IntPtr intPtr = LoadEnumAddress(type);
		if (intPtr != IntPtr.Zero)
		{
			return GCHelper.Find<UEnum>(intPtr);
		}
		return null;
	}

	public static IntPtr ResolveEnumAddress(string path)
	{
		IntPtr intPtr = GetEnumAddress(path);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadEnumAddress(path);
		}
		return intPtr;
	}

	public static UEnum ResolveEnum(string path)
	{
		UEnum uEnum = GetEnum(path);
		if (uEnum == null)
		{
			uEnum = LoadEnum(path);
		}
		return uEnum;
	}

	public static IntPtr ResolveEnumAddress<T>() where T : struct, IConvertible
	{
		IntPtr intPtr = GetEnumAddress(typeof(T));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadEnumAddress(typeof(T));
		}
		return intPtr;
	}

	public static IntPtr ResolveEnumAddress(Type type)
	{
		IntPtr intPtr = GetEnumAddress(type);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadEnumAddress(type);
		}
		return intPtr;
	}

	public static UEnum ResolveEnum<T>() where T : struct, IConvertible
	{
		UEnum uEnum = GetEnum<T>();
		if (uEnum == null)
		{
			uEnum = LoadEnum<T>();
		}
		return uEnum;
	}

	public static UEnum ResolveEnum(Type type)
	{
		UEnum uEnum = GetEnum(type);
		if (uEnum == null)
		{
			uEnum = LoadEnum(type);
		}
		return uEnum;
	}

	public int GetIndexByValue(long value)
	{
		return Native_UEnum.GetIndexByValue(base.Address, value);
	}

	public long GetValueByIndex(int index)
	{
		return Native_UEnum.GetValueByIndex(base.Address, index);
	}

	public FName GetNameByIndex(int index)
	{
		Native_UEnum.GetNameByIndex(base.Address, index, out var result);
		return result;
	}

	public int GetIndexByName(FName name, EGetByNameFlags flags = EGetByNameFlags.None)
	{
		return Native_UEnum.GetIndexByName(base.Address, ref name, flags);
	}

	public FName GetNameByValue(long value)
	{
		Native_UEnum.GetNameByValue(base.Address, value, out var result);
		return result;
	}

	public int GetValueByName(FName name, EGetByNameFlags flags = EGetByNameFlags.None)
	{
		return Native_UEnum.GetValueByName(base.Address, ref name, flags);
	}

	public string GetNameStringByIndex(int index)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GetNameStringByIndex(base.Address, index, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public int GetIndexByNameString(string searchString, EGetByNameFlags flags = EGetByNameFlags.None)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(searchString);
		return Native_UEnum.GetIndexByNameString(base.Address, ref fStringUnsafe.Array, flags);
	}

	public string GetNameStringByValue(long value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GetNameStringByValue(base.Address, value, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public long GetValueByNameString(string searchString, EGetByNameFlags flags = EGetByNameFlags.None)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(searchString);
		return Native_UEnum.GetValueByNameString(base.Address, ref fStringUnsafe.Array, flags);
	}

	public string GetDisplayNameTextStringByIndex(int index)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GetDisplayNameTextStringByIndex(base.Address, index, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string GetDisplayNameTextStringByValue(long value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GetDisplayNameTextStringByValue(base.Address, value, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public long GetMaxEnumValue()
	{
		return Native_UEnum.GetMaxEnumValue(base.Address);
	}

	public bool IsValidEnumValue(long value)
	{
		return Native_UEnum.IsValidEnumValue(base.Address, value);
	}

	public bool IsValidEnumName(FName name)
	{
		return Native_UEnum.IsValidEnumName(base.Address, ref name);
	}

	public void RemoveNamesFromMasterList()
	{
		Native_UEnum.RemoveNamesFromMasterList(base.Address);
	}

	public ECppForm GetCppForm()
	{
		return Native_UEnum.GetCppForm(base.Address);
	}

	public static bool IsFullEnumName(string inEnumName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inEnumName);
		return Native_UEnum.IsFullEnumName(ref fStringUnsafe.Array);
	}

	public string GenerateFullEnumName(string inEnumName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(inEnumName);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_UEnum.GenerateFullEnumName(base.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public bool SetEnums(Dictionary<FName, long> names, ECppForm inCppForm, bool addMaxKeyIfMissing = true)
	{
		using TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>();
		using TArrayUnsafe<long> tArrayUnsafe2 = new TArrayUnsafe<long>();
		tArrayUnsafe.AddRange(names.Keys.ToArray());
		tArrayUnsafe2.AddRange(names.Values.ToArray());
		return Native_UEnum.SetEnums(base.Address, tArrayUnsafe.Address, tArrayUnsafe2.Address, inCppForm, addMaxKeyIfMissing);
	}

	public int NumEnums()
	{
		return Native_UEnum.NumEnums(base.Address);
	}

	public string GenerateEnumPrefix()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GenerateEnumPrefix(base.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string GetToolTipByIndex(int nameIndex)
	{
		if (Native_UEnum.GetToolTipByIndex == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UEnum.GetToolTipByIndex(base.Address, nameIndex, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool HasMetaData(string key, int nameIndex = -1)
	{
		if (Native_UEnum.HasMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UEnum.HasMetaData(base.Address, ref fStringUnsafe.Array, nameIndex);
	}

	public string GetMetaData(string key, int nameIndex = -1)
	{
		if (Native_UEnum.GetMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_UEnum.GetMetaData(base.Address, ref fStringUnsafe.Array, nameIndex, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public void SetMetaData(string key, string value, int nameIndex = -1)
	{
		if (Native_UEnum.SetMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(value);
		Native_UEnum.SetMetaData(base.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, nameIndex);
	}

	public void RemoveMetaData(string key, int nameIndex = -1)
	{
		if (Native_UEnum.RemoveMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		Native_UEnum.RemoveMetaData(base.Address, ref fStringUnsafe.Array, nameIndex);
	}

	public Dictionary<FName, long> GetValues()
	{
		Dictionary<FName, long> dictionary = new Dictionary<FName, long>();
		int num = NumEnums() - 1;
		for (int i = 0; i < num; i++)
		{
			dictionary[GetNameByIndex(i)] = GetValueByIndex(i);
		}
		return dictionary;
	}
}
