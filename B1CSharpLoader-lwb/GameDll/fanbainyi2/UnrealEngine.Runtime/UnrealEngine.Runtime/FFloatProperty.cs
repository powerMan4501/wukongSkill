using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.FloatProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FFloatProperty : FNumericProperty
{
	private PropertyAccessor<float> accessor;

	public override EPropertyType PropertyType => EPropertyType.Float;

	public PropertyAccessor<float> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<float>(this);
		}
	}

	public FFloatProperty()
	{
	}

	public FFloatProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
