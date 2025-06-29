using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkAudioSessionCategoryOptions", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAudioSessionCategoryOptions
{
	MixWithOthers,
	DuckOthers,
	AllowBluetooth,
	DefaultToSpeaker
}
