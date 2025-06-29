using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class TestState_ChangeAbpSetting : AutoTestNodeLib.TestState_Node
{
	public TestState_ChangeAbpSetting(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn();
		BGWDataAsset_AbpHumanoidSetting bGWDataAsset_AbpHumanoidSetting = BGW_PreloadAssetMgr.Get(aPawn).TryGetCachedResourceObj<BGWDataAsset_AbpHumanoidSetting>("BGWDataAsset_AbpHumanoidSetting'/Game/00MainHZ/Characters/Wukong/ABPSetting_Wukong_Autotest_Plane.ABPSetting_Wukong_Autotest_Plane'", ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_AbpHumanoidSetting != null && !aPawn.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(aPawn).Evt_ChangeABPSetting.Invoke(bGWDataAsset_AbpHumanoidSetting);
			Description = "ABP_Setting替换成功";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		Description = "ABP_Setting替换失败";
		return AutoTestNodeLib.NodeState.Failed;
	}
}
