using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.Plugins.Calliope;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public sealed class PsmInstance
{
	private TWeakObject<UObject> OwnerPtr;

	public FCalliopeAssetReference TemplateAsset { get; set; }

	public UObject Owner
	{
		get
		{
			if (OwnerPtr.IsValid())
			{
				return OwnerPtr.Get();
			}
			return null;
		}
		set
		{
			OwnerPtr.Set(value);
		}
	}

	public string PsmGuid { get; set; }

	public string GraphName => Graph.GraphName;

	private FCalliopeGraph Graph { get; set; }

	private Action TerminateCallBack { get; set; }

	private Dictionary<Guid, PsmNodeInstance> NodeInstances { get; } = new Dictionary<Guid, PsmNodeInstance>();

	private Dictionary<string, PsmStateInstance> StateInstances { get; } = new Dictionary<string, PsmStateInstance>();

	private Dictionary<string, PsmNodeInstance> StateNodeInstances { get; } = new Dictionary<string, PsmNodeInstance>();

	private Dictionary<string, PsmNodeInstance> ResetGroupStartNodeInstances { get; } = new Dictionary<string, PsmNodeInstance>();

	private Dictionary<string, PsmNodeInstance> ActivedGroups { get; } = new Dictionary<string, PsmNodeInstance>();

	private Queue<FGameplayTag> EventQueue { get; } = new Queue<FGameplayTag>();

	public List<PsmNodeInstance> ActivedNodeInstances { get; } = new List<PsmNodeInstance>();

	public Dictionary<Guid, PsmParameterInstance> ParameterInstances { get; } = new Dictionary<Guid, PsmParameterInstance>();

	private bool bIsInReset { get; set; }

	private bool bReadyToGraphEnd { get; set; }

	public Dictionary<Guid, List<FIdleProcessExecutorBase>> IdleNodeProcessActions { get; } = new MultiMap<Guid, FIdleProcessExecutorBase>();

	public static PsmInstance Create(Action InTerminateCallBack, string AssetPath, UObject Owner, string InPsmGuid = null, string AliasName = null, string PrefixName = null)
	{
		if (string.IsNullOrEmpty(AssetPath))
		{
			return null;
		}
		FCalliopeGraph fCalliopeGraph = GameplayTagExtension.LoadGraph(AssetPath);
		if (fCalliopeGraph == null)
		{
			return null;
		}
		PsmInstance psmInstance = new PsmInstance();
		psmInstance.Graph = fCalliopeGraph;
		psmInstance.TemplateAsset = FCalliopeAssetReference.CreateInstance(Owner, ECalliopeAssetType.Process, AssetPath, (string.IsNullOrEmpty(PrefixName) ? Owner.GetName() : PrefixName) + "_" + (string.IsNullOrEmpty(AliasName) ? "" : AliasName));
		psmInstance.TerminateCallBack = InTerminateCallBack;
		psmInstance.Owner = Owner;
		psmInstance.PsmGuid = (string.IsNullOrEmpty(InPsmGuid) ? UBGWFunctionLibraryCS.GenerateRandomGuid("ProcessStatMachine") : InPsmGuid);
		if (fCalliopeGraph.BranchGraphs != null)
		{
			foreach (KeyValuePair<string, FCalliopeGraph> branchGraph in fCalliopeGraph.BranchGraphs)
			{
				PsmStateInstance value = PsmStateInstance.Create(branchGraph.Value, psmInstance);
				psmInstance.StateInstances.Add(branchGraph.Key, value);
			}
		}
		if (fCalliopeGraph.Nodes != null)
		{
			foreach (FCalliopeNode node in fCalliopeGraph.Nodes)
			{
				if (string.IsNullOrEmpty(node.GraphIdentifier))
				{
					PsmNodeInstance value2 = CreateNodeInstance(node, psmInstance);
					psmInstance.NodeInstances.Add(node.NodeGuid, value2);
				}
			}
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_RegisterPsmInstance(psmInstance.PsmGuid, psmInstance);
		}
		return psmInstance;
	}

	public static PsmNodeInstance CreateNodeInstance(FCalliopeNode Node, PsmInstance ParentInstance)
	{
		PsmNodeInstance psmNodeInstance = FPsmNodeInstanceFactory.CreateInstance(Node.NodeClass);
		if (psmNodeInstance != null)
		{
			psmNodeInstance.Node = Node;
			psmNodeInstance.ParentInstance = ParentInstance;
			psmNodeInstance.PostCreate();
			return psmNodeInstance;
		}
		return null;
	}

	public void OnGraphStart()
	{
		EventQueue.Clear();
		if (FCalliopeGraph.IsValid(Graph))
		{
			TemplateAsset.StartInstance();
			OnTriggerNodeInput(Graph.GetStartNode(), "");
		}
	}

	public void NotifyGraphEnd()
	{
		bReadyToGraphEnd = true;
	}

	private void OnGraphEnd()
	{
		bReadyToGraphEnd = false;
		EventQueue.Clear();
		if (!FCalliopeGraph.IsValid(Graph))
		{
			return;
		}
		foreach (PsmNodeInstance value in NodeInstances.Values)
		{
			value.Shutdown();
		}
		NodeInstances.Clear();
		BGW_EventCollection.Get(Owner).Evt_UnregisterPsmInstance(PsmGuid);
		TemplateAsset.FinishInstance();
		TerminateCallBack?.Invoke();
	}

	public void OnGraphTick(float DeltaTime, bool bIsOpeningLevel)
	{
		for (int num = ActivedNodeInstances.Count - 1; num >= 0; num--)
		{
			ActivedNodeInstances[num].Tick(DeltaTime);
		}
		while (EventQueue.Count > 0)
		{
			FGameplayTag eventTag = EventQueue.Dequeue();
			for (int num2 = ActivedNodeInstances.Count - 1; num2 >= 0; num2--)
			{
				ActivedNodeInstances[num2].OnEvent(eventTag);
			}
		}
		if (!bIsOpeningLevel)
		{
			foreach (KeyValuePair<Guid, List<FIdleProcessExecutorBase>> idleNodeProcessAction in IdleNodeProcessActions)
			{
				foreach (FIdleProcessExecutorBase item in idleNodeProcessAction.Value)
				{
					if (item.CanTick())
					{
						item.OnTick(Owner, DeltaTime);
					}
				}
			}
		}
		if (bReadyToGraphEnd)
		{
			OnGraphEnd();
		}
	}

	public void OnEvent(FGameplayTag EventTag)
	{
		EventQueue.Enqueue(EventTag);
	}

	private void OnTriggerNodeInput(FCalliopeNode Node, string InputPin)
	{
		FindOrAddNodeInstance(Node)?.TriggerInputWithGroupName(InputPin, "");
	}

	public void Shutdown()
	{
		EventQueue.Clear();
		foreach (PsmNodeInstance value in NodeInstances.Values)
		{
			value.Shutdown();
		}
		NodeInstances.Clear();
		TemplateAsset?.FinishInstance();
		BGW_EventCollection.Get(Owner).Evt_UnregisterPsmInstance(PsmGuid);
		TemplateAsset = null;
	}

	public void ExecuteEdge(FCalliopeEdge Edge, string GroupName)
	{
		FindOrAddNodeInstance(Edge.To)?.TriggerInputWithGroupName(Edge.ToPinName, GroupName);
	}

	public void ForceEdgeFinish(FCalliopeEdge Edge)
	{
		FindOrAddNodeInstance(Edge.To)?.ForceFinishInCurrentGroup();
	}

	private PsmNodeInstance FindOrAddNodeInstance(FCalliopeNode Node)
	{
		Guid nodeGuid = Node.NodeGuid;
		if (NodeInstances.ContainsKey(nodeGuid))
		{
			return NodeInstances[nodeGuid];
		}
		return null;
	}

	public void StartGroup(string GroupName, PsmNodeInstance GroupNodeInstance)
	{
		if (!ActivedGroups.ContainsKey(GroupName))
		{
			if (!ResetGroupStartNodeInstances.TryGetValue(GroupName, out var value))
			{
				GroupNodeInstance.TriggerFirstOutput(bFinish: true);
				return;
			}
			ActivedGroups.Add(GroupName, GroupNodeInstance);
			value.ForceFinishInCurrentGroup();
			value.TriggerInputWithGroupName("", GroupName);
		}
	}

	public void FinishGroup(string GroupName)
	{
		if (ActivedGroups.TryGetValue(GroupName, out var value))
		{
			ActivedGroups.Remove(GroupName);
			value.OnEvent(BGW_FlowUtils.CommonProcessTag.Event_GroupFinish);
		}
	}

	public void TerminateGroup(string GroupName)
	{
		if (ActivedGroups.ContainsKey(GroupName))
		{
			ActivedGroups.Remove(GroupName);
		}
		foreach (PsmNodeInstance item in new List<PsmNodeInstance>(ActivedNodeInstances))
		{
			if (item.CurrentGroupName == GroupName)
			{
				item.Shutdown();
			}
		}
	}

	public void RegisterGroupStartNodeInstance(string GroupName, PsmNodeInstance NodeInstance)
	{
		if (!ResetGroupStartNodeInstances.ContainsKey(GroupName))
		{
			ResetGroupStartNodeInstances.Add(GroupName, NodeInstance);
		}
	}

	public void RegisterStateNodeInstance(string StateTagStr, PsmNodeInstance NodeInstance)
	{
		if (StateNodeInstances.ContainsKey(StateTagStr))
		{
			StateNodeInstances[StateTagStr] = NodeInstance;
		}
		else
		{
			StateNodeInstances.Add(StateTagStr, NodeInstance);
		}
	}

	public bool TryGetStateInstance(string StateTagStr, out PsmStateInstance StateInstance)
	{
		StateInstance = null;
		if (StateInstances.ContainsKey(StateTagStr))
		{
			StateInstance = StateInstances[StateTagStr];
			return true;
		}
		return false;
	}

	public void OnFinalState()
	{
		foreach (PsmNodeInstance value in NodeInstances.Values)
		{
			if (value.ActivationState == ActivationState.Active)
			{
				return;
			}
		}
		NotifyGraphEnd();
	}

	public void JunctionToState(string StateTagStr, string GroupName)
	{
		if (StateNodeInstances.TryGetValue(StateTagStr, out var value))
		{
			value.TriggerInputWithGroupName(B1CalliopeDef.Common.DefaultInputPinName, GroupName);
		}
	}

	public PsmArchiveGraphData GetRecoverData()
	{
		PsmArchiveGraphData psmArchiveGraphData = new PsmArchiveGraphData();
		psmArchiveGraphData.PsmId = PsmGuid;
		foreach (KeyValuePair<Guid, PsmNodeInstance> nodeInstance in NodeInstances)
		{
			PsmNodeInstance value = nodeInstance.Value;
			PsmArchiveNodeData psmArchiveNodeData = new PsmArchiveNodeData();
			if (!string.IsNullOrEmpty(value.CurrentGroupName))
			{
				psmArchiveNodeData.ActivationState = ActivationState.NeverActivated;
			}
			else
			{
				psmArchiveNodeData.ActivationState = value.ActivationState;
			}
			psmArchiveNodeData.UniqueId = value.Node.NodeGuid.ToString();
			psmArchiveGraphData.NodeData.Add(psmArchiveNodeData);
		}
		return psmArchiveGraphData;
	}

	public void SetRecoverData(PsmArchiveGraphData GraphData)
	{
		List<PsmNodeInstance> list = new List<PsmNodeInstance>();
		foreach (PsmArchiveNodeData nodeDatum in GraphData.NodeData)
		{
			if (NodeInstances.TryGetValue(Guid.Parse(nodeDatum.UniqueId), out var value))
			{
				value.ActivationState = nodeDatum.ActivationState;
				if (value.ActivationState == ActivationState.Active)
				{
					TemplateAsset.RecordOnlyNode(value.Node.NodeGuid);
					list.Add(value);
				}
			}
		}
		foreach (PsmNodeInstance item in list)
		{
			item.RecoverActiveState();
		}
		list.Clear();
	}

	public void OnReset()
	{
		bIsInReset = true;
		foreach (PsmNodeInstance value2 in NodeInstances.Values)
		{
			if (value2.ActivationState == ActivationState.Active)
			{
				value2.OnReset();
			}
		}
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, PsmNodeInstance> activedGroup in ActivedGroups)
		{
			string key = activedGroup.Key;
			list.Add(key);
		}
		foreach (string item in list)
		{
			if (ResetGroupStartNodeInstances.TryGetValue(item, out var value))
			{
				value.TriggerInputWithGroupName("", item);
			}
		}
		bIsInReset = false;
	}

	public bool IsInReset()
	{
		return bIsInReset;
	}

	public void RegisterParameter(ProcessCustom_Param Param)
	{
		if (!Guid.TryParse(Param.ParamGuid, out var result) || ParameterInstances.ContainsKey(result))
		{
			return;
		}
		PsmParameterInstance psmParameterInstance = new PsmParameterInstance();
		psmParameterInstance.ParamGuid = result;
		psmParameterInstance.ParamType = (EGsManagedParamType)Param.ParamType;
		psmParameterInstance.ParamValueStr = Param.ParamString;
		if (psmParameterInstance.ParamType == EGsManagedParamType.AiConversationID)
		{
			psmParameterInstance.ParamValueArrayInt = new List<int>();
			psmParameterInstance.ParamValueArrayInt = BGUFuncLibAiConversation.AnalysisStrParam_To_IntValueList(Param.ParamString, ',');
		}
		psmParameterInstance.ParamValueInt = Param.ParamInt;
		if (Guid.TryParse(Param.ParamLinkInt, out var result2))
		{
			psmParameterInstance.ParamLinkInt = result2;
		}
		if (Guid.TryParse(Param.ParamLinkString, out var result3))
		{
			psmParameterInstance.ParamLinkString = result3;
		}
		psmParameterInstance.ParamSubInstances = new Dictionary<Guid, PsmParameterSubInstance>();
		foreach (ProcessCustom_SubParam paramSub in Param.ParamSubList)
		{
			if (Guid.TryParse(paramSub.ParamGuid, out var result4))
			{
				psmParameterInstance.ParamSubInstances.Add(result4, new PsmParameterSubInstance
				{
					ParamGuid = result4,
					ParamValueStr = paramSub.ParamString,
					ParamAliasName = paramSub.ParamAliasName
				});
			}
		}
		psmParameterInstance.ParamAliasName = Param.ParamAliasName;
		ParameterInstances.Add(result, psmParameterInstance);
	}

	public void RegisterParameterOverride(Guid ParamGuid, EGsManagedParamType ParamType, string ParamValueStr, int ParamValueInt, List<int> ParamValueArrayInt, string OverrideComment)
	{
		if (ParameterInstances.TryGetValue(ParamGuid, out var value) && value.ParamType == ParamType)
		{
			value.ParamValueStr = ParamValueStr;
			value.ParamValueInt = ParamValueInt;
			value.ParamValueArrayInt = ParamValueArrayInt;
			value.OverrideComment = OverrideComment;
			value.bOverride = true;
		}
	}

	public bool TryGetParameter(string InParamGuidStr, out PsmParameterInstance OutParameterInstance)
	{
		OutParameterInstance = null;
		if (Guid.TryParse(InParamGuidStr, out var result))
		{
			return ParameterInstances.TryGetValue(result, out OutParameterInstance);
		}
		return false;
	}

	public string ConvertParamID2StringParam(string InParamGuidStr)
	{
		if (TryGetParameter(InParamGuidStr, out var OutParameterInstance))
		{
			return OutParameterInstance.ParamValueStr;
		}
		return "";
	}

	public int ConvertParamID2IntParam(string InParamGuidStr)
	{
		if (TryGetParameter(InParamGuidStr, out var OutParameterInstance))
		{
			return OutParameterInstance.ParamValueInt;
		}
		return 0;
	}

	public List<int> ConvertParamID2ArrayIntParam(string InParamGuidStr)
	{
		if (TryGetParameter(InParamGuidStr, out var OutParameterInstance))
		{
			return OutParameterInstance.ParamValueArrayInt;
		}
		return null;
	}

	public string ConvertParamID2StringParam(Guid InParamGuid)
	{
		if (ParameterInstances.TryGetValue(InParamGuid, out var value))
		{
			return value.ParamValueStr;
		}
		return "";
	}

	public string ConvertParamID2UnitGuid(string InParamGuid)
	{
		if (InParamGuid == Guid.Empty.ToString())
		{
			UGSE_EngineFuncLib.GetWorldFromObj(Owner);
			return BGU_DataUtil.GetActorGuid(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn());
		}
		return ConvertParamID2StringParam(InParamGuid);
	}

	public int ConvertParamID2IntParam(Guid InParamGuid)
	{
		if (ParameterInstances.TryGetValue(InParamGuid, out var value))
		{
			return value.ParamValueInt;
		}
		return 0;
	}

	public int ConvertParamID2IntParamUseLink(string InParamGuidStr)
	{
		if (TryGetParameter(InParamGuidStr, out var OutParameterInstance))
		{
			return ConvertParamID2IntParam(OutParameterInstance.ParamLinkInt);
		}
		return 0;
	}

	public string ConvertParamID2StringParamUseLink(string InParamGuidStr)
	{
		if (TryGetParameter(InParamGuidStr, out var OutParameterInstance))
		{
			return ConvertParamID2StringParam(OutParameterInstance.ParamLinkString);
		}
		return "";
	}

	public List<PsmStateNodeInstance> GetPsmStateNodeInstances()
	{
		List<PsmStateNodeInstance> list = new List<PsmStateNodeInstance>();
		foreach (PsmStateInstance item in new List<PsmStateInstance>(StateInstances.Values))
		{
			list.AddRange(item.GetNodeInstances().Values);
		}
		return list;
	}

	public Dictionary<Guid, PsmNodeInstance> GetNodeInstances()
	{
		return NodeInstances;
	}
}
