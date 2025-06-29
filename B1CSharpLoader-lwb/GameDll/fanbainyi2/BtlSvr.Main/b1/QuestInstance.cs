using System;
using System.Collections.Generic;
using ArchiveB1;
using UnrealEngine.Runtime;

namespace b1;

public class QuestInstance
{
	public UObject Owner { get; set; }

	public FCalliopeAssetReference TemplateAsset { get; set; }

	public Dictionary<Guid, QuestSubInstance> SubInstances { get; } = new Dictionary<Guid, QuestSubInstance>();

	public FCalliopeGraph Graph { get; set; }

	public Dictionary<Guid, QuestNodeInstance> NodeInstances { get; } = new Dictionary<Guid, QuestNodeInstance>();

	public HashSet<int> ReferenceTaskStageList { get; } = new HashSet<int>();

	public static QuestInstance Create(string AssetPath, ECalliopeAssetType AssetType, UObject InOwner)
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
		QuestInstance questInstance = new QuestInstance();
		questInstance.Graph = fCalliopeGraph;
		questInstance.TemplateAsset = FCalliopeAssetReference.CreateInstance(InOwner, AssetType, AssetPath);
		questInstance.Owner = InOwner;
		foreach (FCalliopeNode node in fCalliopeGraph.Nodes)
		{
			QuestNodeInstance questNodeInstance = QuestNodeInstanceFactory.Create(node, InOwner, questInstance);
			if (questNodeInstance != null)
			{
				questInstance.NodeInstances.Add(node.NodeGuid, questNodeInstance);
			}
		}
		return questInstance;
	}

	public virtual void OnGraphStart()
	{
		if (FCalliopeGraph.IsValid(Graph))
		{
			TemplateAsset.StartInstance();
			OnTriggerNodeInput(Graph.GetStartNode(), "");
		}
	}

	public virtual void OnGraphRecover(LevelArchiveQuestData ArchiveData)
	{
		if (!FCalliopeGraph.IsValid(Graph))
		{
			return;
		}
		TemplateAsset.StartInstance();
		List<QuestNodeInstance> list = new List<QuestNodeInstance>();
		foreach (LevelArchiveQuestNodeData node in ArchiveData.Nodes)
		{
			if (!node.IsDataValid || !NodeInstances.TryGetValue(Guid.Parse(node.UniqueId), out var value))
			{
				continue;
			}
			value.ActivationState = node.ActivationState;
			value.SetNodeCustomData(node.CustomData.ToByteArray());
			if (value.ActivationState != ActivationState.Active)
			{
				continue;
			}
			TemplateAsset.RecordOnlyNode(value.Node.NodeGuid);
			list.Add(value);
			foreach (string item in node.ObserveActorGuid)
			{
				if (value is IObserveNodeInstance p)
				{
					if (value is TaskNodeInstance_ObserveUnitByCondition || value is TaskNodeInstance_ObserveUnitsDeadWithOrder)
					{
						BGW_EventCollection.Get(Owner).Evt_TaskGraphStartObserve(p, item);
					}
					else
					{
						BGS_EventCollectionCS.Get(Owner).Evt_BGS_StartObserve.Invoke(p, item);
					}
				}
			}
		}
		foreach (QuestNodeInstance item2 in list)
		{
			item2.RecoverActiveState();
		}
		list.Clear();
		foreach (LevelArchiveQuestData subGraphDatum in ArchiveData.SubGraphData)
		{
			if (SubInstances.TryGetValue(Guid.Parse(subGraphDatum.ParentNodeGuid), out var value2))
			{
				value2.OnGraphRecover(subGraphDatum);
			}
		}
	}

	public virtual void OnGraphEnd()
	{
		if (!FCalliopeGraph.IsValid(Graph))
		{
			return;
		}
		foreach (QuestSubInstance value in SubInstances.Values)
		{
			value.Shutdown();
		}
		SubInstances.Clear();
		foreach (QuestNodeInstance value2 in NodeInstances.Values)
		{
			value2.Shutdown();
		}
		NodeInstances.Clear();
		TemplateAsset.FinishInstance();
	}

	public virtual void OnGraphTick(float DeltaTime)
	{
		foreach (QuestNodeInstance value in NodeInstances.Values)
		{
			if (value.ActivationState == ActivationState.Active)
			{
				value.Tick(DeltaTime);
			}
		}
	}

	protected void OnTriggerNodeInput(FCalliopeNode Node, string InputPin)
	{
		FindOrAddNodeInstance(Node)?.TriggerInput(InputPin);
	}

	public void AddSubInstance(Guid ParentNodeGuid, QuestSubInstance SubInstance)
	{
		SubInstances.Add(ParentNodeGuid, SubInstance);
	}

	public virtual void Shutdown()
	{
		foreach (QuestSubInstance value in SubInstances.Values)
		{
			value.Shutdown();
		}
		foreach (QuestNodeInstance value2 in NodeInstances.Values)
		{
			value2.Shutdown();
		}
		TemplateAsset?.FinishInstance();
		SubInstances.Clear();
		NodeInstances.Clear();
		TemplateAsset = null;
	}

	public void UnregisterNodeInstance(QuestNodeInstance InNodeInstance)
	{
	}

	public void ExecuteEdge(FCalliopeEdge Edge)
	{
		FindOrAddNodeInstance(Edge.To)?.TriggerInput(Edge.ToPinName);
	}

	private QuestNodeInstance FindOrAddNodeInstance(FCalliopeNode Node)
	{
		Guid nodeGuid = Node.NodeGuid;
		if (NodeInstances.TryGetValue(nodeGuid, out var value))
		{
			return value;
		}
		return null;
	}
}
