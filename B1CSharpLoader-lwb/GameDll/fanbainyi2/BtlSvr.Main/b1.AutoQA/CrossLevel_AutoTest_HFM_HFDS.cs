using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFM_HFDS : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFM_8_1_战黄风大圣";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2010, "RebirthPoint_HFM_Default_C_8", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		StateStack.Push(new TestState_ZhenFengMenJudgeSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_B1GM(base.WorldContext, "additem 4001"));
		StateStack.Push(new AutoTestNodeLib.TestState_B1GM(base.WorldContext, "additem 4002"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "HFM_FuJie_C_0", "HFM02_Quest_Fujie_SandSkiing", "黄风阵大门", 0));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_FuJie_C_0", "HFM02_Quest_Fujie_SandSkiing"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition -74910 13690 -8796"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hfm_hfds_01a_C_0", "黄风大圣", 0, AutoTestNodeLib.AutoMoveExitCondition.SequenceBegin));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		UClass uClass = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Design/Units/HFM/Unit_HFM_HFDS_01a.Unit_HFM_HFDS_01a_C'", ELoadResourceType.SyncLoadAndCache);
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, uClass, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ReceiveChapterAward(base.WorldContext));
	}
}
