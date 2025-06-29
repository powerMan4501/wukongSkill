using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraIterationSource", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraIterationSource
{
	Particles,
	DataInterface
}
