using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ERaDistanceRolloffModel", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public enum ERaDistanceRolloffModel : byte
{
	LOGARITHMIC,
	LINEAR,
	NONE
}
