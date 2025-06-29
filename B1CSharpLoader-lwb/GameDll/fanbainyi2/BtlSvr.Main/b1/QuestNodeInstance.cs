using System.IO;
using ArchiveB1;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1;

public abstract class QuestNodeInstance : ICheckNodeQueryable
{
	public UObject Owner { get; set; }

	public FCalliopeNode Node { get; set; }

	public QuestInstance ParentInstance { get; set; }

	public ActivationState ActivationState { get; set; }

	protected BGW_GameArchiveMgr ArchivedMgr { get; set; }

	protected BGW_PreloadAssetMgr PreloadAssetMgr { get; set; }

	public virtual bool IsDataValid()
	{
		return true;
	}

	protected virtual void PostCreate()
	{
	}

	public void NotifyPostCreate()
	{
		ActivationState = ActivationState.NeverActivated;
		ArchivedMgr = BGW_GameArchiveMgr.Get(Owner);
		PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
		PostCreate();
	}

	public virtual void TriggerInput(string InputPin)
	{
		ActivationState = ActivationState.Active;
		ParentInstance.TemplateAsset.RecordInput(Node.NodeGuid, InputPin);
		ArchivedMgr?.MarkDelaySaveArchive(EArchiveDelaySaveSource.CalliopeGraphTriggerInput, $"Task Graph: {ParentInstance.Graph.GraphName} Node: {Node.NodeGuid}");
	}

	public void TriggerOutput(string OutputPin, bool bFinish)
	{
		if (bFinish)
		{
			Finish();
		}
		if (Node.OutputEdges.TryGetValue(OutputPin, out var value))
		{
			ParentInstance.ExecuteEdge(value);
			ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, OutputPin);
		}
	}

	protected virtual void Finish()
	{
		ActivationState = ActivationState.WasActive;
		ParentInstance.UnregisterNodeInstance(this);
		ParentInstance.TemplateAsset.DeactivateNode(Node.NodeGuid);
	}

	protected void MarkNodeArchiveDataDirty()
	{
		ArchivedMgr?.MarkDelaySaveArchive(EArchiveDelaySaveSource.CalliopeNodeDataChanged, $"Task Graph: {ParentInstance.TemplateAsset.AssetPath} Node: {Node.NodeGuid}");
	}

	protected void TriggerFirstOutput(bool bFinish)
	{
		if (bFinish)
		{
			Finish();
		}
		if (Node.OutputEdges.TryGetValue(B1CalliopeDef.Common.DefaultOutputPinName, out var value))
		{
			ParentInstance.ExecuteEdge(value);
			ParentInstance.TemplateAsset.RecordOutput(Node.NodeGuid, value.FromPinName);
		}
	}

	public virtual void Tick(float DeltaTime)
	{
	}

	public virtual void Shutdown()
	{
		Finish();
	}

	protected void LogError(string Error)
	{
	}

	protected UObject ConvertSoftObjPath2Obj(string ObjPath)
	{
		if (!string.IsNullOrEmpty(ObjPath))
		{
			string path = ObjPath + "." + Path.GetFileNameWithoutExtension(ObjPath);
			return PreloadAssetMgr.TryGetCachedResourceObj<UObject>(path, ELoadResourceType.SyncLoadAndCache);
		}
		return null;
	}

	public virtual bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		return true;
	}

	public virtual void OnNotifyGraph(string Guid, FGameplayTag Tag)
	{
	}

	public abstract byte[] GetNodeCustomData();

	public abstract void SetNodeCustomData(byte[] CustomData);

	public abstract void RecoverActiveState();
}
