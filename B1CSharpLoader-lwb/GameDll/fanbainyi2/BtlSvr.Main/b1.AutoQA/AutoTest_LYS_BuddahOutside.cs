using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_LYS_BuddahOutside")]
internal class AutoTest_LYS_BuddahOutside : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3015, "RebirthPoint_LYS_Default_C_10", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 3901002 0"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 3401006 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_mile_C_1", "LYS_Monster_FrontMountain"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "LYS_XiaoMiLe_C_13", "LYS_Item_xiaomile_quest", "弥勒像1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_XiaoMiLe_C_13"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "LYS_XiaoMiLe_C_17", "LYS_Item_xiaomile_quest", "弥勒像2"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_XiaoMiLe_C_17"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "LYS_XiaoMiLe_C_7", "LYS_Item_xiaomile_quest", "弥勒像3"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_XiaoMiLe_C_7"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "LYS_XiaoMiLe_C_15", "LYS_Item_xiaomile_quest", "弥勒像4"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_XiaoMiLe_C_15"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_LYS_BuddahOutside");
	}

	static AutoTest_LYS_BuddahOutside()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_LYS_BuddahOutside)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_LYS_BuddahOutside));
	}
}
