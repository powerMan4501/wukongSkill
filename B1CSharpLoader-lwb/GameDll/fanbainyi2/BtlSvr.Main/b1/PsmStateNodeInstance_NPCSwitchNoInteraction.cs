using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_NPCSwitchNoInteraction : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NPCSwitchNoInteraction";

	private ProcessStateCustom_SwitchNoInteraction CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_SwitchNoInteraction();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		string unitGuid = CustomData.UnitGuid;
		bool isRecover = CustomData.IsRecover;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), unitGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SwitchNoInteraction.Invoke(isRecover);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
