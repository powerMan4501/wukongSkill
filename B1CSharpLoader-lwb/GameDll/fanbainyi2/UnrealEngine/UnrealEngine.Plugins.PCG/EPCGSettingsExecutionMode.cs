using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSettingsExecutionMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSettingsExecutionMode
{
	Enabled,
	Debug,
	Isolated,
	Disabled
}
