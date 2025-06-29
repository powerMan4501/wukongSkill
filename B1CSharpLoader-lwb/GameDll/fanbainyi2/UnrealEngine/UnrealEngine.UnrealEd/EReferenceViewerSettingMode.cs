using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EReferenceViewerSettingMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EReferenceViewerSettingMode
{
	NoPreference,
	ShowByDefault,
	HideByDefault
}
