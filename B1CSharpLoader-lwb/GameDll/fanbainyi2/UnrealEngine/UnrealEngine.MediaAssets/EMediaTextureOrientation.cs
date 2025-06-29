using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[UMetaPath("/Script/MediaAssets.MediaTextureOrientation", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaTextureOrientation
{
	MTORI_Original,
	MTORI_CW90,
	MTORI_CW180,
	MTORI_CW270
}
