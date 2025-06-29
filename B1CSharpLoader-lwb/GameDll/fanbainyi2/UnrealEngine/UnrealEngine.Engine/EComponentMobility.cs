using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EComponentMobility", "Engine", UnrealModuleType.Engine)]
public enum EComponentMobility : byte
{
	Static,
	Stationary,
	Movable
}
