using b1.EventDelDefine;

namespace b1;

public class BGS_GameStateTestSystem : GameStateSystemBase
{
	private BGC_GameStateTestData TestData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		if (!UGSE_EngineFuncLib.IsStandAlone(GetOwner().World))
		{
			DebugConfig.CanOptimizeTick = false;
		}
	}

	public override void OnAttach()
	{
		TestData = RequireWritableData<BGC_GameStateTestData>();
		base.BGSEventCollection.Evt_BGS_TestGameState += new Del_Void_Int(TestAddData);
		base.BGSEventCollection.Evt_BGS_SwitchTickRateLogic += new Del_Void_Int(SwitchTickRateLogic);
	}

	private void TestAddData(int LevelAreaIdx)
	{
		TestData.TestID++;
	}

	private void SwitchTickRateLogic(int TickRateLogic)
	{
		TestData.StopOptimizeTickRate = TickRateLogic > 0;
		DebugConfig.CanOptimizeTick = TickRateLogic == 0;
	}
}
