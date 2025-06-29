using UnrealEngine.Runtime;

namespace UnrealEngine.LandscapeEditor;

[UEnum]
[UMetaPath("/Script/LandscapeEditor.ELandscapeToolNoiseMode", "LandscapeEditor", UnrealModuleType.Engine)]
public enum ELandscapeToolNoiseMode
{
	Invalid = -1,
	Both,
	Add,
	Sub
}
