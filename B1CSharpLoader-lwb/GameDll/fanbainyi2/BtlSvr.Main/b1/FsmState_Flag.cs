using UnrealEngine.Runtime;

namespace b1;

public class FsmState_Flag : FsmState
{
	public override FGameplayTag StateTag { get; }

	public FsmState_Flag()
	{
	}

	public FsmState_Flag(FGameplayTag InStateTag)
	{
		StateTag = InStateTag;
	}

	public override void OnEnterAction(FsmInstance InInstance)
	{
		base.bInState = true;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.Owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnFSMStateEnter.Invoke(StateTag);
		}
	}

	public override void OnExitAction(FsmInstance InInstance)
	{
		base.bInState = false;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.Owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnFSMStateExit.Invoke(StateTag);
		}
	}
}
