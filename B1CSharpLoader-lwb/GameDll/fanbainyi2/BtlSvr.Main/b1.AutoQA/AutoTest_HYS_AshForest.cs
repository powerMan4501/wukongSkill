using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_HYS_AshForest")]
internal class AutoTest_HYS_AshForest : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5002, "RebirthPoint_HYS_Default_C_1", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_yinbingniumo_01_C_1", "HYS_Monster_AshForest", "堵路的阴兵牛魔"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HYS_Default_C_3", "烬村"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HYS_Default_C_3", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HYS_AshForest");
	}

	static AutoTest_HYS_AshForest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HYS_AshForest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HYS_AshForest));
	}
}
