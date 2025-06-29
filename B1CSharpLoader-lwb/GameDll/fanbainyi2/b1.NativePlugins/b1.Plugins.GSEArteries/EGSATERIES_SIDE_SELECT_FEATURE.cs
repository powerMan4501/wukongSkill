using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UEnum]
[UMetaPath("/Script/GSEArteries.GSATERIES_SIDE_SELECT_FEATURE", "GSEArteries", UnrealModuleType.GamePlugin)]
public enum EGSATERIES_SIDE_SELECT_FEATURE
{
	RANDOM_SIDE,
	LONGEST_SIDE,
	SHORTEST_SIDE,
	EACH_SIDE,
	FIRST_SIDE
}
