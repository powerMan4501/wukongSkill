namespace b1;

public class PsmNodeInstance_Terminate : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.Terminate };

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		Finish();
		base.ParentInstance.NotifyGraphEnd();
	}
}
