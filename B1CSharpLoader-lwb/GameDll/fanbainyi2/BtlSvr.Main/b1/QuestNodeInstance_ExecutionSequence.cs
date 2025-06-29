using System;
using System.Collections.Generic;
using System.Text;

namespace b1;

public class QuestNodeInstance_ExecutionSequence : QuestNodeInstance
{
	private List<string> TriggeredPins { get; } = new List<string>();

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (string key in base.Node.OutputEdges.Keys)
		{
			TriggerOutput(key, bFinish: false);
			TriggeredPins.Add(key);
		}
		Finish();
	}

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes(TriggeredPins.Count));
		foreach (string triggeredPin in TriggeredPins)
		{
			list.AddRange(BitConverter.GetBytes(triggeredPin.Length));
			list.AddRange(Encoding.UTF8.GetBytes(triggeredPin));
		}
		return list.ToArray();
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		TriggeredPins.Clear();
		int num = 0;
		int num2 = BitConverter.ToInt32(CustomData, num);
		num += 4;
		for (int i = 0; i < num2; i++)
		{
			int num3 = BitConverter.ToInt32(CustomData, num);
			num += 4;
			TriggeredPins.Add(Encoding.UTF8.GetString(CustomData, num, num3));
			num += num3;
		}
	}

	public override void RecoverActiveState()
	{
		foreach (string key in base.Node.OutputEdges.Keys)
		{
			if (!TriggeredPins.Contains(key))
			{
				TriggerOutput(key, bFinish: false);
				TriggeredPins.Add(key);
			}
		}
		Finish();
	}

	protected override void Finish()
	{
		base.Finish();
		TriggeredPins.Clear();
	}
}
