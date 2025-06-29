using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPBodyBlendData : IBUC_ABPBodyBlendData
{
	private const float LerpSpd = 20f;

	private const float CurveBodyBlendLerpSpeed = 6f;

	private IBUC_SimpleStateData SimpleStateData;

	public float UpperBodyBlendWeight { get; set; }

	public float BSUpperBodyBlendAdditiveX { get; set; }

	public float BSUpperBodyBlendAdditiveY { get; set; }

	public float LeftArmBlendWeight { get; set; }

	public float RightArmBlendWeight { get; set; }

	public bool bHasUpperBodySlotMontage { get; set; }

	public bool bHasLeftArmSlotMontage { get; set; }

	public bool bHasRightArmSlotMontage { get; set; }

	public float FacialBlendWeight { get; set; }

	public bool bHasFacialAnim { get; set; }

	public bool bEnableAnyCurveBodyBlend { get; set; }

	public bool bEnableCurveBodyBlendUpperBody { get; set; }

	public bool bEnableCurveBodyBlendLeftArm { get; set; }

	public bool bEnableCurveBodyBlendRightArm { get; set; }

	public bool bEnableCurveBodyBlendLeftLeg { get; set; }

	public bool bEnableCurveBodyBlendRightLeg { get; set; }

	public UAnimSequenceBase AnimCurveBodyBlendUpperBody { get; set; }

	public UAnimSequenceBase AnimCurveBodyBlendLeftArm { get; set; }

	public UAnimSequenceBase AnimCurveBodyBlendRightArm { get; set; }

	public UAnimSequenceBase AnimCurveBodyBlendLeftLeg { get; set; }

	public UAnimSequenceBase AnimCurveBodyBlendRightLeg { get; set; }

	public float CurveBodyBlendUpperBodyWeight { get; set; }

	public float CurveBodyBlendLeftArmWeight { get; set; }

	public float CurveBodyBlendRightArmWeight { get; set; }

	public float CurveBodyBlendLeftLegWeight { get; set; }

	public float CurveBodyBlendRightLegWeight { get; set; }

	public EMoveDirection MoveDirection { get; set; }

	public bool bEnableAnimCurveBodySeparation { get; set; }

	public bool bCanUseBodySeparation { get; set; }

	public bool bNewMontageStarted { get; set; }

	public float BodySplitBlendWeight_Leg { get; set; }

	public float BodySplitBlendWeight_Pelvis { get; set; }

	public float BodySplitBlendWeight_Spine { get; set; }

	public float BodySplitBlendWeight_Head { get; set; }

	public float BodySplitBlendWeight_ArmL { get; set; }

	public float BodySplitBlendWeight_ArmR { get; set; }

	public float BodySplitBlendWeight_ArmL_LS { get; set; }

	public float BodySplitBlendWeight_ArmR_LS { get; set; }

	public void Init(IBUC_SimpleStateData InSimpleStateData)
	{
		SimpleStateData = InSimpleStateData;
		UpperBodyBlendWeight = 1f;
		LeftArmBlendWeight = 1f;
		RightArmBlendWeight = 1f;
		FacialBlendWeight = 1f;
		bHasUpperBodySlotMontage = false;
		bHasLeftArmSlotMontage = false;
		bEnableCurveBodyBlendUpperBody = false;
		bEnableCurveBodyBlendLeftArm = false;
		bEnableCurveBodyBlendRightArm = false;
		bEnableCurveBodyBlendLeftLeg = false;
		bEnableCurveBodyBlendRightLeg = false;
		CurveBodyBlendUpperBodyWeight = 0f;
		CurveBodyBlendLeftArmWeight = 0f;
		CurveBodyBlendRightArmWeight = 0f;
		CurveBodyBlendLeftLegWeight = 0f;
		CurveBodyBlendRightLegWeight = 0f;
		bEnableAnimCurveBodySeparation = false;
		bCanUseBodySeparation = false;
		BodySplitBlendWeight_Leg = 0f;
		BodySplitBlendWeight_Pelvis = 0f;
		BodySplitBlendWeight_Spine = 0f;
		BodySplitBlendWeight_Head = 0f;
		BodySplitBlendWeight_ArmL = 0f;
		BodySplitBlendWeight_ArmR = 0f;
		BodySplitBlendWeight_ArmL_LS = 0f;
		BodySplitBlendWeight_ArmR_LS = 0f;
	}

	public void Update(AActor Owner, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPCommonSettingData CommonData, IBUC_ABPMonsterLocomotionData MonsterLocomotionData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		if (SimpleStateData != null)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.DynamicUpperBodyMode))
			{
				float target = 0f;
				if (!BasicData.bHasMoveInput)
				{
					target = 1f;
				}
				UpperBodyBlendWeight = FMath.FInterpTo(UpperBodyBlendWeight, target, DeltaTime, 20f);
			}
			else if (UpperBodyBlendWeight != 0f)
			{
				UpperBodyBlendWeight = FMath.FInterpTo(UpperBodyBlendWeight, 0f, DeltaTime, 20f);
			}
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.DynamicLeftArmMode))
			{
				float target2 = 0f;
				if (!BasicData.bHasMoveInput)
				{
					target2 = 1f;
				}
				LeftArmBlendWeight = FMath.FInterpTo(LeftArmBlendWeight, target2, DeltaTime, 20f);
			}
			else if (LeftArmBlendWeight != 0f)
			{
				LeftArmBlendWeight = FMath.FInterpTo(LeftArmBlendWeight, 0f, DeltaTime, 20f);
			}
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.DynamicRightArmMode))
			{
				float target3 = 0f;
				if (!BasicData.bHasMoveInput)
				{
					target3 = 1f;
				}
				RightArmBlendWeight = FMath.FInterpTo(RightArmBlendWeight, target3, DeltaTime, 20f);
			}
			else if (RightArmBlendWeight != 0f)
			{
				RightArmBlendWeight = FMath.FInterpTo(RightArmBlendWeight, 0f, DeltaTime, 20f);
			}
		}
		UpdateUpperBodyBlendAddtive(CommonData, ChrData, MonsterLocomotionData, DeltaTime);
		UpdateCurveBodyBlend(HelperData, DeltaTime);
		UpdateAnimCurveBodySeparation(ChrData, HelperData, DeltaTime);
	}

	private void UpdateUpperBodyBlendAddtive(IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData, IBUC_ABPMonsterLocomotionData MonsterLocomotionData, float DeltaTime)
	{
		float num = FMath.Cos(FMath.DegreesToRadians(50f));
		float num2 = FMath.Cos(FMath.DegreesToRadians(130f));
		float num3 = FMath.Cos(FMath.DegreesToRadians(40f));
		float num4 = FMath.Cos(FMath.DegreesToRadians(140f));
		FVector safeNormal2D = ChrData.Velocity.GetSafeNormal2D();
		if (safeNormal2D.Size().Equals(0f))
		{
			MoveDirection = EMoveDirection.None;
		}
		else
		{
			float num5 = FVector.DotProduct(safeNormal2D, ChrData.ForwardVector);
			float num6 = FVector.DotProduct(safeNormal2D, ChrData.RightVector);
			if (num5 >= num)
			{
				MoveDirection = EMoveDirection.Forward;
			}
			if (num5 <= num2)
			{
				MoveDirection = EMoveDirection.Backward;
			}
			if (num6 > num3)
			{
				MoveDirection = EMoveDirection.Right;
			}
			if (num6 < num4)
			{
				MoveDirection = EMoveDirection.Left;
			}
		}
		if (CommonData.FinalABPMoveMode == EABPMoveMode.MonsterLocomotion)
		{
			MoveDirection = MonsterLocomotionData.TargetLockMoveDirection;
		}
		float target = 0f;
		float target2 = 0f;
		switch (MoveDirection)
		{
		case EMoveDirection.Forward:
			target = 0f;
			target2 = 1f;
			break;
		case EMoveDirection.Right:
			target = 1f;
			target2 = 0f;
			break;
		case EMoveDirection.Backward:
			target = 0f;
			target2 = -1f;
			break;
		case EMoveDirection.Left:
			target = -1f;
			target2 = 0f;
			break;
		}
		BSUpperBodyBlendAdditiveX = FMath.FInterpTo(BSUpperBodyBlendAdditiveX, target, DeltaTime, 12f);
		BSUpperBodyBlendAdditiveY = FMath.FInterpTo(BSUpperBodyBlendAdditiveY, target2, DeltaTime, 12f);
	}

	private void UpdateCurveBodyBlend(IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		float val = 0.01f;
		float OutCurveValue = 0f;
		HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.UpperBodyBlendWeight, out OutCurveValue);
		float target = (bEnableCurveBodyBlendUpperBody ? FMath.Max(OutCurveValue, val) : 0f);
		CurveBodyBlendUpperBodyWeight = FMath.FInterpTo(CurveBodyBlendUpperBodyWeight, target, DeltaTime, 6f);
		HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LeftArmBlendWeight, out OutCurveValue);
		target = (bEnableCurveBodyBlendLeftArm ? FMath.Max(OutCurveValue, val) : 0f);
		CurveBodyBlendLeftArmWeight = FMath.FInterpTo(CurveBodyBlendLeftArmWeight, target, DeltaTime, 6f);
		HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RightArmBlendWeight, out OutCurveValue);
		target = (bEnableCurveBodyBlendRightArm ? FMath.Max(OutCurveValue, val) : 0f);
		CurveBodyBlendRightArmWeight = FMath.FInterpTo(CurveBodyBlendRightArmWeight, target, DeltaTime, 6f);
		HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LeftLegBlendWeight, out OutCurveValue);
		target = (bEnableCurveBodyBlendLeftLeg ? FMath.Max(OutCurveValue, val) : 0f);
		CurveBodyBlendLeftLegWeight = FMath.FInterpTo(CurveBodyBlendLeftLegWeight, target, DeltaTime, 6f);
		HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RightLegBlendWeight, out OutCurveValue);
		target = (bEnableCurveBodyBlendRightLeg ? FMath.Max(OutCurveValue, val) : 0f);
		CurveBodyBlendRightLegWeight = FMath.FInterpTo(CurveBodyBlendRightLegWeight, target, DeltaTime, 6f);
		bEnableAnyCurveBodyBlend = bEnableCurveBodyBlendUpperBody || bEnableCurveBodyBlendLeftArm || bEnableCurveBodyBlendRightArm || bEnableCurveBodyBlendLeftLeg || bEnableCurveBodyBlendRightLeg;
	}

	private void UpdateAnimCurveBodySeparation(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		float OutCurveValue = 0f;
		bool floatAnimCurveValue = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_Leg, out OutCurveValue);
		BodySplitBlendWeight_Leg = FMath.FInterpTo(BodySplitBlendWeight_Leg, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue2 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_Pelvis, out OutCurveValue);
		BodySplitBlendWeight_Pelvis = FMath.FInterpTo(BodySplitBlendWeight_Pelvis, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue3 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_Spine, out OutCurveValue);
		BodySplitBlendWeight_Spine = FMath.FInterpTo(BodySplitBlendWeight_Spine, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue4 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_Head, out OutCurveValue);
		BodySplitBlendWeight_Head = FMath.FInterpTo(BodySplitBlendWeight_Head, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue5 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_ArmL, out OutCurveValue);
		BodySplitBlendWeight_ArmL = FMath.FInterpTo(BodySplitBlendWeight_ArmL, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue6 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_ArmL_LS, out OutCurveValue);
		BodySplitBlendWeight_ArmL_LS = FMath.FInterpTo(BodySplitBlendWeight_ArmL_LS, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue7 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_ArmR, out OutCurveValue);
		BodySplitBlendWeight_ArmR = FMath.FInterpTo(BodySplitBlendWeight_ArmR, OutCurveValue, DeltaTime, 10f);
		bool floatAnimCurveValue8 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BodySplit_ArmR_LS, out OutCurveValue);
		BodySplitBlendWeight_ArmR_LS = FMath.FInterpTo(BodySplitBlendWeight_ArmR_LS, OutCurveValue, DeltaTime, 10f);
		bEnableAnimCurveBodySeparation = (floatAnimCurveValue && BodySplitBlendWeight_Leg > 0f) || (floatAnimCurveValue2 && BodySplitBlendWeight_Pelvis > 0f) || (floatAnimCurveValue3 && BodySplitBlendWeight_Spine > 0f) || (floatAnimCurveValue4 && BodySplitBlendWeight_Head > 0f) || (floatAnimCurveValue5 && BodySplitBlendWeight_ArmL > 0f) || (floatAnimCurveValue7 && BodySplitBlendWeight_ArmR > 0f) || (floatAnimCurveValue6 && BodySplitBlendWeight_ArmL_LS > 0f) || (floatAnimCurveValue8 && BodySplitBlendWeight_ArmR_LS > 0f);
		if (!bCanUseBodySeparation && bEnableAnimCurveBodySeparation)
		{
			bCanUseBodySeparation = !ChrData.MoveAcceleration.IsNearlyZero();
		}
		if (bNewMontageStarted)
		{
			bCanUseBodySeparation = false;
			bNewMontageStarted = false;
		}
	}
}
