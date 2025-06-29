namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ManualCollectPlayGoResource : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "ManualCollectPlayGoResource";

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MonitorOpeningEnd(base.WorldContext));
		StateStack.Push(new TestState_QAQuitGame(base.WorldContext));
	}
}
