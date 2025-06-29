using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraOutlinerTimeUnits", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraOutlinerTimeUnits
{
	Microseconds,
	Milliseconds,
	Seconds
}
