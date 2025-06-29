using b1.CppExport;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_NotifyActor : QuestNodeInstance
{
	private string NotifyActorGuid { get; set; }

	protected GameplayTagContainerRef NotifyTags { get; set; }

	private QuestCustom_NotifyActor CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_NotifyActor();
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
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, NotifyActorGuid);
		if (actorByGuid == null)
		{
			foreach (FGameplayTag notifyTag in NotifyTags)
			{
				BGW_EventCollection.Get(base.Owner).Evt_SaveSceneObjEvent(NotifyActorGuid, notifyTag);
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

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, NotifyActorGuid);
		if (actorByGuid == null)
		{
			foreach (FGameplayTag notifyTag in NotifyTags)
			{
				BGW_EventCollection.Get(base.Owner).Evt_SaveSceneObjEvent(NotifyActorGuid, notifyTag);
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
