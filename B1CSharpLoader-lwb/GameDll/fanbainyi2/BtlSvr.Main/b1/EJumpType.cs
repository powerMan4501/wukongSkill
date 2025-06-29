using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.JumpType")]
public enum EJumpType : byte
{
	None,
	Normal,
	GlideJump,
	StrideJump
}
