using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERayTracingGlobalIlluminationType", "Engine", UnrealModuleType.Engine)]
public enum ERayTracingGlobalIlluminationType
{
	Disabled,
	BruteForce,
	FinalGather
}
