namespace b1;

public class PsmNodeInstance_Reroute : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[2]
	{
		B1CalliopeDef.ProcessMachineNode.Reroute,
		B1CalliopeDef.BossRushNode.Reroute
	};

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
