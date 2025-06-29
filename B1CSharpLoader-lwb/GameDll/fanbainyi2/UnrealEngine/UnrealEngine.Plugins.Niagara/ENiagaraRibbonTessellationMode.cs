using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRibbonTessellationMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRibbonTessellationMode
{
	Automatic,
	Custom,
	Disabled
}
