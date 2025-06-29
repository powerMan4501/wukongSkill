using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.BGW;
using b1.EventDelDefine;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BIS_LevelManager")]
public class BIS_LevelManager : GameInstanceSystemBaseUObj
{
	private BGW_EventCollection EventCollection { get; set; }

	private BIC_LevelData LevelData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBIC_CollectionGroupData CollectionGroupData { get; set; }

	public override void OnAttach()
	{
		LevelData = RequireWritableGameInstanceData<BIC_LevelData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		CollectionGroupData = RequireReadonlyGameInstanceData<IBIC_CollectionGroupData, BIC_CollectionGroupData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_RequestUpdateLevelArchiveData = (Del_Void)Delegate.Combine(eventCollection.Evt_RequestUpdateLevelArchiveData, new Del_Void(OnRequestUpdateLevelArchiveData));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_RecoverLevelArchiveData = (BGW_EventCollection.Del_BGW_Void_IntLevelArchiveData)Delegate.Combine(eventCollection2.Evt_RecoverLevelArchiveData, new BGW_EventCollection.Del_BGW_Void_IntLevelArchiveData(RecoverLevelArchiveData));
			BGW_EventCollection eventCollection3 = EventCollection;
			eventCollection3.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(eventCollection3.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			BGW_EventCollection eventCollection4 = EventCollection;
			eventCollection4.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(eventCollection4.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnReSetGameData));
			BGW_EventCollection eventCollection5 = EventCollection;
			eventCollection5.Evt_BGW_OnWorldChanged = (BGW_EventCollection.Del_BGW_OnWorldChanged)Delegate.Combine(eventCollection5.Evt_BGW_OnWorldChanged, new BGW_EventCollection.Del_BGW_OnWorldChanged(OnWorldChanged));
			BGW_EventCollection eventCollection6 = EventCollection;
			eventCollection6.Evt_PreLoadMap = (Del_Void_String)Delegate.Combine(eventCollection6.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
		}
	}

	public override void OnInit()
	{
		UpdateLevelInfo(UGSE_EngineFuncLib.GetWorldFromObj(this));
		BGWDataAsset_LevelInfo levelInfo = BGW_PreloadAssetMgr.Get(this).LevelInfo;
		if (levelInfo != null)
		{
			LevelData.DetailLevelInfo = (DebugConfig.IsLiteBuild ? levelInfo.LiteLevelInfo : levelInfo.MainLevelInfo);
			LevelData.LevelTagToLevelIdMap = levelInfo.LevelTagToLevelIdMap.ToDictionary((KeyValuePair<ELevelTag, FLevelIdListInfo> pair) => pair.Key, (KeyValuePair<ELevelTag, FLevelIdListInfo> pair) => pair.Value.LevelIdList);
		}
	}

	private void OnReSetGameData(EGameInstanceResetType ResetType)
	{
		LevelData.LevelBaseDataMap.Clear();
		LevelData.LevelDetailDataMap.Clear();
	}

	private void OnWorldChanged(UWorld OldWorld, UWorld NewWorld)
	{
		UpdateLevelInfo(NewWorld);
	}

	private void OnPreLoadMap(string MapName)
	{
		LevelData.bOpeningLevel = true;
	}

	private void UpdateLevelInfo(UWorld World)
	{
		if (!World.IsNullOrDestroyed())
		{
			int currentLevelID = LevelData.CurrentLevelID;
			LevelData.CurrentLevelName = World.GetFName();
			LevelDesc levelDesc = GameDBRuntime.GetTBLevelDesc().List.FirstOrDefault((LevelDesc item) => item.Path == LevelData.CurrentLevelName.PlainName);
			LevelData.CurrentLevelID = levelDesc?.Id ?? 0;
			BGW_GameArchiveMgr.Get(base.Owner).MarkDelaySaveArchive(EArchiveDelaySaveSource.LevelIDChanged, $"LevelID: {currentLevelID} -> {LevelData.CurrentLevelID}");
			BGW_EventCollection.Get(base.Owner).Evt_OnCurrentLevelChanged(LevelData.CurrentLevelID);
			BGW_DebugMgr.Get(base.Owner).UpdateUserConfigToSentry();
		}
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		LevelData.CurrentLevelName = new FName(UGameplayStatics.GetCurrentLevelName(this));
		if (LevelData.bOpeningLevel)
		{
			LevelData.bOpeningLevel = false;
			EventCollection.Evt_OpenLevelFinished();
		}
	}

