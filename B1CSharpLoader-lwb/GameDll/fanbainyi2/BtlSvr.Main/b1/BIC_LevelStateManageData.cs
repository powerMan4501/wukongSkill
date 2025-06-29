using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BIC_LevelStateManageData : IBIC_LevelStateManageData
{
	public Dictionary<EGSLevelStateInfoLayerType, FGSLevelStateInfoLayer> LevelControlInfoLayers;

	public FGSLevelStateRequestBatchInfo BatchingRequests;

	public List<FGSLevelStateRequestBatchInfo> RequestedBatchs;

	private TStrongObjectPtr<BGWDataAsset_SeqLevelLoadRelationInfo> _seqLevelLoadRelationInfoPtr = new TStrongObjectPtr<BGWDataAsset_SeqLevelLoadRelationInfo>();

	public BGWDataAsset_SeqLevelLoadRelationInfo SeqLevelLoadRelationInfo
	{
		get
		{
			return _seqLevelLoadRelationInfoPtr.Get();
		}
		set
		{
			_seqLevelLoadRelationInfoPtr.Set(value);
		}
	}

	public Dictionary<string, Dictionary<int, FMovieRelationInfoCollection>> SeqLevelRelations { get; } = new Dictionary<string, Dictionary<int, FMovieRelationInfoCollection>>();

	public FGSLevelStateControlInfo SeqLevelControlInfo { get; set; } = new FGSLevelStateControlInfo();

	public int CurrentLevelID { get; set; }

	public BIC_LevelStateManageData()
	{
		LevelControlInfoLayers = new Dictionary<EGSLevelStateInfoLayerType, FGSLevelStateInfoLayer>();
		RequestedBatchs = new List<FGSLevelStateRequestBatchInfo>();
	}

	public int UpdateLevelState(string RequesterID, int LevelID, FGSLevelStateControlInfo LevelManagedInfo, EGSLevelStateInfoLayerType Layer)
	{
		EnsureLevelStateInfoLayerValid(Layer);
		LevelControlInfoLayers[Layer].UpdateLevelState(RequesterID, LevelID, LevelManagedInfo);
		if (LevelControlInfoLayers[Layer].IsEmpty())
		{
			LevelControlInfoLayers.Remove(Layer);
		}
		return GetNewRequestID();
	}

	public FGSPersistentLevelStateLayerInfo GetCurrentLevelStateInfo(int LevelID)
	{
		FGSPersistentLevelStateLayerInfo fGSPersistentLevelStateLayerInfo = new FGSPersistentLevelStateLayerInfo();
		for (int i = 0; i < 4; i++)
		{
			if (LevelControlInfoLayers.TryGetValue((EGSLevelStateInfoLayerType)i, out var value) && value.HasPersistentLevelStateInfo(LevelID))
			{
				fGSPersistentLevelStateLayerInfo.PersistentLevelStateLayers.Add((EGSLevelStateInfoLayerType)i, value.GetCurrentLevelStateInfo(LevelID));
			}
		}
		return fGSPersistentLevelStateLayerInfo;
	}

	private void EnsureLevelStateInfoLayerValid(EGSLevelStateInfoLayerType Layer)
	{
		if (!LevelControlInfoLayers.ContainsKey(Layer))
		{
			LevelControlInfoLayers.Add(Layer, new FGSLevelStateInfoLayer());
		}
	}

	public int GetNewRequestID()
	{
		if (BatchingRequests == null)
		{
			if (RequestedBatchs.Count > 0)
			{
				BatchingRequests = new FGSLevelStateRequestBatchInfo(RequestedBatchs[RequestedBatchs.Count - 1].LastID + 1);
			}
			else
			{
				BatchingRequests = new FGSLevelStateRequestBatchInfo(0);
			}
			return BatchingRequests.LastID;
		}
		return BatchingRequests.Add();
	}

	public int OnBatchingRequestsSent()
	{
		if (BatchingRequests == null)
		{
			return -1;
		}
		RequestedBatchs.Add(BatchingRequests);
		BatchingRequests = null;
		return RequestedBatchs.Count - 1;
	}

	public FGSLevelStateRequestBatchInfo OnRequestedBatchFinished(int BatchID)
	{
		if (BatchID < 0 || RequestedBatchs.Count <= BatchID)
		{
			return null;
		}
		FGSLevelStateRequestBatchInfo result = RequestedBatchs[BatchID];
		RequestedBatchs[BatchID] = null;
		while (RequestedBatchs.Count > 0 && RequestedBatchs[RequestedBatchs.Count - 1] == null)
		{
			RequestedBatchs.RemoveAt(RequestedBatchs.Count - 1);
		}
		return result;
	}
}
