using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_ExitState : FBehaviorRightNodeInstance
{
	private BehaviorCustom_ExitState CustomData { get; set; }

	private FGameplayTag StateName { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.ExitState;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_ExitState();
		CustomData.MergeFrom(base.Node.NodeData);
		StateName = GameplayTagExtension.MakeGameplayTag(CustomData.StateName);
		base.BUSEventCollection.Evt_OnFSMStateExit += new Del_Void_FGameplayTag(ExecuteFSMStateExit);
	}

	private void ExecuteFSMStateExit(FGameplayTag FSMStateName)
	{
		if (GameplayTagExtension.EqualTo(FSMStateName, StateName))
		{
			NotifyTriggerInput();
		}
	}

	protected override void Shutdown()
	{
		base.BUSEventCollection.Evt_OnFSMStateExit -= new Del_Void_FGameplayTag(ExecuteFSMStateExit);
	}
}
