namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFS_Quest_HongLinMang : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFS_Q_2_HongLinMang";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1010, "RebirthPoint_HFS_C_7", 10101102));
	}
}
