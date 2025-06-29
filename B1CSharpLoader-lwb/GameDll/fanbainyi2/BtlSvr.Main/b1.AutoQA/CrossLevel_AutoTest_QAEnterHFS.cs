namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAEnterHFS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAEnterHFS";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAEnterMap(base.WorldContext, 10));
	}
}
