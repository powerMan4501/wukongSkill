using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraExecutionStateSource", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraExecutionStateSource
{
	Scalability,
	Internal,
	Owner,
	InternalCompletion
}
