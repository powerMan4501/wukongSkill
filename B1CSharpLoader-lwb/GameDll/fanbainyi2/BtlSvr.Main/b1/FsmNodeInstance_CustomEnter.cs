using UnrealEngine.Runtime;

namespace b1;

public class FsmNodeInstance_CustomEnter : FsmNodeInstance
{
	protected override void OnExecuteNode_Custom(FName CustomEvent)
	{
		ExecuteCustomEventOut(CustomEvent);
	}
}
