using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_HYS_HongHaiEr")]
internal class AutoTest_HYS_HongHaiEr : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5008, "RebirthPoint_HYS_Default_C_13", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_honghaier_01a_C_0", "红孩儿", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hys_honghaier_01a_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hys_honghaier_02a_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HYS_HongHaiEr");
	}

	static AutoTest_HYS_HongHaiEr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HYS_HongHaiEr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HYS_HongHaiEr));
	}
}
