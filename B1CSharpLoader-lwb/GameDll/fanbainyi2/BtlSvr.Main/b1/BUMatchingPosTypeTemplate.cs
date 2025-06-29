using UnrealEngine.Engine;

namespace b1;

public abstract class BUMatchingPosTypeTemplate
{
	public abstract bool TriggerMatchingPos(AActor User, in FMatchingPositionMoveParam Param);
}
