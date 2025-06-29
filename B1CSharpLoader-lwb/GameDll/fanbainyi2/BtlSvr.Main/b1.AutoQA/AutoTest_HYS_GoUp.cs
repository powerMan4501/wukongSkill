using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_HYS_GoUp")]
internal class AutoTest_HYS_GoUp : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5011, "RebirthPoint_HYS_Default_C_4", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(1854.0, 34079.0, 18818.0), "土地公SEQ触发盒", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hys_tudigong_01a_C_0", AutoTestNodeLib.AutoBattleExitCondition.CanNotLock));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hys_tudigong_01a_C_0", AutoTestNodeLib.AutoBattleExitCondition.CanNotLock));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, 10000, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hys_diaozuiyusaigui_C_1", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(1657.0, 48141.0, 21176.0), "上山路上"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(10449.0, 60803.0, 24917.0), "火焰战车前"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_zhanche_01c_C_0", "HYS_Monster_JDS", "罗刹宫火焰战车"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_0", "铁球环道"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_0", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HYS_GoUp");
	}

	static AutoTest_HYS_GoUp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HYS_GoUp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HYS_GoUp));
	}
}
