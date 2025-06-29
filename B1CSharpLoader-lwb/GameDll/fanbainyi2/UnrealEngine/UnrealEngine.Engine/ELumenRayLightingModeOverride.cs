using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELumenRayLightingModeOverride", "Engine", UnrealModuleType.Engine)]
public enum ELumenRayLightingModeOverride
{
	Default,
	SurfaceCache,
	HitLighting
}
