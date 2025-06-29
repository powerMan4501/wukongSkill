using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELumenRayLightingMode", "Engine", UnrealModuleType.Engine)]
public enum ELumenRayLightingMode
{
	SurfaceCache = 0,
	HitLighting = 2
}
