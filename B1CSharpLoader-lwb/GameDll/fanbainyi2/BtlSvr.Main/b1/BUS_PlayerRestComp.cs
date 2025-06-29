using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CsB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_PlayerRestComp : UActorCompBaseCS
{
	private IBUC_PotentialEnergyData PotentialEnergyData;

	protected IBUC_AttrContainer AttrContainer;

	private BGW_UIEventCollection UIEC;

	private BUC_PlayerRestData PlayerRestData;

	private IBPC_TransData TransData;

	private BTF_EventCollectionCS BTFEventCollection { get; set; }

	public override void OnAttach()
	{
		PotentialEnergyData = RequireReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PlayerRestData = RequireWritableData<BUC_PlayerRestData>();
		TransData = RequireReadOnlyControledPlayerStateData<IBPC_TransData, BPC_TransData>();
		UIEC = BGW_UIEventCollection.Get(GetOwner());
		base.BUSEventCollection.Evt_TriggerPlayerRest += new Del_TriggerPlayerRest(OnTriggerPlayerRest);
		base.BUSEventCollection.Evt_TriggerPlayerRestByReBirth += new Del_Void(OnTriggerPlayerRestByReBirth);
		base.BUSEventCollection.Evt_TriggerTeleportResetPlayer += new Del_Void(OnTriggerPlayerRestOnly);
		base.BUSEventCollection.Evt_TriggerPlayerClearBattleState += new Del_TriggerPlayerClearBattleState(ClearBattleState);
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(OwnerAsCharacterCS.PlayerState);
		if (bPS_GSEventCollection != null)
		{
			bPS_GSEventCollection.Evt_ChangePlayerTaskStage += new Del_ChangePlayerTaskStage(OnChangePlayerTaskStage);
		}
		BTFEventCollection = BTF_EventCollectionCS.Get(OwnerAsCharacterCS.PlayerState);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(OwnerAsCharacterCS.PlayerState);
		if (bPS_GSEventCollection != null)
		{
			bPS_GSEventCollection.Evt_ChangePlayerTaskStage -= new Del_ChangePlayerTaskStage(OnChangePlayerTaskStage);
		}
	}

	private void ReSetBaseState()
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
		float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.MpMax);
		float floatValue3 = AttrContainer.GetFloatValue(EBGUAttrFloat.StaminaMax);
		base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Stamina, floatValue3);
		base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, floatValue);
		base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Mp, floatValue2);
	}

	private void ReSetConsumables()
	{
		int num = (int)AttrContainer.GetFloatValMax(EBGUAttrFloat.BloodBottomNumMax);
		base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BloodBottomNum, num);
	}

	private void ClearBattleState(EPlayerClearBattleStateType PlayerClearBattleStateType)
	{
		base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.None);
		base.BUSEventCollection.Evt_ResetSealingSpell.Invoke();
		base.BUSEventCollection.Evt_ClearAllAbnormalState.Invoke();
		base.BUSEventCollection.Evt_ClearPEValue.Invoke();
		if (PlayerClearBattleStateType == EPlayerClearBattleStateType.Normal)
		{
			base.BUSEventCollection.Evt_ResetSkillCD.Invoke();
		}
		base.BUSEventCollection.Evt_PlayerResetRecoverTalent.Invoke();
		base.BUSEventCollection.Evt_PlayerResetRecoverEquipAndSuitTalent.Invoke();
		if (PlayerClearBattleStateType == EPlayerClearBattleStateType.Normal)
		{
			base.BUSEventCollection.Evt_ResetUnitFaBaoState.Invoke();
		}
		base.BUSEventCollection.Evt_PlayerRebirthAddBuff.Invoke();
		base.BUSEventCollection.Evt_ResetDaShengStatus.Invoke();
		base.BUSEventCollection.Evt_ResetCBG.Invoke();
	}

	private void ResetAllActor()
	{
		base.BGWEventCollection.Evt_TriggerResetAllActors(EResetActorReason.InteractRebirthPoint);
	}

	private void OnTriggerPlayerRest()
	{
		ReSetPlayer(NeedResetAllActor: true);
	}

	private void OnTriggerPlayerRestByReBirth()
	{
		ActorOnPlayerRestReq();
		UIEC?.Evt_UI_ForceClearBindUnitList();
	}

	private void ActorOnPlayerRestReq()
	{
		CSMsgActorOnPlayerRestReq actorOnPlayerRest = new CSMsgActorOnPlayerRestReq();
		BTFEventCollection.Evt_ActorOnPlayerRestReq(actorOnPlayerRest, null);
	}

	private void ReSetPlayer(bool NeedResetAllActor)
	{
		ReSetConsumables();
		ClearBattleState(EPlayerClearBattleStateType.Normal);
		if (!IsOnline() && NeedResetAllActor)
		{
			ResetAllActor();
		}
		base.BUSEventCollection.Evt_TriggerPlayerRestToSvr.Invoke();
		ActorOnPlayerRestReq();
		base.BGSEventCollection.Evt_ClearAllAttachedProjectiles.Invoke();
		if (base.BUSEventCollection != null && AttrContainer != null)
		{
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.CurEnergy, AttrContainer.GetFloatValue(EBGUAttrFloat.TransEnergyMax));
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.FabaoEnergy, AttrContainer.GetFloatValue(EBGUAttrFloat.FabaoEnergyMax));
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergy, AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergyMax));
		}
		ReSetBaseState();
	}

	private void OnTriggerPlayerRestOnly()
	{
		ReSetPlayer(NeedResetAllActor: false);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PlayerRestData.FrameInt > 0)
		{
			PlayerRestData.FrameInt--;
			if (PlayerRestData.FrameInt == 0)
			{
				OnTriggerPlayerRestOnly();
			}
		}
	}

	private void OnChangePlayerTaskStage(int _TaskStageID, QuestStage Stage)
	{
		if (Stage == QuestStage.Finished)
		{
			FUStTaskStageDesc taskStageDesc = BGW_GameDB.GetTaskStageDesc(_TaskStageID);
			if (taskStageDesc != null && taskStageDesc.PlayerRest > 0)
			{
				PlayerRestData.FrameInt = 1;
			}
		}
	}
}
