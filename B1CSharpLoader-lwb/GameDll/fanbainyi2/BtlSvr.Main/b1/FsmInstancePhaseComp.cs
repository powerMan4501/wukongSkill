using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FsmInstancePhaseComp
{
	private readonly FsmInstance _fsmInstance;

	private readonly AActor _owner;

	private readonly FCalliopeGraph _graph;

	private readonly List<FGameplayTag> _currentStates;

	private readonly MultiMap<FGameplayTag, FsmNodeInstance_State> _stateNodeMap;

	private readonly Dictionary<Guid, FsmNodeInstance> _nodes;

	public readonly List<FsmSubInstance> SubInstances;

	private FBossPhaseInfo _currentInfo;

	private bool _isInfoValid;

	private bool _isRootPhaseComp;

	private string[] _cachedSubSuffixStateNames;

	private Dictionary<FGameplayTag, FGuardConditionBase> _stageConditionToTarget;

	private IEnumerator<KeyValuePair<FGameplayTag, FGuardConditionBase>> _conditionEnumerator;

	private Dictionary<FGuardConditionBase, float> _traversedConditions;

	private const float AllowQueryingDuration = 1f;

	private bool _hasShowMessageBox;

	private readonly IBUC_UnitStateData _unitStateData;

	private readonly IBUC_FsmData _fsmData;

	public string LastEnterPhasePerformanceReason;

	public string LastLeavePhasePerformanceReason;

	public FName FsmIdentify { get; private set; }

	public FCalliopeAssetReference TemplateAsset { get; private set; }

	public FsmInstancePhaseComp(FsmInstance fsmInstance, bool IsRoot)
	{
		_fsmInstance = fsmInstance;
		_owner = fsmInstance.Owner;
		_graph = fsmInstance.Graph;
		_currentStates = fsmInstance.CurrentStates;
		FsmInstance fsmInstance2 = _fsmInstance;
		fsmInstance2.Evt_NotifyEnterState = (Del_Void_FGameplayTag)Delegate.Combine(fsmInstance2.Evt_NotifyEnterState, new Del_Void_FGameplayTag(OnCurrentStatesAdd));
		_stateNodeMap = fsmInstance.StateNodeMap;
		_nodes = fsmInstance.Nodes;
		SubInstances = fsmInstance.SubInstances;
		FsmIdentify = fsmInstance.FsmIdentify;
		TemplateAsset = fsmInstance.TemplateAsset;
		_isInfoValid = false;
		_isRootPhaseComp = IsRoot;
		_unitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(_owner);
		_fsmData = BGU_DataUtil.GetReadOnlyData<IBUC_FsmData, BUC_FsmData>(_owner);
	}

	public bool CheckIfStopUpdateCurrentStates()
	{
		return _unitStateData.HasState(EBGUUnitState.PhasePerformance);
	}

	private void OnCurrentStatesAdd(FGameplayTag StateTag)
	{
		if (_isInfoValid)
		{
			if (_currentInfo.HasPhasePerformance)
			{
				BUS_EventCollectionCS.Get(_owner).Evt_EnterOrExitPhasePerformance.Invoke(P1: true, $"{StateTag} 导致进入表演状态");
			}
			_isInfoValid = false;
		}
	}

	public void Transition(FBossPhaseInfo Info)
	{
		_currentInfo = Info;
		_isInfoValid = true;
	}

	public void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		_isInfoValid = false;
		ClearTransitionEachPhase(IsReset: true);
		foreach (FsmSubInstance subInstance in SubInstances)
		{
			subInstance.PhaseComp.OnResetActorStatusPre(ResetReason);
		}
	}

	private void TransitionPhaseImpl(FsmNodeInstance_State StateNodeInstance)
	{
		_fsmInstance.Evt_NotifyStateTransition(BGW_FlowUtils.NormalAIFsmEventTag.ExitAll);
		if (!_stateNodeMap.TryGetValue(StateNodeInstance.StateTag, out var value))
		{
			return;
		}
		foreach (FsmNodeInstance_State item in value)
		{
			item.ExecuteNode();
		}
	}

	public void TransitionPhaseForDebug(string SuffixStateName)
	{
		foreach (FsmNodeInstance value in _nodes.Values)
		{
			if (value is FsmNodeInstance_State { StateTag: var stateTag } fsmNodeInstance_State && stateTag.ToString().EndsWith(SuffixStateName, StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					TransitionPhaseImpl(fsmNodeInstance_State);
					break;
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public void TransitionEachPhaseForDebug(string[] SuffixStateNames)
	{
		if (SuffixStateNames != null && SuffixStateNames.Any())
		{
			if (SuffixStateNames.Length > 1)
			{
				_cachedSubSuffixStateNames = SuffixStateNames.Skip(1).Take(SuffixStateNames.Length - 1).ToArray();
			}
			TransitionEachPhaseForThisComp(SuffixStateNames[0]);
		}
	}

	private void TransitionEachPhaseForThisComp(string SuffixStateName)
	{
		Dictionary<FCalliopeNode, FsmNodeInstance_State> dictionary = _nodes.Values.OfType<FsmNodeInstance_State>().ToDictionary((FsmNodeInstance_State nodeInstance) => nodeInstance.Node, (FsmNodeInstance_State nodeInstance) => nodeInstance);
		List<FCalliopeNode> startNodes = (_currentStates.Any() ? (from pair in dictionary
			where pair.Value.StateTag.Equals(_currentStates[0]) && IsReachableToInitialNode(pair.Key)
			select pair.Key).ToList() : new List<FCalliopeNode> { _graph.GetStartNode() });
		List<FCalliopeNode> targetNodes = (from pair in dictionary
			where pair.Value.StateTag.ToString().EndsWith(SuffixStateName, StringComparison.OrdinalIgnoreCase)
			select pair.Key).ToList();
		List<FCalliopeNode> list = FindShortestPathToTargetNodes(startNodes, targetNodes);
		if (list == null)
		{
			return;
		}
		_stageConditionToTarget = new Dictionary<FGameplayTag, FGuardConditionBase>();
		_conditionEnumerator = null;
		for (int num = 0; num < list.Count; num++)
		{
			if (num == list.Count - 1)
			{
				continue;
			}
			FCalliopeNode fCalliopeNode = list[num];
			FCalliopeNode item = list[num + 1];
			if (dictionary.TryGetValue(fCalliopeNode, out var value))
			{
				int num2 = fCalliopeNode.OutputEdges.Values.Select((FCalliopeEdge edge) => edge.To).ToList().IndexOf(item);
				if (num2 < 0 || value.Guards.Count <= num2)
				{
					break;
				}
				_stageConditionToTarget.Add(value.StateTag, value.Guards[num2].Condition);
			}
		}
	}

	private bool IsReachableToInitialNode(FCalliopeNode Node)
	{
		FCalliopeNode startNode = _graph.GetStartNode();
		return FindShortestPathToTargetNodes(new List<FCalliopeNode> { startNode }, new List<FCalliopeNode> { Node }) != null;
	}

	private List<FCalliopeNode> FindShortestPathToTargetNodes(List<FCalliopeNode> startNodes, List<FCalliopeNode> targetNodes)
	{
		foreach (FCalliopeNode startNode in startNodes)
		{
			if (targetNodes.Contains(startNode))
			{
				return new List<FCalliopeNode> { startNode };
			}
		}
		List<FCalliopeNode> list = new List<FCalliopeNode>();
		List<FCalliopeEdge> list2 = new List<FCalliopeEdge>();
		Queue<FCalliopeNode> queue = new Queue<FCalliopeNode>();
		list.AddRange(startNodes);
		startNodes.ForEach(delegate(FCalliopeNode node)
		{
			queue.Enqueue(node);
		});
		while (queue.Any())
		{
			FCalliopeNode fCalliopeNode = queue.Dequeue();
			if (targetNodes.Contains(fCalliopeNode))
			{
				break;
			}
			foreach (FCalliopeEdge value in fCalliopeNode.OutputEdges.Values)
			{
				FCalliopeNode to = value.To;
				if (!list.Contains(to))
				{
					list.Add(to);
					list2.Add(value);
					queue.Enqueue(to);
				}
			}
		}
		if (!list.Any(targetNodes.Contains) || !list2.Any())
		{
			return null;
		}
		list2.Reverse();
		List<FCalliopeNode> list3 = new List<FCalliopeNode>();
		foreach (FCalliopeEdge item in list2)
		{
			if (list3.Any())
			{
				if (item.To == list3.Last())
				{
					list3.Add(item.From);
				}
			}
			else if (targetNodes.Contains(item.To))
			{
				list3.Add(item.To);
				list3.Add(item.From);
			}
			if (list3.Any() && startNodes.Contains(list3.Last()))
			{
				list3.Reverse();
				return list3;
			}
		}
		return null;
	}

	private void TryTransitionPhase(float DeltaSeconds)
	{
		if (_unitStateData.HasState(EBGUUnitState.PhasePerformance) || !IsTransitionEachPhase())
		{
			return;
		}
		if (_conditionEnumerator == null)
		{
			_conditionEnumerator = _stageConditionToTarget.GetEnumerator();
			MoveNextConditionEnumerator();
			if (!IsTransitionEachPhase())
			{
				return;
			}
			_traversedConditions = new Dictionary<FGuardConditionBase, float>();
		}
		FGameplayTag key = _conditionEnumerator.Current.Key;
		FGuardConditionBase value = _conditionEnumerator.Current.Value;
		_traversedConditions = _traversedConditions.Where((KeyValuePair<FGuardConditionBase, float> pair) => pair.Key.QueryState == EQueryState.Querying).ToDictionary((KeyValuePair<FGuardConditionBase, float> pair) => pair.Key, (KeyValuePair<FGuardConditionBase, float> pair) => pair.Value - DeltaSeconds);
		foreach (FGuardConditionBase item in (from pair in _traversedConditions
			where pair.Value < 0f
			select pair.Key).ToList())
		{
			ThrowErrorMessage($"{item}的Condition跳转时间超过了{1f}秒，请程序查看这个问题");
		}
		if (_fsmData.IsInFsmState(key) && value.QueryState == EQueryState.Querying)
		{
			if (!_traversedConditions.ContainsKey(value))
			{
				_traversedConditions.Add(value, 1f);
			}
			if (!value.TryQuickFinishCondition())
			{
				ThrowErrorMessage($"{value.ConditionType}的Condition没有实现快速跳转阶段的方法");
			}
		}
		if (value.QueryState != EQueryState.Querying)
		{
			MoveNextConditionEnumerator();
		}
	}

	private void MoveNextConditionEnumerator()
	{
		if (!_conditionEnumerator.MoveNext())
		{
			ClearTransitionEachPhase();
		}
		else
		{
			BGW_UIEventCollection.Get(_owner).Evt_UI_ShowTransitionPhaseTips(_conditionEnumerator.Current.Key.ToString());
		}
	}

	public void OnTick(float DeltaSeconds)
	{
		TryTransitionPhase(DeltaSeconds);
	}

	private bool IsTransitionEachPhase()
	{
		return _stageConditionToTarget != null;
	}

	private void ClearTransitionEachPhase(bool IsReset = false)
	{
		_stageConditionToTarget = null;
		_conditionEnumerator?.Dispose();
		_traversedConditions = null;
		foreach (FsmSubInstance subInstance in SubInstances)
		{
			if (IsReset)
			{
				subInstance.PhaseComp.ClearTransitionEachPhase(IsReset: true);
			}
			else
			{
				subInstance.PhaseComp.TransitionEachPhaseForDebug(_cachedSubSuffixStateNames);
			}
		}
		_cachedSubSuffixStateNames = null;
	}

	private void ThrowErrorMessage(string Message)
	{
		if (!_hasShowMessageBox)
		{
			FMessage.OpenDialog("Something wrong: " + Message);
			_hasShowMessageBox = true;
		}
	}

	public void FetchEachBossPhase(ref List<string> ToFetchList, string Separated, string UpperStateName = null)
	{
		foreach (FsmNodeInstance value in _nodes.Values)
		{
			if (IsReachableToInitialNode(value.Node) && value is FsmNodeInstance_State fsmNodeInstance_State)
			{
				string text = (string.IsNullOrEmpty(UpperStateName) ? fsmNodeInstance_State.StateTag.ToString() : $"{UpperStateName}{Separated}{fsmNodeInstance_State.StateTag}");
				if (!ToFetchList.Contains(text))
				{
					ToFetchList.Add(text);
				}
				fsmNodeInstance_State.SubInstance?.PhaseComp.FetchEachBossPhase(ref ToFetchList, Separated, text);
			}
		}
	}
}
