using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraLibrarySourceDefaultMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraLibrarySourceDefaultMode
{
	Value,
	Binding,
	FailIfPreviouslyNotSet
}
