namespace b1.AutoQA;

internal class CrossLevel_AutoTest_PlaneMover : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "PlaneMover";

	public override float TickInterval => 0f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new b1.AutoQA.TestState_ChangeAbpSetting(base.WorldContext));
	}
}
