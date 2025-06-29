using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.EScriptSource", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum EScriptSource
{
	Niagara,
	Game,
	Plugins,
	Developer,
	Unknown
}
