using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSystemSpawnSectionEndBehavior", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSystemSpawnSectionEndBehavior
{
	SetSystemInactive,
	Deactivate,
	None
}
