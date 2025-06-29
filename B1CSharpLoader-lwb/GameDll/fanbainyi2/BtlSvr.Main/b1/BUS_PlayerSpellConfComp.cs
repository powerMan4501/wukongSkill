using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_PlayerSpellConfComp : UActorCompBaseCS
{
	private BUC_PlayerSpellConfData PlayerSpellConfData;

	private IBPC_PlayerTagData PlayerTagData;

	public override void OnAttach()
	{
		PlayerSpellConfData = RequireWritableData<BUC_PlayerSpellConfData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		base.BUSEventCollection.Evt_SwitchMagicConfInfo += new Del_SwitchMagicConfInfo(OnSwitchMagicConfInfo);
		base.BUSEventCollection.Evt_SwitchSpellSolution += new Del_Void_Int(OnSwitchSpellSolution);
		base.BUSEventCollection.Evt_GMInitAttrByMaxAttr += new Del_Void(InitMagicConfInfo);
	}

	public override void OnBeginPlay()
	{
		InitMagicConfInfo();
	}

	private void InitMagicConfInfo()
	{
		APawn aPawn = GetOwner() as APawn;
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPawn.GetController());
		if (readOnlyData == null || readOnlyData.RoleData == null)
		{
			return;
		}
		PlayerSpellConfData.CurrentTransFormID = 0;
		PlayerSpellConfData.MagicConfInfo.Clear();
		FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(bGUCharacterCS.GetResID());
		ReadOnlySpellItemList readOnlySpellItemList = readOnlyData.RoleData?.RoleCs?.Actor?.Wear?.SpellList;
		if (fUStPlayerTransUnitConfDesc != null)
		{
			foreach (FUStMagicConfInfo magicSkillInfo in fUStPlayerTransUnitConfDesc.MagicSkillInfoList)
			{
				SpellType spellType = magicSkillInfo.Type;
				int num = magicSkillInfo.SpellID;
				if (fUStPlayerTransUnitConfDesc.SwitchMagicSkillInfoList != null && fUStPlayerTransUnitConfDesc.SwitchMagicSkillInfoList.Count > 0 && readOnlySpellItemList != null && readOnlySpellItemList.Count > 0)
				{
					bool flag = false;
					foreach (FUStSwitchMagicConfInfo switchMagicSkillInfo in fUStPlayerTransUnitConfDesc.SwitchMagicSkillInfoList)
					{
						foreach (ReadOnlySpellItem item in readOnlySpellItemList)
						{
							if (spellType == item.Type && item.Type == switchMagicSkillInfo.FindType && item.SpellId == switchMagicSkillInfo.FindSpellID)
							{
								spellType = switchMagicSkillInfo.SetType;
								num = switchMagicSkillInfo.SetSpellID;
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
				PlayerSpellConfData.MagicConfInfo.Add(new FUStMagicConfInfo
				{
					Type = spellType,
					SpellID = num
				});
				base.BUSEventCollection?.Evt_TriggerSwitchMagicConfInfo.Invoke(spellType, num, 0);
			}
		}
		else if (readOnlySpellItemList != null && readOnlySpellItemList.Count > 0)
		{
			foreach (ReadOnlySpellItem item2 in readOnlySpellItemList)
			{
				PlayerSpellConfData.MagicConfInfo.Add(new FUStMagicConfInfo
				{
					Type = item2.Type,
					SpellID = item2.SpellId
				});
				base.BUSEventCollection?.Evt_TriggerSwitchMagicConfInfo.Invoke(item2.Type, item2.SpellId, 0);
			}
		}
		base.BGWEventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload(ECSExtension.ToEntity(Owner), EPreloadPlayerAbilityType.Magic);
	}

	private void OnSwitchSpellSolution(int SolutionID)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(bGUCharacterCS.GetResID(), SolutionID);
			if (fUStPlayerTransUnitConfDesc != null)
			{
				PlayerSpellConfData.MagicConfInfo.Clear();
				PlayerSpellConfData.MagicConfInfo.AddRange(fUStPlayerTransUnitConfDesc.Clone().MagicSkillInfoList);
				PlayerSpellConfData.CurrentTransFormID = SolutionID;
			}
			base.BUSEventCollection?.Evt_TriggerSwitchSpellSolution.Invoke(SolutionID);
		}
	}

	private void OnSwitchMagicConfInfo(SpellType SpellType, int NewSpellId, int OldSpellId)
	{
		for (int i = 0; i < PlayerSpellConfData.MagicConfInfo.Count; i++)
		{
			if (PlayerSpellConfData.MagicConfInfo[i].Type != SpellType)
			{
				continue;
			}
			if (SpellType == SpellType.BianShen)
			{
				if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
				{
					break;
				}
				base.BUSEventCollection?.Evt_SetEnergyInfo.Invoke(NewSpellId);
			}
			PlayerSpellConfData.MagicConfInfo[i].SpellID = NewSpellId;
			base.BUSEventCollection?.Evt_TriggerSwitchMagicConfInfo.Invoke(SpellType, NewSpellId, OldSpellId);
			break;
		}
		base.BGWEventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload(ECSExtension.ToEntity(Owner), EPreloadPlayerAbilityType.Magic);
	}
}
