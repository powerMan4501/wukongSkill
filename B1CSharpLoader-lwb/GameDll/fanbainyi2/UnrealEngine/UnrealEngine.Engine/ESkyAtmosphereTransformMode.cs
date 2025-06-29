using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkyAtmosphereTransformMode", "Engine", UnrealModuleType.Engine)]
public enum ESkyAtmosphereTransformMode
{
	PlanetTopAtAbsoluteWorldOrigin,
	PlanetTopAtComponentTransform,
	PlanetCenterAtComponentTransform
}
