using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeImportTransformType", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeImportTransformType
{
	None,
	ExpandOffset,
	ExpandCentered,
	Resample
}
