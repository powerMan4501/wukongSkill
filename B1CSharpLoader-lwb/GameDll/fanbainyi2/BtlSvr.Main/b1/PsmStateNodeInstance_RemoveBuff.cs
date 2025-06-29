using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_RemoveBuff : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.RemoveBuff";

	private ProcessStateCustom_RemoveBuff CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_RemoveBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		string unitGuid = CustomData.UnitGuid;
		int buffId = CustomData.BuffId;
		int buffLayer = CustomData.BuffLayer;
		bool isTriggerRemoveEffect = CustomData.IsTriggerRemoveEffect;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), unitGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(buffId, EBuffEffectTriggerType.None, buffLayer, isTriggerRemoveEffect);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
