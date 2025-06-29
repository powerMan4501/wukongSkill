using System;
using System.Collections.Generic;
using System.Linq;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_CircusEnterOverlap : FGuardConditionBase
{
	private string CircusOverlapNickName { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	private IBIC_DeathData DeathData { get; set; }

	private IBGC_CircusControlData CircusData { get; set; }

	public string OverlapGuid { get; private set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.CircusEnterOverlap;

	protected override void Clean()
	{
		CircusOverlapNickName = "";
		EventCollection = null;
		DeathData = null;
		CircusData = null;
		OverlapGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		CircusOverlapNickName = StateCondition.CircusNickName;
		return true;
	}

	protected override void Start()
	{
		DeathData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_DeathData, BIC_DeathData>(base.Owner);
		CircusData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_CircusControlData, BGC_CircusControlData>(base.Owner);
		EventCollection = BGW_EventCollection.Get(base.Owner);
		List<string> Guids = new List<string>();
		if (base.Owner is BGUCharacterCS actor)
		{
			CircusData.TravelCircus(actor, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, (CircusMember TreeNode) => TreeNode.NickName.Contains(CircusOverlapNickName));
		}
		if (Guids.Count > 0)
		{
			OverlapGuid = Guids.First();
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, OverlapGuid);
			APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn();
			if (actorByGuid != null && aPawn != null && actorByGuid.IsOverlappingActor(aPawn))
			{
				base.QueryState = EQueryState.QuerySuccess;
				return;
			}
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForEnterOverlap));
		}
	}

	public override bool TryQuickFinishCondition()
	{
		base.QueryState = EQueryState.QuerySuccess;
		return true;
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
		if (!DeathData.bIgnoreAllOverlapEvent && !string.IsNullOrEmpty(OverlapGuid) && ActorGuid == OverlapGuid && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.OverlapBegin))
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Remove(eventCollection.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(NotifyGraphForEnterOverlap));
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
