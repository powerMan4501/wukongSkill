using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPSplineMoveData : IBUC_ABPSplineMoveData
{
	private float TriggerSharpturnAngle = 120f;

	private IBUC_ManualSplineMoveData ManualSplineMoveData;

	private IBUC_UnitStateData UnitStateData;

	public bool bSplineMoveForward { get; set; }

	public bool bSplineMoveForwardLastFrame { get; set; }

	public bool bSplineMoveInSharpturn { get; set; }

	public bool bSplineMoveShouldSharpturn { get; set; }

	public float SplineMoveStopTimer { get; set; }

	public bool bPlaySharpturn { get; set; }

	public float SharpturnAngle { get; set; }

	public FRotator TargetMoveRotation { get; set; }

	public FRotator PriTargetRotation { get; set; }

	public FRotator SecTargetRotation { get; set; }

	public void Init(IBUC_ManualSplineMoveData InManualSplineMoveData, IBUC_UnitStateData InUnitStateData)
	{
		ManualSplineMoveData = InManualSplineMoveData;
		UnitStateData = InUnitStateData;
		bSplineMoveForward = true;
	}

	public void Update(IBUC_ActorBasicData ActorBasicData, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			return;
		}
		if (SpecialMoveData.SpecialMovementMode != ESpecialMovementMode.SplineMove)
		{
			TargetMoveRotation = ChrData.ActorRotation;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
			SharpturnAngle = 0f;
			return;
		}
		if (SpecialMoveData.LastFrameSpecialMovementMode != ESpecialMovementMode.SplineMove && SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.SplineMove)
		{
			bSplineMoveForward = true;
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			TargetMoveRotation = ChrData.ActorRotation;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
		}
		if (ManualSplineMoveData == null)
		{
			return;
		}
		SplineMoveStopTimer += DeltaTime;
		bPlaySharpturn = false;
		if (!bSplineMoveInSharpturn)
		{
			if (SharpturnAngle != 0f)
			{
				if (!HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out var OutCurveValue))
				{
					SharpturnAngle = 0f;
				}
				if (OutCurveValue == 0f)
				{
					SharpturnAngle = 0f;
				}
				if (UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					SharpturnAngle = 0f;
				}
			}
			bSplineMoveForwardLastFrame = bSplineMoveForward;
			if (!ChrData.MoveAcceleration.IsZero())
			{
				bSplineMoveForward = ManualSplineMoveData.bMoveForward;
				TargetMoveRotation = ChrData.MoveAcceleration.Rotation();
			}
			bSplineMoveShouldSharpturn = bSplineMoveForward != bSplineMoveForwardLastFrame;
			bSplineMoveInSharpturn = bSplineMoveShouldSharpturn;
			if (bSplineMoveInSharpturn && ManualSplineMoveData.DirectionType == EManualSplineMoveDirectionType.Free)
			{
				float num = FMath.Abs(ChrData.ActorRotation.NormalizedDeltaRotator(TargetMoveRotation).Yaw);
				FVector2D unitRotateAimDir = new FVector2D(ChrData.ForwardVector);
				FVector2D unit2TargetDir = new FVector2D(TargetMoveRotation.GetForwardVector());
				bool flag = BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir);
				if (num > 1f && ((bSplineMoveForward && flag) || (!bSplineMoveForward && !flag)))
				{
					num = 360f - num;
				}
				SharpturnAngle = (bSplineMoveForward ? (0f - num) : num);
				bPlaySharpturn = true;
				FRotator priTargetRotation = (SecTargetRotation = TargetMoveRotation);
				PriTargetRotation = priTargetRotation;
			}
			return;
		}
		bSplineMoveShouldSharpturn = false;
		if (ManualSplineMoveData.DirectionType == EManualSplineMoveDirectionType.Free)
		{
			FVector2D unitRotateAimDir2 = new FVector2D(ChrData.ForwardVector);
			FVector2D unit2TargetDir2 = new FVector2D(TargetMoveRotation.GetForwardVector());
			bool flag2 = BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir2, unit2TargetDir2);
			float num2 = FMath.Abs(ChrData.ActorRotation.NormalizedDeltaRotator(TargetMoveRotation).Yaw);
			if (num2 > 1f && ((bSplineMoveForward && flag2) || (!bSplineMoveForward && !flag2)))
			{
				num2 = 360f - num2;
			}
			if (num2 <= 180f - TriggerSharpturnAngle)
			{
				bSplineMoveInSharpturn = false;
			}
		}
		else
		{
			bSplineMoveInSharpturn = false;
		}
	}

	public FRotator GetRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		FRotator target = FRotator.ZeroRotator;
		switch (ManualSplineMoveData.DirectionType)
		{
		case EManualSplineMoveDirectionType.Free:
			target = TargetMoveRotation;
			break;
		case EManualSplineMoveDirectionType.Lock:
			target = MathLib.RotateAngleAxis(ManualSplineMoveData.CurSplineMoveForwardDir, ManualSplineMoveData.LockDirectionDeltaAngle, FVector.UpVector).Rotation();
			break;
		}
		target.Pitch = 0f;
		target.Roll = 0f;
		PriTargetRotation = FMath.RInterpConstantTo(PriTargetRotation, target, DeltaTime, 1000f);
		SecTargetRotation = FMath.RInterpTo(SecTargetRotation, PriTargetRotation, DeltaTime, 6f);
		FRotator result = SecTargetRotation;
		if (ManualSplineMoveData.DirectionType == EManualSplineMoveDirectionType.Free)
		{
			float OutCurveValue;
			bool floatAnimCurveValue = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out OutCurveValue);
			float stateMachineWeight = HelperData.GetStateMachineWeight(in B1GlobalFNames.SplineMoveBaseLayer, in B1GlobalFNames.SharpTurn);
			float num = 0f - SharpturnAngle;
			float x = ((stateMachineWeight == 0f || bPlaySharpturn) ? num : (OutCurveValue / stateMachineWeight));
			x = ((num > 0f) ? FMath.Clamp(x, 0f, num) : FMath.Clamp(x, num, 0f));
			if (!bPlaySharpturn && !floatAnimCurveValue && FMath.Abs(SharpturnAngle) > 0f)
			{
				PriTargetRotation = FMath.RInterpConstantTo(ChrData.ActorRotation, target, DeltaTime, 1000f);
				SecTargetRotation = FMath.RInterpTo(ChrData.ActorRotation, PriTargetRotation, DeltaTime, 6f);
				x = 0f;
				SharpturnAngle = 0f;
			}
			result = new FRotator(SecTargetRotation.Pitch, SecTargetRotation.Yaw + x, SecTargetRotation.Roll);
		}
		return result;
	}
}
