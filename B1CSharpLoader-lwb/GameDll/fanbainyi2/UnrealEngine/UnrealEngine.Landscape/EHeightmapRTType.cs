using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.EHeightmapRTType", "Landscape", UnrealModuleType.Engine)]
public enum EHeightmapRTType
{
	HeightmapRT_CombinedAtlas,
	HeightmapRT_CombinedNonAtlas,
	HeightmapRT_Scratch1,
	HeightmapRT_Scratch2,
	HeightmapRT_Scratch3,
	HeightmapRT_Mip1,
	HeightmapRT_Mip2,
	HeightmapRT_Mip3,
	HeightmapRT_Mip4,
	HeightmapRT_Mip5,
	HeightmapRT_Mip6,
	HeightmapRT_Mip7,
	HeightmapRT_Count
}
