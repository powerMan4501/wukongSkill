using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.UInt64Property", "CoreUObject", UnrealModuleType.Engine)]
public class FUInt64Property : FNumericProperty
{
	private PropertyAccessor<ulong> accessor;

	public override EPropertyType PropertyType => EPropertyType.UInt64;

	public PropertyAccessor<ulong> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<ulong>(this);
		}
	}

	public FUInt64Property()
	{
	}

	public FUInt64Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
