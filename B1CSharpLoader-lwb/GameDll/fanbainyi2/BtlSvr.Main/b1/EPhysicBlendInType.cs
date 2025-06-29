using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PhysicBlendInType")]
public enum EPhysicBlendInType : byte
{
	Immediately,
	BlendByTime
}
