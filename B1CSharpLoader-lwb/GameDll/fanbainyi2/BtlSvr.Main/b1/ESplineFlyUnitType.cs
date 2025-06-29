using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SplineFlyUnitType")]
public enum ESplineFlyUnitType : byte
{
	Monster,
	Player,
	TransitionPlayer
}
