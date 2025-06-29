using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraPlatformSetState", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraPlatformSetState
{
	Disabled,
	Enabled,
	Active,
	Unknown
}
