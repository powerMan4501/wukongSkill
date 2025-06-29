using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraOutlinerSortMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraOutlinerSortMode
{
	Auto,
	FilterMatches,
	AverageTime,
	MaxTime
}
