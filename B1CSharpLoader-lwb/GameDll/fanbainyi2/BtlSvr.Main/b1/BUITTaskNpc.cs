using UnrealEngine.Engine;

namespace b1;

internal class BUITTaskNpc : BUInteractTypeTemplate
{
	public BUITTaskNpc()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.NotInBattle,
			EPreCheckBehavior.NotInTransforming
		};
	}

	public override bool BreakInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public override bool FinishInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public override bool BreakInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		FinishInteract(InteractiveActorID, User, InteractiveActor);
		return true;
	}
}
