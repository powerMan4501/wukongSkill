using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.AxisLineType", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum EAxisLineType : byte
{
	Solid,
	Dashed,
	Dotted
}
