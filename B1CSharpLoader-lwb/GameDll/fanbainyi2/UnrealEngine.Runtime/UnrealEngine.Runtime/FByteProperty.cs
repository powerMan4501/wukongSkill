using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ByteProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FByteProperty : FNumericProperty
{
	private PropertyAccessor<byte> accessor;

	private CachedUObject<UEnum> enumCached;

	public override EPropertyType PropertyType => EPropertyType.Byte;

	public PropertyAccessor<byte> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<byte>(this);
		}
	}

	public UEnum Enum
	{
		get
		{
			return enumCached.Update(Native_FByteProperty.Get_Enum(base.Address));
		}
		set
		{
			Native_FByteProperty.Set_Enum(base.Address, enumCached.Set(value));
		}
	}

	public FByteProperty()
	{
	}

	public FByteProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
