using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_UnitBarInfoComp : UActorCompBaseCS
{
	private BUC_UnitBarInfoData UnitBarInfoData;

	private IBUC_PartMgrData PartMgrData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_BattleStateData BattleStateData { get; set; }

	private IBUC_AIData AIData { get; set; }

	private BUC_AttrContainer AttrContainerData { get; set; }

	private BGW_UIEventCollection UIEC { get; set; }

	private APawn LocalPlayer { get; set; }

	private IBPC_BattleMainInfoData LocalPlayerBattleMainInfoData { get; set; }

	private IBUC_TargetInfoData LocalPlayerTargetInfoData { get; set; }

	private IBUC_UIControlData UIControlData { get; set; }

	private IBGC_UnrealGameplayData UnrealGameplayData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		UnitBarInfoData = RequireWritableData<BUC_UnitBarInfoData>();
		AttrContainerData = RequireWritableData<BUC_AttrContainer>();
		PartMgrData = RequireReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		UIControlData = RequireReadOnlyData<IBUC_UIControlData, BUC_UIControlData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		AttrContainerData.FloatAttrs.BindOnSetIdxValue(OnBindOnSetIdxValueChange);
		UIEC = BGW_UIEventCollection.Get(Owner);
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_TriggerHitInPart += new Del_TriggerHitInPart(OnTriggerHitInPart);
			base.BUSEventCollection.Evt_UIPartIDChanged += new Del_Void_IntFloat(OnUIPartIDChanged);
			base.BUSEventCollection.Evt_ShowEliteBar += new Del_Bool_Void(ShowEliteBar);
			base.BUSEventCollection.Evt_ShowBossBar += new Del_Bool_Void(ShowBossBar);
			base.BUSEventCollection.Evt_BuffInstsDictOnAdd += new Del_BuffInstsDictOnAdd(BuffInstsDictOnAdd);
			base.BUSEventCollection.Evt_BuffInstsDictOnRemove += new Del_Void_Int(OnBuffInstsDictOnRemove);
			base.BUSEventCollection.Evt_ShouledUpdateBuffTime += new Del_Void_Bool(OnShouledUpdateBuffTime);
			base.BUSEventCollection.Evt_OnBuffLayerChangedNotify += new Del_OnBuffLayerChangedNotify(OnBuffLayerChanged);
			base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
			base.BUSEventCollection.Evt_BeAttackedByPlayer_ForUI += new Del_Void(OnBeAttackedByPlayer);
			base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		}
		if (UnitBarInfoData != null)
		{
			UnitBarInfoData.LocalBuffInstDic.OnAdd += OnBuffAdd;
			GSBindDictionary<int, BuffInstData> localBuffInstDic = UnitBarInfoData.LocalBuffInstDic;
			localBuffInstDic.OnRemove = (Action<int, BuffInstData>)Delegate.Combine(localBuffInstDic.OnRemove, new Action<int, BuffInstData>(OnBuffRemove));
			GSBindProp<bool> bossBarAcived = UnitBarInfoData.BossBarAcived;
			bossBarAcived.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(bossBarAcived.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeBossBarActived));
			GSBindProp<bool> eliteBarActived = UnitBarInfoData.EliteBarActived;
			eliteBarActived.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(eliteBarActived.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeEilteBarActived));
		}
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		if (Owner as BGUCharacterCS != null)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null)
			{
				UnitBarInfoData.BarType = unitBattleInfoExtendDesc.BloodBarType;
			}
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc2 = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc2 != null)
			{
				UnitBarInfoData.ShieldShowInUI = unitBattleInfoExtendDesc2.BlockCollapseArmorIsShowInUI == EGSYesNo.Yes;
			}
		}
		UnitBarInfoData.LockDelayTime = 3f;
		UnitBarInfoData.LastDmgDelayTime = 3f;
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.UnitBarConfig, out var ConfigInfo);
		BGWDataAsset_UnitBarConfig bGWDataAsset_UnitBarConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_UnitBarConfig>(ConfigInfo.StringValue, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_UnitBarConfig != null)
		{
			UnitBarInfoData.LockDelayTime = bGWDataAsset_UnitBarConfig.LockDelayTime;
			UnitBarInfoData.LastDmgDelayTime = bGWDataAsset_UnitBarConfig.LastDmgDelayTime;
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		UIEC?.Evt_UI_RegTopBarUI(GetOwner() as BGUCharacterCS);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		AttrContainerData.FloatAttrs.UnBindOnSetIdxValue(OnBindOnSetIdxValueChange);
		UpdateBossAndEliteBar(IsShowBoss: false, IsShowElite: false);
		base.OnEndPlay(EndPlayReason);
		UIEC?.Evt_UI_UnRegTopBarUI(GetOwner() as BGUCharacterCS);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (LocalPlayer.IsNullOrDestroyed())
		{
			LocalPlayer = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
			if (LocalPlayer.IsNullOrDestroyed())
			{
				return;
			}
			LocalPlayerBattleMainInfoData = BGU_DataUtil.GetReadOnlyData<IBPC_BattleMainInfoData, BPC_BattleMainInfoData>(LocalPlayer.GetController());
			LocalPlayerTargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(LocalPlayer);
		}
		if (LocalPlayer != null)
		{
			TickIsLocked();
			TickIsInBattle(LocalPlayer);
			TickIsInAttackedWindow();
			TickIsDead();
			PlayerInBossBattle();
			bool flag = TickShieldIDIsValid();
			UnitBarInfoData.BloodBarActived = ShowEnemyBar();
			UnitBarInfoData.ShieldBarActived = UnitBarInfoData.BloodBarActived && flag;
			UnitBarInfoData.BossShieldBarActived = (UnitBarInfoData.BossBarAcived.Value || UnitBarInfoData.EliteBarActived.Value) && flag;
			if (!UnitBarInfoData.IsBlockCollapseArmorUnit && SimpleStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal) && UnitBarInfoData.ShieldShowInUI)
			{
				UnitBarInfoData.IsBlockCollapseArmorUnit = true;
				float floatValue = AttrContainerData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
				float num = AttrContainerData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor) / floatValue;
				num = ((num < 0f) ? 0f : num);
				UpDateUnitShield(num);
			}
			if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal))
			{
				UnitBarInfoData.IsBlockCollapseArmorUnit = false;
			}
		}
		bool isShowElite = ShowEliteBar();
		bool isShowBoss = ShowBossBar();
		UpdateBossAndEliteBar(isShowBoss, isShowElite);
	}

	private void UpdateBossAndEliteBar(bool IsShowBoss, bool IsShowElite)
	{
		bool flag = false;
		if (((UnitBarInfoData.BossBarAcived.Value && !IsShowBoss) || (UnitBarInfoData.EliteBarActived.Value && !IsShowElite)) && UnitBarInfoData.ObserveBoss.Count > 0)
		{
			foreach (string item in UnitBarInfoData.ObserveBoss)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, item);
				if (!actorByGuid.IsNullOrDestroyed())
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
					if (!bUS_GSEventCollection.IsNullOrDestroyed())
					{
						flag |= bUS_GSEventCollection.Evt_ShowBossBar.Invoke() || bUS_GSEventCollection.Evt_ShowEliteBar.Invoke();
					}
				}
			}
		}
		if (UnitBarInfoData.BossBarAcived.Value && !IsShowBoss)
		{
			bool flag2 = flag;
			UnitBarInfoData.BossBarAcived.SetValue(EChangeReason.InnerOp, flag2);
			if (!flag2 && LocalPlayerBattleMainInfoData != null)
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
				if (firstLocalPlayerController != null)
				{
					BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(firstLocalPlayerController);
					if (local != null)
					{
						foreach (string item2 in UnitBarInfoData.ObserveBoss)
						{
							local.Evt_TryRemoveBossBarInfo.Invoke(item2);
						}
					}
				}
			}
		}
		else
		{
			UnitBarInfoData.BossBarAcived.SetValue(EChangeReason.InnerOp, IsShowBoss);
		}
		if (UnitBarInfoData.EliteBarActived.Value && !IsShowElite)
		{
			bool flag3 = flag;
			UnitBarInfoData.EliteBarActived.SetValue(EChangeReason.InnerOp, flag3);
			if (flag3 || LocalPlayerBattleMainInfoData == null)
			{
				return;
			}
			APlayerController firstLocalPlayerController2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
			if (!(firstLocalPlayerController2 != null))
			{
				return;
			}
			BPS_GSEventCollection local2 = BPS_EventCollectionCS.GetLocal(firstLocalPlayerController2);
			if (!(local2 != null))
			{
				return;
			}
			{
				foreach (string item3 in UnitBarInfoData.ObserveBoss)
				{
					local2.Evt_TryRemoveEliteBarInfo.Invoke(item3);
				}
				return;
			}
		}
		UnitBarInfoData.EliteBarActived.SetValue(EChangeReason.InnerOp, IsShowElite);
	}

	private bool TickShieldIDIsValid()
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal))
		{
			if (PartMgrData.ShowUIPartID < 0)
			{
				UnitBarInfoData.ShieldBarActived = false;
				return false;
			}
			return true;
		}
		if (UnitBarInfoData.ShieldShowInUI)
		{
			if (AttrContainerData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor) <= 0f)
			{
				UnitBarInfoData.ShieldBarActived = false;
				return false;
			}
			return true;
		}
		return false;
	}

	private void TickIsInBattle(APawn PlayerActor)
	{
		if (UnitStateData == null || !UnitStateData.HasState(EBGUUnitState.Dead))
		{
			bool isInBattle = BattleStateData.IsUnitInBattleAssignPlayer(PlayerActor);
			UnitBarInfoData.IsInBattle = isInBattle;
		}
	}

	private void TickIsLocked()
	{
		if (LocalPlayerTargetInfoData != null)
		{
			UnitBarInfoData.IsLocked = LocalPlayerTargetInfoData.GetTargetInfo().LockTargetActor == Owner;
		}
	}

	private void TickIsInAttackedWindow()
	{
		if (AIData.GetLastAtkDmgTime() != 0f)
		{
			UnitBarInfoData.IsInLastDmgWindow = Owner.World.GetTimeSeconds() - AIData.GetLastAtkDmgTime() < UnitBarInfoData.LastDmgDelayTime;
		}
		else
		{
			UnitBarInfoData.IsInLastDmgWindow = false;
		}
	}

	private void TickIsDead()
	{
		UnitBarInfoData.IsDead = UnitStateData.HasState(EBGUUnitState.Dead);
	}

	private void PlayerInBossBattle()
	{
		if (LocalPlayerBattleMainInfoData != null)
		{
			UnitBarInfoData.PlayerInBossBattle = LocalPlayerBattleMainInfoData.IsInBossBattle();
		}
	}

	private void OnHPChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		float floatValue = AttrContainerData.GetFloatValue(EBGUAttrFloat.HpMax);
		float num = NewValue / floatValue;
		num = ((num < 0f) ? 0f : num);
		UpdateUnitHp(NewValue - OldValue, num);
	}

	private void OnHPMaxChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		float num = AttrContainerData.GetFloatValue(EBGUAttrFloat.Hp) / NewValue;
		num = ((num < 0f) ? 0f : num);
		UpdateUnitHp(NewValue - OldValue, num);
	}

	private void OnBlockArmorChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		float floatValue = AttrContainerData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
		float num = NewValue / floatValue;
		num = ((num < 0f) ? 0f : num);
		UpDateUnitShield(num);
	}

	private void OnBlockArmorMaxChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		float num = AttrContainerData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor) / NewValue;
		num = ((num < 0f) ? 0f : num);
		UpDateUnitShield(num);
	}

	private void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		switch (AttrId)
		{
		case 151:
			OnHPChange(EBGUAttrFloat.Hp, OldValue, NewValue);
			break;
		case 1:
			OnHPMaxChange(EBGUAttrFloat.HpMax, OldValue, NewValue);
			break;
		case 171:
			OnBlockArmorChange(EBGUAttrFloat.BlockCollapseArmor, OldValue, NewValue);
			break;
		case 21:
			OnBlockArmorMaxChange(EBGUAttrFloat.BlockCollapseArmorMax, OldValue, NewValue);
			break;
		}
	}

	private void OnUIPartIDChanged(int PartID, float MaxPartDamagedValue)
	{
		if (GetOwner() == null || PartID == -1)
		{
			return;
		}
		PartMgrData.GetPartInfo(PartID, out var PartInfoOut);
		if (PartInfoOut == null)
		{
			return;
		}
		float maxPartDamagedValue = PartInfoOut.MaxPartDamagedValue;
		float currentPartDamagedValue = PartInfoOut.CurrentPartDamagedValue;
		if (maxPartDamagedValue > 0f)
		{
			float num = currentPartDamagedValue / maxPartDamagedValue;
			if (num > 0f)
			{
				UnitBarInfoData.ShieldBarActived = true;
			}
			UpDateUnitShield(num);
		}
	}

	private void OnTriggerHitInPart(int PartID, float HitHP, int StiffLevel)
	{
		if (GetOwner() == null || PartID == -1 || PartMgrData.ShowUIPartID != PartID)
		{
			return;
		}
		PartMgrData.GetPartInfo(PartID, out var PartInfoOut);
		if (PartInfoOut != null)
		{
			float maxPartDamagedValue = PartInfoOut.MaxPartDamagedValue;
			float currentPartDamagedValue = PartInfoOut.CurrentPartDamagedValue;
			if (maxPartDamagedValue > 0f)
			{
				float num = currentPartDamagedValue / maxPartDamagedValue;
				num = ((num < 0f) ? 0f : num);
				UpDateUnitShield(num);
			}
		}
	}

	private void UpdateUnitHp(float ExpectChangeValue, float HPPercent)
	{
		GetIsLocalPlayer(out var _, out var _);
		SetHpBarPercent(HPPercent);
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner));
		if (local != null)
		{
			if (UnitBarInfoData.BossBarAcived.Value)
			{
				local.Evt_UpdateHPPercent.Invoke(Owner, UnitBarInfoData.BloodBarPercent, IsAdd: true);
			}
			else if (UnitBarInfoData.EliteBarActived.Value)
			{
				local.Evt_UpdateHPPercent.Invoke(Owner, UnitBarInfoData.BloodBarPercent, IsAdd: false);
			}
		}
	}

	private void SetHpBarPercent(float HPPercent)
	{
		UnitBarInfoData.BloodBarPercent = HPPercent;
	}

	private void UpDateUnitShield(float Percent)
	{
		SetShieldBarPercent(Percent);
	}

	private void SetShieldBarPercent(float Percent)
	{
		UnitBarInfoData.ShieldBarPercent = Percent;
		if (Percent <= 0f)
		{
			UnitBarInfoData.ShieldBarActived = false;
		}
		else
		{
			UnitBarInfoData.ShieldBarActived = true;
		}
	}

	private void GetIsLocalPlayer(out bool IsPlayer, out bool IsLocal)
	{
		IsPlayer = false;
		IsLocal = false;
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
		{
			IsPlayer = bGUPlayerCharacterCS.IsPlayerControlled();
			IsLocal = bGUPlayerCharacterCS.IsLocallyControlled();
		}
	}

	private bool ShowEnemyBar()
	{
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.CantShowBlood);
		bool flag2 = false;
		if (UIControlData.GetOnlyShowByPlayer() && UnitBarInfoData.BeAttackedByPlayer && UnrealGameplayData.GetTimeSeconds() - UnitBarInfoData.LastTimeBeAttackedByPlayer <= 10f)
		{
			flag = false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreBattleInfoInUnitBar))
		{
			return !flag;
		}
		if (UnitBarInfoData.BarType == EBGUBloodBarType.EnemyBar)
		{
			flag2 = (UnitBarInfoData.IsLocked || UnitBarInfoData.IsInLastDmgWindow) && !UnitBarInfoData.IsDead;
		}
		else if (UnitBarInfoData.BarType == EBGUBloodBarType.EliteBar)
		{
			flag2 = false;
		}
		else if (UnitBarInfoData.BarType == EBGUBloodBarType.BossBar)
		{
			flag2 = false;
		}
		if (DebugConfig.CricketBattleMode)
		{
			flag2 = UnitBarInfoData.IsInLastDmgWindow;
		}
		if (flag2)
		{
			return !flag;
		}
		return false;
	}

	public bool ShowEliteBar()
	{
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.CantShowBlood);
		bool flag2 = false;
		if (UnitBarInfoData.BarType == EBGUBloodBarType.EliteBar)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreBattleInfoInUnitBar))
			{
				return !flag;
			}
			flag2 = UnitBarInfoData.IsInBattle && !UnitBarInfoData.IsDead && !UnitBarInfoData.PlayerInBossBattle;
		}
		if (flag2)
		{
			return !flag;
		}
		return false;
	}

	public bool ShowBossBar()
	{
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.CantShowBlood);
		bool flag2 = false;
		if (UnitBarInfoData.BarType == EBGUBloodBarType.BossBar)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreBattleInfoInUnitBar))
			{
				return !flag;
			}
			flag2 = UnitBarInfoData.IsInBattle && !UnitBarInfoData.IsDead;
		}
		if (flag2)
		{
			return !flag;
		}
		return false;
	}

	private void OnChangeBossBarActived(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		BPS_EventCollectionCS.GetLocal(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner))?.Evt_SetBossBar.Invoke(Owner, UnitBarInfoData.BloodBarPercent, NewValue);
	}

	private void OnChangeEilteBarActived(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		BPS_EventCollectionCS.GetLocal(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner))?.Evt_SetEilteBar.Invoke(Owner, UnitBarInfoData.BloodBarPercent, NewValue);
	}

	private void BuffInstsDictOnAdd(int BuffID, float Duration, EBuffSourceType BuffSourceType, AActor Caster)
	{
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
		if (!UnitBarInfoData.LocalBuffInstDic.ContainsKey(BuffID))
		{
			UnitBarInfoData.LocalBuffInstDic.Add(BuffID, buffInstData);
			return;
		}
		UnitBarInfoData.LocalBuffInstDic.Remove(BuffID);
		UnitBarInfoData.LocalBuffInstDic.Add(BuffID, buffInstData);
	}

	private void OnBuffInstsDictOnRemove(int BuffID)
	{
		UnitBarInfoData.LocalBuffInstDic.Remove(BuffID);
	}

	private void OnBuffLayerChanged(int BuffID, int Layer_OldValue, int Layer_NewValue)
	{
		if (UnitBarInfoData.LocalBuffInstDic.ContainsKey(BuffID) && Layer_NewValue != 0)
		{
			UnitBarInfoData.LocalBuffInstDic[BuffID].LeftTime = UnitBarInfoData.LocalBuffInstDic[BuffID].Duration;
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (UnitBarInfoData.ObserveBoss.Count == 0)
		{
			UnitBarInfoData.BossBarAcived.SetValue(EChangeReason.InnerOp, value: false);
			UnitBarInfoData.EliteBarActived.SetValue(EChangeReason.InnerOp, value: false);
			UnitBarInfoData.BloodBarActived = false;
			UnitBarInfoData.ShieldBarActived = false;
			UnitBarInfoData.BossShieldBarActived = false;
			UnitBarInfoData.ObserveBoss.Clear();
		}
	}

	private void OnBeAttackedByPlayer()
	{
		UnitBarInfoData.BeAttackedByPlayer = true;
		UnitBarInfoData.LastTimeBeAttackedByPlayer = UnrealGameplayData.GetTimeSeconds();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		UnitBarInfoData.BeAttackedByPlayer = false;
		UnitBarInfoData.LastTimeBeAttackedByPlayer = -1f;
	}

	private void OnShouledUpdateBuffTime(bool ShouledUpdateBuffTime)
	{
		UnitBarInfoData.bShouldUpdateBuffTime = ShouledUpdateBuffTime;
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
			if (UnitBarInfoData.BuffIconInfo.ContainsKey(buffIconDesc.IconID))
			{
				UnitBarInfoData.BuffIconInfo[buffIconDesc.IconID].Add(BuffInstData);
				return;
			}
			List<BuffInstData> list = new List<BuffInstData>();
			list.Add(BuffInstData);
			UnitBarInfoData.BuffIconInfo.Add(buffIconDesc.IconID, list);
			UnitBarInfoData.BuffIconList.Add(buffIconDesc.IconID);
		}
	}

	private void OnBuffRemove(int BuffID, BuffInstData BuffInstData)
	{
		FUStBuffIconDesc buffIconDesc = BGW_GameDB.GetBuffIconDesc(BuffID);
		if (buffIconDesc != null && UnitBarInfoData.BuffIconInfo.ContainsKey(buffIconDesc.IconID))
		{
			UnitBarInfoData.BuffIconInfo[buffIconDesc.IconID].RemoveAll((BuffInstData Data) => Data.BuffID == BuffID);
			if (UnitBarInfoData.BuffIconInfo[buffIconDesc.IconID].Count == 0)
			{
				UnitBarInfoData.BuffIconInfo.Remove(buffIconDesc.IconID);
				UnitBarInfoData.BuffIconList.Remove(buffIconDesc.IconID);
			}
		}
	}
}
