namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BYS_Start : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BYS_1_1_王灵官";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AddDebugUI(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBox_C_2", "BYS_Volume", "天兵刷新盒子1"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBox_C_3", "BYS_Volume", "天兵刷新盒子2"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBox_C_5", "BYS_Volume", "天兵刷新盒子3"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBox_C_4", "BYS_Volume", "天兵刷新盒子4"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBox_C_6", "BYS_Volume", "天兵刷新盒子5"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_1", "青嶂道"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_OverlapBoxForSeq_C_5", "BYS_Volume", "王灵官", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_szlc_wanglingguan_01_C_1", "BYS_Monster_WLG", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 5009));
	}
}
