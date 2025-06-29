using System;
using CommB1;

namespace b1;

public class FGuardCondition_InteractionEnd : FGuardConditionBase
{
	private int InteractionGroupID { get; set; }

	private int InteractionStep { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InteractionEnd;

	protected override void Clean()
	{
		InteractionGroupID = 0;
		InteractionStep = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractionGroupID = IdleCondition.InteractGroupId;
		InteractionStep = IdleCondition.InteractStep;
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph_InteractionEnd = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph_InteractionEnd, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd(OnInteractionEnd));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph_InteractionEnd = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph_InteractionEnd, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_InteractionEnd(OnInteractionEnd));
		}
	}

	private void OnInteractionEnd(int GroupID, int InteractStep)
	{
		if (InteractionGroupID == GroupID && InteractionStep == InteractStep)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
