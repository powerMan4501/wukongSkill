using UnrealEngine.Engine;

namespace b1;

public class GSSplinePatrolJumpPoint
{
	public UAnimMontage JumpAM { get; set; }

	public float JumpForce { get; set; }

	public GSSplinePatrolJumpPoint(in FGSSplinePatrolJumpPoint InConfig)
	{
		JumpAM = InConfig.JumpAM;
		JumpForce = InConfig.JumpForce;
	}

	public GSSplinePatrolJumpPoint(GSSplinePatrolJumpPoint other)
	{
		JumpAM = other.JumpAM;
		JumpForce = other.JumpForce;
	}
}
