using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ArrayProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FArrayProperty : FProperty
{
	private PropertyAccessor<FScriptArray> accessor;

	public override EPropertyType PropertyType => EPropertyType.Array;

	public PropertyAccessor<FScriptArray> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FScriptArray>(this);
		}
	}

	public IntPtr Inner
	{
		get
		{
			return Native_FArrayProperty.Get_Inner(base.Address);
		}
		set
		{
			Native_FArrayProperty.Set_Inner(base.Address, value);
		}
	}

	public FArrayProperty()
	{
	}

	public FArrayProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
