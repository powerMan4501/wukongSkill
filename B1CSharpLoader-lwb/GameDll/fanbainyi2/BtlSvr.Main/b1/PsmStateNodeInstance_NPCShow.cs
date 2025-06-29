using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmStateNodeInstance_NPCShow : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NPCShow";

	private string NotifyActorGuid { get; set; }

	private bool bNPCIsShow { get; set; }

	private ProcessStateCustom_NPCShow CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_NPCShow();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyActorGuid = CustomData.NotifyActorGuid;
		bNPCIsShow = CustomData.NpcIsShow;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), NotifyActorGuid);
		FGameplayTag fGameplayTag = (bNPCIsShow ? BGW_FlowUtils.NPCShowTag.Event_Appear : BGW_FlowUtils.NPCShowTag.Event_Hide);
		if (actorByGuid == null)
		{
			BGW_EventCollection.Get(GetOwner()).Evt_SaveSceneObjEvent(NotifyActorGuid, fGameplayTag);
		}
		else
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_SceneObjTransitByEvent.Invoke(fGameplayTag);
		}
		TriggerFirstOutput(bFinish: true);
	}
}
