using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSpawnWaveUnitConfigForData
{
	public ESpawnPointType SpawnPointType { get; set; }

	public UEnvQuery EQSTemplate { get; set; }

	public List<FGSEnvNamedValue> QueryConfig { get; } = new List<FGSEnvNamedValue>();

	public FVector LocalSpaceOffset { get; set; }

	public ESpawnWaveLocalSpaceType LocalSpaceType { get; set; }

	public TSubclassOf<BUTamerActor> UnitClass { get; set; }

	public List<TSoftObject<BGUBattlePaceSpawnPointActor>> SpawnPoints { get; } = new List<TSoftObject<BGUBattlePaceSpawnPointActor>>();

	public List<int> BirthBuff { get; } = new List<int>();

	public UAnimMontage SpawnMontage { get; set; }

	public bool bIsFacePlayer { get; set; }

	public bool bIsCatchPlayer { get; set; }

	public TSoftObject<BUTamerActor> SpawnMaster { get; set; }

	public FSpawnWaveUnitConfigForData(FSpawnWaveUnitConfig UnitConfig)
	{
		SpawnPointType = UnitConfig.SpawnPointType;
		EQSTemplate = UnitConfig.EQSTemplate;
		QueryConfig.AddRange(UnitConfig.QueryConfig);
		UnitClass = UnitConfig.TamerClass;
		SpawnPoints.AddRange(UnitConfig.SpawnPoints);
		BirthBuff.AddRange(UnitConfig.BirthBuff);
		SpawnMontage = UnitConfig.SpawnMontage;
		bIsFacePlayer = UnitConfig.bIsFacePlayer;
		bIsCatchPlayer = UnitConfig.bIsCatchPlayer;
		SpawnMaster = UnitConfig.MasterTamer;
		LocalSpaceType = UnitConfig.LocalSpaceType;
		LocalSpaceOffset = UnitConfig.LocalSpaceOffset;
	}
}
