using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.NpcMoveType")]
public enum ENpcMoveType : byte
{
	[DisplayName("寻路移动")]
	Navigation,
	[DisplayName("Spline移动")]
	Spline
}
