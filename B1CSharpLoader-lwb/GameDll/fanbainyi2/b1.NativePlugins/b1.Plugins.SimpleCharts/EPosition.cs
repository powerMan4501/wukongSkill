using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.Position", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum EPosition : byte
{
	Center,
	Left,
	Right
}
