using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EActorGridPlacement", "Engine", UnrealModuleType.Engine)]
public enum EActorGridPlacement
{
	Bounds,
	Location,
	AlwaysLoaded,
	None
}
