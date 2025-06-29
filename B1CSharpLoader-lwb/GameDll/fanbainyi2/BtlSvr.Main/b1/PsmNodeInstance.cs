using System.Collections.Generic;
using ArchiveB1;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[TypeFactory]
public abstract class PsmNodeInstance : ICheckNodeQueryable
{
	private ActivationState _activationState;

	[FactoryKey]
	public abstract string[] SupportNodeClasses { get; }

	public FCalliopeNode Node { get; set; }

	public PsmInstance ParentInstance { get; set; }

	public ActivationState ActivationState
	{
		get
		{
			return _activationState;
		}
		set
		{
			if (_activationState != value)
			{
				switch (value)
				{
				case ActivationState.NeverActivated:
				case ActivationState.WasActive:
					ParentInstance.ActivedNodeInstances.Remove(this);
					break;
				case ActivationState.Active:
					ParentInstance.ActivedNodeInstances.Add(this);
					break;
				}
				_activationState = value;
			}
		}
	}

	public string CurrentGroupName { get; set; }

	public bool bHasForceFinished { get; set; }

	public PsmNodeInstance()
	{
		ActivationState = ActivationState.NeverActivated;
	}

	public virtual void PostCreate()
	{
	}

	public void ForceFinishInCurrentGroup()
	{
		if (bHasForceFinished)
		{
			return;
		}
		Finish();
		bHasForceFinished = true;
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in Node.OutputEdges)
		{
			ParentInstance.ForceEdgeFinish(outputEdge.Value);
		}
		bHasForceFinished = false;
	}

	public void TriggerInputWithGroupName(string InputPin, string GroupName)
	{
		CurrentGroupName = GroupName;
		TriggerInput(InputPin);
	}

	protected virtual void TriggerInput(string InputPin)
	{
		TriggerInputInternal(InputPin);
		BGW_GameArchiveMgr.Get(ParentInstance.Owner).MarkDelaySaveArchive(EArchiveDelaySaveSource.CalliopeGraphTriggerInput, $"Psm: {ParentInstance.GraphName}({ParentInstance.PsmGuid}) Node: {Node.NodeGuid}");
	}

	protected void TriggerInputInternal(string InputPin)
	{
		ActivationState = ActivationState.Active;
		ParentInstance.TemplateAsset.RecordInput(Node.NodeGuid, InputPin);
	}

	public void TriggerOutput(string OutputPin, bool bFinish)
	{
		if (Node.OutputEdges.ContainsKey(OutputPin))
		{
			if (bFinish)
			{
				Finish();
			}
			ParentInstance.ExecuteEdge(Node.OutputEdges[OutputPin], CurrentGroupName);
			ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, OutputPin);
		}
		else if (!string.IsNullOrEmpty(CurrentGroupName))
		{
			if (bFinish)
			{
				Finish();
			}
			ParentInstance.FinishGroup(CurrentGroupName);
		}
	}

	public void TriggerFirstOutput(bool bFinish)
	{
		if (Node.OutputEdges.TryGetValue(B1CalliopeDef.Common.DefaultOutputPinName, out var value))
		{
			if (bFinish)
			{
				Finish();
			}
			ParentInstance.ExecuteEdge(value, CurrentGroupName);
			ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, value.FromPinName);
		}
		else if (!string.IsNullOrEmpty(CurrentGroupName))
		{
			if (bFinish)
			{
				Finish();
			}
			ParentInstance.FinishGroup(CurrentGroupName);
		}
	}

	public virtual void OnEvent(FGameplayTag EventTag)
	{
	}

	public virtual void Tick(float DeltaTime)
	{
	}

	public virtual void Shutdown()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.TemplateAsset.DeactivateNode(Node.NodeGuid);
	}

	protected virtual void Finish()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.TemplateAsset.DeactivateNode(Node.NodeGuid);
	}

	public virtual string GetNodeCurrentState4Archive()
	{
		return "";
	}

	public virtual void SetNodeCurrentState4Archive(string CurrentState)
	{
	}

	public virtual void RecoverActiveState()
	{
	}

	public virtual void OnReset()
	{
		RecoverActiveState();
	}

	public virtual bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		return true;
	}
}
