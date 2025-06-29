using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FsmNodeInstance_Junction : FsmNodeInstance
{
	private FGameplayTag StateTag { get; set; }

	protected override void OnInitialize()
	{
		StateCustom_Junction stateCustom_Junction = new StateCustom_Junction();
		stateCustom_Junction.MergeFrom(base.Node.NodeData);
		StateTag = GameplayTagExtension.MakeGameplayTag(stateCustom_Junction.JunctionState);
	}

	protected override void OnExecuteNode()
	{
		base.ParentInstance.OnEnterState(StateTag);
	}
}
