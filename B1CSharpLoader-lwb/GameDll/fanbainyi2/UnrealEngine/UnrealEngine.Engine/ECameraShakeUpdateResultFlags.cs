using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECameraShakeUpdateResultFlags", "Engine", UnrealModuleType.Engine)]
public enum ECameraShakeUpdateResultFlags
{
	ApplyAsAbsolute = 1,
	SkipAutoScale = 2,
	SkipAutoPlaySpace = 4,
	Default = 0
}
