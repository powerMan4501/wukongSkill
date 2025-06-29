using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_Random : FBehaviorRightNodeInstance
{
	private BehaviorCustom_Random CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.Random;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_Random();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		int num = IsSuccessInRandom();
		if ((uint)(num - -1) > 1u && num == 1)
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.PlainName);
		}
	}

	private int IsSuccessInRandom()
	{
		int result = 1;
		int result2 = -1;
		if (CustomData.IsReverseCondition)
		{
			result = -1;
			result2 = 1;
		}
		float successRate = CustomData.SuccessRate;
		float num = FMath.FRand();
		if (successRate.Equals(0f))
		{
			return result2;
		}
		if (successRate.Equals(1f))
		{
			return result;
		}
		if (!(num <= successRate))
		{
			return result2;
		}
		return result;
	}
}
