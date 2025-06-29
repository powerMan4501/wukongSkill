using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PhysicBlendOutType")]
public enum EPhysicBlendOutType : byte
{
	Immediately,
	BlendByTimeBeforeEnd,
	BlendByTimeAfterEnd
}
