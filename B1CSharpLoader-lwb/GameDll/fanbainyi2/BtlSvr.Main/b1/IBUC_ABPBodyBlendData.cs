using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPBodyBlendData
{
	float UpperBodyBlendWeight { get; }

	float BSUpperBodyBlendAdditiveX { get; }

	float BSUpperBodyBlendAdditiveY { get; }

	float LeftArmBlendWeight { get; }

	float RightArmBlendWeight { get; }

	float FacialBlendWeight { get; }

	bool bHasUpperBodySlotMontage { get; }

	bool bHasLeftArmSlotMontage { get; }

	bool bHasRightArmSlotMontage { get; }

	bool bHasFacialAnim { get; }

	bool bEnableAnyCurveBodyBlend { get; }

	UAnimSequenceBase AnimCurveBodyBlendUpperBody { get; }

	UAnimSequenceBase AnimCurveBodyBlendLeftArm { get; }

	UAnimSequenceBase AnimCurveBodyBlendRightArm { get; }

	UAnimSequenceBase AnimCurveBodyBlendLeftLeg { get; }

	UAnimSequenceBase AnimCurveBodyBlendRightLeg { get; }

	float CurveBodyBlendUpperBodyWeight { get; }

	float CurveBodyBlendLeftArmWeight { get; }

	float CurveBodyBlendRightArmWeight { get; }

	float CurveBodyBlendLeftLegWeight { get; }

	float CurveBodyBlendRightLegWeight { get; }

	EMoveDirection MoveDirection { get; }

	bool bEnableAnimCurveBodySeparation { get; }

	bool bCanUseBodySeparation { get; }

	float BodySplitBlendWeight_Leg { get; }

	float BodySplitBlendWeight_Pelvis { get; }

	float BodySplitBlendWeight_Spine { get; }

	float BodySplitBlendWeight_Head { get; }

	float BodySplitBlendWeight_ArmL { get; }

	float BodySplitBlendWeight_ArmR { get; }

	float BodySplitBlendWeight_ArmL_LS { get; }

	float BodySplitBlendWeight_ArmR_LS { get; }
}
