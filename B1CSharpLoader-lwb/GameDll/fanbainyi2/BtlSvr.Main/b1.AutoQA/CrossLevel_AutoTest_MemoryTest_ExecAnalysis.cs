namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MemoryTest_ExecAnalysis : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemoryTest_ExecAnalysis";

	public override float TimeLimit => 14400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreMemoryTest.memreport", "PostMemoryTest.memreport"));
	}
}
