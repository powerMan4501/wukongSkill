using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraTickBehavior", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraTickBehavior
{
	UsePrereqs,
	UseComponentTickGroup,
	ForceTickFirst,
	ForceTickLast
}
