using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HYS_StoneForest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HYS_3_1_石林大探险";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 5003, "RebirthPoint_HYS_Default_C_3", 50101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(92617.0, -94050.0, 29166.0), "黑貘兽大门"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_Door3_C_2"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hys_zhanche_01b_C_0", "HYS_Monster_JDS", "二号战车"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 95835 -74476 22330"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new TestState_KillBigHead(base.WorldContext, "TAMER_hys_jiruhuo_C_0", "HYS_Monster_JRHKRF", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new TestState_KillBigHead(base.WorldContext, "TAMER_hys_kuairufeng_01_C_0", "HYS_Monster_JRHKRF", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
	}
}
