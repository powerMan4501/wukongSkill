using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaPlayerEditor;

[UEnum]
[UMetaPath("/Script/MediaPlayerEditor.EMediaPlayerEditorScale", "MediaPlayerEditor", UnrealModuleType.EnginePlugin)]
public enum EMediaPlayerEditorScale
{
	Fill,
	Fit,
	Original
}
