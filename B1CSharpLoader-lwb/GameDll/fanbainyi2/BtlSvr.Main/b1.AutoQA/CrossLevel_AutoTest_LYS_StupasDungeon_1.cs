namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_StupasDungeon_1 : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_2_1_地牢下层";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3027, "BP_RebirthPointZhaoHunFanBase_C_5", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_Door1_C_3"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_nosnow_C_1", "下层土地庙"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_nosnow_C_3", "中层土地庙"));
	}
}
