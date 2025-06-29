namespace b1;

public class PsmNodeInstance_Final : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.Final };

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		Finish();
		base.ParentInstance.OnFinalState();
	}

	public override void RecoverActiveState()
	{
		Finish();
		base.ParentInstance.OnFinalState();
	}
}
