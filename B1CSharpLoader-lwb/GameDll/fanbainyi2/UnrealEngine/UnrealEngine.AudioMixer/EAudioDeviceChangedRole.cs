using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.EAudioDeviceChangedRole", "AudioMixer", UnrealModuleType.Engine)]
public enum EAudioDeviceChangedRole : byte
{
	Invalid,
	Console,
	Multimedia,
	Communications,
	Count
}
