using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeConvertMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeConvertMode
{
	Invalid = -1,
	Expand,
	Clip,
	Resample
}
