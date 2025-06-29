using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeToolHydroErosionMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeToolHydroErosionMode
{
	Invalid = -1,
	Both,
	Positive
}
