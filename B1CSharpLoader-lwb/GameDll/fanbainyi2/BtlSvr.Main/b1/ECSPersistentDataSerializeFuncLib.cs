using b1.ECS;
using BtlB1;
using BtlShare;
using GurGsPersistent;
using UnrealEngine.Runtime;

namespace b1;

public static class ECSPersistentDataSerializeFuncLib
{
	public static void DeSerializeBUC_ActorInitData(BUC_ActorInitData ECSData, GurGsPersistent.BUC_ActorInitData Protobuf)
	{
		if (Protobuf.HasPersistentDataDontResetOnNewGamePlus)
		{
			ECSData.PersistentDataDontResetOnNewGamePlus = Protobuf.PersistentDataDontResetOnNewGamePlus;
		}
	}

	public static void DeSerializeBUC_LifeSavingData(BUC_LifeSavingData ECSData, GurGsPersistent.BUC_LifeSavingData Protobuf)
	{
	}

	public static void DeSerializeBUC_ReplicateTestData(BUC_ReplicateTestData ECSData, GurGsPersistent.BUC_ReplicateTestData Protobuf)
	{
	}

	public static void DeSerializeBUC_CollectionData(BUC_CollectionData ECSData, GurGsPersistent.BUC_CollectionData Protobuf)
	{
		if (Protobuf.HasGroupId)
		{
			ECSData.GroupId = Protobuf.GroupId;
		}
		if (Protobuf.HasCollectionQuality)
		{
			ECSData.CollectionQuality = (ECollectionQualityType)Protobuf.CollectionQuality;
		}
		if (Protobuf.HasCollectiontType)
		{
			ECSData.CollectiontType = (ECollectionInteractType)Protobuf.CollectiontType;
		}
		if (Protobuf.HasIsRandomed)
		{
			ECSData.IsRandomed = Protobuf.IsRandomed;
		}
		if (Protobuf.HasBeCollected)
		{
			ECSData.BeCollected = Protobuf.BeCollected;
		}
		if (Protobuf.HasNeedReBirthMonster)
		{
			ECSData.NeedReBirthMonster = Protobuf.NeedReBirthMonster;
		}
	}

	public static void DeSerializeBUC_InteractData(BUC_InteractData ECSData, GurGsPersistent.BUC_InteractData Protobuf)
	{
		if (Protobuf.HasInteractUnitStatePersistent)
		{
			ECSData.InteractUnitStatePersistent = (EBGUInteractUnitState)Protobuf.InteractUnitStatePersistent;
		}
		if (Protobuf.HasActionGroupIDPersistent)
		{
			ECSData.ActionGroupIDPersistent = Protobuf.ActionGroupIDPersistent;
		}
	}

	public static void DeSerializeBUC_GamePlusSpawnData(BUC_GamePlusSpawnData ECSData, GurGsPersistent.BUC_GamePlusSpawnData Protobuf)
	{
		if (Protobuf.HasDestoryForever)
		{
			ECSData.DestoryForever = Protobuf.DestoryForever;
		}
		if (Protobuf.HasLastCollectTime)
		{
			ECSData.LastCollectTime = Protobuf.LastCollectTime;
		}
		if (Protobuf.HasCurCD)
		{
			ECSData.CurCD = Protobuf.CurCD;
		}
		if (Protobuf.HasLastCollectGamePlayCount)
		{
			ECSData.LastCollectGamePlayCount = Protobuf.LastCollectGamePlayCount;
		}
		if (Protobuf.HasCollectionCount)
		{
			ECSData.CollectionCount = Protobuf.CollectionCount;
		}
	}

	public static void DeSerializeBUC_TaskCollectionData(BUC_TaskCollectionData ECSData, GurGsPersistent.BUC_TaskCollectionData Protobuf)
	{
	}

	public static void DeSerializeBGC_CollectionGroupData(BGC_CollectionGroupData ECSData, GurGsPersistent.BGC_CollectionGroupData Protobuf)
	{
		foreach (DictDeltaMsgInt_CollectionGroupDataInfo item in Protobuf.CollectionGroupDataInfo)
		{
			CollectionGroupDataInfo collectionGroupDataInfo = new CollectionGroupDataInfo();
			if (collectionGroupDataInfo == null)
			{
				collectionGroupDataInfo = new CollectionGroupDataInfo();
			}
			if (item.Value != null)
			{
				if (item.Value.HasFreshTime)
				{
					collectionGroupDataInfo.FreshTime = item.Value.FreshTime;
				}
				if (item.Value.HasFreshCount)
				{
					collectionGroupDataInfo.FreshCount = item.Value.FreshCount;
				}
			}
			ECSData.CollectionGroupDataInfo[item.Key] = collectionGroupDataInfo;
		}
	}

