using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_BuffDispMgr : GameStateSystemBase
{
	private BGC_BuffDispMgrData BuffDispMgrData;

	public override void OnAttach()
	{
		base.OnAttach();
		BuffDispMgrData = RequireWritableData<BGC_BuffDispMgrData>();
		base.BGSEventCollection.Evt_BGS_IncreaseBuffDispGlobalTriggerCounter += new Del_Void(OnIncreaseGlobalTriggerCounter);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.GlobalBuffDispMaxTriggerCountPerFrame, out var ConfigInfo);
		BuffDispMgrData.GlobalMaxTriggerCountPerFrame = ConfigInfo.IntValue;
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BuffDispMaxTriggerCountPerFrame, out var ConfigInfo2);
		BuffDispMgrData.MaxTriggerCountPerFrame = ConfigInfo2.IntValue;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		ResetGlobalTriggerCounter();
	}

	private void OnIncreaseGlobalTriggerCounter()
	{
		BuffDispMgrData.GlobalTriggerCounterPerFrame++;
	}

	private void ResetGlobalTriggerCounter()
	{
		BuffDispMgrData.GlobalTriggerCounterPerFrame = 0;
	}
}
