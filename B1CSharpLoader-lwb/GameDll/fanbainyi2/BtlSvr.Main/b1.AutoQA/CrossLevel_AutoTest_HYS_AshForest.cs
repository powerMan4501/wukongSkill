namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_AshForest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_2_1_灰烬林前行";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5002, "RebirthPoint_HYS_Default_C_1", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_yinbingniumo_01_C_1", "HYS_Monster_AshForest", "堵路的阴兵牛魔"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_3", "烬村"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_3", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
