using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.EBlueprintComponentDataCookingMethod", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum EBlueprintComponentDataCookingMethod
{
	Disabled,
	AllBlueprints,
	EnabledBlueprintsOnly
}
