namespace b1.AutoQA;

internal class CrossLevel_AutoTest_BulletTrace : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "GamePlayTrace_BulletSkill";

	public override float TimeLimit => 36000f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.LockHP"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SetCanTriggerGroupAI 0"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllPlaySequenceNode 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllChapterMovie 1"));
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BulletTrace_BulletSkillIDConfigPath, out var ConfigInfo);
		if (ConfigInfo != null && ConfigInfo.StringValue != "")
		{
			StateStack.Push(new TestState_ATPAllBulletSkillTest(base.WorldContext, ConfigInfo.StringValue, QuitEditorPerUnit: false));
		}
		StateStack.Push(new TestState_ExportWarningTaskNameToCSV(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 180));
	}
}
