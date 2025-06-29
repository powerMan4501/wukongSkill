using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_UIPerformanceTest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "UIPerformanceTest";

	public override float TimeLimit => 3600f;

	private List<UClass> TamerClassList { get; set; }

	private void FillTamerClassList()
	{
		List<string> obj = new List<string> { "Blueprint'/Game/00Main/Design/Units/HFM/TAMER_hfm_shu_05a.TAMER_hfm_shu_05a_C'", "Blueprint'/Game/00Main/Design/Units/HYS/TAMER_hys_xizhanglao_01.TAMER_hys_xizhanglao_01_C'", "Blueprint'/Game/00Main/Design/Units/HFM/TAMER_hfm_hu_stone_01.TAMER_hfm_hu_stone_01_C'" };
		TamerClassList = new List<UClass>();
		foreach (string item2 in obj)
		{
			UClass item = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<UClass>(item2, ELoadResourceType.SyncLoadAndCache);
			TamerClassList.Add(item);
		}
	}

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 20));
		FillTamerClassList();
		StateStack.Push(new TestState_PreUIPerformanceTest(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		for (int i = 0; i < TamerClassList.Count; i++)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.teleportToPosition 0 0 100"));
			StateStack.Push(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(base.WorldContext, TamerClassList[i]));
			StateStack.Push(new TestState_AdjustRoleData(base.WorldContext, TamerClassList[i]));
			StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, TamerClassList[i], AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		}
		StateStack.Push(new TestState_PostUIPerformanceTest(base.WorldContext));
	}
}
