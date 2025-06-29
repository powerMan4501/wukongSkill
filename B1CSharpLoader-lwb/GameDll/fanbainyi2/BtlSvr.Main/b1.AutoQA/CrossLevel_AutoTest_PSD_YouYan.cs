using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_PSD_YouYan : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "PSD_3_2_蚰蜒精白僵蚕";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 4013, "RebirthPoint_PSD_Default_C_5", 40101101));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4001001 0"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901001 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901002 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901003 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Task.TryPushStage 4901004 1"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(145300.0, -73300.0, -1500.0), "百足虫坑前"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 145800, -72000, -3100"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(146842.0, -67288.0, -3200.0), "百足虫"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(151199.0, -57528.0, -2749.0), "中继点1"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(152896.0, -56788.0, -3314.0), "中继点2"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(162510.0, -65410.0, -2238.0), "中继点3"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(161583.0, -62974.0, -1580.0), "中继点4"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_PSD_Default_C_16", "绝想崖"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_16", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
