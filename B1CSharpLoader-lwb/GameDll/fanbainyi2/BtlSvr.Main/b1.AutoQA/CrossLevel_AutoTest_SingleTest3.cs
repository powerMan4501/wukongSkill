namespace b1.AutoQA;

internal class CrossLevel_AutoTest_SingleTest3 : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "SingleTest3";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_BossRushAutoBattle(base.WorldContext, "b.sys BossRushRechallenge 9"));
	}
}
