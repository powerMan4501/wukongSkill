using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EEndPlayReason", "Engine", UnrealModuleType.Engine)]
public enum EEndPlayReason : byte
{
	Destroyed,
	LevelTransition,
	EndPlayInEditor,
	RemovedFromWorld,
	Quit
}
