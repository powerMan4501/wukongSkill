using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_TalentComp : UActorCompBaseCS
{
	private BUC_TalentData TalentData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBPC_RoleBaseData RoleBaseData;

	private bool CanCheckLegacyBan = true;

	private bool CanTriggerLegacyReactivate;

	private bool HasInit;

	public override void OnAttach()
	{
		TalentData = RequireWritableData<BUC_TalentData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		RoleBaseData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>((GetOwner() as APawn)?.PlayerState);
		base.BUSEventCollection.Evt_ActivateTalent += new Del_ActivateTalent(OnActivateTalent);
		base.BUSEventCollection.Evt_DeactivateTalent += new Del_Void_Int(OnDeactivateTalent);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnAfterUnitRebirth);
		base.BUSEventCollection.Evt_PlayerResetRecoverTalent += new Del_Void(OnPlayerResetRecoverTalent);
		base.BUSEventCollection.Evt_TriggerSwitchMagicConfInfo += new Del_SwitchMagicConfInfo(OnTriggerSwitchMagicConfInfo);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_OpenLevelFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_OpenLevelFinished, new Del_Void(OnOpenLevelFinished));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_OpenLevelFinished = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_OpenLevelFinished, new Del_Void(OnOpenLevelFinished));
	}

	public override int GetTickGroupMask()
	{
		return 64;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!HasInit)
		{
			HasInit = true;
			if (RoleBaseData != null)
			{
				foreach (KeyValuePair<int, int> talen in RoleBaseData.TalenList)
				{
					OnActivateTalent(talen.Key, talen.Value);
				}
			}
			InitBossRushDebuffTalent();
			BUS_BGUDataCompBase componentByClass = GetOwner().GetComponentByClass<BUS_BGUDataCompBase>();
			if (componentByClass != null && componentByClass.DataInitTemplate != null)
			{
				List<ECSDataInitTemplate> dataInitTemplate = componentByClass.DataInitTemplate;
				if (dataInitTemplate != null)
				{
					foreach (ECSDataInitTemplate item in dataInitTemplate)
					{
						(item as PlayerWukongAttrDataInit)?.SetAttrTransAfterActiveTalent();
					}
				}
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BanLegacyTalent))
		{
			if (!CanCheckLegacyBan)
			{
				return;
			}
			CanCheckLegacyBan = false;
			CanTriggerLegacyReactivate = true;
			if (RoleBaseData == null)
			{
				return;
			}
			int actorResID = GetActorResID();
			{
				foreach (KeyValuePair<int, int> talen2 in RoleBaseData.TalenList)
				{
					int key = talen2.Key;
					TalentSDesc talentSDescByUnitResIDInMapCache = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(key, actorResID);
					if (talentSDescByUnitResIDInMapCache != null && talentSDescByUnitResIDInMapCache.Type == TalentType.Legacy)
					{
						OnDeactivateTalent(key);
					}
				}
				return;
			}
		}
		if (!CanTriggerLegacyReactivate)
		{
			return;
		}
		CanCheckLegacyBan = true;
		CanTriggerLegacyReactivate = false;
		if (RoleBaseData == null)
		{
			return;
		}
		int actorResID2 = GetActorResID();
		foreach (KeyValuePair<int, int> talen3 in RoleBaseData.TalenList)
		{
			int key2 = talen3.Key;
			int value = talen3.Value;
			TalentSDesc talentSDescByUnitResIDInMapCache2 = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(key2, actorResID2);
			if (talentSDescByUnitResIDInMapCache2 != null && talentSDescByUnitResIDInMapCache2.Type == TalentType.Legacy)
			{
				OnDeactivateTalent(key2);
				OnActivateTalent(key2, value);
			}
		}
	}

	private void InitTalentInfo()
	{
		HasInit = false;
		CanCheckLegacyBan = true;
		CanTriggerLegacyReactivate = false;
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		APawn aPawn = owner as APawn;
		if (aPawn == null || !aPawn.IsPlayerControlled())
		{
			return;
		}
		if (RoleBaseData != null)
		{
			foreach (KeyValuePair<int, int> talen in RoleBaseData.TalenList)
			{
				OnDeactivateTalent(talen.Key);
				OnActivateTalent(talen.Key, talen.Value);
			}
		}
		InitBossRushDebuffTalent();
	}

	private void InitBossRushDebuffTalent()
	{
		IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(Owner);
		if ((gameInstanceReadonlyData == null || gameInstanceReadonlyData.BossRushType != EBossRushType.BossIterations) && gameInstanceReadonlyData.BossRushType != EBossRushType.IterationsPractise)
		{
			return;
		}
		foreach (int debuff in gameInstanceReadonlyData.BossRushBattleData.DebuffList)
		{
			BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
			if (bossRushDebuffDesc == null)
			{
				continue;
			}
			List<int> bossRushTalentIDList = BGW_GameDB.GetBossRushTalentIDList(bossRushDebuffDesc.DebuffId);
			if (bossRushTalentIDList == null)
			{
				continue;
			}
			foreach (int item in bossRushTalentIDList)
			{
				OnDeactivateTalent(item);
				OnActivateTalent(item, 1);
			}
		}
	}

	private void OnActivateTalent(int TalentID, int ChangeLevel)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		int actorResID = GetActorResID();
		TalentSDesc talentSDescByUnitResIDInMapCache = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(TalentID, actorResID);
		if (talentSDescByUnitResIDInMapCache == null)
		{
			return;
		}
		if (GameDBRuntime.IsSpellOnlyTalent(TalentID, out var SpellId))
		{
			bool flag = false;
			IBUC_PlayerSpellConfData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(Owner);
			if (readOnlyData != null)
			{
				foreach (FUStMagicConfInfo item in readOnlyData.MagicConfInfo)
				{
					if (item.SpellID == SpellId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return;
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BanLegacyTalent) && talentSDescByUnitResIDInMapCache.Type == TalentType.Legacy)
		{
			return;
		}
		int maxLevel = talentSDescByUnitResIDInMapCache.MaxLevel;
		int num = 1;
		if (RoleBaseData != null)
		{
			num = RoleBaseData.RoleLevel;
		}
		string[] array = talentSDescByUnitResIDInMapCache.PassiveSkillIDs.Split(',');
		string[] array2 = talentSDescByUnitResIDInMapCache.AddBuffIDs.Split(',');
		if (TalentData.ActivatingTalentDic.TryGetValue(TalentID, out var value))
		{
			int val = ChangeLevel;
			val = Math.Max(0, Math.Min(val, maxLevel));
			string[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				if (int.TryParse(array3[i], out var result))
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(result, EBuffEffectTriggerType.None, 1);
				}
			}
			if (val <= 0)
			{
				array3 = array;
				for (int i = 0; i < array3.Length; i++)
				{
					if (int.TryParse(array3[i], out var result2))
					{
						Dictionary<int, FUStPassiveSkillDesc> passiveSkillDescDic = BGW_GameDB.GetPassiveSkillDescDic(result2);
						if (passiveSkillDescDic != null && passiveSkillDescDic.Count > 0)
						{
							base.BUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(result2, value, bRecover: true, num);
						}
					}
				}
				TalentData.ActivatingTalentDic.Remove(TalentID);
			}
			else
			{
				array3 = array;
				for (int i = 0; i < array3.Length; i++)
				{
					if (int.TryParse(array3[i], out var result3))
					{
						Dictionary<int, FUStPassiveSkillDesc> passiveSkillDescDic2 = BGW_GameDB.GetPassiveSkillDescDic(result3);
						if (passiveSkillDescDic2 != null && passiveSkillDescDic2.Count > 0)
						{
							int passiveSkillMappingIndexID = Math.Max(1, Math.Min(passiveSkillDescDic2.Count, val));
							base.BUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(result3, value, bRecover: true, num);
							base.BUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(result3, passiveSkillMappingIndexID, bRecover: false, num);
						}
					}
				}
				array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					if (int.TryParse(array3[i], out var result4))
					{
						base.BUSEventCollection.Evt_BuffAdd.Invoke(result4, Owner, Owner, -1f, EBuffSourceType.Talent);
					}
				}
				TalentData.ActivatingTalentDic[TalentID] = val;
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.Talent, $"<character>{owner.GetName()}</><action>，当前角色等级 = </><effect>{num}</><action>，修改现有天赋等级，天赋ID = </><effect>{TalentID}</><action>, 旧天赋等级 = </><effect>{value}</><action>, 新天赋等级 = </><effect>{val}</>");
			}
		}
		else
		{
			int val2 = ChangeLevel;
			val2 = Math.Max(0, Math.Min(val2, maxLevel));
			if (val2 > 0)
			{
				string[] array3 = array;
				for (int i = 0; i < array3.Length; i++)
				{
					if (int.TryParse(array3[i], out var result5))
					{
						Dictionary<int, FUStPassiveSkillDesc> passiveSkillDescDic3 = BGW_GameDB.GetPassiveSkillDescDic(result5);
						if (passiveSkillDescDic3 != null && passiveSkillDescDic3.Count > 0)
						{
							int passiveSkillMappingIndexID2 = Math.Max(1, Math.Min(passiveSkillDescDic3.Count, val2));
							base.BUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(result5, passiveSkillMappingIndexID2, bRecover: false, num);
						}
					}
				}
				array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					if (int.TryParse(array3[i], out var result6))
					{
						base.BUSEventCollection.Evt_BuffAdd.Invoke(result6, Owner, Owner, -1f, EBuffSourceType.Talent);
					}
				}
				TalentData.ActivatingTalentDic.Add(TalentID, val2);
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.Talent, $"<character>{owner.GetName()}</><action>，当前角色等级 = </><effect>{num}</><action>，新添加天赋，天赋ID = </><effect>{TalentID}</><action>, 天赋等级 = </><effect>{ChangeLevel}</>");
				}
			}
		}
		base.BGWEventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload(ECSExtension.ToEntity(Owner), EPreloadPlayerAbilityType.Talent);
	}

	private void OnDeactivateTalent(int TalentID)
	{
		if (GetOwner() == null)
		{
			return;
		}
		int actorResID = GetActorResID();
		TalentSDesc talentSDescByUnitResIDInMapCache = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(TalentID, actorResID);
		if (talentSDescByUnitResIDInMapCache == null)
		{
			return;
		}
		string[] array = talentSDescByUnitResIDInMapCache.AddBuffIDs.Split(',');
		string[] array2 = talentSDescByUnitResIDInMapCache.PassiveSkillIDs.Split(',');
		if (!TalentData.ActivatingTalentDic.TryGetValue(TalentID, out var value))
		{
			return;
		}
		string[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			if (int.TryParse(array3[i], out var result))
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(result, EBuffEffectTriggerType.None, 1);
			}
		}
		int level = 1;
		if (RoleBaseData != null)
		{
			level = RoleBaseData.RoleLevel;
		}
		array3 = array2;
		for (int i = 0; i < array3.Length; i++)
		{
			if (int.TryParse(array3[i], out var result2))
			{
				Dictionary<int, FUStPassiveSkillDesc> passiveSkillDescDic = BGW_GameDB.GetPassiveSkillDescDic(result2);
				if (passiveSkillDescDic != null && passiveSkillDescDic.Count > 0)
				{
					base.BUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(result2, value, bRecover: true, level);
				}
			}
		}
		TalentData.ActivatingTalentDic.Remove(TalentID);
	}

	private void OnAfterUnitRebirth(ERebirthType RebirthType)
	{
		InitTalentInfo();
	}

	private void OnOpenLevelFinished()
	{
		InitTalentInfo();
	}

	private void OnPlayerResetRecoverTalent()
	{
		InitTalentInfo();
	}

	private void OnTriggerSwitchMagicConfInfo(SpellType SpellType, int NewSpellId, int OldSpellId)
	{
		if (RoleBaseData == null)
		{
			return;
		}
		foreach (KeyValuePair<int, int> talen in RoleBaseData.TalenList)
		{
			int key = talen.Key;
			if (GameDBRuntime.IsSpellOnlyTalent(key, out var SpellId) && SpellId == OldSpellId)
			{
				OnDeactivateTalent(key);
			}
		}
		foreach (KeyValuePair<int, int> talen2 in RoleBaseData.TalenList)
		{
			int key2 = talen2.Key;
			int value = talen2.Value;
			if (GameDBRuntime.IsSpellOnlyTalent(key2, out var SpellId2) && SpellId2 == NewSpellId)
			{
				OnActivateTalent(key2, value);
			}
		}
	}
}
