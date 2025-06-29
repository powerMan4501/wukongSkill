using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EInputDisplayType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EInputDisplayType : byte
{
	NORNAL_BUTTON,
	TRIGGER_BUTTON,
	TRIGGER_TEXT,
	AXIS_BUTTON,
	AXIS_TEXT,
	MOUSE_POS_TEXT
}
