using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_CollectionActorUtil
{
	public static FGSSpawnProbabilityGroup InitProbabilityGroupByDesc(string CurrentLevel)
	{
		FGSSpawnProbabilityGroup result = new FGSSpawnProbabilityGroup
		{
			SpawnProbabilityGroup = new Dictionary<int, FGSSpawnProbabilityConfig>()
		};
		List<FUStCollectionSpawnInfoDesc> allCollectionSpawnInfoDesc = BGW_GameDB.GetAllCollectionSpawnInfoDesc();
		Dictionary<int, FUStCollectionSpawnGroupDesc> allCollectionSpawnGroupDesc = BGW_GameDB.GetAllCollectionSpawnGroupDesc();
		if (allCollectionSpawnGroupDesc != null)
		{
			foreach (KeyValuePair<int, FUStCollectionSpawnGroupDesc> item in allCollectionSpawnGroupDesc)
			{
				if (!(item.Value.MapName == CurrentLevel))
				{
					continue;
				}
				int num = 0;
				FGSSpawnProbabilityConfig value = new FGSSpawnProbabilityConfig
				{
					FreshDelta = item.Value.FreshDelta,
					MinNum = item.Value.NumMin,
					MaxNum = item.Value.NumMax,
					PlusRate = item.Value.PlusRate,
					ChiefRate = item.Value.ChiefRate,
					Describe = item.Value.GroupName,
					ActorDict = new Dictionary<int, string>()
				};
				foreach (FUStCollectionSpawnInfoDesc item2 in allCollectionSpawnInfoDesc)
				{
					if (item2.GroupId == item.Value.ID)
					{
						value.ActorDict.Add(num, item2.Guid);
						num++;
					}
				}
				result.SpawnProbabilityGroup.Add(item.Value.ID, value);
			}
		}
		return result;
	}

	public static (int, TSubclassOf<AActor>) RandomTargetSpawnActor(List<GamePlusSpawnerConfig> SpawnerConfigList)
	{
		int num = 0;
		foreach (GamePlusSpawnerConfig SpawnerConfig in SpawnerConfigList)
		{
			num += SpawnerConfig.Rate;
		}
		int num2 = FMath.RandRange(0, num);
		TSubclassOf<AActor> item = null;
		int num3 = 0;
		foreach (GamePlusSpawnerConfig SpawnerConfig2 in SpawnerConfigList)
		{
			num3++;
			if (num2 <= SpawnerConfig2.Rate)
			{
				item = SpawnerConfig2.ActorClass;
				break;
			}
			num2 -= SpawnerConfig2.Rate;
		}
		return (num3, item);
	}

	public static GamePlusSpawnConfig InitGamePlusSpawnConfig(FGamePlusSpawnConfig GamePlusSpawnConfig)
	{
		GamePlusSpawnConfig result = new GamePlusSpawnConfig
		{
			GamePlusCount = GamePlusSpawnConfig.GamePlusCount,
			SpawnerConfig = new List<GamePlusSpawnerConfig>()
		};
		foreach (FGamePlusSpawnerConfig item2 in GamePlusSpawnConfig.SpawnerConfig)
		{
			GamePlusSpawnerConfig item = new GamePlusSpawnerConfig
			{
				Rate = item2.Rate,
				ActorClass = item2.ActorClass
			};
			result.SpawnerConfig.Add(item);
		}
		return result;
	}
}
