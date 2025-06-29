using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

internal class BIS_BossRushBattleManager : GameInstanceSystemBase
{
	private const string GlobalDAPath = "BGWDataAsset_BossRushLevelConfig'/Game/00Main/DataAsset/DA_BossRushLevelConfig.DA_BossRushLevelConfig'";

	public override bool bTickEnabled => true;

	private BIC_BossRushBattleData BattleData { get; set; }

	private IBIC_BossRushData BossRushData { get; set; }

	private BGW_EventCollection BGWEventCollection { get; set; }

	public override void OnAttach()
	{
		BattleData = RequireWritableGameInstanceData<BIC_BossRushBattleData>();
		BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
		BGWEventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection bGWEventCollection = BGWEventCollection;
		bGWEventCollection.Evt_LoadBossRushBattle = (Del_Void_Int)Delegate.Combine(bGWEventCollection.Evt_LoadBossRushBattle, new Del_Void_Int(LoadBossRushBattle));
		BGW_EventCollection bGWEventCollection2 = BGWEventCollection;
		bGWEventCollection2.Evt_ShutdownBossRushBattle = (Del_Void)Delegate.Combine(bGWEventCollection2.Evt_ShutdownBossRushBattle, new Del_Void(ShutdownBossRushBattle));
		BGW_EventCollection bGWEventCollection3 = BGWEventCollection;
		bGWEventCollection3.Evt_UpdateBossRushConfig = (BGW_EventCollection.Del_UpdateBossRushConfig)Delegate.Combine(bGWEventCollection3.Evt_UpdateBossRushConfig, new BGW_EventCollection.Del_UpdateBossRushConfig(UpdateBossRushRunConfig));
		BGW_EventCollection bGWEventCollection4 = BGWEventCollection;
		bGWEventCollection4.Evt_EndBossRushBattle = (Del_Void)Delegate.Combine(bGWEventCollection4.Evt_EndBossRushBattle, new Del_Void(EndBossRushBattle));
		BGWEventCollection.Evt_BossRushBattleWaitFinished = OnWaitFinished;
		BGW_EventCollection bGWEventCollection5 = BGWEventCollection;
		bGWEventCollection5.Evt_NotifyPlayerInBattle = (Del_Void)Delegate.Combine(bGWEventCollection5.Evt_NotifyPlayerInBattle, new Del_Void(OnPlayerInBattle));
		BGW_EventCollection bGWEventCollection6 = BGWEventCollection;
		bGWEventCollection6.Evt_NotifyPlayerLeaveBattle = (Del_Void)Delegate.Combine(bGWEventCollection6.Evt_NotifyPlayerLeaveBattle, new Del_Void(OnPlayerLeaveBattle));
	}

	private void OnWaitFinished()
	{
		if (BattleData.BattlePhase == EBossRushBattlePhase.GraphLoaded)
		{
			BattleData.BattlePhase = EBossRushBattlePhase.WaitFinish;
			if (BattleData.bPlayerInBattle)
			{
				Trans2BattlePhase();
			}
		}
	}

	private void Trans2BattlePhase()
	{
		BattleData.BattlePhase = EBossRushBattlePhase.Battle;
		BGWEventCollection.Evt_BeginBossRushBattle();
	}

	private void OnPlayerInBattle()
	{
		BattleData.bPlayerInBattle = true;
		if (BattleData.BattlePhase == EBossRushBattlePhase.WaitFinish)
		{
			Trans2BattlePhase();
		}
	}

	private void OnPlayerLeaveBattle()
	{
		BattleData.bPlayerInBattle = false;
	}

	public override void OnInit()
	{
		base.OnInit();
		BattleData.DAConfig = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<BGWDataAsset_BossRushLevelConfig>("BGWDataAsset_BossRushLevelConfig'/Game/00Main/DataAsset/DA_BossRushLevelConfig.DA_BossRushLevelConfig'", ELoadResourceType.SyncLoadAndCache);
		B1Global.GOverrideLevelNumericalStrength = 0;
		B1Global.GBossRushBattleReadyTime = BattleData.DAConfig.BattleReadyTime;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForDefeatSlowTime(DeltaTime);
	}

