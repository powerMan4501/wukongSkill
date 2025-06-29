using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[UMetaPath("/Script/MediaAssets.MediaTextureOutputFormat", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaTextureOutputFormat
{
	MTOF_Default,
	MTOF_SRGB_LINOUT
}
