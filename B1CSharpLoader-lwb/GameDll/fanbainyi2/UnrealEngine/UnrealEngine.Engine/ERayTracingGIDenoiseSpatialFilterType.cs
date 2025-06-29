using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERayTracingGIDenoiseSpatialFilterType", "Engine", UnrealModuleType.Engine)]
public enum ERayTracingGIDenoiseSpatialFilterType
{
	ATrous,
	Gaussian
}
