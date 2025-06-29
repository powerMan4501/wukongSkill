using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_ActiveUnit : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.ActiveUnit";

	private ProcessStateCustom_ActiveUnit CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_ActiveUnit();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), CustomData.UnitGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				AActor playerPawn = UGameplayStatics.GetPlayerPawn(GetOwner(), 0);
				if (playerPawn != null)
				{
					bUS_GSEventCollection.Evt_AICatchTarget.Invoke(playerPawn, ETargetSourceType.Target_CPGAssignTarget);
				}
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
