using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_PSD_BaiYanMoJun")]
internal class AutoTest_PSD_BaiYanMoJun : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4028, "RebirthPoint_PSD_Default_C_42", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_PSD_BaiYanMoJun_01_C_0", "PSD_Monster_BaiYanMoJun", "百眼魔君", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_PSD_BaiYanMoJun_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PSD_BaiYanMoJun");
	}

	static AutoTest_PSD_BaiYanMoJun()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PSD_BaiYanMoJun)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PSD_BaiYanMoJun));
	}
}
