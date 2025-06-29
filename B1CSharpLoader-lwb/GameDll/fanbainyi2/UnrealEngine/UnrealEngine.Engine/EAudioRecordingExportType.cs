using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioRecordingExportType", "Engine", UnrealModuleType.Engine)]
public enum EAudioRecordingExportType : byte
{
	SoundWave,
	WavFile
}
