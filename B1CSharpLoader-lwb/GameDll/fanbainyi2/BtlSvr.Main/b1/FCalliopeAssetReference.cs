using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public class FCalliopeAssetReference
{
	public Guid InstanceID { get; }

	public string AssetPath { get; }

	protected ECalliopeAssetType AssetType { get; }

	protected string PrefixName { get; }

	public FCalliopeAssetReference(ECalliopeAssetType InAssetType, string InAssetPath, string InPrefixName)
	{
		AssetType = InAssetType;
		AssetPath = InAssetPath;
		InstanceID = Guid.NewGuid();
		PrefixName = InPrefixName;
	}

	public static FCalliopeAssetReference CreateInstance(UObject InWorldContext, ECalliopeAssetType InAssetType, string InAssetPath, string InInstancePrefixName = null)
	{
		FCalliopeAssetReference fCalliopeAssetReference = new FCalliopeAssetReference(InAssetType, InAssetPath, InInstancePrefixName);
		fCalliopeAssetReference.CreateInstance(InWorldContext);
		return fCalliopeAssetReference;
	}

	protected virtual void CreateInstance(UObject InWorldContext)
	{
	}

	public virtual void StartInstance()
	{
	}

	public virtual void StartAsSubInstance(FCalliopeAssetReference ParentAssetReference, FCalliopeGuid NodeGuid)
	{
	}

	public virtual void FinishInstance()
	{
	}

	public virtual void ClearRecordData()
	{
	}

	public virtual void RecordInput(Guid NodeGuid, string InPinName)
	{
	}

	public virtual void RecordOutput(Guid NodeGuid, string InPinName)
	{
	}

	public virtual void RecordOnlyNode(Guid NodeGuid)
	{
	}

	public virtual void DeactivateNode(Guid NodeGuid)
	{
	}
}
