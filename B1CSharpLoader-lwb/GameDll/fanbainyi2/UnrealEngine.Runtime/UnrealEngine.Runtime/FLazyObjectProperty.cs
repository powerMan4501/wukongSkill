using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.LazyObjectProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FLazyObjectProperty : FObjectPropertyBase, IPropertyAccessor<FLazyObjectPtr>
{
	private PropertyAccessor<FLazyObjectPtr> accessor;

	public override EPropertyType PropertyType => EPropertyType.LazyObject;

	public PropertyAccessor<FLazyObjectPtr> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FLazyObjectPtr>(this);
		}
	}

	public FLazyObjectProperty()
	{
	}

	public FLazyObjectProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public FLazyObjectPtr GetValuePtr(IntPtr address)
	{
		return Marshal.PtrToStructure<FLazyObjectPtr>(address);
	}

	public void SetValuePtr(IntPtr address, FLazyObjectPtr value)
	{
		FLazyObjectPtr structure = Marshal.PtrToStructure<FLazyObjectPtr>(address);
		structure.Copy(value);
		Marshal.StructureToPtr(structure, address, fDeleteOld: false);
	}
}
