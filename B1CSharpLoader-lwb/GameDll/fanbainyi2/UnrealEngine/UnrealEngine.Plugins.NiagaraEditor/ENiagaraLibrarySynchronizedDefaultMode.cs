using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraLibrarySynchronizedDefaultMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraLibrarySynchronizedDefaultMode
{
	Definition,
	Value,
	Binding,
	Custom,
	FailIfPreviouslyNotSet
}
