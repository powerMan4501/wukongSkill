using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsSpawnerState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsSpawnerState : byte
{
	Disabled,
	Enabled,
	Spawned
}
