using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDebugHUDPerfGraphMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDebugHUDPerfGraphMode
{
	None,
	GameThread,
	RenderThread,
	GPU
}
