namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_LeiYinTemple : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_6_1_雷音大殿";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3022, "RebirthPoint_LYS_Default_C_24", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_LYS_Mo2_C_4", "魔将02"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_32", "大殿"));
	}
}
