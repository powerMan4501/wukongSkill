using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.MapProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FMapProperty : FProperty
{
	private PropertyAccessor<FScriptMap> accessor;

	public override EPropertyType PropertyType => EPropertyType.Map;

	public PropertyAccessor<FScriptMap> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FScriptMap>(this);
		}
	}

	public IntPtr KeyProp
	{
		get
		{
			return Native_FMapProperty.Get_KeyProp(base.Address);
		}
		set
		{
			Native_FMapProperty.Set_KeyProp(base.Address, value);
		}
	}

	public IntPtr ValueProp
	{
		get
		{
			return Native_FMapProperty.Get_ValueProp(base.Address);
		}
		set
		{
			Native_FMapProperty.Set_ValueProp(base.Address, value);
		}
	}

	public FScriptMapLayout MapLayout
	{
		get
		{
			return Native_FMapProperty.Get_MapLayout(base.Address);
		}
		set
		{
			Native_FMapProperty.Set_MapLayout(base.Address, value);
		}
	}

	public FMapProperty()
	{
	}

	public FMapProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
