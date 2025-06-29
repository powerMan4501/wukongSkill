using System.Collections.Generic;
using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPPlayerLocomotionData : IBUC_ABPPlayerLocomotionData
{
	private float LockTurnStopTimer;

	private bool bIsAI;

	private Dictionary<ELockMoveDirectionSix, FName> LockMoveDir2StateName = new Dictionary<ELockMoveDirectionSix, FName>
	{
		{
			ELockMoveDirectionSix.None,
			B1GlobalFNames.None
		},
		{
			ELockMoveDirectionSix.F,
			B1GlobalFNames.Fwd
		},
		{
			ELockMoveDirectionSix.B,
			B1GlobalFNames.Bwd
		},
		{
			ELockMoveDirectionSix.FL,
			B1GlobalFNames.Left_f
		},
		{
			ELockMoveDirectionSix.FR,
			B1GlobalFNames.Right_f
		},
		{
			ELockMoveDirectionSix.BL,
			B1GlobalFNames.Left_b
		},
		{
			ELockMoveDirectionSix.BR,
			B1GlobalFNames.Right_b
		}
	};

	private IBUC_MovementData MovementData;

	public UCurveVector FreeMovementCurve { get; set; }

	public UCurveVector LockMovementCurve { get; set; }

	public UCurveFloat LockRotationRateCurve { get; set; }

	public ELockMoveDirectionSix LockMoveDirection { get; set; }

	public ELockMoveDirectionSix LastLockMoveDirection { get; set; }

	public FRotator TargetRotation { get; set; }

	public float FreeAdditiveMovingLeanX { get; set; }

	public float FreeAdditiveMovingLeanY { get; set; }

	public float FreeAdditiveMovingLeanAlpha { get; set; }

	public float FreeAdditiveMovingLeanSmoothX { get; set; }

	public float FreeAdditiveMovingLeanSmoothY { get; set; }

	public bool bSwitchToLock { get; set; }

	public bool bSwitchingLockState { get; set; }

	public bool bShouldWaitRotateFinished { get; set; }

	public EMoveDirection TargetLockMoveDirection { get; set; }

	public float TargetLockMoveDeltaAngle { get; set; }

	public ELockMoveDirectionSix LockMoveDirectionStart { get; set; }

	public ELockMoveDirectionSix LockMoveDirectionStop { get; set; }

	public FVector4 InputBlendAlpha { get; set; }

	public FVector4 VelocityBlendAlpha { get; set; }

	public FVector4 VelocityBlendAlphaStop { get; set; }

	public FVector LastFallingVelocity { get; set; }

	public int RandomIdleIndex { get; set; }

	public FRotator PriTargetRotation { get; set; }

	public FRotator SecTargetRotation { get; set; }

	public EGaitGroundedState GaitGroundedState { get; set; }

	public EGaitGroundedState LastMoveGaitGroundedState { get; set; }

	public EGaitGroundedState GaitGroundedStateTemp { get; set; }

	public bool bPlayWalkStart { get; set; }

	public bool bPlayRunStart { get; set; }

	public bool bPlayRushStart { get; set; }

	public float CurveMoveSpeedScale { get; set; }

	public float WalkStartAngle { get; set; }

	public float RunStartAngle { get; set; }

	public float RushStartAngle { get; set; }

	public float AnimRateWalk { get; set; }

	public float AnimRateRun { get; set; }

	public float AnimRateRush { get; set; }

	public float AnimRateRunLock { get; set; }

	public float VelocityDeltaAngleTemp { get; set; }

	public float VelocityDeltaAngleWalk { get; set; }

	public float VelocityDeltaAngleRun { get; set; }

	public float VelocityDeltaAngleRush { get; set; }

	public float InputDeltaAngle { get; set; }

	public float SlopeAngle { get; set; }

	public float VelocityDeltaAngleWhenTurnLast { get; set; }

	public float VelocityDeltaAngleWhenTurn { get; set; }

	public float VelocityDeltaAngle { get; set; }

	public float StopFreeTimer { get; set; }

	public bool bInFreeTurn { get; set; }

	public ELockMoveDirectionSix LockTurnStopDir { get; set; }

	public bool bLockMoveFromTurnStop { get; set; }

	public bool bInLockMoveState { get; set; }

	public ELockMoveDirectionSix MaxAnimWeightLockMoveDir { get; set; }

	public bool bInSequenceTransition { get; set; }

	public bool bSequenceTransitionFromWalk { get; set; }

	public bool bSequenceTransitionFromRun { get; set; }

	public bool bSequenceTransitionFromRush { get; set; }

	public void EnterLockMoveState()
	{
		LockTurnStopTimer = 0f;
	}

	public void EnterLockTurnStopState()
	{
		bLockMoveFromTurnStop = true;
		LockTurnStopTimer = 1.2f;
		VelocityDeltaAngleWhenTurn = VelocityDeltaAngleWhenTurnLast;
	}

	public void SetInSequenceTransition(bool bValue, IBUC_ABPCharacterData ChrData)
	{
		bInSequenceTransition = bValue;
		if (bInSequenceTransition)
		{
			bSequenceTransitionFromWalk = GaitGroundedState == EGaitGroundedState.Walk;
			bSequenceTransitionFromRun = GaitGroundedState == EGaitGroundedState.Run;
			bSequenceTransitionFromRush = GaitGroundedState == EGaitGroundedState.Rush;
			WalkStartAngle = 0f;
			RunStartAngle = 0f;
			RushStartAngle = 0f;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
		}
	}

	public void AfterSequenceTransition()
	{
		bSequenceTransitionFromWalk = false;
		bSequenceTransitionFromRun = false;
		bSequenceTransitionFromRush = false;
	}

	public void Init(AActor Owner, BUABPSettingData Setting, IBUC_MovementData InMovementData, bool InIsAI)
	{
		MovementData = InMovementData;
		bIsAI = InIsAI;
		if (b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.PlayerLocomotion, Setting))
		{
			BUABPPlayerLocomotionSettingData playerLocomotionSetting = Setting.PlayerLocomotionSetting;
			FreeMovementCurve = playerLocomotionSetting.Free.FreeMovementCurve;
			LockMovementCurve = playerLocomotionSetting.Lock.LockMovementCurve;
		}
	}

	public void Update(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPBGUCharacterData BGUData, IBUC_ABPCommonLocomotionData LocomotionData, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		UpdateLastFalling(ChrData);
		if (LockTurnStopTimer > 0f)
		{
			LockTurnStopTimer -= DeltaTime;
			if (LockTurnStopTimer <= 0f)
			{
				LockTurnStopTimer = 0f;
				bLockMoveFromTurnStop = false;
			}
		}
		if (SpecialMoveData.SpecialMovementMode != ESpecialMovementMode.GroundMove || CommonData.FinalABPMoveMode != EABPMoveMode.PlayerLocomotion)
		{
			if (LockMoveDirection != ELockMoveDirectionSix.None)
			{
				LastLockMoveDirection = LockMoveDirection;
				LockMoveDirection = ELockMoveDirectionSix.None;
			}
			bInFreeTurn = false;
			bShouldWaitRotateFinished = false;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
			GaitGroundedStateTemp = EGaitGroundedState.None;
			GaitGroundedState = EGaitGroundedState.None;
			MaxAnimWeightLockMoveDir = ELockMoveDirectionSix.None;
			return;
		}
		bSwitchingLockState = false;
		if (!ChrData.MoveAcceleration.IsNearlyZero())
		{
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
		}
		float target = 0f;
		float target2 = 0f;
		if (!bSwitchToLock)
		{
			target = LocomotionData.RelativeAcceleration.Y;
			target2 = LocomotionData.RelativeAcceleration.X;
		}
		FreeAdditiveMovingLeanX = FMath.FInterpTo(FreeAdditiveMovingLeanX, target, DeltaTime, 10f);
		FreeAdditiveMovingLeanY = FMath.FInterpTo(FreeAdditiveMovingLeanY, target2, DeltaTime, 10f);
		FreeAdditiveMovingLeanAlpha = 1f;
		EGaitGroundedState gaitGroundedState = GaitGroundedState;
		UpdateMovementBase(Owner, BasicData, ChrData, HelperData, DeltaTime);
		if (BasicData.Speed > 0.1f)
		{
			InputDeltaAngle = MathLib.NormalizedDeltaRotator(ChrData.ActorRotation, ChrData.MoveAcceleration.Rotation()).Yaw;
		}
		if (GaitGroundedState != EGaitGroundedState.Idle)
		{
			float velocityDeltaAngleWhenTurnLast = (VelocityDeltaAngle = MathLib.NormalizedDeltaRotator(ChrData.Velocity.Rotation(), ChrData.ActorRotation).Yaw);
			VelocityDeltaAngleWhenTurnLast = velocityDeltaAngleWhenTurnLast;
			if (bSwitchToLock)
			{
				if (gaitGroundedState == EGaitGroundedState.None || gaitGroundedState == EGaitGroundedState.Idle)
				{
					InputBlendAlpha = FVector4.ZeroVector;
				}
				FVector4 fVector = BGUFuncLibForMove.BGUCalcRelativeVectorDirectionAlpha(ChrData.MoveAcceleration, ChrData.ActorRotation);
				float num = FMath.FInterpConstantTo(InputBlendAlpha.X, fVector.X, DeltaTime, 2f);
				float num2 = FMath.FInterpConstantTo(InputBlendAlpha.Y, fVector.Y, DeltaTime, 2f);
				float num3 = FMath.FInterpConstantTo(InputBlendAlpha.Z, fVector.Z, DeltaTime, 2f);
				float num4 = FMath.FInterpConstantTo(InputBlendAlpha.W, fVector.W, DeltaTime, 2f);
				InputBlendAlpha = new FVector4(num, num2, num3, num4);
				fVector = BGUFuncLibForMove.BGUCalcRelativeVectorDirectionAlpha(ChrData.Velocity, ChrData.ActorRotation);
				num = FMath.FInterpTo(VelocityBlendAlpha.X, fVector.X, DeltaTime, 12f);
				num2 = FMath.FInterpTo(VelocityBlendAlpha.Y, fVector.Y, DeltaTime, 12f);
				num3 = FMath.FInterpTo(VelocityBlendAlpha.Z, fVector.Z, DeltaTime, 12f);
				num4 = FMath.FInterpTo(VelocityBlendAlpha.W, fVector.W, DeltaTime, 12f);
				VelocityBlendAlpha = new FVector4(num, num2, num3, num4);
				VelocityBlendAlphaStop = fVector;
				float yaw2 = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.ActorRotation).Yaw;
				float num5 = -70f;
				float num6 = 70f;
				float num7 = -110f;
				float num8 = 110f;
				float num9 = 5f;
				switch (TargetLockMoveDirection)
				{
				case EMoveDirection.Forward:
					num5 -= num9;
					num6 += num9;
					break;
				case EMoveDirection.Right:
					num6 -= num9;
					num8 += num9;
					break;
				case EMoveDirection.Backward:
					num7 += num9;
					num8 -= num9;
					break;
				case EMoveDirection.Left:
					num5 += num9;
					num7 -= num9;
					break;
				}
				if (num5 <= yaw2 && yaw2 <= num6)
				{
					TargetLockMoveDirection = EMoveDirection.Forward;
				}
				else if (num7 <= yaw2 && yaw2 < num5)
				{
					TargetLockMoveDirection = EMoveDirection.Left;
				}
				else if (num6 < yaw2 && yaw2 <= num8)
				{
					TargetLockMoveDirection = EMoveDirection.Right;
				}
				else
				{
					TargetLockMoveDirection = EMoveDirection.Backward;
				}
				if (0f <= yaw2 && yaw2 <= 90f)
				{
					LockMoveDirectionStart = ELockMoveDirectionSix.FR;
				}
				else if (90f < yaw2 && yaw2 <= 180f)
				{
					LockMoveDirectionStart = ELockMoveDirectionSix.BR;
				}
				else if (-90f <= yaw2 && yaw2 < 0f)
				{
					LockMoveDirectionStart = ELockMoveDirectionSix.FL;
				}
				else
				{
					LockMoveDirectionStart = ELockMoveDirectionSix.BL;
				}
				if (0f <= VelocityDeltaAngle && VelocityDeltaAngle <= 90f)
				{
					LockMoveDirectionStop = ELockMoveDirectionSix.FR;
				}
				else if (90f < VelocityDeltaAngle && VelocityDeltaAngle <= 180f)
				{
					LockMoveDirectionStop = ELockMoveDirectionSix.BR;
				}
				else if (-90f <= VelocityDeltaAngle && VelocityDeltaAngle < 0f)
				{
					LockMoveDirectionStop = ELockMoveDirectionSix.FL;
				}
				else
				{
					LockMoveDirectionStop = ELockMoveDirectionSix.BL;
				}
				TargetLockMoveDeltaAngle = yaw2;
			}
		}
		else
		{
			TargetLockMoveDirection = EMoveDirection.None;
		}
		if (ChrData.MoveAcceleration.IsNearlyZero() && BasicData.Speed < 10f)
		{
			LastLockMoveDirection = ELockMoveDirectionSix.None;
		}
		if (HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded_FreeNew, in B1GlobalFNames.StopFree) > 0f)
		{
			StopFreeTimer += DeltaTime;
		}
		bInLockMoveState = HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded_LockNew, in B1GlobalFNames.LockMoveState) > 0f;
		if (bInLockMoveState)
		{
			float stateMachineWeight = HelperData.GetStateMachineWeight(in B1GlobalFNames.LockGroundedLayerMain, LockMoveDir2StateName[LockMoveDirection]);
			float stateMachineWeight2 = HelperData.GetStateMachineWeight(in B1GlobalFNames.LockGroundedLayerMain, LockMoveDir2StateName[LastLockMoveDirection]);
			MaxAnimWeightLockMoveDir = ((stateMachineWeight >= stateMachineWeight2) ? LockMoveDirection : LastLockMoveDirection);
		}
		if (bShouldWaitRotateFinished && (BGUData.bSideWalking || ChrData.IsMontage || FVector.DotProduct(ChrData.LastMoveAccelerationNotZero.GetSafeNormal(), ChrData.ForwardVector) >= 0.99f))
		{
			bShouldWaitRotateFinished = false;
		}
	}

	private void UpdateMovementBase(AActor Owner, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		bPlayWalkStart = false;
		bPlayRunStart = false;
		bPlayRushStart = false;
		UpdateGaitGrounded(BasicData, ChrData, HelperData, DeltaTime);
		if (bInSequenceTransition)
		{
			return;
		}
		float num = 0.3f;
		FVector2D outputRange = new FVector2D(1f - num, 1f + num);
		FRotator fRotator = ChrData.MoveAcceleration.Rotation();
		fRotator.Pitch = 0f;
		fRotator.Roll = 0f;
		float OutCurveValue;
		float OutCurveValue2;
		switch (GaitGroundedState)
		{
		case EGaitGroundedState.None:
			GaitGroundedStateTemp = EGaitGroundedState.None;
			break;
		case EGaitGroundedState.Idle:
			GaitGroundedStateTemp = EGaitGroundedState.Idle;
			break;
		case EGaitGroundedState.Walk:
		{
			if (GaitGroundedStateTemp == EGaitGroundedState.Idle || GaitGroundedStateTemp == EGaitGroundedState.None)
			{
				bShouldWaitRotateFinished = true;
			}
			if (GaitGroundedStateTemp != EGaitGroundedState.Walk || bSwitchingLockState)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				WalkStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw;
				GaitGroundedStateTemp = EGaitGroundedState.Walk;
				bPlayWalkStart = true;
			}
			float num2 = BasicData.JogBaseSpeed * num;
			float OutCurveValue3 = 0f;
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.speed, out OutCurveValue3);
			AnimRateWalk = FMath.GetMappedRangeValueClamped(new FVector2D(0f - num2, num2), outputRange, BasicData.Speed - OutCurveValue3);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LoopLean, out OutCurveValue3);
			VelocityDeltaAngleWalk = GetFreeVelocityDeltaAngle(ChrData, 10f, DeltaTime) * OutCurveValue3;
			bLockMoveFromTurnStop = false;
			break;
		}
		case EGaitGroundedState.Run:
		{
			if (GaitGroundedStateTemp == EGaitGroundedState.Idle || GaitGroundedStateTemp == EGaitGroundedState.None)
			{
				bShouldWaitRotateFinished = true;
			}
			if (GaitGroundedStateTemp != EGaitGroundedState.Run || bSwitchingLockState)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				RunStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw;
				GaitGroundedStateTemp = EGaitGroundedState.Run;
				bPlayRunStart = true;
			}
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LoopLean, out OutCurveValue);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.speed, out OutCurveValue2);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.ChangeAnimRate, out var OutCurveValue4);
			float num2 = BasicData.RunSpeed * num;
			AnimRateRun = FMath.GetMappedRangeValueClamped(new FVector2D(0f - num2, num2), outputRange, BasicData.Speed - OutCurveValue2);
			VelocityDeltaAngleRun = GetFreeVelocityDeltaAngle(ChrData, 10f, DeltaTime) * OutCurveValue;
			FreeAdditiveMovingLeanSmoothX = FreeAdditiveMovingLeanX * OutCurveValue;
			FreeAdditiveMovingLeanSmoothY = FreeAdditiveMovingLeanY * OutCurveValue;
			AnimRateRunLock = ((OutCurveValue4 == 1f && OutCurveValue2 != 0f) ? AnimRateRun : 1f);
			if (!bSwitchToLock)
			{
				bLockMoveFromTurnStop = false;
			}
			break;
		}
		case EGaitGroundedState.Rush:
			if (GaitGroundedStateTemp == EGaitGroundedState.Idle || GaitGroundedStateTemp == EGaitGroundedState.None)
			{
				bShouldWaitRotateFinished = true;
			}
			if (GaitGroundedStateTemp != EGaitGroundedState.Rush || bSwitchingLockState)
			{
				WalkStartAngle = 0f;
				RunStartAngle = 0f;
				RushStartAngle = 0f;
				FRotator priTargetRotation = (SecTargetRotation = fRotator);
				PriTargetRotation = priTargetRotation;
				RushStartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw;
				GaitGroundedStateTemp = EGaitGroundedState.Rush;
				bPlayRushStart = true;
			}
			if (HelperData.GetStateMachineWeight(in B1GlobalFNames.RushState, in B1GlobalFNames.RushLoop) > 0f)
			{
				HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LoopLean, out OutCurveValue);
				float num2 = BasicData.SprintSpeed * num;
				HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.speed, out OutCurveValue2);
				AnimRateRush = FMath.GetMappedRangeValueClamped(new FVector2D(0f - num2, num2), outputRange, BasicData.Speed - OutCurveValue2);
				VelocityDeltaAngleRush = GetFreeVelocityDeltaAngle(ChrData, 9f, DeltaTime) * OutCurveValue * 0.5f;
				FreeAdditiveMovingLeanSmoothX = FreeAdditiveMovingLeanX * OutCurveValue;
				FreeAdditiveMovingLeanSmoothY = FreeAdditiveMovingLeanY * OutCurveValue;
			}
			else
			{
				VelocityDeltaAngleRush = 0f;
			}
			if (!bSwitchToLock)
			{
				bLockMoveFromTurnStop = false;
			}
			break;
		}
		if (!bSwitchToLock)
		{
			FVector SurfaceNormal_Normalized;
			FRotator a = BGUFunctionLibraryCS.BGUCalcCharacterRotOnSlope(Owner as ACharacter, out SurfaceNormal_Normalized);
			SlopeAngle = MathLib.NormalizedDeltaRotator(a, ChrData.ActorRotation).Pitch;
		}
	}

	private float GetFreeVelocityDeltaAngle(IBUC_ABPCharacterData ChrData, float InterpSpeed, float DeltaTime)
	{
		if (ChrData.MoveAcceleration.IsNearlyZero())
		{
			return 0f;
		}
		if (ChrData.Velocity.Size() < 10f)
		{
			return 0f;
		}
		float yaw = MathLib.NormalizedDeltaRotator(ChrData.Velocity.Rotation(), ChrData.ActorRotation).Yaw;
		VelocityDeltaAngleTemp = FMath.FInterpTo(VelocityDeltaAngleTemp, yaw, DeltaTime, InterpSpeed);
		return VelocityDeltaAngleTemp;
	}

	private void UpdateGaitGrounded(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		if (ChrData.MoveAcceleration.IsNearlyZero())
		{
			if (GaitGroundedState != EGaitGroundedState.Idle)
			{
				LastMoveGaitGroundedState = GaitGroundedState;
				GaitGroundedState = EGaitGroundedState.Idle;
				StopFreeTimer = 0f;
			}
			bInFreeTurn = false;
			CurveMoveSpeedScale = 1f;
			return;
		}
		float num = 60f;
		float yaw = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.Velocity.Rotation()).Yaw;
		bool flag = ChrData.IsLandingMove || FMath.Abs(yaw) > num;
		if (!bSwitchToLock && ((BasicData.Speed > 0.1f && !bInFreeTurn && flag) || bSwitchingLockState))
		{
			if (GaitGroundedState != EGaitGroundedState.Idle)
			{
				LastMoveGaitGroundedState = GaitGroundedState;
				GaitGroundedState = EGaitGroundedState.Idle;
				bShouldWaitRotateFinished = false;
				StopFreeTimer = (bSwitchingLockState ? 0f : 0.001f);
			}
			bInFreeTurn = true;
			CurveMoveSpeedScale = 0f;
			if (!ChrData.IsLandingMove)
			{
				return;
			}
		}
		if (bInFreeTurn && !flag)
		{
			bInFreeTurn = false;
		}
		EGaitGroundedState eGaitGroundedState = EGaitGroundedState.None;
		switch (BasicData.MoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			eGaitGroundedState = EGaitGroundedState.Walk;
			break;
		case EMoveSpeedLevel.Run:
			eGaitGroundedState = EGaitGroundedState.Run;
			break;
		case EMoveSpeedLevel.Sprint:
			eGaitGroundedState = EGaitGroundedState.Rush;
			break;
		}
		if (GaitGroundedState == eGaitGroundedState || !ShouldTurnToAnotherState(eGaitGroundedState, HelperData))
		{
			return;
		}
		if (bShouldWaitRotateFinished && GaitGroundedState == EGaitGroundedState.Idle)
		{
			bShouldWaitRotateFinished = false;
			return;
		}
		if (GaitGroundedState != EGaitGroundedState.Idle)
		{
			StopFreeTimer = 0f;
		}
		LastMoveGaitGroundedState = GaitGroundedState;
		GaitGroundedState = eGaitGroundedState;
	}

	private bool ShouldTurnToAnotherState(EGaitGroundedState TargetState, IBUC_ABPHelperData HelperData)
	{
		if (TargetState == EGaitGroundedState.Walk)
		{
			return true;
		}
		float num = 0f;
		float OutCurveValue = 0f;
		switch (GaitGroundedState)
		{
		case EGaitGroundedState.None:
		case EGaitGroundedState.Idle:
		case EGaitGroundedState.Walk:
			return true;
		case EGaitGroundedState.Run:
			num = HelperData.GetStateMachineWeight(in B1GlobalFNames.RunState, in B1GlobalFNames.SharpTurn);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out OutCurveValue);
			break;
		case EGaitGroundedState.Rush:
			num = HelperData.GetStateMachineWeight(in B1GlobalFNames.RushState, in B1GlobalFNames.SharpTurn);
			HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RushRotationAlpha, out OutCurveValue);
			break;
		}
		if (num == 0f)
		{
			return true;
		}
		return FMath.Abs(OutCurveValue) < 30f;
	}

	public FRotator GetRotationTarget(EMoveSpeedLevel MoveSpeedType, IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		int num;
		float num2;
		if (bShouldWaitRotateFinished)
		{
			num = (ChrData.MoveAcceleration.IsZero() ? 1 : 0);
			if (num != 0)
			{
				num2 = 15f;
				goto IL_0033;
			}
		}
		else
		{
			num = 0;
		}
		num2 = ((MoveSpeedType == EMoveSpeedLevel.Walk) ? 4f : 6f);
		goto IL_0033;
		IL_0033:
		float interpSpeed = num2;
		FRotator target = ((num != 0) ? ChrData.LastMoveAccelerationNotZero.Rotation() : ChrData.MoveAcceleration.Rotation());
		target.Pitch = 0f;
		target.Roll = 0f;
		PriTargetRotation = FMath.RInterpConstantTo(PriTargetRotation, target, DeltaTime, 1000f);
		SecTargetRotation = FMath.RInterpTo(SecTargetRotation, PriTargetRotation, DeltaTime, interpSpeed);
		bool flag = false;
		bool flag2 = false;
		float num3 = 0f;
		float OutCurveValue = 0f;
		float num4 = 0f;
		switch (MoveSpeedType)
		{
		case EMoveSpeedLevel.Walk:
			num3 = WalkStartAngle;
			flag = bPlayWalkStart;
			flag2 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.WalkRotationAlpha, out OutCurveValue);
			num4 = HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded_FreeNew, in B1GlobalFNames.WalkFree);
			break;
		case EMoveSpeedLevel.Run:
			num3 = RunStartAngle;
			flag = bPlayRunStart;
			flag2 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RunRotationAlpha, out OutCurveValue);
			num4 = HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded_FreeNew, in B1GlobalFNames.RunFree);
			break;
		case EMoveSpeedLevel.Sprint:
			num3 = RushStartAngle;
			flag = bPlayRushStart;
			flag2 = HelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RushRotationAlpha, out OutCurveValue);
			num4 = HelperData.GetStateMachineWeight(in B1GlobalFNames.MoveGrounded_FreeNew, in B1GlobalFNames.RushFree);
			break;
		}
		float num5 = 0f - num3;
		float x = ((num4 == 0f || flag) ? num5 : (OutCurveValue / num4));
		x = ((num5 > 0f) ? FMath.Clamp(x, 0f, num5) : FMath.Clamp(x, num5, 0f));
		if (!flag && !flag2 && FMath.Abs(num3) > 0f)
		{
			PriTargetRotation = FMath.RInterpConstantTo(ChrData.ActorRotation, target, DeltaTime, 1000f);
			SecTargetRotation = FMath.RInterpTo(ChrData.ActorRotation, PriTargetRotation, DeltaTime, interpSpeed);
			x = 0f;
			WalkStartAngle = 0f;
			RunStartAngle = 0f;
			RushStartAngle = 0f;
		}
		return new FRotator(SecTargetRotation.Pitch, SecTargetRotation.Yaw + x, SecTargetRotation.Roll);
	}

	private void UpdateLastFalling(IBUC_ABPCharacterData ChrData)
	{
		if (ChrData.IsFalling)
		{
			LastFallingVelocity = ChrData.Velocity;
		}
	}
}
