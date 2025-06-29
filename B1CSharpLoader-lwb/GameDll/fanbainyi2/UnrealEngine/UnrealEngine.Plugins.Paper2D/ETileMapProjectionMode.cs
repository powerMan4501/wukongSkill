using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UEnum]
[UMetaPath("/Script/Paper2D.ETileMapProjectionMode", "Paper2D", UnrealModuleType.EnginePlugin)]
public enum ETileMapProjectionMode
{
	Orthogonal,
	IsometricDiamond,
	IsometricStaggered,
	HexagonalStaggered
}
