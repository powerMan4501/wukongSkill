using UnrealEngine.Engine;

namespace b1;

internal class BUITCricket : BUInteractTypeTemplate
{
	public BUITCricket()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.NotInTransforming,
			EPreCheckBehavior.CricketIdle
		};
	}

	public override bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BUS_EventCollectionCS.Get(User)?.Evt_TriggerInteractCricket.Invoke(InteractiveActor);
		return true;
	}

	public override bool BreakInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BUS_EventCollectionCS.Get(User)?.Evt_BreakInteractCricket.Invoke();
		return true;
	}

	public override bool FinishInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BUS_EventCollectionCS.Get(User)?.Evt_FinishInteractCricket.Invoke();
		return true;
	}
}
