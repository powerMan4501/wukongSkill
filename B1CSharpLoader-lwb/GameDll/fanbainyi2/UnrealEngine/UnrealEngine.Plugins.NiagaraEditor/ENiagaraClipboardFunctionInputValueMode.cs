using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraClipboardFunctionInputValueMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraClipboardFunctionInputValueMode
{
	Local,
	Linked,
	Data,
	Expression,
	Dynamic
}
