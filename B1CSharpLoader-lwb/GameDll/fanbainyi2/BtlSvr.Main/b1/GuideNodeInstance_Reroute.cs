namespace b1;

public class GuideNodeInstance_Reroute : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.GuideNode.Reroute };

	protected override void TriggerInput(string InputPin)
	{
		TriggerInputInternal(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
