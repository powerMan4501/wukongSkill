using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.ESubmixEffectDynamicsProcessorType", "AudioMixer", UnrealModuleType.Engine)]
public enum ESubmixEffectDynamicsProcessorType : byte
{
	Compressor,
	Limiter,
	Expander,
	Gate,
	UpwardsCompressor,
	Count
}
