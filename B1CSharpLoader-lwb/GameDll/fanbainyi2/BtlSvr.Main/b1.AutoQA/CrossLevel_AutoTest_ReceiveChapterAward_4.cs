namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ReceiveChapterAward_4 : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAReceiveChapterAward_4";

	public override CaseType GetCaseType()
	{
		return CaseType.Normal;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}
}
