using System;
using CommB1;

namespace b1;

public class FGuardCondition_ConsumedItem : FGuardConditionBase
{
	private int ConsumeItemID { get; set; }

	private int ConsumptionQuantity { get; set; }

	private int ConsumeItemCounter { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.ConsumedItem;

	protected override void Clean()
	{
		ConsumeItemID = 0;
		ConsumptionQuantity = 0;
		ConsumeItemCounter = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		ConsumeItemID = IdleCondition.ConsumeItemId;
		ConsumptionQuantity = IdleCondition.ConsumptionQuantity;
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		ConsumeItemCounter = 0;
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(NotifyGraphForConsumedItemChange));
	}

	private void NotifyGraphForConsumedItemChange(int ItemID, int OldNum, int NewNum)
	{
		if (ConsumeItemID == ItemID)
		{
			int num = NewNum - OldNum;
			if (num < 0)
			{
				ConsumeItemCounter += -num;
			}
			if (ConsumeItemCounter >= ConsumptionQuantity)
			{
				BGW_EventCollection eventCollection = EventCollection;
				eventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(NotifyGraphForConsumedItemChange));
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
