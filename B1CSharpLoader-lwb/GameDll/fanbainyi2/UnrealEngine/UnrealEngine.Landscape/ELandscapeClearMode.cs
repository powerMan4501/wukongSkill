using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeClearMode", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeClearMode
{
	Clear_Weightmap = 1,
	Clear_Heightmap,
	Clear_All
}
