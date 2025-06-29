using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSEArteries.EGSARTERIES_PLACEMENT_LEVEL", "GSEArteries", UnrealModuleType.GamePlugin)]
public enum EGSARTERIES_PLACEMENT_LEVEL : byte
{
	NONE = 0,
	BUTTOM = 1,
	TOP = 2,
	TOP_OR_BOTTOM = 3,
	ALL = 7
}
