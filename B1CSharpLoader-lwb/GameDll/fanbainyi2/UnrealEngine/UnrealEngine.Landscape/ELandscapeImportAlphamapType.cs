using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeImportAlphamapType", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeImportAlphamapType
{
	Additive,
	Layered
}
