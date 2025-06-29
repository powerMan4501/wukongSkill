using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ERaQualityMode", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public enum ERaQualityMode : byte
{
	STEREO_PANNING,
	BINAURAL_LOW,
	BINAURAL_MEDIUM,
	BINAURAL_HIGH
}
