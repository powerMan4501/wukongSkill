using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Prediction;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_JumpComp : UActorCompBaseCS
{
	private b1.BUC_JumpData JumpData;

	private IBUC_MovementData MovementData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_ABPJumpV2Data JumpV2_AnimData;

	private IBUC_FallDyingData FallDyingData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_ManualSplineMoveData ManualSplineMoveData;

	private TStrongObjectPtr<UBGUCharacterMovementComponent> mMoveComp = new TStrongObjectPtr<UBGUCharacterMovementComponent>();

	private UBGUCharacterMovementComponent CppCharacterMovementComp
	{
		get
		{
			return mMoveComp.Get();
		}
		set
		{
			mMoveComp.Set(value);
		}
	}

	public override void OnAttach()
	{
		JumpData = RequireWritableData<b1.BUC_JumpData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		JumpV2_AnimData = RequireReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>();
		FallDyingData = RequireReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		ManualSplineMoveData = RequireReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>();
		CppCharacterMovementComp = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		base.BUSEventCollection.Evt_TriggerJumpSkill.Predict += new GSDel_TriggerJumpSkill_IPK_Del.Del_Predict(TriggerJumpSkill_Predict);
		base.BUSEventCollection.Evt_TriggerJumpSkill.Cue += new GSDel_TriggerJumpSkill_IPK_Del.Del_Predict(TriggerJumpSkill);
		base.BUSEventCollection.Evt_TriggerStrideJump += new Del_Void_Float(OnTriggerStrideJump);
		base.BUSEventCollection.Evt_OnRealJump += new Del_Void_Bool(DoRealJump);
		base.BUSEventCollection.Evt_Jump_OnReleased += new Del_Void(OnReleased);
		base.BUSEventCollection.Evt_JumpBreak += new Del_Void(JumpBreak);
		base.BUSEventCollection.Evt_OnAIRealJump += new Del_Void_Bool(DoAIRealJump);
		base.BUSEventCollection.Evt_AIJumpEnd += new Del_Void(OnJumpEnd);
		base.BUSEventCollection.Evt_FallingStart += new Del_Void(OnFallingStart);
		base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
	}

	public override void OnBeginPlay()
	{
		InitData();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CheckJumpOffState())
		{
			JumpBreak();
		}
		else
		{
			JumpAttackProtectTimer_Tick(DeltaTime);
		}
	}

	private void InitData()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		JumpData.Default_JumpZVelocity = bGUCharacterCS.CharacterMovement.JumpZVelocity;
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(bGUCharacterCS.GetResID(), Owner);
		if (playerCommDesc == null)
		{
			return;
		}
		JumpData.JumpSkillID.Add(EJumpType.None, -1);
		JumpData.JumpSkillID.Add(EJumpType.Normal, playerCommDesc.JumpSkillID);
		JumpData.JumpSkillID.Add(EJumpType.GlideJump, playerCommDesc.GlideJumpSkillID);
		JumpData.JumpAttackProtectTime = playerCommDesc.AirAtkJumpProtectTime;
		foreach (int item in playerCommDesc.JumpBuffID)
		{
			JumpData.JumpBuffID.Add(item);
		}
	}

	private void OnFallingStart()
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !JumpData.IsInJump())
		{
			JumpData.StartFallHeight = CheckStartFallHeight();
			if (base.BUSEventCollection != null)
			{
				base.BUSEventCollection.Evt_CheckLittleFall.Invoke(JumpData.StartFallHeight);
			}
		}
	}

	private void OnLanded()
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && JumpData.IsInJump())
		{
			JumpBreak();
		}
	}

	private void OnTriggerStrideJump(float ObstacleHeight)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null) && UnitCanStrideJump())
		{
			JumpData.JumpType = EJumpType.StrideJump;
			JumpData.ObstacleHeight_StrideJump = ObstacleHeight;
			float num = ((ObstacleHeight > 0f) ? (ObstacleHeight + aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() / 2f) : (aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() / 4f));
			float gravityZ = aCharacter.CharacterMovement.GetGravityZ();
			float jumpZVelocity = FMath.Sqrt(2f * (0f - gravityZ) * num);
			OnSetJumpZVelocity(jumpZVelocity);
			aCharacter.Jump();
			JumpData.BIsInJump = true;
			JumpData.CurrentJumpDir = ESkillDirection.Forward;
			JumpData.CurrenrJumpMoveDirection = aCharacter.GetActorForwardVector();
			if (base.BUSEventCollection != null)
			{
				base.BUSEventCollection.Evt_DoJumpAnim.Invoke(bIsJumping: true, JumpData.CurrentJumpDir, JumpData.CurStartJumpSpdState, JumpData.JumpType);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.JumpMovingStart, -1f);
				base.BUSEventCollection.Evt_OnJumpStart.Invoke(JumpData.CurrenrJumpMoveDirection);
				base.BUSEventCollection.Evt_NotifyStrideJumpHeight.Invoke(ObstacleHeight);
			}
		}
	}

	private void TriggerJumpSkill_Predict(ESkillDirection StartJumpDir, FVector2D CurrentInputVector, GSPredictionKey PredictionKey)
	{
		TriggerJumpSkill(StartJumpDir, CurrentInputVector, null);
	}

	private void TriggerJumpSkill(ESkillDirection StartJumpDir, FVector2D CurrentInputVector, GSPredictionKey PredictionKey)
	{
		TriggerJumpSkill(StartJumpDir, CurrentInputVector);
	}

	private void TriggerJumpSkill(ESkillDirection StartJumpDir, FVector2D CurrentInputVector)
	{
		if (!(GetOwner() == null) && UnitCanJump() && base.BUSEventCollection != null && !BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(GetOwner()).HasSimpleState(EBGUSimpleState.UseCarMontageMoveMode))
		{
			InitJumpType();
			if (JumpData.JumpType == EJumpType.GlideJump)
			{
				StartJumpDir = ESkillDirection.Forward;
			}
			JumpData.CurrentJumpDir = StartJumpDir;
			if (UnitStateData.HasState(EBGUUnitState.Sprinting))
			{
				JumpData.CurStartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Fast;
			}
			else if (StartJumpDir != ESkillDirection.None)
			{
				JumpData.CurStartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Normal;
			}
			else
			{
				JumpData.CurStartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Zero;
			}
			JumpData.CurrentJumpInputVector = CurrentInputVector;
			JumpData.Jump_with_LookatTarget = false;
			if (UnitStateData.HasState(EBGUUnitState.SideWalking))
			{
				JumpData.Jump_with_LookatTarget = true;
			}
			DoRealJump(bDoJump: true);
		}
	}

	private bool UnitCanStrideJump()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			return false;
		}
		if (!UnitStateData.HasState(EBGUUnitState.JumpWindow) && UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			return false;
		}
		if (bGUCharacterCS.CharacterMovement.IsFalling())
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.JumpMoving))
		{
			return false;
		}
		if (FallDyingData.GetFallDyingState() != EFallDyingState.Alive)
		{
			return false;
		}
		if (ManualSplineMoveData.IsManuaslSplineMovingWithSpecialAnimation())
		{
			return false;
		}
		return true;
	}

	private bool UnitCanJump()
	{
		if (!UnitCanStrideJump())
		{
			return false;
		}
		if (JumpV2_AnimData.bIsInLandCantJumpTime)
		{
			return false;
		}
		return true;
	}

	private void InitJumpType()
	{
		JumpData.JumpType = EJumpType.Normal;
		if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			JumpData.JumpType = EJumpType.GlideJump;
		}
	}

	private void DoRealJump(bool bDoJump)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		if (bDoJump)
		{
			if (JumpV2_AnimData == null)
			{
				return;
			}
			IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(Owner);
			if (readOnlyData != null && readOnlyData.CurrentCastingSkillID > 0)
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.StartJump, 0f);
			}
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection?.Evt_UnitTryBreakSkill.Invoke("跳跃");
			if (bGUCharacterCS.GetCurrentMontage() != null)
			{
				bGUCharacterCS.StopAnimMontage(null);
			}
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null)
			{
				if (JumpData.JumpType == EJumpType.Normal)
				{
					if (JumpData.CurrentJumpDir == ESkillDirection.None)
					{
						JumpData.CurrenrJumpMoveDirection = FVector.ZeroVector;
					}
					else
					{
						JumpData.CurrenrJumpMoveDirection = MovementData.GetCurrentWorldInputVec(bGUCharacterCS);
					}
				}
				else
				{
					FVector actorForwardVector = bGUCharacterCS.GetActorForwardVector();
					FVector actorRightVector = bGUCharacterCS.GetActorRightVector();
					FVector currenrJumpMoveDirection = actorForwardVector;
					switch (JumpData.CurrentJumpDir)
					{
					case ESkillDirection.Forward:
						currenrJumpMoveDirection = actorForwardVector;
						break;
					case ESkillDirection.Backward:
						currenrJumpMoveDirection = actorForwardVector * -1.0;
						break;
					case ESkillDirection.Left:
						currenrJumpMoveDirection = actorRightVector * -1.0;
						break;
					case ESkillDirection.Right:
						currenrJumpMoveDirection = actorRightVector;
						break;
					}
					JumpData.CurrenrJumpMoveDirection = currenrJumpMoveDirection;
				}
				if (JumpData.CurrentJumpDir != ESkillDirection.None)
				{
					base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxAcceleration, uBGUCharacterMovementComponent.MaxAcceleration * 100f);
					JumpData.MaxAccelerationHandleID = PropMgrData.GetLastHandleID();
				}
			}
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(bGUCharacterCS.GetResID(), Owner);
			if (playerCommDesc != null)
			{
				switch (JumpData.CurrentJumpDir)
				{
				default:
					JumpData.JumpRotSpd = 0f;
					break;
				case ESkillDirection.Forward:
					JumpData.JumpRotSpd = playerCommDesc.LockJumpRotSpdF;
					break;
				case ESkillDirection.Backward:
					JumpData.JumpRotSpd = playerCommDesc.LockJumpRotSpdB;
					break;
				case ESkillDirection.Left:
					JumpData.JumpRotSpd = playerCommDesc.LockJumpRotSpdL;
					break;
				case ESkillDirection.Right:
					JumpData.JumpRotSpd = playerCommDesc.LockJumpRotSpdR;
					break;
				}
			}
			else
			{
				JumpData.JumpRotSpd = 1000f;
			}
			JumpData.LastStartJumpPoint = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			JumpData.LastJumpDir = JumpData.CurrenrJumpMoveDirection;
			JumpData.BIsInJump = true;
			if (base.BUSEventCollection != null)
			{
				base.BUSEventCollection.Evt_DoJumpAnim.Invoke(bIsJumping: true, JumpData.CurrentJumpDir, JumpData.CurStartJumpSpdState, JumpData.JumpType);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.JumpMovingStart, -1f);
				base.BUSEventCollection.Evt_OnJumpStart.Invoke(JumpData.CurrenrJumpMoveDirection);
			}
			PocessJump();
		}
		else
		{
			JumpBreak();
		}
	}

	private void PocessJump()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (!(uBGUCharacterMovementComponent == null))
		{
			base.BUSEventCollection.Evt_OnSetJumpSpeedRate.Invoke();
			uBGUCharacterMovementComponent.Velocity = uBGUCharacterMovementComponent.GetCurrentAcceleration().GetSafeNormal2D() * uBGUCharacterMovementComponent.GetMaxSpeed();
			bGUCharacterCS.Jump();
			float customJumpVelocityIncrement = 0f;
			bool flag = false;
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo != null && targetInfo.LockTargetActor != null && targetInfo.LockTargetWayType == ELockTargetWayType.Manual)
			{
				flag = true;
				customJumpVelocityIncrement = JumpV2_AnimData.CustomJumpVelocityIncrementWhenPressed_Locked;
			}
			if (!flag)
			{
				customJumpVelocityIncrement = JumpV2_AnimData.CustomJumpVelocityIncrementWhenPressed;
			}
			uBGUCharacterMovementComponent.SetCustomJumpVelocityIncrement(customJumpVelocityIncrement);
			OnJumpStart();
		}
	}

	private void OnJumpStart()
	{
		JumpAttackProtectTimer_StartTick();
		JumpBuffBegin();
	}

	private void OnReleased()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (!(uBGUCharacterMovementComponent == null))
			{
				uBGUCharacterMovementComponent.SetCustomJumpVelocityIncrement(0f);
			}
		}
	}

	private void DoAIRealJump(bool bDoJump)
	{
		JumpData.CurrentJumpDir = ESkillDirection.Forward;
		if (UnitStateData.HasState(EBGUUnitState.Sprinting))
		{
			JumpData.CurStartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Fast;
		}
		else
		{
			JumpData.CurStartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Normal;
		}
		DoRealJump(bDoJump);
	}

	private void JumpBreak()
	{
		if (!JumpData.BIsInJump)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			bGUCharacterCS.StopJumping();
			JumpData.BIsInJump = false;
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null)
			{
				uBGUCharacterMovementComponent.CustomJumpMoveBreak();
			}
			JumpData.JumpType = EJumpType.None;
			JumpData.ObstacleHeight_StrideJump = 0f;
			JumpData.CurrenrJumpMoveDirection = FVector.ZeroVector;
			JumpData.Jump_with_LookatTarget = false;
			base.BUSEventCollection.Evt_ResetProperty.Invoke(JumpData.MaxAccelerationHandleID);
			JumpData.MaxAccelerationHandleID = 0u;
			base.BUSEventCollection.Evt_DoJumpAnim.Invoke(bIsJumping: false);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.JumpMovingStop, -1f);
			base.BUSEventCollection.Evt_OnJumpEnd.Invoke();
			JumpAttackProtectTimer_Clear();
			JumpBuffRemove();
			ResetJumpZVelocity();
		}
	}

	private float CheckStartFallHeight()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return -1f;
		}
		UCapsuleComponent capsuleComponent = aCharacter.CapsuleComponent;
		List<AActor> actorsToIgnore = new List<AActor>();
		USystemLibrary.LineTraceSingleByProfile(aCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter), BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) - new FVector(0.0, 0.0, capsuleComponent.GetScaledCapsuleHalfHeight() * 4f), B1GlobalFNames.Pawn, bTraceComplex: false, actorsToIgnore, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 10f);
		if (!OutHit.BlockingHit)
		{
			return -1f;
		}
		if (!aCharacter.CharacterMovement.IsWalkable(OutHit))
		{
			return -1f;
		}
		return BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter).Z - capsuleComponent.GetScaledCapsuleHalfHeight() - (float)OutHit.Location.Z;
	}

	private void OnJumpEnd()
	{
		if (!base.BUSEventCollection.IsNullOrDestroyed())
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, 0.01f);
		}
		JumpData.BIsInJump = false;
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		JumpBreak();
	}

	private void JumpAttackProtectTimer_StartTick()
	{
		JumpData.JumpAttackProtectTimer = JumpData.JumpAttackProtectTime;
	}

	private bool CheckJumpOffState()
	{
		if (CppCharacterMovementComp != null)
		{
			return CppCharacterMovementComp.IsInJumpOffAdjust();
		}
		return false;
	}

	private void JumpAttackProtectTimer_Tick(float DeltaTime)
	{
		if (JumpData.JumpAttackProtectTimer > 0f)
		{
			JumpData.JumpAttackProtectTimer -= DeltaTime;
		}
	}

	private void JumpAttackProtectTimer_Clear()
	{
		JumpData.JumpAttackProtectTimer = -1f;
	}

	private void JumpBuffBegin()
	{
		if (JumpData.JumpBuffID == null || JumpData.JumpBuffID.Count < 1 || !(base.BUSEventCollection != null))
		{
			return;
		}
		foreach (int item in JumpData.JumpBuffID)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, 0f, EBuffSourceType.Jump);
		}
	}

	private void JumpBuffRemove()
	{
		if (JumpData.JumpBuffID == null || JumpData.JumpBuffID.Count < 1 || !(base.BUSEventCollection != null))
		{
			return;
		}
		foreach (int item in JumpData.JumpBuffID)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(item, EBuffEffectTriggerType.None, 1);
		}
	}

	private void OnSetJumpZVelocity(float JumpZVelocity)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			bGUCharacterCS.CharacterMovement.JumpZVelocity = JumpZVelocity;
		}
	}

	private void ResetJumpZVelocity()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			bGUCharacterCS.CharacterMovement.JumpZVelocity = JumpData.Default_JumpZVelocity;
		}
	}

	private void OnUnitCastSkillSuccess(int MappingSkillId, int OriSkillID, ECastSkillSourceType SourceType)
	{
		JumpBreak();
	}
}
