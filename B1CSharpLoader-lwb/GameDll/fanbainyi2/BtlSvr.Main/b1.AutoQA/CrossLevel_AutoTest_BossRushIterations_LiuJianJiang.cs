namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BossRushIterations_LiuJianJiang : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BossRushIterations_4_LiuJianJiang";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushIterations 4"));
	}
}
