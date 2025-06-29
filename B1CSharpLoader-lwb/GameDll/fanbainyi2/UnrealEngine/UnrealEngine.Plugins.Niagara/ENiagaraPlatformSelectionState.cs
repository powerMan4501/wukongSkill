using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraPlatformSelectionState", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraPlatformSelectionState
{
	Default,
	Enabled,
	Disabled
}
