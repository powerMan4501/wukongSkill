using UnrealEngine.Runtime;

namespace UnrealEngine.SequenceRecorder;

[UEnum]
[UMetaPath("/Script/SequenceRecorder.EAudioRecordingMode", "SequenceRecorder", UnrealModuleType.Engine)]
public enum EAudioRecordingMode
{
	None,
	AudioTrack
}
