using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeImportLayerError", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeImportLayerError
{
	None,
	MissingLayerInfo,
	FileNotFound,
	FileSizeMismatch,
	CorruptFile,
	ColorPng
}
