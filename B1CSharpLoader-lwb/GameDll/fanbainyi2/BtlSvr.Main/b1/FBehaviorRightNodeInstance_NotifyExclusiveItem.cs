using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_NotifyExclusiveItem : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.NotifyExclusiveItem;

	private BehaviorCustom_NotifyExclusiveItem CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_NotifyExclusiveItem();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		string actorTag = CustomData.ActorTag;
		FGameplayTag tag = GameplayTagExtension.MakeGameplayTag(CustomData.NotifyTag);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, actorTag);
		if (!(actorByGuid == null))
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_SceneObjTransitByEventNoSaveState.Invoke(tag);
		}
	}
}
