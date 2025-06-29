namespace b1.AutoQA;

internal class CrossLevel_AutoTest_SoulSkill_CompleteCoverage : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "SoulSkill_CompleteCoverage";

	public override float TimeLimit => 14400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 100));
		StateStack.Push(new TestState_MemTestPrepare(base.WorldContext));
		StateStack.Push(new TestState_SoulSkill_CompleteCoverage(base.WorldContext));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreSoulSkillCompleteCoverage.memreport", "PostSoulSkillCompleteCoverage.memreport"));
	}
}
