namespace b1;

public class GSGroupFollowConfig
{
	public bool bEnableAdjustTimeRate;

	public float MinTimeRate;

	public float MaxTimeRate;

	public float MinRateDistance;

	public float DecreaseRateDistance;

	public float IncreaseRateDistance;

	public float MaxRateDistance;

	public GSGroupFollowConfig(in FGSGroupFollowConfig other)
	{
		bEnableAdjustTimeRate = other.bEnableAdjustTimeRate;
		MinTimeRate = other.MinTimeRate;
		MaxTimeRate = other.MaxTimeRate;
		MinRateDistance = other.MinRateDistance;
		DecreaseRateDistance = other.DecreaseRateDistance;
		IncreaseRateDistance = other.IncreaseRateDistance;
		MaxRateDistance = other.MaxRateDistance;
	}
}
