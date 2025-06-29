using UnrealEngine.Engine;

namespace b1;

public abstract class BGU_PropMgrType_Movement : BGU_PropMgrTypeBase
{
	protected UCharacterMovementComponent MovementComp { get; set; }

	protected BGU_PropMgrType_Movement(UCharacterMovementComponent InMovementComp)
	{
		MovementComp = InMovementComp;
	}
}
