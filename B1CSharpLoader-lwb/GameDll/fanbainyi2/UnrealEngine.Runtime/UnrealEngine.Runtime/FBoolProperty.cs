using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.BoolProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FBoolProperty : FProperty, IPropertyAccessor<bool>
{
	private PropertyAccessor<bool> accessor;

	public override EPropertyType PropertyType => EPropertyType.Bool;

	public PropertyAccessor<bool> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<bool>(this);
		}
	}

	public FBoolProperty()
	{
	}

	public FBoolProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public bool GetValuePtr(IntPtr address)
	{
		return Native_FBoolProperty.GetPropertyValue(base.Address, address);
	}

	public void SetValuePtr(IntPtr address, bool value)
	{
		Native_FBoolProperty.SetPropertyValue(base.Address, address, value);
	}
}
