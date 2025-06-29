using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioSpectrumBandPresetType", "Engine", UnrealModuleType.Engine)]
public enum EAudioSpectrumBandPresetType : byte
{
	KickDrum,
	SnareDrum,
	Voice,
	Cymbals
}
