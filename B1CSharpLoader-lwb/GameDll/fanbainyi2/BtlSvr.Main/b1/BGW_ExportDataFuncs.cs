using System.IO;
using ArchiveB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_ExportDataFuncs
{
	public static void WriteJsonStrToFile(string JsonStr, string TargetPath = "ExportGameData.json")
	{
		string text = Path.Combine(FPaths.ProjectPersistentDownloadDir, "ExportGameData");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string path = Path.Combine(text, TargetPath);
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, JsonStr);
	}

	public static FUStBEDArchivesData ExportArchiveData(UObject World)
	{
		return BGW_GameArchiveMgr.Get(World).GMExportArchiveSnapshot();
	}

	public static GameDataSnapShotMgr.GameDataSnapShot ExportECSDataSnapShot(UObject World)
	{
		GameDataSnapShotMgr.InstanceClear();
		IBIC_GlobalActorData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(World);
		if (gameInstanceReadonlyData != null)
		{
			foreach (string actorDataKey in gameInstanceReadonlyData.GetActorDataKeys())
			{
				gameInstanceReadonlyData.GetActorEntity(actorDataKey, out var Entity);
				if (!ECSExtension.ToActor(Entity).IsNullOrDestroyed())
				{
					GameDataSnapShotMgr.DoGenGameDataSnapData(ECSExtension.ToActor(Entity), "AllInitActor");
				}
			}
		}
		ExporrActorDataByType(World);
		ExporrGlobalData(World);
		return GameDataSnapShotMgr.Instance;
	}

	private static void ExporrActorDataByType(UObject World)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(World, UClass.GetClass<ABGUActorBase>());
		AActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass(World, UClass.GetClass<ABGUCharacter>());
		AActor[] array = allActorsOfClass;
		foreach (AActor obj in array)
		{
			GameDataSnapShotMgr.DoGenGameDataSnapData(obj, obj.GetType().FullName);
		}
		array = allActorsOfClass2;
		foreach (AActor obj2 in array)
		{
			GameDataSnapShotMgr.DoGenGameDataSnapData(obj2, obj2.GetType().FullName);
		}
	}

	private static void ExporrGlobalData(UObject World)
	{
		GameDataSnapShotMgr.DoGenGlobalGameDataSnapData(UGSE_EngineFuncLib.GetFirstLocalPlayerController(World)?.GetControlledPawn());
	}
}
