using System;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_PlayerPerformSystem : PlayerControllerSystemBase
{
	private enum EPlayerPoseType
	{
		None,
		Idle,
		Walking,
		Running,
		Jumping,
		Sprinting,
		Charging,
		BeAttacked,
		Attacking,
		Exception
	}

	private BPS_GSEventCollection EventCollection { get; set; }

	private BGW_EventCollection BGW_Evt { get; set; }

	private BPC_PlayerPerformData PerformData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBGC_LevelActorData LevelActorData { get; set; }

	public override void OnAttach()
	{
		PerformData = RequireWritablePlayerStateData<BPC_PlayerPerformData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		EventCollection = BPS_GSEventCollection.Get(base.PlayerController);
		if (EventCollection != null)
		{
			EventCollection.Evt_EnterWeakPerformState += new Del_Void_Int(TriggerEnterWeakPerformState);
			EventCollection.Evt_ExitWeakPerformState += new Del_Void(TriggerExitWeakPerformState);
		}
		BGW_Evt = BGW_EventCollection.Get(base.PlayerController);
		if (BGW_Evt != null)
		{
			BGW_EventCollection bGW_Evt = BGW_Evt;
			bGW_Evt.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGW_Evt.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(TriggerForceExitWeakPerformState));
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (BGW_Evt != null)
		{
			BGW_EventCollection bGW_Evt = BGW_Evt;
			bGW_Evt.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGW_Evt.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(TriggerForceExitWeakPerformState));
		}
		base.OnEndPlay(EndPlayReason);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PerformData.CurrentPerformPhase == EWeakPerformPhase.PoseTurnBack)
		{
			if (JudgePoseTurnBack())
			{
				EndForPoseTurnBackPhase();
			}
		}
		else
		{
			if (!(PerformData.CurrentWaitTime > 0f))
			{
				return;
			}
			PerformData.CurrentWaitTime -= DeltaTime;
			if (PerformData.CurrentWaitTime <= 0f)
			{
				switch (PerformData.CurrentPerformPhase)
				{
				case EWeakPerformPhase.WaitEnterTime:
					EndForWaitEnterTimePhase();
					break;
				case EWeakPerformPhase.TransTurnsBack:
					EndForTransTurnsBackPhase();
					break;
				case EWeakPerformPhase.Performing:
					EndForPerformingPhase();
					break;
				case EWeakPerformPhase.WaitExitTime:
					EndForWaitExitTimePhase();
					break;
				case EWeakPerformPhase.PoseTurnBack:
					break;
				}
			}
		}
	}

	private void TriggerEnterWeakPerformState(int PerformConfigID)
	{
		switch (PerformData.CurrentPerformPhase)
		{
		case EWeakPerformPhase.NotPerform:
		case EWeakPerformPhase.WaitEnterTime:
		case EWeakPerformPhase.TransTurnsBack:
			EnterWeakPerformState(PerformConfigID);
			break;
		case EWeakPerformPhase.PoseTurnBack:
			EndInputCinematicMode();
			EnterWeakPerformState(PerformConfigID);
			break;
		case EWeakPerformPhase.Performing:
		case EWeakPerformPhase.WaitExitTime:
			EndForWaitExitTimePhase();
			EnterWeakPerformState(PerformConfigID);
			break;
		}
	}

	private void TriggerExitWeakPerformState()
	{
		switch (PerformData.CurrentPerformPhase)
		{
		case EWeakPerformPhase.NotPerform:
		case EWeakPerformPhase.WaitEnterTime:
		case EWeakPerformPhase.TransTurnsBack:
			EnterNotPerformPhase();
			break;
		case EWeakPerformPhase.PoseTurnBack:
			EndInputCinematicMode();
			EnterNotPerformPhase();
			break;
		case EWeakPerformPhase.Performing:
			EndForPerformingPhase();
			break;
		case EWeakPerformPhase.WaitExitTime:
			break;
		}
	}

	private void TriggerForceExitWeakPerformState(EResetActorReason ResetReason)
	{
		switch (PerformData.CurrentPerformPhase)
		{
		case EWeakPerformPhase.NotPerform:
		case EWeakPerformPhase.WaitEnterTime:
		case EWeakPerformPhase.TransTurnsBack:
			EnterNotPerformPhase();
			break;
		case EWeakPerformPhase.PoseTurnBack:
			EndInputCinematicMode();
			EnterNotPerformPhase();
			break;
		case EWeakPerformPhase.Performing:
		case EWeakPerformPhase.WaitExitTime:
			EndForWaitExitTimePhase();
			break;
		}
	}

	private void EnterWeakPerformState(int PerformConfigID)
	{
		PerformData.CurrentWaitTime = -1f;
		FUStWeakPerformConfigDesc weakPerformConfigDesc = BGW_GameDB.GetWeakPerformConfigDesc(PerformConfigID);
		if (weakPerformConfigDesc == null)
		{
			return;
		}
		FWeakPerformConfig currentPerformConfig = PerformData.CurrentPerformConfig;
		currentPerformConfig.Clear();
		switch (weakPerformConfigDesc.LockType)
		{
		case EPerformLockType.None:
			currentPerformConfig.IsValid = true;
			break;
		case EPerformLockType.Unit:
		{
			if (GlobalActorData.GetActorEntity(weakPerformConfigDesc.LockTargetTag, out var Entity))
			{
				currentPerformConfig.IsValid = true;
				currentPerformConfig.LockTarget = new UnitLockTargetInfo(ECSExtension.ToActor(Entity), ETargetSourceType.Target_SwitchTaget);
			}
			break;
		}
		case EPerformLockType.SceneItem:
		{
			LevelActorData.GetSceneItemsByTag(new FName(weakPerformConfigDesc.LockTargetTag), out var OutSceneItems);
			if (OutSceneItems.Count >= 1)
			{
				currentPerformConfig.IsValid = true;
				currentPerformConfig.LockTarget = new UnitLockTargetInfo(OutSceneItems[0], ETargetSourceType.Target_SwitchTaget);
			}
			break;
		}
		}
		currentPerformConfig.bDisableMoveBack = weakPerformConfigDesc.IsDisableMoveBack == EGSYesNo.Yes;
		currentPerformConfig.bDisableXAxisMove = weakPerformConfigDesc.IsDisableXAxisMove == EGSYesNo.Yes;
		currentPerformConfig.bDisableInteract = weakPerformConfigDesc.IsDisableInteract == EGSYesNo.Yes;
		currentPerformConfig.ExitDelayTime = weakPerformConfigDesc.ExitDelayTime;
		currentPerformConfig.DurationTime = weakPerformConfigDesc.DurationTime;
		if (!currentPerformConfig.IsValid)
		{
			currentPerformConfig.Clear();
			return;
		}
		PerformData.CurrentPerformConfigID = PerformConfigID;
		BeginForWaitEnterTimePhase();
	}

	private void BeginForWaitEnterTimePhase()
	{
		PerformData.CurrentPerformPhase = EWeakPerformPhase.WaitEnterTime;
		EndForWaitEnterTimePhase();
	}

	private void EndForWaitEnterTimePhase()
	{
		PerformData.CurrentWaitTime = -1f;
		BeginForTransTurnsBackPhase();
	}

	private void BeginForTransTurnsBackPhase()
	{
		PerformData.CurrentPerformPhase = EWeakPerformPhase.TransTurnsBack;
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
		float transBackDurationTime = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>(controlledPawn).TransBackDurationTime;
		if (transBackDurationTime > 0f)
		{
			bUS_GSEventCollection?.Evt_TriggerTransBack.Invoke();
			PerformData.CurrentWaitTime = transBackDurationTime;
			return;
		}
		IBUC_MagicallyChangeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>(controlledPawn);
		float vigorSkillReEnterWaitTime = unPersistentReadOnlyData.VigorSkillReEnterWaitTime;
		if (unPersistentReadOnlyData.IsDurMagicallyChange() && vigorSkillReEnterWaitTime > 0f)
		{
			bUS_GSEventCollection?.Evt_OnMagicallyChangeRecover.Invoke(0);
			PerformData.CurrentWaitTime = vigorSkillReEnterWaitTime;
		}
		else
		{
			EndForTransTurnsBackPhase();
		}
	}

	private void EndForTransTurnsBackPhase()
	{
		PerformData.CurrentWaitTime = -1f;
		BeginForPoseTurnBackPhase();
	}

	private void BeginInputCinematicMode()
	{
		FWeakPerformConfig currentPerformConfig = PerformData.CurrentPerformConfig;
		BUS_EventCollectionCS.Get(base.PlayerController.GetControlledPawn())?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantTransInSeq);
		EventCollection.Evt_BPS_BeginCinematicIgnoreMode.Invoke(P1: false, P2: true, currentPerformConfig.bDisableInteract);
		base.PlayerController.SetCinematicMode(bInCinematicMode: true, bHidePlayer: false, bAffectsHUD: false, bAffectsMovement: false, bAffectsTurning: true);
	}

	private void EndInputCinematicMode()
	{
		BUS_EventCollectionCS.Get(base.PlayerController.GetControlledPawn())?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantTransInSeq, IsRemove: true);
		EventCollection.Evt_BPS_EndCinematicIgnoreMode.Invoke();
		base.PlayerController.SetCinematicMode(bInCinematicMode: false, bHidePlayer: false, bAffectsHUD: false, bAffectsMovement: false, bAffectsTurning: true);
	}

	private void BeginForPoseTurnBackPhase()
	{
		PerformData.CurrentPerformPhase = EWeakPerformPhase.PoseTurnBack;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(base.PlayerController.GetControlledPawn());
		ClearWukongStates();
		BeginInputCinematicMode();
		bUS_GSEventCollection?.Evt_ClearCameraLock.Invoke();
		if (JudgePoseTurnBack())
		{
			EndForPoseTurnBackPhase();
		}
	}

	private void EndForPoseTurnBackPhase()
	{
		PerformData.CurrentWaitTime = -1f;
		BeginForPerformingPhase();
	}

	private void BeginForPerformingPhase()
	{
		PerformData.CurrentPerformPhase = EWeakPerformPhase.Performing;
		FWeakPerformConfig currentPerformConfig = PerformData.CurrentPerformConfig;
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((IBUC_PlayerCameraData)BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(controlledPawn)).IsInG4Mode())
		{
			bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.G4Mode);
		}
		if (currentPerformConfig.LockTarget != null)
		{
			AActor lockTargetActor = currentPerformConfig.LockTarget.LockTargetActor;
			if (lockTargetActor != null)
			{
				bUS_GSEventCollection.Evt_Camera_ManualLock.Invoke(lockTargetActor, currentPerformConfig.LockTarget.LockTargetSkeletonSocketName);
				bUS_GSEventCollection.Evt_ActorRotateToPos.Invoke(lockTargetActor.GetActorLocation(), 180f, bForceUpdate: false);
				bUS_GSEventCollection.Evt_G4CameraTurnToTarget.Invoke(lockTargetActor.GetActorTransform());
			}
		}
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(controlledPawn);
		if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Sprinting))
		{
			bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintRelease, -1f);
		}
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.MoveSlowly);
		if (currentPerformConfig.bDisableMoveBack)
		{
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreMoveBackInput);
		}
		if (currentPerformConfig.bDisableXAxisMove)
		{
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreXAxisMoveInput);
		}
		if (currentPerformConfig.DurationTime > 0f)
		{
			PerformData.CurrentWaitTime = currentPerformConfig.DurationTime;
		}
	}

	private void EndForPerformingPhase()
	{
		PerformData.CurrentWaitTime = -1f;
		BeginForWaitExitTimePhase();
	}

	private void BeginForWaitExitTimePhase()
	{
		PerformData.CurrentPerformPhase = EWeakPerformPhase.WaitExitTime;
		FWeakPerformConfig currentPerformConfig = PerformData.CurrentPerformConfig;
		if (currentPerformConfig.IsValid && currentPerformConfig.ExitDelayTime > 0f)
		{
			PerformData.CurrentWaitTime = currentPerformConfig.ExitDelayTime;
		}
		else
		{
			EndForWaitExitTimePhase();
		}
	}

	private void EndForWaitExitTimePhase()
	{
		PerformData.CurrentWaitTime = -1f;
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
		FWeakPerformConfig currentPerformConfig = PerformData.CurrentPerformConfig;
		if (currentPerformConfig.IsValid)
		{
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.MoveSlowly, IsRemove: true);
			if (((IBUC_PlayerCameraData)BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(controlledPawn)).IsInG4Mode())
			{
				bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.AutoTrail);
				bUS_GSEventCollection.Evt_DoCheckUpdateSideWalkingState.Invoke();
			}
			UnitLockTargetInfo lockTarget = currentPerformConfig.LockTarget;
			if (lockTarget != null && lockTarget.LockTargetType == ELockTargetType.Actor)
			{
				bUS_GSEventCollection.Evt_ClearCameraLock.Invoke();
			}
			if (currentPerformConfig.bDisableMoveBack)
			{
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreMoveBackInput, IsRemove: true);
			}
			if (currentPerformConfig.bDisableXAxisMove)
			{
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreXAxisMoveInput, IsRemove: true);
			}
			EndInputCinematicMode();
		}
		EnterNotPerformPhase();
	}

	private void EnterNotPerformPhase()
	{
		PerformData.CurrentPerformConfig.Clear();
		PerformData.ResetPerformConfigID();
		PerformData.CurrentPerformPhase = EWeakPerformPhase.NotPerform;
		PerformData.CurrentWaitTime = -1f;
	}

	private bool JudgePoseTurnBack()
	{
		EPlayerPoseType ePlayerPoseType = UpdatePlayerPose();
		if (ePlayerPoseType == EPlayerPoseType.Jumping || (uint)(ePlayerPoseType - 6) <= 2u)
		{
			return false;
		}
		return true;
	}

	private EPlayerPoseType UpdatePlayerPose()
	{
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		if (controlledPawn == null)
		{
			return EPlayerPoseType.Exception;
		}
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitStateData>(controlledPawn);
		IBUC_JumpData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.BUC_JumpData>(controlledPawn);
		IBUC_ChargeSkillData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ChargeSkillData>(controlledPawn);
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = controlledPawn.GetMovementComponent() as UBGUCharacterMovementComponent;
		IBIC_TaskData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(controlledPawn);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || unPersistentReadOnlyData3 == null || uBGUCharacterMovementComponent == null || gameInstanceReadonlyData == null)
		{
			return EPlayerPoseType.Exception;
		}
		if (unPersistentReadOnlyData.HasState(EBGUUnitState.Dead))
		{
			BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitRebirth.Invoke(ERebirthType.Quick);
			return EPlayerPoseType.Exception;
		}
		EPlayerPoseType ePlayerPoseType = EPlayerPoseType.None;
		if (unPersistentReadOnlyData.HasState(EBGUUnitState.Walking))
		{
			return EPlayerPoseType.Walking;
		}
		if (unPersistentReadOnlyData.HasState(EBGUUnitState.Sprinting))
		{
			return EPlayerPoseType.Sprinting;
		}
		if (unPersistentReadOnlyData2.IsInJump())
		{
			return EPlayerPoseType.Jumping;
		}
		if (unPersistentReadOnlyData.HasState(EBGUUnitState.Beatback))
		{
			return EPlayerPoseType.BeAttacked;
		}
		if (unPersistentReadOnlyData.HasState(EBGUUnitState.Attacking))
		{
			return EPlayerPoseType.Attacking;
		}
		if (unPersistentReadOnlyData3.IsCastingChargeSkill)
		{
			return EPlayerPoseType.Charging;
		}
		if (uBGUCharacterMovementComponent.GetCurrentAcceleration().Size() > 1E-08f)
		{
			return EPlayerPoseType.Running;
		}
		return EPlayerPoseType.Idle;
	}

	private void ClearWukongStates()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(base.PlayerController.GetControlledPawn());
		if (!(bUS_GSEventCollection == null))
		{
			bUS_GSEventCollection.Evt_ClearAllAbnormalState.Invoke();
			bUS_GSEventCollection.Evt_RelievePhantomRush.Invoke();
			bUS_GSEventCollection.Evt_TriggerCancelChargeSkill.Invoke();
			bUS_GSEventCollection.Evt_DestroyAllSummons.Invoke();
			base.BGSEventCollection?.Evt_ReliveAllImmobilized.Invoke();
			base.PlayerController.StopMovement();
		}
	}
}
