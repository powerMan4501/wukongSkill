using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SpawnMultiPointData : b1.IBUC_SpawnMultiPointData, IPersistentECSData
{
	private readonly TStrongObjectPtr<UClass> mSpawnUnitClass = new TStrongObjectPtr<UClass>();

	private readonly TStrongObjectPtr<UAnimMontage> mSpawnMontage = new TStrongObjectPtr<UAnimMontage>();

	public FTimerHandle ReSpawnTestTimer;

	public bool bDefaultStartSpawn { get; set; }

	public FVector[] SpawnPoints { get; set; }

	public FRotator[] SpawnPointsRot { get; set; }

	public bool UseSpawnPointsRot { get; set; }

	public int PointNum { get; set; }

	public List<int> SpawnedIndexes { get; } = new List<int>();

	public List<int> UnSpawnedIndexes { get; } = new List<int>();

	public ESpawnType SpawnType { get; set; }

	public ESpawnRule SpawnRule { get; set; }

	public bool IsLRU { get; set; }

	public bool IsNotSpawnedInPlayerSight { get; set; }

	public int LowerLimitNum { get; set; }

	public int SpawnMaxNum { get; set; }

	public int ReSpawnThreshold { get; set; }

	public int ReSpawnLimit { get; set; }

	public float ReSpawnTestInterval { get; set; }

	public int CurrentUnitNum { get; set; }

	public bool bReplenish { get; set; }

	public List<TSubclassOf<AActor>> SpawnActorList { get; set; }

	public List<FUnitSpawnInfo> UnitSpawnInfoList { get; } = new List<FUnitSpawnInfo>();

	public FName SpawnedTag { get; set; }

	public float SpawnHeight { get; set; }

	public List<FSpawnActorInfo> SpawnActorInfos { get; } = new List<FSpawnActorInfo>();

	public Dictionary<int, int> SpawnedPool { get; set; } = new Dictionary<int, int>();

	public int SpawnMaxNumAlone { get; set; }

	public int SpawnMaxNumOnline { get; set; }

	public int LowerLimitNumAlone { get; set; }

	public int LowerLimitNumOnline { get; set; }

	public int ReSpawnLimitAlone { get; set; }

	public int ReSpawnLimitOnline { get; set; }

	public bool HasSpawn { get; set; }
}
