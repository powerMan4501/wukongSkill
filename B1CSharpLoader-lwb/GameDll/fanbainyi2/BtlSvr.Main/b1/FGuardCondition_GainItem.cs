using System;
using CommB1;

namespace b1;

public class FGuardCondition_GainItem : FGuardConditionBase
{
	private int ItemId { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.GainItem;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		ItemId = GuideCondition.ItemId;
		return true;
	}

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnItemChange));
	}

	protected override void Stop()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnItemChange));
	}

	private void OnItemChange(int InItemId, int OldValue, int NewValue)
	{
		if (InItemId == ItemId)
		{
			base.QueryState = EQueryState.QuerySuccess;
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
			bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnItemChange));
		}
	}
}
