using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScalabilityUpdateFrequency", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScalabilityUpdateFrequency
{
	SpawnOnly,
	Low,
	Medium,
	High,
	Continuous
}
