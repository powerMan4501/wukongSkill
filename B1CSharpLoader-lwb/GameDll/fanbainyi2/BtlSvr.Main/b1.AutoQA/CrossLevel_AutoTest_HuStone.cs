using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HuStone : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_4_1_血池虎先锋";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2005, "RebirthPoint_HFM_Default_C_12", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -59565 27735 -91"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		UClass uClass = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Design/Units/HFM/Unit_HFM_Hu_Stone_01.Unit_HFM_Hu_Stone_01_C'", ELoadResourceType.SyncLoadAndCache);
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, uClass, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new TestState_HuStoneJudgeSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_4", "忘忧桥"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_4", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
