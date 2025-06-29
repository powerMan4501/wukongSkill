using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.EWeightmapRTType", "Landscape", UnrealModuleType.Engine)]
public enum EWeightmapRTType
{
	WeightmapRT_Scratch_RGBA,
	WeightmapRT_Scratch1,
	WeightmapRT_Scratch2,
	WeightmapRT_Scratch3,
	WeightmapRT_Mip0,
	WeightmapRT_Mip1,
	WeightmapRT_Mip2,
	WeightmapRT_Mip3,
	WeightmapRT_Mip4,
	WeightmapRT_Mip5,
	WeightmapRT_Mip6,
	WeightmapRT_Mip7,
	WeightmapRT_Count
}
