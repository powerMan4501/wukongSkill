using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_HFM_ShaMenGang")]
internal class AutoTest_HFM_ShaMenGang : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2002, "RebirthPoint_HFM_Default_C_0", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_1", "沙门岗（鼠村山顶）"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_1", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFM_ShaMenGang");
	}

	static AutoTest_HFM_ShaMenGang()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFM_ShaMenGang)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFM_ShaMenGang));
	}
}
