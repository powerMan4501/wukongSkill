using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSArmorCounterWithBlood")]
public struct FGSArmorCounterWithBlood
{
	[UProperty]
	[DisplayName("血线（低于）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSArmorCounterWithBlood:BloodChangeLine")]
	public int BloodChangeLine;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("受击次数最小值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSArmorCounterWithBlood:BeHitNum_Min")]
	public int BeHitNum_Min;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("受击次数最大值")]
	[USharpPath("/Script/b1-Managed.FGSArmorCounterWithBlood:BeHitNum_Max")]
	public int BeHitNum_Max;

	private static int FGSArmorCounterWithBlood_StructSize;

	public FGSArmorCounterWithBlood Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSArmorCounterWithBlood");
		FGSArmorCounterWithBlood_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSArmorCounterWithBlood));
	}

	static FGSArmorCounterWithBlood()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSArmorCounterWithBlood)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSArmorCounterWithBlood));
	}
}
