using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_HFS_Xiong")]
internal class AutoTest_HFS_Xiong : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1008, "RebirthPoint_HFS_C_4", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -69432 28462 10325"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_xiong_02_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext, 10, 20));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFS_Xiong");
	}

	static AutoTest_HFS_Xiong()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFS_Xiong)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFS_Xiong));
	}
}
