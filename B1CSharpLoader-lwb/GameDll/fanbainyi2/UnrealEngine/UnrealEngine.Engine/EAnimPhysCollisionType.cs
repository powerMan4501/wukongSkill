using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.AnimPhysCollisionType", "Engine", UnrealModuleType.Engine)]
public enum EAnimPhysCollisionType
{
	CoM,
	CustomSphere,
	InnerSphere,
	OuterSphere
}
