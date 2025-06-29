using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptGroup", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptGroup
{
	Particle,
	Emitter,
	System,
	Max
}
