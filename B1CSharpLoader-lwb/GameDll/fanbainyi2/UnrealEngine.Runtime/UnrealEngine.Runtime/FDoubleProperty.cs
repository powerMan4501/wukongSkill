using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.DoubleProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FDoubleProperty : FNumericProperty
{
	private PropertyAccessor<double> accessor;

	public override EPropertyType PropertyType => EPropertyType.Double;

	public PropertyAccessor<double> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<double>(this);
		}
	}

	public FDoubleProperty()
	{
	}

	public FDoubleProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
