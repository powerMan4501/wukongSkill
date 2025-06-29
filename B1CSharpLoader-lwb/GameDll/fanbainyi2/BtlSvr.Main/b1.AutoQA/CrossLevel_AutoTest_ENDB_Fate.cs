namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ENDB_Fate : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "ENDB_1_1_无法逃避的命运";

	public override float TimeLimit => 2400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 6202, "RebirthPoint_MS_Default_C_1", 62101100));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_mgd_yangjian_01_C_1", "杨戬平台", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_yangjian_01_C_1", "MS_b01_monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		string[] actorNames = new string[4] { "TAMER_hgs_chiguo_C_0", "TAMER_hgs_duowen_C_0", "TAMER_hgs_guangmu_C_0", "TAMER_hgs_zengzhang_C_0" };
		StateStack.Push(new AutoTestNodeLib.TestState_BattleWithMulti(base.WorldContext, "MS_b01_monster", (AutoTestNodeLib.AutoBattleExitCondition)3, actorNames));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_erlangshen_01_C_0", "MS_b01_monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
