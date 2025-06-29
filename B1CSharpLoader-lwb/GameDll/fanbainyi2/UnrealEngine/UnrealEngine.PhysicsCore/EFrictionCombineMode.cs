using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.EFrictionCombineMode", "PhysicsCore", UnrealModuleType.Engine)]
public enum EFrictionCombineMode
{
	Average,
	Min,
	Multiply,
	Max
}
