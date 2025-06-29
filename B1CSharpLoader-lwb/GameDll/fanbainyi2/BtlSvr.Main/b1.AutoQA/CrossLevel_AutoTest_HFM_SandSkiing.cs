using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_SandSkiing : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_7_1_滑沙大冒险";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2008, "RebirthPoint_HFM_Default_C_6", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-121880.0, 13350.0, 3780.0), "滑沙道前"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -121880, 15180, 2890"));
		StateStack.Push(new AutoTestNodeLib.TestState_Glide(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_8", "镇风门", 0, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new TestState_SandSkiingJudgeSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_8", "镇风门"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_8", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
