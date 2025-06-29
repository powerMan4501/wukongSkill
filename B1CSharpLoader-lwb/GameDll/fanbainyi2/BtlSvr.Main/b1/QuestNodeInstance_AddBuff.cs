using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_AddBuff : QuestNodeInstance
{
	private QuestCustom_AddBuff CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_AddBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor aActor = ((!(CustomData.UnitGuid == B1GlobalFNames.Player_Wukong.PlainName)) ? BGU_DataUtil.GetActorByGuid(base.Owner, CustomData.UnitGuid) : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn());
		if (aActor != null)
		{
			for (int i = 0; i < CustomData.BuffLayer; i++)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_BuffAdd.Invoke(CustomData.BuffId, aActor, aActor, CustomData.BuffDuration, EBuffSourceType.CQG);
			}
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
