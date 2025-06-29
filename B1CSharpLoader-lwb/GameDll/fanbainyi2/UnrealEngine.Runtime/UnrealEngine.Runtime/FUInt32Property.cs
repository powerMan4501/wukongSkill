using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.UInt32Property", "CoreUObject", UnrealModuleType.Engine)]
public class FUInt32Property : FNumericProperty
{
	private PropertyAccessor<uint> accessor;

	public override EPropertyType PropertyType => EPropertyType.UInt32;

	public PropertyAccessor<uint> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<uint>(this);
		}
	}

	public FUInt32Property()
	{
	}

	public FUInt32Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
