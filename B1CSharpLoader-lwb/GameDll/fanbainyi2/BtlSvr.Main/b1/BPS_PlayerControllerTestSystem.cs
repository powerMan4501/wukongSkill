using b1.EventDelDefine;

namespace b1;

public class BPS_PlayerControllerTestSystem : PlayerControllerSystemBase
{
	private BPC_PlayerControllerTestData TestData;

	private BPC_PlayerStateTestData PlayerStateTestData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		TestData = RequireWritableData<BPC_PlayerControllerTestData>();
		PlayerStateTestData = RequireWritablePlayerStateData<BPC_PlayerStateTestData>();
		GetPlayerEventCollection().Evt_BPS_TestPlayerController += new Del_Void_Int(TestAddData);
	}

	private void TestAddData(int LevelAreaIdx)
	{
		TestData.TestID++;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		GetPlayerEventCollection().Evt_BPS_TestPlayerController.Invoke(0);
		GetPlayerEventCollection().Evt_BPS_TestPlayerState.Invoke(0);
	}
}
