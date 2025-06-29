namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_StartSeqOnly : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_0_1_黄风岭开场播片";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
