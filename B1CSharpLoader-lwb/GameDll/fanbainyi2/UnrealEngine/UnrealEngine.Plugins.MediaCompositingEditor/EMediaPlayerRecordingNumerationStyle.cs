using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositingEditor;

[UEnum]
[UMetaPath("/Script/MediaCompositingEditor.EMediaPlayerRecordingNumerationStyle", "MediaCompositingEditor", UnrealModuleType.EnginePlugin)]
public enum EMediaPlayerRecordingNumerationStyle
{
	AppendFrameNumber,
	AppendSampleTime
}
