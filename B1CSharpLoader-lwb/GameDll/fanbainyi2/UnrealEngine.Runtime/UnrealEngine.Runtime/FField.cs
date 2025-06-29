using System;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FField : IEquatable<FField>
{
	private CachedUObject<UClass> ownerClass;

	private CachedUObject<UStruct> ownerStruct;

	private CachedUObject<UPackage> cachedOutermost;

	public IntPtr Address { get; internal set; }

	public FField Next
	{
		get
		{
			return new FField(Native_FField.Get_Next(Address));
		}
		set
		{
			Native_FField.Set_Next(Address, value.Address);
		}
	}

	public UClass OwnerClass => ownerClass.Update(Native_FField.GetOwnerClass(Address));

	public UStruct OwnerStruct => ownerStruct.Update(Native_FField.GetOwnerStruct(Address));

	public string PathName => GetPathName();

	public FField()
	{
		Address = IntPtr.Zero;
	}

	public FField(IntPtr _fieldAddress)
	{
		Address = _fieldAddress;
	}

	public static bool operator ==(FField a, FField b)
	{
		if ((object)a == null)
		{
			if ((object)b == null)
			{
				return true;
			}
			return false;
		}
		return a.Equals(b);
	}

	public static bool operator !=(FField a, FField b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as FField);
	}

	public bool Equals(FField other)
	{
		if ((object)other == null)
		{
			return false;
		}
		return Address.Equals(other.Address);
	}

	public override int GetHashCode()
	{
		return Address.GetHashCode();
	}

	public UPackage GetOutermost()
	{
		return cachedOutermost.Update(Native_FField.GetOutermost(Address));
	}

	public string GetPathName(UObject stopOuter = null)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetPathName(Address, (stopOuter == null) ? IntPtr.Zero : stopOuter.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void AddCppProperty(IntPtr property)
	{
		Native_FField.AddCppProperty(Address, property);
	}

	public void Bind()
	{
		Native_FField.Bind(Address);
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
		if (Native_FField.GetDisplayName == null)
		{
			return null;
		}
		if (Native_FField.GetDisplayName != null)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe())
			{
				Native_FField.GetDisplayName(Address, ref fStringUnsafe.Array);
				return fStringUnsafe.Value;
			}
		}
		return null;
	}

	public string GetToolTip(bool shortTooltip = false)
	{
		if (Native_FField.GetToolTip == null)
		{
			return null;
		}
		if (Native_FField.GetToolTip != null)
		{
			using (FStringUnsafe fStringUnsafe = new FStringUnsafe())
			{
				Native_FField.GetToolTip(Address, ref fStringUnsafe.Array);
				return fStringUnsafe.Value;
			}
		}
		return null;
	}

	public bool HasMetaData(string key)
	{
		if (Native_FField.HasMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.HasMetaData(Address, ref fStringUnsafe.Array);
	}

	public string GetMetaData(string key)
	{
		if (Native_FField.GetMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FField.GetMetaData(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		return fStringUnsafe2.Value;
	}

	public string GetMetaData(FName key)
	{
		if (Native_FField.GetMetaDataF == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetMetaDataF(Address, ref key, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void SetMetaData(string key, string value)
	{
		if (Native_FField.SetMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(value);
		Native_FField.SetMetaData(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public bool GetBoolMetaData(string key)
	{
		if (Native_FField.GetBoolMetaData == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.GetBoolMetaData(Address, ref fStringUnsafe.Array);
	}

	public int GetIntMetaData(string key)
	{
		if (Native_FField.GetINTMetaData == null)
		{
			return 0;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.GetINTMetaData(Address, ref fStringUnsafe.Array);
	}

	public float GetFloatMetaData(string key)
	{
		if (Native_FField.GetFLOATMetaData == null)
		{
			return 0f;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return Native_FField.GetFLOATMetaData(Address, ref fStringUnsafe.Array);
	}

	public UClass GetClassMetaData(string key)
	{
		if (Native_FField.GetClassMetaData == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		return GCHelper.Find<UClass>(Native_FField.GetClassMetaData(Address, ref fStringUnsafe.Array));
	}

	public void RemoveMetaData(string key)
	{
		if (Native_FField.RemoveMetaData == null)
		{
			return;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		Native_FField.RemoveMetaData(Address, ref fStringUnsafe.Array);
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

	public IntPtr GetClass()
	{
		return Native_FField.GetClass(Address);
	}

	public string GetName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FField.GetName(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool IsValid()
	{
		return Native_FField.IsValid(Address);
	}
}
