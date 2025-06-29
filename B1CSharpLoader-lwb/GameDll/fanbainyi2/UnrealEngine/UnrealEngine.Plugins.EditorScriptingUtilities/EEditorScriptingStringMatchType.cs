using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EEditorScriptingStringMatchType", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public enum EEditorScriptingStringMatchType : byte
{
	Contains,
	MatchesWildcard,
	ExactMatch
}
