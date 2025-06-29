using System;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Field", "CoreUObject", UnrealModuleType.Engine)]
public class UField : UObject
{
	private CachedUObject<UField> next;

	private CachedUObject<UClass> ownerClass;

	private CachedUObject<UStruct> ownerStruct;

	public UField Next
	{
		get
		{
			return next.Update(Native_UField.Get_Next(base.Address));
		}
		set
		{
			Native_UField.Set_Next(base.Address, next.Set(value));
		}
	}

	public UClass OwnerClass => ownerClass.Update(Native_UField.GetOwnerClass(base.Address));

	public UStruct OwnerStruct => ownerStruct.Update(Native_UField.GetOwnerStruct(base.Address));

	public void AddCppProperty(IntPtr property)
	{
		Native_UField.AddCppProperty(base.Address, property);
	}

	public void Bind()
	{
		Native_UField.Bind(base.Address);
	}

	public UClass GetOwnerClass()
	{
		return OwnerClass;
	}

	public UStruct GetOwnerStruct()
	{
		return OwnerStruct;
	}

	public string GetDisplayName()
	{
		if (Native_UField.GetDisplayName == null)
		{
			return null;
		}
		if (Native_UField.GetDisplayName != null)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe())
			{
				Native_UField.GetDisplayName(base.Address, ref fStringUnsafe.Array);
				return fStringUnsafe.Value;
			}
		}
		return null;
	}

	public string GetToolTip(bool shortTooltip = false)
	{
		if (Native_UField.GetToolTip == null)
		{
			return null;
		}
		if (Native_UField.GetToolTip != null)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe())
			{
				Native_UField.GetToolTip(base.Address, ref fStringUnsafe.Array);
				return fStringUnsafe.Value;
			}
		}
		return null;
	}

	public bool HasMetaData(string key)
	{
		if (Native_UField.HasMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UField.HasMetaData(base.Address, ref fStringUnsafe.Array);
	}

	public string GetMetaData(string key)
	{
		if (Native_UField.GetMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_UField.GetMetaData(base.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public string GetMetaData(FName key)
	{
		if (Native_UField.GetMetaDataF == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UField.GetMetaDataF(base.Address, ref key, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void SetMetaData(string key, string value)
	{
		if (Native_UField.SetMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(value);
		Native_UField.SetMetaData(base.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public bool GetBoolMetaData(string key)
	{
		if (Native_UField.GetBoolMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UField.GetBoolMetaData(base.Address, ref fStringUnsafe.Array);
	}

	public int GetIntMetaData(string key)
	{
		if (Native_UField.GetINTMetaData == null)
		{
			return 0;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UField.GetINTMetaData(base.Address, ref fStringUnsafe.Array);
	}

	public float GetFloatMetaData(string key)
	{
		if (Native_UField.GetFLOATMetaData == null)
		{
			return 0f;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_UField.GetFLOATMetaData(base.Address, ref fStringUnsafe.Array);
	}

	public UClass GetClassMetaData(string key)
	{
		if (Native_UField.GetClassMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return GCHelper.Find<UClass>(Native_UField.GetClassMetaData(base.Address, ref fStringUnsafe.Array));
	}

	public void RemoveMetaData(string key)
	{
		if (Native_UField.RemoveMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		Native_UField.RemoveMetaData(base.Address, ref fStringUnsafe.Array);
	}

	public string[] GetCommaSeperatedMetaData(string key)
	{
		List<string> list = new List<string>();
		string metaData = GetMetaData(key);
		if (!string.IsNullOrEmpty(metaData))
		{
			string[] array = metaData.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
		}
		return list.ToArray();
	}
}
