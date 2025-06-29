using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[UMetaPath("/Script/AudioMixer.EAudioMixerStreamDataFormatType", "AudioMixer", UnrealModuleType.Engine)]
public enum EAudioMixerStreamDataFormatType
{
	Unknown,
	Float,
	Int16,
	Unsupported
}
