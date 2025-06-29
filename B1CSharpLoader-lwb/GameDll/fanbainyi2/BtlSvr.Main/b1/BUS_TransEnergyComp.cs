using b1.EventDelDefine;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_TransEnergyComp : UActorCompBaseCS
{
	private IBUC_AttrContainer AttrContron;

	private IBPC_PlayerTagData PlayerTagData;

	private BUAttrCostTemplate AttrCostTemplate;

	private IBUC_SimpleStateData SimpleStateData;

	private IBPC_TransData TransData;

	private BUC_TransEnergyData TransEnergyData;

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	public override void OnAttach()
	{
		BPSEventCollection = BPS_EventCollectionCS.Get((GetOwner() as BGUCharacterCS).PlayerState);
		base.BUSEventCollection.Evt_GMSetFullEnergy += new Del_Void_Float(GMSetFullEnergy);
		base.BUSEventCollection.Evt_SetEnergyInfo += new Del_Void_Int(OnSetEnergyInfo);
		base.BUSEventCollection.Evt_CostTransEnergyBySkill += new Del_Void_Float(OnCostTransEnergyBySkill);
		AttrContron = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		TransData = RequireReadOnlyControledPlayerStateData<IBPC_TransData, BPC_TransData>();
		AttrCostTemplate = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(EAttrCostType.TransEnergy);
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		TransEnergyData = RequireWritableData<BUC_TransEnergyData>();
		base.BUSEventCollection.Evt_AddSpellItem += new Del_Void_Int(ChangePlayerItem);
	}

	private void ChangePlayerItem(int ItemId)
	{
		if (GameDBRuntime.GetItemDesc(ItemId).ItemType == ItemType.Spell)
		{
			TransEnergyData.ReSetDelay = 1;
		}
	}

	private void ReCoverEnergyByGetNewSpell()
	{
		base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.CurEnergy, AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMax));
	}

	private void OnCostTransEnergyBySkill(float CostEnergy)
	{
		AttrCostTemplate.DoCostAttrValue(Owner, AttrContron, CostEnergy, 0f);
	}

	private void GMSetFullEnergy(float GMFullEnergy)
	{
		if (GMFullEnergy > 0f)
		{
			AttrCostTemplate.DoCostAttrValue(Owner, AttrContron, 0f - (AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMax) - AttrContron.GetFloatValue(EBGUAttrFloat.CurEnergy)), 0f);
		}
	}

	private void OnSetEnergyInfo(int SpellId)
	{
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(SpellId);
		if (spellDesc != null)
		{
			if (spellDesc.FloatParam.Count < 4)
			{
				BGW_LogUtil.LogError($"ID = {SpellId}  SpellDesc.IntParam.Count < 4");
				return;
			}
			base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.TransEnergyMaxBase, spellDesc.FloatParam[0] - AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMaxBase));
			base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.EnergyMinConsumeBase, spellDesc.FloatParam[1] - AttrContron.GetFloatValue(EBGUAttrFloat.EnergyMinConsumeBase));
			base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.EnergyConsumeSpeedBase, spellDesc.FloatParam[2] - AttrContron.GetFloatValue(EBGUAttrFloat.EnergyConsumeSpeedBase));
			base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.EnergyIncreaseSpeedBase, spellDesc.FloatParam[3] - AttrContron.GetFloatValue(EBGUAttrFloat.EnergyIncreaseSpeedBase));
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickTransEnergy(DeltaTime);
		if (TransEnergyData.ReSetDelay > 0)
		{
			TransEnergyData.ReSetDelay--;
			if (TransEnergyData.ReSetDelay == 0)
			{
				ReCoverEnergyByGetNewSpell();
			}
		}
	}

	private void TickTransEnergy(float DeltaTime)
	{
		if (PlayerTagData == null)
		{
			return;
		}
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			if (AttrContron.GetFloatValue(EBGUAttrFloat.CurEnergy) > 0f && !PlayerTagData.HasTag(EBGPPlayerTag.PauseEnergyCost))
			{
				float floatValue = AttrContron.GetFloatValue(EBGUAttrFloat.EnergyConsumeSpeed);
				float num = DeltaTime * floatValue;
				if (num != 0f)
				{
					AttrCostTemplate.DoCostAttrValue(Owner, AttrContron, num, 0f);
				}
			}
		}
		else if (AttrContron.GetFloatValue(EBGUAttrFloat.CurEnergy) < AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMax))
		{
			float floatValue2 = AttrContron.GetFloatValue(EBGUAttrFloat.EnergyIncreaseSpeed);
			float num2 = DeltaTime * floatValue2;
			if (num2 != 0f)
			{
				AttrCostTemplate.DoCostAttrValue(Owner, AttrContron, 0f - num2, 0f);
			}
		}
		TickEndTrans(DeltaTime);
	}

	private void TickEndTrans(float DeltaTime)
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			if (AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMax) > 0f && AttrContron.GetFloatValue(EBGUAttrFloat.CurEnergy) <= 0f && TransData != null && !TransData.IsPlotTrans())
			{
				BPSEventCollection?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.EnergyEmpty, default(PlayerTransParam));
			}
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantTrans))
			{
				BPSEventCollection?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CantTrans, default(PlayerTransParam));
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}
}
