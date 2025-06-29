using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class QuestSubInstance : QuestInstance
{
	public QuestNodeInstance_SubGraph SubGraphNode { get; set; }

	public Dictionary<string, FCalliopeNode> CustomInputs { get; } = new Dictionary<string, FCalliopeNode>();

	public static QuestSubInstance Create(QuestNodeInstance_SubGraph InSubGraphNode)
	{
		if (InSubGraphNode == null)
		{
			return null;
		}
		if (InSubGraphNode.ParentInstance == null)
		{
			return null;
		}
		UObject owner = InSubGraphNode.ParentInstance.Owner;
		QuestSubInstance questSubInstance = new QuestSubInstance
		{
			Owner = owner,
			SubGraphNode = InSubGraphNode,
			Graph = InSubGraphNode.SubGraph
		};
		questSubInstance.TemplateAsset = FCalliopeAssetReference.CreateInstance(owner, ECalliopeAssetType.Quest, InSubGraphNode.AssetPath);
		foreach (FCalliopeNode node in questSubInstance.Graph.Nodes)
		{
			QuestNodeInstance questNodeInstance = QuestNodeInstanceFactory.Create(node, owner, questSubInstance);
			if (questNodeInstance != null)
			{
				questSubInstance.NodeInstances.Add(node.NodeGuid, questNodeInstance);
			}
		}
		InSubGraphNode.ParentInstance.AddSubInstance(InSubGraphNode.Node.NodeGuid, questSubInstance);
		return questSubInstance;
	}

	public override void OnGraphStart()
	{
		if (!FCalliopeGraph.IsValid(base.Graph))
		{
			return;
		}
		FCalliopeGuid nodeGuid = GameplayTagExtension.ConvertToCalliopeGuid(SubGraphNode.Node.NodeGuid);
		base.TemplateAsset.StartAsSubInstance(SubGraphNode.ParentInstance.TemplateAsset, nodeGuid);
		foreach (FCalliopeNode node in base.Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.QuestNode.CustomInput)
			{
				QuestCustom_CustomInput questCustom_CustomInput = new QuestCustom_CustomInput();
				questCustom_CustomInput.MergeFrom(node.NodeData);
				string eventName = questCustom_CustomInput.EventName;
				if (!string.IsNullOrEmpty(eventName))
				{
					CustomInputs.Add(eventName, node);
				}
			}
		}
	}

	public override void OnGraphEnd()
	{
		CustomInputs.Clear();
		TriggerCustomOutput(BGW_FlowUtils.PinName.Finish.PlainName);
		SubGraphNode = null;
		base.OnGraphEnd();
	}

	public void TriggerCustomOutput(string OutputPin)
	{
		if (OutputPin == BGW_FlowUtils.PinName.Finish.PlainName)
		{
			SubGraphNode.TriggerOutput(OutputPin, bFinish: true);
		}
		else
		{
			SubGraphNode.TriggerOutput(OutputPin, bFinish: false);
		}
	}

	public void TriggerCustomInput(string InputPin)
	{
		if (InputPin == BGW_FlowUtils.PinName.Start.PlainName)
		{
			OnTriggerNodeInput(base.Graph.GetStartNode(), "");
		}
		else if (CustomInputs.ContainsKey(InputPin))
		{
			OnTriggerNodeInput(CustomInputs[InputPin], "");
		}
	}
}
