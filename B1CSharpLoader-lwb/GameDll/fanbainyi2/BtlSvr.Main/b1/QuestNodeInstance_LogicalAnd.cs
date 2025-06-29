using System;
using System.Collections.Generic;
using System.Text;
using ArchiveB1;
using b1.AutoQA;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_LogicalAnd : QuestNodeInstance
{
	private HashSet<string> ExecutedInputNames { get; } = new HashSet<string>();

	public override void Shutdown()
	{
		ExecutedInputNames.Clear();
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		ExecutedInputNames.Add(InputPin);
		if (ExecutedInputNames.Count == base.Node.InputEdges.Count)
		{
			TriggerFirstOutput(bFinish: true);
		}
	}

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes(ExecutedInputNames.Count));
		foreach (string executedInputName in ExecutedInputNames)
		{
			list.AddRange(BitConverter.GetBytes(executedInputName.Length));
			list.AddRange(Encoding.UTF8.GetBytes(executedInputName));
		}
		return list.ToArray();
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		int num = 0;
		int num2 = BitConverter.ToInt32(CustomData, num);
		num += 4;
		for (int i = 0; i < num2; i++)
		{
			int num3 = BitConverter.ToInt32(CustomData, num);
			num += 4;
			ExecutedInputNames.Add(Encoding.UTF8.GetString(CustomData, num, num3));
			num += num3;
		}
	}

	public override void RecoverActiveState()
	{
		if (ExecutedInputNames.Count == base.Node.InputEdges.Count)
		{
			TriggerFirstOutput(bFinish: true);
		}
	}

	public static void AddInputPin2CustomData(LevelArchiveQuestNodeData NodeData, string InputPin)
	{
		if (NodeData.NodeTemplateName != B1CalliopeDef.QuestNode.LogicalAnd)
		{
			return;
		}
		byte[] array = NodeData.CustomData.ToByteArray();
		List<string> list = new List<string>();
		int num = 0;
		int num2 = BitConverter.ToInt32(array, num);
		num += 4;
		for (int i = 0; i < num2; i++)
		{
			int num3 = BitConverter.ToInt32(array, num);
			num += 4;
			list.Add(Encoding.UTF8.GetString(array, num, num3));
			num += num3;
		}
		ListExtensions.AddUnique(list, InputPin);
		List<byte> list2 = new List<byte>();
		list2.AddRange(BitConverter.GetBytes(list.Count));
		foreach (string item in list)
		{
			list2.AddRange(BitConverter.GetBytes(item.Length));
			list2.AddRange(Encoding.UTF8.GetBytes(item));
		}
		NodeData.CustomData = ByteString.CopyFrom(list2.ToArray());
	}
}
