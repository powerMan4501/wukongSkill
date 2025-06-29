using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_TrainDummyResultReport : QuestNodeInstance
{
	private QuestCustom_TrainDummyResultReport CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_TrainDummyResultReport();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_TrainDummyResultReport = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_TrainDummyResultReport, new Del_Void_String(OnTrainDummyResultReport));
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
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
		TriggerFirstOutput(bFinish: true);
	}

	private void OnTrainDummyResultReport(string Guid)
	{
		if (Guid == CustomData.TrainDummyMgrActorGuid)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_TrainDummyResultReport = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_TrainDummyResultReport, new Del_Void_String(OnTrainDummyResultReport));
			TriggerFirstOutput(bFinish: true);
		}
	}
}
