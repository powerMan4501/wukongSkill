using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_PSD_HuangHuaGuan")]
internal class AutoTest_PSD_HuangHuaGuan : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4024, "RebirthPoint_PSD_Default_C_34", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_38", "空心林"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_38", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4026, "RebirthPoint_PSD_Default_C_38", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_jiachongzongbing_02_C_1", "PSD_Monster_HuangHuaGuan", "甲虫总兵"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_40", "山门"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_40", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4027, "RebirthPoint_PSD_Default_C_40", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_42", "金光苑"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_42", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PSD_HuangHuaGuan");
	}

	static AutoTest_PSD_HuangHuaGuan()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PSD_HuangHuaGuan)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PSD_HuangHuaGuan));
	}
}
