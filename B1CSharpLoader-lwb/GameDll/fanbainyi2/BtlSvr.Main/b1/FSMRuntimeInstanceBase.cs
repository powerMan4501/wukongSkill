using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public abstract class FSMRuntimeInstanceBase
{
	private FCalliopeGraph CalliopeGraph;

	public FCalliopeNode ActiveNode;

	public List<FCalliopeNode> AnyStateNodes = new List<FCalliopeNode>();

	public DateTime StartTime;

	public string FSMInstanceName;

	public UObject OwnerUObj { get; protected set; }

	public event Action<FSMException> OnException;

	public event Action OnFinish;

	public event Action OnStart;

	public abstract int OnTick(float Delta);

	protected virtual void Finish()
	{
		this.OnFinish?.Invoke();
	}

	protected void OnExceptionInvoke(FSMException Exception)
	{
		BGW_EventCollection.Get(OwnerUObj).Evt_ShowExceptionUI(Exception);
		this.OnException?.Invoke(Exception);
	}

	public virtual void Start(object InputParams, FSMContextBase Context)
	{
		TriggerEventByString("Out", Context, out var _);
		this.OnStart?.Invoke();
		StartTime = DateTime.Now;
	}

	public FSMRuntimeInstanceBase(FCalliopeGraph CalliopeGraph, FSMContextBase Context, UCalliopeAsset CalliopeAsset)
	{
		this.CalliopeGraph = CalliopeGraph;
		ActiveNode = CalliopeGraph.GetStartNode();
		OwnerUObj = Context.OwnerUObj;
		foreach (FCalliopeNode node in CalliopeGraph.Nodes)
		{
			if (node.InputEdges.Count == 0 && node.NodeClass.Contains("AnyState"))
			{
				AnyStateNodes.Add(node);
			}
		}
	}

	private bool TriggerEventByStringWithNode(string Event, FCalliopeNode Node, FSMContextBase Context, string CachedEvent, bool IsAnyState = false)
	{
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in Node.OutputEdges)
		{
			if (outputEdge.Key == Event)
			{
				string cachedEvent = ((Event == "Out") ? CachedEvent : Event);
				if (outputEdge.Value.To.NodeClass == "FSM.BED_FSMNode_Reroute")
				{
					return TriggerEventByStringWithNode("Out", outputEdge.Value.To, Context, cachedEvent, IsAnyState);
				}
				ActiveNode = outputEdge.Value.To;
				if (Context != null)
				{
					Context.InputPinName = outputEdge.Value.ToPinName;
				}
				return true;
			}
		}
		if (!IsAnyState)
		{
			BGW_LogUtil.LogError("FSMRuntimeInstance TriggerEventByString Owner:" + OwnerUObj.GetName() + " Graph:" + FSMInstanceName + " Event:" + Event + " ActiveNode:" + ActiveNode.NodeClass + " InNode" + Node.NodeClass + " Failed");
		}
		return false;
	}

	public bool TriggerEventByString(string Event, FSMContextBase Context, out bool FromAnyState)
	{
		FromAnyState = false;
		foreach (FCalliopeNode anyStateNode in AnyStateNodes)
		{
			if (TriggerEventByStringWithNode(Event, anyStateNode, Context, Event, IsAnyState: true))
			{
				FromAnyState = true;
				return true;
			}
		}
		if (TriggerEventByStringWithNode(Event, ActiveNode, Context, Event))
		{
			return true;
		}
		return false;
	}
}
