using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using OssB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BIS_BossRushMgr : GameInstanceSystemBase
{
	private IBGC_MovieData MovieData;

	private BGW_CharacterViewMgr CharacterViewMgr;

	private IBPC_PlayerTagData PlayerTagData;

	public override bool bTickEnabled => true;

	private BIC_BossRushData BossRushData { get; set; }

	public override void OnAttach()
	{
		BossRushData = RequireWritableGameInstanceData<BIC_BossRushData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_StartBossRushChallenge = (Del_StartBossRushChallenge)Delegate.Combine(bGW_EventCollection.Evt_StartBossRushChallenge, new Del_StartBossRushChallenge(StartBossRushChallenge));
			bGW_EventCollection.Evt_QuitBossRushChallenge = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_QuitBossRushChallenge, new Del_Void(QuitBossRushChallenge));
			bGW_EventCollection.Evt_BossRushIterationsNext = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BossRushIterationsNext, new Del_Void(BossRushIterationsNext));
			bGW_EventCollection.Evt_BeginBossRushBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BeginBossRushBattle, new Del_Void(BeginBossRushBattle));
			bGW_EventCollection.Evt_FailedBossRushBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_FailedBossRushBattle, new Del_Void(BossRushBattleFailed));
			bGW_EventCollection.Evt_EndBossRushBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_EndBossRushBattle, new Del_Void(EndBossRushBattle));
			bGW_EventCollection.Evt_FinishBossRushBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_FinishBossRushBattle, new Del_Void(FinishBossRushBattle));
			bGW_EventCollection.Evt_GMSetBossrushIndex = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_GMSetBossrushIndex, new Del_Void_Int(GMSetBossrushIndex));
			bGW_EventCollection.Evt_ReBattleWithCurConfig = (Del_ReBattleWithCurConfig)Delegate.Combine(bGW_EventCollection.Evt_ReBattleWithCurConfig, new Del_ReBattleWithCurConfig(ReBattleWithCurConfig));
			bGW_EventCollection.Evt_ManualQuitBossRush = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ManualQuitBossRush, new Del_Void(OnManualQuitBossRush));
			bGW_EventCollection.Evt_BossRushBattleTimeSetPaused = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_BossRushBattleTimeSetPaused, new Del_Void_Bool(OnBossRushBattleTimeSetPaused));
			bGW_EventCollection.Evt_BossRushBattleWaitFinished = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BossRushBattleWaitFinished, new Del_Void(OnBossRushBattleWaitFinished));
			bGW_EventCollection.Evt_BossRushPreEndBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BossRushPreEndBattle, new Del_Void(BTFPlayerRestReq));
			bGW_EventCollection.Evt_BossRushRecordItemUse = (Del_BossRushRecordItemUse)Delegate.Combine(bGW_EventCollection.Evt_BossRushRecordItemUse, new Del_BossRushRecordItemUse(BossRushRecordItemUse));
			bGW_EventCollection.Evt_BBC_OnUseSkillByTypeSuccess = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnUseSkillByTypeSuccess, new Del_Void_Int(OnUseSkillByTypeSuccess));
			bGW_EventCollection.Evt_BBC_OnUseFaBaoSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnUseFaBaoSuccess, new Del_Void(OnUseFaBaoSuccess));
			bGW_EventCollection.Evt_BBC_OnVigorSkillCastSuccess = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnVigorSkillCastSuccess, new Del_Void_IntInt(OnVigorSkillCastSuccess));
			bGW_EventCollection.Evt_BBC_OnUseItemSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnUseItemSuccess, new Del_Void(OnUseItemSuccess));
			bGW_EventCollection.Evt_BBC_OnTriggerHuluEffectSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnTriggerHuluEffectSuccess, new Del_Void(OnTriggerHuluEffectSuccess));
			bGW_EventCollection.Evt_BBC_OnPreciseDodgeSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnPreciseDodgeSuccess, new Del_Void(OnPreciseDodgeSuccess));
			bGW_EventCollection.Evt_BBC_OnGPSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnGPSuccess, new Del_Void(OnGPSuccess));
			bGW_EventCollection.Evt_BBC_OnFourPEAtkSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnFourPEAtkSuccess, new Del_Void(OnFourPEAtkSuccess));
			bGW_EventCollection.Evt_BBC_OnMonsterBeHurted = (Del_BBC_OnMonsterBeHurted)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnMonsterBeHurted, new Del_BBC_OnMonsterBeHurted(OnMonsterBeHurted));
			bGW_EventCollection.Evt_BBC_OnPlayerBeHurted = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnPlayerBeHurted, new Del_Void_Int(OnPlayerBeHurted));
			bGW_EventCollection.Evt_BBC_OnCastLifeSavingSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BBC_OnCastLifeSavingSuccess, new Del_Void(OnPlayerCastLifeSavingSuccess));
		}
	}

	private void ResetBattleData()
	{
		BossRushData.BossRushBattleData.TotalTime = 0f;
		BossRushData.BossRushBattleData.ArchiveTime = 0uL;
		BossRushData.BossRushBattleData.RoleBase = new BossRushRoleBase();
		BossRushData.BossRushBattleData.BattleStyleInfo = new BossRushBattleStyle();
		BossRushData.BossRushBattleData.DamageInfo = new BossRushDamageInfo();
		BossRushData.BossIterationsAttrCacheDict?.Clear();
		BossRushData.BossRushDamageInfo_PerRand?.Clear();
		BossRushData.LimitTime = 0f;
		BossRushData.LastLimitTime = 0f;
		BossRushData.CostItemList = null;
		BossRushData.BattleTimeList?.Clear();
		BossRushData.IsInBattleState = false;
	}

	private void OssReport(BossRushResultType BossRushResultType)
	{
		ReportEventBossRushResult reportEventBossRushResult = new ReportEventBossRushResult();
		reportEventBossRushResult.Type = (int)BossRushData.BossRushType;
		reportEventBossRushResult.TargetId = BossRushData.TargetId;
		reportEventBossRushResult.Result = BossRushResultType;
		reportEventBossRushResult.BattleTime = (int)BossRushData.BossRushBattleData.TotalTime;
		reportEventBossRushResult.HardLevel = BossRushData.BossRushBattleData.Score;
		if (BossRushData.BossRushBattleData.DebuffList != null)
		{
			foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
			{
				reportEventBossRushResult.DebuffList.Add(debuff);
			}
		}
		if (BossRushData.BossRushType == EBossRushType.Rechallenge || BossRushData.BossRushType == EBossRushType.IterationsPractise)
		{
			reportEventBossRushResult.Progress = 1;
		}
		if (BossRushData.BossRushType == EBossRushType.BossIterations)
		{
			reportEventBossRushResult.Progress = BossRushData.BossIterationsIndex + 1;
		}
		if (BossRushData.BossRushType != EBossRushType.IterationsPractise)
		{
			reportEventBossRushResult.TargetId = BossRushData.BossRushBattleData.TargetId;
		}
		(reportEventBossRushResult.BattleCount, reportEventBossRushResult.IsComplete) = GetBattleCount(BossRushResultType);
		foreach (float battleTime in BossRushData.BattleTimeList)
		{
			reportEventBossRushResult.BattleTimeList.Add(battleTime);
		}
		reportEventBossRushResult.BattleTimeList.Add(BossRushData.BossRushBattleData.TotalTime - BossRushData.LastLimitTime);
		EventReporter.GetInstance(base.Owner).BossRushResult(reportEventBossRushResult);
	}

	private (uint, bool) GetBattleCount(BossRushResultType BossRushResultType)
	{
		EBossRushType bossRushType = BossRushData.BossRushType;
		APlayerController playerController = UGameplayStatics.GetPlayerController(base.Owner, 0);
		bool flag = BossRushResultType == BossRushResultType.Success;
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(playerController);
		if (readOnlyData != null)
		{
			switch (bossRushType)
			{
			case EBossRushType.Rechallenge:
			{
				ReadOnlyBossRushRefightBossList bossList = readOnlyData.RoleData.RoleCs.BossRush.Refight.BossList;
				if (bossList == null)
				{
					break;
				}
				int targetId = BossRushData.BossRushBattleData.TargetId;
				foreach (ReadOnlyBossRushRefightBoss item in bossList)
				{
					if (item.BossId != targetId)
					{
						continue;
					}
					bool flag2 = BossRushData.BossRushBattleData.Score <= (int)item.PassedMaxLevel;
					if (item.RefightStatisticsList == null)
					{
						continue;
					}
					foreach (ReadOnlyRefightStatistics refightStatistics in item.RefightStatisticsList)
					{
						if (refightStatistics.ChallengeLevel == (EReChallengeLevel)BossRushData.BossRushBattleData.Score)
						{
							return (refightStatistics.BattleCount, flag2 || flag);
						}
					}
				}
				break;
			}
			case EBossRushType.BossIterations:
			case EBossRushType.IterationsPractise:
			{
				ReadOnlyBossRushContinuousFightGroupList bossGroups = readOnlyData.RoleData.RoleCs.BossRush.ContinuousFight.BossGroups;
				if (bossGroups == null)
				{
					break;
				}
				foreach (ReadOnlyBossRushContinuousFightGroup item2 in bossGroups)
				{
					if (item2.BossGroupId == BossRushData.BossIterationsGroupId)
					{
						if (bossRushType == EBossRushType.IterationsPractise)
						{
							return (item2.BattleCount, item2.IsPassed || BossRushData.BossIterationsIndex < item2.EncounterBossIndex);
						}
						return (item2.BattleCount, item2.IsPassed || flag);
					}
				}
				break;
			}
			}
		}
		return (1u, flag);
	}

	private void BossRushIterationsNext()
	{
		BossRushData.BossIterationsIndex++;
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
		BossRushData.BattleTimeList.Add(BossRushData.BossRushBattleData.TotalTime - BossRushData.LastLimitTime);
		BossRushData.LastLimitTime = BossRushData.BossRushBattleData.TotalTime;
		if (bossIterationsDesc.BossSuccessiveInfo.Count > BossRushData.BossIterationsIndex)
		{
			BossRushData.TargetId = bossIterationsDesc.BossSuccessiveInfo[BossRushData.BossIterationsIndex];
			FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushData.TargetId);
			RecordAndSetPlayerState(bossRushConfigDesc.LevelID);
			BGW_EventCollection.Get(base.Owner)?.Evt_BossRushManualCloseDefeatedUI?.Invoke();
			BGS_GSEventCollection.Get(base.Owner)?.Evt_BGS_StopAllAiConversation?.Invoke(EACInterruptType.Interrupt, EACInterruptReason.PlaySeq);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
			if (playerCharacter != null)
			{
				UAkGameplayStatics.PostEvent(null, playerCharacter, 0, null, bStopWhenAttachedToDestroyed: false, "Break_Dialogue_Battle");
			}
			BPS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.BossRush, new TeleportParam_BossRush
			{
				LevelId = bossRushConfigDesc.LevelID
			}, EPlayerTeleportReason.BossRush);
		}
	}

	private void RecordAndSetPlayerState(int TargetLevelId)
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
		BossRushData.BossIterationsAttrCacheDict = new Dictionary<int, float>();
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(playerCharacter);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
		IBUC_SealingSpellData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SealingSpellData, BUC_SealingSpellData>(playerCharacter);
		if (readOnlyData != null && unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsInSealingSpellState)
		{
			bUS_GSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Mp, readOnlyData.GetFloatValue(EBGUAttrFloat.MpMax));
			bUS_GSEventCollection?.Evt_ModifyCD.Invoke(10521, bAddOrMul: false, -10000f);
		}
		foreach (KeyValuePair<int, int> item in BUS_TransPlayerDataBindComp.PlayerAttrDict)
		{
			BossRushData.BossIterationsAttrCacheDict.Add(item.Key, readOnlyData.GetFloatValue((EBGUAttrFloat)item.Key));
		}
		bUS_GSEventCollection?.Evt_TriggerPlayerClearBattleState.Invoke(EPlayerClearBattleStateType.BattleRush);
		bUS_GSEventCollection?.Evt_UpdatePlayerBindData.Invoke();
	}

	private void BeginBossRushBattle()
	{
		BossRushData.IsInBattleState = true;
		if (BossRushData.BossRushType == EBossRushType.BossIterations || BossRushData.BossRushType == EBossRushType.IterationsPractise)
		{
			bool flag = false;
			foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
			{
				BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
				if (bossRushDebuffDesc != null && BGW_GameDB.GetBossRushBattleTimeLimitEnable(bossRushDebuffDesc.DebuffId))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
				if (bossIterationsDesc.LimitTimeList.Count > BossRushData.BossIterationsIndex && bossIterationsDesc.LimitTimeList[BossRushData.BossIterationsIndex] > 0)
				{
					BossRushData.LimitTime = bossIterationsDesc.LimitTimeList[BossRushData.BossIterationsIndex];
				}
			}
		}
		OnBossRushBattleTimeSetPaused(IsPause: false);
	}

	private void EndBossRushBattle()
	{
		OnBossRushBattleTimeSetPaused(IsPause: true);
		BGW_EventCollection.Get(base.Owner).Evt_SetGamePause(EPauseEvent.BattleInput, bPause: true);
		BossRushData.IsInBattleState = false;
		if (BossRushData.BossRushBattleData != null)
		{
			BossRushData.BossRushBattleData.ArchiveTime = UBGWFunctionLibraryCS.GetUTCTimeStamp();
			BossRushData.BossRushBattleData.RoleBase = BossRushData.BossRushRoleBase;
			BossRushDamageInfo bossRushDamageInfo = new BossRushDamageInfo();
			bossRushDamageInfo.TotalDamage = BossRushData.BossRushDamageInfo_PerRand.TotalDmg;
			bossRushDamageInfo.HightestDamage = BossRushData.BossRushDamageInfo_PerRand.HightestDmg;
			bossRushDamageInfo.CriticalDmgRate = ((bossRushDamageInfo.TotalDamage > 0f) ? (BossRushData.BossRushDamageInfo_PerRand.CritDmg / bossRushDamageInfo.TotalDamage) : 0f);
			bossRushDamageInfo.CriticalDmgTotal = BossRushData.BossRushDamageInfo_PerRand.CritDmg;
			bossRushDamageInfo.TotalBeDamaged = BossRushData.BossRushDamageInfo_PerRand.BeHurtedDmg;
			bossRushDamageInfo.ElemDotDmgRate = ((bossRushDamageInfo.TotalDamage > 0f) ? (BossRushData.BossRushDamageInfo_PerRand.ElemDotDmg / bossRushDamageInfo.TotalDamage) : 0f);
			bossRushDamageInfo.ElemDotDmgTotal = BossRushData.BossRushDamageInfo_PerRand.ElemDotDmg;
			BossRushData.BossRushBattleData.DamageInfo = bossRushDamageInfo;
			BossRushBattleStyle bossRushBattleStyle = new BossRushBattleStyle();
			foreach (BossRushCastCount spell in BossRushData.BattleStyleInfo.SpellList)
			{
				bossRushBattleStyle.SpellList.Add(spell);
			}
			bossRushBattleStyle.SoulInfo = BossRushData.BattleStyleInfo.SoulSkillInfo;
			bossRushBattleStyle.FabaoInfo = BossRushData.BattleStyleInfo.FabaoSkillInfo;
			bossRushBattleStyle.ItemCount = BossRushData.BattleStyleInfo.ItemCount;
			bossRushBattleStyle.WineCount = BossRushData.BattleStyleInfo.WineCount;
			bossRushBattleStyle.RollCount = BossRushData.BattleStyleInfo.RollCount;
			bossRushBattleStyle.DefuseCount = BossRushData.BattleStyleInfo.DefuseCount;
			bossRushBattleStyle.FourPeCount = BossRushData.BattleStyleInfo.FourPECount;
			BossRushData.BossRushBattleData.BattleStyleInfo = bossRushBattleStyle;
		}
		if (GSEUtil.IsBossRushLastBoss(base.Owner, BossRushData))
		{
			BGW_EventCollection.Get(base.Owner).Evt_ShowBossRushBattleFinishUI(P1: true, P2: false);
			if (BossRushData.BossRushType != EBossRushType.IterationsPractise)
			{
				B1Global.GIsBossRushSettlementMode = true;
			}
		}
	}

	private void InitBossRushRoleBaseData()
	{
		BossRushData.BossRushRoleBase = new BossRushRoleBase();
		APlayerController playerController = UGameplayStatics.GetPlayerController(base.Owner, 0);
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(playerController);
		IBUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(playerCharacter);
		if (readOnlyData != null && readOnlyData2 != null)
		{
			BossRushData.BossRushRoleBase.Level = readOnlyData.RoleData.RoleCs.Base.Level;
			BossRushData.BossRushRoleBase.HpMax = readOnlyData2.GetFloatValue(EBGUAttrFloat.HpMax);
			BossRushData.BossRushRoleBase.MpMax = readOnlyData2.GetFloatValue(EBGUAttrFloat.MpMax);
			BossRushData.BossRushRoleBase.Atk = readOnlyData2.GetFloatValue(EBGUAttrFloat.Atk);
			BossRushData.BossRushRoleBase.StaminaMax = readOnlyData2.GetFloatValue(EBGUAttrFloat.StaminaMax);
		}
	}

	private void FinishBossRushBattle()
	{
		bool flag = !GSEUtil.IsBossRushLastBoss(base.Owner, BossRushData);
		APlayerState playerState = UGameplayStatics.GetPlayerState(base.Owner, 0);
		FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushData.TargetId);
		if (bossRushConfigDesc != null)
		{
			BossRushData.WaitEndTransformingFlag = flag;
			if (flag)
			{
				BossRushData.BattleFinishDelayTime = (float)bossRushConfigDesc.TeleportDelayTime * 0.001f;
				PlayerTagData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(playerState);
			}
			else
			{
				OssReport(BossRushResultType.Success);
				BossRushData.BattleFinishDelayTime = 0.1f;
			}
		}
		BPS_EventCollectionCS.Get(playerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CantTrans, default(PlayerTransParam));
	}

	private void SendEndRpc(bool IsSuccess)
	{
		BossRushBattleParam bossRushBattleParam = new BossRushBattleParam
		{
			BossRushType = BossRushData.BossRushType,
			TargetId = BossRushData.BossRushBattleData.TargetId,
			ChallengeLevel = (EReChallengeLevel)BossRushData.BossRushBattleData.Score
		};
		foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
		{
			bossRushBattleParam.DebuffList.Add(debuff);
		}
		BGUCharacterCS bGUCharacterCS = UGameplayStatics.GetPlayerCharacter(base.Owner, 0) as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BTF_EventCollectionCS.Get(bGUCharacterCS.PlayerState)?.Evt_BossRushBattleCompleteReq(new CSMsgBossRushBattleCompleteReq
			{
				BattleParam = bossRushBattleParam,
				ChangleSuccess = IsSuccess,
				BattleData = BossRushData.BossRushBattleData,
				EncounterBossIndex = BossRushData.BossIterationsIndex
			}, null);
		}
	}

	private void BossRushBattleFailed()
	{
		BossRushBattleFailed(IsTimeOut: false);
	}

	private void BossRushBattleFailed(bool IsTimeOut)
	{
		BGW_EventCollection.Get(base.Owner).Evt_ShowBossRushBattleFinishUI(P1: false, IsTimeOut);
		OnBossRushBattleTimeSetPaused(IsPause: true);
		OssReport(IsTimeOut ? BossRushResultType.TimeOutFailed : BossRushResultType.DeadFailed);
		if (BossRushData.BossRushType != EBossRushType.IterationsPractise)
		{
			B1Global.GIsBossRushSettlementMode = true;
		}
	}

	private void OnBossRushBattleTimeSetPaused(bool IsPause)
	{
		BossRushData.BattleTimePaused = IsPause;
		BGW_EventCollection.Get(base.Owner)?.Evt_BossRushSetPauseTimeTick(IsPause, BossRushData.LimitTime - BossRushData.BossRushBattleData.TotalTime + BossRushData.LastLimitTime);
	}

	private void OnBossRushBattleWaitFinished()
	{
		if (BossRushData.BossRushType != EBossRushType.BossIterations || BossRushData.BossIterationsIndex == 0)
		{
			InitBossRushRoleBaseData();
			BossRushData.BattleStyleInfo.InitBattleStyleInfo(base.Owner);
		}
		MovieData = null;
	}

	private void OnManualQuitBossRush()
	{
		OssReport(BossRushResultType.ManualQuit);
	}

	private void ReBattleWithCurConfig(EBossRushType NewBossRushType = EBossRushType.None)
	{
		if (NewBossRushType != EBossRushType.None)
		{
			BossRushData.BossRushType = NewBossRushType;
		}
		if (BossRushData.BossRushType != EBossRushType.IterationsPractise)
		{
			APlayerController playerController = UGameplayStatics.GetPlayerController(base.Owner, 0);
			if (!(playerController != null))
			{
				return;
			}
			BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(playerController.PlayerState);
			if (bTF_EventCollectionCS == null)
			{
				return;
			}
			CSMsgBossRushBattleStartReq cSMsgBossRushBattleStartReq = new CSMsgBossRushBattleStartReq();
			BossRushBattleParam bossRushBattleParam = new BossRushBattleParam
			{
				BossRushType = BossRushData.BossRushType,
				TargetId = BossRushData.BossRushBattleData.TargetId,
				ChallengeLevel = (EReChallengeLevel)BossRushData.BossRushBattleData.Score,
				EnableCooperation = BossRushData.AllowAssociationUnit
			};
			foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
			{
				bossRushBattleParam.DebuffList.Add(debuff);
			}
			cSMsgBossRushBattleStartReq.BattleParam = bossRushBattleParam;
			bTF_EventCollectionCS.Evt_BossRushBattleStartReq(cSMsgBossRushBattleStartReq, BossRushBattleStartReqCallBack);
		}
		else
		{
			ReBattleWithCurConfigBegin();
		}
	}

	private void BossRushBattleStartReqCallBack(MsgErrCode ErrCode, CSMsgBossRushBattleStartReq Req, CSMsgBossRushBattleStartRes Res)
	{
		ReBattleWithCurConfigBegin();
	}

	private void ReBattleWithCurConfigBegin()
	{
		_ = BossRushData.TargetLevelId;
		if (BossRushData.BossRushType == EBossRushType.BossIterations || BossRushData.BossRushType == EBossRushType.IterationsPractise)
		{
			BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
			if (bossIterationsDesc != null)
			{
				if (BossRushData.BossRushType == EBossRushType.BossIterations)
				{
					BossRushData.BossIterationsIndex = 0;
				}
				BossRushData.TargetId = bossIterationsDesc.BossSuccessiveInfo[BossRushData.BossIterationsIndex];
				FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushData.TargetId);
				if (bossRushConfigDesc != null)
				{
					BossRushData.TargetLevelId = bossRushConfigDesc.LevelID;
					_ = bossRushConfigDesc.LevelID;
				}
			}
		}
		ResetBattleData();
		BTFPlayerRestReq();
		BGW_EventCollection.Get(base.Owner).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.EnterBossRush, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
		{
			ArchiveId = BGW_GameArchiveMgr.Get(base.Owner).CurrentArchiveId
		});
		B1Global.GIsBossRushSettlementMode = false;
	}

	private void BossRushRecordItemUse(ItemOne ItemOne)
	{
		if (BossRushData.CostItemList == null)
		{
			BossRushData.CostItemList = new List<ItemOne>();
		}
		BossRushData.CostItemList.Add(ItemOne);
	}

	private void BTFPlayerRestReq()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
		if (playerCharacter != null)
		{
			CSMsgActorOnPlayerRestReq actorOnPlayerRest = new CSMsgActorOnPlayerRestReq();
			BTF_EventCollectionCS.Get(playerCharacter.PlayerState)?.Evt_ActorOnPlayerRestReq(actorOnPlayerRest, null);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (BossRushData == null || !B1Global.GIsBossRushMode)
		{
			return;
		}
		if (BossRushData.IsInBattleState && !BossRushData.BattleTimePaused && BossRushData.BossRushBattleData != null)
		{
			if (IsPauseTotalTime())
			{
				return;
			}
			BossRushData.BossRushBattleData.TotalTime += DeltaTime;
			if (BossRushData.LimitTime > 0f && BossRushData.LimitTime - BossRushData.BossRushBattleData.TotalTime + BossRushData.LastLimitTime <= 0f)
			{
				BossRushBattleFailed(IsTimeOut: true);
			}
		}
		if (!(BossRushData.BattleFinishDelayTime > 0f))
		{
			return;
		}
		if (BossRushData.WaitEndTransformingFlag)
		{
			if (PlayerTagData != null && PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				return;
			}
			BossRushData.WaitEndTransformingFlag = false;
			PlayerTagData = null;
			BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
			if (bossIterationsDesc != null)
			{
				ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
				BUS_EventCollectionCS.Get(playerCharacter)?.Evt_BuffAdd?.Invoke(bossIterationsDesc.BattleEndBuff, playerCharacter, playerCharacter, -1f);
			}
		}
		BossRushData.BattleFinishDelayTime -= DeltaTime;
		if (BossRushData.BattleFinishDelayTime < 0f && !GSEUtil.IsBossRushLastBoss(base.Owner, BossRushData))
		{
			BossRushIterationsNext();
			BGW_EventCollection.Get(base.Owner).Evt_SetGamePause(EPauseEvent.BattleInput, bPause: false);
		}
	}

	private bool IsPauseTotalTime()
	{
		if (MovieData == null)
		{
			AGameStateBase gameState = UGameplayStatics.GetGameState(base.Owner);
			MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(gameState);
		}
		if (MovieData != null && MovieData.IsPlaying())
		{
			return true;
		}
		if (CharacterViewMgr == null)
		{
			CharacterViewMgr = BGW_CharacterViewMgr.Get(base.Owner);
		}
		if (CharacterViewMgr != null && CharacterViewMgr.IsOpenCharacterView)
		{
			return true;
		}
		return false;
	}

	private void GMSetBossrushIndex(int BossIterationsIndex)
	{
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
		if (bossIterationsDesc != null)
		{
			BossRushData.BossIterationsIndex = BossIterationsIndex;
			BossRushData.TargetId = bossIterationsDesc.BossSuccessiveInfo[BossIterationsIndex];
			FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushData.TargetId);
			if (bossRushConfigDesc != null)
			{
				BossRushData.TargetLevelId = bossRushConfigDesc.LevelID;
			}
		}
	}

	public void StartBossRushChallenge(EBossRushType BossRushType, EReChallengeLevel ReChallengeLevel, List<int> DebuffList, int TargetId, int BossIterationsIndex, bool AllowAssociationUnit)
	{
		if (B1Global.GIsBossRushMode)
		{
			ResetBattleData();
		}
		if (BossRushData != null)
		{
			BossRushData.BossRushBattleData = new BossRushBattleData();
			BossRushData.BossRushBattleData.TargetId = TargetId;
			BossRushData.BossRushType = BossRushType;
			BossRushData.IsInBattleState = false;
			if (BossRushType == EBossRushType.BossIterations || BossRushType == EBossRushType.IterationsPractise)
			{
				if (DebuffList != null)
				{
					foreach (int Debuff in DebuffList)
					{
						BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(Debuff);
						if (bossRushDebuffDesc != null)
						{
							BossRushData.BossRushBattleData.Score += bossRushDebuffDesc.DebuffScore;
						}
						BossRushData.BossRushBattleData.DebuffList.Add(Debuff);
					}
				}
				BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(TargetId);
				if (bossIterationsDesc != null && bossIterationsDesc.BossSuccessiveInfo.Count > 0)
				{
					BossRushData.BossIterationsGroupId = TargetId;
					BossRushData.BossIterationsIndex = 0;
					if (BossRushType == EBossRushType.IterationsPractise)
					{
						BossRushData.BossIterationsIndex = BossIterationsIndex;
					}
					BossRushData.TargetId = bossIterationsDesc.BossSuccessiveInfo[BossRushData.BossIterationsIndex];
					FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushData.TargetId);
					if (bossRushConfigDesc != null)
					{
						BossRushData.TargetLevelId = bossRushConfigDesc.LevelID;
					}
				}
			}
			else
			{
				BossRushData.BossRushBattleData.Score = (int)ReChallengeLevel;
				BossReChallengeDesc bossReChallengeDesc = GameDBRuntime.GetBossReChallengeDesc(TargetId);
				if (bossReChallengeDesc != null)
				{
					FUStBossRushConfigDesc bossRushConfigDesc2 = BGW_GameDB.GetBossRushConfigDesc(bossReChallengeDesc.ConfigId);
					if (bossRushConfigDesc2 != null)
					{
						BossRushData.TargetId = bossReChallengeDesc.ConfigId;
						BossRushData.TargetLevelId = bossRushConfigDesc2.LevelID;
						if (AllowAssociationUnit && bossReChallengeDesc.AllowAssociationUnitConfigId > 0)
						{
							BossRushData.TargetId = bossReChallengeDesc.AllowAssociationUnitConfigId;
							BossRushData.bAllowAssociationUnit = true;
						}
						else
						{
							BossRushData.bAllowAssociationUnit = false;
						}
					}
				}
			}
		}
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(base.Owner, 0))?.Evt_TriggerTeleportResetPlayer.Invoke();
	}

	public void QuitBossRushChallenge()
	{
		BGW_EventCollection.Get(base.Owner).Evt_ShutdownBossRushBattle();
		BossRushData.Reset();
		MovieData = null;
		PlayerTagData = null;
		B1Global.GIsBossRushSettlementMode = false;
		B1Global.GIsBossRushMode = false;
	}

	private void OnUseSkillByTypeSuccess(int SpellID)
	{
		for (int i = 0; i < BossRushData.BattleStyleInfo.SpellList.Count; i++)
		{
			if (BossRushData.BattleStyleInfo.SpellList[i].CastId == SpellID)
			{
				BossRushData.BattleStyleInfo.SpellList[i].CastCount++;
				break;
			}
		}
	}

	private void OnUseFaBaoSuccess()
	{
		BossRushData.BattleStyleInfo.FabaoSkillInfo.CastCount++;
	}

	private void OnVigorSkillCastSuccess(int OriSkillID, int FinalSkillID)
	{
		BossRushData.BattleStyleInfo.SoulSkillInfo.CastCount++;
	}

	private void OnUseItemSuccess()
	{
		BossRushData.BattleStyleInfo.ItemCount++;
	}

	private void OnTriggerHuluEffectSuccess()
	{
		BossRushData.BattleStyleInfo.WineCount++;
	}

	private void OnPreciseDodgeSuccess()
	{
		BossRushData.BattleStyleInfo.RollCount++;
	}

	private void OnGPSuccess()
	{
		BossRushData.BattleStyleInfo.DefuseCount++;
	}

	private void OnFourPEAtkSuccess()
	{
		BossRushData.BattleStyleInfo.FourPECount++;
	}

	public void OnMonsterBeHurted(int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		BossRushData.BossRushDamageInfo_PerRand.OnMonsterBeHurted(DamageValue, bIsCrit, bIsElemDot);
	}

	public void OnPlayerBeHurted(int Dmg)
	{
		BossRushData.BossRushDamageInfo_PerRand.OnPlayerBeHurted(Dmg);
	}

	public void OnPlayerCastLifeSavingSuccess()
	{
		for (int i = 0; i < BossRushData.BattleStyleInfo.SpellList.Count; i++)
		{
			if (BossRushData.BattleStyleInfo.SpellList[i].CastId == 5302)
			{
				BossRushData.BattleStyleInfo.SpellList[i].CastCount++;
				break;
			}
		}
	}

	public override void OnShutdown()
	{
		B1Global.GIsBossRushMode = false;
		B1Global.GIsBossRushSettlementMode = false;
		base.OnShutdown();
	}
}
