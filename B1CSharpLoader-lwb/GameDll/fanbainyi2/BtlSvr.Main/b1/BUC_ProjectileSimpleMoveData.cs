using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectileSimpleMoveData : b1.IBUC_ProjectileSimpleMoveData, IPersistentECSData
{
	public bool bEnableMove { get; set; }

	public FVector Velocity { get; set; }

	public BUC_ProjectileSimpleMoveData()
	{
		Velocity = FVector.ZeroVector;
		bEnableMove = true;
	}
}
