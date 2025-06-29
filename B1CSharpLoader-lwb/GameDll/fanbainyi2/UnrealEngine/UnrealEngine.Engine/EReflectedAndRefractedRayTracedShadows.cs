using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EReflectedAndRefractedRayTracedShadows", "Engine", UnrealModuleType.Engine)]
public enum EReflectedAndRefractedRayTracedShadows
{
	Disabled,
	Hard_shadows,
	Area_shadows
}
