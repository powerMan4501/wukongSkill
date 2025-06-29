using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

internal class BUC_RelativeFloatMoveData : b1.IBUC_RelativeFloatMoveData, IPersistentECSData
{
	public AActor FloatRelativeSpotActor { get; set; }

	public float RelativeFloatHeight { get; set; }
}
