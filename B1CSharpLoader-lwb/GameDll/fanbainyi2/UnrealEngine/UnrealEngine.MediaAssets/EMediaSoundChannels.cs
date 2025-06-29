using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[UMetaPath("/Script/MediaAssets.EMediaSoundChannels", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaSoundChannels
{
	Mono,
	Stereo,
	Surround
}
