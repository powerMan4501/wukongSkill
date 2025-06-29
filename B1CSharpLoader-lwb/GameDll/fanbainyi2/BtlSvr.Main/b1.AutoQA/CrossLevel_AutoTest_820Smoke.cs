namespace b1.AutoQA;

internal class CrossLevel_AutoTest_820Smoke : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "820SmokeTest";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new TestState_820EnterSelect(base.WorldContext));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 1));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new TestState_820ExitMap(base.WorldContext));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 2));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new TestState_820ExitMap(base.WorldContext));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 3));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new TestState_820ExitMap(base.WorldContext));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 4));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new TestState_820ExitMap(base.WorldContext));
	}
}
