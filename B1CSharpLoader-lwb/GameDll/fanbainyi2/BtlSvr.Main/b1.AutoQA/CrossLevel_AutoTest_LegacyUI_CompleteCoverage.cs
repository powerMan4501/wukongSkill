namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LegacyUI_CompleteCoverage : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LegacyUI_CompleteCoverage";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 100));
		StateStack.Push(new TestState_MemTestPrepare(base.WorldContext));
		StateStack.Push(new TestState_LegacyUI_CompleteCoverage(base.WorldContext));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreLegacyCompleteCoverage.memreport", "PostLegacyCompleteCoverage.memreport"));
	}
}