	private void InitCurrentLevelArchiveData()
	{
		int currentLevelID = LevelData.CurrentLevelID;
		if (currentLevelID > 0)
		{
			Dictionary<int, LevelArchiveBaseData> levelBaseDataMap = LevelData.LevelBaseDataMap;
			if (!levelBaseDataMap.ContainsKey(currentLevelID))
			{
				LevelArchiveBaseData value = new LevelArchiveBaseData
				{
					MapId = currentLevelID,
					PlayerData = new LevelArchivePlayerData()
				};
				levelBaseDataMap.Add(currentLevelID, value);
			}
			Dictionary<int, LevelArchiveDetailData> levelDetailDataMap = LevelData.LevelDetailDataMap;
			if (!levelDetailDataMap.ContainsKey(currentLevelID))
			{
				LevelArchiveDetailData value2 = new LevelArchiveDetailData
				{
					LevelId = currentLevelID
				};
				levelDetailDataMap.Add(currentLevelID, value2);
			}
		}
	}

	private void RecoverLevelArchiveData(int MapId, LevelArchiveData InLevelArchiveData)
	{
		LevelData.LevelIDInArchive = MapId;
		Dictionary<int, LevelArchiveBaseData> levelBaseDataMap = LevelData.LevelBaseDataMap;
		foreach (LevelArchiveBaseData levelBaseDatum in InLevelArchiveData.LevelBaseData)
		{
			if (levelBaseDataMap.ContainsKey(levelBaseDatum.MapId))
			{
				levelBaseDataMap[levelBaseDatum.MapId] = levelBaseDatum;
			}
			else
			{
				levelBaseDataMap.Add(levelBaseDatum.MapId, levelBaseDatum);
			}
			foreach (DeadUnitData deadUnitDatum in levelBaseDatum.DeadUnitData)
			{
				EventCollection.Evt_LoadActorAliveState(deadUnitDatum.Uid, P2: false);
				EventCollection.Evt_LoadActorResetType(deadUnitDatum.Uid, deadUnitDatum.ResetType);
			}
		}
		Dictionary<int, LevelArchiveDetailData> levelDetailDataMap = LevelData.LevelDetailDataMap;
		foreach (LevelArchiveDetailData levelDetailDatum in InLevelArchiveData.LevelDetailData)
		{
			if (levelDetailDataMap.ContainsKey(levelDetailDatum.LevelId))
			{
				levelDetailDataMap[levelDetailDatum.LevelId] = levelDetailDatum;
			}
			else
			{
				levelDetailDataMap.Add(levelDetailDatum.LevelId, levelDetailDatum);
			}
		}
	}

	private void OnRequestUpdateLevelArchiveData()
	{
		if (LevelData.CurrentLevelID <= 0)
		{
			return;
		}
		InitCurrentLevelArchiveData();
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(this, 0);
		LevelArchivePlayerData playerData = LevelData.GetCurrentLevelBaseArchiveData().PlayerData;
		FVector actorLocation = playerCharacter.GetActorLocation();
		FRotator actorRotation = playerCharacter.GetActorRotation();
		playerData.PlayerPosX = actorLocation.X;
		playerData.PlayerPosY = actorLocation.Y;
		playerData.PlayerPosZ = actorLocation.Z;
		playerData.PlayerPosPitch = actorRotation.Pitch;
		playerData.PlayerPosYaw = actorRotation.Yaw;
		playerData.PlayerPosRoll = actorRotation.Roll;
		playerData.RequireLevelNames.Clear();
		foreach (ULevelStreaming item in UBGWFunctionLibrary.BGWGetAllStreamingLevels(playerCharacter))
		{
			if (item.IsLevelLoaded())
			{
				playerData.RequireLevelNames.Add(UBGWFunctionLibrary.GetLevelStreamingAssetName(item));
			}
		}
		foreach (KeyValuePair<int, LevelArchiveBaseData> item2 in LevelData.LevelBaseDataMap)
		{
			LevelArchiveBaseData value = item2.Value;
			value.DeadUnitData.Clear();
			List<DeadUnitData> deadUnitsDataToArchive = GlobalActorData.GetDeadUnitsDataToArchive();
			value.DeadUnitData.AddRange(deadUnitsDataToArchive);
		}
		BGS_EventCollectionCS.Get(this).Evt_BGS_SerializeQuestArchiveData.Invoke();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BIS_LevelManager");
	}

	static BIS_LevelManager()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BIS_LevelManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BIS_LevelManager));
	}
}
