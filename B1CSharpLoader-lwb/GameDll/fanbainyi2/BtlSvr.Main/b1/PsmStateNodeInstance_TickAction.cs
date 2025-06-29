using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_TickAction : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.TickAction";

	private ProcessStateCustom_EnterAction CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_EnterAction();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void Tick(float DeltaTime)
	{
		if (!CustomData.IsOverrideParent)
		{
			base.ParentInstance.BaseState?.OnTickAction(DeltaTime);
		}
		TriggerInput("");
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
