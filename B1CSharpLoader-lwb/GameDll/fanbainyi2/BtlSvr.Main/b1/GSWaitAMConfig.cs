using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class GSWaitAMConfig
{
	private float Probability { get; set; }

	private IList<UAnimMontage> WaitAM { get; set; }

	public GSWaitAMConfig(float probability, IList<UAnimMontage> waitAM)
	{
		Probability = probability;
		WaitAM = waitAM;
	}

	public GSWaitAMConfig(GSWaitAMConfig other)
	{
		Probability = other.Probability;
		WaitAM = new List<UAnimMontage>(other.WaitAM);
	}

	public bool ShouldPlayWaitAM()
	{
		if (WaitAM.Count <= 0)
		{
			return false;
		}
		if (UB1Util.GetRandomNumberFloat(0f, 100f) <= Probability)
		{
			return true;
		}
		return false;
	}

	public UAnimMontage GetRandomAMToPlay()
	{
		int randomNumberInt = UB1Util.GetRandomNumberInt(0, WaitAM.Count - 1);
		return WaitAM[randomNumberInt];
	}
}
