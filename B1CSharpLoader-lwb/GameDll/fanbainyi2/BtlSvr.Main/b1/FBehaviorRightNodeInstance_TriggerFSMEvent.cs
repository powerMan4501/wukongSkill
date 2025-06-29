using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_TriggerFSMEvent : FBehaviorRightNodeInstance
{
	private BehaviorCustom_OnTrigerFSMEvent CustomData { get; set; }

	private FGameplayTag FSMEventTag { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.OnTrigerFSMEvent;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_OnTrigerFSMEvent();
		CustomData.MergeFrom(base.Node.NodeData);
		FSMEventTag = GameplayTagExtension.MakeGameplayTag(CustomData.EventName);
		base.BUSEventCollection.Evt_TriggerFsmEvent += new Del_Void_GameplayTag(ExecuteOnTriggerFSMEvent);
	}

	private void ExecuteOnTriggerFSMEvent(FGameplayTag EventTag)
	{
		if (GameplayTagExtension.EqualTo(EventTag, FSMEventTag))
		{
			NotifyTriggerInput();
		}
	}

	protected override void Shutdown()
	{
		base.BUSEventCollection.Evt_TriggerFsmEvent -= new Del_Void_GameplayTag(ExecuteOnTriggerFSMEvent);
	}
}
