using System;
using System.Collections.Generic;
using ArchiveB1;

namespace b1;

public abstract class FBehaviorRightNodeInstance : FBehaviorNodeInstanceBase
{
	public ActivationState ActivationState { get; private set; }

	public override bool bLeftNode => false;

	public Action<FBehaviorRightNodeInstance, string> NodeAction { get; set; }

	public Dictionary<string, FBehaviorGraphRightEdge> RightEdges { get; } = new Dictionary<string, FBehaviorGraphRightEdge>();

	public void NotifyTriggerInput(string InputPin = "")
	{
		NodeAction?.Invoke(this, InputPin);
		ActivationState = ActivationState.Active;
		base.ParentInstance.TemplateAsset?.RecordInput(base.Node.NodeGuid, InputPin);
		TriggerInput(InputPin);
	}

	protected virtual void TriggerInput(string InputPin)
	{
		TriggerFirstOutput();
	}

	protected void TriggerOutput(string OutputPin, bool bFinish = true)
	{
		if (bFinish)
		{
			Finish();
		}
		if (RightEdges.TryGetValue(OutputPin, out var value))
		{
			value.ExecuteOutput();
		}
	}

	protected void TriggerFirstOutput(bool bFinish = true)
	{
		if (bFinish)
		{
			Finish();
		}
		if (RightEdges.TryGetValue(B1CalliopeDef.Common.DefaultOutputPinName, out var value))
		{
			value.ExecuteOutput();
		}
	}

	protected virtual void Finish()
	{
		ActivationState = ActivationState.WasActive;
		base.ParentInstance.TemplateAsset?.DeactivateNode(base.Node.NodeGuid);
	}

	public void NotifyShutdown()
	{
		Shutdown();
	}

	protected virtual void Shutdown()
	{
		Finish();
	}
}