	public override void OnShutdown()
	{
		B1Global.GOverrideLevelNumericalStrength = 0;
	}

	private void LoadBossRushBattle(int BossRushID)
	{
		if (BattleData.CurrentInstance != null)
		{
			ShutdownBossRushBattle();
		}
		BGW_EventCollection.Get(base.Owner)?.Evt_SetAllUnitCannotDead(P1: false);
		FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(BossRushID);
		if (bossRushConfigDesc != null)
		{
			BattleData.BattlePhase = EBossRushBattlePhase.GraphLoaded;
			BattleData.BossRushRoom = null;
			if (bossRushConfigDesc.IsUseBossRoom == EGSYesNo.Yes)
			{
				BattleData.BossRushRoom = new FBossRoom();
			}
			BattleData.BossRushID = BossRushID;
			PsmInstance psmInstance = PsmInstance.Create(null, bossRushConfigDesc.GraphPath, base.Owner, BossRushID.ToString(), null, "BIS");
			BattleData.CurrentInstance = psmInstance;
			psmInstance.OnGraphStart();
			BattleData.CurrentSlowTime = -1f;
			BattleData.TotalSlowTime = bossRushConfigDesc.TotalSlowTime;
			BattleData.TimeDilationCurve = BGW_PreloadAssetMgr.Get(base.Owner)?.TryGetCachedResourceObj<UCurveFloat>(bossRushConfigDesc.TimeDilationCurve, ELoadResourceType.SyncLoadAndCache);
			BattleData.AdditionalHPMaxMul = bossRushConfigDesc.AdditionalHPMaxMul;
			BattleData.AdditionalAtkMul = bossRushConfigDesc.AdditionalAtkMul;
		}
	}

	private void EndBossRushBattle()
	{
		BattleData.BattlePhase = EBossRushBattlePhase.EndBattle;
		BeginDefeatSlowTime();
	}

	private void BeginDefeatSlowTime()
	{
		BattleData.CurrentSlowTime = 0f;
		BPS_EventCollectionCS.GetLocal(base.Owner).Evt_DefeatedStateChange.Invoke(BattleData.BossRushID, EDefeatUITriggerType.BossRush);
		BGW_EventCollection.Get(base.Owner).Evt_StopAllTimeDilation();
		TickForDefeatSlowTime(0f);
	}

	private void TickForDefeatSlowTime(float InDeltaTime)
	{
		if (BattleData.CurrentSlowTime < 0f)
		{
			return;
		}
		if (BattleData.TotalSlowTime <= BattleData.CurrentSlowTime)
		{
			EndDefeatSlowTime();
			return;
		}
		if (InDeltaTime > 1E-08f)
		{
			float globalTimeDilation = UGameplayStatics.GetGlobalTimeDilation(base.Owner);
			BattleData.CurrentSlowTime += ((globalTimeDilation > 0f) ? (InDeltaTime / globalTimeDilation) : InDeltaTime);
		}
		float timeDilation = 1f;
		if (BattleData.TimeDilationCurve != null)
		{
			timeDilation = BattleData.TimeDilationCurve.GetFloatValue(BattleData.CurrentSlowTime);
		}
		UGameplayStatics.SetGlobalTimeDilation(base.Owner, timeDilation);
	}

	private void EndDefeatSlowTime()
	{
		UGameplayStatics.SetGlobalTimeDilation(base.Owner, 1f);
		BattleData.CurrentSlowTime = -1f;
		BGW_EventCollection.Get(base.Owner).Evt_FinishBossRushBattle();
	}

	private void ShutdownBossRushBattle()
	{
		BattleData.CurrentInstance.Shutdown();
		BattleData.ClearData();
		B1Global.GOverrideLevelNumericalStrength = 0;
	}

