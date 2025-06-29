using System.Collections.Generic;
using System.Linq;

namespace b1;

public class PsmStateNodeInstance_LogicalAnd : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.LogicalAnd";

	private HashSet<string> ExecutedInputNames { get; } = new HashSet<string>();

	private int FinishPinNum { get; set; }

	public override void PostCreate()
	{
		FinishPinNum = base.Node.InputEdges.Count;
		if (base.Node.InputEdges.Any((FCalliopeEdge p) => p.ToPinName.Equals(BGW_FlowUtils.PinName.Reset.PlainName)))
		{
			FinishPinNum--;
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(BGW_FlowUtils.PinName.Reset.PlainName))
		{
			ExecutedInputNames.Clear();
			Finish();
			return;
		}
		ExecutedInputNames.Add(InputPin);
		if (ExecutedInputNames.Count == FinishPinNum)
		{
			TriggerFirstOutput(bFinish: true);
		}
	}

	protected override void Finish()
	{
		ExecutedInputNames.Clear();
		base.Finish();
	}

	public override void Shutdown()
	{
		ExecutedInputNames.Clear();
		base.Shutdown();
	}
}
