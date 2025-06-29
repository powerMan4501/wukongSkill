using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_Log : QuestNodeInstance
{
	private QuestCustom_Log CustomData { get; set; }

	private FColor TextColor { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_Log();
		CustomData.MergeFrom(base.Node.NodeData);
		TextColor = new FLinearColor(CustomData.TextColorR, CustomData.TextColorG, CustomData.TextColorB, CustomData.TextColorA).ToFColor(srgb: true);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		UGSE_EngineFuncLib.LogDbgWithColor(CustomData.Message, CustomData.IsPrintToScreen, CustomData.Duration, TextColor, -1);
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
	}
}
