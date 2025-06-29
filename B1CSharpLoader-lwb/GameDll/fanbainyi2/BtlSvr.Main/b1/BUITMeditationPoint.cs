using UnrealEngine.Engine;

namespace b1;

internal class BUITMeditationPoint : BUInteractTypeTemplate
{
	public BUITMeditationPoint()
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
}
