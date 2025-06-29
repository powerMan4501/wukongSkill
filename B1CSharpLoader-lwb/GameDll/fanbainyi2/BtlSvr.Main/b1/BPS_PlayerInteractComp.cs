using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CsB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_PlayerInteractComp : PlayerControllerSystemBase
{
	private InteractContext Context;

	private BTF_EventCollectionCS BTFEventCollection;

	private float Timer;

	private Queue<InteractStepBase> InteractStepQueue;

	public override void OnAttach()
	{
		Context = new InteractContext();
		Context.IsOnline = IsOnline();
		Context.OwnerController = GetOwner() as BGP_PlayerControllerCS;
		Context.PlayerInteractData = RequireWritablePlayerStateData<BPC_PlayerInteractData>();
		Context.PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		Context.PlayerInteractData.OnPlayerInteractStateReset += ResetInteract;
		GetPlayerEventCollection().Evt_OnControlledPawnChange_Local += new Del_Param_Actor_Actor(OnControlledPawnChange);
		GetPlayerEventCollection().Evt_BPS_BreakInteract += new Del_Void(OnBreakInteract);
		GetPlayerEventCollection().Evt_TmpTransSendDropItem += new Del_Void_Int(TmpTransSendDropItem);
		GetPlayerEventCollection().Evt_BPS_SkipInteract += new Del_Void(OnSkipInteract);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
		OnControlledPawnChange(null, Context.OwnerController.GetControlledPawn());
		BTFEventCollection = BTF_EventCollectionCS.Get(GetOwner() as APlayerState);
		InteractStepQueue = new Queue<InteractStepBase>();
	}

	private void OnControlledPawnChange(AActor OldPawn, AActor NewPawn)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OldPawn);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_EnterInteractiveArea -= new Del_Void_Actor(OnCharacterEnterInteractiveArea);
			bUS_GSEventCollection.Evt_LeaveInteractiveArea -= new Del_Void_Actor(OnCharacterLeaveInteractiveArea);
			bUS_GSEventCollection.Evt_LeaveActiveArea -= new Del_EnterInteractActiveArea(OnCharacterLeaveActiveArea);
			bUS_GSEventCollection.Evt_InputInteract -= new Del_Void(OnInputInteract);
			bUS_GSEventCollection.Evt_ReleaseInteractInput -= new Del_Void(OnReleaseInteractInput);
			bUS_GSEventCollection.Evt_TriggerFinishInteractActionForce -= new Del_Void(OnTriggerFinishInteractActionForce);
			bUS_GSEventCollection.Evt_UnitSkillBreak -= new Del_UnitSkillBreak(OnSkillBreak);
			bUS_GSEventCollection.Evt_TriggerAttackStiff -= new Del_TriggerAttackStiff(OnHandleAttackStiff);
			bUS_GSEventCollection.Evt_UnitTriggerDead -= new Del_UnitTriggerDead(OnUnitTriggerDead);
			bUS_GSEventCollection.Evt_TriggerFallDying -= new Del_Void_Actor(OnTriggerFallDying);
			bUS_GSEventCollection.Evt_TriggrtInteractOnOtherClient -= new Del_Actor(OnOtherClientTriggerInteract);
			bUS_GSEventCollection.Evt_BreakInteract -= new Del_Void(OnBreakInteract);
			bUS_GSEventCollection.Evt_TriggerFrozen -= new Del_Void(OnBreakInteract);
		}
		BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(NewPawn);
		if (bUS_GSEventCollection2 != null)
		{
			bUS_GSEventCollection2.Evt_EnterInteractiveArea += new Del_Void_Actor(OnCharacterEnterInteractiveArea);
			bUS_GSEventCollection2.Evt_LeaveInteractiveArea += new Del_Void_Actor(OnCharacterLeaveInteractiveArea);
			bUS_GSEventCollection2.Evt_LeaveActiveArea += new Del_EnterInteractActiveArea(OnCharacterLeaveActiveArea);
			bUS_GSEventCollection2.Evt_InputInteract += new Del_Void(OnInputInteract);
			bUS_GSEventCollection2.Evt_ReleaseInteractInput += new Del_Void(OnReleaseInteractInput);
			bUS_GSEventCollection2.Evt_TriggerFinishInteractActionForce += new Del_Void(OnTriggerFinishInteractActionForce);
			bUS_GSEventCollection2.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnSkillBreak);
			bUS_GSEventCollection2.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
			bUS_GSEventCollection2.Evt_TriggerFallDying += new Del_Void_Actor(OnTriggerFallDying);
			bUS_GSEventCollection2.Evt_TriggerAttackStiff += new Del_TriggerAttackStiff(OnHandleAttackStiff);
			bUS_GSEventCollection2.Evt_TriggrtInteractOnOtherClient += new Del_Actor(OnOtherClientTriggerInteract);
			bUS_GSEventCollection2.Evt_BreakInteract += new Del_Void(OnBreakInteract);
			bUS_GSEventCollection2.Evt_TriggerFrozen += new Del_Void(OnBreakInteract);
		}
		if (NewPawn != null)
		{
			Context.UnitStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(NewPawn);
			Context.SimpleStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(NewPawn);
		}
		else
		{
			Context.UnitStateData = null;
			Context.SimpleStateData = null;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Remove(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
	}

	public void TriggerStepStatus(PlayerInteractState StateName, InteractStepResult Result)
	{
		if (Context.PlayerInteractData.CurrentStep == null || Context.PlayerInteractData.CurrentStep.StateName != StateName)
		{
			return;
		}
		switch (Result)
		{
		case InteractStepResult.Success:
			if (InteractStepQueue.Count > 0)
			{
				Context.PlayerInteractData.CurrentStep = InteractStepQueue.Dequeue();
				Context.PlayerInteractData.CurrentStep.StepBegin();
			}
			else if (Context.PlayerInteractData.InteractActionDesc.TriggerActionID != 0)
			{
				Context.OwnerController.SetViewTargetWithBlend(Context.OwnerController.GetControlledPawn(), 1f, EViewTargetBlendFunction.VTBlend_EaseInOut, 4f, bLockOutgoing: true);
				FUStInteractionMappingDesc interactionMappingDesc = BGW_GameDB.GetInteractionMappingDesc(Context.PlayerInteractData.InteractActionDesc.TriggerActionID);
				if (interactionMappingDesc != null)
				{
					AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
					int interactiveUnitID = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(aActor).InteractiveUnitID;
					Context.PlayerInteractData.CurrentStep = null;
					OnInteractSkipInput(interactiveUnitID, aActor, interactionMappingDesc);
				}
			}
			else
			{
				InteractStepQueue.Clear();
				Context.PlayerInteractData.CurrentStep = null;
			}
			break;
		case InteractStepResult.Failure:
			InteractStepQueue.Clear();
			Context.PlayerInteractData.CurrentStep = null;
			break;
		}
	}

	private void OnOtherClientTriggerInteract(AActor Target)
	{
		if (Context.PlayerInteractData.CurrentStep == null)
		{
			Context.PlayerInteractData.BestInteractEntityRef = new EntitySharedRef(Target);
			OnInputInteract();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckInteractiveActorsValid();
		if (Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnTick(DeltaTime);
		}
		else
		{
			TickForInteractiveActor();
		}
	}

	private void OnInputInteract()
	{
		if (Context.PlayerInteractData.CurrentStep == null)
		{
			InteractStepInput interactStepInput = new InteractStepInput();
			interactStepInput.StepInit(Context, TriggerStepStatus);
			InteractStepQueue.Enqueue(interactStepInput);
			InteractStepMatchPos interactStepMatchPos = new InteractStepMatchPos();
			interactStepMatchPos.StepInit(Context, TriggerStepStatus);
			InteractStepQueue.Enqueue(interactStepMatchPos);
			InteractStepAction interactStepAction = new InteractStepAction();
			interactStepAction.StepInit(Context, TriggerStepStatus);
			InteractStepQueue.Enqueue(interactStepAction);
			Context.PlayerInteractData.CurrentStep = InteractStepQueue.Dequeue();
			Context.PlayerInteractData.CurrentStep.StepBegin();
		}
	}

	private void ResetInteract(PlayerInteractState OldVal)
	{
		if (Context?.TargetInteractData != null)
		{
			Context.TargetInteractData.bIsInteracting = false;
		}
		ACharacter aCharacter = Context.OwnerController.GetControlledPawn() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		if (Context?.InteractActionTemplate != null)
		{
			Context?.InteractActionTemplate.OnEnd(aCharacter);
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (Context.PlayerInteractData.bIsModifyDueCantBreak)
		{
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(Context.PlayerInteractData.CantbreakBuffID, EBuffEffectTriggerType.None, 1);
			bUS_GSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.Interact);
			Context.PlayerInteractData.bIsModifyDueCantBreak = false;
		}
		bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ShooterModeClear, -1f);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreAllInput, IsRemove: true);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.CameraEffect == EInteractCameraEffect.Lock)
		{
			if (Context.PlayerInteractData.InteractActionDesc.NPCCameraID > 0)
			{
				BPS_EventCollectionCS.Get(Context.OwnerController).Evt_ExitSkillCam.Invoke(EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef));
			}
			bUS_GSEventCollection.Evt_ClearTargetInfo.Invoke();
			bUS_GSEventCollection.Evt_Camera_ClearCamLock.Invoke();
			bUS_GSEventCollection.Evt_CameraLockCleared.Invoke();
		}
		bool flag = false;
		if (ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef) != null && OldVal == PlayerInteractState.Action && Context.TargetInteractData != null && Context.InteractiveUnitCommDesc != null && Context.InteractiveUnitCommDesc.InteractType == EInteractType.TaskNpc)
		{
			flag = true;
		}
		if (Context.PlayerInteractData.bUsingInteractiveUnitViewTarget)
		{
			IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(aCharacter);
			if (gameStateReadonlyData == null || !gameStateReadonlyData.IsPlaying())
			{
				bUS_GSEventCollection.Evt_MoveCameraSpringArmRot2Nearest.Invoke();
				Context.OwnerController.SetViewTargetWithBlend(aCharacter, 0.5f, EViewTargetBlendFunction.VTBlend_EaseOut, 1f, bLockOutgoing: true);
			}
			Context.PlayerInteractData.bUsingInteractiveUnitViewTarget = false;
		}
		if (!flag)
		{
			Context.PlayerInteractData.CurrentInteractingEntityRef = Entity.Null;
		}
		ProcessActionLock(Remove: true);
		Context.PlayerInteractData.bUsingInteractSkill = false;
		Context.InteractTypeTemplate = null;
		Context.InteractActionTemplate = null;
		Context.TargetUnitStateData = null;
		Context.TargetSimpleStateData = null;
		Context.TargetInteractData = null;
		Context.InteractiveUnitCommDesc = null;
		Context.PlayerInteractData.InteractActionDesc = null;
	}

	private void OnReleaseInteractInput()
	{
		if (Context.PlayerInteractData.CurrentStep != null && Context.PlayerInteractData.CurrentStep.StateName == PlayerInteractState.Input && Context.PlayerInteractData.CurrentStep is InteractStepInput interactStepInput)
		{
			interactStepInput.OnReleaseInput();
		}
	}

	private void OnInteractSkipInput(int InteractiveUnitID, AActor InteractiveUnit, FUStInteractionMappingDesc SpecificAction = null)
	{
		InteractStepQueue.Clear();
		Context.PlayerInteractData.CurrentStep = null;
		InteractStepMatchPos interactStepMatchPos = new InteractStepMatchPos();
		interactStepMatchPos.StepInit(Context, TriggerStepStatus);
		InteractStepQueue.Enqueue(interactStepMatchPos);
		InteractStepAction interactStepAction = new InteractStepAction();
		interactStepAction.StepInit(Context, TriggerStepStatus);
		InteractStepQueue.Enqueue(interactStepAction);
		Context.TargetInteractData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveUnit);
		Context.InteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(Context.TargetInteractData.InteractiveUnitID);
		if (SpecificAction == null)
		{
			List<FUStInteractionMappingDesc> actionList = Context.TargetInteractData.ActionList;
			if (actionList.Count == 0)
			{
				BGW_LogUtil.LogError("[InteractComp] TargetInteractAction = 0");
				return;
			}
			Context.PlayerInteractData.InteractActionDesc = actionList[0];
			foreach (FUStInteractionMappingDesc item in actionList)
			{
				if (item.InteractAction == EInteractAction.ToolNpc)
				{
					Context.PlayerInteractData.InteractActionDesc = item;
				}
			}
		}
		else
		{
			Context.PlayerInteractData.InteractActionDesc = SpecificAction;
		}
		Context.InteractTypeTemplate = BGW_EffectTemplateList.Get(GetOwner()).GetInteractTypeTemplate(Context.InteractiveUnitCommDesc.InteractType);
		Context.InteractActionTemplate = BGW_EffectTemplateList.Get(GetOwner()).GetInteractActionTemplate(Context.PlayerInteractData.InteractActionDesc.InteractAction);
		if (InteractiveUnit as BGUCharacterCS != null)
		{
			Context.TargetUnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(InteractiveUnit);
			Context.TargetSimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(InteractiveUnit);
		}
		Context.PlayerInteractData.StartInteractTime = Owner.World.GetTimeSeconds();
		Context.PlayerInteractData.CurrentStep = InteractStepQueue.Dequeue();
		Context.PlayerInteractData.CurrentStep.StepBegin();
	}

	private void TickForInteractiveActor()
	{
		if (Context.PlayerInteractData.IsInInteraction())
		{
			return;
		}
		EntitySharedRef bestInteractEntityRef = Context.PlayerInteractData.BestInteractEntityRef;
		AActor bestInteractiveActor = GetBestInteractiveActor();
		if (bestInteractiveActor != null && !Context.PlayerInteractData.bIsInNewInputContext)
		{
			IBUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(bestInteractiveActor);
			if (readOnlyData != null && readOnlyData.InteractiveUnitID == 9809)
			{
				BGW_EventCollection.Get(Owner).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Interact, bEnable: true, IsIgnoreAllPressedKeyUntilRelease: false);
			}
			else
			{
				BGW_EventCollection.Get(Owner).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Interact, bEnable: true);
			}
			Context.PlayerInteractData.bIsInNewInputContext = true;
		}
		else if (bestInteractiveActor == null && Context.PlayerInteractData.bIsInNewInputContext)
		{
			BGW_EventCollection.Get(Owner).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Interact, bEnable: false);
			Context.PlayerInteractData.bIsInNewInputContext = false;
		}
		Context.PlayerInteractData.BestInteractEntityRef = ((bestInteractiveActor == null) ? null : new EntitySharedRef(bestInteractiveActor));
		if (Context.PlayerInteractData.BestInteractEntityRef == bestInteractEntityRef)
		{
			return;
		}
		if (bestInteractEntityRef != null)
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(bestInteractEntityRef);
			if (!aActor.IsNullOrDestroyed() && (aActor as IECSWorldObj).ActorCompContainerCS.HasBeginPlay)
			{
				BUS_EventCollectionCS.Get(aActor).Evt_SetInteractActiveState.Invoke(P1: false);
			}
		}
		if (Context.PlayerInteractData.BestInteractEntityRef != null)
		{
			AActor aActor2 = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
			if (!aActor2.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(aActor2).Evt_SetInteractActiveState.Invoke(P1: true);
			}
		}
	}

	private void TmpTransSendDropItem(int RewardDropID)
	{
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(Context.OwnerController.PlayerState);
		if (bTF_EventCollectionCS != null)
		{
			CSMsgBagCommDropReq cSMsgBagCommDropReq = new CSMsgBagCommDropReq();
			cSMsgBagCommDropReq.DropId = RewardDropID;
			cSMsgBagCommDropReq.Reason = OPReason.InteractAward;
			bTF_EventCollectionCS.Evt_BagCommDropReq(cSMsgBagCommDropReq, delegate
			{
			});
		}
	}

	private AActor GetBestInteractiveActor()
	{
		AActor result = null;
		if (Context.PlayerInteractData.InteractiveActors.Count == 0)
		{
			return result;
		}
		if (Context.OwnerController.IsNullOrDestroyed() || Context.OwnerController.GetControlledPawn().IsNullOrDestroyed())
		{
			return result;
		}
		float num = float.MaxValue;
		foreach (EntitySharedRef interactiveActor in Context.PlayerInteractData.InteractiveActors)
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(interactiveActor);
			if (aActor.IsNullOrDestroyed() || aActor == Context.OwnerController.GetControlledPawn())
			{
				continue;
			}
			IBUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(aActor);
			if (readOnlyData != null && readOnlyData.IconSockVector != FVector.ZeroVector && !UGSE_CameraUtilFuncLib.IsPositionInScreenViewport(aActor, readOnlyData.IconSockVector))
			{
				continue;
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Context.OwnerController.GetControlledPawn());
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			if (readOnlyData != null && readOnlyData.InteractiveUnitCommDesc != null && readOnlyData.InteractiveUnitCommDesc.IgnorePlayerOrientation == EGSYesNo.No)
			{
				FVector b = fVector2 - fVector;
				b.Normalize();
				if (FMath.Abs(MathLib.DegAcos(FVector.DotProduct(Context.OwnerController.GetControlledPawn().GetActorForwardVector(), b))) > 90f)
				{
					continue;
				}
			}
			float num2 = FVector.DistSquared(fVector, fVector2);
			if (num2 < num)
			{
				num = num2;
				result = aActor;
			}
		}
		return result;
	}

	private void CheckInteractiveActorsValid()
	{
		if (Context.PlayerInteractData.BestInteractEntityRef != null)
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
			if (aActor.IsNullOrDestroyed())
			{
				OnCharacterLeaveInteractiveArea(aActor);
			}
		}
	}

	private void OnCharacterEnterInteractiveArea(AActor Actor)
	{
		EntitySharedRef entityRef = new EntitySharedRef(Actor);
		if (!Context.PlayerInteractData.InteractiveActors.Contains(entityRef))
		{
			Context.PlayerInteractData.InteractiveActors.Add(entityRef);
			TickForInteractiveActor();
		}
	}

	private void OnCharacterLeaveActiveArea(AActor Actor, EInteractType InteractType)
	{
		OnCharacterLeaveInteractiveArea(Actor);
	}

	private void OnCharacterLeaveInteractiveArea(AActor Actor)
	{
		EntitySharedRef entityRef = new EntitySharedRef(Actor);
		Context.PlayerInteractData.InteractiveActors.Remove(entityRef);
		TickForInteractiveActor();
	}

	private void OnUiInteractBehaviour(int Behaviour, int ActionID)
	{
		if (Behaviour != 4)
		{
			return;
		}
		FUStInteractionMappingDesc interactionMappingDesc = BGW_GameDB.GetInteractionMappingDesc(ActionID);
		if (interactionMappingDesc != null)
		{
			AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
			int interactiveUnitID = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(aActor).InteractiveUnitID;
			if (!(Context.OwnerController.GetControlledPawn() as ACharacter == null))
			{
				OnInteractSkipInput(interactiveUnitID, aActor, interactionMappingDesc);
			}
		}
	}

	private void OnSkillBreak(int SkillID, string Reason)
	{
		if (Context.PlayerInteractData.bUsingInteractSkill && Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnBreak();
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnBreak();
		}
	}

	private void OnTriggerFallDying(AActor Attacker)
	{
		if (Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnBreak();
		}
	}

	private void OnHandleAttackStiff(AActor AttackerMaster, int StiffLevel, float HitWeight)
	{
		if (HitWeight > 0f && Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnBreak();
		}
	}

	private void OnBreakInteract()
	{
		if (Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnBreak();
		}
	}

	private void OnTriggerFinishInteractActionForce()
	{
		if (Context.PlayerInteractData.CurrentStep != null && Context.PlayerInteractData.CurrentStep is InteractStepAction)
		{
			Context.PlayerInteractData.CurrentStep.StepFinish();
		}
	}

	private void ProcessActionLock(bool Remove)
	{
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.LockAction != EInteractLockAction.None)
		{
			switch (Context.PlayerInteractData.InteractActionDesc.LockAction)
			{
			case EInteractLockAction.LockSkill:
				BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Silent, Remove);
				break;
			case EInteractLockAction.OnlyWalk:
				BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Silent, Remove);
				BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.MoveSlowly, Remove);
				break;
			case EInteractLockAction.LockAllInput:
				BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreAllInput, Remove);
				break;
			}
		}
	}

	private void OnSkipInteract()
	{
		if (Context.PlayerInteractData.CurrentStep != null)
		{
			Context.PlayerInteractData.CurrentStep.OnSkip();
		}
		else
		{
			BGW_LogUtil.LogError("[BPS_PlayerInteractComp] OnSkipInteract CurrentStep == null!");
		}
	}
}
