namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAEnterMGD : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAEnterMGD";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAEnterMap(base.WorldContext, 13));
	}
}
