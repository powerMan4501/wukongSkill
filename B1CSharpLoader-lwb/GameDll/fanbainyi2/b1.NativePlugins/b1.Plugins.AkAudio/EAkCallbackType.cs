using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.EAkCallbackType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkCallbackType : byte
{
	EndOfEvent = 0,
	Marker = 2,
	Duration = 3,
	Starvation = 5,
	MusicPlayStarted = 7,
	MusicSyncBeat = 8,
	MusicSyncBar = 9,
	MusicSyncEntry = 10,
	MusicSyncExit = 11,
	MusicSyncGrid = 12,
	MusicSyncUserCue = 13,
	MusicSyncPoint = 14,
	MIDIEvent = 16,
	EnableGetSourcePlayPosition = 20
}
