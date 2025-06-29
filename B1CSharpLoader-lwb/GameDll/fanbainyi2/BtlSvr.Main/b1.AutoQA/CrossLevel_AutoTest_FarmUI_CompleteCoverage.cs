namespace b1.AutoQA;

internal class CrossLevel_AutoTest_FarmUI_CompleteCoverage : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "FarmUI_CompleteCoverage";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 100));
		StateStack.Push(new TestState_MemTestPrepare(base.WorldContext));
		StateStack.Push(new TestState_FarmUI_CompleteCoverage(base.WorldContext));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreFarmCompleteCoverage.memreport", "PostFarmCompleteCoverage.memreport"));
	}
}
