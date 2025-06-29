namespace b1.AutoQA;

internal class CrossLevel_AutoTest_PSD_BaiYanMoJun : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "PSD_8_1_决战百眼魔君";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4028, "RebirthPoint_PSD_Default_C_42", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_PSD_BaiYanMoJun_01_C_0", "PSD_Monster_BaiYanMoJun", "百眼魔君", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_PSD_BaiYanMoJun_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}
}
