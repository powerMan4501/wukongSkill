using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UEnum]
[UMetaPath("/Script/GSEArteries.EGSARTERIES_PLACEMENT_STRATEGY", "GSEArteries", UnrealModuleType.GamePlugin)]
public enum EGSARTERIES_PLACEMENT_STRATEGY
{
	ANY,
	PREFER_STACKABLE,
	BASE
}