	public static void DeSerializeBGC_GameStateTestData(BGC_GameStateTestData ECSData, GurGsPersistent.BGC_GameStateTestData Protobuf)
	{
		foreach (ListDeltaMsgInt testID in Protobuf.TestIDList)
		{
			int oneItem = 0;
			if (testID.HasValue)
			{
				oneItem = testID.Value;
			}
			ECSData.TestIDList.Add(oneItem);
		}
		foreach (DictDeltaMsgEPropType_UInt item in Protobuf.TestPropIDDict)
		{
			uint value = 0u;
			if (item.HasValue)
			{
				value = item.Value;
			}
			ECSData.TestPropIDDict[(EPropType)item.Key] = value;
		}
		foreach (ListDeltaMsgFRepInnerClass testInnerClass in Protobuf.TestInnerClassList)
		{
			FRepInnerClass fRepInnerClass = new FRepInnerClass();
			if (fRepInnerClass == null)
			{
				fRepInnerClass = new FRepInnerClass();
			}
			_ = testInnerClass.Value;
			ECSData.TestInnerClassList.Add(fRepInnerClass);
		}
		if (Protobuf.HasTestID)
		{
			ECSData.TestID = Protobuf.TestID;
		}
	}

	public static void DeSerializeBGC_OnlineAssistData(BGC_OnlineAssistData ECSData, GurGsPersistent.BGC_OnlineAssistData Protobuf)
	{
		foreach (DictDeltaMsgString_FCrusadeUnitInfo crusadeMonsterInfo in Protobuf.CrusadeMonsterInfos)
		{
			FCrusadeUnitInfo fCrusadeUnitInfo = new FCrusadeUnitInfo();
			if (fCrusadeUnitInfo == null)
			{
				fCrusadeUnitInfo = new FCrusadeUnitInfo();
			}
			_ = crusadeMonsterInfo.Value;
			ECSData.CrusadeMonsterInfos[crusadeMonsterInfo.Key] = fCrusadeUnitInfo;
		}
	}

	public static void DeSerializeBGC_PigsyStoryData(BGC_PigsyStoryData ECSData, GurGsPersistent.BGC_PigsyStoryData Protobuf)
	{
		foreach (ListDeltaMsgInt item in Protobuf.FinishedStoryMemory)
		{
			int oneItem = 0;
			if (item.HasValue)
			{
				oneItem = item.Value;
			}
			ECSData.FinishedStoryMemory.Add(oneItem);
		}
	}

	public static void DeSerializeBGC_PlayerDeathData(BGC_PlayerDeathData ECSData, GurGsPersistent.BGC_PlayerDeathData Protobuf)
	{
		if (Protobuf.HasPlayerDeathCount)
		{
			ECSData.PlayerDeathCount = Protobuf.PlayerDeathCount;
		}
		foreach (DictDeltaMsgInt_Int item in Protobuf.ChapterDeathDict)
		{
			int value = 0;
			if (item.HasValue)
			{
				value = item.Value;
			}
			ECSData.ChapterDeathDict[item.Key] = value;
		}
	}

	public static void DeSerializeBGC_PlayerGuideData(BGC_PlayerGuideData ECSData, GurGsPersistent.BGC_PlayerGuideData Protobuf)
	{
		foreach (ListDeltaMsgInt finishedGroupGuide in Protobuf.FinishedGroupGuideList)
		{
			int oneItem = 0;
			if (finishedGroupGuide.HasValue)
			{
				oneItem = finishedGroupGuide.Value;
			}
			ECSData.FinishedGroupGuideList.Add(oneItem);
		}
	}

