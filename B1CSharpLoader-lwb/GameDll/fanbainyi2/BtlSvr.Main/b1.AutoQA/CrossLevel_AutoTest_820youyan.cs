namespace b1.AutoQA;

internal class CrossLevel_AutoTest_820youyan : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "820youyan";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new TestState_820EnterSelect(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys TestPassTime -900"));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 1));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_5", "土地庙"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_5", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 145961 -69372 3100"));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_psd_youyan_02_C_1", "PSD_Monster_YouYan", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_PressBtn(base.WorldContext, "确定"));
	}
}
