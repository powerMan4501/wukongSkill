using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.MetaData", "CoreUObject", UnrealModuleType.Engine)]
public class UMetaData : UObject
{
	public string GetValue(UObject obj, string key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_UMetaData.GetValue(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public string GetValue(UObject obj, FName key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UMetaData.GetValueFName(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref key, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool HasValue(UObject obj, string key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UMetaData.HasValue(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref fStringUnsafe.Array);
	}

	public bool HasValue(UObject obj, FName key)
	{
		return Native_UMetaData.HasValueFName(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref key);
	}

	public bool HasObjectValues(UObject obj)
	{
		return Native_UMetaData.HasObjectValues(base.Address, (obj == null) ? IntPtr.Zero : obj.Address);
	}

	public void SetObjectValues(UObject obj, Dictionary<FName, string> value)
	{
		using TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>();
		using TArrayUnsafe<string> tArrayUnsafe2 = new TArrayUnsafe<string>();
		tArrayUnsafe.AddRange(value.Keys.ToArray());
		tArrayUnsafe2.AddRange(value.Values.ToArray());
		Native_UMetaData.SetObjectValues(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, tArrayUnsafe.Address, tArrayUnsafe2.Address);
	}

	public void SetValue(UObject obj, string key, string value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(value);
		Native_UMetaData.SetValue(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public void SetValue(UObject obj, FName key, string value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
		Native_UMetaData.SetValueFName(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref key, ref fStringUnsafe.Array);
	}

	public void RemoveValue(UObject obj, string key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		Native_UMetaData.RemoveValue(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref fStringUnsafe.Array);
	}

	public void RemoveValue(UObject obj, FName key)
	{
		Native_UMetaData.RemoveValueFName(base.Address, (obj == null) ? IntPtr.Zero : obj.Address, ref key);
	}

	public static Dictionary<FName, string> GetMapForObject(UObject obj)
	{
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		using (TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>())
		{
			using TArrayUnsafe<string> tArrayUnsafe2 = new TArrayUnsafe<string>();
			Native_UMetaData.GetMapForObject((obj == null) ? IntPtr.Zero : obj.Address, tArrayUnsafe.Address, tArrayUnsafe2.Address);
			if (tArrayUnsafe.Count == tArrayUnsafe2.Count)
			{
				int count = tArrayUnsafe.Count;
				for (int i = 0; i < count; i++)
				{
					dictionary[tArrayUnsafe[i]] = tArrayUnsafe2[i];
				}
			}
		}
		return dictionary;
	}

	public static void CopyMetadata(UObject sourceObject, UObject destObject)
	{
		Native_UMetaData.CopyMetadata((sourceObject == null) ? IntPtr.Zero : sourceObject.Address, (destObject == null) ? IntPtr.Zero : destObject.Address);
	}

	public void RemoveMetaDataOutsidePackage()
	{
		Native_UMetaData.RemoveMetaDataOutsidePackage(base.Address);
	}
}
