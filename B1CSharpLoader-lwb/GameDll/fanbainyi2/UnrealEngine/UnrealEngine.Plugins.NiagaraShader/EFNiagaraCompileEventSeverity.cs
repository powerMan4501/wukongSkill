using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UEnum]
[UMetaPath("/Script/NiagaraShader.FNiagaraCompileEventSeverity", "NiagaraShader", UnrealModuleType.EnginePlugin)]
public enum EFNiagaraCompileEventSeverity
{
	Log,
	Display,
	Warning,
	Error
}
