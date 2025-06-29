using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_HFS_NV_WoodDragon")]
internal class AutoTest_HFS_NV_WoodDragon : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(this, "EnableAllScreenMessages"));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(this));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(this));
		StateStack.Push(new AutoTestNodeLib.TestState_SetPlayerAttack(this, 175));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(this, "Unit_LYS_WuDuLong_02A_C_8", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFS_NV_WoodDragon");
	}

	static AutoTest_HFS_NV_WoodDragon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFS_NV_WoodDragon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFS_NV_WoodDragon));
	}
}
