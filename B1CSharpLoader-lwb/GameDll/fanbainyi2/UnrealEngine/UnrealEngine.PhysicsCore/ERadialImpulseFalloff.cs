using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[UMetaPath("/Script/PhysicsCore.ERadialImpulseFalloff", "PhysicsCore", UnrealModuleType.Engine)]
public enum ERadialImpulseFalloff
{
	RIF_Constant,
	RIF_Linear
}
