namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BYS_Xuelu : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BYS_3_1_血鹿";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 9802, "RebirthPoint_HFS_C_2", 90001010));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -49178, -98325, 5881"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_szlc_yingzuilu_01_C_1", "BYS_Monster_Xuelu", AutoTestNodeLib.AutoBattleExitCondition.CanNotLock));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 30));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 12003));
	}
}
