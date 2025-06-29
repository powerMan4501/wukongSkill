using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_LYS_StupasDungeon_1")]
internal class AutoTest_LYS_StupasDungeon_1 : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3027, "BP_RebirthPointZhaoHunFanBase_C_5", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "LYS_Door1_C_3"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_nosnow_C_1", "下层土地庙"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_nosnow_C_3", "中层土地庙"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_LYS_StupasDungeon_1");
	}

	static AutoTest_LYS_StupasDungeon_1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_LYS_StupasDungeon_1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_LYS_StupasDungeon_1));
	}
}
