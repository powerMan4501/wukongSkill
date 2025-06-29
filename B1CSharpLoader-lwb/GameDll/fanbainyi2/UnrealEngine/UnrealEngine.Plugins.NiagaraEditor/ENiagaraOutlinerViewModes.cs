using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraOutlinerViewModes", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraOutlinerViewModes
{
	State,
	Performance
}
