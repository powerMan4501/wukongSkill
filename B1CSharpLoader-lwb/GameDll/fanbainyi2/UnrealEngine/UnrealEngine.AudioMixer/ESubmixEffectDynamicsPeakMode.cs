using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.ESubmixEffectDynamicsPeakMode", "AudioMixer", UnrealModuleType.Engine)]
public enum ESubmixEffectDynamicsPeakMode : byte
{
	MeanSquared,
	RootMeanSquared,
	Peak,
	Count
}
