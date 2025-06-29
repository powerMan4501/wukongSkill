using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestDistance", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestDistance
{
	Distance3D,
	Distance2D,
	DistanceZ,
	DistanceAbsoluteZ
}
