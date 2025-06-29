namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_QuietLake : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_1_2_鉴湖金龙";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3004, "RebirthPoint_LYS_Default_C_5", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_kjldragon_C_1", "LYS_Monster_KJLDragon", "亢金龙小庙", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_SetPlayerAttack(base.WorldContext, 2000));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_kjldragon_C_1", "LYS_Monster_KJLDragon", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_SetPlayerAttack(base.WorldContext, 200));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
