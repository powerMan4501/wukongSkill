using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_OSSTriggerComp : UActorCompBaseCS
{
	private struct GPEvent
	{
		public bool bInGPSkill;

		public int PELevelBeforeGP;

		public bool bInFight;

		public bool bSuccess;

		public void Clear()
		{
			bInGPSkill = false;
			PELevelBeforeGP = 0;
			bInFight = false;
			bSuccess = false;
		}
	}

	private BGW_EventCollection BGWE;

	private IBUC_PlayerSpellConfData PlayerSpellConfData;

	private bool bEventBinded;

	private BUC_OSSCollectData OSSCollectData;

	private IBPC_PlayerRoleData PlayerRoleData;

	private IBPC_RoleBaseData PlayerBaseRoleData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_PlayerTransData PlayerTransData;

	private const int SkillID_GP = 10705;

	private const int BuffID_GPSuccess = 288;

	private GPEvent _GPEvent;

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	private void OnAttachBossRush()
	{
		PlayerSpellConfData = RequireReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>();
		BGWE = BGW_EventCollection.Get(Owner);
		if (BGWE != null)
		{
			BGW_EventCollection bGWE = BGWE;
			bGWE.Evt_BeginBossRushBattle = (Del_Void)Delegate.Combine(bGWE.Evt_BeginBossRushBattle, new Del_Void(BossRushBegin));
			BGW_EventCollection bGWE2 = BGWE;
			bGWE2.Evt_EndBossRushBattle = (Del_Void)Delegate.Combine(bGWE2.Evt_EndBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE3 = BGWE;
			bGWE3.Evt_FinishBossRushBattle = (Del_Void)Delegate.Combine(bGWE3.Evt_FinishBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE4 = BGWE;
			bGWE4.Evt_FailedBossRushBattle = (Del_Void)Delegate.Combine(bGWE4.Evt_FailedBossRushBattle, new Del_Void(BossRushEnd));
		}
		if (B1Global.GIsBossRushMode)
		{
			BossRushBegin();
		}
	}

	private void BossRushBegin()
	{
		if (!bEventBinded)
		{
			bEventBinded = true;
			BindBossRushEvent();
		}
	}

	private void BossRushEnd()
	{
		if (bEventBinded)
		{
			bEventBinded = false;
			UnBindBossRushEvent();
		}
	}

	private void BindBossRushEvent()
	{
		if (!Owner.IsNullOrDestroyed() && !(base.BUSEventCollection == null))
		{
			base.BUSEventCollection.Evt_OnPreciseDodgeSuccess += new Del_Void(OnPreciseDodgeSuccess);
			base.BUSEventCollection.Evt_AddBuffNotify += new Del_AddBuffNotify(OnGPSuccess_BossRush);
			base.BUSEventCollection.Evt_OnTriggerHuluEffectSuccess += new Del_Void(OnTriggerHuluEffectSuccess);
			base.BUSEventCollection.Evt_OnUseItemSuccess += new Del_Void(OnUseItemSuccess);
			base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnSkillCastSuccess);
			base.BUSEventCollection.Evt_UpdateOSSDefenceData += new Del_OSSBattle(OnPlayerBeHurted_BossRush);
			base.BUSEventCollection.Evt_OnCastLifeSavingSuccess += new Del_Void(OnCastLifeSavingSuccess);
			base.BUSEventCollection.Evt_UnitCastFaBaoSkillSucceed += new Del_Void(OnUseFaBaoSuccess);
		}
	}

	private void UnBindBossRushEvent()
	{
		if (!Owner.IsNullOrDestroyed() && !(base.BUSEventCollection == null))
		{
			base.BUSEventCollection.Evt_OnPreciseDodgeSuccess -= new Del_Void(OnPreciseDodgeSuccess);
			base.BUSEventCollection.Evt_AddBuffNotify -= new Del_AddBuffNotify(OnGPSuccess_BossRush);
			base.BUSEventCollection.Evt_OnTriggerHuluEffectSuccess -= new Del_Void(OnTriggerHuluEffectSuccess);
			base.BUSEventCollection.Evt_OnUseItemSuccess -= new Del_Void(OnUseItemSuccess);
			base.BUSEventCollection.Evt_UnitCastSkillSuccess -= new Del_UnitCastSkillSuccess(OnSkillCastSuccess);
			base.BUSEventCollection.Evt_UpdateOSSDefenceData -= new Del_OSSBattle(OnPlayerBeHurted_BossRush);
			base.BUSEventCollection.Evt_OnCastLifeSavingSuccess -= new Del_Void(OnCastLifeSavingSuccess);
			base.BUSEventCollection.Evt_UnitCastFaBaoSkillSucceed -= new Del_Void(OnUseFaBaoSuccess);
		}
	}

	private void OnEndPlayBossRush(EEndPlayReason EndPlayReason)
	{
		if (BGWE != null)
		{
			BGW_EventCollection bGWE = BGWE;
			bGWE.Evt_BeginBossRushBattle = (Del_Void)Delegate.Remove(bGWE.Evt_BeginBossRushBattle, new Del_Void(BossRushBegin));
			BGW_EventCollection bGWE2 = BGWE;
			bGWE2.Evt_EndBossRushBattle = (Del_Void)Delegate.Remove(bGWE2.Evt_EndBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE3 = BGWE;
			bGWE3.Evt_FinishBossRushBattle = (Del_Void)Delegate.Remove(bGWE3.Evt_FinishBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE4 = BGWE;
			bGWE4.Evt_FailedBossRushBattle = (Del_Void)Delegate.Remove(bGWE4.Evt_FailedBossRushBattle, new Del_Void(BossRushEnd));
		}
	}

	private void OnSkillCastSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (OriSkillID == 10834 || OriSkillID == 10864 || OriSkillID == 10885 || OriSkillID == 10890 || OriSkillID == 10609 || OriSkillID == 50023 || OriSkillID == 50024 || OriSkillID == 50038 || OriSkillID == 10829)
		{
			BGWE?.Evt_BBC_OnFourPEAtkSuccess();
			return;
		}
		if (SourceType == ECastSkillSourceType.MagicallyChange)
		{
			BGWE?.Evt_BBC_OnVigorSkillCastSuccess(OriSkillID, MappingSkillID);
			return;
		}
		foreach (FUStMagicConfInfo item in PlayerSpellConfData.MagicConfInfo)
		{
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(item.SpellID);
			if (spellDesc != null && spellDesc.SkillId == OriSkillID && (item.Type == SpellType.QiShu || item.Type == SpellType.HaoMao || item.Type == SpellType.ShenFa || item.Type == SpellType.BianShen))
			{
				BGWE?.Evt_BBC_OnUseSkillByTypeSuccess(item.SpellID);
				break;
			}
		}
	}

	private void OnGPSuccess_BossRush(bool IsHasBuffBefore, AActor Caster, int BuffID, float BuffDuration)
	{
		if (BuffID == 288)
		{
			BGWE?.Evt_BBC_OnGPSuccess();
		}
	}

	private void OnPreciseDodgeSuccess()
	{
		BGWE?.Evt_BBC_OnPreciseDodgeSuccess();
	}

	private void OnUseFaBaoSuccess()
	{
		BGWE?.Evt_BBC_OnUseFaBaoSuccess();
	}

	private void OnPlayerBeHurted_BossRush(int SkillId, AActor Attacker, int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		BGWE?.Evt_BBC_OnPlayerBeHurted(DamageValue);
	}

	private void OnCastLifeSavingSuccess()
	{
		BGWE?.Evt_BBC_OnCastLifeSavingSuccess();
	}

	private void OnTriggerHuluEffectSuccess()
	{
		BGWE?.Evt_BBC_OnTriggerHuluEffectSuccess();
	}

	private void OnUseItemSuccess()
	{
		BGWE?.Evt_BBC_OnUseItemSuccess();
	}

	private void OnAttachSZ()
	{
		BPSEventCollection = BPS_EventCollectionCS.Get((Owner as ABGUCharacter)?.PlayerState);
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_SetOSSItemChangeData += new Del_OSSItemChange(OnSetOSSItemChangeData);
		}
	}

	public void OnEndPlaySZ(EEndPlayReason EndPlayReason)
	{
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_SetOSSItemChangeData -= new Del_OSSItemChange(OnSetOSSItemChangeData);
		}
	}

	private void OnSetOSSItemChangeData(int ItemID, int Num, OPReason OpReason)
	{
		if (OpReason != OPReason.PlayerCostItem || !OSSCollectData.IsFight || OSSCollectData.BattlePlayerData == null)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < OSSCollectData.BattlePlayerData.ItemUse.Count; i++)
		{
			if (OSSCollectData.BattlePlayerData.ItemUse[i].Id == ItemID)
			{
				flag = true;
				OSSCollectData.BattlePlayerData.ItemUse[i].Num += Num;
			}
		}
		if (!flag)
		{
			Item item = new Item();
			item.Id = ItemID;
			item.Num = Num;
			OSSCollectData.BattlePlayerData.ItemUse.Add(item);
		}
	}

	public override void OnAttach()
	{
		OSSCollectData = RequireWritableData<BUC_OSSCollectData>();
		PlayerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		PlayerBaseRoleData = RequireReadOnlyLocalPlayerStateData<IBPC_RoleBaseData, BPC_RoleBaseData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PlayerTransData = RequireReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>();
		OSSCollectData.BeginFightTime = -1;
		OSSCollectData.IsFight = false;
		OSSCollectData.BattlePlayerData = new BattlePlayer();
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnOSSCollectBattleData_Player);
		base.BUSEventCollection.Evt_NotifyUnitTrans_BeforePosses += new Del_Evt_NotifyUnitTrans_BeforePosses(UnitTrans_BeforePosses);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnGPStart);
		base.BUSEventCollection.Evt_OnSkillEnd += new Del_Void_Int(OnGPEnded);
		base.BUSEventCollection.Evt_AddBuffNotify += new Del_AddBuffNotify(CheckGPSuccess);
		if (IsTransUnit())
		{
			OSSCollectData.PlayerTransEvent = new ReportEventPlayerTransEvent();
			OSSCollectData.StartTime_PlayerTrans = PlayerRoleData.GetGameTotalTime();
		}
		OnAttachSZ();
		OnAttachBossRush();
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (DeadReason == EDeadReason.PlayerTrans)
		{
			return;
		}
		ReportEventPlayerDie reportEventPlayerDie = new ReportEventPlayerDie();
		reportEventPlayerDie.RoleId = PlayerBaseRoleData.RoleId;
		reportEventPlayerDie.Player = BGUFuncLibPlayer.GetPlayerInfoData(Owner);
		reportEventPlayerDie.Player.Battle.ResId = BGU_DataUtil.GetActorResID(Owner);
		switch (DeadReason)
		{
		case EDeadReason.SkillDamage:
		{
			int unitId = -1;
			int extendId = -1;
			BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				BGUProjectileBaseActor bGUProjectileBaseActor = Attacker as BGUProjectileBaseActor;
				if (bGUProjectileBaseActor != null)
				{
					BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
					if (readOnlyData != null)
					{
						bGUCharacterCS = readOnlyData.GetMasterActor() as BGUCharacterCS;
					}
				}
			}
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				unitId = BGU_DataUtil.GetActorResID(bGUCharacterCS);
				extendId = bGUCharacterCS.GetFinalBattleInfoExtendID();
			}
			reportEventPlayerDie.Type = DieType.Killed;
			reportEventPlayerDie.UnitId = unitId;
			reportEventPlayerDie.ExtendId = extendId;
			reportEventPlayerDie.DmgId = DmgID;
			reportEventPlayerDie.DmgType = DamageType.Skill;
			break;
		}
		case EDeadReason.DeadZone:
		case EDeadReason.FallDead:
			reportEventPlayerDie.Type = DieType.Fall;
			break;
		}
		base.BGSEventCollection.Evt_BGS_LocalPlayerDead_ForOSS.Invoke();
		EventReporter.GetInstance(Owner).PlayerDie(reportEventPlayerDie);
		if (OSSCollectData.IsFight)
		{
			OnOSSCollectBattleData_Player(IsFight: false);
		}
	}

	private void OnOSSCollectBattleData_Player(bool IsFight)
	{
		OnOSSCollectBattleData_Player_Wrap(IsFight);
	}

	private void OnOSSCollectBattleData_Player_Wrap(bool IsFight, bool BecauseOfTrans = false)
	{
		if (OSSCollectData.IsFight == IsFight)
		{
			return;
		}
		if (IsFight)
		{
			OSSCollectData.BattlePlayerData = new BattlePlayer();
			OSSCollectData.BeginFightTime = PlayerRoleData.GetGameTotalTime();
			base.BGSEventCollection.Evt_BGS_OnPlayerIntoBattle.Invoke(OSSCollectData.BeginFightTime, Owner);
			if (IsTransUnit())
			{
				OSSCollectData.PlayerTransEvent.HaveBattle |= 1;
			}
		}
		else
		{
			if (BGUFunctionLibraryCS.GetAttrValue(Owner, EBGUAttrFloat.Hp) <= 0f)
			{
				OSSCollectData.BattlePlayerData.EndType = BattleEndType.Die;
			}
			else
			{
				OSSCollectData.BattlePlayerData.EndType = BattleEndType.Detach;
			}
			bool flag = IsTransUnit();
			if (flag && OSSCollectData.bHasExtEndType)
			{
				OSSCollectData.BattlePlayerData.EndType = OSSCollectData.Ext_EndType;
			}
			ulong roleId = PlayerBaseRoleData.RoleId;
			BattlePlayer battlePlayerData = OSSCollectData.BattlePlayerData;
			BGUCharacterCS player = Owner as BGUCharacterCS;
			battlePlayerData.Player = BGUFuncLibPlayer.GetPlayerInfoBattleData(player);
			int gameTotalTime = PlayerRoleData.GetGameTotalTime();
			battlePlayerData.Dur = gameTotalTime - OSSCollectData.BeginFightTime;
			if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
			{
				base.BGSEventCollection.Evt_BGS_OnPlayerLeaveBattle.Invoke(roleId, battlePlayerData, gameTotalTime, flag, BecauseOfTrans);
			}
			if (IsTransUnit())
			{
				MergeBattleData_UnitTrans();
			}
		}
		PlayerInfo playerInfo = new PlayerInfo();
		if (PlayerRoleData != null && PlayerRoleData.RoleData != null)
		{
			playerInfo.Role = new PlayerInfoRole();
			APlayerController playerController = UGameplayStatics.GetPlayerController(GetOwner(), 0);
			RoleDataHelper.FillOssPlayerRoleInfo(PlayerRoleData.RoleData, playerInfo.Role, playerController);
		}
		foreach (Item item in playerInfo.Role.Items)
		{
			OSSCollectData.BattlePlayerData.FullItems.Add(item);
		}
		OSSCollectData.IsFight = IsFight;
	}

	private bool IsTransUnit()
	{
		if (Owner == null)
		{
			return false;
		}
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
		return BGU_DataUtil.GetActorResID(Owner) != commLogicCfgValue;
	}

	private void OnGPStart(int MappingSkillId, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (MappingSkillId == 10705)
		{
			_GPEvent = default(GPEvent);
			_GPEvent.bInGPSkill = true;
			_GPEvent.PELevelBeforeGP = BGUFunctionLibraryCS.BGUGetCurPELevel(Owner);
			_GPEvent.bInFight = OSSCollectData.IsFight;
		}
	}

	private void OnGPEnded(int SkillId)
	{
		if (SkillId == 10705)
		{
			ReportEventGPEvent reportEventGPEvent = new ReportEventGPEvent();
			reportEventGPEvent.RoleId = PlayerBaseRoleData.RoleId;
			reportEventGPEvent.IsInBattle = (_GPEvent.bInFight ? 1 : 2);
			reportEventGPEvent.PeLevel = _GPEvent.PELevelBeforeGP;
			reportEventGPEvent.IsSuccess = (_GPEvent.bSuccess ? 1 : 2);
			EventReporter.GetInstance(Owner).GPEvent(reportEventGPEvent);
			_GPEvent.Clear();
		}
	}

	private void CheckGPSuccess(bool IsHasBuffBefore, AActor Caster, int BuffID, float BuffDuration)
	{
		if (_GPEvent.bInGPSkill && BuffID == 288)
		{
			_GPEvent.bSuccess = true;
		}
	}

	private void ReportPlayerTransEvent()
	{
		OSSCollectData.PlayerTransEvent.Dur = PlayerRoleData.GetGameTotalTime() - OSSCollectData.StartTime_PlayerTrans;
		if (OSSCollectData.PlayerTransEvent.HaveBattle != 1)
		{
			OSSCollectData.PlayerTransEvent.HaveBattle = 2;
		}
		OSSCollectData.PlayerTransEvent.EndType = "Die";
		if (OSSCollectData.bHasExtEndType)
		{
			if (OSSCollectData.Ext_EndType == BattleEndType.TransbackEnergyEmpty)
			{
				OSSCollectData.PlayerTransEvent.EndType = "Energy_Empty";
			}
			else if (OSSCollectData.Ext_EndType == BattleEndType.TransbackActive)
			{
				OSSCollectData.PlayerTransEvent.EndType = "Transback_Active";
			}
			else if (OSSCollectData.Ext_EndType == BattleEndType.TransbackOther)
			{
				OSSCollectData.PlayerTransEvent.EndType = "Transback_Other";
			}
		}
		OSSCollectData.PlayerTransEvent.ExitEnergy = AttrContainer.GetFloatValue(EBGUAttrFloat.CurEnergy);
		OSSCollectData.PlayerTransEvent.ExitHp = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
		OSSCollectData.PlayerTransEvent.AttackDur = PlayerTransData.AttackDur;
		OSSCollectData.PlayerTransEvent.RollDur = PlayerTransData.RollDur;
		foreach (KeyValuePair<string, TransDmgStruct> item in PlayerTransData.GetTransDmgDict())
		{
			PlayerTransDmg playerTransDmg = new PlayerTransDmg();
			playerTransDmg.Guid = item.Key;
			playerTransDmg.ExtendId = item.Value.ExtendId;
			playerTransDmg.HpMax = item.Value.HpMax;
			foreach (PlayerTransDmgInfo item2 in item.Value.TransDmgInfo)
			{
				playerTransDmg.DmgInfo.Add(item2);
			}
			OSSCollectData.PlayerTransEvent.Dmg.Add(playerTransDmg);
		}
		EventReporter.GetInstance(Owner).PlayerTransEvent(OSSCollectData.PlayerTransEvent);
	}

	private void UnitTrans_BeforePosses(EPlayerTransEndType TransType)
	{
		if (IsTransUnit())
		{
			if (TransType != EPlayerTransEndType.None)
			{
				OSSCollectData.bHasExtEndType = true;
				switch (TransType)
				{
				case EPlayerTransEndType.EnergyEmpty:
					OSSCollectData.Ext_EndType = BattleEndType.TransbackEnergyEmpty;
					break;
				case EPlayerTransEndType.BeatBack:
				case EPlayerTransEndType.HpTransBack:
					OSSCollectData.Ext_EndType = BattleEndType.Die;
					break;
				case EPlayerTransEndType.CastSpell:
					OSSCollectData.Ext_EndType = BattleEndType.TransbackActive;
					break;
				default:
					OSSCollectData.Ext_EndType = BattleEndType.TransbackOther;
					break;
				}
			}
			OSSCollectData.PlayerTransEvent.Player = BGUFuncLibPlayer.GetPlayerInfoBattleData(OwnerAsCharacterCS);
		}
		if (OSSCollectData.IsFight)
		{
			OnOSSCollectBattleData_Player_Wrap(IsFight: false, BecauseOfTrans: true);
		}
	}

	private void MergeBattleData_UnitTrans()
	{
		if (OSSCollectData.BattlePlayerData == null)
		{
			return;
		}
		foreach (Attack item in OSSCollectData.BattlePlayerData.Atk)
		{
			bool flag = false;
			for (int i = 0; i < OSSCollectData.PlayerTransEvent.Atk.Count; i++)
			{
				if (OSSCollectData.PlayerTransEvent.Atk[i].Id == item.Id)
				{
					OSSCollectData.PlayerTransEvent.Atk[i].Num += item.Num;
					OSSCollectData.PlayerTransEvent.Atk[i].Dmg += item.Dmg;
					OSSCollectData.PlayerTransEvent.Atk[i].Hit += item.Hit;
					OSSCollectData.PlayerTransEvent.Atk[i].Target += item.Target;
					OSSCollectData.PlayerTransEvent.Atk[i].Call += item.Call;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				OSSCollectData.PlayerTransEvent.Atk.Add(item);
			}
		}
		foreach (Defence item2 in OSSCollectData.BattlePlayerData.Def)
		{
			bool flag2 = false;
			for (int j = 0; j < OSSCollectData.PlayerTransEvent.Def.Count; j++)
			{
				if (OSSCollectData.PlayerTransEvent.Def[j].Id == item2.Id && OSSCollectData.PlayerTransEvent.Def[j].IsMonst == item2.IsMonst)
				{
					OSSCollectData.PlayerTransEvent.Def[j].Num += item2.Num;
					OSSCollectData.PlayerTransEvent.Def[j].Dmg += item2.Dmg;
					OSSCollectData.PlayerTransEvent.Def[j].IsKill |= item2.IsKill;
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				OSSCollectData.PlayerTransEvent.Def.Add(item2);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		OnEndPlaySZ(EndPlayReason);
		OnEndPlayBossRush(EndPlayReason);
		if (EndPlayReason == EEndPlayReason.Destroyed && IsTransUnit())
		{
			ReportPlayerTransEvent();
		}
	}
}
