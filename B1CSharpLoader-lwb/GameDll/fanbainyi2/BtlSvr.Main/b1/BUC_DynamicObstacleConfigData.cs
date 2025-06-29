using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

internal class BUC_DynamicObstacleConfigData : b1.IBUC_DynamicObstacleConfigData, IPersistentECSData
{
	public bool bDefaultEnable { get; set; }

	public UShapeComponent CollisionComp { get; set; }
}
