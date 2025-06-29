using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EDynamicBoxType", "UMG", UnrealModuleType.Engine)]
public enum EDynamicBoxType : byte
{
	Horizontal,
	Vertical,
	Wrap,
	VerticalWrap,
	Radial,
	Overlay
}
