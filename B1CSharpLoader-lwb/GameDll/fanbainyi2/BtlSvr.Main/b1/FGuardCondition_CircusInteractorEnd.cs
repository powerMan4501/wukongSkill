using System;
using System.Collections.Generic;
using System.Linq;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_CircusInteractorEnd : FGuardConditionBase
{
	private string CircusInteractorNickName { get; set; }

	private string InteractorGuid { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	private IBGC_CircusControlData CircusData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.CircusInteractorEnd;

	protected override void Clean()
	{
		CircusInteractorNickName = "";
		InteractorGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		CircusInteractorNickName = StateCondition.CircusNickName;
		return true;
	}

	protected override void Start()
	{
		CircusData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_CircusControlData, BGC_CircusControlData>(base.Owner);
		EventCollection = BGW_EventCollection.Get(base.Owner);
		List<string> Guids = new List<string>();
		if (base.Owner is BGUCharacterCS actor)
		{
			CircusData.TravelCircus(actor, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, (CircusMember TreeNode) => TreeNode.NickName.Contains(CircusInteractorNickName));
		}
		if (Guids.Count > 0)
		{
			InteractorGuid = Guids.First();
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForInteractorEnd));
		}
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
