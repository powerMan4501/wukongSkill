using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DLSS;

[UEnum]
[UMetaPath("/Script/DLSS.EDLSSSettingOverride", "DLSS", UnrealModuleType.EnginePlugin)]
public enum EDLSSSettingOverride
{
	Enabled,
	Disabled,
	UseProjectSettings
}
