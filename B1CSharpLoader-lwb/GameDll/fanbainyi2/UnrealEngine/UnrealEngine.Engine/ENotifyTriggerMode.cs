using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENotifyTriggerMode", "Engine", UnrealModuleType.Engine)]
public enum ENotifyTriggerMode
{
	AllAnimations,
	HighestWeightedAnimation,
	None
}
