using System;
using System.Collections.Generic;
using System.Linq;
using b1.GameMode;
using b1.Localization;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibMap")]
public class BGUFuncLibMap : UBlueprintFunctionLibrary
{
	private static IBIC_LevelData GetLevelData(UObject WorldContext)
	{
		return BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext);
	}

	private static FDetailLevelInfo GetLevelInfo(UObject WorldContext)
	{
		return GetLevelData(WorldContext)?.DetailLevelInfo ?? default(FDetailLevelInfo);
	}

	public static int GetCurLevelId(UObject WorldContext)
	{
		return GetLevelData(WorldContext)?.CurrentLevelID ?? 0;
	}

	public static bool IsValidLevelId(int LevelId)
	{
		return GameDBRuntime.FastGetLevelDesc(LevelId) != null;
	}

	public static int GetLevelIdByName(string LevelName)
	{
		return GameDBRuntime.GetTBLevelDesc().List.FirstOrDefault((LevelDesc item) => item.Path == LevelName)?.Id ?? 0;
	}

	public static string GetRebirthGroupNameById(int LevelId)
	{
		return GameDBRuntime.FastGetLevelDesc(LevelId)?.RebirthGroupName;
	}

	public static string GetLevelPathById(int LevelId)
	{
		return GameDBRuntime.FastGetLevelDesc(LevelId)?.Path;
	}

	public static string GetMapName(UObject WorldContext)
	{
		int curLevelId = GetCurLevelId(WorldContext);
		foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
		{
			if (item.Id == curLevelId)
			{
				return item.Name.ToFText().ToString();
			}
		}
		return "未知地图";
	}

	public static int GetAreaId(AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return 0;
		}
		if (BGU_DataUtil.GetPlayerStateReadonlyData<b1.IBPC_MapAreaData, BPC_MapAreaData>(UGameplayStatics.GetPlayerState(Actor, 0)).TryGetAreaId(Actor, out var AreaId))
		{
			return AreaId;
		}
		return 0;
	}

	public static bool IsInWXLogin(UObject WorldContext)
	{
		return UGameplayStatics.GetCurrentLevelName(WorldContext).Equals("WXLogin_P");
	}

	public static string GetAreaName(AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return "未知区域";
		}
		int LevelId = GetCurLevelId(Actor);
		int AreaId = GetAreaId(Actor);
		return GameDBRuntime.GetTBMapAreaConfigDesc().List.FirstOrDefault((MapAreaConfigDesc item) => item.LevelId == LevelId && item.AreaId == AreaId)?.AreaName.ToFText().ToString() ?? "未知区域";
	}

	public static bool IsSupportMountRide(UObject WorldContext)
	{
		IBIC_LevelData levelData = GetLevelData(WorldContext);
		if (levelData != null && levelData.LevelTagToLevelIdMap.TryGetValue(ELevelTag.SupportRide, out var value))
		{
			return value.Contains(GetCurLevelId(WorldContext));
		}
		return false;
	}

	public static bool IsPartyLevel(int MapId, UObject WorldContext)
	{
		return GetLevelTags(MapId, WorldContext).Contains(ELevelTag.Party);
	}

	public static bool IsPartyLevel(UObject WorldContext)
	{
		return IsPartyLevel(GetCurLevelId(WorldContext), WorldContext);
	}

	public static bool IsSupportOpenMap(UObject WorldContext)
	{
		return true;
	}

	public static bool IsEndingLevel(int MapId, UObject WorldContext)
	{
		return GetLevelTags(MapId, WorldContext).Contains(ELevelTag.Ending);
	}

	public static bool IsEndingLevel(UObject WorldContext)
	{
		return IsEndingLevel(GetCurLevelId(WorldContext), WorldContext);
	}

	public static PlayerGameMode GetPlayerGameMode(UObject WorldContext)
	{
		if (IsPartyLevel(WorldContext))
		{
			return PlayerGameMode.Party;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		if (UGSE_EngineFuncLib.IsListenServer(worldFromObj) || UGSE_EngineFuncLib.IsClient(worldFromObj))
		{
			return PlayerGameMode.Online;
		}
		return PlayerGameMode.Console;
	}

	public static List<ELevelTag> GetLevelTags(int MapId, UObject WorldContext)
	{
		List<ELevelTag> list = new List<ELevelTag>();
		IBIC_LevelData levelData = GetLevelData(WorldContext);
		if (levelData != null)
		{
			foreach (KeyValuePair<ELevelTag, List<int>> item in levelData.LevelTagToLevelIdMap)
			{
				if (item.Value.Contains(MapId))
				{
					list.Add(item.Key);
				}
			}
		}
		return list;
	}

	public static List<ELevelTag> GetLevelTags(UObject WorldContext)
	{
		return GetLevelTags(GetCurLevelId(WorldContext), WorldContext);
	}

	public static List<int> GetLevelIdList(ELevelTag LevelTag, UObject WorldContext)
	{
		IBIC_LevelData levelData = GetLevelData(WorldContext);
		if (levelData != null && levelData.LevelTagToLevelIdMap != null && levelData.LevelTagToLevelIdMap.TryGetValue(LevelTag, out var value))
		{
			return value;
		}
		return new List<int>();
	}

	public static bool IsMainMenuLevelId(int MapId, UObject WorldContext)
	{
		return GetLevelInfo(WorldContext).MainMenuLevelId == MapId;
	}

	public static bool IsBattleMap(UObject WorldContext)
	{
		AGameModeBase gameMode = UGameplayStatics.GetGameMode(WorldContext);
		if (!(gameMode == null))
		{
			return gameMode.IsA<BGG_GameModeB1>();
		}
		return true;
	}

	public static int GetMainMenuLevelId(UObject WorldContext)
	{
		return GetLevelInfo(WorldContext).MainMenuLevelId;
	}

	public static int GetSetConfigLevelId(UObject WorldContext)
	{
		return GetLevelInfo(WorldContext).SetConfigLevelId;
	}

	public static int GetPrologueLevelId(UObject WorldContext)
	{
		return GetLevelInfo(WorldContext).PrologueLevelId;
	}

	public static int GetAfterPrologueLevelId(UObject WorldContext)
	{
		return GetLevelInfo(WorldContext).AfterPrologueLevelId;
	}

	public static int GetPartyId(UObject WorldContext, bool IsOnline)
	{
		if (!IsOnline)
		{
			return GetLevelInfo(WorldContext).StandAlonePartyId;
		}
		return GetLevelInfo(WorldContext).OnlinePartyId;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibMap");
	}

	static BGUFuncLibMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibMap));
	}
}
