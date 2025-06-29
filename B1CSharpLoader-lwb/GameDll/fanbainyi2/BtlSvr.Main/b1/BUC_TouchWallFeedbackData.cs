namespace b1;

public class BUC_TouchWallFeedbackData
{
	public bool EnableDebug;

	public float TraceLength;

	public float SpeedThreshold;

	public float HitDynamicObstacle_ProtectTime;

	public float HitDynamicObstacle_LastTime;

	public float CliffUnbalance_SpeedThreshold;

	public FCliffUnbalanceAMConfig UnbalanceAMConfig;

	public BUC_TouchWallFeedbackData()
	{
		EnableDebug = false;
		SpeedThreshold = -1f;
		HitDynamicObstacle_ProtectTime = 0f;
		HitDynamicObstacle_LastTime = 0f;
		CliffUnbalance_SpeedThreshold = -1f;
	}
}
