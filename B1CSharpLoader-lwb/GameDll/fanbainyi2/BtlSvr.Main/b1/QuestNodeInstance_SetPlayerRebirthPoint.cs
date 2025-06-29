using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_SetPlayerRebirthPoint : QuestNodeInstance
{
	private QuestCustom_SetPlayerRebirthPoint CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SetPlayerRebirthPoint();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		if (controlledPawn != null)
		{
			BPS_EventCollectionCS.Get(controlledPawn.PlayerState).Evt_SetCurrentRebirthPoint.Invoke(CustomData.RebirthPointId);
		}
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
		TriggerFirstOutput(bFinish: true);
	}
}
