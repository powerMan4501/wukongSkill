using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;

namespace b1;

public class FGuardCondition_KillOrder : FGuardConditionBase
{
	public List<string> KillOrder { get; } = new List<string>();

	private int KillOrderIndex { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.KillOrder;

	protected override void Clean()
	{
		KillOrder.Clear();
		KillOrderIndex = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		foreach (string item in BattleCondition.KillOrder)
		{
			KillOrder.Add(InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(item));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		foreach (string item in GroupCondition.KillOrder)
		{
			KillOrder.Add(InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(item));
		}
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		KillOrderIndex = 0;
		if (KillOrder.Count < KillOrderIndex)
		{
			base.QueryState = EQueryState.QueryFailure;
			return;
		}
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Combine(eventCollection.Evt_SetActorAliveState, new Del_Void_StringBool(OnSetActorAliveState));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Remove(eventCollection.Evt_SetActorAliveState, new Del_Void_StringBool(OnSetActorAliveState));
		}
	}

	protected override void Reset()
	{
		KillOrderIndex = 0;
	}

	private void OnSetActorAliveState(string ActorGuid, bool bAlive)
	{
		if (!bAlive && ActorGuid == KillOrder[KillOrderIndex])
		{
			KillOrderIndex++;
			if (KillOrderIndex == KillOrder.Count)
			{
				BGW_EventCollection eventCollection = EventCollection;
				eventCollection.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Remove(eventCollection.Evt_SetActorAliveState, new Del_Void_StringBool(OnSetActorAliveState));
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
