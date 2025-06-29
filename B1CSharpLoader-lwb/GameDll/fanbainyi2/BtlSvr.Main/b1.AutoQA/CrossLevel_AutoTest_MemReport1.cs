namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MemReport1 : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemReport1";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "memreport -full -name=1"));
	}
}
