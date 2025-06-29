using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_HYS_FoxGuide")]
internal class AutoTest_HYS_FoxGuide : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5004, "RebirthPoint_HYS_Default_C_5", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "HFM_Tunnel_C_1", "灰烬林-火焰山隧道"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_Tunnel_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "TAMER_hys_shanzhen_01_C_1", "HYS_Monster_LavaPavement"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_7", "熔岩小径"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_7", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HYS_FoxGuide");
	}

	static AutoTest_HYS_FoxGuide()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HYS_FoxGuide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HYS_FoxGuide));
	}
}
