using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.EnumProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FEnumProperty : FProperty
{
	public override EPropertyType PropertyType => EPropertyType.Enum;

	public override bool IsBlittableType => true;

	public FEnumProperty()
	{
	}

	public FEnumProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public void SetEnum(UEnum unrealEnum)
	{
		Native_FEnumProperty.SetEnum(base.Address, (unrealEnum == null) ? IntPtr.Zero : unrealEnum.Address);
	}

	public UEnum GetEnum()
	{
		return GCHelper.Find<UEnum>(Native_FEnumProperty.GetEnum(base.Address));
	}

	public FNumericProperty GetUnderlyingProperty()
	{
		return new FNumericProperty(Native_FEnumProperty.GetUnderlyingProperty(base.Address));
	}
}
