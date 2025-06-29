using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Int64Property", "CoreUObject", UnrealModuleType.Engine)]
public class FInt64Property : FNumericProperty
{
	private PropertyAccessor<long> accessor;

	public override EPropertyType PropertyType => EPropertyType.Int64;

	public PropertyAccessor<long> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<long>(this);
		}
	}

	public FInt64Property()
	{
	}

	public FInt64Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
