namespace b1;

public class AIData_BasicTimers
{
	private float WatchTime;

	private float StalemateMoveTime;

	public void Init()
	{
		StalemateMoveTime = 0f;
	}

	public float GetWatchTime()
	{
		return WatchTime;
	}

	public void SetWatchTime(float _WatchTime)
	{
		WatchTime = _WatchTime;
	}

	public float GetStalemateMoveTime()
	{
		return StalemateMoveTime;
	}

	public void SetStalemateMoveTime(float InTime)
	{
		StalemateMoveTime = InTime;
	}
}
