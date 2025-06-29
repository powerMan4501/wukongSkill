using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EMultiBlockType", "Slate", UnrealModuleType.Engine)]
public enum EMultiBlockType : byte
{
	None,
	ButtonRow,
	EditableText,
	Heading,
	MenuEntry,
	Separator,
	ToolBarButton,
	ToolBarComboButton,
	Widget
}
