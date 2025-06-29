using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.EffectorData")]
public struct FEffectorData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("肢体IK根骨骼")]
	[USharpPath("/Script/b1-Managed.EffectorData:EffectorRootName")]
	public FName EffectorRootName;

	[DisplayName("肢体IK骨骼")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.EffectorData:BoneName")]
	public FName BoneName;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EffectorData:Position")]
	public FVector Position;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.EffectorData:Alpha")]
	public float Alpha;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.EffectorData:AlphaCurveValue")]
	public float AlphaCurveValue;

	private static int EffectorData_StructSize;

	public FEffectorData Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.EffectorData");
		EffectorData_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FEffectorData));
	}

	static FEffectorData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEffectorData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEffectorData));
	}
}
