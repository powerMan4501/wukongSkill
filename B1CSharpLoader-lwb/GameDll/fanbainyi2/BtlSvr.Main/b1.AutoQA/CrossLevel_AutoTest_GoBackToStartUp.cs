namespace b1.AutoQA;

internal class CrossLevel_AutoTest_GoBackToStartUp : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "GoBackToStartUp";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_GoBackToStartUp(base.WorldContext));
	}
}
