using System;
using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class TaskNodeInstance_ObserveUnitsDeadWithOrder : QuestNodeInstance, IObserveNodeInstance
{
	private List<string> ObservedUnitGuids { get; set; } = new List<string>();

	private List<int> ObserveSuccessIndex { get; set; } = new List<int>();

	private TaskCustom_ObserveUnitsDeadWithOrder CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new TaskCustom_ObserveUnitsDeadWithOrder();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (string item in CustomData.ObserveActorGuid)
		{
			ObservedUnitGuids.Add(item);
		}
	}

	private void ResetAllActors(EResetActorReason ResetReason)
	{
		ObserveSuccessIndex.Clear();
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		StartObserving();
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (string observedUnitGuid in ObservedUnitGuids)
		{
			if (string.IsNullOrEmpty(observedUnitGuid))
			{
				Finish();
				return;
			}
		}
		if (InputPin.Equals(BGW_FlowUtils.PinName.Enable.PlainName))
		{
			StartObserving();
			TriggerOutput(BGW_FlowUtils.PinName.Enabled.PlainName, bFinish: false);
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Disable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Disabled.PlainName, bFinish: true);
		}
	}

	public override void Tick(float DeltaTime)
	{
	}

	private void StartObserving()
	{
		foreach (string observedUnitGuid in ObservedUnitGuids)
		{
			BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStartObserve(this, observedUnitGuid);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGW_EventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(ResetAllActors));
	}

	private void StopObserving()
	{
		BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStopObserve(this);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGW_EventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(ResetAllActors));
	}

	protected override void Finish()
	{
		StopObserving();
		base.Finish();
	}

	public override void OnNotifyGraph(string Guid, FGameplayTag Tag)
	{
		for (int i = 0; i < ObservedUnitGuids.Count; i++)
		{
			string text = ObservedUnitGuids[i];
			if (Guid == text && Tag.Equals(BGW_FlowUtils.CommonTag.UnitDead))
			{
				OnConditionSuccess(i);
			}
		}
	}

	private void OnConditionSuccess(int SuccessIndex)
	{
		ObserveSuccessIndex.Add(SuccessIndex);
		if (ObserveSuccessIndex.Count == ObservedUnitGuids.Count)
		{
			string text = "";
			for (int i = 0; i < ObserveSuccessIndex.Count; i++)
			{
				text += ((i == ObservedUnitGuids.Count - 1) ? $"{ObserveSuccessIndex[i]}" : $"{ObserveSuccessIndex[i]}->");
			}
			if (text != "")
			{
				TriggerOutput(text, bFinish: false);
			}
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: true);
		}
	}
}
