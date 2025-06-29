using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ERTDrawingType", "Landscape", UnrealModuleType.Engine)]
public enum ERTDrawingType
{
	RTAtlas,
	RTAtlasToNonAtlas,
	RTNonAtlasToAtlas,
	RTNonAtlas,
	RTMips
}
