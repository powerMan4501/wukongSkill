using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_PSD_SanCeng")]
internal class AutoTest_PSD_SanCeng : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4012, "RebirthPoint_PSD_Default_C_16", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4001001 0"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901001 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901002 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901003 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901004 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "PSD_interact_foshouchong_C_1", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_psd_foshouchong_02a_C_1", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 123500, -39300, -7000"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(125336.0, -42389.0, -6926.0), "PV03", 0, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 127300, -56700, -9900"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_22", "盘丝洞底层"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_22", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_chong_01_C_1", "PSD_Monster_PSDSanCeng", "挡路双刀虫"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(126342.0, -41354.0, -11683.0), "若仙庵缝前"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_26", "若仙庵"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_26", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PSD_SanCeng");
	}

	static AutoTest_PSD_SanCeng()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PSD_SanCeng)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PSD_SanCeng));
	}
}
