namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ResumeGame : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemoryTest_ResumeGame";

	public override CaseType GetCaseType()
	{
		return CaseType.Normal;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_ResumeGame(base.WorldContext));
	}
}
