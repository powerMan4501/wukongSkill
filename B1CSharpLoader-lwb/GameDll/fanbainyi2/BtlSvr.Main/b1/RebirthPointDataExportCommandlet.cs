using System.Collections.Generic;
using System.IO;
using b1.GSFile;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class RebirthPointDataExportCommandlet
{
	private static TBRebirthPointPosDesc RebirthPointPosList = new TBRebirthPointPosDesc();

	private static BPC_MapAreaData BPCMapAreaData = new BPC_MapAreaData();

	public static void DoProces(string ExportParams)
	{
		RebirthPointPosList = new TBRebirthPointPosDesc();
		string text = ExportParams.Split('!')[0];
		InitTBData();
		if (text == "All")
		{
			foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
			{
				if (item.IsFormalLevel == YesNoType.Yes)
				{
					ExportLevelData(item.Path);
				}
			}
		}
		else
		{
			ExportLevelData(text);
		}
		GenRebirthPointPosTBTable(RebirthPointPosList);
	}

	private static void InitTBData()
	{
		GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().LoadData();
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
		if (UGSE_EditorFuncLib.OpenLevelInEditor(text, bOnlyPersistentLevel: false))
		{
			UWorld uWorld = UObject.LoadObject<UWorld>(null, text);
			if (uWorld != null)
			{
				List<AActor> allActorsInWorld = UBGUFunctionLibrary.GetAllActorsInWorld(uWorld);
				uWorld.GetFName().ToString();
				GenRebirthPointPosData(allActorsInWorld, uWorld);
				BGW_LogUtil.LogError("导出完毕");
			}
			else
			{
				BGW_LogUtil.LogError("导出失败");
			}
		}
	}

	private static void GenRebirthPointPosData(List<AActor> AllActors, UWorld CurWorld)
	{
		int num = 1;
		BGUFuncLibMap.GetLevelIdByName(CurWorld.GetFName().ToString());
		foreach (AActor AllActor in AllActors)
		{
			BGURebirthPointBase bGURebirthPointBase = AllActor as BGURebirthPointBase;
			if (bGURebirthPointBase != null)
			{
				int rebirthPointID = bGURebirthPointBase.GetComponentByClass<BUS_RebirthPointConfigComp>().RebirthPointConfig.RebirthPointID;
				FVector actorLocation = bGURebirthPointBase.GetActorLocation();
				RebirthPointPosDesc rebirthPointPosDesc = new RebirthPointPosDesc();
				FUStRebirthPointDesc fUStRebirthPointDesc = GameDBRuntime.GetFUStRebirthPointDesc(rebirthPointID);
				if (fUStRebirthPointDesc != null)
				{
					BPCMapAreaData.EditorToolExportLocationData(fUStRebirthPointDesc.MapID, actorLocation, CurWorld, out var MapSpriteId, out var MapPosition);
					rebirthPointPosDesc.Id = rebirthPointID;
					rebirthPointPosDesc.PosX = MapPosition.X;
					rebirthPointPosDesc.PosY = MapPosition.Y;
					rebirthPointPosDesc.MapSpriteId = MapSpriteId;
					RebirthPointPosList.List.Add(rebirthPointPosDesc);
					num++;
				}
			}
		}
	}

	private static void GenRebirthPointPosTBTable(TBRebirthPointPosDesc RebirthPointPosDesc)
	{
		string path = FPaths.Combine(FPaths.ProjectContentDir, "00Main\\PBTable\\Runtime\\RebirthPointPosDesc.data");
		TBRebirthPointPosDesc tBRebirthPointPosDesc = new TBRebirthPointPosDesc();
		using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
		{
			tBRebirthPointPosDesc.MergeFrom(fileStream);
			fileStream.Close();
		}
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		FileStream fileStream2 = File.Create(path);
		byte[] array = new byte[RebirthPointPosDesc.CalculateSize()];
		RebirthPointPosDesc.WriteTo(new CodedOutputStream(array));
		fileStream2.Write(array, 0, RebirthPointPosDesc.CalculateSize());
		fileStream2.Close();
		fileStream2.Dispose();
		DiffRebirthPointPosTBTable(tBRebirthPointPosDesc, RebirthPointPosDesc);
	}

	private static void DiffRebirthPointPosTBTable(TBRebirthPointPosDesc TBOldRebirthPointPosDesc, TBRebirthPointPosDesc TBNewRebirthPointPosDesc)
	{
		string text = "";
		int count = TBOldRebirthPointPosDesc.List.Count;
		if (TBOldRebirthPointPosDesc.List.Count != TBNewRebirthPointPosDesc.List.Count)
		{
			text += $"有数据变更，原表格数据量:{TBOldRebirthPointPosDesc.List.Count} ，新表格数据量:{TBNewRebirthPointPosDesc.List.Count}\n";
			if (TBNewRebirthPointPosDesc.List.Count > TBOldRebirthPointPosDesc.List.Count)
			{
				count = TBNewRebirthPointPosDesc.List.Count;
				text += "有新增土地庙信息\n";
			}
			else
			{
				text += "有土地庙信息被删除\n";
			}
		}
		for (int i = 0; i < count; i++)
		{
			if (TBNewRebirthPointPosDesc.List.Count > i && TBOldRebirthPointPosDesc.List.Count > i)
			{
				RebirthPointPosDesc rebirthPointPosDesc = TBOldRebirthPointPosDesc.List[i];
				RebirthPointPosDesc rebirthPointPosDesc2 = TBNewRebirthPointPosDesc.List[i];
				if (rebirthPointPosDesc.Id != rebirthPointPosDesc2.Id || rebirthPointPosDesc.PosX != rebirthPointPosDesc2.PosX || rebirthPointPosDesc.PosY != rebirthPointPosDesc2.PosY || rebirthPointPosDesc.MapSpriteId != rebirthPointPosDesc2.MapSpriteId)
				{
					text = text + $"有数据变更：旧数据： {rebirthPointPosDesc.Id}，{rebirthPointPosDesc.PosX}，{rebirthPointPosDesc.PosY}，{rebirthPointPosDesc.MapSpriteId}," + $"新数据：{rebirthPointPosDesc2.Id}，{rebirthPointPosDesc2.PosX}，{rebirthPointPosDesc2.PosY}，{rebirthPointPosDesc2.MapSpriteId}\n";
				}
			}
			else if (TBNewRebirthPointPosDesc.List.Count > i)
			{
				RebirthPointPosDesc rebirthPointPosDesc3 = TBNewRebirthPointPosDesc.List[i];
				text += $"有数据新增：{rebirthPointPosDesc3.Id}，{rebirthPointPosDesc3.PosX}，{rebirthPointPosDesc3.PosY}，{rebirthPointPosDesc3.MapSpriteId}\n";
			}
			else
			{
				RebirthPointPosDesc rebirthPointPosDesc4 = TBOldRebirthPointPosDesc.List[i];
				text += $"有数据被删除：{rebirthPointPosDesc4.Id}，{rebirthPointPosDesc4.PosX}，{rebirthPointPosDesc4.PosY}，{rebirthPointPosDesc4.MapSpriteId}\n";
			}
		}
		if (text != "")
		{
			string path = FPaths.Combine(FPaths.ProjectPersistentDownloadDir, "DiffRebirthPointTxt.txt");
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			File.WriteAllText(path, text);
		}
	}
}
