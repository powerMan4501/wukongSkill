using System.Collections.Concurrent;
using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BIC_SubLevelStreamingMgrData : IBIC_SubLevelStreamingMgrData, IPersistentECSData
{
	public FGSPersistentLevelStateLayerInfo CurrentPersistentLevelStateLayerInfo;

	public List<string> OverlappingBoxGuidsQueue;

	public FGSSubLevelStates ActiveLevelStates;

	public Dictionary<int, List<int>> RequestBatchOperationIDs;

	public ConcurrentQueue<int> FinishedOperationIDs;

	public Dictionary<int, KeyValuePair<EGSLevelState, List<string>>> RequestingOperationLevelInfo;

	public bool bRequestedUpdateLevelState;

	public float UpdateLevelStateCountDown;

	public int NeedDelayedTick;

	public Dictionary<EGSLevelState, List<string>> NewLevelStateRequests { get; private set; }

	public Dictionary<EGSLevelState, List<string>> NewLevelStateBlockRequests { get; private set; }

	public Dictionary<string, EGSLevelState> NewLevelStates { get; private set; }

	public List<FGSDelayedBlockLoadLevelInfo> DelayedBlockLoadLevels { get; private set; }

	public Dictionary<int, float> SequenceLoadTimers { get; private set; }

	public BIC_SubLevelStreamingMgrData()
	{
		CurrentPersistentLevelStateLayerInfo = new FGSPersistentLevelStateLayerInfo();
		FinishedOperationIDs = new ConcurrentQueue<int>();
		RequestingOperationLevelInfo = new Dictionary<int, KeyValuePair<EGSLevelState, List<string>>>();
		OverlappingBoxGuidsQueue = new List<string>();
		ActiveLevelStates = new FGSSubLevelStates();
		bRequestedUpdateLevelState = false;
		UpdateLevelStateCountDown = -1f;
		RequestBatchOperationIDs = new Dictionary<int, List<int>>();
		NewLevelStateRequests = new Dictionary<EGSLevelState, List<string>>
		{
			{
				EGSLevelState.Auto,
				new List<string>()
			},
			{
				EGSLevelState.LoadedVisible,
				new List<string>()
			},
			{
				EGSLevelState.LoadedInvisible,
				new List<string>()
			},
			{
				EGSLevelState.Unloaded,
				new List<string>()
			}
		};
		NewLevelStateBlockRequests = new Dictionary<EGSLevelState, List<string>>
		{
			{
				EGSLevelState.Auto,
				new List<string>()
			},
			{
				EGSLevelState.LoadedVisible,
				new List<string>()
			},
			{
				EGSLevelState.LoadedInvisible,
				new List<string>()
			},
			{
				EGSLevelState.Unloaded,
				new List<string>()
			}
		};
		NewLevelStates = new Dictionary<string, EGSLevelState>();
		DelayedBlockLoadLevels = new List<FGSDelayedBlockLoadLevelInfo>();
		SequenceLoadTimers = new Dictionary<int, float>();
	}

	public void ResetNewLevelStateContainers(out Dictionary<string, EGSLevelState> NewLevelStates, out Dictionary<EGSLevelState, List<string>> NewLevelStateRequests, out Dictionary<EGSLevelState, List<string>> NewLevelStateBlockRequests)
	{
		NewLevelStates = this.NewLevelStates;
		NewLevelStateRequests = this.NewLevelStateRequests;
		NewLevelStateBlockRequests = this.NewLevelStateBlockRequests;
		foreach (List<string> value in NewLevelStateRequests.Values)
		{
			value.Clear();
		}
		foreach (List<string> value2 in NewLevelStateBlockRequests.Values)
		{
			value2.Clear();
		}
		NewLevelStates.Clear();
	}

	public List<string> GetManuallyControlledLevelNames()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in ActiveLevelStates.ManagedLevels)
		{
			if (managedLevel.Value.LevelState != EGSLevelState.Auto)
			{
				list.Add(managedLevel.Key);
			}
		}
		return list;
	}

	public void FlushLevelStreamingStates()
	{
		ActiveLevelStates = new FGSSubLevelStates();
		RequestBatchOperationIDs.Clear();
		int result;
		while (FinishedOperationIDs.TryDequeue(out result))
		{
		}
		RequestingOperationLevelInfo.Clear();
		bRequestedUpdateLevelState = false;
		NeedDelayedTick = 0;
		DelayedBlockLoadLevels.Clear();
		SequenceLoadTimers.Clear();
	}
}
