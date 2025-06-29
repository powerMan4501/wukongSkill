namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFS_HFDW : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFS_6_1_黑风大王战";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1006, "RebirthPoint_HFS_C_2", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "BPO_Door02_C_0"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_hfdw_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext, 5201));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_Tunnel_C_1", "HFS01_Item_Cave"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_11", "洞外"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFS_C_11", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
