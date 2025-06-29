namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_Tortoise : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_3_1_龟背南岸";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3012, "RebirthPoint_LYS_Default_C_16", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_xuehou_C_1", "LYS_Monster_Forest", "安身寺", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_xuehou_C_1", "LYS_Monster_Forest", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext, 5102));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 5102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_frozenmon_C_26", "LYS_Monster_Forest", "冰冻小怪"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "BP_OverlapBox_C_30", "LYS_Volume"));
		StateStack.Push(new AutoTestNodeLib.TestState_Glide(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_kjlwoman_C_1", "LYS_Monster_KJLWoman", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_NPC_ZhuBaJie_01B_Guibei_2_C_1", "LYS_Item_KJLWoman", "Exit八戒"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_NPC_ZhuBaJie_01B_Guibei_2_C_1", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_10", "戒语廊"));
	}
}
