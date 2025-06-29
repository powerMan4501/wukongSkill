using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCompileUsageStaticSwitch", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCompileUsageStaticSwitch
{
	Spawn,
	Update,
	Event,
	SimulationStage,
	Default
}
