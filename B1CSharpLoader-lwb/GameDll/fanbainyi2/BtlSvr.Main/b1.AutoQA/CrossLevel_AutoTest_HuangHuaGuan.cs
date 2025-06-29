namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HuangHuaGuan : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "PSD_7_1_黄花观风景区";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4024, "RebirthPoint_PSD_Default_C_34", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_38", "空心林"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_38", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4026, "RebirthPoint_PSD_Default_C_38", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_jiachongzongbing_02_C_1", "PSD_Monster_HuangHuaGuan", "甲虫总兵"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_40", "山门"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_40", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4027, "RebirthPoint_PSD_Default_C_40", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_42", "金光苑"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_42", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
