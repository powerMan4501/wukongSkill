using b1.BGW;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_NiagaraPerformance : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "NiagaraPerformance";

	public override float TimeLimit => 3.6E+09f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invincible"));
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.NiagaraPerformance_TamerListDAPath, out var ConfigInfo);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.NiagaraPerformance_BlackSkillIDDaPath, out var ConfigInfo2);
		AutoTestHelperLib.BGWDataAsset_TamerListConfig tamerList = null;
		BGWDataAsset_SkillIDBlackListConfig bGWDataAsset_SkillIDBlackListConfig = null;
		if (ConfigInfo != null)
		{
			tamerList = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(ConfigInfo.StringValue, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
		}
		if (ConfigInfo2 != null)
		{
			bGWDataAsset_SkillIDBlackListConfig = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<BGWDataAsset_SkillIDBlackListConfig>(ConfigInfo2.StringValue, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
		}
		if (bGWDataAsset_SkillIDBlackListConfig != null)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.AddTraceStat STAT_TotalNiagaraSystemInstances"));
			StateStack.Push(new TestState_ATPNiagaraPerformanceTest_CrossLevel(base.WorldContext, tamerList, bGWDataAsset_SkillIDBlackListConfig.SkillList));
		}
	}
}
