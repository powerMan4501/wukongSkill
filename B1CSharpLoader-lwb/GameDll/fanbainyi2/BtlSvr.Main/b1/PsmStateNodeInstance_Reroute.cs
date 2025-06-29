namespace b1;

public class PsmStateNodeInstance_Reroute : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.Reroute";

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
