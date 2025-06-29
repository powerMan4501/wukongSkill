using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineRHI;

[UEnum]
[UMetaPath("/Script/StreamlineRHI.EStreamlineSettingOverride", "StreamlineRHI", UnrealModuleType.EnginePlugin)]
public enum EStreamlineSettingOverride
{
	Enabled,
	Disabled,
	UseProjectSettings
}
