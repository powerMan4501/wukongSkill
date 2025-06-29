namespace b1.AutoQA;

internal class CrossLevel_AutoTest_MemoryTest_BackToStart : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "MemoryTest_BackToStart";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MemoryTest_BackToStart(base.WorldContext));
	}
}
