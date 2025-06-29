using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LYS_BuddahInside : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "LYS_4_2_弥勒像内";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 3016, "RebirthPoint_LYS_Default_C_17", 30101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-32878.0, -317599.0, -6603.0), "僧面", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_LYS_SengMian_01_C_0", "LYS_Monster_theGreatBuddah", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -41941, -319569, -2250"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_LYS_SengMian_01_MagaVer_C_1", "LYS_Monster_theGreatBuddah"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -75440, -319775, -2419"));
		StateStack.Push(new AutoTestNodeLib.TestState_Glide(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_LYS_Default_C_15", "快活林"));
	}
}
