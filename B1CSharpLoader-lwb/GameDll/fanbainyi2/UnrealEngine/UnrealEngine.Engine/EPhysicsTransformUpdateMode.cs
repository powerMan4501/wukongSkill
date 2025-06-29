using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPhysicsTransformUpdateMode", "Engine", UnrealModuleType.Engine)]
public enum EPhysicsTransformUpdateMode
{
	SimulationUpatesComponentTransform,
	ComponentTransformIsKinematic
}
