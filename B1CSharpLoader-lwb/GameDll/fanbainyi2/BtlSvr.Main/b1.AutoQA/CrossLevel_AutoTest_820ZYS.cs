namespace b1.AutoQA;

internal class CrossLevel_AutoTest_820ZYS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "820ZYS";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 10));
		StateStack.Push(new TestState_820EnterSelect(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys TestPassTime -1500"));
		StateStack.Push(new TestState_820EnterMap(base.WorldContext, 4));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_6", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_0", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_xiezijing_og_npc_C_1", "ZYS01_Monster_XieZi", "蝎子精"));
		StateStack.Push(new TestState_DestroyDroppableDestructionActor(base.WorldContext, "BP_zys_jiugang_droppable_xiezijing_C_0", "ZYS01_Item_XieZi"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_psd_xiezijing_og_C_0", "ZYS01_Monster_XieZi", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_8", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_duchongsishi_C_7", "ZYS01_Monster_village", "道士大哥"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_psd_duchongsishi_C_7", IgnoreInteractCheck: true));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "Tamer_PSD_daoshi_03_zys_C_3", "ZYS01_Monster_village", "路边道士A"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "Tamer_PSD_daoshi_03_zys_C_0", "ZYS01_Monster_village", "路边道士B"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "Tamer_PSD_daoshi_03_zys_C_8", "ZYS01_Monster_village", "路边道士C"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_psd_duchongsishi_C_7", "ZYS01_Monster_village", "道士大哥"));
		StateStack.Push(new AutoTestNodeLib.TestState_B1GM(base.WorldContext, "additem 4017"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "TAMER_psd_duchongsishi_C_7"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_psd_daoshi_04_C_5", "ZYS01_Monster_village", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_psd_duchongsishi_02_C_3", "ZYS01_Monster_village", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(base.WorldContext, 0));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_PSD_Default_C_10", AutoTestNodeLib.QARebirthPointChoice.Leave));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_bhl_gushoufsq_01_C_0", "ZYS01_Monster_MRXG", "昴日星官", 1000, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, "TAMER_bhl_gushoufsq_01_C_0", "ZYS01_Monster_MRXG", AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new AutoTestNodeLib.TestState_PressBtn(base.WorldContext, "确定"));
	}
}
