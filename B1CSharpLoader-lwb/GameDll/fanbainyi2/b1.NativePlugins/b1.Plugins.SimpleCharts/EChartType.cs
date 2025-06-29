using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.ChartType", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum EChartType : byte
{
	Bar,
	Line
}
