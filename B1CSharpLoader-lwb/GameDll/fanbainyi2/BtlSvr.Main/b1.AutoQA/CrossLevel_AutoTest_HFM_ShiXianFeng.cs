namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_ShiXianFeng : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_5_2_伥鬼石先锋";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2007, "RebirthPoint_HFM_Default_C_5", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hfm_shawuliang_01a_C_0", "沙无量"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "PrefabActor_0", "HFM02_Valley_Monster", "石先锋", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_HFM_ShiXianFeng_01_C_1", "HFM02_Valley_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_6", "土地庙"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_6", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
