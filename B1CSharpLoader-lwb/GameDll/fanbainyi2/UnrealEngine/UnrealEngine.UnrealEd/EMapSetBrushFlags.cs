using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EMapSetBrushFlags", "UnrealEd", UnrealModuleType.Engine)]
public enum EMapSetBrushFlags
{
	MSB_BrushColor = 1,
	MSB_Group = 2,
	MSB_PolyFlags = 4,
	MSB_BrushType = 8
}
