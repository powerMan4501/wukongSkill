using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeCustomizedCoordType", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeCustomizedCoordType
{
	LCCT_None,
	LCCT_CustomUV0,
	LCCT_CustomUV1,
	LCCT_CustomUV2,
	LCCT_WeightMapUV
}
