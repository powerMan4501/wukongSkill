using System.Collections.Generic;
using b1.GSMUI.Core;
using b1.Localization;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class InteractStepInput : InteractStepBase
{
	public bool ReleaseInput;

	public InteractStepInput()
	{
		StateName = PlayerInteractState.Input;
	}

	public override void StepBegin()
	{
		APawn controlledPawn = Context.OwnerController.GetControlledPawn();
		AActor aActor = EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef);
		if (BGW_LogUtil.LogIfNull(aActor, "[InteractComp] Interact target {0} is null!!!", Context.PlayerInteractData.BestInteractEntityRef))
		{
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		Context.TargetInteractData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(aActor);
		if (BGW_LogUtil.LogIfNull(Context.TargetInteractData, "[InteractComp] TargetInteractData == null"))
		{
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		if (Context.TargetInteractData.InteractUnitState != EBGUInteractUnitState.BeforeActive)
		{
			BGW_LogUtil.LogError("[InteractComp] 尝试交互不可交互的交互物");
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		Context.InteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(Context.TargetInteractData.InteractiveUnitID);
		BUS_EventCollectionCS.Get(aActor).Evt_TriggerPreInteract.Invoke(controlledPawn);
		Context.PlayerInteractData.InteractActionDesc = null;
		List<FUStInteractionMappingDesc> actionList = Context.TargetInteractData.ActionList;
		if (actionList.Count != 0)
		{
			Context.PlayerInteractData.InteractActionDesc = actionList[0];
			foreach (FUStInteractionMappingDesc item in actionList)
			{
				if (item.InteractAction == EInteractAction.ToolNpc)
				{
					Context.PlayerInteractData.InteractActionDesc = item;
				}
			}
			if (BGW_LogUtil.LogIfNull(Context.InteractiveUnitCommDesc, "[InteractComp] Find InteractiveUnitCommDesc failed! ResID: {0}", Context.TargetInteractData.InteractiveUnitID))
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			Context.InteractTypeTemplate = BGW_EffectTemplateList.Get(Context.OwnerController).GetInteractTypeTemplate(Context.InteractiveUnitCommDesc.InteractType);
			if (BGW_LogUtil.LogIfNull(Context.InteractTypeTemplate, "[InteractComp] InteractTypeTemplate == null"))
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			Context.InteractActionTemplate = BGW_EffectTemplateList.Get(Context.OwnerController).GetInteractActionTemplate(Context.PlayerInteractData.InteractActionDesc.InteractAction);
			if (BGW_LogUtil.LogIfNull(Context.InteractActionTemplate, "[InteractComp] InteractActionTemplate == null"))
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			if (Context.TargetInteractData.InteractConstraint != EInteractConstraint.None)
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_PlayerBeInteractInput.Invoke(aActor);
			Context.PlayerInteractData.CurrentInteractingEntityRef = EntitySharedRefFuncLib.Entity(Context.PlayerInteractData.BestInteractEntityRef);
			Context.PlayerInteractData.StartInteractTime = Context.OwnerController.World.GetTimeSeconds();
			if (!Context.InteractTypeTemplate.TriggerInteractInput(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor))
			{
				TriggerFinish(InteractStepResult.Failure);
				return;
			}
			if (Context.PlayerInteractData.InteractActionDesc.CanBreak == EGSYesNo.No && !IsCanFreeMoveInInteract())
			{
				BUS_EventCollectionCS.Get(controlledPawn).Evt_BuffAdd.Invoke(Context.PlayerInteractData.CantbreakBuffID, controlledPawn, controlledPawn, -1f, EBuffSourceType.PlayerInteract);
				BUS_EventCollectionCS.Get(controlledPawn).Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.Interact);
				Context.PlayerInteractData.bIsModifyDueCantBreak = true;
			}
			else
			{
				Context.PlayerInteractData.bIsModifyDueCantBreak = false;
			}
			if (Context.PlayerInteractData.InteractActionDesc.InteractInputTime <= 0f)
			{
				StepFinish();
			}
		}
		else
		{
			BGW_LogUtil.LogError("[InteractComp] TargetInteractAction = 0");
			TriggerFinish(InteractStepResult.Failure);
		}
	}

	public override void OnTick(float DeltaTime)
	{
		base.OnTick(DeltaTime);
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		if (ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef) == null)
		{
			TriggerFinish(InteractStepResult.Failure);
		}
		else if (ReleaseInput && Context.PlayerInteractData.InteractActionDesc.InteractInputTime > 0f)
		{
			controlledPawn.World.GetTimeSeconds();
			_ = Context.PlayerInteractData.StartInteractTime;
			if (controlledPawn.World.GetTimeSeconds() - Context.PlayerInteractData.StartInteractTime < Context.PlayerInteractData.InteractActionDesc.InteractInputTime)
			{
				OnBreak();
			}
		}
		else if (controlledPawn.World.GetTimeSeconds() - Context.PlayerInteractData.StartInteractTime >= Context.PlayerInteractData.InteractActionDesc.InteractInputTime)
		{
			StepFinish();
		}
	}

	public void OnReleaseInput()
	{
		ReleaseInput = true;
		OnTick(0f);
	}

	public override void OnBreak()
	{
		base.OnBreak();
		Context.PlayerInteractData.StartInteractTime = 0f;
		AActor controlledPawn = Context.OwnerController.GetControlledPawn();
		AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
		if (!aActor.IsNullOrDestroyed())
		{
			Context.InteractTypeTemplate.BreakInteractInput(Context.TargetInteractData.InteractiveUnitID, controlledPawn, aActor);
			BUS_EventCollectionCS.Get(controlledPawn).Evt_PlayerBreakInteractInput.Invoke(aActor);
		}
		BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreAllInput, IsRemove: true);
		TriggerFinish(InteractStepResult.Failure);
	}

	public override void StepFinish()
	{
		base.StepFinish();
		if (!PostCheckInteract(Context.TargetInteractData.InteractiveUnitID, Context.OwnerController.GetControlledPawn()))
		{
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		AActor aActor = ECSExtension.ToActor(Context.PlayerInteractData.CurrentInteractingEntityRef);
		if (Context.PlayerTagData != null && Context.PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		Context.PlayerInteractData.StartInteractTime = 0f;
		if (Context.InteractiveUnitCommDesc == null || aActor == null)
		{
			TriggerFinish(InteractStepResult.Failure);
			return;
		}
		BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_PlayerFinishInteractInput.Invoke(aActor);
		if (aActor as BGUCharacterCS != null)
		{
			Context.TargetUnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(aActor);
			Context.TargetSimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(aActor);
		}
		Context.TargetInteractData.InteractingPlayerEntity = Context.TargetInteractData.TriggerInteractPlayerEntity;
		if (Context.TargetInteractData.InteractiveUnitCommDesc.NetGameSync == EGSYesNo.Yes)
		{
			BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_TriggrtInteractOnOtherClient.Invoke(EntitySharedRefFuncLib.Actor(Context.PlayerInteractData.BestInteractEntityRef));
		}
		Context.InteractTypeTemplate.FinishInteractInput(Context.TargetInteractData.InteractiveUnitID, Context.OwnerController.GetControlledPawn(), aActor);
		TriggerFinish(InteractStepResult.Success);
	}

	public bool PostCheckInteract(int InteractiveActorID, AActor User)
	{
		if (Context.InteractiveUnitCommDesc == null || Context.PlayerInteractData.InteractActionDesc == null)
		{
			return false;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>((User as APawn).GetController());
		if (readOnlyData == null || readOnlyData.RoleData == null)
		{
			return false;
		}
		RepeatedField<FUStInteractCondition> interactCondition = Context.PlayerInteractData.InteractActionDesc.InteractCondition;
		string text = "";
		foreach (FUStInteractCondition item in interactCondition)
		{
			int bagItemNum = RoleDataHelper.GetBagItemNum(readOnlyData, item.ConditionItemID);
			if (bagItemNum >= item.ConditionItemNum)
			{
				continue;
			}
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(item.ConditionItemID);
			if (itemDesc != null)
			{
				if (text.Length > 0)
				{
					text += GSMUIUtil.GetUIWordDescFText(EUIWordID.INNTERACT_ITEM_LACK_SPLIT);
				}
				text = ((item.ConditionItemNum <= 1) ? (text + itemDesc.Name.ToFTextRemoveRich()) : (text + itemDesc.Name.ToFTextRemoveRich()?.ToString() + $" {bagItemNum}/{item.ConditionItemNum}"));
			}
		}
		if (text.Length > 0)
		{
			BUS_EventCollectionCS.Get(Context.OwnerController.GetControlledPawn()).Evt_TriggerInteactItemLack.Invoke(FText.FromString(text));
			return false;
		}
		return true;
	}

	private bool IsCanFreeMoveInInteract()
	{
		FUStInteractionMappingDesc interactActionDesc = Context.PlayerInteractData.InteractActionDesc;
		if (interactActionDesc.LockAction == EInteractLockAction.LockAllInput)
		{
			return false;
		}
		switch (interactActionDesc.InteractAction)
		{
		case EInteractAction.DummyMeshAnim:
		case EInteractAction.RebirthPoint:
		case EInteractAction.Meditation:
		case EInteractAction.ComplexSkill:
		case EInteractAction.ComplexMontage:
		case EInteractAction.Seq:
		case EInteractAction.ToolNpc:
		case EInteractAction.LongPressRescue:
		case EInteractAction.PartyRoom:
		case EInteractAction.OnlineTeleport:
		case EInteractAction.OpenUi:
		case EInteractAction.EnterSplineMove:
		case EInteractAction.DaShengEquipOpen:
		case EInteractAction.XiShuaiSpecial:
			return false;
		case EInteractAction.SkillAndBuff:
			if (interactActionDesc.ParamsInt.Count > 0 && interactActionDesc.ParamsBool == EGSYesNo.Yes)
			{
				return false;
			}
			return true;
		case EInteractAction.None:
		case EInteractAction.LoopMontage:
		case EInteractAction.Echo:
			return true;
		case EInteractAction.Montage:
			if (interactActionDesc.ParamsBool == EGSYesNo.Yes)
			{
				return false;
			}
			return true;
		case EInteractAction.Dialogue:
			if (interactActionDesc.ParamsString.Count > 0)
			{
				return false;
			}
			return true;
		default:
			return true;
		}
	}
}
