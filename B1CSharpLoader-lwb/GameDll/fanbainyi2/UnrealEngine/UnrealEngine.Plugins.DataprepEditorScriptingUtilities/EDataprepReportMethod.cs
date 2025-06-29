using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepEditorScriptingUtilities;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DataprepEditorScriptingUtilities.EDataprepReportMethod", "DataprepEditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public enum EDataprepReportMethod : byte
{
	StandardLog,
	SameFeedbackAsEditor,
	NoFeedback
}