	public static void DeSerializeBPC_GeoInfoData(BPC_GeoInfoData ECSData, GurGsPersistent.BPC_GeoInfoData Protobuf)
	{
		foreach (ListDeltaMsgGeoInfoAreaData areaPointGeoInfo in Protobuf.AreaPointGeoInfoList)
		{
			GeoInfoAreaData geoInfoAreaData = new GeoInfoAreaData();
			if (geoInfoAreaData == null)
			{
				geoInfoAreaData = new GeoInfoAreaData();
			}
			if (areaPointGeoInfo.Value != null)
			{
				if (areaPointGeoInfo.Value.HasLevelId)
				{
					geoInfoAreaData.LevelId = areaPointGeoInfo.Value.LevelId;
				}
				if (areaPointGeoInfo.Value.HasAreaId)
				{
					geoInfoAreaData.AreaId = areaPointGeoInfo.Value.AreaId;
				}
				if (areaPointGeoInfo.Value.HasMapSpriteId)
				{
					geoInfoAreaData.MapSpriteId = areaPointGeoInfo.Value.MapSpriteId;
				}
				if (areaPointGeoInfo.Value.HasGeoAreaState)
				{
					geoInfoAreaData.GeoAreaState = (EGeoAreaState)areaPointGeoInfo.Value.GeoAreaState;
				}
				if (areaPointGeoInfo.Value.HasExploredTime)
				{
					geoInfoAreaData.ExploredTime = areaPointGeoInfo.Value.ExploredTime;
				}
			}
			ECSData.AreaPointGeoInfoList.Add(geoInfoAreaData);
		}
		foreach (ListDeltaMsgGeoInfoCustomData customGeoInfo in Protobuf.CustomGeoInfoList)
		{
			GeoInfoCustomData geoInfoCustomData = new GeoInfoCustomData();
			if (geoInfoCustomData == null)
			{
				geoInfoCustomData = new GeoInfoCustomData();
			}
			if (customGeoInfo.Value != null)
			{
				if (customGeoInfo.Value.HasId)
				{
					geoInfoCustomData.Id = customGeoInfo.Value.Id;
				}
				if (customGeoInfo.Value.HasMapId)
				{
					geoInfoCustomData.MapId = customGeoInfo.Value.MapId;
				}
				if (customGeoInfo.Value.HasPosX)
				{
					geoInfoCustomData.PosX = customGeoInfo.Value.PosX;
				}
				if (customGeoInfo.Value.HasPosY)
				{
					geoInfoCustomData.PosY = customGeoInfo.Value.PosY;
				}
				if (customGeoInfo.Value.HasGeoInfoCustomType)
				{
					geoInfoCustomData.GeoInfoCustomType = (EGeoInfoCustomType)customGeoInfo.Value.GeoInfoCustomType;
				}
			}
			ECSData.CustomGeoInfoList.Add(geoInfoCustomData);
		}
		if (Protobuf.HasCurMapSpriteId)
		{
			ECSData.CurMapSpriteId = Protobuf.CurMapSpriteId;
		}
	}

	public static void DeSerializeBPC_MapSymbolData(BPC_MapSymbolData ECSData, GurGsPersistent.BPC_MapSymbolData Protobuf)
	{
		foreach (DictDeltaMsgString_EMapSymbolState item in Protobuf.MapSymbolStateDict)
		{
			EMapSymbolState value = EMapSymbolState.Hidden;
			if (item.HasValue)
			{
				value = (EMapSymbolState)item.Value;
			}
			ECSData.MapSymbolStateDict[item.Key] = value;
		}
	}

