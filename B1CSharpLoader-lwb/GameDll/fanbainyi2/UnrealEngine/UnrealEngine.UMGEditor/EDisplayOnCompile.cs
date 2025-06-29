using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UEnum]
[UMetaPath("/Script/UMGEditor.EDisplayOnCompile", "UMGEditor", UnrealModuleType.Engine)]
public enum EDisplayOnCompile
{
	DoC_ErrorsOrWarnings,
	DoC_ErrorsOnly,
	DoC_WarningsOnly,
	DoC_Never
}
