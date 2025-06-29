using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvOverlapShape", "AIModule", UnrealModuleType.Engine)]
public enum EEnvOverlapShape
{
	Box,
	Sphere,
	Capsule
}
