using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDebugHUDOverviewMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDebugHUDOverviewMode
{
	Overview,
	Scalability,
	Performance,
	GpuComputePerformance
}
