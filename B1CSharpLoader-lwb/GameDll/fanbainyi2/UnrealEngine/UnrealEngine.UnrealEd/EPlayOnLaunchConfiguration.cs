using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayOnLaunchConfiguration", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayOnLaunchConfiguration
{
	LaunchConfig_Default,
	LaunchConfig_Debug,
	LaunchConfig_Development,
	LaunchConfig_Test,
	LaunchConfig_Shipping
}
