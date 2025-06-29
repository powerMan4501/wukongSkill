using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.SetProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FSetProperty : FProperty
{
	private PropertyAccessor<FScriptSet> accessor;

	public override EPropertyType PropertyType => EPropertyType.Set;

	public PropertyAccessor<FScriptSet> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FScriptSet>(this);
		}
	}

	public IntPtr ElementProp
	{
		get
		{
			return Native_FSetProperty.Get_ElementProp(base.Address);
		}
		set
		{
			Native_FSetProperty.Set_ElementProp(base.Address, value);
		}
	}

	public FScriptSetLayout SetLayout
	{
		get
		{
			return Native_FSetProperty.Get_SetLayout(base.Address);
		}
		set
		{
			Native_FSetProperty.Set_SetLayout(base.Address, value);
		}
	}

	public FSetProperty()
	{
	}

	public FSetProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
