using System;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_ENDA_ShiZhongJing : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "ENDA_1_1_石中境";

	public override float TimeLimit => 2400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AddDebugUI(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		if (DateTime.Now.Day % 2 == 0)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 9800003 1 "));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 6210010 1 "));
		}
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_yuan_C_1", "ENDA02_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_jsds_C_1", "ENDA02_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_jsds_C_0", "ENDA02_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_EndCredits(base.WorldContext));
	}
}
