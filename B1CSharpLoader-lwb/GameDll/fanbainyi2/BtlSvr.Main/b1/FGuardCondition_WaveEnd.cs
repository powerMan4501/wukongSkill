using System;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_WaveEnd : FGuardConditionBase
{
	private string Spawner { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.WaveEnd;

	protected override void Clean()
	{
		Spawner = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		Spawner = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(BattleCondition.Spawner);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		Spawner = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.Spawner);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		Spawner = StateCondition.Spawner;
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForWaveEnd));
	}

	private void NotifyGraphForWaveEnd(string ActorGuid, FGameplayTag NotifyTag)
	{
		if (ActorGuid == Spawner && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.SpawnUnitAllDead))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForWaveEnd));
		}
	}
}
