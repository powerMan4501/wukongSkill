using UnrealEngine.Runtime;

namespace b1;

internal class MagicFieldDirectionInfo
{
	public EMagicFieldDirectionUsage Usage;

	public FVector Direction;

	public MagicFieldDirectionInfo(EMagicFieldDirectionUsage InUsage, in FVector InDirection)
	{
		Usage = InUsage;
		Direction = InDirection;
	}
}
