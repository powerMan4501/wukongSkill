using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAutoPossessAI", "Engine", UnrealModuleType.Engine)]
public enum EAutoPossessAI
{
	Disabled,
	PlacedInWorld,
	Spawned,
	PlacedInWorldOrSpawned
}
