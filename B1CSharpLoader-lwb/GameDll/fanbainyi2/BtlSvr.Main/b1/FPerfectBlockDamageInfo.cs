using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PerfectBlockDamageInfo")]
public struct FPerfectBlockDamageInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("完美格挡扣除格挡值Hitweiht")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.PerfectBlockDamageInfo:TriggerDeductPerfectBlockValueHitWeight")]
	public int TriggerDeductPerfectBlockValueHitWeight;

	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("万分比")]
	[DisplayName("完美格挡扣除格挡值万分比")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerfectBlockDamageInfo:DeductPerfectBlockValueRadio")]
	public int DeductPerfectBlockValueRadio;

	private static int PerfectBlockDamageInfo_StructSize;

	public FPerfectBlockDamageInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.PerfectBlockDamageInfo");
		PerfectBlockDamageInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FPerfectBlockDamageInfo));
	}

	static FPerfectBlockDamageInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPerfectBlockDamageInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerfectBlockDamageInfo));
	}
}
