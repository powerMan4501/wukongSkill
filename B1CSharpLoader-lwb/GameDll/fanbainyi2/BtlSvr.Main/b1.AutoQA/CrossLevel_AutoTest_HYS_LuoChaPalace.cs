namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_LuoChaPalace : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_6_1_挺进罗刹宫";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5006, "RebirthPoint_HYS_Default_C_9", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_niu_02_C_0", "HYS_Monster_LuoChaPalace", "把关的火焰青牛精"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_4", "罗刹宫内"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_4", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
