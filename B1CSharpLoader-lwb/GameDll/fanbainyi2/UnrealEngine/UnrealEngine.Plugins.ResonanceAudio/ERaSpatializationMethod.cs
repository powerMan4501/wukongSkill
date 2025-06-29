using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ERaSpatializationMethod", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public enum ERaSpatializationMethod : byte
{
	STEREO_PANNING,
	HRTF
}
