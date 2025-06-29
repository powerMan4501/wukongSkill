using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UEnum]
[UMetaPath("/Script/ResonanceAudio.EResonanceRenderMode", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public enum EResonanceRenderMode
{
	StereoPanning,
	BinauralLowQuality,
	BinauralMediumQuality,
	BinauralHighQuality,
	RoomEffectsOnly
}
