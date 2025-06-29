using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBGUMoveAIType")]
public enum EBGUMoveAIType : byte
{
	None,
	KeepFacingTarget,
	Flock,
	FacingVelocity
}
