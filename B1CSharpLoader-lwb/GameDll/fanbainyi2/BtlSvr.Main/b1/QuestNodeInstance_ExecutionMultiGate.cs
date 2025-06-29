using System;
using System.Collections.Generic;
using System.Linq;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_ExecutionMultiGate : QuestNodeInstance
{
	private int NextOutput { get; set; }

	private List<bool> Completed { get; } = new List<bool>();

	private QuestCustom_ExecutionMultiGate CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_ExecutionMultiGate();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin == B1CalliopeDef.Common.DefaultInputPinName)
		{
			if (Completed.Count == 0)
			{
				Completed.Clear();
				for (int i = 0; i < base.Node.OutputEdges.Count; i++)
				{
					Completed.Add(item: false);
				}
			}
			if (!Completed.Contains(item: false))
			{
				return;
			}
			bool flag = !Completed.Contains(item: true) && Completed.Any() && Completed.Count > CustomData.StartIndex;
			if (CustomData.IsRandom)
			{
				int index;
				if (flag)
				{
					index = CustomData.StartIndex;
				}
				else
				{
					List<int> list = new List<int>();
					for (int j = 0; j < Completed.Count; j++)
					{
						if (!Completed[j])
						{
							list.Add(j);
						}
					}
					int index2 = FMath.RandRange(0, list.Count - 1);
					index = list[index2];
				}
				Completed[index] = true;
				TriggerOutput(base.Node.OutputEdges.Keys.ElementAt(index), bFinish: false);
			}
			else
			{
				if (flag)
				{
					NextOutput = CustomData.StartIndex;
				}
				int nextOutput = NextOutput;
				NextOutput = ++NextOutput % base.Node.OutputEdges.Count;
				Completed[nextOutput] = true;
				TriggerOutput(base.Node.OutputEdges.Keys.ElementAt(nextOutput), bFinish: false);
			}
			if (!Completed.Contains(item: false) && CustomData.IsLoop)
			{
				Finish();
			}
		}
		else if (InputPin == BGW_FlowUtils.PinName.Reset.PlainName)
		{
			Finish();
		}
	}

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		foreach (bool item in Completed)
		{
			list.AddRange(BitConverter.GetBytes(item));
		}
		return list.ToArray();
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		for (int i = 0; i < CustomData.Length; i++)
		{
			Completed.Add(BitConverter.ToBoolean(CustomData, i));
		}
	}

	public override void RecoverActiveState()
	{
	}
}
