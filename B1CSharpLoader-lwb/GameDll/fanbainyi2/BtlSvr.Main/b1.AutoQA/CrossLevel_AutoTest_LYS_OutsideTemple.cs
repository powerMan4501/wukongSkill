using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_OutsideTemple : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_5_1_朝圣之路";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3019, "RebirthPoint_LYS_Default_C_15", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-127825.0, -266575.0, -28283.0), "中段"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-152496.0, -261938.0, -27560.0), "门楼"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_24", "长生大道"));
	}
}
