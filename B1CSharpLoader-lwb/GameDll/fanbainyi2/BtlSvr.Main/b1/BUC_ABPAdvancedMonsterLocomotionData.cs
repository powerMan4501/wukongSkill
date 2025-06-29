using System.Collections.Generic;
using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPAdvancedMonsterLocomotionData : IBUC_ABPAdvancedMonsterLocomotionData
{
	private IBUC_MovementData MovementData;

	private Dictionary<ELockMoveDirectionSix, b1.AngleRange> MoveDirAngleRange;

	private List<ELockMoveDirectionSix> AngleRangeList;

	private bool bIsAI;

	private readonly FVector2D AlphaRangle = new FVector2D(-2.0, 2.0);

	private readonly FVector2D PelvisAngleOffsetRange = new FVector2D(-20.0, 20.0);

	public ELMFreeMode FreeMode { get; set; }

	public ELMLockMode LockMode { get; set; }

	public float MaxAcceleration { get; set; }

	public float BrakingDecelerationWalking { get; set; }

	public float BrakingFriction { get; set; }

	public float WalkMaxAcceleration { get; set; }

	public float WalkBrakingDecelerationWalking { get; set; }

	public float WalkBrakingFriction { get; set; }

	public float RunMaxAcceleration { get; set; }

	public float RunBrakingDecelerationWalking { get; set; }

	public float RunBrakingFriction { get; set; }

	public float RushMaxAcceleration { get; set; }

	public float RushBrakingDecelerationWalking { get; set; }

	public float RushBrakingFriction { get; set; }

	public FRotator TargetRotation { get; set; }

	public bool bSwitchToLock { get; set; }

	public bool bSwitchingLockState { get; set; }

	public float SwitchingLockStateAngle { get; set; }

	public FRotator PriTargetRotation { get; set; }

	public FRotator SecTargetRotation { get; set; }

	public EGaitGroundedState GaitGroundedState { get; set; }

	public EGaitGroundedState GaitGroundedStateTemp { get; set; }

	public EGaitGroundedState MoveGaitGroundedState { get; set; }

	public bool bPlayWalkStart { get; set; }

	public bool bPlayRunStart { get; set; }

	public bool bPlayRushStart { get; set; }

	public bool bPlayStart { get; set; }

	public float WalkStartAngle { get; set; }

	public float RunStartAngle { get; set; }

	public float RushStartAngle { get; set; }

	public float StartAngle { get; set; }

	public float AnimRateWalk { get; set; }

	public float AnimRateRun { get; set; }

	public float AnimRateRush { get; set; }

	public float AnimRateRunLock { get; set; }

	public float VelocityDeltaAngle { get; set; }

	public float VelocityLeanAlpha { get; set; }

	public float InputDeltaAngle { get; set; }

	public ELockMoveDirectionSix VelocityDirection { get; set; }

	public ELockMoveDirectionSix InputDirection { get; set; }

	public ELockMoveDirectionSix LastFrameVelocityDirection { get; set; }

	public ELockMoveDirectionSix LastFrameInputDirection { get; set; }

	public EMoveDirectionFive FreeInputDirection { get; set; }

	public float InputVelocityAngle { get; set; }

	public float MoveLoopPelvisLocationOffset { get; set; }

	public float MoveLoopPelvisAngleOffset { get; set; }

	public float PelvisFootDistance { get; set; }

	public float MoveLoopAlpha { get; set; }

	public bool bInFreeTurn { get; set; }

	public void Init(AActor Owner, BUABPSettingData Setting, IBUC_MovementData InMovementData, bool InIsAI)
	{
		MovementData = InMovementData;
		bIsAI = InIsAI;
		if (b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.AdvancedMonsterLocomotion, Setting))
		{
			BUABPAdvancedMonsterLocomotionSettingData advancedMonsterLocomotionSetting = Setting.AdvancedMonsterLocomotionSetting;
			FreeMode = advancedMonsterLocomotionSetting.FreeMode;
			LockMode = advancedMonsterLocomotionSetting.LockMode;
			WalkMaxAcceleration = advancedMonsterLocomotionSetting.WalkMaxAcceleration;
			WalkBrakingDecelerationWalking = advancedMonsterLocomotionSetting.WalkBrakingDecelerationWalking;
			WalkBrakingFriction = advancedMonsterLocomotionSetting.WalkBrakingFriction;
			RunMaxAcceleration = advancedMonsterLocomotionSetting.RunMaxAcceleration;
			RunBrakingDecelerationWalking = advancedMonsterLocomotionSetting.RunBrakingDecelerationWalking;
			RunBrakingFriction = advancedMonsterLocomotionSetting.RunBrakingFriction;
			RushMaxAcceleration = advancedMonsterLocomotionSetting.RushMaxAcceleration;
			RushBrakingDecelerationWalking = advancedMonsterLocomotionSetting.RushBrakingDecelerationWalking;
			RushBrakingFriction = advancedMonsterLocomotionSetting.RushBrakingFriction;
			MaxAcceleration = RunMaxAcceleration;
			BrakingDecelerationWalking = RunBrakingDecelerationWalking;
			BrakingFriction = RunBrakingFriction;
			MoveDirAngleRange = new Dictionary<ELockMoveDirectionSix, b1.AngleRange>
			{
				{
					ELockMoveDirectionSix.F,
					new b1.AngleRange(-30f, 30f)
				},
				{
					ELockMoveDirectionSix.B,
					new b1.AngleRange(150f, -150f)
				},
				{
					ELockMoveDirectionSix.FL,
					new b1.AngleRange(-90f, -30f)
				},
				{
					ELockMoveDirectionSix.FR,
					new b1.AngleRange(30f, 90f)
				},
				{
					ELockMoveDirectionSix.BL,
					new b1.AngleRange(-150f, -90f)
				},
				{
					ELockMoveDirectionSix.BR,
					new b1.AngleRange(90f, 150f)
				}
			};
			AngleRangeList = new List<ELockMoveDirectionSix>
			{
				ELockMoveDirectionSix.F,
				ELockMoveDirectionSix.B,
				ELockMoveDirectionSix.FL,
				ELockMoveDirectionSix.FR,
				ELockMoveDirectionSix.BL,
				ELockMoveDirectionSix.BR
			};
		}
	}

	public void Update(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPBGUCharacterData BGUData, IBUC_ABPCommonLocomotionData LocomotionData, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		if (SpecialMoveData.SpecialMovementMode != ESpecialMovementMode.GroundMove || CommonData.FinalABPMoveMode != EABPMoveMode.AdvancedMonsterLocomotion)
		{
			bInFreeTurn = false;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
			GaitGroundedStateTemp = EGaitGroundedState.None;
			GaitGroundedState = EGaitGroundedState.None;
			MaxAcceleration = RunMaxAcceleration;
			BrakingDecelerationWalking = RunBrakingDecelerationWalking;
			BrakingFriction = RunBrakingFriction;
			return;
		}
		bool flag = bSwitchToLock;
		if (bIsAI)
		{
			if (MovementData != null)
			{
				bSwitchToLock = MovementData.MoveAIType == EBGUMoveAIType.KeepFacingTarget;
			}
		}
		else
		{
			bSwitchToLock = BGUData.bSideWalking;
		}
		bSwitchingLockState = bSwitchToLock != flag;
		if (bSwitchingLockState)
		{
			FRotator a = ChrData.ActorRotation;
			if (bSwitchToLock)
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Owner);
				if (aActor != null)
				{
					a = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - ChrData.ActorLocation).Rotation();
				}
			}
			else
			{
				a = ChrData.MoveAcceleration.Rotation();
			}
			SwitchingLockStateAngle = MathLib.NormalizedDeltaRotator(a, ChrData.ActorRotation).Yaw;
		}
		if (!ChrData.MoveAcceleration.IsNearlyZero())
		{
			LastFrameVelocityDirection = VelocityDirection;
			LastFrameInputDirection = InputDirection;
			InputDeltaAngle = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.ActorRotation).Yaw;
			InputVelocityAngle = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.Velocity.Rotation()).Yaw;
			VelocityDeltaAngle = MathLib.NormalizedDeltaRotator(ChrData.Velocity.Rotation(), ChrData.ActorRotation).Yaw;
			InputDirection = GetMoveDirectionByAngle(InputDeltaAngle, InputDirection, ChrData);
			VelocityDirection = GetMoveDirectionByAngle(VelocityDeltaAngle, VelocityDirection, ChrData);
			float y = LocomotionData.RelativeAcceleration.Y;
			float interpSpeed = ((FMath.Abs(y) > FMath.Abs(VelocityLeanAlpha)) ? 2f : 6f);
			VelocityLeanAlpha = FMath.FInterpTo(VelocityLeanAlpha, y, DeltaTime, interpSpeed);
			if (!bSwitchToLock)
			{
				FreeInputDirection = GetFreeTurnDirectionByAngle(InputDeltaAngle);
				if (Owner is ACharacter aCharacter)
				{
					UpdatePelvisTransformOffset(aCharacter.Mesh, DeltaTime);
				}
			}
		}
		else
		{
			InputDeltaAngle = 0f;
			InputVelocityAngle = 0f;
		}
		UpdateMovementBase(BasicData, ChrData, HelperData, DeltaTime);
		switch (BasicData.MoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			MaxAcceleration = WalkMaxAcceleration;
			BrakingDecelerationWalking = WalkBrakingDecelerationWalking;
			BrakingFriction = WalkBrakingFriction;
			break;
		case EMoveSpeedLevel.Run:
			MaxAcceleration = RunMaxAcceleration;
			BrakingDecelerationWalking = RunBrakingDecelerationWalking;
			BrakingFriction = RunBrakingFriction;
			break;
		case EMoveSpeedLevel.Sprint:
			MaxAcceleration = RushMaxAcceleration;
			BrakingDecelerationWalking = RushBrakingDecelerationWalking;
			BrakingFriction = RushBrakingFriction;
			break;
		}
	}

	private void UpdatePelvisTransformOffset(USkeletalMeshComponent Mesh, float DeltaTime)
	{
		if (!(Mesh == null))
		{
			FTransform socketTransform = Mesh.GetSocketTransform(B1GlobalFNames.ik_foot_root, ERelativeTransformSpace.RTS_Component);
			FVector location = Mesh.GetSocketTransform(B1GlobalFNames.VB_root_pelvis, ERelativeTransformSpace.RTS_Component).GetLocation();
			PelvisFootDistance = FMath.FInterpTo(PelvisFootDistance, location.Z - socketTransform.GetLocation().Z, DeltaTime, 3f);
			float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(AlphaRangle, PelvisAngleOffsetRange, VelocityLeanAlpha);
			FVector fVector = MathLib.RotateAngleAxis(location, mappedRangeValueClamped, socketTransform.GetRotation().GetForwardVector());
			MoveLoopPelvisLocationOffset = (location - fVector).Y * MoveLoopAlpha;
			MoveLoopPelvisAngleOffset = mappedRangeValueClamped * MoveLoopAlpha;
		}
	}

	private void UpdateMovementBase(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		bPlayWalkStart = false;
		bPlayRunStart = false;
		bPlayRushStart = false;
		bPlayStart = false;
		UpdateGaitGrounded(BasicData, ChrData);
		if (GaitGroundedState != EGaitGroundedState.None && GaitGroundedState != EGaitGroundedState.Idle)
		{
			MoveGaitGroundedState = GaitGroundedState;
		}
		float num = 0.3f;
		FVector2D outputRange = new FVector2D(1f - num, 1f + num);
		FRotator fRotator = ChrData.MoveAcceleration.Rotation();
		fRotator.Pitch = 0f;
		fRotator.Roll = 0f;
		switch (GaitGroundedState)
		{
		case EGaitGroundedState.None:
			GaitGroundedStateTemp = EGaitGroundedState.None;
			break;
		case EGaitGroundedState.Idle:
			GaitGroundedStateTemp = EGaitGroundedState.Idle;
			WalkStartAngle = 0f;
			RunStartAngle = 0f;
			RushStartAngle = 0f;
			StartAngle = 0f;
			break;
		case EGaitGroundedState.Walk:
		{
			if (GaitGroundedStateTemp != EGaitGroundedState.Walk)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				float startAngle = (WalkStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw);
				StartAngle = startAngle;
				GaitGroundedStateTemp = EGaitGroundedState.Walk;
				bool flag = (bPlayWalkStart = true);
				bPlayStart = flag;
			}
			float num2 = BasicData.JogBaseSpeed * num;
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.speed, out var OutCurveValue3);
			AnimRateWalk = FMath.GetMappedRangeValueClamped(new FVector2D(0f - num2, num2), outputRange, BasicData.Speed - OutCurveValue3);
			break;
		}
		case EGaitGroundedState.Run:
		{
			if (GaitGroundedStateTemp != EGaitGroundedState.Run)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				float startAngle = (RunStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw);
				StartAngle = startAngle;
				GaitGroundedStateTemp = EGaitGroundedState.Run;
				bool flag = (bPlayRunStart = true);
				bPlayStart = flag;
			}
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.speed, out var OutCurveValue);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.ChangeAnimRate, out var OutCurveValue2);
			float num2 = BasicData.RunSpeed * num;
			AnimRateRun = FMath.GetMappedRangeValueClamped(new FVector2D(0f - num2, num2), outputRange, BasicData.Speed - OutCurveValue);
			AnimRateRunLock = ((OutCurveValue2 == 1f && OutCurveValue != 0f) ? AnimRateRun : 1f);
			break;
		}
		case EGaitGroundedState.Rush:
			if (GaitGroundedStateTemp != EGaitGroundedState.Rush)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				float startAngle = (RushStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw);
				StartAngle = startAngle;
				GaitGroundedStateTemp = EGaitGroundedState.Rush;
				bool flag = (bPlayRushStart = true);
				bPlayStart = flag;
			}
			break;
		}
	}

	private void UpdateGaitGrounded(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData)
	{
		if (ChrData.MoveAcceleration.IsNearlyZero())
		{
			if (GaitGroundedState != EGaitGroundedState.Idle)
			{
				bInFreeTurn = false;
				GaitGroundedState = EGaitGroundedState.Idle;
			}
			return;
		}
		bool flag = !bSwitchToLock || LockMode != ELMLockMode.Normal;
		float num = (bSwitchToLock ? 135f : 60f);
		if ((BasicData.Speed > 0.1f && flag && !bInFreeTurn && FMath.Abs(InputVelocityAngle) > num) || bSwitchingLockState)
		{
			if (GaitGroundedState != EGaitGroundedState.Idle)
			{
				GaitGroundedState = EGaitGroundedState.Idle;
			}
			bInFreeTurn = true;
			return;
		}
		if (bInFreeTurn && FMath.Abs(InputVelocityAngle) <= num)
		{
			bInFreeTurn = false;
		}
		switch (BasicData.MoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			if (GaitGroundedState != EGaitGroundedState.Walk)
			{
				GaitGroundedState = EGaitGroundedState.Walk;
			}
			break;
		case EMoveSpeedLevel.Run:
			if (GaitGroundedState != EGaitGroundedState.Run)
			{
				GaitGroundedState = EGaitGroundedState.Run;
			}
			break;
		case EMoveSpeedLevel.Sprint:
			if (GaitGroundedState != EGaitGroundedState.Rush)
			{
				GaitGroundedState = EGaitGroundedState.Rush;
			}
			break;
		}
	}

	private EMoveDirectionFive GetFreeTurnDirectionByAngle(float InAngle)
	{
		if (FMath.Abs(InAngle) <= 45f)
		{
			return EMoveDirectionFive.F;
		}
		if (InAngle <= -135f)
		{
			return EMoveDirectionFive.BL;
		}
		if (InAngle >= 135f)
		{
			return EMoveDirectionFive.BR;
		}
		if (-135f < InAngle && InAngle < 0f)
		{
			return EMoveDirectionFive.L;
		}
		if (0f < InAngle && InAngle < 135f)
		{
			return EMoveDirectionFive.R;
		}
		return EMoveDirectionFive.None;
	}

	private ELockMoveDirectionSix GetMoveDirectionByAngle(float InAngle, ELockMoveDirectionSix CurrentDirection, IBUC_ABPCharacterData ChrData)
	{
		if (ChrData.Velocity.IsZero())
		{
			return ELockMoveDirectionSix.None;
		}
		float buffer = 15f;
		float buffer2 = 7.5f;
		switch (CurrentDirection)
		{
		case ELockMoveDirectionSix.F:
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.F;
			AngleRangeList[1] = ELockMoveDirectionSix.B;
			AngleRangeList[2] = ELockMoveDirectionSix.FL;
			AngleRangeList[3] = ELockMoveDirectionSix.FR;
			AngleRangeList[4] = ELockMoveDirectionSix.BL;
			AngleRangeList[5] = ELockMoveDirectionSix.BR;
			break;
		case ELockMoveDirectionSix.FL:
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.FL;
			AngleRangeList[1] = ELockMoveDirectionSix.BR;
			AngleRangeList[2] = ELockMoveDirectionSix.F;
			AngleRangeList[3] = ELockMoveDirectionSix.B;
			AngleRangeList[4] = ELockMoveDirectionSix.FR;
			AngleRangeList[5] = ELockMoveDirectionSix.BL;
			break;
		case ELockMoveDirectionSix.FR:
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.FR;
			AngleRangeList[1] = ELockMoveDirectionSix.BL;
			AngleRangeList[2] = ELockMoveDirectionSix.F;
			AngleRangeList[3] = ELockMoveDirectionSix.B;
			AngleRangeList[4] = ELockMoveDirectionSix.FL;
			AngleRangeList[5] = ELockMoveDirectionSix.BR;
			break;
		case ELockMoveDirectionSix.BL:
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.BL;
			AngleRangeList[1] = ELockMoveDirectionSix.FR;
			AngleRangeList[2] = ELockMoveDirectionSix.B;
			AngleRangeList[3] = ELockMoveDirectionSix.F;
			AngleRangeList[4] = ELockMoveDirectionSix.FL;
			AngleRangeList[5] = ELockMoveDirectionSix.BR;
			break;
		case ELockMoveDirectionSix.BR:
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.BR;
			AngleRangeList[1] = ELockMoveDirectionSix.FL;
			AngleRangeList[2] = ELockMoveDirectionSix.B;
			AngleRangeList[3] = ELockMoveDirectionSix.F;
			AngleRangeList[4] = ELockMoveDirectionSix.FR;
			AngleRangeList[5] = ELockMoveDirectionSix.BL;
			break;
		case ELockMoveDirectionSix.B:
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(buffer);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(buffer2);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.B;
			AngleRangeList[1] = ELockMoveDirectionSix.F;
			AngleRangeList[2] = ELockMoveDirectionSix.BL;
			AngleRangeList[3] = ELockMoveDirectionSix.BR;
			AngleRangeList[4] = ELockMoveDirectionSix.FL;
			AngleRangeList[5] = ELockMoveDirectionSix.FR;
			break;
		default:
			MoveDirAngleRange[ELockMoveDirectionSix.F].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.B].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.FR].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BL].SetBuffer(0f);
			MoveDirAngleRange[ELockMoveDirectionSix.BR].SetBuffer(0f);
			AngleRangeList[0] = ELockMoveDirectionSix.F;
			AngleRangeList[1] = ELockMoveDirectionSix.B;
			AngleRangeList[2] = ELockMoveDirectionSix.FL;
			AngleRangeList[3] = ELockMoveDirectionSix.FR;
			AngleRangeList[4] = ELockMoveDirectionSix.BL;
			AngleRangeList[5] = ELockMoveDirectionSix.BR;
			break;
		}
		for (int i = 0; i < AngleRangeList.Count; i++)
		{
			ELockMoveDirectionSix eLockMoveDirectionSix = AngleRangeList[i];
			if (b1.AngleRange.IsInRange(InAngle, MoveDirAngleRange[eLockMoveDirectionSix]))
			{
				return eLockMoveDirectionSix;
			}
		}
		return ELockMoveDirectionSix.None;
	}

	public FRotator GetRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		FRotator target = ChrData.MoveAcceleration.Rotation();
		target.Pitch = 0f;
		target.Roll = 0f;
		PriTargetRotation = FMath.RInterpConstantTo(PriTargetRotation, target, DeltaTime, 1000f);
		SecTargetRotation = FMath.RInterpTo(SecTargetRotation, PriTargetRotation, DeltaTime, 6f);
		float OutCurveValue;
		bool floatAnimCurveValue = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out OutCurveValue);
		float stateMachineWeight = HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded, in B1GlobalFNames.Move);
		float num = 0f - StartAngle;
		float x = ((stateMachineWeight == 0f || bPlayStart) ? num : (OutCurveValue / stateMachineWeight));
		x = ((num > 0f) ? FMath.Clamp(x, 0f, num) : FMath.Clamp(x, num, 0f));
		if (!bPlayStart && !floatAnimCurveValue && FMath.Abs(StartAngle) > 0f)
		{
			PriTargetRotation = FMath.RInterpConstantTo(ChrData.ActorRotation, target, DeltaTime, 1000f);
			SecTargetRotation = FMath.RInterpTo(ChrData.ActorRotation, PriTargetRotation, DeltaTime, 6f);
			x = 0f;
			WalkStartAngle = 0f;
			RunStartAngle = 0f;
			RushStartAngle = 0f;
			StartAngle = 0f;
		}
		return new FRotator(SecTargetRotation.Pitch, SecTargetRotation.Yaw + x, SecTargetRotation.Roll);
	}

	public void SetupMoveLoop()
	{
		VelocityDirection = InputDirection;
	}

	public void UpdateMoveLoopAlpha(float DeltaTime)
	{
		MoveLoopAlpha = FMath.FInterpTo(MoveLoopAlpha, 1f, DeltaTime, 2f);
	}

	public void ResetMoveLoopAlpha()
	{
		MoveLoopAlpha = 0f;
	}
}
