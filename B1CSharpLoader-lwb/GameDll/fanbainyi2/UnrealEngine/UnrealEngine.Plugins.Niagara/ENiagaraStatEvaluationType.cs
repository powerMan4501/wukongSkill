using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraStatEvaluationType", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraStatEvaluationType
{
	Average,
	Maximum
}
