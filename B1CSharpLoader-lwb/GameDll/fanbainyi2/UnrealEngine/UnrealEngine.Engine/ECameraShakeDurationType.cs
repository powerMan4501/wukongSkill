using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECameraShakeDurationType", "Engine", UnrealModuleType.Engine)]
public enum ECameraShakeDurationType
{
	Fixed,
	Infinite,
	Custom
}
