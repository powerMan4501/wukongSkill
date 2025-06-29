using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_LYS_Tortoise")]
internal class AutoTest_LYS_Tortoise : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3012, "RebirthPoint_LYS_Default_C_16", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_xuehou_C_1", "LYS_Monster_Forest", "安身寺", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_xuehou_C_1", "LYS_Monster_Forest", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext, 5102));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 5102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_lys_frozenmon_C_26", "LYS_Monster_Forest", "冰冻小怪"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "BP_OverlapBox_C_30", "LYS_Volume"));
		StateStack.Push(new AutoTestNodeLib.TestState_Glide(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_kjlwoman_C_1", "LYS_Monster_KJLWoman", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_NPC_ZhuBaJie_01B_Guibei_2_C_1", "LYS_Item_KJLWoman", "Exit八戒"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_NPC_ZhuBaJie_01B_Guibei_2_C_1", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_10", "戒语廊"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_LYS_Tortoise");
	}

	static AutoTest_LYS_Tortoise()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_LYS_Tortoise)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_LYS_Tortoise));
	}
}
