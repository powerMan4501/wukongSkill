using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraPythonScriptInputSource", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraPythonScriptInputSource
{
	Input,
	Output,
	Local,
	InputOutput,
	InitialValueInput,
	None,
	Num
}
