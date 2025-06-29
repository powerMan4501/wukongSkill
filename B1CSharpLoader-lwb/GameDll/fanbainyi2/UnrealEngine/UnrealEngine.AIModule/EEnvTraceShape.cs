using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTraceShape", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTraceShape
{
	Line,
	Box,
	Sphere,
	Capsule
}
