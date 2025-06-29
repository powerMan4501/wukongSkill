using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character")]
public struct FAnimHumanoidSetting_Spider_Character
{
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:bodyTransOffset")]
	public FTransform bodyTransOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:targetTransform")]
	public FTransform targetTransform;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:bodyTransLerpSpeed")]
	public float bodyTransLerpSpeed;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:meanHeadHeight")]
	public float meanHeadHeight;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:meanGroundNormal")]
	public FVector meanGroundNormal;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:maxHeadHeight")]
	public float maxHeadHeight;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:GroundedFootNum")]
	public float GroundedFootNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:standardHeadHeight")]
	public float standardHeadHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character:capsuleHeightOffset")]
	public float capsuleHeightOffset;

	private static int AnimHumanoidSetting_Spider_Character_StructSize;

	public FAnimHumanoidSetting_Spider_Character Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Spider_Character");
		AnimHumanoidSetting_Spider_Character_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAnimHumanoidSetting_Spider_Character));
	}

	static FAnimHumanoidSetting_Spider_Character()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Spider_Character)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Spider_Character));
	}
}
