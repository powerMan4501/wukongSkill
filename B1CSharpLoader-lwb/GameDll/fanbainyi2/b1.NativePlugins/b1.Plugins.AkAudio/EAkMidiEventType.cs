using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.EAkMidiEventType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkMidiEventType : byte
{
	AkMidiEventTypeInvalid = 0,
	AkMidiEventTypeNoteOff = 128,
	AkMidiEventTypeNoteOn = 144,
	AkMidiEventTypeNoteAftertouch = 160,
	AkMidiEventTypeController = 176,
	AkMidiEventTypeProgramChange = 192,
	AkMidiEventTypeChannelAftertouch = 208,
	AkMidiEventTypePitchBend = 224,
	AkMidiEventTypeSysex = 240,
	AkMidiEventTypeEscape = 247,
	AkMidiEventTypeMeta = byte.MaxValue
}
