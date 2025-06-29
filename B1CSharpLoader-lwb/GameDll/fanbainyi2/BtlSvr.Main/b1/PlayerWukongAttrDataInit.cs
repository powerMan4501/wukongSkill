using System.Collections.Generic;
using ArchiveB1;
using b1.ECS;
using BtlShare;
using CsB1;
using UnrealEngine.Engine;

namespace b1;

public class PlayerWukongAttrDataInit : CharacterAttrDataInitTemplate, IPlayerDataInitTemplate, IWukongDataInitTemplate
{
	public PlayerWukongAttrDataInit(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataPreBeginPlay()
	{
		base.InitDataPreBeginPlay();
		GetData<BUC_AttrContainer>();
		BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>((Owner as APawn)?.PlayerState);
	}

	public override void InitDataLateBeginPlay()
	{
		InitEnergy();
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			CSMsgAttrRefreshReq attrRefresh = new CSMsgAttrRefreshReq();
			BTF_EventCollectionCS.Get(bGUCharacterCS.PlayerState)?.Evt_AttrRefreshReq(attrRefresh, null);
		}
	}

	public void PostLogin(RoleData RoleData)
	{
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		foreach (PlayerPersistentAttr item in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerAttrData, BPC_PlayerAttrData>((Owner as APawn).PlayerState).PlayerPersistentAttr)
		{
			if (item.AttrValueType == EPlayerAttrRecoverType.Percentage)
			{
				data.SetFloatValue((EBGUAttrFloat)item.AttrId, item.AttrValue * data.GetFloatValue((EBGUAttrFloat)item.AttrMaxId));
			}
			else
			{
				data.SetFloatValue((EBGUAttrFloat)item.AttrId, item.AttrValue);
			}
			if (item.AttrId == 151 && item.AttrValue == 0f)
			{
				BGW_LogUtil.LogError("Error Archive HP = 0 !!");
				data.SetFloatValue((EBGUAttrFloat)item.AttrId, 1f);
			}
		}
		if (!B1Global.GIsBossRushMode)
		{
			return;
		}
		foreach (KeyValuePair<int, int> item2 in BUS_TransPlayerDataBindComp.PlayerAttrDict)
		{
			if (item2.Key != 191)
			{
				data.SetFloatValue((EBGUAttrFloat)item2.Key, data.GetFloatValue((EBGUAttrFloat)item2.Value));
			}
		}
	}

	public void PostTrans(AActor OldActor)
	{
		APawn obj = Owner as APawn;
		IBPC_TransData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(obj.PlayerState);
		BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(obj);
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OldActor);
		BGW_GameDB.GetPlayerTransAttrDesc(readOnlyData.GetLastControlUnitResID());
		BPC_PlayerAttrData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerAttrData>((Owner as APawn).PlayerState);
		foreach (PlayerPersistentAttr item in readOnlyData3.PlayerPersistentAttr)
		{
			if (item.AttrValueType == EPlayerAttrRecoverType.Percentage)
			{
				readOnlyData2.SetFloatValue((EBGUAttrFloat)item.AttrId, item.AttrValue * readOnlyData2.GetFloatValue((EBGUAttrFloat)item.AttrMaxId));
			}
			else
			{
				readOnlyData2.SetFloatValue((EBGUAttrFloat)item.AttrId, item.AttrValue);
			}
			if (item.AttrId == 151)
			{
				readOnlyData3.HpPercentTransTmp = item.AttrValue;
			}
			if (item.AttrId == 152)
			{
				readOnlyData3.MpPercentTransTmp = item.AttrValue;
			}
		}
	}

	public void SetAttrTransAfterActiveTalent()
	{
		BPC_PlayerAttrData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerAttrData>((Owner as APawn).PlayerState);
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		if (readOnlyData.HpPercentTransTmp > 0f)
		{
			data.SetFloatValue(EBGUAttrFloat.Hp, readOnlyData.HpPercentTransTmp * data.GetFloatValue(EBGUAttrFloat.HpMax));
			readOnlyData.HpPercentTransTmp = 0f;
		}
		if (readOnlyData.MpPercentTransTmp > 0f)
		{
			data.SetFloatValue(EBGUAttrFloat.Mp, readOnlyData.MpPercentTransTmp * data.GetFloatValue(EBGUAttrFloat.MpMax));
			readOnlyData.MpPercentTransTmp = 0f;
		}
	}

	public void BossRushReCoverAttrData(Dictionary<int, float> BossIterationsAttrCacheDict)
	{
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		foreach (KeyValuePair<int, float> item in BossIterationsAttrCacheDict)
		{
			if ((byte)item.Key == 191)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreasePEValue.Invoke(item.Value, EPotentialEnergyIncreaseReason.Normal);
			}
			else
			{
				data.SetFloatValue((EBGUAttrFloat)item.Key, item.Value);
			}
		}
	}
}
