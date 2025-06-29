using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ArchiveB1;
using b1.Localization;
using b1.Protobuf.DataAPI;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using CsB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class SpawnActorCommandlet
{
	private enum ItemType
	{
		Collection,
		Monster,
		Task
	}

	private GSMapAreaBaseData MapAreaBaseData;

	private GSMapAreaDetailData MapAreaDetailData;

	private Dictionary<string, MapAreaConfigDesc> MapAreaDescDict = new Dictionary<string, MapAreaConfigDesc>();

	private Dictionary<int, Dictionary<ItemType, int>> ProduceDict = new Dictionary<int, Dictionary<ItemType, int>>();

	private string ExportPath = FPaths.Combine(UPaths.ProjectDir(), "GSDataTable/ZTable_GSExportData");

	public void DoProces(string args, UObject World)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStCollectionSpawnInfoDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStCollectionSpawnGroupDesc>();
		TBMapAreaConfigDesc all = GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().GetAll();
		for (int i = 0; i < all.List.Count; i++)
		{
			MapAreaConfigDesc mapAreaConfigDesc = all.List[i];
			MapAreaDescDict[string.Format($"{mapAreaConfigDesc.LevelId}_{mapAreaConfigDesc.AreaId}")] = mapAreaConfigDesc;
		}
		UWorld uWorld = World as UWorld;
		if (uWorld != null)
		{
			List<AActor> allActorsInWorld = UBGUFunctionLibrary.GetAllActorsInWorld(uWorld);
			new Regex("\\w+$");
			string text = uWorld.GetFName().ToString();
			int levelIdByName = BGUFuncLibMap.GetLevelIdByName(text);
			if (levelIdByName == -1)
			{
				throw new Exception("Can not find the corresponding map id in TBLevelDesc!");
			}
			string name = string.Format("{0}/DA_MapArea_Base_{1}.DA_MapArea_Base_{2}", "/Game/00Main/Design/MapArea", levelIdByName, levelIdByName);
			string name2 = string.Format("{0}/DA_MapArea_Detail_{1}.DA_MapArea_Detail_{2}", "/Game/00Main/Design/MapArea", levelIdByName, levelIdByName);
			MapAreaBaseData = UObject.LoadObject<GSMapAreaBaseData>(null, name);
			MapAreaDetailData = UObject.LoadObject<GSMapAreaDetailData>(null, name2);
			GenCollectionActorData(allActorsInWorld, text);
			GenCharacterActorData(allActorsInWorld, text);
			GenInteractiveActorData(allActorsInWorld, text);
			GenAllActorBaseData(allActorsInWorld, text);
			ClcMapItemProduce(allActorsInWorld, text);
		}
	}

	private void FileCheckOut(string FilePath)
	{
		UGSFunclibPerforceSourceControlModule.CheckOutOrAddFile(FilePath);
		if (File.Exists(FilePath))
		{
			File.Delete(FilePath);
		}
	}

	private void GenCollectionActorData(List<AActor> AllActors, string CurMapName)
	{
		string text = FPaths.Combine(ExportPath, CurMapName + "_Collection.csv");
		FileCheckOut(text);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Id,Name,Guid,DropId,AreaName,X,Y,Z");
		int levelIdByName = BGUFuncLibMap.GetLevelIdByName(CurMapName);
		for (int i = 0; i < AllActors.Count; i++)
		{
			BGUCollectionActorCS bGUCollectionActorCS = AllActors[i] as BGUCollectionActorCS;
			if (!(bGUCollectionActorCS != null))
			{
				continue;
			}
			string name = bGUCollectionActorCS.GetName();
			FVector actorLocation = bGUCollectionActorCS.GetActorLocation();
			int areaId = BGUFuncLibMap.GetAreaId(bGUCollectionActorCS);
			string text2 = "";
			if (MapAreaDescDict.TryGetValue($"{levelIdByName}_{areaId}", out var value))
			{
				if (value != null)
				{
					text2 = value.AreaName;
				}
				bGUCollectionActorCS.GetActorRotation();
				string text3 = BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCollectionActorCS);
				int collectionDropID = bGUCollectionActorCS.GetComponentByClass<BUS_CollectionConfigComp>().CollectionDropID;
				stringBuilder.AppendLine($"{i},{name},{text3},{collectionDropID},{text2},{(int)actorLocation.X},{(int)actorLocation.Y},{(int)actorLocation.Z}");
			}
		}
		File.WriteAllText(text, stringBuilder.ToString(), Encoding.UTF8);
	}

	private void GenCharacterActorData(List<AActor> AllActors, string CurMapName)
	{
		string text = FPaths.Combine(ExportPath, CurMapName + "_Character.csv");
		FileCheckOut(text);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Id,Name,DisplayName,Guid,ResId,AreaName,X,Y,Z");
		int levelIdByName = BGUFuncLibMap.GetLevelIdByName(CurMapName);
		for (int i = 0; i < AllActors.Count; i++)
		{
			BGUCharacterCS bGUCharacterCS = AllActors[i] as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				string name = bGUCharacterCS.GetName();
				FVector actorLocation = bGUCharacterCS.GetActorLocation();
				new FVector2D(actorLocation.X, actorLocation.Y);
				int num = 0;
				string text2 = "";
				if (MapAreaDescDict.TryGetValue($"{levelIdByName}_{num}", out var value))
				{
					text2 = value.AreaName;
				}
				bGUCharacterCS.GetActorRotation();
				BUS_ConfigInfoComp componentByClass = bGUCharacterCS.GetComponentByClass<BUS_ConfigInfoComp>();
				int num2 = -1;
				if (componentByClass != null)
				{
					num2 = componentByClass.UnitCDesc.ResID;
				}
				string text3 = BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCharacterCS);
				string displayName = UGSE_EngineFuncLib.GetDisplayName(bGUCharacterCS);
				stringBuilder.AppendLine($"{i},{name},{displayName},{text3},{num2},{text2},{(int)actorLocation.X},{(int)actorLocation.Y},{(int)actorLocation.Z}");
			}
		}
		File.WriteAllText(text, stringBuilder.ToString(), Encoding.UTF8);
	}

	private void GenInteractiveActorData(List<AActor> AllActors, string CurMapName)
	{
		string text = FPaths.Combine(ExportPath, CurMapName + "_Interactive.csv");
		FileCheckOut(text);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Id,Name,Interactive,InteractiveId,AreaName,X,Y,Z");
		int levelIdByName = BGUFuncLibMap.GetLevelIdByName(CurMapName);
		for (int i = 0; i < AllActors.Count; i++)
		{
			BGUInteractiveActorBase bGUInteractiveActorBase = AllActors[i] as BGUInteractiveActorBase;
			if (bGUInteractiveActorBase != null)
			{
				string name = bGUInteractiveActorBase.GetName();
				FVector actorLocation = bGUInteractiveActorBase.GetActorLocation();
				new FVector2D(actorLocation.X, actorLocation.Y);
				int areaId = BGUFuncLibMap.GetAreaId(bGUInteractiveActorBase);
				string text2 = "";
				if (MapAreaDescDict.TryGetValue($"{levelIdByName}_{areaId}", out var value))
				{
					text2 = value.AreaName;
				}
				bGUInteractiveActorBase.GetActorRotation();
				BUS_InteractComp componentByClass = bGUInteractiveActorBase.GetComponentByClass<BUS_InteractComp>();
				int num = -1;
				if (componentByClass != null)
				{
					num = componentByClass.InteractiveUnitID;
				}
				FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(componentByClass.InteractiveUnitID);
				string text3 = "";
				if (interactiveUnitCommDesc != null)
				{
					text3 = interactiveUnitCommDesc.Name.ToFText().ToString();
				}
				stringBuilder.AppendLine($"{i},{name}, {text3},{num},{text2},{(int)actorLocation.X},{(int)actorLocation.Y},{(int)actorLocation.Z}");
			}
		}
		File.WriteAllText(text, stringBuilder.ToString(), Encoding.UTF8);
	}

	private void GenAllActorBaseData(List<AActor> AllActors, string CurMapName)
	{
		string text = FPaths.Combine(ExportPath, CurMapName + "_AllActorBase.csv");
		FileCheckOut(text);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Id,Name,ActorGuid,AreaName,X,Y,Z");
		int levelIdByName = BGUFuncLibMap.GetLevelIdByName(CurMapName);
		for (int i = 0; i < AllActors.Count; i++)
		{
			AActor aActor = AllActors[i];
			if (aActor != null)
			{
				string name = aActor.GetName();
				string actorGuid = BGU_DataUtil.GetActorGuid(aActor);
				FVector actorLocation = aActor.GetActorLocation();
				new FVector2D(actorLocation.X, actorLocation.Y);
				int areaId = BGUFuncLibMap.GetAreaId(aActor);
				string text2 = "";
				if (MapAreaDescDict.TryGetValue($"{levelIdByName}_{areaId}", out var value))
				{
					text2 = value.AreaName;
				}
				stringBuilder.AppendLine($"{i},{name},{actorGuid},{text2},{(int)actorLocation.X},{(int)actorLocation.Y},{(int)actorLocation.Z}");
			}
		}
		File.WriteAllText(text, stringBuilder.ToString(), Encoding.UTF8);
	}

	private void ClcMapItemProduce(List<AActor> AllActors, string CurMapName)
	{
		Dictionary<string, AActor> dictionary = new Dictionary<string, AActor>();
		foreach (AActor AllActor in AllActors)
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(AllActor);
			if (actorGuid != null && !dictionary.ContainsKey(actorGuid))
			{
				dictionary.Add(actorGuid, AllActor);
			}
		}
		string text = FPaths.Combine(ExportPath, CurMapName + "ItemProduce.csv");
		FileCheckOut(text);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("道具id,采集物产出数量,杀怪产出数量,任务产出数量,总计数量");
		ClcCollectionProduce(dictionary, CurMapName);
		ClcMonsterProduce(dictionary, CurMapName);
		foreach (KeyValuePair<int, Dictionary<ItemType, int>> item in ProduceDict)
		{
			item.Value.TryGetValue(ItemType.Collection, out var value);
			item.Value.TryGetValue(ItemType.Monster, out var value2);
			item.Value.TryGetValue(ItemType.Task, out var value3);
			stringBuilder.AppendLine($"{item.Key},{value},{value2},{value3},{value + value2 + value3}");
		}
		File.WriteAllText(text, stringBuilder.ToString(), Encoding.UTF8);
	}

	private FUStCollectionSpawnGroupDesc GetCollectionSpawnInfoDescByGroupId(int GroupId)
	{
		foreach (KeyValuePair<int, FUStCollectionSpawnGroupDesc> item in BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().GetAll())
		{
			if (item.Value.ID == GroupId)
			{
				return item.Value;
			}
		}
		return null;
	}

	private void ClcCollectionProduce(Dictionary<string, AActor> GuidDict, string CurMapName)
	{
		BIC_CollectionGroupData bIC_CollectionGroupData = new BIC_CollectionGroupData();
		new LevelArchiveBaseData();
		bIC_CollectionGroupData.CollectionGroupMgr.InitSpawnActorState(CurMapName, new BIC_PersistentECSData());
		Dictionary<int, CollectionGroupData> collectionGroupData = bIC_CollectionGroupData.CollectionGroupMgr.GetCollectionGroupData();
		if (collectionGroupData == null)
		{
			return;
		}
		foreach (KeyValuePair<int, CollectionGroupData> item in collectionGroupData)
		{
			GetCollectionSpawnInfoDescByGroupId(item.Key);
		}
	}

	private void ClcMonsterProduce(Dictionary<string, AActor> GuidDict, string CurMapName)
	{
		foreach (KeyValuePair<string, AActor> item in GuidDict)
		{
			AActor value = item.Value;
			if (value != null)
			{
				BUS_ConfigInfoComp componentByClass = value.GetComponentByClass<BUS_ConfigInfoComp>();
				if (componentByClass != null)
				{
					int resID = componentByClass.UnitCDesc.ResID;
					new CSMsgBagDropUnitAwardReq().UnitId = resID;
				}
			}
		}
	}
}
