using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.EConstantQNormalizationEnum", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public enum EConstantQNormalizationEnum : byte
{
	EqualEuclideanNorm,
	EqualEnergy,
	EqualAmplitude
}
