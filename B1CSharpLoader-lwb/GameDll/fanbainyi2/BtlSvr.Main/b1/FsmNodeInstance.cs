using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class FsmNodeInstance
{
	public FsmInstance ParentInstance { get; set; }

	public FCalliopeNode Node { get; set; }

	protected Dictionary<FName, (Guid, FName)> OutEdges { get; } = new Dictionary<FName, (Guid, FName)>();

	public void Initialize()
	{
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in Node.OutputEdges)
		{
			FCalliopeEdge value = outputEdge.Value;
			OutEdges[FNameExtension.ToFName(outputEdge.Key)] = (value.To.NodeGuid, FNameExtension.ToFName(value.ToPinName));
		}
		OnInitialize();
	}

	public void ExecuteNode()
	{
		ParentInstance.TemplateAsset.RecordOnlyNode(Node.NodeGuid);
		OnExecuteNode();
	}

	public void NodeBack2History(bool bDeepHistory)
	{
		ParentInstance.TemplateAsset.RecordOnlyNode(Node.NodeGuid);
		OnNodeBack2History(bDeepHistory);
	}

	public void ExecuteNode_Custom(FName CustomEvent)
	{
		ParentInstance.TemplateAsset.RecordOnlyNode(Node.NodeGuid);
		OnExecuteNode_Custom(CustomEvent);
	}

	public void ForceExitNode()
	{
		OnForceExitNode();
	}

	protected void ExecuteFirstOut()
	{
		(Guid, FName) value = OutEdges.First().Value;
		ExecuteNextNode(value.Item1, value.Item2);
	}

	protected void ExecuteAllOut()
	{
		foreach (KeyValuePair<FName, (Guid, FName)> outEdge in OutEdges)
		{
			ExecuteNextNode(outEdge.Value.Item1, outEdge.Value.Item2);
		}
	}

	protected void ExecuteCustomEventOut(FName OutPinName)
	{
		if (OutEdges.TryGetValue(OutPinName, out var value))
		{
			ExecuteNextNode(value.Item1, value.Item2);
		}
	}

	protected void ExecuteNextNode(Guid NextNodeGuid, FName PinName)
	{
		if (!ParentInstance.TryGetNodeInstance(NextNodeGuid, out var OutNodeInstance))
		{
			return;
		}
		if (FNameExtension.EqualTo(PinName, BGW_FlowUtils.PinName.ShallowHistory))
		{
			OutNodeInstance.NodeBack2History(bDeepHistory: false);
		}
		else if (FNameExtension.EqualTo(PinName, BGW_FlowUtils.PinName.DeepHistory))
		{
			OutNodeInstance.NodeBack2History(bDeepHistory: true);
		}
		else if (OutNodeInstance is FsmNodeInstance_State fsmNodeInstance_State)
		{
			if (fsmNodeInstance_State.CustomEnterEvents.Contains(PinName))
			{
				OutNodeInstance.ExecuteNode_Custom(PinName);
			}
			else
			{
				OutNodeInstance.ExecuteNode();
			}
		}
		else if (OutNodeInstance is FsmNodeInstance_CustomExit)
		{
			OutNodeInstance.ExecuteNode_Custom(PinName);
		}
		else
		{
			OutNodeInstance.ExecuteNode();
		}
	}

	protected virtual void OnInitialize()
	{
	}

	protected virtual void OnExecuteNode()
	{
	}

	protected virtual void OnNodeBack2History(bool bDeepHistory)
	{
	}

	protected virtual void OnExecuteNode_Custom(FName CustomEvent)
	{
	}

	protected virtual void OnForceExitNode()
	{
	}

	public void NotifyShutdown()
	{
		Shutdown();
	}

	protected virtual void Shutdown()
	{
	}
}
