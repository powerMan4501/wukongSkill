using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSimTarget", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSimTarget
{
	CPUSim,
	GPUComputeSim
}
