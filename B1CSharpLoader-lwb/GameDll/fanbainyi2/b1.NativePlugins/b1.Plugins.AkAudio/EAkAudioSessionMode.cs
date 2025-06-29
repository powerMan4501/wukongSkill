using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkAudioSessionMode", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAudioSessionMode
{
	Default,
	VoiceChat,
	GameChat,
	VideoRecording,
	Measurement,
	MoviePlayback,
	VideoChat
}
