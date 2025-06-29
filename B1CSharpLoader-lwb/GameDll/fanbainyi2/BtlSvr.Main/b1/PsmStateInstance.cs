using System;
using System.Collections.Generic;
using ArchiveB1;

namespace b1;

public sealed class PsmStateInstance : IPsmState
{
	private FCalliopeGraph Graph { get; set; }

	public PsmInstance ParentInstance { get; set; }

	private Dictionary<Guid, PsmStateNodeInstance> NodeInstances { get; } = new Dictionary<Guid, PsmStateNodeInstance>();

	public PsmSubMachineState BaseState { get; set; }

	private PsmStateNodeInstance EnterActionNode { get; set; }

	private PsmStateNodeInstance ExitActionNode { get; set; }

	private PsmStateNodeInstance TickActionNode { get; set; }

	private PsmStateNodeInstance ResetActionNode { get; set; }

	private Dictionary<string, PsmStateNodeInstance> DetectStartNodes { get; } = new Dictionary<string, PsmStateNodeInstance>();

	public static PsmStateInstance Create(FCalliopeGraph BranchGraph, PsmInstance InParentInstance)
	{
		if (BranchGraph == null)
		{
			return null;
		}
		PsmStateInstance psmStateInstance = new PsmStateInstance();
		psmStateInstance.Graph = BranchGraph;
		psmStateInstance.ParentInstance = InParentInstance;
		foreach (FCalliopeNode node in BranchGraph.Nodes)
		{
			PsmStateNodeInstance psmStateNodeInstance = CreateStateNodeInstance(node, psmStateInstance);
			switch (node.NodeClass)
			{
			case "Process.State.EnterAction":
				psmStateInstance.EnterActionNode = psmStateNodeInstance;
				break;
			case "Process.State.ExitAction":
				psmStateInstance.ExitActionNode = psmStateNodeInstance;
				break;
			case "Process.State.TickAction":
				psmStateInstance.TickActionNode = psmStateNodeInstance;
				break;
			case "Process.State.ResetAction":
				psmStateInstance.ResetActionNode = psmStateNodeInstance;
				break;
			}
			psmStateInstance.NodeInstances.Add(node.NodeGuid, psmStateNodeInstance);
		}
		return psmStateInstance;
	}

	private static PsmStateNodeInstance CreateStateNodeInstance(FCalliopeNode Node, PsmStateInstance ParentInstance)
	{
		PsmStateNodeInstance psmStateNodeInstance = FPsmStateNodeInstanceFactory.CreateInstance(Node.NodeClass);
		if (psmStateNodeInstance != null)
		{
			psmStateNodeInstance.Node = Node;
			psmStateNodeInstance.ParentInstance = ParentInstance;
			psmStateNodeInstance.PostCreate();
			return psmStateNodeInstance;
		}
		return null;
	}

	public void RegisterDetectStartNode(string DetectCondition, PsmStateNodeInstance NodeInstance)
	{
		if (DetectStartNodes.ContainsKey(DetectCondition))
		{
			DetectStartNodes[DetectCondition] = NodeInstance;
		}
		else
		{
			DetectStartNodes.Add(DetectCondition, NodeInstance);
		}
	}

	public void OnEnterAction()
	{
		EnterActionNode?.TriggerInput("");
	}

	public void OnExitAction()
	{
		ExitActionNode?.TriggerInput("");
	}

	public void OnTickAction(float InDeltaTime)
	{
		foreach (KeyValuePair<Guid, PsmStateNodeInstance> nodeInstance in NodeInstances)
		{
			if (nodeInstance.Value.ActivationState == ActivationState.Active || nodeInstance.Value == TickActionNode)
			{
				nodeInstance.Value.Tick(InDeltaTime);
			}
		}
	}

	public void OnResetAction()
	{
		ResetActionNode?.TriggerInput("");
	}

	public void OnRecoverAction()
	{
		ResetActionNode?.TriggerInput("");
	}

	public void SetDetectConditionEnabled(string DetectCondition, bool bEnable)
	{
		if (DetectStartNodes.TryGetValue(DetectCondition, out var value))
		{
			value.TriggerInput(bEnable ? BGW_FlowUtils.PinName.Enable.PlainName : BGW_FlowUtils.PinName.Disable.PlainName);
		}
	}

	public void Shutdown()
	{
		foreach (PsmStateNodeInstance value in NodeInstances.Values)
		{
			value.Shutdown();
		}
		NodeInstances.Clear();
	}

	public void ExecuteEdge(FCalliopeEdge Edge)
	{
		FindOrAddNodeInstance(Edge.To)?.TriggerInput(Edge.ToPinName);
	}

	private PsmStateNodeInstance FindOrAddNodeInstance(FCalliopeNode Node)
	{
		Guid nodeGuid = Node.NodeGuid;
		if (NodeInstances.ContainsKey(nodeGuid))
		{
			return NodeInstances[nodeGuid];
		}
		return null;
	}

	public Dictionary<Guid, PsmStateNodeInstance> GetNodeInstances()
	{
		return NodeInstances;
	}
}
