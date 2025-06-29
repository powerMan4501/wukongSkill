using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.EProjectPackagingBlueprintNativizationMethod", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum EProjectPackagingBlueprintNativizationMethod
{
	Disabled,
	Inclusive,
	Exclusive
}
