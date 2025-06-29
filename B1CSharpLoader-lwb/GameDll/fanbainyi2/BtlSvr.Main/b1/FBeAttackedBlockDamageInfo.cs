using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BeAttackedBlockDamageInfo")]
public struct FBeAttackedBlockDamageInfo
{
	[UProperty]
	[DisplayName("触发削减格挡值等级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BeAttackedBlockDamageInfo:TriggerDeductBlockArmorLevel")]
	public int TriggerDeductBlockArmorLevel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("削减格挡值")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BeAttackedBlockDamageInfo:DeductBlockArmorValue")]
	public float DeductBlockArmorValue;

	private static int BeAttackedBlockDamageInfo_StructSize;

	public FBeAttackedBlockDamageInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BeAttackedBlockDamageInfo");
		BeAttackedBlockDamageInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FBeAttackedBlockDamageInfo));
	}

	static FBeAttackedBlockDamageInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBeAttackedBlockDamageInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBeAttackedBlockDamageInfo));
	}
}
