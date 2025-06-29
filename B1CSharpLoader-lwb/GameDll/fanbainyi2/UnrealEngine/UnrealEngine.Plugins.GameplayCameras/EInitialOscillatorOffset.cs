using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UEnum]
[UMetaPath("/Script/GameplayCameras.EInitialOscillatorOffset", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public enum EInitialOscillatorOffset
{
	EOO_OffsetRandom,
	EOO_OffsetZero
}
