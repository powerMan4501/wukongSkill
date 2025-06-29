namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_RoundAbout : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_7_1_铁球环道长";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5010, "RebirthPoint_HYS_Default_C_0", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_niaozui_C_1", "HYS_Monster_RoundAbout", "缓台鸟嘴", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_13", "铁球环道", 0, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
