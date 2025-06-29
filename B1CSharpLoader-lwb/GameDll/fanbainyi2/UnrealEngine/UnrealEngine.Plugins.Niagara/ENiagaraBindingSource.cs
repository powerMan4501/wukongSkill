using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraBindingSource", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraBindingSource
{
	ImplicitFromSource,
	ExplicitParticles,
	ExplicitEmitter,
	ExplicitSystem,
	ExplicitUser,
	MaxBindingSource
}
