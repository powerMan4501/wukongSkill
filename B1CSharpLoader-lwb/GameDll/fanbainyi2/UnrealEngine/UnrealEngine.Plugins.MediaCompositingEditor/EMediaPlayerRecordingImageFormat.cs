using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositingEditor;

[UEnum]
[UMetaPath("/Script/MediaCompositingEditor.EMediaPlayerRecordingImageFormat", "MediaCompositingEditor", UnrealModuleType.EnginePlugin)]
public enum EMediaPlayerRecordingImageFormat
{
	PNG,
	JPEG,
	BMP,
	EXR
}
