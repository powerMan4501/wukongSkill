using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_PlayLevelSequence : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.PlayLevelSequence";

	private ProcessStateCustom_PlayLevelSequence CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_PlayLevelSequence();
		CustomData.MergeFrom(base.Node.NodeData);
	}
}