	public static void DeSerializeBPC_PlayerAttrData(BPC_PlayerAttrData ECSData, GurGsPersistent.BPC_PlayerAttrData Protobuf)
	{
		if (Protobuf.HasPlayerLifeSavingCoolDownRemainTime)
		{
			ECSData.PlayerLifeSavingCoolDownRemainTime = Protobuf.PlayerLifeSavingCoolDownRemainTime;
		}
		foreach (ListDeltaMsgPlayerPersistentAttr item in Protobuf.PlayerPersistentAttr)
		{
			PlayerPersistentAttr playerPersistentAttr = new PlayerPersistentAttr();
			if (playerPersistentAttr == null)
			{
				playerPersistentAttr = new PlayerPersistentAttr();
			}
			if (item.Value != null)
			{
				if (item.Value.HasAttrId)
				{
					playerPersistentAttr.AttrId = item.Value.AttrId;
				}
				if (item.Value.HasAttrMaxId)
				{
					playerPersistentAttr.AttrMaxId = item.Value.AttrMaxId;
				}
				if (item.Value.HasAttrValue)
				{
					playerPersistentAttr.AttrValue = item.Value.AttrValue;
				}
				if (item.Value.HasAttrValueType)
				{
					playerPersistentAttr.AttrValueType = (EPlayerAttrRecoverType)item.Value.AttrValueType;
				}
			}
			ECSData.PlayerPersistentAttr.Add(playerPersistentAttr);
		}
		foreach (ListDeltaMsgPlayerMagicSkillCd item2 in Protobuf.PlayerMagicSkillCd)
		{
			PlayerMagicSkillCd playerMagicSkillCd = new PlayerMagicSkillCd();
			if (playerMagicSkillCd == null)
			{
				playerMagicSkillCd = new PlayerMagicSkillCd();
			}
			if (item2.Value != null)
			{
				if (item2.Value.HasSkillId)
				{
					playerMagicSkillCd.SkillId = item2.Value.SkillId;
				}
				if (item2.Value.HasCoolDown)
				{
					playerMagicSkillCd.CoolDown = item2.Value.CoolDown;
				}
			}
			ECSData.PlayerMagicSkillCd.Add(playerMagicSkillCd);
		}
		foreach (DictDeltaMsgString_Int item3 in Protobuf.KeyMonsterMeetCount)
		{
			int value = 0;
			if (item3.HasValue)
			{
				value = item3.Value;
			}
			ECSData.KeyMonsterMeetCount[item3.Key] = value;
		}
		foreach (DictDeltaMsgString_Int keyMonsterBattlePlayerDieTime in Protobuf.KeyMonsterBattlePlayerDieTimes)
		{
			int value2 = 0;
			if (keyMonsterBattlePlayerDieTime.HasValue)
			{
				value2 = keyMonsterBattlePlayerDieTime.Value;
			}
			ECSData.KeyMonsterBattlePlayerDieTimes[keyMonsterBattlePlayerDieTime.Key] = value2;
		}
	}

	public static void DeSerializeBPC_PlayerRoleData(BPC_PlayerRoleData ECSData, GurGsPersistent.BPC_PlayerRoleData Protobuf)
	{
		if (Protobuf.HasBeginAreaStayTime)
		{
			ECSData.BeginAreaStayTime = Protobuf.BeginAreaStayTime;
		}
		if (Protobuf.HasLastRebirthPointTime)
		{
			ECSData.LastRebirthPointTime = Protobuf.LastRebirthPointTime;
		}
		if (Protobuf.HasMapAreaId)
		{
			ECSData.MapAreaId = Protobuf.MapAreaId;
		}
		if (Protobuf.HasMaxMapAreaId)
		{
			ECSData.MaxMapAreaId = Protobuf.MaxMapAreaId;
		}
		if (Protobuf.HasMaxMapId)
		{
			ECSData.MaxMapId = Protobuf.MaxMapId;
		}
		if (Protobuf.HasMapId)
		{
			ECSData.MapId = Protobuf.MapId;
		}
		if (Protobuf.HasDemo820MapIdx)
		{
			ECSData.Demo820MapIdx = Protobuf.Demo820MapIdx;
		}
		if (Protobuf.HasDefaultShortcutsPosition)
		{
			ECSData.DefaultShortcutsPosition = Protobuf.DefaultShortcutsPosition;
		}
		foreach (DictDeltaMsgInt_GSUnitBookData item in Protobuf.UnitBookDataDic)
		{
			GSUnitBookData gSUnitBookData = new GSUnitBookData();
			if (gSUnitBookData == null)
			{
				gSUnitBookData = new GSUnitBookData();
			}
			if (item.Value != null)
			{
				if (item.Value.HasIsFirstSightRead)
				{
					gSUnitBookData.IsFirstSightRead = item.Value.IsFirstSightRead;
				}
				if (item.Value.HasIsStory1Read)
				{
					gSUnitBookData.IsStory1Read = item.Value.IsStory1Read;
				}
				if (item.Value.HasMIParamFirst)
				{
					gSUnitBookData.MIParamFirst = item.Value.MIParamFirst;
				}
				if (item.Value.HasMIParamFull)
				{
					gSUnitBookData.MIParamFull = item.Value.MIParamFull;
				}
			}
			ECSData.UnitBookDataDic[item.Key] = gSUnitBookData;
		}
		foreach (ListDeltaMsgInt surprisePerformed in Protobuf.SurprisePerformedList)
		{
			int oneItem = 0;
			if (surprisePerformed.HasValue)
			{
				oneItem = surprisePerformed.Value;
			}
			ECSData.SurprisePerformedList.Add(oneItem);
		}
	}

