using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.IntProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FIntProperty : FNumericProperty
{
	private PropertyAccessor<int> accessor;

	public override EPropertyType PropertyType => EPropertyType.Int;

	public PropertyAccessor<int> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<int>(this);
		}
	}

	public FIntProperty()
	{
	}

	public FIntProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
