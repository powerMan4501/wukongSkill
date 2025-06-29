using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeImportResult", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeImportResult
{
	Success,
	Warning,
	Error
}
