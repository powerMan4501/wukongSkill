using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FFieldAddress
{
	public IntPtr Address;

	public int Size;

	public int ArrayDim;

	public bool IsEditConst;

	public bool IsBlueprintReadOnly;

	public IntPtr GenericArg1Address;

	public int GenericArg1Size;

	public int GenericArg1ArrayDim;

	public IntPtr GenericArg2Address;

	public int GenericArg2Size;

	public int GenericArg2ArrayDim;

	public EPropertyType PropertyType;

	public string PathName => NativeReflection.GetFFieldPathName(Address);

	public FFieldAddress()
	{
	}

	public FFieldAddress(IntPtr address)
	{
		Update(address);
	}

	public bool Update(IntPtr address)
	{
		if (Address != address)
		{
			Address = address;
			Size = 0;
			ArrayDim = 0;
			IsEditConst = false;
			IsBlueprintReadOnly = false;
			GenericArg1Address = IntPtr.Zero;
			GenericArg1Size = 0;
			GenericArg1ArrayDim = 0;
			GenericArg2Address = IntPtr.Zero;
			GenericArg2Size = 0;
			GenericArg2ArrayDim = 0;
			PropertyType = EPropertyType.Unknown;
			if (address == IntPtr.Zero)
			{
				return true;
			}
			EPropertyType propertyType = NativeReflection.GetPropertyType(address);
			if (propertyType != EPropertyType.Unknown)
			{
				PropertyType = propertyType;
				Size = Native_FProperty.Get_ElementSize(address);
				ArrayDim = Native_FProperty.Get_ArrayDim(address);
				IsEditConst = Native_FProperty.HasAnyPropertyFlags(address, EPropertyFlags.EditConst);
				IsBlueprintReadOnly = Native_FProperty.HasAnyPropertyFlags(address, EPropertyFlags.BlueprintReadOnly);
				switch (propertyType)
				{
				case EPropertyType.Array:
					GenericArg1Address = Native_FArrayProperty.Get_Inner(address);
					if (GenericArg1Address != IntPtr.Zero)
					{
						GenericArg1Size = Native_FProperty.Get_ElementSize(GenericArg1Address);
						GenericArg1ArrayDim = Native_FProperty.Get_ArrayDim(GenericArg1Address);
					}
					break;
				case EPropertyType.Map:
					GenericArg1Address = Native_FMapProperty.Get_KeyProp(address);
					if (GenericArg1Address != IntPtr.Zero)
					{
						GenericArg1Size = Native_FProperty.Get_ElementSize(GenericArg1Address);
						GenericArg1ArrayDim = Native_FProperty.Get_ArrayDim(GenericArg1Address);
					}
					GenericArg2Address = Native_FMapProperty.Get_ValueProp(address);
					if (GenericArg2Address != IntPtr.Zero)
					{
						GenericArg2Size = Native_FProperty.Get_ElementSize(GenericArg2Address);
						GenericArg2ArrayDim = Native_FProperty.Get_ArrayDim(GenericArg2Address);
					}
					break;
				case EPropertyType.Set:
					GenericArg1Address = Native_FSetProperty.Get_ElementProp(address);
					if (GenericArg1Address != IntPtr.Zero)
					{
						GenericArg1Size = Native_FProperty.Get_ElementSize(GenericArg1Address);
						GenericArg1ArrayDim = Native_FProperty.Get_ArrayDim(GenericArg1Address);
					}
					break;
				}
			}
			return true;
		}
		return false;
	}
}
