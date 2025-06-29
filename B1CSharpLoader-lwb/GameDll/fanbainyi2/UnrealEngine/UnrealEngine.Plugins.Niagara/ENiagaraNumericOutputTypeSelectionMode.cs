using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraNumericOutputTypeSelectionMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraNumericOutputTypeSelectionMode
{
	None,
	Largest,
	Smallest,
	Scalar,
	Custom
}
