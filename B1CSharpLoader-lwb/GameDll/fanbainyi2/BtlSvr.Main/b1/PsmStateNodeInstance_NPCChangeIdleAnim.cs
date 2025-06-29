using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_NPCChangeIdleAnim : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NPCChangeIdleAnim";

	private string NotifyActorGuid { get; set; }

	private int ChangeIdleAnimIdx { get; set; }

	private ProcessStateCustom_NPCChangeIdleAnim CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_NPCChangeIdleAnim();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyActorGuid = CustomData.NotifyActorGuid;
		ChangeIdleAnimIdx = CustomData.ChangeIdleAnimIdx;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		string notifyActorGuid = CustomData.NotifyActorGuid;
		int changeIdleAnimIdx = CustomData.ChangeIdleAnimIdx;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), notifyActorGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ChangeIdleAnimByIdx.Invoke(changeIdleAnimIdx);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
