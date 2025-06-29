using UnrealEngine.Engine;

namespace b1;

public abstract class BGU_PropMgrType_Actor : BGU_PropMgrTypeBase
{
	protected AActor Actor { get; set; }

	protected BGU_PropMgrType_Actor(AActor InActor)
	{
		Actor = InActor;
	}
}
