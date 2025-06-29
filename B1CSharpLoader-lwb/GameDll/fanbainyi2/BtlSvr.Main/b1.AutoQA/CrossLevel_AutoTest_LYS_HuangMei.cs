namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_HuangMei : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_7_1_黄眉悬塑";

	public override float TimeLimit => 2400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3026, "RebirthPoint_LYS_Default_C_32", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "BPO_Door05_HM_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_LYS_HuangMei_02_C_2", "LYS_Monster_HMPhaseOne", AutoTestNodeLib.AutoBattleExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_xuehou_C_2", "LYS_Item_RZD", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_RebirthPointZhaoHunFanBase_C_7", "LYS_PersistentLevel"));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_LYS_HuangMei_03_C_0", "LYS_Monster_HuangMei", AutoTestNodeLib.AutoBattleExitCondition.PlayerHasBuff, "10000"));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_LYS_HuangMei_03_C_0", "LYS_Monster_HuangMei", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}
}
