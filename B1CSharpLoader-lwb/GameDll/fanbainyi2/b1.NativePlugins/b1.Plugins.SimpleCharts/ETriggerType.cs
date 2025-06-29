using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.TriggerType", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum ETriggerType : byte
{
	Item,
	Axis
}
