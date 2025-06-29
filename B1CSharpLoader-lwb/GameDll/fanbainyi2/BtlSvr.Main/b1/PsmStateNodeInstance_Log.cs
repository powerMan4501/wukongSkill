using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmStateNodeInstance_Log : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.Log";

	private ProcessStateCustom_Log CustomData { get; set; }

	private FColor TextColor { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_Log();
		CustomData.MergeFrom(base.Node.NodeData);
		TextColor = new FLinearColor(CustomData.TextColorR, CustomData.TextColorG, CustomData.TextColorB, CustomData.TextColorA).ToFColor(srgb: true);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		UGSE_EngineFuncLib.LogDbgWithColor(CustomData.Message, CustomData.IsPrintToScreen, CustomData.Duration, TextColor, -1);
		TriggerFirstOutput(bFinish: true);
	}
}
