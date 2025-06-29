using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPBasicData : IBUC_ABPBasicData
{
	private IBUC_MovementData MovementData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	public float VerticleSpeed { get; set; }

	public float HorizontalSpeed { get; set; }

	public float Speed { get; set; }

	public float Speed3D { get; set; }

	public float SprintSpeed { get; set; }

	public float RunSpeed { get; set; }

	public float SpeedWarpAmount { get; set; }

	public float JogBaseSpeed { get; set; }

	public bool IsStandRotate { get; set; }

	public bool IsStandRotateStart { get; set; }

	public FRotator StandRotateTargetRotation { get; set; }

	public float StandRotateAngle { get; set; }

	public EStandRotateType StandRotateType { get; set; }

	public FRotator PriTargetRotation { get; set; }

	public FRotator SecTargetRotation { get; set; }

	public EMoveSpeedLevel MoveSpeedLevel { get; set; }

	public EMoveSpeedLevel MoveSpeedState { get; set; }

	public FVector AccelerationVec { get; set; }

	public bool bHasMoveInput { get; set; }

	public bool bHasPlayerInput { get; set; }

	public bool bHasRun { get; set; }

	public void Init(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_MovementData InMovementData, IBUC_UnitStateData InUnitStateData, IBUC_SimpleStateData InSimpleStateData, IBUC_SpeedCtrlData InSpeedCtrlData)
	{
		MovementData = InMovementData;
		UnitStateData = InUnitStateData;
		SimpleStateData = InSimpleStateData;
		bHasRun = CommonData.BSRunFwd != null && CommonData.BSRunBwd != null && CommonData.BSRunLeft != null && CommonData.BSRunRight != null;
		JogBaseSpeed = InSpeedCtrlData.GetMoveSpeedSlow();
		RunSpeed = InSpeedCtrlData.GetMoveSpeedNormal();
		SprintSpeed = InSpeedCtrlData.GetMoveSpeedFast();
		IsStandRotate = false;
		IsStandRotateStart = false;
		MoveSpeedLevel = EMoveSpeedLevel.Run;
		MoveSpeedState = EMoveSpeedLevel.Run;
	}

	public void Update_WorkThread(AActor Owner, IBUC_ABPCharacterData ChrData, IBUC_ABPBGUCharacterData BGUData, IBUC_SpeedCtrlData SpeedCtrlData, float DeltaTime)
	{
		if (SpeedCtrlData != null)
		{
			JogBaseSpeed = SpeedCtrlData.GetMoveSpeedSlow();
			RunSpeed = SpeedCtrlData.GetMoveSpeedNormal();
			SprintSpeed = SpeedCtrlData.GetMoveSpeedFast();
		}
		if (JogBaseSpeed <= 0f)
		{
			JogBaseSpeed = 100f;
		}
		FVector velocity = ChrData.Velocity;
		FVector forwardVector = ChrData.ForwardVector;
		forwardVector.Normalize();
		FVector rightVector = ChrData.RightVector;
		rightVector.Normalize();
		ChrData.UpVector.Normalize();
		AccelerationVec = ChrData.MoveAcceleration.GetSafeNormal();
		bHasMoveInput = AccelerationVec.Size() > 0.1f;
		if (MovementData != null)
		{
			bHasPlayerInput = MovementData.bInputMoving;
			if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World))
			{
				ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
				if (aBGUCharacter != null && !aBGUCharacter.IsLocallyControlled())
				{
					bHasPlayerInput = true;
				}
			}
		}
		else
		{
			bHasPlayerInput = false;
		}
		VerticleSpeed = FVector.DotProduct(velocity, forwardVector);
		HorizontalSpeed = FVector.DotProduct(velocity, rightVector);
		Speed = FMath.Abs(velocity.Size2D());
		Speed3D = FMath.Abs(velocity.Size());
		MoveSpeedLevel = EMoveSpeedLevel.Walk;
		if (Speed > (JogBaseSpeed + RunSpeed) / 2f)
		{
			MoveSpeedLevel = EMoveSpeedLevel.Run;
		}
		if (Speed > (SprintSpeed + RunSpeed) / 2f)
		{
			MoveSpeedLevel = EMoveSpeedLevel.Sprint;
		}
		if (bHasMoveInput)
		{
			MoveSpeedState = EMoveSpeedLevel.Run;
			if (UnitStateData != null)
			{
				if (UnitStateData.HasState(EBGUUnitState.Sprinting))
				{
					MoveSpeedState = EMoveSpeedLevel.Sprint;
				}
				else if (UnitStateData.HasState(EBGUUnitState.Walking))
				{
					MoveSpeedState = EMoveSpeedLevel.Walk;
				}
			}
			if (SimpleStateData != null && SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly))
			{
				MoveSpeedState = EMoveSpeedLevel.Walk;
			}
		}
		float num = 0f;
		SpeedWarpAmount = FMath.Lerp(b: (!bHasRun) ? ((Speed > SprintSpeed) ? (Speed / SprintSpeed) : (Speed / JogBaseSpeed)) : ((Speed <= (JogBaseSpeed + RunSpeed) / 2f) ? (Speed / JogBaseSpeed) : ((!(Speed <= (SprintSpeed + RunSpeed) / 2f)) ? (Speed / SprintSpeed) : (Speed / RunSpeed))), a: SpeedWarpAmount, alpha: FMath.Clamp(DeltaTime, 0f, 1f));
		UpdateTurnInPlace(Owner, ChrData, BGUData, DeltaTime);
	}

	private void UpdateTurnInPlace(AActor Owner, IBUC_ABPCharacterData ChrData, IBUC_ABPBGUCharacterData BGUData, float DeltaTime)
	{
		bool isStandRotate = IsStandRotate;
		IsStandRotate = BGUData.IsStandRotate;
		IsStandRotateStart = false;
		if (!isStandRotate && IsStandRotate)
		{
			IsStandRotateStart = true;
			StandRotateAngle = BGUData.TurnInplaceRemainAngle;
			StandRotateTargetRotation = BGUData.TurnInplaceTargetRotation;
			FRotator priTargetRotation = (SecTargetRotation = StandRotateTargetRotation);
			PriTargetRotation = priTargetRotation;
			if (-180f < StandRotateAngle && StandRotateAngle <= -120f)
			{
				StandRotateType = EStandRotateType.Left180;
			}
			if (-120f < StandRotateAngle && StandRotateAngle < 0f)
			{
				StandRotateType = EStandRotateType.Left90;
			}
			if (0f < StandRotateAngle && StandRotateAngle < 120f)
			{
				StandRotateType = EStandRotateType.Right90;
			}
			if (120f <= StandRotateAngle && StandRotateAngle <= 180f)
			{
				StandRotateType = EStandRotateType.Right180;
			}
		}
		else if (IsStandRotate)
		{
			StandRotateTargetRotation = BGUData.TurnInplaceTargetRotation;
		}
		if (!IsStandRotate)
		{
			StandRotateAngle = 0f;
			StandRotateTargetRotation = ChrData.ActorRotation;
			FRotator priTargetRotation = (SecTargetRotation = StandRotateTargetRotation);
			PriTargetRotation = priTargetRotation;
		}
	}

	public float GetMappedSpeed()
	{
		float num = 0f;
		float num2 = FMath.Abs(Speed);
		num = ((num2 < JogBaseSpeed) ? FMath.GetMappedRangeValueClamped(new FVector2D(0.0, JogBaseSpeed), new FVector2D(0.0, 1.0), num2) : ((!(num2 < RunSpeed)) ? FMath.GetMappedRangeValueClamped(new FVector2D(RunSpeed, SprintSpeed), new FVector2D(2.0, 3.0), num2) : FMath.GetMappedRangeValueClamped(new FVector2D(JogBaseSpeed, RunSpeed), new FVector2D(1.0, 2.0), num2)));
		return num * ((Speed >= 0f) ? 1f : (-1f));
	}

	public float GetMappedSpeed3D()
	{
		float num = 0f;
		float num2 = FMath.Abs(Speed3D);
		num = ((num2 < JogBaseSpeed) ? FMath.GetMappedRangeValueClamped(new FVector2D(0.0, JogBaseSpeed), new FVector2D(0.0, 1.0), num2) : ((!(num2 < RunSpeed)) ? FMath.GetMappedRangeValueClamped(new FVector2D(RunSpeed, SprintSpeed), new FVector2D(2.0, 3.0), num2) : FMath.GetMappedRangeValueClamped(new FVector2D(JogBaseSpeed, RunSpeed), new FVector2D(1.0, 2.0), num2)));
		return num * ((Speed3D >= 0f) ? 1f : (-1f));
	}

	public FRotator GetStandRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		FRotator zeroRotator = FRotator.ZeroRotator;
		if (IsStandRotate)
		{
			zeroRotator = StandRotateTargetRotation;
			zeroRotator.Pitch = 0f;
			zeroRotator.Roll = 0f;
			PriTargetRotation = FMath.RInterpConstantTo(PriTargetRotation, zeroRotator, DeltaTime, 1000f);
			SecTargetRotation = FMath.RInterpTo(SecTargetRotation, PriTargetRotation, DeltaTime, 6f);
			float OutCurveValue;
			bool floatAnimCurveValue = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out OutCurveValue);
			float stateMachineWeight = HelperData.GetStateMachineWeight(in B1GlobalFNames.StandRotate, in B1GlobalFNames.Rotate);
			float num = 0f - StandRotateAngle;
			float x = ((stateMachineWeight == 0f || IsStandRotateStart) ? num : (OutCurveValue / stateMachineWeight));
			x = ((num > 0f) ? FMath.Clamp(x, 0f, num) : FMath.Clamp(x, num, 0f));
			if (!IsStandRotateStart && !floatAnimCurveValue && FMath.Abs(StandRotateAngle) > 0f)
			{
				PriTargetRotation = FMath.RInterpConstantTo(ChrData.ActorRotation, zeroRotator, DeltaTime, 1000f);
				SecTargetRotation = FMath.RInterpTo(ChrData.ActorRotation, PriTargetRotation, DeltaTime, 6f);
				x = 0f;
				StandRotateAngle = 0f;
			}
			return new FRotator(SecTargetRotation.Pitch, SecTargetRotation.Yaw + x, SecTargetRotation.Roll);
		}
		return SecTargetRotation;
	}
}
