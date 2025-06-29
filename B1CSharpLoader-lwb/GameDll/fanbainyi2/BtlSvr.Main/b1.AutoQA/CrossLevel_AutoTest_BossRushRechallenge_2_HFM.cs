namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BossRushRechallenge_2_HFM : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BossRushRechallenge_2_HFM";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 11"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 12"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 13"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 14"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 15"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 16"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 17"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 18"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 19"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 20"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 21"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 22"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 23"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 24"));
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 25"));
	}
}
