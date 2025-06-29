using UnrealEngine.Engine;

namespace b1;

internal class BUITRebirthPoint : BUInteractTypeTemplate
{
	public BUITRebirthPoint()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.NotInBattle,
			EPreCheckBehavior.NotInTransforming
		};
	}

	public override bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public override bool BreakInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return base.BreakInteract(InteractiveActorID, User, InteractiveActor);
	}

	public override void FinishInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		base.FinishInteract(InteractiveActorID, User, InteractiveActor);
	}
}
