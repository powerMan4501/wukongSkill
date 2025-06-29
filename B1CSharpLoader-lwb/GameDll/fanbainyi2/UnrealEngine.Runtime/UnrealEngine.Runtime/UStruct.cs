using System;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Struct", "CoreUObject", UnrealModuleType.Engine)]
public class UStruct : UField
{
	private CachedUObject<UField> children;

	private CachedUObject<UStruct> superStruct;

	public UField Children
	{
		get
		{
			return children.Update(Native_UStruct.Get_Children(base.Address));
		}
		set
		{
			Native_UStruct.Set_Children(base.Address, children.Set(value));
		}
	}

	public IntPtr ChildProperties
	{
		get
		{
			return Native_UStruct.Get_ChildProperties(base.Address);
		}
		set
		{
			Native_UStruct.Set_ChildProperties(base.Address, value);
		}
	}

	public int PropertiesSize
	{
		get
		{
			return Native_UStruct.Get_PropertiesSize(base.Address);
		}
		set
		{
			Native_UStruct.Set_PropertiesSize(base.Address, value);
		}
	}

	public int MinAlignment
	{
		get
		{
			return Native_UStruct.Get_MinAlignment(base.Address);
		}
		set
		{
			Native_UStruct.Set_MinAlignment(base.Address, value);
		}
	}

	public byte[] Script
	{
		get
		{
			IntPtr intPtr = Native_UStruct.Get_Script(base.Address);
			if (intPtr != IntPtr.Zero)
			{
				return new TArrayUnsafeRef<byte>(intPtr).ToArray();
			}
			return null;
		}
		set
		{
			using TArrayUnsafe<byte> tArrayUnsafe = new TArrayUnsafe<byte>();
			tArrayUnsafe.AddRange(value);
			Native_UStruct.Set_Script(base.Address, tArrayUnsafe.Address);
		}
	}

	public IntPtr PropertyLink
	{
		get
		{
			return Native_UStruct.Get_PropertyLink(base.Address);
		}
		set
		{
			Native_UStruct.Set_PropertyLink(base.Address, value);
		}
	}

	public IntPtr RefLink
	{
		get
		{
			return Native_UStruct.Get_RefLink(base.Address);
		}
		set
		{
			Native_UStruct.Set_RefLink(base.Address, value);
		}
	}

	public IntPtr DestructorLink
	{
		get
		{
			return Native_UStruct.Get_DestructorLink(base.Address);
		}
		set
		{
			Native_UStruct.Set_DestructorLink(base.Address, value);
		}
	}

	public IntPtr PostConstructLink
	{
		get
		{
			return Native_UStruct.Get_PostConstructLink(base.Address);
		}
		set
		{
			Native_UStruct.Set_PostConstructLink(base.Address, value);
		}
	}

	public UObject[] ScriptObjectReferences
	{
		get
		{
			IntPtr intPtr = Native_UStruct.Get_ScriptObjectReferences(base.Address);
			if (intPtr != IntPtr.Zero)
			{
				return new TArrayUnsafeRef<UObject>(intPtr).ToArray();
			}
			return null;
		}
		set
		{
			using TArrayUnsafe<UObject> tArrayUnsafe = new TArrayUnsafe<UObject>();
			tArrayUnsafe.AddRange(value);
			Native_UStruct.Set_ScriptObjectReferences(base.Address, tArrayUnsafe.Address);
		}
	}

	public UStruct SuperStruct
	{
		get
		{
			return superStruct.Update(Native_UStruct.GetSuperStruct(base.Address));
		}
		set
		{
			Native_UStruct.SetSuperStruct(base.Address, superStruct.Set(value));
		}
	}

	public UStruct GetSuperStruct()
	{
		return SuperStruct;
	}

	public IntPtr FindPropertyByName(FName name)
	{
		return Native_UStruct.FindPropertyByName(base.Address, ref name);
	}

	public UStruct GetInheritanceSuper()
	{
		return GCHelper.Find<UStruct>(Native_UStruct.GetInheritanceSuper(base.Address));
	}

	public void StaticLink(bool relinkExistingProperties)
	{
		Native_UStruct.StaticLink(base.Address, relinkExistingProperties);
	}

	public void TagSubobjects(EObjectFlags newFlags)
	{
		Native_UStruct.TagSubobjects(base.Address, newFlags);
	}

	public void InitializeStruct(IntPtr dest, int arrayDim)
	{
		Native_UStruct.InitializeStruct(base.Address, dest, arrayDim);
	}

	public void DestroyStruct(IntPtr dest, int arrayDim)
	{
		Native_UStruct.DestroyStruct(base.Address, dest, arrayDim);
	}

	public string GetPrefixCPP()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UStruct.GetPrefixCPP(base.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public int GetStructureSize()
	{
		return Native_UStruct.GetStructureSize(base.Address);
	}

	public int GetStructSize()
	{
		UScriptStruct uScriptStruct = this as UScriptStruct;
		if (uScriptStruct != null)
		{
			IntPtr intPtr = Native_UScriptStruct.GetCppStructOps(uScriptStruct.Address);
			if (intPtr != IntPtr.Zero)
			{
				return Native_ICppStructOps.GetSize(intPtr);
			}
		}
		return GetStructureSize();
	}

	public bool IsChildOf<T>() where T : UObject
	{
		return IsChildOf(UClass.GetClass<T>());
	}

	public bool IsChildOf(Type type)
	{
		return IsChildOf(UClass.GetClass(type));
	}

	public bool IsChildOf(UStruct someBase)
	{
		if (someBase == null)
		{
			return false;
		}
		return Native_UStruct.IsChildOf(base.Address, someBase.Address);
	}

	public bool GetBoolMetaDataHierarchical(FName key)
	{
		if (Native_UStruct.GetBoolMetaDataHierarchical == null)
		{
			return false;
		}
		return Native_UStruct.GetBoolMetaDataHierarchical(base.Address, ref key);
	}

	public bool GetStringMetaDataHierarchical(FName key, ref string outValue)
	{
		if (Native_UStruct.GetStringMetaDataHierarchical == null)
		{
			return false;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(outValue);
		bool result = Native_UStruct.GetStringMetaDataHierarchical(base.Address, ref key, ref fStringUnsafe.Array);
		outValue = fStringUnsafe.Value;
		return result;
	}

	public T FindField<T>(FName fieldName) where T : FProperty
	{
		if (fieldName == FName.None)
		{
			return null;
		}
		foreach (T item in new TFFieldIterator<T>(this))
		{
			if (item.GetName() == fieldName.ToString())
			{
				return item;
			}
		}
		return null;
	}

	public T FindField<T>(string fieldName) where T : FProperty
	{
		return FindField<T>(new FName(fieldName));
	}

	public TUFieldIterator<T> GetUFields<T>(bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false) where T : UObject
	{
		return new TUFieldIterator<T>(this, includeSuper, includeDeprecated, includeInterface);
	}

	public TFFieldIterator<T> GetFFields<T>(bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false) where T : FProperty
	{
		return new TFFieldIterator<T>(this, includeSuper, includeDeprecated, includeInterface);
	}
}
