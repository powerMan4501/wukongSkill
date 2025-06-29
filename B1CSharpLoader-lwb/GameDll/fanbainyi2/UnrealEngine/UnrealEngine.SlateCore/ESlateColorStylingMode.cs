using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ESlateColorStylingMode", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateColorStylingMode : byte
{
	UseColor_Specified,
	UseColor_ColorTable,
	UseColor_Foreground,
	UseColor_Foreground_Subdued,
	UseColor_UseStyle
}
