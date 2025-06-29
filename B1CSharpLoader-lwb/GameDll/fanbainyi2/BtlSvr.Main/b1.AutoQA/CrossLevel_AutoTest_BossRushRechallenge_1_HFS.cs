namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BossRushRechallenge_1_HFS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BossRushRechallenge_1_HFS";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 2"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 3"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 4"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 5"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 6"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 7"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 8"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 10"));
	}
}
