using b1.EventDelDefine;

namespace b1;

public class BPS_PlayerStateTestSystem : PlayerStateSystemBase
{
	private BPC_PlayerStateTestData TestData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		TestData = RequireWritableData<BPC_PlayerStateTestData>();
		GetPlayerEventCollection().Evt_BPS_TestPlayerState += new Del_Void_Int(TestAddData);
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		TestData.ActiveTransactions.Add(new PlayerTransactionInteract
		{
			InteractTarget = GetOwner()
		});
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TestData.ActiveTransactions[0] is PlayerTransactionInteract playerTransactionInteract)
		{
			if (playerTransactionInteract.InteractTarget == null)
			{
				playerTransactionInteract.InteractTarget = GetOwner();
			}
			else
			{
				playerTransactionInteract.InteractTarget = null;
			}
		}
		for (int num = TestData.ActiveTransactions.Count - 1; num >= 1; num--)
		{
		}
	}

	private void TestAddData(int LevelAreaIdx)
	{
		TestData.TestID++;
	}
}
