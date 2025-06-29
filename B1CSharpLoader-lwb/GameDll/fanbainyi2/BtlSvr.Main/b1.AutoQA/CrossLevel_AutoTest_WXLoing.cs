namespace b1.AutoQA;

internal class CrossLevel_AutoTest_WXLoing : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAWXLogin";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "EnableAllScreenMessages"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new TestState_QAWXLogin(base.WorldContext));
	}
}
