using System;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_InteractorEnd : FGuardConditionBase
{
	private string InteractorGuid { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InteractorEnd;

	protected override void Clean()
	{
		InteractorGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractorGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.InteractorGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractorGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.InteractorGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		InteractorGuid = StateCondition.InteractorGuid;
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorEnd));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorEnd));
		}
	}

	private void NotifyGraphForInteractorEnd(string ActorGuid, FGameplayTag NotifyTag)
	{
		if (ActorGuid == InteractorGuid && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.InteractionEnd))
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorEnd));
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
