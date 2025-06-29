using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDebugHUDPerfSampleMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDebugHUDPerfSampleMode
{
	FrameTotal,
	PerInstanceAverage
}
