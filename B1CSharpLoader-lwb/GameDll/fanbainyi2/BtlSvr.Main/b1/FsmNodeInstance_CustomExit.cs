using UnrealEngine.Runtime;

namespace b1;

public class FsmNodeInstance_CustomExit : FsmNodeInstance
{
	protected override void OnExecuteNode_Custom(FName CustomEvent)
	{
		if (base.ParentInstance != null && base.ParentInstance is FsmSubInstance fsmSubInstance)
		{
			fsmSubInstance.OnEvent(GameplayTagExtension.MakeGameplayTag(CustomEvent));
		}
	}
}
