using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_HFM_Cave")]
internal class AutoTest_HFM_Cave : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2004, "RebirthPoint_HFM_Default_C_2", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "TAMER_hfm_shu_05a_C_2", "HFM02_Cave_Monster"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "HFM_Tunnel_C_2", "利爪洞窟隧道口"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_Tunnel_C_2"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "TAMER_hfm_magu_01a_C_0", "HFM02_Cave_Monster"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_3", "卧虎寺山门", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_3", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFM_Cave");
	}

	static AutoTest_HFM_Cave()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFM_Cave)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFM_Cave));
	}
}
