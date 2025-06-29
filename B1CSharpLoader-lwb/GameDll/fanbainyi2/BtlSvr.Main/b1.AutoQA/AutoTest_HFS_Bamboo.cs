using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_HFS_Bamboo")]
internal class AutoTest_HFS_Bamboo : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1005, "RebirthPoint_HFS_C_6", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_she_02_passive_C_1", "HFS01_Monster_Bamboo", "蛇阵"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_she_03_C_4", "HFS01_Monster_Bamboo", "拐弯"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_she_02_C_6", "HFS01_Monster_Bamboo", "竹林"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_gycy_she_01_C_0", "HFS01_Monster_Bamboo", "蛇书记", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_gycy_she_01_C_0", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_7", "竹林后山"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFS_C_7", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFS_Bamboo");
	}

	static AutoTest_HFS_Bamboo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFS_Bamboo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFS_Bamboo));
	}
}
