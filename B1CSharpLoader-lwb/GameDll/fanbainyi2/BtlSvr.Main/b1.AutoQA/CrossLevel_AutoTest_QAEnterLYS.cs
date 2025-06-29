namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAEnterLYS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAEnterLYS";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAEnterMap(base.WorldContext, 30));
	}
}
