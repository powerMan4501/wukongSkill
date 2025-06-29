using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EEditorUserScreenPercentageModeOverride", "UnrealEd", UnrealModuleType.Engine)]
public enum EEditorUserScreenPercentageModeOverride
{
	ProjectDefault,
	Manual,
	BasedOnDisplayResolution,
	BasedOnDPIScale
}
