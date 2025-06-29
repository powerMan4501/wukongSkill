using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDefaultMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDefaultMode
{
	Value,
	Binding,
	Custom,
	FailIfPreviouslyNotSet
}
