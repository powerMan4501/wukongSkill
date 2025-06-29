namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFS_GYCY : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFS_3_1_大白狼后院";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1004, "RebirthPoint_HFS_C_5", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_dbl_01_C_0", "HFS01_Monster_Old_GYCY", "大白狼", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_dbl_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_lang_03_huoba_C_1", "HFS01_Monster_Graveyard", "禅院后院"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_yaxiangke_C_0", "HFS01_Monster_Graveyard", "竹林入口"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_6", "翠竹林"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFS_C_6", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
