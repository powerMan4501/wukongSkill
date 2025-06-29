using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.UInt16Property", "CoreUObject", UnrealModuleType.Engine)]
public class FUInt16Property : FNumericProperty
{
	private PropertyAccessor<ushort> accessor;

	public override EPropertyType PropertyType => EPropertyType.UInt16;

	public PropertyAccessor<ushort> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<ushort>(this);
		}
	}

	public FUInt16Property()
	{
	}

	public FUInt16Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
