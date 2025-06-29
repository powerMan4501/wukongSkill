using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_ChallengeSuccess : QuestNodeInstance
{
	private int ChallengeID;

	private QuestCustom_ChallengeSuccess CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_ChallengeSuccess();
		CustomData.MergeFrom(base.Node.NodeData);
		ChallengeID = CustomData.ChallengeId;
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
