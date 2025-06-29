using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.ESubmixEffectDynamicsChannelLinkMode", "AudioMixer", UnrealModuleType.Engine)]
public enum ESubmixEffectDynamicsChannelLinkMode : byte
{
	Disabled,
	Average,
	Peak,
	Count
}
