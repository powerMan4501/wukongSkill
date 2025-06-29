using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.SeriesLabelPosition", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum ESeriesLabelPosition : byte
{
	Inside,
	Top,
	Bottom,
	Left,
	Right
}
