using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_RemoveBuff : QuestNodeInstance
{
	private QuestCustom_RemoveBuff CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_RemoveBuff();
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
				BUS_EventCollectionCS.Get(aActor)?.Evt_BuffRemove.Invoke(CustomData.BuffId, EBuffEffectTriggerType.None, 1);
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
