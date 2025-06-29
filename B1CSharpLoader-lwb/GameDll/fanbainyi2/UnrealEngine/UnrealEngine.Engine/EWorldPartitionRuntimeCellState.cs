using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EWorldPartitionRuntimeCellState", "Engine", UnrealModuleType.Engine)]
public enum EWorldPartitionRuntimeCellState : byte
{
	Unloaded,
	Loaded,
	Activated
}
