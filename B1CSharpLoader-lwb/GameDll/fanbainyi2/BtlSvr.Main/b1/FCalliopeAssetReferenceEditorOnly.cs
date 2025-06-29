using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public class FCalliopeAssetReferenceEditorOnly : FCalliopeAssetReference
{
	private BGW_EventCollection BGWEventCollection { get; set; }

	public FCalliopeAssetReferenceEditorOnly(UObject InWorldContext, ECalliopeAssetType InAssetType, string InAssetPath, string InPrefixName)
		: base(InAssetType, InAssetPath, InPrefixName)
	{
		BGWEventCollection = BGW_EventCollection.Get(InWorldContext);
	}

	protected override void CreateInstance(UObject InWorldContext)
	{
		string instancePrefixName = base.PrefixName ?? InWorldContext.GetName();
		BGWEventCollection.Evt_RegisterCalliopeAsset(base.AssetType, base.InstanceID, base.AssetPath, instancePrefixName);
	}

	public override void StartInstance()
	{
		SendRequest(ECalliopeAssetRequestType.StartInstance);
	}

	public override void StartAsSubInstance(FCalliopeAssetReference ParentAssetReference, FCalliopeGuid NodeGuid)
	{
		SendRequest(ECalliopeAssetRequestType.StartAseSubInstance, ParentAssetReference.InstanceID, NodeGuid);
	}

	public override void FinishInstance()
	{
		SendRequest(ECalliopeAssetRequestType.FinishInstance);
	}

	public override void ClearRecordData()
	{
		SendRequest(ECalliopeAssetRequestType.ClearRecordData);
	}

	public override void RecordInput(Guid NodeGuid, string InPinName)
	{
		RecordInput(GameplayTagExtension.ConvertToCalliopeGuid(NodeGuid), new FName(InPinName));
	}

	public override void RecordOutput(Guid NodeGuid, string InPinName)
	{
		RecordOutput(GameplayTagExtension.ConvertToCalliopeGuid(NodeGuid), new FName(InPinName));
	}

	public override void RecordOnlyNode(Guid NodeGuid)
	{
		RecordOnlyNode(GameplayTagExtension.ConvertToCalliopeGuid(NodeGuid));
	}

	public override void DeactivateNode(Guid NodeGuid)
	{
		DeactivateNode(GameplayTagExtension.ConvertToCalliopeGuid(NodeGuid));
	}

	private void RecordInput(FCalliopeGuid NodeGuid, FName InPinName)
	{
		SendRequest(ECalliopeAssetRequestType.RecordNodeInput, NodeGuid, InPinName);
	}

	private void RecordOutput(FCalliopeGuid NodeGuid, FName InPinName)
	{
		SendRequest(ECalliopeAssetRequestType.RecordNodeOutput, NodeGuid, InPinName);
	}

	private void RecordOnlyNode(FCalliopeGuid NodeGuid)
	{
		SendRequest(ECalliopeAssetRequestType.RecordOnlyNode, NodeGuid);
	}

	private void DeactivateNode(FCalliopeGuid NodeGuid)
	{
		SendRequest(ECalliopeAssetRequestType.DeactiveNode, NodeGuid);
	}

	private void SendRequest(ECalliopeAssetRequestType RequestType)
	{
		FCalliopeAssetRequest inRequest = new FCalliopeAssetRequest
		{
			InstanceID = base.InstanceID,
			RequestType = RequestType
		};
		BGWEventCollection.Evt_SendCalliopeAssetRequest(inRequest);
	}

	private void SendRequest(ECalliopeAssetRequestType RequestType, Guid InParentInstanceID, FCalliopeGuid NodeGuid)
	{
		FCalliopeAssetRequest inRequest = new FCalliopeAssetRequest
		{
			InstanceID = base.InstanceID,
			RequestType = RequestType,
			ParentInstanceID = InParentInstanceID,
			NodeGuid = NodeGuid
		};
		BGWEventCollection.Evt_SendCalliopeAssetRequest(inRequest);
	}

	private void SendRequest(ECalliopeAssetRequestType RequestType, FCalliopeGuid NodeGuid, FName? InPinName = null)
	{
		FCalliopeAssetRequest inRequest = new FCalliopeAssetRequest
		{
			InstanceID = base.InstanceID,
			RequestType = RequestType,
			NodeGuid = NodeGuid
		};
		if (InPinName.HasValue)
		{
			inRequest.PinName = InPinName.Value;
		}
		BGWEventCollection.Evt_SendCalliopeAssetRequest(inRequest);
	}
}
