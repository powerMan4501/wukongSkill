using System;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_EnterOverlap : FGuardConditionBase
{
	private string OverlapGuid { get; set; }

	private bool IsOnlyTriggerWhenEnterOverlap { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	private IBIC_DeathData DeathData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.EnterOverlap;

	protected override void Clean()
	{
		OverlapGuid = "";
		EventCollection = null;
		DeathData = null;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.OverlapGuid);
		IsOnlyTriggerWhenEnterOverlap = false;
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GuideCondition.OverlapGuid);
		IsOnlyTriggerWhenEnterOverlap = true;
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.OverlapGuid);
		IsOnlyTriggerWhenEnterOverlap = false;
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		OverlapGuid = StateCondition.OverlapGuid;
		IsOnlyTriggerWhenEnterOverlap = false;
		return true;
	}

	protected override void Start()
	{
		DeathData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_DeathData, BIC_DeathData>(base.Owner);
		EventCollection = BGW_EventCollection.Get(base.Owner);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, OverlapGuid);
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn();
		if (!IsOnlyTriggerWhenEnterOverlap && actorByGuid != null && aPawn != null && actorByGuid.IsOverlappingActor(aPawn))
		{
			base.QueryState = EQueryState.QuerySuccess;
			return;
		}
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForEnterOverlap));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForEnterOverlap));
		}
	}

	private void NotifyGraphForEnterOverlap(string ActorGuid, FGameplayTag NotifyTag)
	{
		if (!DeathData.bIgnoreAllOverlapEvent && ActorGuid == OverlapGuid && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.OverlapBegin))
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForEnterOverlap));
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
