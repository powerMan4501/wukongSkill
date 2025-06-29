using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_HFS_NV_Waterfall")]
internal class AutoTest_HFS_NV_Waterfall : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(this, 1002, "RebirthPoint_HFS_C_1", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(this, new FVector(21132.0, -21405.0, 5708.0), "小桥", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(this, "b.teleportToPosition 21199 -30342 5337"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(this, "HFS_PuBu_C_1", "法宝交互点"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(this, "HFS_PuBu_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(this, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(this, "HFM_Stone_C_2", "瀑布一线天"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(this, "HFM_Stone_C_2"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(this, 20));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFS_NV_Waterfall");
	}

	static AutoTest_HFS_NV_Waterfall()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFS_NV_Waterfall)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFS_NV_Waterfall));
	}
}
