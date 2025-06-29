using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_BulletTrace")]
internal class AutoTest_BulletTrace : b1.AutoQA.AutoTest_Template
{
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

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_BulletTrace");
	}

	static AutoTest_BulletTrace()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_BulletTrace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_BulletTrace));
	}
}
