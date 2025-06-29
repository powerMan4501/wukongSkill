namespace b1.AutoQA;

internal class CrossLevel_AutoTest_TakePhoto_CompleteCoverage : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "TakePhoto_CompleteCoverage";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 100));
		StateStack.Push(new TestState_MemTestPrepare(base.WorldContext));
		StateStack.Push(new TestState_TakePhoto_CompleteCoverage(base.WorldContext));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreTakePhotoCompleteCoverage.memreport", "PostTakePhotoCompleteCoverage.memreport"));
	}
}
