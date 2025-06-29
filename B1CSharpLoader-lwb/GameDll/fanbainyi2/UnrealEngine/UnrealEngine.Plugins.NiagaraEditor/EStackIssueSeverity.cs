using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.EStackIssueSeverity", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum EStackIssueSeverity
{
	Error,
	Warning,
	Info,
	CustomNote,
	None
}
