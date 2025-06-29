using System;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_InteractorInOverlap : FGuardConditionBase
{
	private string OverlapGuid { get; set; }

	private string InteractorGuid { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InteractorInOverlap;

	protected override void Clean()
	{
		InteractorGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractorGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.InteractorGuid);
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.OverlapGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractorGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.InteractorGuid);
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.OverlapGuid);
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorInOverlap));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorInOverlap));
		}
	}

	private void NotifyGraphForInteractorInOverlap(string ActorGuid, FGameplayTag NotifyTag)
	{
		if (ActorGuid == InteractorGuid && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.InteractionEnd) && BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner).IsPlayerInOverlap(OverlapGuid, out var bInnerOverlap))
		{
			if (bInnerOverlap)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
		}
	}
}
