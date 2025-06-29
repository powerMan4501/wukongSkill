using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_TransGuideComp : UActorCompBaseCS
{
	private const int ICE_BUFF_ID = 16070;

	private BUC_TransGuideData TransGuideData;

	private IBUC_PlayerSpellConfData PlayerSpellConfData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_BuffData BuffData;

	private IBPC_PlayerTagData PlayerTagData;

	private BGW_UIEventCollection UIEC;

	private IBGC_MovieData MovieData;

	public override void OnAttach()
	{
		TransGuideData = RequireWritableData<BUC_TransGuideData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PlayerSpellConfData = RequireReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		UIEC = BGW_UIEventCollection.Get(GetOwner());
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				TransGuideData.ResId = bGUCharacterCS.GetResID();
			}
		}
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_IncreasePEValue += new Del_IncreasePEValue(OnIncreasePEValue);
			base.BUSEventCollection.Evt_PEValueFull += new Del_Void(OnPEValueFull);
			base.BUSEventCollection.Evt_ClearPEValue += new Del_Void(ClearPEValue);
			base.BUSEventCollection.Evt_AddDetonate += new Del_Void(AddDetonate);
			base.BUSEventCollection.Evt_RemoveDetonate += new Del_Void(RemoveDetonate);
			base.BUSEventCollection.Evt_BuffUpdated += new Del_BuffUpdated(OnObservedUnitAddBuff);
			base.BUSEventCollection.Evt_TriggerSwitchMagicConfInfo += new Del_SwitchMagicConfInfo(OnTriggerSwitchMagicConfInfo);
			base.BUSEventCollection.Evt_IncreaseAttrFloat += new Del_IncreaseAttrFloat(OnIncreaseAttrFloat);
			base.BUSEventCollection.Evt_TriggerSwitchSpellSolution += new Del_Void_Int(OnTriggerSwitchSpellSolution);
		}
		InitGuideData();
	}

	public override void LateBeginPlay()
	{
		UpdateTransGuideData();
	}

	private void InitGuideData()
	{
		if (TransGuideData.ResId == 0)
		{
			return;
		}
		TransGuideData.CheckTransInputUITipsDescList = GameDBRuntime.GetTransInputUITipsDescListByResId(TransGuideData.GetResId());
		if (TransGuideData.CheckTransInputUITipsDescList != null)
		{
			if (TransGuideData.TransGuideDict == null)
			{
				TransGuideData.TransGuideDict = new Dictionary<int, TransInputUITipsDesc>();
			}
			UpdateTransGuideData();
		}
	}

	private void OnIncreasePEValue(float IncreaseValue, EPotentialEnergyIncreaseReason Reason)
	{
		if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			return;
		}
		if (IncreaseValue > 0f)
		{
			TransGuideData.HavePe = true;
			UpdateTransGuideData();
		}
		else if (IncreaseValue < 0f)
		{
			TransGuideData.IsPEFull = false;
			if (AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue) == 0f)
			{
				TransGuideData.HavePe = false;
			}
			UpdateTransGuideData();
		}
	}

	private void OnPEValueFull()
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			TransGuideData.IsPEFull = true;
			UpdateTransGuideData();
		}
	}

	private void ClearPEValue()
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			TransGuideData.IsPEFull = false;
			TransGuideData.HavePe = false;
			UpdateTransGuideData();
		}
	}

	private void AddDetonate()
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			TransGuideData.HaveDetonate = true;
			UpdateTransGuideData();
		}
	}

	private void RemoveDetonate()
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			TransGuideData.HaveDetonate = false;
			UpdateTransGuideData();
		}
	}

	private void OnObservedUnitAddBuff(int BuffId)
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			UpdateTransGuideData();
		}
	}

	private void OnTriggerSwitchSpellSolution(int SolutionId)
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			UpdateTransGuideData();
		}
	}

	private void OnTriggerSwitchMagicConfInfo(SpellType SpellType, int NewSpellId, int OldSpellId)
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			UpdateTransGuideData();
		}
	}

	private void OnIncreaseAttrFloat(EBGUAttrFloat AttrID, float IncreaseValue)
	{
		if (AttrID == EBGUAttrFloat.Pevalue && PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			UpdateTransGuideData();
		}
	}

	public override void OnBeginPlay()
	{
		if (TransGuideData.ResId > 0 && IsNeedGuideUI())
		{
			UIEC?.Evt_ShowTransGuideUI(B1: false);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (TransGuideData.ResId > 0 && IsNeedGuideUI())
		{
			UIEC?.Evt_ShowTransGuideUI(B1: true);
		}
	}

	private bool IsNeedGuideUI()
	{
		if (TransGuideData.ResId == GameDBRuntime.GetCommLogicCfgValue(CommCfgType.XuehouDefaultResid))
		{
			IBPC_TransData iBPC_TransData = RequireReadOnlyControledPlayerStateData<IBPC_TransData, BPC_TransData>();
			if (iBPC_TransData != null)
			{
				return !iBPC_TransData.IsPlotTrans();
			}
		}
		return true;
	}

	public void UpdateTransGuideData()
	{
		if (TransGuideData.CheckTransInputUITipsDescList == null)
		{
			return;
		}
		foreach (TransInputUITipsDesc checkTransInputUITipsDesc in TransGuideData.CheckTransInputUITipsDescList)
		{
			TransInputUITipsDesc value2;
			if (CheckGuideState(checkTransInputUITipsDesc.Condition, checkTransInputUITipsDesc.ConditionParamInt, checkTransInputUITipsDesc) && CheckGuideState(checkTransInputUITipsDesc.Condition2, checkTransInputUITipsDesc.ConditionParamInt2, checkTransInputUITipsDesc))
			{
				if (TransGuideData.TransGuideDict.TryGetValue(checkTransInputUITipsDesc.SortId, out var value))
				{
					if (checkTransInputUITipsDesc.PriorityId > value.PriorityId)
					{
						TransGuideData.TransGuideDict[checkTransInputUITipsDesc.SortId] = checkTransInputUITipsDesc;
					}
				}
				else
				{
					TransGuideData.TransGuideDict.Add(checkTransInputUITipsDesc.SortId, checkTransInputUITipsDesc);
				}
			}
			else if (TransGuideData.TransGuideDict.TryGetValue(checkTransInputUITipsDesc.SortId, out value2) && value2 == checkTransInputUITipsDesc)
			{
				TransGuideData.TransGuideDict.Remove(checkTransInputUITipsDesc.SortId);
			}
		}
		UIEC.Evt_UpdateTransGuideUI();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TransGuideData != null)
		{
			if (MovieData == null)
			{
				AGameStateBase gameState = UGameplayStatics.GetGameState(GetOwner());
				MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(gameState);
			}
			if ((MovieData != null && MovieData.IsPlaying()) || BGW_GameArchiveMgr.Get(GetOwner()).IsSeqPlaying())
			{
				TransGuideData.CanShowUI.SetValue(EChangeReason.ManualSet, value: false);
			}
			else
			{
				TransGuideData.CanShowUI.SetValue(EChangeReason.ManualSet, value: true);
			}
		}
	}

	private bool HaveStateBuff(TransInputUITipsDesc CheckInputUITipsDesc)
	{
		if (CheckInputUITipsDesc.StateBuffId1 > 0 && BuffData.HasBuff(CheckInputUITipsDesc.StateBuffId1))
		{
			return true;
		}
		if (CheckInputUITipsDesc.StateBuffId2 > 0 && BuffData.HasBuff(CheckInputUITipsDesc.StateBuffId2))
		{
			return true;
		}
		if (CheckInputUITipsDesc.StateBuffId3 > 0 && BuffData.HasBuff(CheckInputUITipsDesc.StateBuffId3))
		{
			return true;
		}
		return false;
	}

	private bool CheckGuideState(ETransInputCondition TransInputCondition, int ConditionParamInt, TransInputUITipsDesc CheckInputUITipsDesc)
	{
		if (!HaveStateBuff(CheckInputUITipsDesc))
		{
			return false;
		}
		return TransInputCondition switch
		{
			ETransInputCondition.None => true, 
			ETransInputCondition.FullPe => TransGuideData.IsPEFull, 
			ETransInputCondition.HavePe => TransGuideData.HavePe, 
			ETransInputCondition.HaveMark => TransGuideData.HaveDetonate, 
			ETransInputCondition.HaveBuff => BuffData.HasBuff(ConditionParamInt), 
			ETransInputCondition.NoBuff => !BuffData.HasBuff(ConditionParamInt), 
			ETransInputCondition.EquipSpell => CheckEquipSpell(ConditionParamInt), 
			ETransInputCondition.PeHiger => AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue) >= (float)ConditionParamInt, 
			_ => false, 
		};
	}

	private bool CheckEquipSpell(int SpellId)
	{
		if (PlayerSpellConfData != null)
		{
			foreach (FUStMagicConfInfo item in PlayerSpellConfData.MagicConfInfo)
			{
				if (item.SpellID == SpellId)
				{
					return true;
				}
			}
		}
		return false;
	}
}
