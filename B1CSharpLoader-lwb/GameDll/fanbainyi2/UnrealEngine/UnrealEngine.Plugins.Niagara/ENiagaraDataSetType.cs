using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDataSetType", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDataSetType
{
	ParticleData,
	Shared,
	Event
}
