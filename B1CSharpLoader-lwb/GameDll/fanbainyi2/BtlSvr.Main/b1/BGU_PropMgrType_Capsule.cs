using UnrealEngine.Engine;

namespace b1;

public abstract class BGU_PropMgrType_Capsule : BGU_PropMgrTypeBase
{
	protected UCapsuleComponent CapsuleComp { get; set; }

	protected BGU_PropMgrType_Capsule(UCapsuleComponent InCapsuleComp)
	{
		CapsuleComp = InCapsuleComp;
	}
}
