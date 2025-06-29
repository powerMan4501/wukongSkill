using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_TriggerOlineScreenMsg : QuestNodeInstance
{
	private int EventId { get; set; }

	private bool bSaveArchiveFinish { get; set; }

	private QuestCustom_OlineScreenMsg CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_OlineScreenMsg();
		CustomData.MergeFrom(base.Node.NodeData);
		EventId = CustomData.EventId;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(base.Owner);
		if (bGS_GSEventCollection == null)
		{
			TriggerFirstOutput(bFinish: true);
			return;
		}
		bGS_GSEventCollection.Evt_BGS_LevelEventScreenMsg.Invoke(EventId);
		TriggerFirstOutput(bFinish: true);
	}

	public override void Tick(float DeltaTime)
	{
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
