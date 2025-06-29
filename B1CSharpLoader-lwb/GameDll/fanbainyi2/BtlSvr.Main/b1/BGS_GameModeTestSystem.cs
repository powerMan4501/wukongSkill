using b1.EventDelDefine;

namespace b1;

public class BGS_GameModeTestSystem : GameModeSystemBase
{
	private BGC_GameModeTestData TestData;

	private IBGC_GameStateTestData GameStateTestData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		TestData = RequireWritableData<BGC_GameModeTestData>();
		GameStateTestData = RequireReadOnlyGameStateData<IBGC_GameStateTestData, BGC_GameStateTestData>();
		GetGameEventCollection().Evt_BGS_TestGameMode += new Del_Void_Int(TestAddData);
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
		GetGameEventCollection().Evt_BGS_TestGameMode.Invoke(0);
		GetGameEventCollection().Evt_BGS_TestGameState.Invoke(0);
	}
}
