using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ActorBasicData : IBUC_ActorBasicData, IPersistentECSData
{
	public Entity Entity { get; set; }

	public AActor Actor { get; set; }

	public BGU_ActorType ActorType { get; set; }
}
