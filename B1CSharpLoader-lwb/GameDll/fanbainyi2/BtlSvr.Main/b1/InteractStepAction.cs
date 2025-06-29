using System.Collections.Generic;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using CsB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class InteractStepAction : InteractStepBase
{
	public bool ReleaseInput;

	public bool IsOpenSkipUI;

	private float NPCCameraBlendTime = -1f;

	public InteractStepAction()
	{
		StateName = PlayerInteractState.Action;
	}

	public override void StepBegin()
	{
		base.StepBegin();
		AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		if (Context.PlayerInteractData.InteractActionDesc != null)
		{
			if (Context.PlayerInteractData.InteractActionDesc.InteractAction == EInteractAction.RebirthPoint)
			{
				UAkGameplayStatics.PostEvent(null, controlledPawn, 0, null, bStopWhenAttachedToDestroyed: true, "EVT_ui_rbp_active");
			}
			if (Context.PlayerInteractData.InteractActionDesc.InteractAction == EInteractAction.ToolNpc)
			{
				NPCCameraBlendTime = 0.1f;
			}
			if (!string.IsNullOrEmpty(Context.PlayerInteractData.InteractActionDesc.CameraCompTag))
			{
				Dictionary<string, TWeakObject<UCameraComponent>> cameraComps = Context.TargetInteractData.CameraComps;
				if (cameraComps.Count > 0 && controlledPawn as ACharacter != null)
				{
					bool flag = false;
					foreach (KeyValuePair<string, TWeakObject<UCameraComponent>> item in cameraComps)
					{
						UCameraComponent uCameraComponent = item.Value.Get();
						if (!(uCameraComponent == null))
						{
							if (item.Key.Equals(Context.PlayerInteractData.InteractActionDesc.CameraCompTag))
							{
								flag = true;
								uCameraComponent.SetActive(bNewActive: true);
							}
							else
							{
								uCameraComponent.SetActive(bNewActive: false);
							}
						}
					}
					if (flag && Context.OwnerController != null && Context.OwnerController == UGSE_EngineFuncLib.GetFirstLocalPlayerController(controlledPawn))
					{
						float num = StringParseHelper.SafeFloatParse(Context.PlayerInteractData.InteractActionDesc.CameraBlendTime.Split(',')[0]);
						Context.OwnerController.SetViewTargetWithBlend(aActor, num, EViewTargetBlendFunction.VTBlend_EaseInOut, 4f, bLockOutgoing: true);
						Context.PlayerInteractData.bUsingInteractiveUnitViewTarget = true;
						if (Context.PlayerInteractData.InteractActionDesc.InteractAction == EInteractAction.ToolNpc)
						{
							NPCCameraBlendTime = num;
						}
					}
				}
			}
			if (Context.PlayerInteractData.InteractActionDesc.CameraEffect == EInteractCameraEffect.Lock)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_BePlayerAddTargeted.Invoke();
				UnitLockTargetInfo targetInfo = new UnitLockTargetInfo(aActor, ETargetSourceType.None);
				BGUFunctionLibraryCS.BGUSetTargetInfo(Context.IsOnline, controlledPawn, targetInfo);
				FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(controlledPawn);
				fRotator.Yaw = MathLib.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn), BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Yaw;
				IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(controlledPawn);
				IBUC_ABPCommonSettingData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(controlledPawn);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
				if (!unPersistentReadOnlyData2.bLockUseFreeMode)
				{
					bUS_GSEventCollection.Evt_ActorRotateToPos.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn) + fRotator.Vector() * 1000.0, unPersistentReadOnlyData.GSCameraAutoLockSetting.CamLockTurnSpeed, bForceUpdate: false);
				}
				BUS_EventCollectionCS.Get(controlledPawn).Evt_Camera_ManualLock.Invoke(aActor, "");
				if (Context.PlayerInteractData.InteractActionDesc.NPCCameraID > 0)
				{
					BPS_EventCollectionCS.Get(Context.OwnerController).Evt_EnterSkillCam.Invoke(aActor, Context.PlayerInteractData.InteractActionDesc.NPCCameraID);
				}
			}
			ProcessActionLock(Remove: false);
			if (Context.InteractActionTemplate == null || (Context.InteractActionTemplate != null && !Context.InteractActionTemplate.DoInteractAction(Context.InteractiveUnitCommDesc.ID, controlledPawn, aActor, Context.PlayerInteractData.InteractActionDesc)))
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			if (Context.InteractiveUnitCommDesc.InteractType == EInteractType.TaskNpc && Context.InteractActionTemplate.IsSupportSkip(Context.InteractiveUnitCommDesc.ID, controlledPawn, aActor, Context.PlayerInteractData.InteractActionDesc) && !DebugConfig.DisableSkipInteractFunc)
			{
				OpenSkipUI();
			}
		}
		ABGUCharacter aBGUCharacter = controlledPawn as ABGUCharacter;
		if (aBGUCharacter != null && aBGUCharacter.PlayerState != null && Context.InteractiveUnitCommDesc.InteractType != EInteractType.RebirthPoint)
		{
			string p = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(aActor)?.GetFinalGuid();
			BPS_EventCollectionCS.Get(aBGUCharacter.PlayerState)?.Evt_SetOSSSceneWidgetData.Invoke(Context.InteractiveUnitCommDesc.ID, p);
		}
		BUS_EventCollectionCS.Get(aActor)?.Evt_TriggerBeInteract.Invoke(controlledPawn, IsAiTrigger: false);
	}

	public override void OnTick(float DeltaTime)
	{
		base.OnTick(DeltaTime);
		if (Context.TargetInteractData != null && Context.TargetInteractData.BlendOutTimer > 0f)
		{
			Context.TargetInteractData.BlendOutTimer -= DeltaTime;
			if (Context.TargetInteractData.BlendOutTimer <= 0f)
			{
				ResetInteractUnitCamera();
			}
		}
		if (NPCCameraBlendTime > 0f)
		{
			NPCCameraBlendTime -= DeltaTime;
			if (NPCCameraBlendTime <= 0f)
			{
				AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
				AActor controlledPawn = Context.OwnerController.GetControlledPawn();
				if (aActor != null && controlledPawn != null)
				{
					BUS_EventCollectionCS.Get(controlledPawn).Evt_OpenToolNpcUI.Invoke(aActor);
				}
				NPCCameraBlendTime = -1f;
			}
		}
		if (Context.UnitStateData == null || Context.SimpleStateData == null)
		{
			Context.UnitStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Context.OwnerController.GetControlledPawn());
			Context.SimpleStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Context.OwnerController.GetControlledPawn());
		}
		if (Context.UnitStateData.HasState(EBGUUnitState.Attacking) || Context.SimpleStateData.HasSimpleState(EBGUSimpleState.Interacting))
		{
			return;
		}
		AActor controlledPawn2 = Context.OwnerController.GetControlledPawn();
		AActor aActor2 = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
		if (aActor2 != null && Context.PlayerInteractData.InteractActionDesc.InteractAction != EInteractAction.ComplexSkill && ((Context.TargetUnitStateData != null && Context.TargetUnitStateData.HasState(EBGUUnitState.Attacking)) || (Context.TargetSimpleStateData != null && Context.TargetSimpleStateData.HasSimpleState(EBGUSimpleState.Interacting))))
		{
			if (!(FVector.Dist2D(controlledPawn2.GetActorLocation(), aActor2.GetActorLocation()) < (float)Context.InteractiveUnitCommDesc.BreakDistance))
			{
				if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.BreakAsFinish == EGSYesNo.Yes)
				{
					StepFinish();
					return;
				}
				CloseSkipUI();
				TriggerFinish(InteractStepResult.Failure);
			}
		}
		else
		{
			StepFinish();
		}
	}

	public override void OnBreak()
	{
		base.OnBreak();
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.CanBreak == EGSYesNo.No)
		{
			return;
		}
		if (Context.PlayerInteractData.InteractActionDesc != null && Context.PlayerInteractData.InteractActionDesc.BreakAsFinish == EGSYesNo.Yes)
		{
			StepFinish();
			return;
		}
		CloseSkipUI();
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
		Context.InteractTypeTemplate.BreakInteract(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor);
		if (Context.InteractiveUnitCommDesc.InteractType != EInteractType.TaskNpc)
		{
			Context.InteractActionTemplate.OnBreakInteractAction(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor, Context.PlayerInteractData.InteractActionDesc);
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
		if (bUS_GSEventCollection != null && aActor.World != null)
		{
			bUS_GSEventCollection.Evt_TriggerBreakInteract.Invoke(controlledPawn);
		}
		BUS_EventCollectionCS.Get(controlledPawn).Evt_OnPlayerBreakInteract.Invoke(aActor);
		TriggerFinish(InteractStepResult.Failure);
	}

	public override void StepFinish()
	{
		base.StepFinish();
		CloseSkipUI();
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
		Context.InteractActionTemplate.OnFinishInteractAction(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor, Context.PlayerInteractData.InteractActionDesc);
		Context.InteractTypeTemplate.FinishInteract(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor);
		ResetInteractUnitCamera();
		SettlementInteractItem();
		BUS_EventCollectionCS.Get(aActor)?.Evt_TriggerFinishInteract.Invoke(controlledPawn);
		TriggerFinish(InteractStepResult.Success);
	}

	private void ResetInteractUnitCamera()
	{
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		if (Context.PlayerInteractData.bUsingInteractiveUnitViewTarget)
		{
			if (controlledPawn as ACharacter != null && Context.OwnerController != null && Context.OwnerController.IsLocalPlayerController() && Context.PlayerInteractData.InteractActionDesc.ReturnPlayerCamera == EGSYesNo.Yes)
			{
				float blendTime = StringParseHelper.SafeFloatParse(Context.PlayerInteractData.InteractActionDesc.CameraBlendTime.Split(',')[1]);
				BUS_EventCollectionCS.Get(controlledPawn).Evt_MoveCameraSpringArmRot2Nearest.Invoke();
				Context.OwnerController.SetViewTargetWithBlend(controlledPawn, blendTime, EViewTargetBlendFunction.VTBlend_EaseOut, 1f, bLockOutgoing: true);
			}
			Context.PlayerInteractData.bUsingInteractiveUnitViewTarget = false;
		}
	}

	private void SettlementInteractItem()
	{
		if (Context.InteractiveUnitCommDesc == null || Context.PlayerInteractData.InteractActionDesc == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn());
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		foreach (FUStInteractCondition item in Context.PlayerInteractData.InteractActionDesc.InteractCondition)
		{
			if (item.IsConsume == EGSYesNo.Yes)
			{
				List<ItemOne> list = new List<ItemOne>();
				ItemOne itemOne = new ItemOne();
				itemOne.Id = item.ConditionItemID;
				itemOne.Num = item.ConditionItemNum;
				list.Add(itemOne);
				CSMsgBagCostItemListReq cSMsgBagCostItemListReq = new CSMsgBagCostItemListReq();
				cSMsgBagCostItemListReq.Reason = OPReason.InteractiveCostItem;
				cSMsgBagCostItemListReq.ItemList.AddRange(list);
				BTF_EventCollectionCS.Get(Context.OwnerController.PlayerState).Evt_BagCostItemListReq(cSMsgBagCostItemListReq, null);
				bUS_GSEventCollection.Evt_TriggerCostItemSvr.Invoke(list, OPReason.InteractiveCostItem);
			}
		}
		if (Context.TargetInteractData != null && Context.TargetInteractData.RewardDropID > 0 && Context.OwnerController.IsLocalController())
		{
			BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(Context.OwnerController.PlayerState);
			if (bTF_EventCollectionCS != null)
			{
				CSMsgBagCommDropReq cSMsgBagCommDropReq = new CSMsgBagCommDropReq();
				cSMsgBagCommDropReq.DropId = Context.TargetInteractData.RewardDropID;
				cSMsgBagCommDropReq.Reason = OPReason.InteractAward;
				bTF_EventCollectionCS.Evt_BagCommDropReq(cSMsgBagCommDropReq, delegate
				{
				});
			}
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

	protected override void TriggerFinish(InteractStepResult Result)
	{
		base.TriggerFinish(Result);
	}

	private void OpenSkipUI()
	{
		if (!IsOpenSkipUI)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerController);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_ActiveSkipInteractUI(P1: true);
				bGW_EventCollection.Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.InteractSkip, bEnable: true);
				IsOpenSkipUI = true;
			}
		}
	}

	private void CloseSkipUI()
	{
		if (IsOpenSkipUI)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerController);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_ActiveSkipInteractUI(P1: false);
				bGW_EventCollection.Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.InteractSkip, bEnable: false);
				IsOpenSkipUI = false;
			}
		}
	}

	public override void OnSkip()
	{
		base.OnSkip();
		AActor user = Context.OwnerController?.GetControlledPawn();
		BPC_PlayerInteractData playerInteractData = Context.PlayerInteractData;
		AActor interactiveActor = ((playerInteractData != null) ? ECSExtension.ToActor(playerInteractData.CurrentInteractingEntityRef) : null);
		Context.InteractActionTemplate.OnSkipInteractAction(Context.TargetInteractData.InteractiveUnitID, user, interactiveActor, Context.PlayerInteractData.InteractActionDesc);
	}
}
