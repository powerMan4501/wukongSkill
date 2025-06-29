using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorLeftNodeInstance_DetectExclusiveItemState : FBehaviorLeftNodeInstance
{
	private BehaviorCustom_DetectExclusiveItemState CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.DetectExclusiveItemState;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_DetectExclusiveItemState();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ConditionCoolDownTimeMs = CustomData.ConditionCoolDownTimeMs;
	}

	protected override int IsSuccess()
	{
		int result = 1;
		int result2 = -1;
		if (CustomData.IsReverseCondition)
		{
			result = -1;
			result2 = 1;
		}
		if (base.ParentInstance.ParentGraphComp.StateMachineData.GetCurrentSceneObjState(CustomData.ActorTag, out var GameplayTagContainerRef) && GameplayTagContainerRef.IsValid())
		{
			foreach (string stateTag in CustomData.StateTags)
			{
				FGameplayTag tag = GameplayTagExtension.MakeGameplayTag(stateTag);
				if (GameplayTagContainerRef.HasTag(tag))
				{
					return result;
				}
			}
		}
		return result2;
	}
}
