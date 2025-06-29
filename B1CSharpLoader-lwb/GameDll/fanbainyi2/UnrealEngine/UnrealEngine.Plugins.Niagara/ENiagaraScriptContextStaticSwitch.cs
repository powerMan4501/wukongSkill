using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptContextStaticSwitch", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptContextStaticSwitch
{
	System,
	Emitter,
	Particle
}
