using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraExecutionState", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraExecutionState
{
	Active,
	Inactive,
	InactiveClear,
	Complete,
	Disabled,
	Num
}
