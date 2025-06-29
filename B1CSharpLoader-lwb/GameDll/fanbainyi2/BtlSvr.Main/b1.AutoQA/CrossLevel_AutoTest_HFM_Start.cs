namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_Start : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_1_1_开场到鼠村";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AddDebugUI(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_0", "沙门村口（鼠村正门前）", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_0", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
