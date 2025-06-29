using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_NPCChangeLeisureAnim : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NPCChangeLeisureAnim";

	private string NotifyActorGuid { get; set; }

	private int ChangeLeisureAnimIndex { get; set; }

	private ProcessStateCustom_NPCChangeLeisureAnim CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_NPCChangeLeisureAnim();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyActorGuid = CustomData.NotifyActorGuid;
		ChangeLeisureAnimIndex = CustomData.ChangeLeisureAnimIndex;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		string notifyActorGuid = CustomData.NotifyActorGuid;
		int changeLeisureAnimIndex = CustomData.ChangeLeisureAnimIndex;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), notifyActorGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ChangeLeisureAnimByIdx.Invoke(changeLeisureAnimIndex);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
