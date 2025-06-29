using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.EOscillatorWaveform", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public enum EOscillatorWaveform : byte
{
	SineWave,
	PerlinNoise
}
