namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_ShaMenGang : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_2_1_鼠村大探险（旧）";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2002, "RebirthPoint_HFM_Default_C_0", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_1", "沙门岗（鼠村山顶）"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_1", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
