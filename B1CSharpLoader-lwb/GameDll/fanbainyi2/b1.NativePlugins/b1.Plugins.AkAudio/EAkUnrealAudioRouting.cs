using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkUnrealAudioRouting", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkUnrealAudioRouting
{
	Custom,
	Separate,
	AudioLink,
	AudioMixer,
	EnableWwiseOnly,
	EnableUnrealOnly
}
