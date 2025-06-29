namespace b1.AutoQA;

internal class CrossLevel_AutoTest_AutoPreciseDodge : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "AutoPreciseDodge";

	public override float TickInterval => 0f;

	public override float TimeLimit => 86400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new b1.AutoQA.TestState_QuickTest(base.WorldContext));
	}
}
