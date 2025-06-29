using System.Collections.Generic;
using System.Reflection;
using ArchiveB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class GameDataSnapShotMgr
{
	public class GameDataSnapShot
	{
		public Dictionary<string, List<ActorECSSnapShotData>> AllActorsDict = new Dictionary<string, List<ActorECSSnapShotData>>();

		public GlobalECSSnapShotData GlobalECSSnapShotData = new GlobalECSSnapShotData();
	}

	public class GameDataJsonData
	{
		public FUStBEDArchivesData ArchivesData;

		public GameDataSnapShot GameDataSnapShot;
	}

	public static GameDataSnapShot Instance = new GameDataSnapShot();

	public static void DoGenGlobalGameDataSnapData(AActor Player)
	{
		GlobalECSSnapShotData globalECSSnapShotData = new GlobalECSSnapShotData();
		globalECSSnapShotData.BGC_LevelBattleData = GenBGC_LevelBattleData(Player);
		Instance.GlobalECSSnapShotData = globalECSSnapShotData;
	}

	public static void DoGenGameDataSnapData(AActor Owner, string Type)
	{
		ActorECSSnapShotData actorECSSnapShotData = new ActorECSSnapShotData();
		actorECSSnapShotData.ExtrolData = new SnapShotExtraData();
		actorECSSnapShotData.ExtrolData.ActorName = Owner.GetFName().ToString();
		actorECSSnapShotData.BUC_ActorTransformInfoData = GenBUC_ActorTransformInfoData(Owner);
		actorECSSnapShotData.BUC_AttrContainer = GenBUC_AttrContainer(Owner);
		actorECSSnapShotData.BUC_BuffData = GenBUC_BuffData(Owner);
		actorECSSnapShotData.BUC_GuidData = GenBUC_GuidData(Owner);
		actorECSSnapShotData.BUC_MasterData = GenBUC_MasterData(Owner);
		actorECSSnapShotData.BUC_PartMgrData = GenBUC_PartMgrData(Owner);
		actorECSSnapShotData.BUC_PatrolData = GenBUC_PatrolData(Owner);
		actorECSSnapShotData.BUC_SimpleStateData = GenBUC_SimpleStateData(Owner);
		actorECSSnapShotData.BUC_UnitStateData = GenBUC_UnitStateData(Owner);
		actorECSSnapShotData.BUC_CollectionData = GenBUC_CollectionData(Owner);
		actorECSSnapShotData.BUC_DropItemData = GenBUC_DropItemData(Owner);
		actorECSSnapShotData.BUC_RebirthPointData = GenBUC_RebirthPointData(Owner);
		actorECSSnapShotData.ActorTransformSnapShotData = GenActorTransformSnapShotData(Owner);
		if (!Instance.AllActorsDict.ContainsKey(Type))
		{
			Instance.AllActorsDict.Add(Type, new List<ActorECSSnapShotData>());
		}
		Instance.AllActorsDict[Type].Add(actorECSSnapShotData);
	}

	public static BGC_LevelBattleDataSnapShot GenBGC_LevelBattleData(AActor Player)
	{
		BGC_LevelBattleDataSnapShot bGC_LevelBattleDataSnapShot = new BGC_LevelBattleDataSnapShot();
		AGameModeBase gameMode = UGameplayStatics.GetGameMode(Player.World);
		AGameStateBase gameState = UGameplayStatics.GetGameState(Player.World);
		BGC_LevelBattleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_LevelBattleData>(gameMode);
		if (readOnlyData == null)
		{
			readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_LevelBattleData>(gameState);
		}
		if (readOnlyData == null)
		{
			bGC_LevelBattleDataSnapShot.GamePlayerNum = readOnlyData.GamePlayerNum;
		}
		return bGC_LevelBattleDataSnapShot;
	}

	public static BUC_ActorTransformInfoDataSnapShot GenBUC_ActorTransformInfoData(AActor Owner)
	{
		BUC_ActorTransformInfoDataSnapShot bUC_ActorTransformInfoDataSnapShot = new BUC_ActorTransformInfoDataSnapShot();
		BUC_ActorTransformInfoData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActorTransformInfoData>(Owner);
		if (unPersistentReadOnlyData == null)
		{
			return null;
		}
		bUC_ActorTransformInfoDataSnapShot.NeedUpdate = unPersistentReadOnlyData.NeedUpdate;
		bUC_ActorTransformInfoDataSnapShot.OriginTransformX = unPersistentReadOnlyData.OriginTransform.GetLocation().X;
		bUC_ActorTransformInfoDataSnapShot.OriginTransformY = unPersistentReadOnlyData.OriginTransform.GetLocation().Y;
		bUC_ActorTransformInfoDataSnapShot.OriginTransformZ = unPersistentReadOnlyData.OriginTransform.GetLocation().Z;
		bUC_ActorTransformInfoDataSnapShot.NextUpdateTransformX = unPersistentReadOnlyData.NextUpdateTransform.GetLocation().X;
		bUC_ActorTransformInfoDataSnapShot.NextUpdateTransformY = unPersistentReadOnlyData.NextUpdateTransform.GetLocation().Y;
		bUC_ActorTransformInfoDataSnapShot.NextUpdateTransformZ = unPersistentReadOnlyData.NextUpdateTransform.GetLocation().Z;
		bUC_ActorTransformInfoDataSnapShot.bSweep = unPersistentReadOnlyData.bSweep;
		bUC_ActorTransformInfoDataSnapShot.bTeleport = unPersistentReadOnlyData.bTeleport;
		return bUC_ActorTransformInfoDataSnapShot;
	}

	public static BUC_AttrContainerSnapShot GenBUC_AttrContainer(AActor Owner)
	{
		BUC_AttrContainerSnapShot bUC_AttrContainerSnapShot = new BUC_AttrContainerSnapShot();
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_AttrContainerSnapShot.FloatAttrs = readOnlyData.FloatAttrs.RawData.ValueList;
		return bUC_AttrContainerSnapShot;
	}

	public static BUC_BuffDataSnapShot GenBUC_BuffData(AActor Owner)
	{
		BUC_BuffDataSnapShot bUC_BuffDataSnapShot = new BUC_BuffDataSnapShot();
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		foreach (KeyValuePair<int, BuffInstData> item in readOnlyData.BuffInstsDict)
		{
			BuffInstDataSnapShot buffInstDataSnapShot = new BuffInstDataSnapShot();
			buffInstDataSnapShot.BuffID = item.Value.BuffID;
			buffInstDataSnapShot.DelayTime = item.Value.DelayTime;
			buffInstDataSnapShot.LeftTime = item.Value.LeftTime;
			buffInstDataSnapShot.Layer = item.Value.Layer;
			BUC_GuidData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_GuidData>(EntitySharedRefFuncLib.Actor(item.Value.RootCasterRef));
			if (readOnlyData2 != null)
			{
				buffInstDataSnapShot.RootCasterRef_Guid = readOnlyData2.GetFinalGuid();
			}
			BUC_GuidData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_GuidData>(EntitySharedRefFuncLib.Actor(item.Value.CasterRef));
			if (readOnlyData3 != null)
			{
				buffInstDataSnapShot.CasterRef_Guid = readOnlyData3.GetFinalGuid();
			}
			BUC_GuidData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_GuidData>(EntitySharedRefFuncLib.Actor(item.Value.OwnerRef));
			if (readOnlyData4 != null)
			{
				buffInstDataSnapShot.OwnerRef_Guid = readOnlyData4.GetFinalGuid();
			}
			buffInstDataSnapShot.Duration = item.Value.Duration;
			buffInstDataSnapShot.BuffSourceType = item.Value.BuffSourceType;
			bUC_BuffDataSnapShot.BuffInstsDict.Add(bUC_BuffDataSnapShot.BuffInstsDict.Count, buffInstDataSnapShot);
		}
		bUC_BuffDataSnapShot.bShouldUpdateBuffTime = readOnlyData.bShouldUpdateBuffTime;
		return bUC_BuffDataSnapShot;
	}

	public static BUC_GuidDataSnapShot GenBUC_GuidData(AActor Owner)
	{
		BUC_GuidDataSnapShot bUC_GuidDataSnapShot = new BUC_GuidDataSnapShot();
		BUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_GuidData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_GuidDataSnapShot.UnitRandomGuid = readOnlyData.UnitRandomGuid;
		return bUC_GuidDataSnapShot;
	}

	public static BUC_MasterDataSnapShot GenBUC_MasterData(AActor Owner)
	{
		BUC_MasterDataSnapShot bUC_MasterDataSnapShot = new BUC_MasterDataSnapShot();
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		BUC_GuidData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_GuidData>(EntitySharedRefFuncLib.Actor(typeof(BUC_MasterData).GetProperty("_Master", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(readOnlyData) as EntitySharedRef));
		if (readOnlyData2 != null)
		{
			bUC_MasterDataSnapShot._Master_Guid = readOnlyData2.GetFinalGuid();
		}
		return bUC_MasterDataSnapShot;
	}

	public static BUC_PartMgrDataSnapShot GenBUC_PartMgrData(AActor Owner)
	{
		BUC_PartMgrDataSnapShot bUC_PartMgrDataSnapShot = new BUC_PartMgrDataSnapShot();
		BUC_PartMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_PartMgrData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_PartMgrDataSnapShot.PartInfoDataDic = readOnlyData.PartInfoDataDic;
		return bUC_PartMgrDataSnapShot;
	}

	public static BUC_PatrolDataSnapShot GenBUC_PatrolData(AActor Owner)
	{
		BUC_PatrolDataSnapShot bUC_PatrolDataSnapShot = new BUC_PatrolDataSnapShot();
		BUC_PatrolData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PatrolData>(Owner);
		if (unPersistentReadOnlyData == null)
		{
			return null;
		}
		bUC_PatrolDataSnapShot.PatrolType = unPersistentReadOnlyData.PatrolType;
		bUC_PatrolDataSnapShot.bDisableRestartOnLeaveFight = unPersistentReadOnlyData.bDisableRestartOnLeaveFight;
		bUC_PatrolDataSnapShot.bDisableRestartOnReset = unPersistentReadOnlyData.bDisableRestartOnReset;
		return bUC_PatrolDataSnapShot;
	}

	public static BUC_SimpleStateDataSnapShot GenBUC_SimpleStateData(AActor Owner)
	{
		BUC_SimpleStateDataSnapShot bUC_SimpleStateDataSnapShot = new BUC_SimpleStateDataSnapShot();
		BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_SimpleStateDataSnapShot.SimpleStates = readOnlyData.SimpleStates.RawData.ValueList;
		return bUC_SimpleStateDataSnapShot;
	}

	public static BUC_UnitStateDataSnapShot GenBUC_UnitStateData(AActor Owner)
	{
		BUC_UnitStateDataSnapShot bUC_UnitStateDataSnapShot = new BUC_UnitStateDataSnapShot();
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_UnitStateDataSnapShot.UnitStates = readOnlyData.UnitStates.RawData.ValueList;
		return bUC_UnitStateDataSnapShot;
	}

	public static BUC_CollectionDataSnapShot GenBUC_CollectionData(AActor Owner)
	{
		BUC_CollectionDataSnapShot bUC_CollectionDataSnapShot = new BUC_CollectionDataSnapShot();
		BUC_CollectionData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CollectionData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_CollectionDataSnapShot.CollectionDropId = readOnlyData.CollectionDropId;
		bUC_CollectionDataSnapShot.GroupId = readOnlyData.GroupId;
		bUC_CollectionDataSnapShot.NeedDestroy = readOnlyData.NeedDestroy;
		bUC_CollectionDataSnapShot.NeedHidden = readOnlyData.NeedHidden;
		return bUC_CollectionDataSnapShot;
	}

	public static BUC_DropItemDataSnapShot GenBUC_DropItemData(AActor Owner)
	{
		BUC_DropItemDataSnapShot bUC_DropItemDataSnapShot = new BUC_DropItemDataSnapShot();
		BUC_DropItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DropItemData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_DropItemDataSnapShot.ItemResID = readOnlyData.ItemResID;
		return bUC_DropItemDataSnapShot;
	}

	public static BUC_RebirthPointDataSnapShot GenBUC_RebirthPointData(AActor Owner)
	{
		BUC_RebirthPointDataSnapShot bUC_RebirthPointDataSnapShot = new BUC_RebirthPointDataSnapShot();
		BUC_RebirthPointData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_RebirthPointData>(Owner);
		if (readOnlyData == null)
		{
			return null;
		}
		bUC_RebirthPointDataSnapShot.RebirthPointConfigID = readOnlyData.RebirthPointConfigID;
		bUC_RebirthPointDataSnapShot.ActiveSetCurrentRebirthPoint = readOnlyData.ActiveSetCurrentRebirthPoint;
		bUC_RebirthPointDataSnapShot.bActiveState = readOnlyData.bActiveState;
		return bUC_RebirthPointDataSnapShot;
	}

	public static ActorTransformSnapShotData GenActorTransformSnapShotData(AActor Owner)
	{
		ActorTransformSnapShotData actorTransformSnapShotData = new ActorTransformSnapShotData();
		actorTransformSnapShotData.ActorIsNullOrDestory = Owner.IsNullOrDestroyed();
		if (!Owner.IsNullOrDestroyed())
		{
			actorTransformSnapShotData.TransformLoctionX = Owner.GetActorLocation().X;
			actorTransformSnapShotData.TransformLoctionY = Owner.GetActorLocation().Y;
			actorTransformSnapShotData.TransformLoctionZ = Owner.GetActorLocation().Z;
		}
		return actorTransformSnapShotData;
	}

	public static void InstanceClear()
	{
		Instance.AllActorsDict.Clear();
	}

	public static GameDataJsonData GenJsonData(UObject World)
	{
		return new GameDataJsonData
		{
			ArchivesData = BGW_ExportDataFuncs.ExportArchiveData(World),
			GameDataSnapShot = BGW_ExportDataFuncs.ExportECSDataSnapShot(World)
		};
	}
}
