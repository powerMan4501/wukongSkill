namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MemReportCompare : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemReportCompare";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Memreport.ResolveObjectRef 1 2"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys CheckEventMemoryLeak"));
	}
}
