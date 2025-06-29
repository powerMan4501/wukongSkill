using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkAndroidAudioAPI", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAndroidAudioAPI
{
	AAudio,
	OpenSL_ES
}
