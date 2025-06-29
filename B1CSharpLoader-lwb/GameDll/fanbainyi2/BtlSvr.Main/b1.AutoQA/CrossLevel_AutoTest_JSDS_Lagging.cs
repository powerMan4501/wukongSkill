namespace b1.AutoQA;

internal class CrossLevel_AutoTest_JSDS_Lagging : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "JSDS_Lagging";

	public override float TickInterval => 0.5f;

	public override float TimeLimit => 259200f;

	protected override void RegisterTestState()
	{
		for (int i = 1; i <= 10000; i++)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_jsds_C_1", "ENDA02_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
			StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_jsds_C_0", "ENDA02_Monster", (AutoTestNodeLib.AutoBattleExitCondition)33, "0.2"));
			StateStack.Push(new AutoTestNodeLib.TestState_LogInfo(base.WorldContext, "被大圣击杀了" + i + "次"));
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