	public static void DeSerializeBPC_TransData(BPC_TransData ECSData, GurGsPersistent.BPC_TransData Protobuf)
	{
		if (Protobuf.HasCurActorResId)
		{
			ECSData.CurActorResId = Protobuf.CurActorResId;
		}
	}

	public static void DeSerializeBPC_RebirthPointData(BPC_RebirthPointData ECSData, GurGsPersistent.BPC_RebirthPointData Protobuf)
	{
		if (ECSData.CurrentBirthPoint == null)
		{
			ECSData.CurrentBirthPoint = new FBirthPointInfo();
		}
		if (Protobuf.CurrentBirthPoint != null)
		{
			if (Protobuf.CurrentBirthPoint.HasPointType)
			{
				ECSData.CurrentBirthPoint.PointType = (EBirthPointType)Protobuf.CurrentBirthPoint.PointType;
			}
			if (Protobuf.CurrentBirthPoint.HasPointID)
			{
				ECSData.CurrentBirthPoint.PointID = Protobuf.CurrentBirthPoint.PointID;
			}
		}
		foreach (ListDeltaMsgInt activedRebirthPoint in Protobuf.ActivedRebirthPointList)
		{
			int oneItem = 0;
			if (activedRebirthPoint.HasValue)
			{
				oneItem = activedRebirthPoint.Value;
			}
			ECSData.ActivedRebirthPointList.Add(oneItem);
		}
		foreach (ListDeltaMsgInt blockedRebirthPoint in Protobuf.BlockedRebirthPointList)
		{
			int oneItem2 = 0;
			if (blockedRebirthPoint.HasValue)
			{
				oneItem2 = blockedRebirthPoint.Value;
			}
			ECSData.BlockedRebirthPointList.Add(oneItem2);
		}
		foreach (DictDeltaMsgInt_Int item in Protobuf.CurrentRebirthPointIDMap)
		{
			int value = 0;
			if (item.HasValue)
			{
				value = item.Value;
			}
			ECSData.CurrentRebirthPointIDMap[item.Key] = value;
		}
		if (Protobuf.HasLastRebirthPointTime)
		{
			ECSData.LastRebirthPointTime = Protobuf.LastRebirthPointTime;
		}
	}

	public static void DeSerializeBUCEntity(UObject WorldCtx, int LevelID, string Guid, Entity Entity)
	{
		if (BGU_DataUtil.GetGameInstanceReadonlyData<BIC_PersistentECSData, BIC_PersistentECSData>(WorldCtx).FindOrAllocBUCDataByGuid(Guid, out var Ret))
		{
			BUC_ActorInitData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorInitData>(Entity);
			if (readOnlyData != null && Ret.BUCActorInitData != null)
			{
				DeSerializeBUC_ActorInitData(readOnlyData, Ret.BUCActorInitData);
			}
			BUC_LifeSavingData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_LifeSavingData>(Entity);
			if (readOnlyData2 != null && Ret.BUCLifeSavingData != null)
			{
				DeSerializeBUC_LifeSavingData(readOnlyData2, Ret.BUCLifeSavingData);
			}
			BUC_ReplicateTestData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_ReplicateTestData>(Entity);
			if (readOnlyData3 != null && Ret.BUCReplicateTestData != null)
			{
				DeSerializeBUC_ReplicateTestData(readOnlyData3, Ret.BUCReplicateTestData);
			}
			BUC_CollectionData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_CollectionData>(Entity);
			if (readOnlyData4 != null && Ret.BUCCollectionData != null)
			{
				DeSerializeBUC_CollectionData(readOnlyData4, Ret.BUCCollectionData);
			}
			BUC_InteractData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(Entity);
			if (readOnlyData5 != null && Ret.BUCInteractData != null)
			{
				DeSerializeBUC_InteractData(readOnlyData5, Ret.BUCInteractData);
			}
			BUC_GamePlusSpawnData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BUC_GamePlusSpawnData>(Entity);
			if (readOnlyData6 != null && Ret.BUCGamePlusSpawnData != null)
			{
				DeSerializeBUC_GamePlusSpawnData(readOnlyData6, Ret.BUCGamePlusSpawnData);
			}
			BUC_TaskCollectionData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<BUC_TaskCollectionData>(Entity);
			if (readOnlyData7 != null && Ret.BUCTaskCollectionData != null)
			{
				DeSerializeBUC_TaskCollectionData(readOnlyData7, Ret.BUCTaskCollectionData);
			}
		}
	}

