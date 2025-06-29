using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_WeightRandom : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.WeightRandom;

	private BehaviorCustom_WeightRandom CustomData { get; set; }

	private List<float> MaxValues { get; } = new List<float>();

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_WeightRandom();
		CustomData.MergeFrom(base.Node.NodeData);
		MaxValues.Clear();
		float num = 0f;
		foreach (BehaviorCustom_WeightPin weightPin in CustomData.WeightPins)
		{
			num += (float)weightPin.Weight;
		}
		float num2 = 0f;
		foreach (BehaviorCustom_WeightPin weightPin2 in CustomData.WeightPins)
		{
			num2 += (float)weightPin2.Weight;
			MaxValues.Add(num2 / num);
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (MaxValues.Count == 0)
		{
			return;
		}
		float num = FMath.FRand();
		for (int i = 0; i < MaxValues.Count; i++)
		{
			if (num <= MaxValues[i])
			{
				TriggerOutput(CustomData.WeightPins[i].PinName);
				break;
			}
		}
	}
}
