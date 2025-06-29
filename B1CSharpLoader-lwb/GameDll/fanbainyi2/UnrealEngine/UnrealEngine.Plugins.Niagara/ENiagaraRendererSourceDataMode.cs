using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRendererSourceDataMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRendererSourceDataMode
{
	Particles,
	Emitter
}
