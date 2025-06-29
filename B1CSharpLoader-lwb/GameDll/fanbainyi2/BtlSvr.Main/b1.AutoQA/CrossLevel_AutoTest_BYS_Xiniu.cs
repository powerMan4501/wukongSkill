using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BYS_Xiniu : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BYS_2_1_犀牛";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 9803, "RebirthPoint_HFS_C_0", 90001010));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(75857.0, -19906.0, 15293.0), "犀牛", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_szlc_xiniu_01_C_10", "BYS_Monster_Xiniu", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 12002));
	}
}
