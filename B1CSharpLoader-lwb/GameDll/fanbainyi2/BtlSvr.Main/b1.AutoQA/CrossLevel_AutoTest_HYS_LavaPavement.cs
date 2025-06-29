namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_LavaPavement : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_5_1_熔岩小径险";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5005, "RebirthPoint_HYS_Default_C_7", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_yinbinghoumo_C_3", "HYS_Monster_LavaPavement", "战车前阴兵猴魔"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 24576 9991 12070"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		string[] actorNames = new string[2] { "TAMER_hys_yunliwu_C_0", "TAMER_hys_wuliyun_C_0" };
		StateStack.Push(new AutoTestNodeLib.TestState_BattleWithMulti(base.WorldContext, "HYS_Monster_YLWWLY", (AutoTestNodeLib.AutoBattleExitCondition)3, actorNames));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 17927 17152 13060"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "BPO_Door03_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_9", "罗刹宫入口"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_9", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
