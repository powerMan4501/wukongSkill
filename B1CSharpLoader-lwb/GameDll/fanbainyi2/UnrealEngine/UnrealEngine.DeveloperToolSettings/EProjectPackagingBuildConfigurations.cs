using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.EProjectPackagingBuildConfigurations", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum EProjectPackagingBuildConfigurations
{
	PPBC_Debug,
	PPBC_DebugGame,
	PPBC_Development,
	PPBC_Test,
	PPBC_Shipping
}
