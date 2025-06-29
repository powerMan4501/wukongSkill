namespace b1.AutoQA;

internal class CrossLevel_AutoTest_820youyan_AutoMove : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "820youyan_AutoMove";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new TestState_820EnterSelect(base.WorldContext));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 1));
		StateStack.Push(new TestState_AutoMove(base.WorldContext));
	}
}
