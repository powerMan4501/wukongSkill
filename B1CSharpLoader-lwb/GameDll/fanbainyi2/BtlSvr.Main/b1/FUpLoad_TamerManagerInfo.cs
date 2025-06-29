using System.Collections.Generic;

namespace b1;

public struct FUpLoad_TamerManagerInfo
{
	public Dictionary<string, int> TamerCountInfo;

	public FUpLoad_TamerInfo[] LevelTamers;

	public FUpLoad_TamerInfo[] SpawnedTamers;

	public FUpLoad_TamerInfo[] SummonTamers;

	public FUpLoad_TamerInfo[] AllTamers;

	public FUpLoad_DestroyTamerInfo[] DestroyTamers;

	public FUpLoad_UnitSpawnedTamerInfo[] UnitSpawnedTamers;
}
