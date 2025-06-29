namespace b1;

public class FGuardCondition_PlayerCloudMove : FGuardConditionBase
{
	private IBUC_CloudMoveData CloudMoveData => FGuardConditionBase.CommonData.CloudMoveData;

	public override EGuardConditionType ConditionType => EGuardConditionType.PlayerCloudMove;

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		CheckCloudMoveEnabled();
	}

	protected override void Stop()
	{
	}

	protected override void OnTick(float DeltaTime)
	{
		CheckCloudMoveEnabled();
	}

	private void CheckCloudMoveEnabled()
	{
		if (CloudMoveData != null && CloudMoveData.IsCloudMoveEnabled)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
