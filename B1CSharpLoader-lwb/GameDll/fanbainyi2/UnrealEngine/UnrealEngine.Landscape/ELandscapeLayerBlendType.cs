using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeLayerBlendType", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeLayerBlendType
{
	LB_WeightBlend,
	LB_AlphaBlend,
	LB_HeightBlend
}
