namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ReceiveChapterAward : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "ReceiveChapterAward";

	public override float TimeLimit => 300f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}
}
