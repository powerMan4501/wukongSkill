using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed")]
public struct FAnimHumanoidSetting_Spider_Speed
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:forwardSpeed")]
	public float forwardSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:turnSpeed")]
	public float turnSpeed;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:sideStepSpeed")]
	public float sideStepSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:targetForwardSpeed")]
	public float targetForwardSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:targetTurnSpeed")]
	public float targetTurnSpeed;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:targetSideStepSpeed")]
	public float targetSideStepSpeed;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:forwardSpeedScale")]
	public float forwardSpeedScale;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:turnSpeedScale")]
	public float turnSpeedScale;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:sideStepSpeedScale")]
	public float sideStepSpeedScale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:speedLerpSpeed")]
	public float speedLerpSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:IKInterpSpeedFast")]
	public float IKInterpSpeedFast;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed:IKInterpSpeedSlow")]
	public float IKInterpSpeedSlow;

	private static int AnimHumanoidSetting_Spider_Speed_StructSize;

	public FAnimHumanoidSetting_Spider_Speed Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Spider_Speed");
		AnimHumanoidSetting_Spider_Speed_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAnimHumanoidSetting_Spider_Speed));
	}

	static FAnimHumanoidSetting_Spider_Speed()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Spider_Speed)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Spider_Speed));
	}
}
