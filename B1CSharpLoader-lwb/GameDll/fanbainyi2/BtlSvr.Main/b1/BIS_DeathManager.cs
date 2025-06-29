using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;

namespace b1;

internal class BIS_DeathManager : GameInstanceSystemBase
{
	private BIC_DeathData DeathData { get; set; }

	public override void OnAttach()
	{
		DeathData = RequireWritableGameInstanceData<BIC_DeathData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SetAllUnitCannotDead = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_SetAllUnitCannotDead, new Del_Void_Bool(SetAllUnitCannotDead));
			bGW_EventCollection.Evt_IgnoreAllOverlapEvent = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_IgnoreAllOverlapEvent, new Del_Void_Bool(IgnoreAllOverlapEvent));
			bGW_EventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(bGW_EventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameInstanceData));
		}
	}

	public override void OnPostLoadMap()
	{
		DeathData.bIgnoreAllOverlapEvent = false;
		DeathData.bAllUnitCannotDead = false;
	}

	private void OnResetGameInstanceData(EGameInstanceResetType ResetType)
	{
		DeathData.bIgnoreAllOverlapEvent = false;
		DeathData.bAllUnitCannotDead = false;
	}

	private void IgnoreAllOverlapEvent(bool bInIgnore)
	{
		DeathData.bIgnoreAllOverlapEvent = bInIgnore;
	}

	public override void OnInit()
	{
		DeathData.bAllUnitCannotDead = false;
		DeathData.DeadSeqUnitGuidSet.Clear();
		foreach (KeyValuePair<int, FUStDeadSeqUnitConfigDesc> item in BGW_GameDB.GetAllDeadSeqUnitConfigDesc())
		{
			FUStDeadSeqUnitConfigDesc value = item.Value;
			if (value.IsEnable == EGSYesNo.Yes)
			{
				DeathData.DeadSeqUnitGuidSet.Add(value.UnitGuid);
			}
		}
	}

	private void SetAllUnitCannotDead(bool bInCanUnitDead)
	{
		DeathData.bAllUnitCannotDead = bInCanUnitDead;
	}
}
