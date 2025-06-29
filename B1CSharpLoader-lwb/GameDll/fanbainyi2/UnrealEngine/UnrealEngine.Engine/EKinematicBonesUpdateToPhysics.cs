using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EKinematicBonesUpdateToPhysics", "Engine", UnrealModuleType.Engine)]
public enum EKinematicBonesUpdateToPhysics
{
	SkipSimulatingBones,
	SkipAllBones
}
