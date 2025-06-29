using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UEnum]
[UMetaPath("/Script/NiagaraShader.FNiagaraCompileEventSource", "NiagaraShader", UnrealModuleType.EnginePlugin)]
public enum EFNiagaraCompileEventSource
{
	Unset,
	ScriptDependency
}
