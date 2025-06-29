using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UEnum]
[UMetaPath("/Script/GameplayCameras.ECameraAnimationEasingType", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public enum ECameraAnimationEasingType
{
	Linear,
	Sinusoidal,
	Quadratic,
	Cubic,
	Quartic,
	Quintic,
	Exponential,
	Circular
}
