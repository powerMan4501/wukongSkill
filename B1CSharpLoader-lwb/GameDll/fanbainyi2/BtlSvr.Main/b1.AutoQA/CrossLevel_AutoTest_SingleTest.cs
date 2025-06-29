namespace b1.AutoQA;

internal class CrossLevel_AutoTest_SingleTest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "SingleTest";

	public override float TickInterval => 0.5f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new b1.AutoQA.TestState_QuickTest(base.WorldContext));
	}
}
