using b1.CppExport;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmStateNodeInstance_NotifyActor : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.NotifyActor";

	private string NotifyActorGuid { get; set; }

	private GameplayTagContainerRef NotifyTags { get; set; }

	private ProcessStateCustom_NotifyActor CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_NotifyActor();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyActorGuid = CustomData.NotifyActorGuid;
		NotifyTags = new GameplayTagContainerRef();
		foreach (string notifyTagString in CustomData.NotifyTagStrings)
		{
			NotifyTags.AddTag(GameplayTagExtension.MakeGameplayTag(notifyTagString));
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), NotifyActorGuid);
		if (actorByGuid == null)
		{
			foreach (FGameplayTag notifyTag in NotifyTags)
			{
				BGW_EventCollection.Get(GetOwner()).Evt_SaveSceneObjEvent(NotifyActorGuid, notifyTag);
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_NotifyFromGraph.Invoke(NotifyTags);
			foreach (FGameplayTag notifyTag2 in NotifyTags)
			{
				BUS_EventCollectionCS.Get(actorByGuid).Evt_SceneObjTransitByEvent.Invoke(notifyTag2);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
