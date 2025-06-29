using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.ESubmixEffectDynamicsKeySource", "AudioMixer", UnrealModuleType.Engine)]
public enum ESubmixEffectDynamicsKeySource : byte
{
	Default,
	AudioBus,
	Submix,
	Count
}
