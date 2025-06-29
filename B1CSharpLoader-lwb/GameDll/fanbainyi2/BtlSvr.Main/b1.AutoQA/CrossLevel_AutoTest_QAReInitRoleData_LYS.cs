namespace b1.AutoQA;

internal class CrossLevel_AutoTest_QAReInitRoleData_LYS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "QAReInitRoleData_LYS";

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_AdjustRoleDataByID(base.WorldContext, 31));
	}
}
