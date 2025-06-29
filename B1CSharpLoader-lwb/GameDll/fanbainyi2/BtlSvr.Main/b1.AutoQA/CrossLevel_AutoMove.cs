namespace b1.AutoQA;

internal class CrossLevel_AutoMove : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "AutoMove";

	public override float TimeLimit => 7200f;

	public void AutoMoveComplete()
	{
		if (GetCaseState() == CaseState.Running)
		{
			SetCaseState(CaseState.Succeeded);
		}
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_AutoMove(base.WorldContext));
	}
}
