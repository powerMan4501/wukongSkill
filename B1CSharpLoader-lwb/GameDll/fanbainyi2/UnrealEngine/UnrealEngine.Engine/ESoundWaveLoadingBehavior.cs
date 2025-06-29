using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESoundWaveLoadingBehavior", "Engine", UnrealModuleType.Engine)]
public enum ESoundWaveLoadingBehavior
{
	Inherited = 0,
	RetainOnLoad = 1,
	PrimeOnLoad = 2,
	LoadOnDemand = 3,
	ForceInline = 4,
	Uninitialized = 255
}
