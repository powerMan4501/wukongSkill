using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_ZYS_Whole")]
internal class AutoTest_ZYS_Whole : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 8001, "RebirthPoint_PSD_Invisible_C_1", 80001010));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_StartCapturingAdvancedInfo(base.WorldContext, "ZYS_Whole", 0, CollectInsightData: true));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_1", "紫云山1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_1", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_3", "紫云山2"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_5", "紫云山3", 100));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_bhl_gushoufsq_01_C_0", "ZYS01_Monster_MRXG", "昴日星官", 5000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		string[] extraArgs = new string[1] { "0.1" };
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_bhl_gushoufsq_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.HealthPercent, extraArgs));
		StateStack.Push(new AutoTestNodeLib.TestState_StopCapturingAdvancedInfo(base.WorldContext));
	}

	public override void SetupTest()
	{
		base.SetupTest();
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn());
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_ZYS_Whole");
	}

	static AutoTest_ZYS_Whole()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_ZYS_Whole)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_ZYS_Whole));
	}
}
