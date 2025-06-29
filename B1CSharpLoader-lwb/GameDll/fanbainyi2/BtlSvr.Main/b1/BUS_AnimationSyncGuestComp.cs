using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AnimationSyncGuestComp : UActorCompBaseCS
{
	private BUC_AnimationSyncGuestData AnimationSyncGuestData;

	private BUC_SimpleStateData SimpleStateData;

	private IBUC_MovementData MovementData;

	private IBUC_MagicallyChangeData MagicallyChangeData;

	private IBUC_MasterData MasterData;

	private IBUC_BuffData BuffData;

	public override void OnAttach()
	{
		AnimationSyncGuestData = RequireWritableData<BUC_AnimationSyncGuestData>();
		SimpleStateData = RequireWritableData<BUC_SimpleStateData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		MagicallyChangeData = RequireReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		base.BUSEventCollection.Evt_NotifyEnterPreAnimationSyncingStateOnGuest += new Del_NotifyEnterPreAnimationSyncingState(OnEnterPreAnimationSyncingStateOnGuest);
		base.BUSEventCollection.Evt_NotifyReactToAnimationSyncOnGuest += new Del_Void(OnReactToAnimationSyncOnGuest);
		base.BUSEventCollection.Evt_NotifyEnterAnimationSyncingStateOnGuest += new Del_NotifyEnterAnimationSyncingStateOnGuest(OnEnterAnimationSyncingStateOnGuest);
		base.BUSEventCollection.Evt_NotifyBeginSyncAnimationOnGuest += new Del_NotifyBeginSyncAnimationOnGuest(OnBeginSyncAnimationOnGuest);
		base.BUSEventCollection.Evt_NotifyEndSyncAnimationOnGuest += new Del_NotifyEndSyncAnimation(OnEndSyncAnimationOnGuest);
		base.BUSEventCollection.Evt_NotifyBeginInteractSyncAnimationOnGuest += new Del_Void_Actor(OnBeginInteractSyncAnimationOnGuest);
		base.BUSEventCollection.Evt_NotifyEndInteractSyncAnimationOnGuest += new Del_Void_Bool(OnEndInteractSyncAnimationOnGuest);
		base.BUSEventCollection.Evt_SetPendingCatchTargetInASS += new Del_Void_Actor(OnSetPendingCatchTargetInASS);
		base.BUSEventCollection.Evt_SetPendingDeathInASS += new Del_SetPendingDeathInASS(OnSetPendingDeathInASS);
		base.BUSEventCollection.Evt_SetPendingLifeSavingInASS += new Del_SetPendingLifeSavingInASS(OnSetPendingLifeSavingInASS);
		base.BUSEventCollection.Evt_ProcessPendingDeathInASS += new Del_ProcessPendingDeathInASS(OnProcessPendingDeathInASS);
	}

	public override void OnBeginPlay()
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(GetOwner().World))
		{
			UGSE_AnimFuncLib.SetRootMotionFromEverythingSwitch(GetOwner() as ACharacter, IsOpen: false);
			if (OwnerAsCharacterCS != null)
			{
				OwnerAsCharacterCS.Mesh.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SimpleStateData != null && SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
		{
			ProcessDeathInASS();
		}
		TickInteractSyncAnimationBow();
	}

	private void TickInteractSyncAnimationBow()
	{
		if (AnimationSyncGuestData.InteractSyncAnimationBowState == EInteractSyncAnimationBowState.None)
		{
			return;
		}
		if (Owner.IsNullOrDestroyed())
		{
			base.BGSEventCollection.Evt_BGS_NotifyHostToEndInteractSyncAnimation.Invoke(Owner);
			AnimationSyncGuestData.InteractSyncAnimationBowState = EInteractSyncAnimationBowState.None;
			AnimationSyncGuestData.InteractSyncAnimationBowLocation = FVector.ZeroVector;
		}
		else if (AnimationSyncGuestData.InteractSyncAnimationBowState == EInteractSyncAnimationBowState.Bowing)
		{
			FVector vec = AnimationSyncGuestData.InteractSyncAnimationBowLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			float x = (vec.Y = 0f);
			vec.X = x;
			base.BUSEventCollection?.Evt_ManualUpdateFootIKByZOffset.Invoke(vec);
			AnimationSyncGuestData.InteractSyncAnimationBowState = EInteractSyncAnimationBowState.Finish;
		}
		else if (AnimationSyncGuestData.InteractSyncAnimationBowState == EInteractSyncAnimationBowState.Finish)
		{
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, AnimationSyncGuestData.InteractSyncAnimationBowLocation, bSweep: false, bTeleport: true, NeedReturnHitResult: true);
			base.BGSEventCollection.Evt_BGS_NotifyHostToEndInteractSyncAnimation.Invoke(Owner);
			base.BUSEventCollection?.Evt_SetFootIKManualUpdateMode.Invoke(P1: false);
			if (OwnerAsCharacterCS.CharacterMovement.IsFalling())
			{
				OwnerAsCharacterCS.CharacterMovement.SetMovementMode(OwnerAsCharacterCS.CharacterMovement.DefaultLandMovementMode, 0);
			}
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null && !OwnerAsCharacterCS.IsLocallyControlled())
			{
				uBGUCharacterMovementComponent.SetSwitchToNavWalkCumulateTime(2f);
			}
			AnimationSyncGuestData.InteractSyncAnimationBowState = EInteractSyncAnimationBowState.None;
			AnimationSyncGuestData.InteractSyncAnimationBowLocation = FVector.ZeroVector;
		}
	}

	private void OnEnterPreAnimationSyncingStateOnGuest(AActor Host, List<int> PreAnimationSyncStateGuestBuffList)
	{
		AnimationSyncGuestData.Host = Host;
		SimpleStateData.SetSimpleState(EBGUSimpleState.PreAnimationSyncing);
		foreach (int PreAnimationSyncStateGuestBuff in PreAnimationSyncStateGuestBuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(PreAnimationSyncStateGuestBuff, Owner, Owner, -1f, EBuffSourceType.AnimationSync);
		}
	}

	private void ExitPreAnimationSyncingState(List<int> PreAnimationSyncStateGuestBuffList)
	{
		SimpleStateData.RemoveSimpleState(EBGUSimpleState.PreAnimationSyncing);
		foreach (int PreAnimationSyncStateGuestBuff in PreAnimationSyncStateGuestBuffList)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(PreAnimationSyncStateGuestBuff, EBuffEffectTriggerType.None, 1);
		}
	}

	private void OnReactToAnimationSyncOnGuest()
	{
		if (BGUFunctionLibraryCS.IsClonedWukong(Owner))
		{
			BUS_EventCollectionCS.Get(MasterData.GetMasterActor())?.Evt_SummonRecall.Invoke(Owner);
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			base.BUSEventCollection.Evt_EndFrozen.Invoke();
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			base.BUSEventCollection.Evt_RelieveImmobilized.Invoke();
		}
		SimpleStateData.HasSimpleState(EBGUSimpleState.InTTTB);
		if (MagicallyChangeData.IsDurMagicallyChange())
		{
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
		}
		base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("准备开始抓投");
	}

	private void OnEnterAnimationSyncingStateOnGuest(List<int> AnimationSyncStateGuestBuffList)
	{
		SimpleStateData.SetSimpleState(EBGUSimpleState.InAnimationSyncing);
		foreach (int AnimationSyncStateGuestBuff in AnimationSyncStateGuestBuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(AnimationSyncStateGuestBuff, Owner, Owner, -1f, EBuffSourceType.AnimationSync);
		}
	}

	private void ExitAnimationSyncingState(List<int> AnimationSyncStateGuestBuffList)
	{
		SimpleStateData.RemoveSimpleState(EBGUSimpleState.InAnimationSyncing);
		foreach (int AnimationSyncStateGuestBuff in AnimationSyncStateGuestBuffList)
		{
			if (this.BuffData.GetBuffInstData(AnimationSyncStateGuestBuff, out var BuffData))
			{
				int layer = BuffData.Layer;
				for (int i = 0; i < layer; i++)
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(AnimationSyncStateGuestBuff, EBuffEffectTriggerType.None, 1);
				}
			}
		}
	}

	private void OnBeginSyncAnimationOnGuest(List<int> PreAnimationSyncStateGuestBuffList, float RemainingDuration, AActor Host, float HostSyncBeginTime)
	{
		ExitPreAnimationSyncingState(PreAnimationSyncStateGuestBuffList);
		OwnerAsCharacterCS.StopAnimMontage(null);
		if (MovementData.IsAMCalcSpeedRate)
		{
			base.BUSEventCollection.Evt_SetAMSectionSpeedRate.Invoke(MovementData.AMSpeedRateNotifyStateID, MovementData.AMSpeedRate, MovementData.AMCaleSpeedRateTime);
		}
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, RemainingDuration);
		if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.IgnoreHostile))
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.IgnoreHostile, IsRemove: false);
		}
		base.BUSEventCollection.Evt_OnToggleSnapshotPose.Invoke(bEnable: false, default(FPoseSnapshot), 0f);
		base.BUSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.AnimSync);
		if (!(OwnerAsCharacterCS != null) || !(Host is BGUCharacterCS bGUCharacterCS))
		{
			return;
		}
		UAnimInstance uAnimInstance = bGUCharacterCS.Mesh?.GetAnimInstance();
		if (USystemLibrary.IsValid(uAnimInstance))
		{
			UAnimMontage currentActiveMontage = uAnimInstance.GetCurrentActiveMontage();
			if (currentActiveMontage != null)
			{
				OwnerAsCharacterCS.OnGuestSyncMontage(currentActiveMontage, HostSyncBeginTime);
			}
		}
	}

	private void OnEndSyncAnimationOnGuest(List<int> PreAnimationSyncStateGuestBuffList, List<int> AnimationSyncStateGuestBuffList)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PreAnimationSyncing))
		{
			ExitPreAnimationSyncingState(PreAnimationSyncStateGuestBuffList);
		}
		ExitAnimationSyncingState(AnimationSyncStateGuestBuffList);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.IgnoreHostile, IsRemove: true);
		if (AnimationSyncGuestData.PendingCatchTarget != null)
		{
			base.BUSEventCollection.Evt_AICatchTarget.Invoke(AnimationSyncGuestData.PendingCatchTarget, ETargetSourceType.Target_AnimSyncAssignTarget, SkipWakeUp: true);
			AnimationSyncGuestData.PendingCatchTarget = null;
		}
		if (OwnerAsCharacterCS != null)
		{
			OwnerAsCharacterCS.LeaveGuestSyncMontage();
		}
		base.BUSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.AnimSync);
		AnimationSyncGuestData.Host = null;
		AnimationSyncGuestData.DeathMontage = null;
	}

	private void OnBeginInteractSyncAnimationOnGuest(AActor Host)
	{
		AnimationSyncGuestData.Host = Host;
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InInteractAnimationSyncing);
		if (AnimationSyncGuestData.InteractSyncAnimationBowState != EInteractSyncAnimationBowState.None)
		{
			base.BUSEventCollection.Evt_SetFootIKManualUpdateMode.Invoke(P1: false);
			AnimationSyncGuestData.InteractSyncAnimationBowState = EInteractSyncAnimationBowState.None;
			AnimationSyncGuestData.InteractSyncAnimationBowLocation = FVector.ZeroVector;
		}
	}

	private void OnEndInteractSyncAnimationOnGuest(bool bFindFloor)
	{
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InInteractAnimationSyncing, IsRemove: true);
		if (OwnerAsCharacterCS != null && bFindFloor)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS);
			UCapsuleComponent capsuleComponent = OwnerAsCharacterCS.CapsuleComponent;
			float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleRadius = capsuleComponent.GetScaledCapsuleRadius();
			FVector start = fVector;
			FVector end = fVector - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(Owner, start, end, scaledCapsuleRadius, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, OwnerAsCharacterCS, out var OutHitLocation))
			{
				AnimationSyncGuestData.InteractSyncAnimationBowState = EInteractSyncAnimationBowState.Bowing;
				float num = 2.4f;
				AnimationSyncGuestData.InteractSyncAnimationBowLocation = OutHitLocation + FVector.UpVector * num;
				base.BUSEventCollection.Evt_SetFootIKManualUpdateMode.Invoke(P1: true);
				return;
			}
		}
		base.BGSEventCollection.Evt_BGS_NotifyHostToEndInteractSyncAnimation.Invoke(Owner);
	}

	private void OnSetPendingCatchTargetInASS(AActor NewTarget)
	{
		AnimationSyncGuestData.PendingCatchTarget = NewTarget;
	}

	private void OnSetPendingDeathInASS(AActor Killer, int StiffLevel, int DmgID, bool bIsSummon, FEffectInstReq EffectInstReq)
	{
		if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PendingDeathInAnimationSyncing);
		}
		AnimationSyncGuestData.Killer = Killer;
		AnimationSyncGuestData.bIsSummon = bIsSummon;
		AnimationSyncGuestData.DeathStiffLevel = StiffLevel;
		AnimationSyncGuestData.DeathDmgID = DmgID;
		AnimationSyncGuestData.DeathEffectInstReq = EffectInstReq;
		AnimationSyncGuestData.bIsFakeDead = false;
	}

	private void OnProcessPendingDeathInASS(UAnimMontage DeathMontage, float TotalDuration)
	{
		AnimationSyncGuestData.DeathMontage = DeathMontage;
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterAnimationSyncDeathWindow, TotalDuration);
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			ProcessDeathInASS();
		}
	}

	private void ProcessDeathInASS()
	{
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PendingDeathInAnimationSyncing, IsRemove: true);
		if (AnimationSyncGuestData.bIsFakeDead)
		{
			base.BUSEventCollection.Evt_FakeDeadForSkillDamage.Invoke(AnimationSyncGuestData.Killer, AnimationSyncGuestData.DeathStiffLevel, null, in AnimationSyncGuestData.DeathEffectInstReq);
		}
		else
		{
			base.BUSEventCollection.Evt_UnitDead.Invoke(AnimationSyncGuestData.Killer, AnimationSyncGuestData.bIsSummon ? EDeadReason.SummonDead : EDeadReason.SkillDamage, AnimationSyncGuestData.DeathDmgID, AnimationSyncGuestData.DeathStiffLevel, null, AnimationSyncGuestData.DeathEffectInstReq);
		}
		BUS_EventCollectionCS.Get(AnimationSyncGuestData.Host)?.Evt_StopSkillSequence.Invoke();
		base.BGSEventCollection.Evt_BGS_EndSyncAnimation.Invoke(AnimationSyncGuestData.Host);
	}

	private void OnSetPendingLifeSavingInASS(AActor Killer, int StiffLevel, FEffectInstReq EffectInstReq)
	{
		if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PendingDeathInAnimationSyncing);
		}
		AnimationSyncGuestData.Killer = Killer;
		AnimationSyncGuestData.DeathStiffLevel = StiffLevel;
		AnimationSyncGuestData.DeathEffectInstReq = EffectInstReq;
		AnimationSyncGuestData.bIsFakeDead = true;
	}
}
