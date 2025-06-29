using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.ELocationXToSpawnEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum ELocationXToSpawnEnum : byte
{
	ChaosNiagara_LocationXToSpawn_None,
	ChaosNiagara_LocationXToSpawn_Min,
	ChaosNiagara_LocationXToSpawn_Max,
	ChaosNiagara_LocationXToSpawn_MinMax,
	ChaosNiagara_Max
}
