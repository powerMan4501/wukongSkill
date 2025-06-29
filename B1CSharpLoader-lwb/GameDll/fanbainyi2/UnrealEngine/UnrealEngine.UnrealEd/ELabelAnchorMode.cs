using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ELabelAnchorMode", "UnrealEd", UnrealModuleType.Engine)]
public enum ELabelAnchorMode
{
	LabelAnchorMode_TopLeft,
	LabelAnchorMode_TopCenter,
	LabelAnchorMode_TopRight,
	LabelAnchorMode_CenterLeft,
	LabelAnchorMode_Centered,
	LabelAnchorMode_CenterRight,
	LabelAnchorMode_BottomLeft,
	LabelAnchorMode_BottomCenter,
	LabelAnchorMode_BottomRight
}
