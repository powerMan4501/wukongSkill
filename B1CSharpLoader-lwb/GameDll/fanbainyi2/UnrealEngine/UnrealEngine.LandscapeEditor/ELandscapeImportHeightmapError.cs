using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeImportHeightmapError", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeImportHeightmapError
{
	None,
	FileNotFound,
	InvalidSize,
	CorruptFile,
	ColorPng,
	LowBitDepth
}
