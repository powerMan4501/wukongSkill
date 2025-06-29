using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public struct FNeutralAnimalSpawnReq
{
	public string AreaGuid;

	public List<FVector> SpawnPosList;

	public TSubclassOf<BUTamerActor> TamerTemplate;

	public int DesireSpawnCount;

	public bool DestroyAllAnimalWhenPlaySeq;

	public FFloatRange ScaleRange;
}
