namespace b1;

public class BPS_PlayerStateTestPrintSystem : PlayerStateSystemBase
{
	private BPC_PlayerStateTestData TestData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		TestData = RequireWritableData<BPC_PlayerStateTestData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		foreach (PlayerTransactionBase activeTransaction in TestData.ActiveTransactions)
		{
			if (activeTransaction is PlayerTransactionInteract playerTransactionInteract)
			{
				BGW_LogUtil.LogError("BPS_PlayerStateTestPrintSystem " + GetOwner().GetPathName() + " TestInt:" + playerTransactionInteract.InteractTarget?.GetName());
			}
		}
	}
}
