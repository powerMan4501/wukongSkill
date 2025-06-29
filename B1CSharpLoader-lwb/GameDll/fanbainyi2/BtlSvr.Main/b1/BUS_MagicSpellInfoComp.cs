using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_MagicSpellInfoComp : UActorCompBaseCS
{
	private BUC_MagicSpellInfoData MagicSpellInfoData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_PhantomRushData PhantomRushData;

	private IBUC_PlayerSpellConfData PlayerSpellConfData;

	private IBUC_SkillMappingData SkillMappingData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_AttrContainer AttrContainer;

	private b1.IBUC_LifeSavingData LifeSavingData;

	private IBPC_PlayerTagData PlayerTagData;

	public override void OnAttach()
	{
		MagicSpellInfoData = RequireWritableData<BUC_MagicSpellInfoData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		PhantomRushData = RequireReadOnlyData<IBUC_PhantomRushData, BUC_PhantomRushData>();
		PlayerSpellConfData = RequireReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>();
		SkillMappingData = RequireReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		LifeSavingData = RequireReadOnlyData<b1.IBUC_LifeSavingData, BUC_LifeSavingData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
	}

	public override void LateBeginPlay()
	{
		InitData();
	}

	public void InitData()
	{
		APawn aPawn = GetOwner() as APawn;
		if (PlayerSpellConfData != null)
		{
			foreach (FUStMagicConfInfo item in PlayerSpellConfData.MagicConfInfo)
			{
				MagicSpellInfoData.SpellStateList.Add(new BGUSpellState(item.SpellID));
			}
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPawn.GetController());
		if (readOnlyData == null || readOnlyData.RoleData == null)
		{
			return;
		}
		foreach (int spell in readOnlyData.RoleData.RoleCs.Actor.Progress.SpellList)
		{
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(spell);
			if (spellDesc != null)
			{
				MagicSpellInfoData.AllSpellStateList.Add(new BGUSpellState(spellDesc.Id));
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PlayerSpellConfData != null && PlayerTagData != null)
		{
			UpdataMagicSkillInfo();
			UpdataAllSpellInfo();
		}
	}

	private void UpdataMagicSkillInfo()
	{
		for (int i = 0; i < PlayerSpellConfData.MagicConfInfo.Count; i++)
		{
			FUStMagicConfInfo fUStMagicConfInfo = PlayerSpellConfData.MagicConfInfo[i];
			MagicSpellInfoData.SpellStateList[i].SpellID = fUStMagicConfInfo.SpellID;
			if (fUStMagicConfInfo.SpellID != 0)
			{
				GetSpellState(fUStMagicConfInfo.SpellID, out var IsLock, out var IsDisable, out var CDTimePercent, out var AttrCostType, out var Value, out var AttrCostType2, out var Value2);
				MagicSpellInfoData.SpellStateList[i].IsLock = IsLock;
				MagicSpellInfoData.SpellStateList[i].IsDisable = IsDisable;
				MagicSpellInfoData.SpellStateList[i].CDTimePercent = CDTimePercent;
				MagicSpellInfoData.SpellStateList[i].AttrCostType1 = AttrCostType;
				MagicSpellInfoData.SpellStateList[i].CostValue1 = Value;
				MagicSpellInfoData.SpellStateList[i].AttrCostType2 = AttrCostType2;
				MagicSpellInfoData.SpellStateList[i].CostValue2 = Value2;
			}
		}
	}

	private void UpdataAllSpellInfo()
	{
		for (int i = 0; i < MagicSpellInfoData.AllSpellStateList.Count; i++)
		{
			BGUSpellState bGUSpellState = MagicSpellInfoData.AllSpellStateList[i];
			GetSpellState(bGUSpellState.SpellID, out var IsLock, out var IsDisable, out var CDTimePercent, out var AttrCostType, out var Value, out var AttrCostType2, out var Value2);
			MagicSpellInfoData.AllSpellStateList[i].IsLock = IsLock;
			MagicSpellInfoData.AllSpellStateList[i].IsDisable = IsDisable;
			MagicSpellInfoData.AllSpellStateList[i].CDTimePercent = CDTimePercent;
			MagicSpellInfoData.AllSpellStateList[i].AttrCostType1 = AttrCostType;
			MagicSpellInfoData.AllSpellStateList[i].CostValue1 = Value;
			MagicSpellInfoData.AllSpellStateList[i].AttrCostType2 = AttrCostType2;
			MagicSpellInfoData.AllSpellStateList[i].CostValue2 = Value2;
		}
	}

	private void GetSpellState(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent, out EAttrCostType AttrCostType1, out float Value1, out EAttrCostType AttrCostType2, out float Value2)
	{
		IsLock = false;
		IsDisable = false;
		CDTimePercent = 0f;
		AttrCostType1 = EAttrCostType.None;
		AttrCostType2 = EAttrCostType.None;
		Value1 = 0f;
		Value2 = 0f;
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(SpellID);
		if (spellDesc == null)
		{
			return;
		}
		if (LifeSavingData != null && spellDesc.Id == LifeSavingData.SpellID)
		{
			CDTimePercent = LifeSavingData.GetCDTimePercent();
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.ForbidAllLifeSavingHair) || SimpleStateData.HasSimpleState(EBGUSimpleState.ForbidAllLifeSavingHairExceptJZHHD))
			{
				IsDisable = true;
			}
			return;
		}
		int curResultSkillID = SkillMappingData.GetCurResultSkillID(spellDesc.SkillId);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(curResultSkillID, Owner);
		if (skillSDesc == null)
		{
			return;
		}
		CDTimePercent = BGUFuncLibSkillCS.GetSkillCDTimePercent(Owner, curResultSkillID, in SkillInstsData);
		int num = -1;
		FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(PhantomRushData.NowConfigID, Owner);
		if (phantomRushSkillConfigDesc != null)
		{
			num = phantomRushSkillConfigDesc.PhantomRushSkillID;
		}
		if (num == curResultSkillID)
		{
			IsDisable = UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Silent) || SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreSpell) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush) || SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove);
		}
		else if (spellDesc.Type == SpellType.BianShen)
		{
			bool flag = true;
			if (skillSDesc.MinAttrCostType1 != EAttrCostType.Stamina)
			{
				BUAttrCostTemplate attrCostTemplate = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(skillSDesc.MinAttrCostType1);
				if (attrCostTemplate != null)
				{
					(int, float) costValue = attrCostTemplate.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase1, skillSDesc.MinAttrCostRatio1);
					AttrCostType1 = skillSDesc.MinAttrCostType1;
					Value1 = ((costValue.Item1 != 0) ? ((float)costValue.Item1) : costValue.Item2);
					flag = attrCostTemplate.IsAttrValueEnough(AttrContainer, skillSDesc.MinAttrCostBase1, skillSDesc.MinAttrCostRatio1);
				}
			}
			if (skillSDesc.MinAttrCostType2 != EAttrCostType.Stamina)
			{
				BUAttrCostTemplate attrCostTemplate2 = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(skillSDesc.MinAttrCostType2);
				if (attrCostTemplate2 != null)
				{
					(int, float) costValue2 = attrCostTemplate2.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase2, skillSDesc.MinAttrCostRatio2);
					AttrCostType2 = skillSDesc.MinAttrCostType2;
					Value2 = ((costValue2.Item1 != 0) ? ((float)costValue2.Item1) : costValue2.Item2);
					if (flag)
					{
						flag = attrCostTemplate2.IsAttrValueEnough(AttrContainer, skillSDesc.MinAttrCostBase2, skillSDesc.MinAttrCostRatio2);
					}
				}
			}
			bool flag2 = false;
			if (!OwnerAsCharacterCS.IsNullOrDestroyed() && OwnerAsCharacterCS.CharacterMovement != null)
			{
				flag2 = OwnerAsCharacterCS.CharacterMovement.IsFalling();
			}
			IsDisable = flag2 || UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || UnitStateData.HasState(EBGUUnitState.GlideMoving) || UnitStateData.HasState(EBGUUnitState.JumpMoving) || SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreSpell) || SimpleStateData.HasSimpleState(EBGUSimpleState.Silent) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpleStateData.HasSimpleState(EBGUSimpleState.CantTrans) || PlayerTagData.HasTag(EBGPPlayerTag.DisableTransforming) || !flag || SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove);
		}
		else
		{
			IsDisable = UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || UnitStateData.HasState(EBGUUnitState.GlideMoving) || UnitStateData.HasState(EBGUUnitState.JumpMoving) || SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreSpell) || SimpleStateData.HasSimpleState(EBGUSimpleState.Silent) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove);
		}
		if (spellDesc.Type == SpellType.BianShen)
		{
			return;
		}
		if (skillSDesc.MinAttrCostType1 != EAttrCostType.Stamina)
		{
			BUAttrCostTemplate attrCostTemplate3 = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(skillSDesc.MinAttrCostType1);
			if (attrCostTemplate3 != null)
			{
				(int, float) costValue3 = attrCostTemplate3.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase1, skillSDesc.MinAttrCostRatio1);
				AttrCostType1 = skillSDesc.MinAttrCostType1;
				Value1 = ((costValue3.Item1 != 0) ? ((float)costValue3.Item1) : costValue3.Item2);
				IsLock = !attrCostTemplate3.IsAttrValueEnough(AttrContainer, skillSDesc.MinAttrCostBase1, skillSDesc.MinAttrCostRatio1);
			}
		}
		if (skillSDesc.MinAttrCostType2 == EAttrCostType.Stamina)
		{
			return;
		}
		BUAttrCostTemplate attrCostTemplate4 = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(skillSDesc.MinAttrCostType2);
		if (attrCostTemplate4 != null)
		{
			(int, float) costValue4 = attrCostTemplate4.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase2, skillSDesc.MinAttrCostRatio2);
			AttrCostType2 = skillSDesc.MinAttrCostType2;
			Value2 = ((costValue4.Item1 != 0) ? ((float)costValue4.Item1) : costValue4.Item2);
			if (!IsLock)
			{
				IsLock = !attrCostTemplate4.IsAttrValueEnough(AttrContainer, skillSDesc.MinAttrCostBase2, skillSDesc.MinAttrCostRatio2);
			}
		}
	}
}
