using System.Collections.Generic;

namespace b1;

public class PsmStateNodeInstance_ExecutionSequence : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.ExecutionSequence";

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in base.Node.OutputEdges)
		{
			TriggerOutput(outputEdge.Key, bFinish: false);
		}
		Finish();
	}
}
