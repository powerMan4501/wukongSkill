using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FsmInstance
{
	public Del_Void_FGameplayTag Evt_NotifyStateTransition = delegate
	{
	};

	public Del_Void_Float Evt_NotifyStateTick = delegate
	{
	};

	public Del_Void_FGameplayTag Evt_NotifyEnterState = delegate
	{
	};

	public Del_Void_FGameplayTag Evt_NotifyExitState = delegate
	{
	};

	protected bool bEnableFsmProfile { get; set; }

	public AActor Owner { get; set; }

	public bool HasAuthority { get; set; }

	public FCalliopeAssetReference TemplateAsset { get; set; }

	public FName FsmIdentify { get; protected set; }

	public BUC_FsmData FsmData { get; protected set; }

	public FCalliopeGraph Graph { get; set; }

	public Dictionary<Guid, FsmNodeInstance> Nodes { get; } = new Dictionary<Guid, FsmNodeInstance>();

	public List<FsmSubInstance> SubInstances { get; private set; } = new List<FsmSubInstance>();

	private Queue<FGameplayTag> EventTagQueue { get; } = new Queue<FGameplayTag>();

	public MultiMap<FGameplayTag, FsmNodeInstance_State> StateNodeMap { get; } = new MultiMap<FGameplayTag, FsmNodeInstance_State>();

	public FsmNodeInstance_CustomEnter CustomEnterNode { get; private set; }

	public FsmNodeInstance_CustomExit CustomExitNode { get; private set; }

	private List<FGameplayTag> HistoryStates { get; } = new List<FGameplayTag>();

	public FsmInstancePhaseComp PhaseComp { get; protected set; }

	public List<FGameplayTag> CurrentStates
	{
		get
		{
			if (!FsmData.CurrentStatesMapping.TryGetValue(FsmIdentify, out var value))
			{
				value = new List<FGameplayTag>();
				if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
				{
					FsmData.CurrentStatesMapping.Add(FsmIdentify, value);
				}
				return value;
			}
			return value;
		}
	}

	public static FsmInstance Create(string AssetPath, AActor InOwner)
	{
		if (string.IsNullOrEmpty(AssetPath))
		{
			return null;
		}
		FsmInstance obj = new FsmInstance
		{
			Graph = GameplayTagExtension.LoadGraph(AssetPath, bUseCache: true),
			FsmData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(InOwner),
			FsmIdentify = GenIdentify(InOwner),
			Owner = InOwner,
			HasAuthority = BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(InOwner),
			TemplateAsset = FCalliopeAssetReference.CreateInstance(InOwner, ECalliopeAssetType.State, AssetPath)
		};
		InitialGraphNodes(obj);
		return obj;
	}

	public void MarkAsPhaseInstance(bool IsRoot)
	{
		if (PhaseComp == null)
		{
			PhaseComp = new FsmInstancePhaseComp(this, IsRoot);
		}
		foreach (FsmSubInstance subInstance in SubInstances)
		{
			subInstance.MarkAsPhaseInstance(IsRoot: false);
		}
	}

	public FFsmGraphCacheData GetGraphCacheData()
	{
		FFsmGraphCacheData fFsmGraphCacheData = Graph.GraphCacheData as FFsmGraphCacheData;
		if (fFsmGraphCacheData == null)
		{
			fFsmGraphCacheData = new FFsmGraphCacheData();
			Graph.GraphCacheData = fFsmGraphCacheData;
		}
		return fFsmGraphCacheData;
	}

	protected static FName GenIdentify(AActor Owner)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Owner);
		int identifyCount = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(Owner).IdentifyCount;
		return new FName($"{actorGuid}_{identifyCount}");
	}

	protected static void InitialGraphNodes(FsmInstance InInstance)
	{
		FCalliopeGraph graph = InInstance.Graph;
		FFsmGraphCacheData graphCacheData = InInstance.GetGraphCacheData();
		foreach (FCalliopeNode node in graph.Nodes)
		{
			FsmNodeInstance fsmNodeInstance = FsmNodeInstanceFactory.Create(node, InInstance);
			if (fsmNodeInstance == null)
			{
				continue;
			}
			InInstance.Nodes.Add(node.NodeGuid, fsmNodeInstance);
			if (node.NodeClass == B1CalliopeDef.StateNode.CustomEnter)
			{
				if (InInstance.CustomEnterNode == null && fsmNodeInstance is FsmNodeInstance_CustomEnter customEnterNode)
				{
					InInstance.CustomEnterNode = customEnterNode;
				}
			}
			else if (node.NodeClass == B1CalliopeDef.StateNode.CustomExit)
			{
				if (InInstance.CustomExitNode == null && fsmNodeInstance is FsmNodeInstance_CustomExit customExitNode)
				{
					InInstance.CustomExitNode = customExitNode;
				}
			}
			else if (!(node.NodeClass != B1CalliopeDef.StateNode.Single) && fsmNodeInstance is FsmNodeInstance_State inValue)
			{
				FGameplayTag nodeStateTag = graphCacheData.GetNodeStateTag(node);
				Dictionary<FGameplayTag, FsmState> stateMap = InInstance.FsmData.StateMap;
				if (stateMap.ContainsKey(nodeStateTag))
				{
					BGW_LogUtil.LogError($"{InInstance.Owner.GetName()}的FSM，检测到重复的状态名称{nodeStateTag.TagName}，会导致不可预料的结果，请检查各个FSM的配置");
				}
				else
				{
					stateMap.Add(nodeStateTag, new FsmState_Flag(nodeStateTag));
				}
				InInstance.StateNodeMap.Add(nodeStateTag, inValue);
			}
		}
	}

	public bool TryGetNodeInstance(Guid InGuid, out FsmNodeInstance OutNodeInstance)
	{
		return Nodes.TryGetValue(InGuid, out OutNodeInstance);
	}

	public void OnEnterState(FGameplayTag StateTag)
	{
		if (!CurrentStates.Contains(StateTag))
		{
			CurrentStates.Add(StateTag);
			if (FsmData.StateMap.TryGetValue(StateTag, out var value))
			{
				value.OnEnterAction(this);
			}
			Evt_NotifyEnterState(StateTag);
		}
	}

	public void OnExitState(FGameplayTag StateTag)
	{
		if (CurrentStates.Contains(StateTag))
		{
			CurrentStates.Remove(StateTag);
			if (FsmData.StateMap.TryGetValue(StateTag, out var value))
			{
				value.OnExitAction(this);
			}
			Evt_NotifyExitState(StateTag);
		}
	}

	public virtual void Start()
	{
		TemplateAsset.StartInstance();
		ResetToInitState();
	}

	public virtual void Start_Custom(FName CustomEvent)
	{
		TemplateAsset.StartInstance();
		ResetToCustomEnterState(CustomEvent);
	}

	public virtual void Back2History(bool bDeepHistory)
	{
		TemplateAsset.StartInstance();
		ResetToHistoryState(bDeepHistory);
	}

	public void ResetToInitState()
	{
		FCalliopeNode startNode = Graph.GetStartNode();
		if (startNode != null)
		{
			Nodes[startNode.NodeGuid].ExecuteNode();
		}
	}

	public void ResetToCustomEnterState(FName CustomEvent)
	{
		if (CustomEnterNode != null)
		{
			CustomEnterNode.ExecuteNode_Custom(CustomEvent);
		}
	}

	public void ResetToHistoryState(bool bDeepHistory)
	{
		if (HistoryStates.Count == 0)
		{
			ResetToInitState();
			return;
		}
		foreach (FGameplayTag historyState in HistoryStates)
		{
			if (!StateNodeMap.TryGetValue(historyState, out var value))
			{
				continue;
			}
			foreach (FsmNodeInstance_State item in value)
			{
				if (bDeepHistory)
				{
					item.NodeBack2History(bDeepHistory: true);
				}
				else
				{
					item.ExecuteNode();
				}
			}
		}
	}

	public void ExitFsm()
	{
		OnExit();
	}

	protected virtual void OnExit()
	{
		OnTick(0f);
		HistoryStates.Clear();
		HistoryStates.AddRange(CurrentStates);
		foreach (KeyValuePair<Guid, FsmNodeInstance> node in Nodes)
		{
			node.Value.ForceExitNode();
		}
		EventTagQueue.Clear();
	}

	public virtual void OnTerminate()
	{
		Shutdown();
	}

	public virtual void Shutdown()
	{
		OnExit();
		foreach (FsmNodeInstance value in Nodes.Values)
		{
			value.NotifyShutdown();
		}
		TemplateAsset.FinishInstance();
		foreach (KeyValuePair<FGameplayTag, List<FsmNodeInstance_State>> item in StateNodeMap)
		{
			FsmData.StateMap.Remove(item.Key);
		}
	}

	public void AddSubInstance(FsmSubInstance SubInstance)
	{
		SubInstances.Add(SubInstance);
		if (PhaseComp != null)
		{
			SubInstance.MarkAsPhaseInstance(IsRoot: false);
		}
	}

	public void RemoveSubInstance(FsmSubInstance SubInstance)
	{
		SubInstances.Remove(SubInstance);
	}

	public void OnEvent(FGameplayTag EvenTag)
	{
		EventTagQueue.Enqueue(EvenTag);
	}

	public void OnClearCacheEvent()
	{
		EventTagQueue.Clear();
	}

	public virtual void OnTick(float DeltaSeconds)
	{
		if (PhaseComp != null && PhaseComp.CheckIfStopUpdateCurrentStates())
		{
			return;
		}
		ProfileBegin("[FsmTick]EventTagQueue");
		while (EventTagQueue.Count > 0)
		{
			FGameplayTag fGameplayTag = EventTagQueue.Dequeue();
			Evt_NotifyStateTransition(fGameplayTag);
			if (GameplayTagExtension.EqualTo(fGameplayTag, BGW_FlowUtils.NormalAIFsmEventTag.CommonReset))
			{
				ResetToInitState();
			}
		}
		ProfileEnd();
		ProfileBegin("[FsmTick]State Tick");
		Evt_NotifyStateTick(DeltaSeconds);
		ProfileEnd();
		ProfileBegin("[FsmTick]PhaseComp Tick");
		PhaseComp?.OnTick(DeltaSeconds);
		ProfileEnd();
	}

	public virtual void QueryAllCurrentStates(ref HashSet<FGameplayTag> RefCurrentStates)
	{
		foreach (FsmSubInstance subInstance in SubInstances)
		{
			subInstance.QueryAllCurrentStates(ref RefCurrentStates);
		}
		foreach (FGameplayTag currentState in CurrentStates)
		{
			RefCurrentStates.Add(currentState);
		}
	}

	protected void ProfileBegin(string Name)
	{
		_ = bEnableFsmProfile;
	}

	protected void ProfileEnd()
	{
		_ = bEnableFsmProfile;
	}
}
