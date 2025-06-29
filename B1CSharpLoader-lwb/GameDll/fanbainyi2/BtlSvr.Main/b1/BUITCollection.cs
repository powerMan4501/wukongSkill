using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUITCollection : BUInteractTypeTemplate
{
	public BUITCollection()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[1] { EPreCheckBehavior.NotInTransforming };
	}

	public override bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		if (InteractiveActor.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}
}
