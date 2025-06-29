using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.EMediaPlayerTrack", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaPlayerTrack : byte
{
	Audio,
	Caption,
	Metadata,
	Script,
	Subtitle,
	Text,
	Video
}
