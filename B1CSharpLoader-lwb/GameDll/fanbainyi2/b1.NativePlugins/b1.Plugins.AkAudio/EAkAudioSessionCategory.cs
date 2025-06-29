using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkAudioSessionCategory", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAudioSessionCategory
{
	Ambient,
	SoloAmbient,
	PlayAndRecord
}
