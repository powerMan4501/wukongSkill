using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_EnterState : FBehaviorRightNodeInstance
{
	private BehaviorCustom_EnterState CustomData { get; set; }

	private FGameplayTag StateName { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.EnterState;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_EnterState();
		CustomData.MergeFrom(base.Node.NodeData);
		StateName = GameplayTagExtension.MakeGameplayTag(CustomData.StateName);
		base.BUSEventCollection.Evt_OnFSMStateEnter += new Del_Void_FGameplayTag(ExecuteFSMStateEnter);
	}

	private void ExecuteFSMStateEnter(FGameplayTag FSMStateName)
	{
		if (GameplayTagExtension.EqualTo(FSMStateName, StateName))
		{
			NotifyTriggerInput();
		}
	}

	protected override void Shutdown()
	{
		base.BUSEventCollection.Evt_OnFSMStateEnter -= new Del_Void_FGameplayTag(ExecuteFSMStateEnter);
	}
}
