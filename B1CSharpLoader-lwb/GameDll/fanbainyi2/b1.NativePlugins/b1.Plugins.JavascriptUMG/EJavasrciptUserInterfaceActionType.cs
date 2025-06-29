using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.EJavasrciptUserInterfaceActionType", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public enum EJavasrciptUserInterfaceActionType : byte
{
	None,
	Button,
	ToggleButton,
	RadioButton,
	Check,
	CollapsedButton
}
