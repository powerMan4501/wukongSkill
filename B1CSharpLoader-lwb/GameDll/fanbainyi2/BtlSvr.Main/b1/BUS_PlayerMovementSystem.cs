using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlayerMovementSystem")]
public class BUS_PlayerMovementSystem : BUS_MovementSystem
{
	public override int GetTickGroupMask()
	{
		return 1088;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 1024:
			TickForEnvironmentInteraction();
			TickOnLandEvent();
			if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CantMove) && (JumpV2Data == null || !JumpV2Data.bIsInLandCantMoveTime))
			{
				if (!SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
				{
					TickForInterpolationMove(DeltaTime);
				}
				TickForTPSMode();
				TickPlayRotAM_ByCamRot(DeltaTime);
				TickAllowRotationWhenAttacking();
				TickForRecoverAMScaleRate(DeltaTime);
				TickForRecoverAMSpeedRate(DeltaTime);
				TickForBlendAnimRootMotion();
				TickForAlignCapsuleToSurface(DeltaTime);
			}
			break;
		case 64:
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantMove) || (JumpV2Data != null && JumpV2Data.bIsInLandCantMoveTime))
			{
				MoveStop();
				break;
			}
			TickMoveMode();
			TickSplineFlyDistance(DeltaTime);
			TickInputMoving(DeltaTime);
			TickForStartMoveInMoveWindow();
			TickForNavWalkOpt_ShouldMassiveModeON();
			TickForAMCurveMove(DeltaTime);
			bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen);
			if (MoveModes.ActiveMover != null && !flag)
			{
				MoveModes.ActiveMover.DoUpdate(DeltaTime);
				base.BUSEventCollection?.Evt_ActorForceUpdateTransform.Invoke();
			}
			break;
		}
		}
	}

	private void TickForTPSMode()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.TPSMode))
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo != null && targetInfo.LockTargetActor != null)
			{
				FVector fVector = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(targetInfo);
				USystemLibrary.DrawDebugPoint(Owner, fVector, 10f, FLinearColor.Yellow);
				base.BUSEventCollection?.Evt_TPSRotateToPos.Invoke(fVector, 9999f, bForceUpdate: false);
			}
			else
			{
				int valueInGameThread = GSGameplayCVar.CVar_TPModeRotateIncludedAngle.GetValueInGameThread();
				FVector fVector2 = aCharacter.GetControlRotation().Vector().RotateAngleAxis(valueInGameThread, new FVector(0.0, 0.0, 1.0));
				base.BUSEventCollection?.Evt_TPSRotateToPos.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) + fVector2 * 1000.0, 9999f, bForceUpdate: false);
			}
		}
	}

	private void TickInputMoving(float DeltaTime)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		FVector currentWorldInputVec = MovementData.GetCurrentWorldInputVec(aCharacter);
		MovementData.bInputMoving = currentWorldInputVec.Size() != 0f;
		if (MovementData.bInputMoving)
		{
			MovementData.InputMovingTimer += DeltaTime;
			MovementData.LastMoveWorldInputNotZero = currentWorldInputVec;
		}
		else
		{
			MovementData.InputMovingTimer = 0f;
		}
		float num = ((GSGameplayCVar.CVar_MoveForceWalk.GetValueInGameThread() > 0) ? 10f : 0.75f);
		float num2 = 0.05f;
		float num3 = currentWorldInputVec.Size();
		float num4 = MovementData.LastMoveWorldInput.Size();
		float num5 = FMath.Abs(num3 - num4) / DeltaTime;
		if (num3 < num - num2 && num3 > 0f && !MovementData.bJoypadTriggerWalk && (num3 > num4 || num5 < 1f))
		{
			MovementData.bJoypadTriggerWalk = true;
			MovementData.bWaitingJoypadWalkRelease = false;
			base.BUSEventCollection.Evt_UnitStateTriggerCMultiCast.Invoke(EBUStateTrigger.UnitInputWalkPressed, -1f);
		}
		if (MovementData.bJoypadTriggerWalk)
		{
			if (num3 >= num + num2)
			{
				MovementData.bJoypadTriggerWalk = false;
				MovementData.bWaitingJoypadWalkRelease = false;
				base.BUSEventCollection.Evt_UnitStateTriggerCMultiCast.Invoke(EBUStateTrigger.UnitInputWalkRelease, -1f);
			}
			else if (num3 == 0f)
			{
				MovementData.bJoypadTriggerWalk = false;
				MovementData.bWaitingJoypadWalkRelease = true;
			}
		}
		if (MovementData.bWaitingJoypadWalkRelease && ChrData.MoveAcceleration.IsNearlyZero())
		{
			MovementData.bWaitingJoypadWalkRelease = false;
			base.BUSEventCollection.Evt_UnitStateTriggerCMultiCast.Invoke(EBUStateTrigger.UnitInputWalkRelease, -1f);
		}
		MovementData.LastMoveWorldInput = currentWorldInputVec;
	}

	private void TickPlayRotAM_ByCamRot(float DeltaTime)
	{
		if (!MovementData.PlayRotAMByCamRot_Enable)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		if (MovementData.PlayRotAMByCamRot_ProtectTimer > 0f)
		{
			if (MovementData.PlayRotAMByCamRot_ProtectTimer == MovementData.PlayRotAMByCamRot_ProtectTotalTime)
			{
				MovementData.PlayRotAMByCamRot_ProtectTimer -= DeltaTime;
				return;
			}
			float num = 0f;
			MovementData.PlayRotAMByCamRot_ProtectTimer -= DeltaTime;
			if (!(MovementData.PlayRotAMByCamRot_ProtectTimer < 0f))
			{
				float num2 = MovementData.PlayRotAMByCamRot_ProtectTotalTime - MovementData.PlayRotAMByCamRot_ProtectTimer;
				num = ((num2 <= MovementData.PlayRotAMByCamRot_BlendInTime) ? FMath.Clamp(num2 / MovementData.PlayRotAMByCamRot_BlendInTime, 0f, 1f) : ((!(num2 >= MovementData.PlayRotAMByCamRot_ProtectTotalTime - MovementData.PlayRotAMByCamRot_BlendOutTime)) ? 1f : ((num2 + DeltaTime >= MovementData.PlayRotAMByCamRot_ProtectTotalTime) ? 0f : ((!(MovementData.PlayRotAMByCamRot_BlendOutTime <= 0f)) ? FMath.Clamp((MovementData.PlayRotAMByCamRot_ProtectTotalTime - num2) / MovementData.PlayRotAMByCamRot_BlendOutTime, 0f, 1f) : 0f))));
				ERotTypeInLargeAngle rotTypeInLargeAngle = MovementData.RotTypeInLargeAngle;
				if (rotTypeInLargeAngle != ERotTypeInLargeAngle.AMMatryoshka)
				{
					_ = 2;
				}
				else
				{
					base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka.Invoke(num);
				}
				return;
			}
			MovementData.PlayRotAMByCamRot_ProtectTimer = -1f;
			MovementData.PlayRotAMByCamRot_ProtectTotalTime = -1f;
			num = 0f;
			switch (MovementData.RotTypeInLargeAngle)
			{
			case ERotTypeInLargeAngle.AMMatryoshka:
				base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka.Invoke(num);
				break;
			}
		}
		AController controller = bGUCharacterCS.GetController();
		if (controller.IsNullOrDestroyed())
		{
			return;
		}
		BGUFuncLibActorTransformCS.BGUGetActorRotation(controller);
		BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS);
		FVector2D safeNormal = controller.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
		FVector2D safeNormal2 = bGUCharacterCS.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
		float num3 = MathLib.DegAcos(FVector2D.DotProduct(safeNormal, safeNormal2));
		if (num3 < MovementData.PlayRotAMByCamRot_AngleThreshold && MovementData.PlayRotAMByCamRot_RotateWithCamSpeed > 0f)
		{
			MovementData.PlayRotAMByCamRot_CacheTimer = -1f;
			if (MovementData.RotTypeInSmallAngle == ERotTypeInSmallAngle.SimpleRotate)
			{
				OnRotateWithCam(safeNormal.Conv_Vector2DToVector(), MovementData.PlayRotAMByCamRot_RotateWithCamSpeed);
			}
		}
		else
		{
			if (!(num3 >= MovementData.PlayRotAMByCamRot_AngleThreshold))
			{
				return;
			}
			if (MovementData.PlayRotAMByCamRot_CacheTimer < 0f)
			{
				MovementData.PlayRotAMByCamRot_CacheTimer = MovementData.PlayRotAMByCamRot_CacheTime;
				return;
			}
			MovementData.PlayRotAMByCamRot_CacheTimer -= DeltaTime;
			if (!(MovementData.PlayRotAMByCamRot_CacheTimer <= 0f))
			{
				return;
			}
			MovementData.PlayRotAMByCamRot_CacheTimer = -1f;
			FVector2D safeNormal3 = bGUCharacterCS.GetActorRightVector().Conv_VectorToVector2D().GetSafeNormal();
			if (!UGSE_AnimFuncLib.IsSlotPlayingMontage(bGUCharacterCS.Mesh.GetAnimInstance(), B1GlobalFNames.AMMatryoshka))
			{
				if (FVector2D.DotProduct(safeNormal, safeNormal3) > 0f)
				{
					BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, MovementData.PlayRotAMByCamRot_TurnR_AM, FName.None);
					MovementData.PlayRotAMByCamRot_ProtectTimer = MovementData.PlayRotAMByCamRot_TurnR_AM.SequenceLength;
					MovementData.PlayRotAMByCamRot_ProtectTotalTime = MovementData.PlayRotAMByCamRot_TurnR_AM.SequenceLength;
					MovementData.PlayRotAMByCamRot_CurRotAM = MovementData.PlayRotAMByCamRot_TurnR_AM;
				}
				else
				{
					BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, MovementData.PlayRotAMByCamRot_TurnL_AM, FName.None);
					MovementData.PlayRotAMByCamRot_ProtectTimer = MovementData.PlayRotAMByCamRot_TurnL_AM.SequenceLength;
					MovementData.PlayRotAMByCamRot_ProtectTotalTime = MovementData.PlayRotAMByCamRot_TurnL_AM.SequenceLength;
					MovementData.PlayRotAMByCamRot_CurRotAM = MovementData.PlayRotAMByCamRot_TurnR_AM;
				}
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) + safeNormal.Conv_Vector2DToVector() * 100000.0;
				MovementData.SetRotateInfo(fVector, MovementData.PlayRotAMByCamRot_TurnSpeed);
				SwitchMoverIfNeeded<BGU_AttackRotateMoveMode>(bAlwaysGenIdx: true);
				if (MoveModes.ActiveMover is BGU_AttackRotateMoveMode bGU_AttackRotateMoveMode)
				{
					bGU_AttackRotateMoveMode.BeginRotateToPos(MovementData.PlayRotAMByCamRot_TurnSpeed, fVector);
				}
			}
		}
	}

	private void TickAllowRotationWhenAttacking()
	{
		bool value = UnitStateData.HasState(EBGUUnitState.AttackRotation);
		if (MovementData.AllowPhysicsRotationDuringAnimRootMotionHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Movement_AllowPhysicsRotationDuringAnimRootMotion, value);
			MovementData.AllowPhysicsRotationDuringAnimRootMotionHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Movement_AllowPhysicsRotationDuringAnimRootMotion, value, MovementData.AllowPhysicsRotationDuringAnimRootMotionHandleID);
		}
	}

	private void TickForStartMoveInMoveWindow()
	{
		if (UnitStateData.HasState(EBGUUnitState.InMoveWindow))
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			if (!(aCharacter == null) && !(aCharacter.GetLastMovementInputVector().Size() < 0.001f))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.StartMoveInMoveWindow, 0f);
			}
		}
	}

	private void TickForNavWalkOpt_ShouldMassiveModeON()
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			return;
		}
		if (MovementData != null && MovementData.CharNavWalkOptLevelMap == null)
		{
			MovementData.CharNavWalkOptLevelMap = new Dictionary<TWeakObject<BGUCharacterCS>, int>();
			return;
		}
		List<TWeakObject<BGUCharacterCS>> list = new List<TWeakObject<BGUCharacterCS>>();
		list.Capacity = MovementData.CharNavWalkOptLevelMap.Count;
		float num = 0f;
		foreach (KeyValuePair<TWeakObject<BGUCharacterCS>, int> item in MovementData.CharNavWalkOptLevelMap)
		{
			if (!item.Key.IsValid())
			{
				list.Add(item.Key);
				continue;
			}
			switch (item.Value)
			{
			case 0:
				num += NavWalkOpt_MassiveMode_Level0Score;
				break;
			case 1:
				num += NavWalkOpt_MassiveMode_Level1Score;
				break;
			case 2:
				num += NavWalkOpt_MassiveMode_Level2Score;
				break;
			}
		}
		if (list.Count > 0)
		{
			foreach (TWeakObject<BGUCharacterCS> item2 in list)
			{
				if (MovementData.CharNavWalkOptLevelMap.ContainsKey(item2))
				{
					MovementData.CharNavWalkOptLevelMap.Remove(item2);
				}
			}
		}
		bool flag = num >= NavWalkOpt_MassiveMode_NeedScore;
		if (MovementData.NavWalkOpt_MassiveModeON != flag)
		{
			MovementData.NavWalkOpt_MassiveModeON = flag;
			base.BGSEventCollection.Evt_BGS_OnNavWalkOptMassiveModeChange.Invoke(MovementData.NavWalkOpt_MassiveModeON);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlayerMovementSystem");
	}

	static BUS_PlayerMovementSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlayerMovementSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlayerMovementSystem));
	}
}
