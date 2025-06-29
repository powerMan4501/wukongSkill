using System;
using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_Counter : QuestNodeInstance
{
	private string PN_Increment => BGW_FlowUtils.PinName.Increment.PlainName;

	private string PN_Step => BGW_FlowUtils.PinName.Step.PlainName;

	private string PN_Goal => BGW_FlowUtils.PinName.Goal.PlainName;

	private string PN_Decrement => BGW_FlowUtils.PinName.Decrement.PlainName;

	private string PN_Zero => BGW_FlowUtils.PinName.Zero.PlainName;

	private string PN_Skip => BGW_FlowUtils.PinName.Skip.PlainName;

	private string PN_Skipped => BGW_FlowUtils.PinName.Skipped.PlainName;

	private int CurrentSum { get; set; }

	private QuestCustom_Counter CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_Counter();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(PN_Increment))
		{
			CurrentSum++;
			if (CurrentSum == CustomData.Goal)
			{
				TriggerOutput(PN_Goal, bFinish: true);
			}
			else
			{
				TriggerOutput(PN_Step, bFinish: false);
			}
		}
		else if (InputPin == PN_Decrement)
		{
			CurrentSum--;
			if (CurrentSum == 0)
			{
				TriggerOutput(PN_Zero, bFinish: true);
			}
			else
			{
				TriggerOutput(PN_Step, bFinish: false);
			}
		}
		else if (InputPin == PN_Skip)
		{
			TriggerOutput(PN_Skipped, bFinish: true);
		}
	}

	public override void Shutdown()
	{
		CurrentSum = 0;
	}

	public override byte[] GetNodeCustomData()
	{
		return BitConverter.GetBytes(CurrentSum);
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		CurrentSum = BitConverter.ToInt32(CustomData, 0);
	}

	public override void RecoverActiveState()
	{
	}
}
