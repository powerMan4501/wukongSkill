using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_HFS_NV_Niu")]
internal class AutoTest_HFS_NV_Niu : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(this, "EnableAllScreenMessages"));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(this));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(this));
		string[] extraArgs = new string[1] { "0.7" };
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(this, "Unit_HFM_Niu_01_C_1", AutoTestNodeLib.AutoBattleExitCondition.HealthPercent, extraArgs));
		StateStack.Push(new TestState_NV_Niu_JudegSequence(this));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(this, "Unit_HFM_Niu_01_C_1", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFS_NV_Niu");
	}

	static AutoTest_HFS_NV_Niu()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFS_NV_Niu)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFS_NV_Niu));
	}
}
