using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ESlateBrushDrawType", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateBrushDrawType : byte
{
	NoDrawType,
	Box,
	Border,
	Image,
	RoundedBox
}
