using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_820Valley : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "820Valley";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new TestState_820EnterSelect(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys TestPassTime -1500"));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 4));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_11", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_7", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hfm_stoneman_01_C_0", "HFM02_Valley_Monster", "石中人"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_hfm_stoneman_01_C_0"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -101878 -9142 7511"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hfm_shigong_01_C_5", "HFM02_Valley_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hfm_stoneman_01_C_0", "HFM02_Valley_Monster", "石中人"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_hfm_stoneman_01_C_0"));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_hfm_stoneman_01_C_0", "HFM02_Valley_Monster", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_hfm_stoneman_01_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 0));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_13", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "BP_hys_icedoorinteract_C_0", "HFM02_Valley_Item_sandfall", "门前流沙"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "BP_hys_icedoorinteract_C_0", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "HFM_HugeDoor_C_0", "HFM02_Valley_Item_sandfall", "锤龙大门"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_HugeDoor_C_0"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_JudgeMapID(base.WorldContext, 24));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_lys_chuilong_01a_C_1", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -60308 -52653 908"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "BPO_TreasureBox_08_C_3", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_JudgeMapID(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_1"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "HFM_BuddahHead_01_C_3", "HFM02_Valley_rd_QUEST"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_3"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_5"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_9"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "HFM_BuddahHead_01_C_11", "HFM02_Valley_rd_QUEST"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_11"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_BuddahHead_01_C_13"));
		StateStack.Push(new AutoTestNodeLib.TestState_Teleport(base.WorldContext, "TAMER_hfm_shigandang_01_C_0", "HFM02_Valley_Monster"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_hfm_shigandang_01_C_0", IgnoreInteractCheck: true, new FVector(-500.0, 0.0, 0.0)));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_HFM_ShiXianFeng_01_C_1", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_PressBtn(base.WorldContext, "确定"));
	}
}
