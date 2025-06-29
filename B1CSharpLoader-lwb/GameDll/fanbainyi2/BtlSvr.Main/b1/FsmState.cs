using UnrealEngine.Runtime;

namespace b1;

public abstract class FsmState
{
	public bool bInState { get; set; }

	public abstract FGameplayTag StateTag { get; }

	public abstract void OnEnterAction(FsmInstance InInstance);

	public abstract void OnExitAction(FsmInstance InInstance);
}
