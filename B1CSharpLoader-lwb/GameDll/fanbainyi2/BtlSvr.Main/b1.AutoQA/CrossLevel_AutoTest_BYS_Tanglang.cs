namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BYS_Tanglang : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BYS_5_1_螳螂";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 9806, "RebirthPoint_HFS_C_3", 90001010));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 9810006 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 6));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_bys_zhubajie_tanglang_C_1", "八戒", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_szlc_tanglang01_C_1", "BYS_Monster_Tanglang", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 12003));
	}
}