	private void UpdateBossRushRunConfig(BossRushCustom_InitialV2 InCustomData)
	{
		BattleData.PlayerStartForSingle = CalliopeExtension.ToFTransform(InCustomData.PlayerStartForSingle);
		BattleData.PlayerStartForGroup = CalliopeExtension.ToFTransform(InCustomData.PlayerStartForGroup);
		BattleData.TargetPersistentLevelName = InCustomData.LevelName;
		BattleData.LevelLoadConfigFromDA.Clear();
		BattleData.LevelLoadConfigFromGraph.Clear();
		foreach (UBossRushLevelConfig levelConfig in BattleData.DAConfig.LevelConfigs)
		{
			if (levelConfig.PersistentLevel == InCustomData.LevelName)
			{
				AddConfig2Map(BattleData.LevelLoadConfigFromDA, new IDictionary<string, FBossRushLevelState>[8] { levelConfig.BossRushLevelsLoadSetting, levelConfig.GeometryLevelsLoadSetting, levelConfig.SeqLevelsLoadSetting, levelConfig.ItemLevelsLoadSetting, levelConfig.LightLevelsLoadSetting, levelConfig.SupportLevelsLoadSetting, levelConfig.OtherLevelsLoadSetting, levelConfig.MonsterLevelsLoadSetting });
				break;
			}
		}
		foreach (BossRushCustom_LevelLoadState item in InCustomData.ModifiedLevelState)
		{
			BattleData.LevelLoadConfigFromGraph[item.LevelName] = (EBossRushLevelLoadState)item.LoadState;
		}
		if (BossRushData.BossRushType == EBossRushType.BossIterations || BossRushData.BossRushType == EBossRushType.IterationsPractise)
		{
			bool flag = true;
			int bossIterationsGroupId = BossRushData.BossIterationsGroupId;
			BattleData.TamerPropertyOverrideList.Clear();
			BattleData.ServantPropertyOverrideList.Clear();
			foreach (BossRushCustom_GroupBattleConfigV2 groupBattleConfig in InCustomData.GroupBattleConfigs)
			{
				if (groupBattleConfig.GroupId != 0 && groupBattleConfig.GroupId != bossIterationsGroupId)
				{
					continue;
				}
				flag = false;
				foreach (BossRushCustom_TamerOverrideProperty tamerOverrideProperty in groupBattleConfig.TamerOverrideProperties)
				{
					string unitConfigGuid = tamerOverrideProperty.UnitConfigGuid;
					string key = BattleData.CurrentInstance.ConvertParamID2UnitGuid(unitConfigGuid);
					BattleData.TamerPropertyOverrideList[key] = new FBossRushTamerPropertyOverride
					{
						BattleExtendID = tamerOverrideProperty.ExtendId
					};
				}
				foreach (BossRushCustom_ServantOverrideProperty servantOverrideProperty in groupBattleConfig.ServantOverrideProperties)
				{
					BattleData.ServantPropertyOverrideList[servantOverrideProperty.SummonId] = new FBossRushServantPropertyOverride
					{
						BattleExtendID = servantOverrideProperty.ExtendId
					};
				}
				B1Global.GOverrideLevelNumericalStrength = groupBattleConfig.LevelNumericalStrength;
				break;
			}
			if (flag)
			{
				B1Global.GOverrideLevelNumericalStrength = 99;
			}
		}
		foreach (BossRushCustom_TableOverride tableOverride in InCustomData.TableOverrides)
		{
			FBossRushModifyTableCollection modifyTableCollection = BattleData.ModifyTableCollection;
			if (tableOverride.ModifyMethod == EBossRushModifyTableMethod.DeadDelayDestroyTime)
			{
				modifyTableCollection.ModifyDeadDelayDestroyTime[tableOverride.MainId] = tableOverride.FloatValue;
			}
		}
		FBossRoom bossRushRoom = BattleData.BossRushRoom;
		if (bossRushRoom == null)
		{
			return;
		}
		foreach (ProcessCustom_Param assetParam in InCustomData.AssetParams)
		{
			if ((byte)assetParam.ParamType == 7)
			{
				bossRushRoom.BossBattleState[assetParam.ParamString] = false;
			}
		}
		static void AddConfig2Map(IDictionary<string, EBossRushLevelLoadState> ConfigMap, IDictionary<string, FBossRushLevelState>[] LevelsLoadSettingList)
		{
			for (int i = 0; i < LevelsLoadSettingList.Length; i++)
			{
				foreach (KeyValuePair<string, FBossRushLevelState> item2 in LevelsLoadSettingList[i])
				{
					ConfigMap[item2.Key] = item2.Value.GetFinalBossRushLevelLoadState();
				}
			}
		}
	}
}
