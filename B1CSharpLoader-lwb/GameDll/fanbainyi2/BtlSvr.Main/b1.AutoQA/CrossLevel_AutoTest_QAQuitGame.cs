namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAQuitGame : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAQuitGame";

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAQuitGame(base.WorldContext));
	}
}
