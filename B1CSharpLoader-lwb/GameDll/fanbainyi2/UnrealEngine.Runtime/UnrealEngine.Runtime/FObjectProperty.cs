using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ObjectProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FObjectProperty : FObjectPropertyBase, IPropertyAccessor<UObject>
{
	private PropertyAccessor<UObject> accessor;

	public override EPropertyType PropertyType => EPropertyType.Object;

	public PropertyAccessor<UObject> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<UObject>(this);
		}
	}

	public FObjectProperty()
	{
	}

	public FObjectProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public UObject GetValuePtr(IntPtr address)
	{
		return GCHelper.Find<UObject>(Marshal.ReadIntPtr(address));
	}

	public void SetValuePtr(IntPtr address, UObject value)
	{
		Marshal.WriteIntPtr(address, (value == null) ? IntPtr.Zero : value.Address);
	}
}
