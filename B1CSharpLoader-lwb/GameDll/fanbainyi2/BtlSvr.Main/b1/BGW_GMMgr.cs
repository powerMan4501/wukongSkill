using System;

namespace b1;

public class BGW_GMMgr : GameInstanceSystemBase
{
	private BIC_GMRebirthData GMRebirthData;

	public override void OnInit()
	{
		base.OnInit();
		GMRebirthData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(base.Owner).GetGameInstanceWritableData<BIC_GMRebirthData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(bGW_EventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameInstanceData));
	}

	private void OnResetGameInstanceData(EGameInstanceResetType ResetType)
	{
		GMRebirthData.Reset();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Remove(bGW_EventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameInstanceData));
	}
}
