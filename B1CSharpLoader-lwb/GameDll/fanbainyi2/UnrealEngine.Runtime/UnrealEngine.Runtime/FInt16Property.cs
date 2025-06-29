using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Int16Property", "CoreUObject", UnrealModuleType.Engine)]
public class FInt16Property : FNumericProperty
{
	private PropertyAccessor<short> accessor;

	public override EPropertyType PropertyType => EPropertyType.Int16;

	public PropertyAccessor<short> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<short>(this);
		}
	}

	public FInt16Property()
	{
	}

	public FInt16Property(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
