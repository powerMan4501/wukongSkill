using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EUserInterfaceActionType", "Slate", UnrealModuleType.Engine)]
public enum EUserInterfaceActionType : byte
{
	None,
	Button,
	ToggleButton,
	RadioButton,
	Check,
	CollapsedButton
}
