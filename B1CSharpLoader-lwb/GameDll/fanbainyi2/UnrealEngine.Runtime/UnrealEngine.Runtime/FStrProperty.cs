using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.StrProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FStrProperty : FProperty, IPropertyAccessor<string>
{
	private PropertyAccessor<string> accessor;

	public override EPropertyType PropertyType => EPropertyType.Str;

	public PropertyAccessor<string> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<string>(this);
		}
	}

	public FStrProperty()
	{
	}

	public FStrProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public string GetValuePtr(IntPtr address)
	{
		return FStringMarshaler.FromPtr(address);
	}

	public void SetValuePtr(IntPtr address, string value)
	{
		FStringMarshaler.ToArray(address, value);
	}
}
