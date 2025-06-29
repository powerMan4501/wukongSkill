using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_LYS_OutsideTemple")]
internal class AutoTest_LYS_OutsideTemple : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3019, "RebirthPoint_LYS_Default_C_15", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-127825.0, -266575.0, -28283.0), "中段"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-152496.0, -261938.0, -27560.0), "门楼"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_24", "长生大道"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_LYS_OutsideTemple");
	}

	static AutoTest_LYS_OutsideTemple()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_LYS_OutsideTemple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_LYS_OutsideTemple));
	}
}
