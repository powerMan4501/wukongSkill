namespace b1.AutoQA;

internal class CrossLevel_Perf_AutoTest_HFS_Forest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "PerfAutoTest_HFS_Forest";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_StartCapturingAdvancedInfo(base.WorldContext, "HFS_Forest", 0, CollectInsightData: true));
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1002, "RebirthPoint_HFS_C_1", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_lang_04_C_0", "HFS01_Monster_Forest", "火刀狼", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_lang_04_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_yanjianxi_01b_C_0", "HFS01_Monster_Forest", "幽魂"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_lang_06_C_0", "HFS01_Monster_Old_GYCY", "守门员"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_5", "土地庙"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFS_C_5", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_StopCapturingAdvancedInfo(base.WorldContext));
	}
}
