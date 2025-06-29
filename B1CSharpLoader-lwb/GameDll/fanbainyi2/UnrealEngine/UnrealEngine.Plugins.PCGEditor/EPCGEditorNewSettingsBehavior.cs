using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCGEditor;

[UEnum]
[UMetaPath("/Script/PCGEditor.EPCGEditorNewSettingsBehavior", "PCGEditor", UnrealModuleType.EnginePlugin)]
public enum EPCGEditorNewSettingsBehavior
{
	Normal,
	ForceCopy,
	ForceInstance
}
