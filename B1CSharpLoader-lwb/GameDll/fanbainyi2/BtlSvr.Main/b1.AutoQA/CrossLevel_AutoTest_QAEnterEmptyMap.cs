namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAEnterEmptyMap : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAEnterEmptyMap";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAEnterMap(base.WorldContext, 4444));
	}
}
