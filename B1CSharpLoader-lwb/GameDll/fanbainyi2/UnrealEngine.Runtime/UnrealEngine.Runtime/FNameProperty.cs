using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.NameProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FNameProperty : FProperty
{
	private PropertyAccessor<FName> accessor;

	public override EPropertyType PropertyType => EPropertyType.Name;

	public override bool IsBlittableType => true;

	public PropertyAccessor<FName> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FName>(this);
		}
	}

	public FNameProperty()
	{
	}

	public FNameProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
