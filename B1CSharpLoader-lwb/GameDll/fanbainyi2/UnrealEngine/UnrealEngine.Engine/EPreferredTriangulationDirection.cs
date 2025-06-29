using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPreferredTriangulationDirection", "Engine", UnrealModuleType.Engine)]
public enum EPreferredTriangulationDirection
{
	None,
	Tangential,
	Radial
}
