using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ETexAlign", "UnrealEd", UnrealModuleType.Engine)]
public enum ETexAlign
{
	TEXALIGN_None,
	TEXALIGN_Default,
	TEXALIGN_Box,
	TEXALIGN_Planar,
	TEXALIGN_Fit,
	TEXALIGN_PlanarAuto,
	TEXALIGN_PlanarWall,
	TEXALIGN_PlanarFloor
}
