using System.Collections.Generic;

namespace b1;

public class PsmNodeInstance_Join : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.Join };

	private List<string> JoinedPins { get; } = new List<string>();

	public override void PostCreate()
	{
		JoinedPins.Clear();
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (!JoinedPins.Contains(InputPin))
		{
			JoinedPins.Add(InputPin);
			if (JoinedPins.Count == base.Node.InputEdges.Count)
			{
				TriggerFirstOutput(bFinish: true);
			}
		}
	}
}
