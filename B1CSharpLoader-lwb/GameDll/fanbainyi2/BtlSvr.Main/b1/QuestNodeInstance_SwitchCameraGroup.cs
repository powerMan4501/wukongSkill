using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_SwitchCameraGroup : QuestNodeInstance
{
	private QuestCustom_SwitchCameraGroup CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SwitchCameraGroup();
		CustomData.MergeFrom(base.Node.NodeData);
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
		TriggerFirstOutput(bFinish: true);
	}
}
