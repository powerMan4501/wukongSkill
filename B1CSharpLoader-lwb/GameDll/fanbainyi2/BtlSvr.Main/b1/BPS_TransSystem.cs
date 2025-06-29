using b1.EventDelDefine;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BPS_TransSystem : PlayerControllerSystemBase
{
	private IBPC_PlayerTagData PlayerTagData;

	private IBIC_LevelData LevelData;

	private IBPC_PlayerAttrData PlayerAttrData;

	private BPS_GSEventCollection BPSEventCollection;

	private BPC_TransData TransData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		TransData = RequireWritablePlayerStateData<BPC_TransData>();
		PlayerTagData = RequireReadOnlyPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		LevelData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner);
		PlayerAttrData = RequireReadOnlyPlayerStateData<IBPC_PlayerAttrData, BPC_PlayerAttrData>();
		BPSEventCollection = GetPlayerEventCollection();
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.PauseEneryEnd, -1f);
			BPSEventCollection.Evt_BPS_SwitchPlayerTransState += new Del_SwitchPlayerTransState(OnSwitchTransState);
			BPSEventCollection.Evt_BPS_PauseCostEnergy += new Del_Void(OnPauseCostEnergy);
			BPSEventCollection.Evt_BPS_ResumeCostEnergy += new Del_Void(OnResumeCostEnergy);
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	private void OnPauseCostEnergy()
	{
		BPSEventCollection?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.PauseEneryBegin, -1f);
	}

	private void OnResumeCostEnergy()
	{
		BPSEventCollection?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.PauseEneryEnd, -1f);
	}

	private void OnSwitchTransState(AActor OldActor, int NewActorResId)
	{
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
		if (NewActorResId == commLogicCfgValue)
		{
			if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				BPSEventCollection?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.TransformEnd, -1f);
			}
		}
		else if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			BPSEventCollection?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.TransformBegin, -1f);
		}
		TransData.SetCurActorResId(NewActorResId);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OldActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_ClearAllAbnormalState.Invoke();
		}
		BGUPlayerCharacterCS controlledPlayerCharacter = GetControlledPlayerCharacter();
		if (!(controlledPlayerCharacter == null))
		{
			int resID = controlledPlayerCharacter.GetResID();
			TransData.DefaultSpellTypeDict.TryGetValue(resID, out var value);
			TransData.DefaultSpellType = value;
			TransData.LastControlUnitResID = BGU_DataUtil.GetActorResID(OldActor);
		}
	}
}
