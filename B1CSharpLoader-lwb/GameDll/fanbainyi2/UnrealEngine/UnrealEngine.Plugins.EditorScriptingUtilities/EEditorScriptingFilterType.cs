using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UEnum]
[UMetaPath("/Script/EditorScriptingUtilities.EEditorScriptingFilterType", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public enum EEditorScriptingFilterType
{
	Include,
	Exclude
}
