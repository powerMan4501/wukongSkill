using System;
using System.Linq;
using ArchiveB1;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance")]
public class MovieNodeInstance : UObject
{
	public FCalliopeNode Node { get; set; }

	public MovieInstance ParentInstance { get; set; }

	public ActivationState ActivationState { get; set; }

	public virtual bool IsDataValid()
	{
		return true;
	}

	public virtual void PostCreate()
	{
	}

	public virtual void TriggerInput(string InputPin = "")
	{
		ActivationState = ActivationState.Active;
		FName none = FName.None;
		none = ((!string.IsNullOrEmpty(InputPin)) ? new FName(InputPin) : BGW_FlowUtils.PinName.In);
		ParentInstance.TemplateAsset?.RecordInput(Node.NodeGuid, none.ToString());
	}

	public void TriggerOutput(string OutputPin, bool bFinish)
	{
		if (Node.OutputEdges.ContainsKey(OutputPin))
		{
			ParentInstance.ExecuteEdge(Node.OutputEdges[OutputPin]);
		}
		ParentInstance.TemplateAsset?.DeactivateNode(Node.NodeGuid);
		if (bFinish)
		{
			Finish();
		}
	}

	protected virtual void Finish()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.UnregisterNodeInstance(this);
		ParentInstance.TemplateAsset?.DeactivateNode(Node.NodeGuid);
	}

	public void TriggerFirstOutput(bool bFinish = true)
	{
		if (bFinish)
		{
			Finish();
		}
		FCalliopeEdge fCalliopeEdge = Node.OutputEdges.Values.FirstOrDefault();
		if (fCalliopeEdge != null)
		{
			ParentInstance.ExecuteEdge(fCalliopeEdge);
			ParentInstance.TemplateAsset?.RecordOutput(Node.NodeGuid, fCalliopeEdge.FromPinName);
		}
	}

	public virtual void Tick(float DeltaTime)
	{
	}

	public virtual void Shutdown()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.TemplateAsset?.DeactivateNode(Node.NodeGuid);
	}

	public void LogError(string Error)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance");
	}

	static MovieNodeInstance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance));
	}
}
