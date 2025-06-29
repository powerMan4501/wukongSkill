using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERayTracingWaterCausticsType", "Engine", UnrealModuleType.Engine)]
public enum ERayTracingWaterCausticsType
{
	Disable,
	SurfelBasedRendering,
	ProceduralMeshes
}
