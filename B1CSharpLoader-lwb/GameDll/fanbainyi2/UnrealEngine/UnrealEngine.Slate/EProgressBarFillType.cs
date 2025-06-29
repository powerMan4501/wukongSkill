using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EProgressBarFillType", "Slate", UnrealModuleType.Engine)]
public enum EProgressBarFillType : byte
{
	LeftToRight,
	RightToLeft,
	FillFromCenter,
	FillFromCenterHorizontal,
	FillFromCenterVertical,
	TopToBottom,
	BottomToTop
}
