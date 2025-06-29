using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_DynamicObstacleConfigData
{
	bool bDefaultEnable { get; }

	UShapeComponent CollisionComp { get; }
}
