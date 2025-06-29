using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_CustomOutput : QuestNodeInstance
{
	private QuestCustom_CustomOutput CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_CustomOutput();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override bool IsDataValid()
	{
		return !string.IsNullOrEmpty(CustomData.EventName);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (base.ParentInstance is QuestSubInstance questSubInstance)
		{
			questSubInstance.TriggerCustomOutput(CustomData.EventName);
		}
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
		if (base.ParentInstance is QuestSubInstance questSubInstance)
		{
			questSubInstance.TriggerCustomOutput(CustomData.EventName);
		}
	}
}
