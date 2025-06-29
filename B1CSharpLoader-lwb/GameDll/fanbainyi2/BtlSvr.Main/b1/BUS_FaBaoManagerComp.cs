using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_FaBaoManagerComp : UActorCompBaseCS
{
	private BGUCharacterCS OwnerCharacter;

	private BUC_EquipFaBaoData EquipFaBaoData { get; set; }

	private IBUC_BuffData BuffData { get; set; }

	private BUAttrCostTemplate AttrCostTemplate { get; set; }

	private IBUC_AttrContainer AttrContainer { get; set; }

	public override void OnAttach()
	{
		EquipFaBaoData = RequireWritableData<BUC_EquipFaBaoData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		AttrCostTemplate = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(EAttrCostType.FabaoEnergy);
		OwnerCharacter = Owner as BGUCharacterCS;
		base.BUSEventCollection.Evt_UnitCastFaBaoSkill += new Del_Void(TryCastFaBaoSkill);
		base.BUSEventCollection.Evt_UnitCastFaBaoSkillSucceed += new Del_Void(OnFaBaoCastSucceed);
		base.BUSEventCollection.Evt_UnitEquipFaBao += new Del_Void_Int(EquipFaBao);
		base.BUSEventCollection.Evt_UnitUnequipFaBao += new Del_Void(UnequipFaBao);
		base.BUSEventCollection.Evt_ResetUnitFaBaoState += new Del_Void(OnResetUnitFaBaoState);
	}

	public override void PreBeginPlay()
	{
		EquipFaBaoData.CurrentFaBaoID = -1;
	}

	public override void OnBeginPlay()
	{
		InitEquipFaBaoData();
	}

	private void InitEquipFaBaoData()
	{
		APawn aPawn = Owner as APawn;
		if (!(aPawn != null))
		{
			return;
		}
		IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aPawn.PlayerState);
		if (readOnlyData == null)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, int> equip in readOnlyData.EquipList)
		{
			if (equip.Key == EquipPosition.Fabao)
			{
				EquipFaBaoInternal(equip.Value);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (EquipFaBaoData.CurrentFaBaoID <= 0)
		{
			return;
		}
		switch (EquipFaBaoData.FaBaoState)
		{
		case EFaBaoState.Carry:
			if (EquipFaBaoData.HasBuffList != null && EquipFaBaoData.HasBuffList.Count > 0)
			{
				foreach (int hasBuff in EquipFaBaoData.HasBuffList)
				{
					if (!BuffData.HasBuff(hasBuff))
					{
						EquipFaBaoData.bSatisfiedHasBuffCondition = false;
						break;
					}
					EquipFaBaoData.bSatisfiedHasBuffCondition = true;
				}
				break;
			}
			EquipFaBaoData.bSatisfiedHasBuffCondition = true;
			break;
		case EFaBaoState.Cast:
			EquipFaBaoData.CurrentCastDuration -= DeltaTime * 1000f;
			if (EquipFaBaoData.CurrentCastDuration <= 0f)
			{
				SetFaBaoState(EFaBaoState.Cooldown);
			}
			break;
		case EFaBaoState.Cooldown:
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.FabaoEnergy);
			float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.FabaoEnergyMax);
			EquipFaBaoData.FaBaoCoolDownPercentage = (((double)floatValue2 > 1E-06) ? (floatValue / floatValue2) : 0f);
			if ((double)MathLib.Abs(EquipFaBaoData.FaBaoCoolDownPercentage - 1f) < 1E-06)
			{
				SetFaBaoState(EFaBaoState.Carry);
			}
			break;
		}
		}
	}

	private void OnResetUnitFaBaoState()
	{
		SetFaBaoStateImpl((EquipFaBaoData.CurrentFaBaoID > 0) ? EFaBaoState.Carry : EFaBaoState.None);
	}

	private void SetFaBaoState(EFaBaoState InFaBaoState)
	{
		if (EquipFaBaoData.FaBaoState != InFaBaoState)
		{
			SetFaBaoStateImpl(InFaBaoState);
		}
	}

	private void SetFaBaoStateImpl(EFaBaoState InFaBaoState)
	{
		switch (InFaBaoState)
		{
		case EFaBaoState.None:
			DeactivateCastBuff();
			DeactivateCarryBuff();
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainFabaoEnergy);
			EquipFaBaoData.CurrentCastDuration = -1f;
			EquipFaBaoData.FaBaoCoolDownPercentage = 0f;
			break;
		case EFaBaoState.Carry:
			DeactivateCastBuff();
			ActivateCarryBuff();
			EquipFaBaoData.CurrentCastDuration = -1f;
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainFabaoEnergy, IsRemove: true);
			break;
		case EFaBaoState.Cast:
			ActivateCastBuff();
			if (EquipFaBaoData.bIsFaBaoCarryBuffEnableWhenCasting)
			{
				ActivateCarryBuff();
			}
			else
			{
				DeactivateCarryBuff();
			}
			EquipFaBaoData.CurrentCastDuration = EquipFaBaoData.FaBaoCastDuration;
			AttrCostTemplate.DoCostAttrValue(Owner, AttrContainer, AttrContainer.GetFloatValue(EBGUAttrFloat.FabaoEnergy), 0f);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainFabaoEnergy);
			break;
		case EFaBaoState.Cooldown:
			DeactivateCastBuff();
			ActivateCarryBuff();
			EquipFaBaoData.CurrentCastDuration = -1f;
			EquipFaBaoData.FaBaoCoolDownPercentage = 0f;
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainFabaoEnergy, IsRemove: true);
			break;
		}
		EquipFaBaoData.FaBaoState = InFaBaoState;
	}

	private void EquipFaBao(int FaBaoID)
	{
		EquipFaBaoInternal(FaBaoID);
		if (GameDBRuntime.GetEquipFaBaoAttrDesc(FaBaoID) != null)
		{
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.FabaoEnergy, 0f);
		}
	}

	private void EquipFaBaoInternal(int FaBaoID)
	{
		EquipFaBaoAttrDesc equipFaBaoAttrDesc = GameDBRuntime.GetEquipFaBaoAttrDesc(FaBaoID);
		if (equipFaBaoAttrDesc == null)
		{
			return;
		}
		if (EquipFaBaoData.CurrentFaBaoID != -1)
		{
			UnequipFaBao();
		}
		base.BGWEventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload(ECSExtension.ToEntity(Owner), EPreloadPlayerAbilityType.FaBao);
		EquipFaBaoData.Equip(equipFaBaoAttrDesc);
		if (EquipFaBaoData.HasBuffList != null && EquipFaBaoData.HasBuffList.Count > 0)
		{
			foreach (int hasBuff in EquipFaBaoData.HasBuffList)
			{
				if (!BuffData.HasBuff(hasBuff))
				{
					EquipFaBaoData.bSatisfiedHasBuffCondition = false;
					break;
				}
				EquipFaBaoData.bSatisfiedHasBuffCondition = true;
			}
		}
		else
		{
			EquipFaBaoData.bSatisfiedHasBuffCondition = true;
		}
		SetFaBaoState(EFaBaoState.Cooldown);
		base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.FabaoEnergyMax, equipFaBaoAttrDesc.CastEnergy);
	}

	private void UnequipFaBao()
	{
		SetFaBaoState(EFaBaoState.None);
		EquipFaBaoData.Clear();
	}

	private void ActivateBuffs(List<int> BuffIDs)
	{
		if (BuffIDs == null)
		{
			return;
		}
		foreach (int BuffID in BuffIDs)
		{
			if (!BuffData.HasBuff(BuffID))
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(BuffID, OwnerCharacter, OwnerCharacter, -1f, EBuffSourceType.EquipFabao);
			}
		}
	}

	private void DeactivateBuffs(List<int> BuffIDs)
	{
		if (BuffIDs == null)
		{
			return;
		}
		foreach (int BuffID in BuffIDs)
		{
			if (BuffData.HasBuff(BuffID))
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(BuffID, EBuffEffectTriggerType.None, 1);
			}
		}
	}

	private void ActivateCarryBuff()
	{
		ActivateBuffs(EquipFaBaoData.FaBaoCarryBuffIDs);
	}

	private void ActivateCastBuff()
	{
		ActivateBuffs(EquipFaBaoData.FaBaoCastBuffIDs);
	}

	private void DeactivateCarryBuff()
	{
		DeactivateBuffs(EquipFaBaoData.FaBaoCarryBuffIDs);
	}

	private void DeactivateCastBuff()
	{
		DeactivateBuffs(EquipFaBaoData.FaBaoCastBuffIDs);
	}

	private void TryCastFaBaoSkill()
	{
		if ((EquipFaBaoData.CurrentFaBaoID <= 0 || EquipFaBaoData.FaBaoState == EFaBaoState.Carry) && EquipFaBaoData.bSatisfiedHasBuffCondition)
		{
			if (EquipFaBaoData.FaBaoSkillID <= 0)
			{
				OnFaBaoCastSucceed();
			}
			else
			{
				base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(EquipFaBaoData.FaBaoSkillID, ECastSkillSourceType.FaBaoSkill));
			}
		}
	}

	private void OnFaBaoCastSucceed()
	{
		SetFaBaoState(EFaBaoState.Cast);
	}
}
