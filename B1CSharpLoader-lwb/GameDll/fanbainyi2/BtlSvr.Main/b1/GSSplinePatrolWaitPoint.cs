using UnrealEngine.Engine;

namespace b1;

public class GSSplinePatrolWaitPoint
{
	public float WaitTime { get; set; }

	public UAnimMontage WaitAM { get; set; }

	public GSSplinePatrolWaitPoint(in FGSSplinePatrolWaitPoint InConfig)
	{
		WaitAM = InConfig.WaitAM;
		if (WaitAM != null)
		{
			WaitTime = WaitAM.GetPlayLength();
		}
	}

	public GSSplinePatrolWaitPoint(GSSplinePatrolWaitPoint other)
	{
		WaitTime = other.WaitTime;
	}
}
