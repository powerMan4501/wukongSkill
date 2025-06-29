using System;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_NiagaraPerformanceTest")]
internal class AutoTest_NiagaraPerformanceTest : b1.AutoQA.AutoTest_Template
{
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

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_NiagaraPerformanceTest");
	}

	static AutoTest_NiagaraPerformanceTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_NiagaraPerformanceTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_NiagaraPerformanceTest));
	}
}
