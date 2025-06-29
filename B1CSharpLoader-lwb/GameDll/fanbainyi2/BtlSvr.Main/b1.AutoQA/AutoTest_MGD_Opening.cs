using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_MGD_Opening")]
internal class AutoTest_MGD_Opening : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_mgd_yangjian_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.HealthPercent, "0.05"));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.SequenceBegin));
		StateStack.Push(new TestState_MonitorOpeningEnd(base.WorldContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_MGD_Opening");
	}

	static AutoTest_MGD_Opening()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_MGD_Opening)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_MGD_Opening));
	}
}
