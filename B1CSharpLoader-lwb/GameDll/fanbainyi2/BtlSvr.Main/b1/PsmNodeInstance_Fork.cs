using System.Collections.Generic;

namespace b1;

public class PsmNodeInstance_Fork : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.Fork };

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in base.Node.OutputEdges)
		{
			TriggerOutput(outputEdge.Key, bFinish: false);
		}
		Finish();
	}

	public override void RecoverActiveState()
	{
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in base.Node.OutputEdges)
		{
			TriggerOutput(outputEdge.Key, bFinish: false);
		}
		Finish();
	}
}
