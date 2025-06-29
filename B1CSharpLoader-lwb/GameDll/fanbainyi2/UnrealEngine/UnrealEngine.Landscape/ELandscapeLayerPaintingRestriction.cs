using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeLayerPaintingRestriction", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeLayerPaintingRestriction
{
	None,
	UseMaxLayers,
	ExistingOnly,
	UseComponentAllowList
}
