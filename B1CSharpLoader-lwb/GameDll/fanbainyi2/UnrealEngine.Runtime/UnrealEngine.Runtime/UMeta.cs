using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

internal class UMeta
{
	public enum Target
	{
		Class,
		Interface,
		Enum,
		Struct,
		Property,
		Delegate,
		Function
	}

	private static void ValidateKeyEnum<TEnum>() where TEnum : struct
	{
		if (!typeof(TEnum).IsEnum)
		{
			throw new Exception("Using metadata enum functions on a non-enum type! " + typeof(TEnum).FullName);
		}
	}

	public static string GetGroup<TEnum>() where TEnum : struct
	{
		return typeof(TEnum).Name;
	}

	public static FName GetKeyName<TEnum>(TEnum key) where TEnum : struct
	{
		ValidateKeyEnum<TEnum>();
		return new FName(key.ToString());
	}

	public static string GetKey<TEnum>(TEnum key) where TEnum : struct
	{
		ValidateKeyEnum<TEnum>();
		return key.ToString();
	}

	public static TEnum ParseKey<TEnum>(string key) where TEnum : struct
	{
		ValidateKeyEnum<TEnum>();
		Enum.TryParse<TEnum>(key, out var result);
		return result;
	}

	private static IntPtr GetMetaDataFromObj(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = Native_UObjectBaseUtility.GetOutermost(obj);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		return Native_UPackage.GetMetaData(intPtr);
	}

	public static bool HasMetaData(IntPtr obj, string key)
	{
		IntPtr metaDataFromObj = GetMetaDataFromObj(obj);
		if (metaDataFromObj != IntPtr.Zero)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe(key))
			{
				return Native_UMetaData.HasValue(metaDataFromObj, obj, ref fStringUnsafe.Array);
			}
		}
		return false;
	}

	public static bool HasMetaData<TEnum>(IntPtr obj, TEnum key) where TEnum : struct
	{
		return HasMetaData(obj, GetKey(key));
	}

	public static void SetMetaData<T>(IntPtr obj, string key, T value)
	{
		UClass uClass = value as UClass;
		if (uClass != null)
		{
			uClass.GetPathName();
		}
		else
		{
			value.ToString();
		}
		IntPtr metaDataFromObj = GetMetaDataFromObj(obj);
		if (!(metaDataFromObj != IntPtr.Zero))
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(key);
		Native_UMetaData.SetValue(metaDataFromObj, obj, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static void SetMetaData<TEnum, T>(IntPtr obj, TEnum key, T value) where TEnum : struct
	{
		SetMetaData(obj, GetKey(key), value);
	}

	public static void RemoveMetaData<TEnum>(IntPtr obj, TEnum key) where TEnum : struct
	{
		RemoveMetaData(obj, GetKey(key));
	}

	public static void RemoveMetaData(IntPtr obj, string key)
	{
		IntPtr metaDataFromObj = GetMetaDataFromObj(obj);
		if (metaDataFromObj != IntPtr.Zero)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe(key))
			{
				Native_UMetaData.RemoveValue(metaDataFromObj, obj, ref fStringUnsafe.Array);
			}
		}
	}
}
