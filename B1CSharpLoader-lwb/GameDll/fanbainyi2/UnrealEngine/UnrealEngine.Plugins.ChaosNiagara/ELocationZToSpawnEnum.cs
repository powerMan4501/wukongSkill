using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.ELocationZToSpawnEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum ELocationZToSpawnEnum : byte
{
	ChaosNiagara_LocationZToSpawn_None,
	ChaosNiagara_LocationZToSpawn_Min,
	ChaosNiagara_LocationZToSpawn_Max,
	ChaosNiagara_LocationZToSpawn_MinMax,
	ChaosNiagara_Max
}
