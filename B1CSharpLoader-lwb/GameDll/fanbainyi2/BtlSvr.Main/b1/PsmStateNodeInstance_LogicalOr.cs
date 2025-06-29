namespace b1;

public class PsmStateNodeInstance_LogicalOr : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.LogicalOr";

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
