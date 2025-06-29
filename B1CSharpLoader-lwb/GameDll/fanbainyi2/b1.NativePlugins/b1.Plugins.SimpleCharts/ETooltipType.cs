using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.TooltipType", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum ETooltipType : byte
{
	Line,
	Shadow
}
