using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_CustomInput : QuestNodeInstance
{
	private QuestCustom_CustomInput CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_CustomInput();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override bool IsDataValid()
	{
		return !string.IsNullOrEmpty(CustomData.EventName);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
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
	}
}
