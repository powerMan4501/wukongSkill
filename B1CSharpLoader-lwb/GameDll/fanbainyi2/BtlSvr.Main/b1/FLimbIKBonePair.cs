using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LimbIKBonePair")]
public struct FLimbIKBonePair
{
	[BlueprintReadWrite]
	[DisplayName("肢体IK骨骼")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LimbIKBonePair:BoneName")]
	public FName BoneName;

	[DisplayName("肢体IK虚拟骨骼")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LimbIKBonePair:VBoneName")]
	public FName VBoneName;

	private static int LimbIKBonePair_StructSize;

	public FLimbIKBonePair Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.LimbIKBonePair");
		LimbIKBonePair_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FLimbIKBonePair));
	}

	static FLimbIKBonePair()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLimbIKBonePair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLimbIKBonePair));
	}
}
