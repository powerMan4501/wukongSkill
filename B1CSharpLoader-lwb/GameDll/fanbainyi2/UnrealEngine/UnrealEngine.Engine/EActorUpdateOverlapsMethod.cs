using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EActorUpdateOverlapsMethod", "Engine", UnrealModuleType.Engine)]
public enum EActorUpdateOverlapsMethod : byte
{
	UseConfigDefault,
	AlwaysUpdate,
	OnlyUpdateMovable,
	NeverUpdate
}
