namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MGD_Opening : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MGD_1_1_序章杨戬战";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_yangjian_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.HealthPercent, "0.05"));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.SequenceBegin));
		StateStack.Push(new TestState_MonitorOpeningEnd(base.WorldContext));
	}
}
