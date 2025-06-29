using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ESlateBrushTileType", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateBrushTileType : byte
{
	NoTile,
	Horizontal,
	Vertical,
	Both
}
