namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BattleTrace : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "GamePlayTrace_Battle";

	public override float TimeLimit => 36000f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.StartFetchTick"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SetCanTriggerGroupAI 0"));
		StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(base.WorldContext, "/Game/00Main/Design/Units/GYCY/TAMER_gycy_lang_03.TAMER_gycy_lang_03_C", 20));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 5));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.GamePlayTraceStart TraceBattle"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SetAllUnitTargetIsFirstPlayer"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 180));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.GamePlayTraceEnd"));
	}
}
