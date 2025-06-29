namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_FoxGuide : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_4_1_小狐狸引路";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5004, "RebirthPoint_HYS_Default_C_5", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "HFM_Tunnel_C_1", "灰烬林-火焰山隧道"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_Tunnel_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "TAMER_hys_shanzhen_01_C_1", "HYS_Monster_LavaPavement"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_7", "熔岩小径"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_7", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
