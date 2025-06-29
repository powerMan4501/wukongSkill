using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_AddBuff : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.AddBuff";

	private ProcessStateCustom_AddBuff CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_AddBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		string unitGuid = CustomData.UnitGuid;
		int buffId = CustomData.BuffId;
		int buffLayer = CustomData.BuffLayer;
		int buffDuration = CustomData.BuffDuration;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), unitGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				for (int i = 0; i < buffLayer; i++)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffId, actorByGuid, actorByGuid, buffDuration, EBuffSourceType.CPG);
				}
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
