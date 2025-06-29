using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_LYS_LeiYinTemple")]
internal class AutoTest_LYS_LeiYinTemple : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3022, "RebirthPoint_LYS_Default_C_24", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_LYS_Mo2_C_4", "魔将02"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_32", "大殿"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_LYS_LeiYinTemple");
	}

	static AutoTest_LYS_LeiYinTemple()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_LYS_LeiYinTemple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_LYS_LeiYinTemple));
	}
}
