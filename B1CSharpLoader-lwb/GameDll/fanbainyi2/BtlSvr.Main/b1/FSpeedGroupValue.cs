using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SpeedGroupValue")]
public struct FSpeedGroupValue
{
	[EditAnywhere]
	[UProperty]
	[Category("GSSpawnBullets|LeftValue")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpeedGroupValue:LeftValue")]
	public float LeftValue;

	[Category("GSSpawnBullets|TargetValue")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpeedGroupValue:RightValue")]
	public float RightValue;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSSpawnBullets|AccelerationTime")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpeedGroupValue:AccelerationTime")]
	public float AccelerationTime;

	private static int SpeedGroupValue_StructSize;

	public FSpeedGroupValue Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.SpeedGroupValue");
		SpeedGroupValue_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FSpeedGroupValue));
	}

	static FSpeedGroupValue()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpeedGroupValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpeedGroupValue));
	}
}
