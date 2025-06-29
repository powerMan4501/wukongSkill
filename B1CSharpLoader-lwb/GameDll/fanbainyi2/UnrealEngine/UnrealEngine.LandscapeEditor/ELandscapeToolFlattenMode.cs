using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeToolFlattenMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeToolFlattenMode
{
	Invalid = -1,
	Both,
	Raise,
	Lower,
	Interval,
	Terrace
}
