using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeToolErosionMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeToolErosionMode
{
	Invalid = -1,
	Both,
	Raise,
	Lower
}
