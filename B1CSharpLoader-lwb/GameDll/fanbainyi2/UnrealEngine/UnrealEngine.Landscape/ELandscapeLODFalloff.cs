using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeLODFalloff", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeLODFalloff
{
	Linear,
	SquareRoot
}
