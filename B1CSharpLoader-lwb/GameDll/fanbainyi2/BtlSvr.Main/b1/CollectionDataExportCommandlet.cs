using System.Collections.Generic;
using System.IO;
using b1.GSFile;
using BtlB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class CollectionDataExportCommandlet
{
	public static void DoProces(string ExportParams)
	{
		string text = ExportParams.Split('!')[0];
		if (text == "All")
		{
			foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
			{
				if (item.IsFormalLevel == YesNoType.Yes)
				{
					ExportLevelData(item.Path);
				}
			}
			return;
		}
		ExportLevelData(text);
	}

	private static void ExportLevelData(string MapName)
	{
		Directory.CreateDirectory(GSEFileUtil.GetTmpPath());
		UGSE_EditorFuncLib.GetPackagesByName(MapName, out var OutPackageNames);
		if (OutPackageNames == null || OutPackageNames.Count == 0)
		{
			return;
		}
		string text = OutPackageNames[0].ToString();
		if (!UGSE_EditorFuncLib.OpenLevelInEditor(text, bOnlyPersistentLevel: false))
		{
			return;
		}
		UWorld uWorld = UObject.LoadObject<UWorld>(null, text);
		if (uWorld != null)
		{
			List<AActor> allActorsInWorld = UBGUFunctionLibrary.GetAllActorsInWorld(uWorld);
			int num = 0;
			foreach (AActor item in allActorsInWorld)
			{
				if (item as BGUCollectionActorCS != null)
				{
					num++;
				}
			}
			string text2 = uWorld.GetFName().ToString();
			if (num == 0)
			{
				BGW_LogUtil.LogError("当前地图未监测到任何采集物，请检查打开的地图是否正确: " + text2);
				return;
			}
			GenCollectionActorData(allActorsInWorld, uWorld);
			BGW_LogUtil.LogError("导出完毕");
		}
		else
		{
			BGW_LogUtil.LogError("导出失败");
		}
	}

	private static void GenCollectionActorData(List<AActor> AllActors, UWorld CurWorld)
	{
		int num = 1;
		TBFUStCollectionSpawnInfoDesc tBFUStCollectionSpawnInfoDesc = new TBFUStCollectionSpawnInfoDesc();
		string text = CurWorld.GetFName().ToString();
		int levelIdByName = BGUFuncLibMap.GetLevelIdByName(text);
		foreach (AActor AllActor in AllActors)
		{
			BGUCollectionActorCS bGUCollectionActorCS = AllActor as BGUCollectionActorCS;
			if (bGUCollectionActorCS != null)
			{
				string name = bGUCollectionActorCS.GetName();
				bGUCollectionActorCS.GetActorRotation();
				string guid = BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCollectionActorCS);
				BUS_CollectionConfigComp componentByClass = bGUCollectionActorCS.GetComponentByClass<BUS_CollectionConfigComp>();
				_ = componentByClass.CollectionDropID;
				int groupID = componentByClass.GroupID;
				int eventId = (componentByClass.OverWriterEventId ? componentByClass.EventId : 0);
				int plusEventId = (componentByClass.OverWriterEventId ? componentByClass.PlusEventId : 0);
				int chiefEventId = (componentByClass.OverWriterEventId ? componentByClass.ChiefEventId : 0);
				FUStCollectionSpawnInfoDesc fUStCollectionSpawnInfoDesc = new FUStCollectionSpawnInfoDesc();
				fUStCollectionSpawnInfoDesc.CollectionName = name;
				fUStCollectionSpawnInfoDesc.MapName = text;
				fUStCollectionSpawnInfoDesc.MapId = levelIdByName;
				fUStCollectionSpawnInfoDesc.GroupId = groupID;
				fUStCollectionSpawnInfoDesc.Guid = guid;
				fUStCollectionSpawnInfoDesc.SubLevel = "";
				fUStCollectionSpawnInfoDesc.TaskId = 0;
				fUStCollectionSpawnInfoDesc.EventId = eventId;
				fUStCollectionSpawnInfoDesc.PlusEventId = plusEventId;
				fUStCollectionSpawnInfoDesc.ChiefEventId = chiefEventId;
				tBFUStCollectionSpawnInfoDesc.List.Add(fUStCollectionSpawnInfoDesc);
				num++;
			}
		}
		GenCollectionTBTable(tBFUStCollectionSpawnInfoDesc, text);
	}

	private static void GenCollectionTBTable(TBFUStCollectionSpawnInfoDesc CollectionSpawnInfoList, string CurMapName)
	{
		string path = FPaths.Combine(FPaths.ProjectContentDir, "00Main\\PBTable\\NoneRuntime\\FUStCollectionSpawnInfoDesc-" + CurMapName + ".data");
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		FileStream fileStream = File.Create(path);
		byte[] array = new byte[CollectionSpawnInfoList.CalculateSize()];
		CollectionSpawnInfoList.WriteTo(new CodedOutputStream(array));
		fileStream.Write(array, 0, CollectionSpawnInfoList.CalculateSize());
		fileStream.Close();
		fileStream.Dispose();
	}
}
