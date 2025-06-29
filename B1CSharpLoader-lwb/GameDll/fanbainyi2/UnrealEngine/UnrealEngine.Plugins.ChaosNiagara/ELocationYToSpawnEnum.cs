using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.ELocationYToSpawnEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum ELocationYToSpawnEnum : byte
{
	ChaosNiagara_LocationYToSpawn_None,
	ChaosNiagara_LocationYToSpawn_Min,
	ChaosNiagara_LocationYToSpawn_Max,
	ChaosNiagara_LocationYToSpawn_MinMax,
	ChaosNiagara_Max
}
