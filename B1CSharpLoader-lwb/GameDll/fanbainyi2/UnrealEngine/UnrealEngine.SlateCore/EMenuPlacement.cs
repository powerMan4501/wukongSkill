using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EMenuPlacement", "SlateCore", UnrealModuleType.Engine)]
public enum EMenuPlacement : byte
{
	MenuPlacement_BelowAnchor,
	MenuPlacement_CenteredBelowAnchor,
	MenuPlacement_BelowRightAnchor,
	MenuPlacement_ComboBox,
	MenuPlacement_ComboBoxRight,
	MenuPlacement_MenuRight,
	MenuPlacement_AboveAnchor,
	MenuPlacement_CenteredAboveAnchor,
	MenuPlacement_AboveRightAnchor,
	MenuPlacement_MenuLeft,
	MenuPlacement_Center,
	MenuPlacement_RightLeftCenter,
	MenuPlacement_MatchBottomLeft
}
