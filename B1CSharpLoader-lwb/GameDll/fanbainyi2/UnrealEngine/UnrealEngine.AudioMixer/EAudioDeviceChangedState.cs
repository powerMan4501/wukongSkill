using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.EAudioDeviceChangedState", "AudioMixer", UnrealModuleType.Engine)]
public enum EAudioDeviceChangedState : byte
{
	Invalid,
	Active,
	Disabled,
	NotPresent,
	Unplugged,
	Count
}
