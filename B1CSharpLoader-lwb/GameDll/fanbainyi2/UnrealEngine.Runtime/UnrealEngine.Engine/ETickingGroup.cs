using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETickingGroup", "Engine", UnrealModuleType.Engine)]
public enum ETickingGroup : byte
{
	PrePhysics,
	StartPhysics,
	DuringPhysics,
	EndPhysics,
	PostPhysics,
	PostUpdateWork,
	LastDemotable,
	NewlySpawned
}
