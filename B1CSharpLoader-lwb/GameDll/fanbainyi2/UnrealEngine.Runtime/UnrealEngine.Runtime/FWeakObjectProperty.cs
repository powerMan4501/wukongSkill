using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.WeakObjectProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FWeakObjectProperty : FObjectPropertyBase
{
	private PropertyAccessor<FWeakObjectPtr> accessor;

	public override EPropertyType PropertyType => EPropertyType.WeakObject;

	public PropertyAccessor<FWeakObjectPtr> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FWeakObjectPtr>(this);
		}
	}

	public FWeakObjectProperty()
	{
	}

	public FWeakObjectProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
