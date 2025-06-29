using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraMessageSeverity", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMessageSeverity
{
	CriticalError,
	Error,
	PerformanceWarning,
	Warning,
	Info,
	CustomNote
}
