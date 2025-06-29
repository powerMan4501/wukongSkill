using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_Counter : FBehaviorRightNodeInstance
{
	private BehaviorCustom_GameDataCounter CustomData { get; set; }

	private EDetectedUnitType UnitType { get; set; }

	private EGameplayCounterType CounterType { get; set; }

	private BUS_GSEventCollection EventCollection { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.GameDataCounter;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_GameDataCounter();
		CustomData.MergeFrom(base.Node.NodeData);
		CounterType = (EGameplayCounterType)CustomData.CounterType;
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(BGW_FlowUtils.PinName.Start.PlainName))
		{
			StartCounter();
		}
		if (InputPin.Equals(BGW_FlowUtils.PinName.Stop.PlainName))
		{
			StopCounter();
		}
	}

	private void StartCounter()
	{
		AActor detectUnit = base.ParentInstance.GetDetectUnit(UnitType);
		EventCollection = BUS_EventCollectionCS.Get(detectUnit);
		EventCollection.Evt_GameplayCountCompleted += new Del_Void_Guid(CounterCompleted);
		EventCollection.Evt_StartGameplayCounter.Invoke(base.Node.NodeGuid, CounterType, CustomData.CounterValue);
	}

	private void StopCounter()
	{
		if (EventCollection != null)
		{
			EventCollection.Evt_StopGameplayCounter.Invoke(base.Node.NodeGuid);
			EventCollection.Evt_GameplayCountCompleted -= new Del_Void_Guid(CounterCompleted);
		}
	}

	private void CounterCompleted(Guid NodeGuid)
	{
		if (base.Node.NodeGuid.Equals(NodeGuid))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Completed.PlainName);
		}
	}

	protected override void Finish()
	{
		StopCounter();
		base.Finish();
	}
}
