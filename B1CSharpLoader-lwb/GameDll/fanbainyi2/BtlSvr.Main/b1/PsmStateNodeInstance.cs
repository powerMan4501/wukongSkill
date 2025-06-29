using ArchiveB1;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[TypeFactory]
public abstract class PsmStateNodeInstance : ICheckNodeQueryable
{
	[FactoryKey]
	public abstract string NodeClass { get; }

	public FCalliopeNode Node { get; set; }

	public PsmStateInstance ParentInstance { get; set; }

	public ActivationState ActivationState { get; set; }

	public PsmStateNodeInstance()
	{
		ActivationState = ActivationState.NeverActivated;
	}

	public virtual void PostCreate()
	{
	}

	public virtual void TriggerInput(string InputPin)
	{
		ActivationState = ActivationState.Active;
		ParentInstance.ParentInstance.TemplateAsset.RecordInput(Node.NodeGuid, InputPin);
	}

	public void TriggerOutput(string OutputPin, bool bFinish)
	{
		if (bFinish)
		{
			Finish();
		}
		if (Node.OutputEdges.ContainsKey(OutputPin))
		{
			ParentInstance.ExecuteEdge(Node.OutputEdges[OutputPin]);
			ParentInstance.ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, OutputPin);
		}
	}

	protected virtual void Finish()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.ParentInstance.TemplateAsset.DeactivateNode(Node.NodeGuid);
	}

	public void TriggerFirstOutput(bool bFinish)
	{
		if (bFinish)
		{
			Finish();
		}
		if (Node.OutputEdges.TryGetValue(B1CalliopeDef.Common.DefaultOutputPinName, out var value))
		{
			ParentInstance.ExecuteEdge(value);
			ParentInstance.ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, value.FromPinName);
		}
	}

	public virtual void Tick(float DeltaTime)
	{
	}

	public virtual void Shutdown()
	{
		Finish();
	}

	protected UObject GetOwner()
	{
		return ParentInstance?.ParentInstance?.Owner;
	}

	protected void LogError(string LogStr)
	{
	}

	public virtual bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		return true;
	}
}
