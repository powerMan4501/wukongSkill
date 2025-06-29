using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Int8Property", "CoreUObject", UnrealModuleType.Engine)]
public class FInt8Property : FNumericProperty
{
	private PropertyAccessor<sbyte> accessor;

	public override EPropertyType PropertyType => EPropertyType.Int8;

	public PropertyAccessor<sbyte> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<sbyte>(this);
		}
	}

	public FInt8Property()
	{
	}

	public FInt8Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
