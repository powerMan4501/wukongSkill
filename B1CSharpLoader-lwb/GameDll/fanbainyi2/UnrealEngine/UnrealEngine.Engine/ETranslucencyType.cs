using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETranslucencyType", "Engine", UnrealModuleType.Engine)]
public enum ETranslucencyType
{
	Raster,
	RayTracing,
	HybridTranslucency,
	EnhancedRayTracing
}
