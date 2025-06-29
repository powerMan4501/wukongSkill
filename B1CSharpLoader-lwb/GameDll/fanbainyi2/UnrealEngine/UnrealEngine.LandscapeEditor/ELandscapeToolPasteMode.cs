using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeToolPasteMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeToolPasteMode
{
	Invalid = -1,
	Both,
	Raise,
	Lower
}
