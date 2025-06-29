using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ETerrainCoordMappingType", "Landscape", UnrealModuleType.Engine)]
public enum ETerrainCoordMappingType
{
	TCMT_Auto,
	TCMT_XY,
	TCMT_XZ,
	TCMT_YZ
}
