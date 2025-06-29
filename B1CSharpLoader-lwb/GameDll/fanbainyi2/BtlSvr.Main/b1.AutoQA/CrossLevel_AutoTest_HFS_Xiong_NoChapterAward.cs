namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFS_Xiong_NoChapterAward : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFS_8_1_决战黑熊精_无章节中转";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1008, "RebirthPoint_HFS_C_4", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -69432 28462 10325"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_xiong_02_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
