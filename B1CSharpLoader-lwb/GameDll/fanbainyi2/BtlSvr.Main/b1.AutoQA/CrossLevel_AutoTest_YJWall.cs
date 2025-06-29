namespace b1.AutoQA;

internal class CrossLevel_AutoTest_YJWall : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "YJWall";

	public override float TickInterval => 0.5f;

	public override float TimeLimit => 259200f;

	protected override void RegisterTestState()
	{
		for (int i = 1; i <= 10000; i++)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_yangjian_01_C_1", "MS_b01_monster", (AutoTestNodeLib.AutoBattleExitCondition)33, "0.2"));
			StateStack.Push(new AutoTestNodeLib.TestState_LogInfo(base.WorldContext, "被杨戬击杀了" + i + "次"));
			if (i % 2 == 0)
			{
				StateStack.Push(new AutoTestNodeLib.TestState_RandomSetSpell(base.WorldContext));
				StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.FullFaBaoEnergy"));
				StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.FullVigorEnergy"));
				StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.FullTransEnergy 1"));
				StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			}
		}
	}
}
