namespace b1.AutoQA;

internal class CrossLevel_AutoTest_SingleTest2 : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "Dage_100D_Battle";

	public override float TickInterval => 0.5f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_dage_C_0", "PSD_Monster_Dage", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
	}
}
