using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_HuangCun : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_5_1_荒村从中过";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2006, "RebirthPoint_HFM_Default_C_4", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-92582.0, 51092.0, 839.0), "荒村中央"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -96455, 50086, 839"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_5", "定风庄", 1500));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_5", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
