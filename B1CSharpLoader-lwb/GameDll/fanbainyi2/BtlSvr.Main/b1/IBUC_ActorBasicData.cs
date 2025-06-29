using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ActorBasicData
{
	Entity Entity { get; }

	AActor Actor { get; }

	BGU_ActorType ActorType { get; }
}
