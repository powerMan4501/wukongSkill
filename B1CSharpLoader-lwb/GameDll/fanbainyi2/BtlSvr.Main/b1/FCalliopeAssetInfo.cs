using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public class FCalliopeAssetInfo : ICallbackValidator
{
	private TStrongObjectPtr<UCalliopeAsset> AssetInstancePtr = new TStrongObjectPtr<UCalliopeAsset>();

	private TStrongObjectPtr<UCalliopeAsset> TemplateAssetPtr = new TStrongObjectPtr<UCalliopeAsset>();

	public Guid InstanceID { get; }

	public ECalliopeAssetType AssetType { get; }

	public string AssetPath { get; }

	public string InstancePrefixName { get; }

	public UCalliopeAsset AssetInstance
	{
		get
		{
			return AssetInstancePtr.Get();
		}
		set
		{
			AssetInstancePtr.Set(value);
		}
	}

	public UCalliopeAsset TemplateAsset
	{
		get
		{
			return TemplateAssetPtr.Get();
		}
		set
		{
			TemplateAssetPtr.Set(value);
		}
	}

	public Queue<FCalliopeAssetRequest> RequestQueue { get; } = new Queue<FCalliopeAssetRequest>();

	public ECalliopeAssetPhase Phase { get; set; }

	public bool IsValidAcceptCallback()
	{
		return true;
	}

	public FCalliopeAssetInfo(ECalliopeAssetType InAssetType, Guid InInstanceID, string InAssetPath, string InInstancePrefixName)
	{
		AssetType = InAssetType;
		InstanceID = InInstanceID;
		AssetPath = InAssetPath;
		InstancePrefixName = InInstancePrefixName;
		Phase = ECalliopeAssetPhase.Unloaded;
	}

	public void AsyncLoadFinishCallback(int ReqID, UObject Obj)
	{
		if (!(Obj == null))
		{
			TemplateAsset = Obj as UCalliopeAsset;
			Phase = ECalliopeAssetPhase.Loaded;
		}
	}
}
