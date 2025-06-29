namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MemoryTest_ExportPreMemReport : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemoryTest_ExportPreMemReport";

	public override float TimeLimit => 600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MemoryTest_ExportMemReport(base.WorldContext, "PreMemoryTest"));
	}
}
