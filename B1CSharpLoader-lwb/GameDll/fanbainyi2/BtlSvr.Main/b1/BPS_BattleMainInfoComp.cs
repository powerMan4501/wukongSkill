using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_BattleMainInfoComp : PlayerControllerSystemBase
{
	private static List<int> BuffTickRuleBySimpleStateIDList = new List<int>();

	private BPC_BattleMainInfoData BattleMainInfoData { get; set; }

	private IBPC_PlayerInteractData PlayerInteractData { get; set; }

	private IBGC_MovieData MovieData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_SkillMappingData SkillMappingData { get; set; }

	private IBUC_ConfigInfoData ConfigInfoData { get; set; }

	private IBPC_PlayerRoleData PlayerRoleData { get; set; }

	private IBUC_AttrContainer AttrContainer { get; set; }

	private IBPC_PlayerTagData PlayerTagData { get; set; }

	private BGW_EffectTemplateList EffectTemplateList { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		BattleMainInfoData = RequireWritableData<BPC_BattleMainInfoData>();
		BPC_BattleMainInfoData battleMainInfoData = BattleMainInfoData;
		battleMainInfoData.Del_TickforState = (Del_Void)Delegate.Combine(battleMainInfoData.Del_TickforState, new Del_Void(TickCanOpenEquipAndMapPage));
		BPC_BattleMainInfoData battleMainInfoData2 = BattleMainInfoData;
		battleMainInfoData2.Del_TickforState = (Del_Void)Delegate.Combine(battleMainInfoData2.Del_TickforState, new Del_Void(TickForceCloseEquipAndMapPage));
		BPC_BattleMainInfoData battleMainInfoData3 = BattleMainInfoData;
		battleMainInfoData3.Del_UpdateOpenTakePhotoPageInfo = (Del_Void)Delegate.Combine(battleMainInfoData3.Del_UpdateOpenTakePhotoPageInfo, new Del_Void(UpdateCanOpenTakePhotoPage));
		PlayerInteractData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerInteractData, BPC_PlayerInteractData>();
		PlayerRoleData = RequireReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		MovieData = RequireReadOnlyGameStateData<IBGC_MovieData, BGC_MovieData>();
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(Owner);
		if (local != null)
		{
			local.Evt_SetBossBar += new Del_SetBossBar(OnSetBossBar);
			local.Evt_SetEilteBar += new Del_SetBossBar(OnSetEilteBar);
			local.Evt_UpdateHPPercent += new Del_SetBossBar(OnUpdateHPPercent);
			local.Evt_BPS_UnitRebirthFinished += new Del_Void(OnUnitRebirthFinished);
			local.Evt_BPS_UnitTriggerFallDying += new Del_Void(OnUnitTriggerFallDying);
			local.Evt_BPS_SetPlayerDeathUIDelayTime += new Del_Void_Float(OnSetPlayerDeathUIDelayTime);
			local.Evt_DefeatedStateChange += new Del_DefeatedStateChange(OnDefeatedStateChange);
			local.Evt_TryRemoveBossBarInfo += new Del_Void_String(OnTryRemoveBossBarInfo);
			local.Evt_TryRemoveEliteBarInfo += new Del_Void_String(OnTryRemoveEliteBarInfo);
		}
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnPossessed);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_OnUnitTransited -= new Del_BGS_OnUnitTransited(OnPossessed);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		if (BattleMainInfoData != null)
		{
			foreach (KeyValuePair<int, FUStTransActiveStateDesc> item in BGW_GameDB.GetAllFUStTransActiveStateDesc())
			{
				TransStateInfo value = new TransStateInfo
				{
					BuffOneID = item.Value.StateOneBuffID,
					BuffTwoID = item.Value.StateTwoBuffID,
					BuffThreeID = item.Value.StateThreeBuffID
				};
				BattleMainInfoData.TransStateMappingBuffConfig.Add(item.Key, value);
			}
		}
		EffectTemplateList = BGW_EffectTemplateList.Get(Owner);
		BGUCharacterCS bGUCharacterCS = (GetOwner() as BGP_PlayerControllerB1)?.GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			UpdateData(bGUCharacterCS);
		}
	}

	private void OnUnitTriggerFallDying()
	{
		BattleMainInfoData.ForceCloseEquipPage.SetValue(EChangeReason.InnerOp, value: true);
		BattleMainInfoData.ForceCloseMapPage.SetValue(EChangeReason.InnerOp, value: true);
	}

	private void OnUnitRebirthFinished()
	{
		BattleMainInfoData.ForceCloseEquipPage.SetValue(EChangeReason.InnerOp, value: true);
		BattleMainInfoData.ForceCloseMapPage.SetValue(EChangeReason.InnerOp, value: true);
	}

	private void OnDefeatedStateChange(int ExtendID, EDefeatUITriggerType DefeatUITriggerType)
	{
		BattleMainInfoData.ExtendIDForDefeatedUI = ExtendID;
		BattleMainInfoData.DefeatUITriggerType = DefeatUITriggerType;
		BattleMainInfoData.KillSlowDownState.SetValue(EChangeReason.InnerOp, value: true);
		BattleMainInfoData.KillSlowDownState.SetValue(EChangeReason.InnerOp, value: false);
	}

	private void OnTryRemoveBossBarInfo(string BossGUID)
	{
		foreach (UnitBarInfo item in BattleMainInfoData.BossBarInfo)
		{
			if (item.UnitGuid == BossGUID)
			{
				BattleMainInfoData.BossBarInfo.Remove(item);
				break;
			}
		}
	}

	private void OnTryRemoveEliteBarInfo(string EliteGUID)
	{
		foreach (UnitBarInfo item in BattleMainInfoData.EliteBarInfo)
		{
			if (item.UnitGuid == EliteGUID)
			{
				BattleMainInfoData.EliteBarInfo.Remove(item);
				break;
			}
		}
	}

	private void OnSetPlayerDeathUIDelayTime(float NewPlayerDeathUIDelayTime)
	{
		BattleMainInfoData.PlayerDeathUIDelayTime = NewPlayerDeathUIDelayTime;
	}

	private void OnPossessed(AActor OldActor, AActor CurActor)
	{
		if (CurActor != null && CurActor as BGUCharacterCS != null)
		{
			UpdateData(CurActor as BGUCharacterCS);
		}
	}

	private void UpdateData(BGUCharacterCS Chr)
	{
		if (Chr != null)
		{
			SimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Chr);
			UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Chr);
			SkillMappingData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>(Chr);
			AttrContainer = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Chr);
			PlayerTagData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(Chr.PlayerState);
			ConfigInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(Chr);
			BattleMainInfoData.BattleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(Chr);
			BattleMainInfoData.SimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Chr);
			BattleMainInfoData.UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Chr);
			BattleMainInfoData.MagicSpellInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_MagicSpellInfoData, BUC_MagicSpellInfoData>(Chr);
			BattleMainInfoData.CloudMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(Chr);
			BattleMainInfoData.EquipFaBaoData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_EquipFaBaoData, BUC_EquipFaBaoData>(Chr);
			BattleMainInfoData.SealingSpellData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SealingSpellData, BUC_SealingSpellData>(Chr);
			BattleMainInfoData.PlayerPerformData = BGU_DataUtil.GetPlayerStateReadonlyData<IBPC_PlayerPerformData, BPC_PlayerPerformData>(Chr.GetController() as APlayerController);
			BattleMainInfoData.OwnerCharacter = Chr;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Chr);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BuffInstsDictOnAdd += new Del_BuffInstsDictOnAdd(BuffInstsDictOnAdd);
				bUS_GSEventCollection.Evt_BuffInstsDictOnRemove += new Del_Void_Int(OnBuffInstsDictOnRemove);
				bUS_GSEventCollection.Evt_ShouledUpdateBuffTime += new Del_Void_Bool(OnShouledUpdateBuffTime);
				bUS_GSEventCollection.Evt_OnBuffLayerChangedNotify += new Del_OnBuffLayerChangedNotify(OnBuffLayerChanged);
				bUS_GSEventCollection.Evt_OnSkillMinAttrCostBase1Changed += new Del_PassiveSkill1IDFloatParamChanged(SkillMinAttrCost);
				bUS_GSEventCollection.Evt_OnSkillMinAttrCostBase2Changed += new Del_PassiveSkill1IDFloatParamChanged(SkillMinAttrCost);
			}
			if (BattleMainInfoData != null)
			{
				BattleMainInfoData.BattleMainBuffInstDic.OnAdd += OnBuffAdd;
				GSBindDictionary<int, BuffInstData> battleMainBuffInstDic = BattleMainInfoData.BattleMainBuffInstDic;
				battleMainBuffInstDic.OnRemove = (Action<int, BuffInstData>)Delegate.Combine(battleMainBuffInstDic.OnRemove, new Action<int, BuffInstData>(OnBuffRemove));
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GSGameplayCVar.CVar_DebugBuffHud.GetValueInGameThread() != 0)
		{
			foreach (int buffIcon in BattleMainInfoData.BuffIconList)
			{
				_ = buffIcon;
			}
		}
		if (UnitStateData != null)
		{
			TickCanOpenEquipAndMapPage();
			TickForceCloseEquipAndMapPage();
			TickBuffInstsLeftTime(DeltaTime);
			TickSpellInfo();
			TickVigorSkillCD();
		}
	}

	private void SkillMinAttrCost(int MainID, float OldVal, float NewVal)
	{
		TickSpellInfo();
	}

	private void TickCanOpenEquipAndMapPage()
	{
		bool flag = !UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.Beatback) && !UnitStateData.HasState(EBGUUnitState.Dead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_Rebirth) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !PlayerInteractData.IsInInteraction() && !MovieData.IsPlaying() && !DebugConfig.OnlyOpenPVUI;
		bool value = flag && BGUFuncLibMap.IsSupportOpenMap(Owner);
		BattleMainInfoData.CanOpenEquipPage.SetValue(EChangeReason.InnerOp, flag);
		BattleMainInfoData.CanOpenMapPage.SetValue(EChangeReason.InnerOp, value);
	}

	private void TickForceCloseEquipAndMapPage()
	{
		bool value = UnitStateData.HasState(EBGUUnitState.Beatback) || UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing);
		BattleMainInfoData.ForceCloseEquipPage.SetValue(EChangeReason.InnerOp, value);
		BattleMainInfoData.ForceCloseMapPage.SetValue(EChangeReason.InnerOp, value);
	}

	private void UpdateCanOpenTakePhotoPage()
	{
		bool flag = !UnitStateData.HasState(EBGUUnitState.Dead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_Rebirth) && !PlayerInteractData.IsInInteraction() && !MovieData.IsPlaying() && !MovieData.IsPlayingDefeatSlowTime() && !SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreAllInput) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !DebugConfig.OnlyOpenPVUI;
		if (flag)
		{
			BGUCharacterCS bGUCharacterCS = (GetOwner() as BGP_PlayerControllerB1)?.GetControlledPawn() as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				BattleMainInfoData.CanOpenTakePhotoPage.SetValue(EChangeReason.InnerOp, value: false);
				return;
			}
			if (PlayerTagData != null && PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				int resID = bGUCharacterCS.GetResID();
				if (resID == 11 || resID == 21)
				{
					BattleMainInfoData.CanOpenTakePhotoPage.SetValue(EChangeReason.InnerOp, value: false);
					return;
				}
			}
			UAnimMontage currentMontage = bGUCharacterCS.GetCurrentMontage();
			if (!currentMontage.IsNullOrDestroyed() && currentMontage.GetName() == "AM_Wukong_FuHuo")
			{
				BattleMainInfoData.CanOpenTakePhotoPage.SetValue(EChangeReason.InnerOp, value: false);
				return;
			}
		}
		BattleMainInfoData.CanOpenTakePhotoPage.SetValue(EChangeReason.InnerOp, flag);
	}

	private void TickBuffInstsLeftTime(float DeltaTime)
	{
		if (!BattleMainInfoData.bShouldUpdateBuffTime)
		{
			return;
		}
		BGUFunctionLibraryCS.GetBuffTickRuleBySimpleStateIDList(Owner, ref BuffTickRuleBySimpleStateIDList);
		BattleMainInfoData.BattleMainBuffInstDic.BeginItr();
		while (true)
		{
			BattleMainInfoData.BattleMainBuffInstDic.NextItr(out var output);
			if (output != null)
			{
				if (!BGUFunctionLibraryCS.IsNeedPauseBuffTick(output.BuffID, BuffTickRuleBySimpleStateIDList) && output.bActive && output.LeftTime > 0f)
				{
					output.LeftTime -= DeltaTime;
				}
				continue;
			}
			break;
		}
	}

	private void OnSetBossBar(AActor Actor, float Percent, bool IsAdd)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BloodHudDesc bloodHudDesc = GameDBRuntime.GetBloodHudDesc(bGUCharacterCS.GetResID());
		int num = 0;
		num = bloodHudDesc?.Priority ?? 1;
		bGUCharacterCS.GetActorGuid(out var Guid);
		if (IsAdd)
		{
			if (BattleMainInfoData.BossBarInfo.FindIndex((UnitBarInfo Info) => Info.UnitGuid == Guid) == -1)
			{
				BattleMainInfoData.BossBarInfo.Add(new UnitBarInfo(Guid, Percent, num));
				BattleMainInfoData.BossBarInfo.ValueList.Sort((UnitBarInfo Info, UnitBarInfo Info2) => Info.Priority.CompareTo(Info2.Priority));
			}
			return;
		}
		foreach (UnitBarInfo item in BattleMainInfoData.BossBarInfo)
		{
			if (item.UnitGuid == Guid)
			{
				BattleMainInfoData.BossBarInfo.Remove(item);
				break;
			}
		}
	}

	private void OnSetEilteBar(AActor Actor, float Percent, bool IsAdd)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BloodHudDesc bloodHudDesc = GameDBRuntime.GetBloodHudDesc(bGUCharacterCS.GetResID());
		int num = 0;
		num = bloodHudDesc?.Priority ?? 1;
		bGUCharacterCS.GetActorGuid(out var Guid);
		if (IsAdd)
		{
			if (BattleMainInfoData.EliteBarInfo.FindIndex((UnitBarInfo Info) => Info.UnitGuid == Guid) == -1)
			{
				BattleMainInfoData.EliteBarInfo.Add(new UnitBarInfo(Guid, Percent, num));
				BattleMainInfoData.EliteBarInfo.ValueList.Sort((UnitBarInfo Info, UnitBarInfo Info2) => Info.Priority.CompareTo(Info2.Priority));
			}
			return;
		}
		foreach (UnitBarInfo item in BattleMainInfoData.EliteBarInfo)
		{
			if (item.UnitGuid == Guid)
			{
				BattleMainInfoData.EliteBarInfo.Remove(item);
				break;
			}
		}
	}

	private void OnUpdateHPPercent(AActor Actor, float Percent, bool IsBoss)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		bGUCharacterCS.GetActorGuid(out var OutActorGuid);
		if (IsBoss)
		{
			foreach (UnitBarInfo item in BattleMainInfoData.BossBarInfo)
			{
				if (item.UnitGuid == OutActorGuid)
				{
					item.HPValue = Percent;
				}
			}
			return;
		}
		foreach (UnitBarInfo item2 in BattleMainInfoData.EliteBarInfo)
		{
			if (item2.UnitGuid == OutActorGuid)
			{
				item2.HPValue = Percent;
			}
		}
	}

	private void TickVigorSkillCD()
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergy);
		float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergyMax);
		BattleMainInfoData.VigorSkillCDPercent = 1f - ((floatValue2 > 1E-08f) ? (floatValue / floatValue2) : 0f);
	}

	private void OnBuffAdd(int BuffID, BuffInstData BuffInstData)
	{
		if (BuffInstData == null)
		{
			return;
		}
		FUStBuffIconDesc buffIconDesc = BGW_GameDB.GetBuffIconDesc(BuffID);
		if (buffIconDesc != null)
		{
			if (BattleMainInfoData.BuffIconInfo.ContainsKey(buffIconDesc.IconID))
			{
				BattleMainInfoData.BuffIconInfo[buffIconDesc.IconID].Add(BuffInstData);
				return;
			}
			List<BuffInstData> list = new List<BuffInstData>();
			list.Add(BuffInstData);
			BattleMainInfoData.BuffIconInfo.Add(buffIconDesc.IconID, list);
			BattleMainInfoData.BuffIconList.Add(buffIconDesc.IconID);
		}
	}

	private void OnBuffRemove(int BuffID, BuffInstData BuffInstData)
	{
		FUStBuffIconDesc buffIconDesc = BGW_GameDB.GetBuffIconDesc(BuffID);
		if (buffIconDesc != null && BattleMainInfoData.BuffIconInfo.ContainsKey(buffIconDesc.IconID))
		{
			BattleMainInfoData.BuffIconInfo[buffIconDesc.IconID].RemoveAll((BuffInstData Data) => Data.BuffID == BuffID);
			if (BattleMainInfoData.BuffIconInfo[buffIconDesc.IconID].Count == 0)
			{
				BattleMainInfoData.BuffIconInfo.Remove(buffIconDesc.IconID);
				BattleMainInfoData.BuffIconList.Remove(buffIconDesc.IconID);
			}
		}
	}

	private void OnBuffLayerChanged(int BuffID, int Layer_OldValue, int Layer_NewValue)
	{
		if (BattleMainInfoData.BattleMainBuffInstDic.ContainsKey(BuffID) && Layer_NewValue != 0)
		{
			BattleMainInfoData.BattleMainBuffInstDic[BuffID].LeftTime = BattleMainInfoData.BattleMainBuffInstDic[BuffID].Duration;
		}
	}

	private void OnShouledUpdateBuffTime(bool ShouledUpdateBuffTime)
	{
		BattleMainInfoData.bShouldUpdateBuffTime = ShouledUpdateBuffTime;
	}

	private void BuffInstsDictOnAdd(int BuffID, float Duration, EBuffSourceType BuffSourceType, AActor Caster)
	{
		if (BattleMainInfoData.TransStateMappingBuffConfig.ContainsKey(ConfigInfoData.ResID))
		{
			if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffOneID)
			{
				BattleMainInfoData.State1.SetValue(EChangeReason.InnerOp, value: true);
			}
			else if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffTwoID)
			{
				BattleMainInfoData.State2.SetValue(EChangeReason.InnerOp, value: true);
			}
			else if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffThreeID)
			{
				BattleMainInfoData.State3.SetValue(EChangeReason.InnerOp, value: true);
			}
		}
		if (BuffSourceType == EBuffSourceType.AbnormalState)
		{
			FUStAbnormalStateUIBlackListDesc abnormalStateUIBlackListDesc = BGW_GameDB.GetAbnormalStateUIBlackListDesc(BGU_DataUtil.GetActorResID(Caster));
			if (abnormalStateUIBlackListDesc != null)
			{
				EAbnormalStateType abnormalStateTypeByFinalBuffID = BGUAbnormalStateFuncLib.GetAbnormalStateTypeByFinalBuffID(BuffID);
				if (abnormalStateUIBlackListDesc.AbnormalStateTypes.Contains((int)abnormalStateTypeByFinalBuffID))
				{
					return;
				}
			}
		}
		BuffInstData buffInstData = new BuffInstData();
		buffInstData.bActive = true;
		buffInstData.BuffID = BuffID;
		buffInstData.DelayTime = 0f;
		buffInstData.LeftTime = Duration;
		buffInstData.Duration = Duration;
		buffInstData.UpdateTimer = 0f;
		if (!BattleMainInfoData.BattleMainBuffInstDic.ContainsKey(BuffID))
		{
			BattleMainInfoData.BattleMainBuffInstDic.Add(BuffID, buffInstData);
			return;
		}
		BattleMainInfoData.BattleMainBuffInstDic.Remove(BuffID);
		BattleMainInfoData.BattleMainBuffInstDic.Add(BuffID, buffInstData);
	}

	private void OnBuffInstsDictOnRemove(int BuffID)
	{
		if (BattleMainInfoData.TransStateMappingBuffConfig.ContainsKey(ConfigInfoData.ResID))
		{
			if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffOneID)
			{
				BattleMainInfoData.State1.SetValue(EChangeReason.InnerOp, value: false);
			}
			else if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffTwoID)
			{
				BattleMainInfoData.State2.SetValue(EChangeReason.InnerOp, value: false);
			}
			else if (BuffID == BattleMainInfoData.TransStateMappingBuffConfig[ConfigInfoData.ResID].BuffThreeID)
			{
				BattleMainInfoData.State3.SetValue(EChangeReason.InnerOp, value: false);
			}
		}
		BattleMainInfoData.BattleMainBuffInstDic.Remove(BuffID);
	}

	private void TickSpellInfo()
	{
		BattleMainInfoData.SpellStateList.Clear();
		if (PlayerRoleData == null || EffectTemplateList == null)
		{
			return;
		}
		foreach (int spell in PlayerRoleData.RoleData.RoleCs.Actor.Progress.SpellList)
		{
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(spell);
			if (spellDesc == null)
			{
				continue;
			}
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillMappingData.GetCurResultSkillID(spellDesc.SkillId), GetControlledPlayerCharacter());
			if (skillSDesc != null)
			{
				BGUSpellState bGUSpellState = new BGUSpellState
				{
					SpellID = spell
				};
				BUAttrCostTemplate attrCostTemplate = EffectTemplateList.GetAttrCostTemplate(skillSDesc.MinAttrCostType1);
				if (attrCostTemplate != null)
				{
					(int, float) costValue = attrCostTemplate.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase1, skillSDesc.MinAttrCostRatio1);
					bGUSpellState.CostValue1 = ((costValue.Item1 != 0) ? ((float)costValue.Item1) : costValue.Item2);
				}
				BUAttrCostTemplate attrCostTemplate2 = EffectTemplateList.GetAttrCostTemplate(skillSDesc.MinAttrCostType2);
				if (attrCostTemplate2 != null)
				{
					(int, float) costValue2 = attrCostTemplate2.GetCostValue(AttrContainer, skillSDesc.MinAttrCostBase2, skillSDesc.MinAttrCostRatio2);
					bGUSpellState.CostValue2 = ((costValue2.Item1 != 0) ? ((float)costValue2.Item1) : costValue2.Item2);
				}
				BattleMainInfoData.SpellStateList.Add(bGUSpellState);
			}
		}
	}
}
