namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAEnterENDB : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAEnterENDB";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_QAEnterMap(base.WorldContext, 62));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
