namespace b1;

public class FGuardCondition_Time : FGuardConditionBase
{
	private float WaitTime { get; set; }

	private float RemainWaitTime { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.Time;

	protected override void Clean()
	{
		WaitTime = 0f;
		RemainWaitTime = 0f;
	}

	protected override void Start()
	{
		RemainWaitTime = WaitTime;
	}

	protected override void OnTick(float DeltaTime)
	{
		RemainWaitTime -= DeltaTime;
		if (RemainWaitTime < 0f)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
