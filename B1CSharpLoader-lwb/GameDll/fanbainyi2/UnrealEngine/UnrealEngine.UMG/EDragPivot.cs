using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EDragPivot", "UMG", UnrealModuleType.Engine)]
public enum EDragPivot : byte
{
	MouseDown,
	TopLeft,
	TopCenter,
	TopRight,
	CenterLeft,
	CenterCenter,
	CenterRight,
	BottomLeft,
	BottomCenter,
	BottomRight
}