	public static void DeSerializeBPCEntity(UObject WorldCtx, Entity Entity)
	{
		PersistentBPCData persistentBPCData = BGU_DataUtil.GetGameInstanceReadonlyData<BIC_PersistentECSData, BIC_PersistentECSData>(WorldCtx).GetPersistentBPCData();
		BPC_GeoInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_GeoInfoData>(Entity);
		if (readOnlyData != null && persistentBPCData.BPCGeoInfoData != null)
		{
			DeSerializeBPC_GeoInfoData(readOnlyData, persistentBPCData.BPCGeoInfoData);
		}
		BPC_MapSymbolData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BPC_MapSymbolData>(Entity);
		if (readOnlyData2 != null && persistentBPCData.BPCMapSymbolData != null)
		{
			DeSerializeBPC_MapSymbolData(readOnlyData2, persistentBPCData.BPCMapSymbolData);
		}
		BPC_PlayerAttrData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerAttrData>(Entity);
		if (readOnlyData3 != null && persistentBPCData.BPCPlayerAttrData != null)
		{
			DeSerializeBPC_PlayerAttrData(readOnlyData3, persistentBPCData.BPCPlayerAttrData);
		}
		BPC_PlayerRoleData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(Entity);
		if (readOnlyData4 != null && persistentBPCData.BPCPlayerRoleData != null)
		{
			DeSerializeBPC_PlayerRoleData(readOnlyData4, persistentBPCData.BPCPlayerRoleData);
		}
		BPC_TransData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BPC_TransData>(Entity);
		if (readOnlyData5 != null && persistentBPCData.BPCTransData != null)
		{
			DeSerializeBPC_TransData(readOnlyData5, persistentBPCData.BPCTransData);
		}
		BPC_RebirthPointData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BPC_RebirthPointData>(Entity);
		if (readOnlyData6 != null && persistentBPCData.BPCRebirthPointData != null)
		{
			DeSerializeBPC_RebirthPointData(readOnlyData6, persistentBPCData.BPCRebirthPointData);
		}
	}

	public static void DeSerializeBGCEntity(UObject WorldCtx, Entity Entity)
	{
		PersistentBGCData persistentBGCData = BGU_DataUtil.GetGameInstanceReadonlyData<BIC_PersistentECSData, BIC_PersistentECSData>(WorldCtx).GetPersistentBGCData();
		BGC_CollectionGroupData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CollectionGroupData>(Entity);
		if (readOnlyData != null && persistentBGCData.BGCCollectionGroupData != null)
		{
			DeSerializeBGC_CollectionGroupData(readOnlyData, persistentBGCData.BGCCollectionGroupData);
		}
		BGC_GameStateTestData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BGC_GameStateTestData>(Entity);
		if (readOnlyData2 != null && persistentBGCData.BGCGameStateTestData != null)
		{
			DeSerializeBGC_GameStateTestData(readOnlyData2, persistentBGCData.BGCGameStateTestData);
		}
		BGC_OnlineAssistData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BGC_OnlineAssistData>(Entity);
		if (readOnlyData3 != null && persistentBGCData.BGCOnlineAssistData != null)
		{
			DeSerializeBGC_OnlineAssistData(readOnlyData3, persistentBGCData.BGCOnlineAssistData);
		}
		BGC_PigsyStoryData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BGC_PigsyStoryData>(Entity);
		if (readOnlyData4 != null && persistentBGCData.BGCPigsyStoryData != null)
		{
			DeSerializeBGC_PigsyStoryData(readOnlyData4, persistentBGCData.BGCPigsyStoryData);
		}
		BGC_PlayerDeathData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BGC_PlayerDeathData>(Entity);
		if (readOnlyData5 != null && persistentBGCData.BGCPlayerDeathData != null)
		{
			DeSerializeBGC_PlayerDeathData(readOnlyData5, persistentBGCData.BGCPlayerDeathData);
		}
		BGC_PlayerGuideData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BGC_PlayerGuideData>(Entity);
		if (readOnlyData6 != null && persistentBGCData.BGCPlayerGuideData != null)
		{
			DeSerializeBGC_PlayerGuideData(readOnlyData6, persistentBGCData.BGCPlayerGuideData);
		}
	}
}
