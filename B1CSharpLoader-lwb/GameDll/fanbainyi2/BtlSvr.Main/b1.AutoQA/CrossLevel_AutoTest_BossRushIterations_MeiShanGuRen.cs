namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BossRushIterations_MeiShanGuRen : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BossRushIterations_8_MeiShanGuRen";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushIterations 8"));
	}
}
