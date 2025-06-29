using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.Orient", "SimpleCharts", UnrealModuleType.GamePlugin)]
public enum EOrient : byte
{
	Horizontal,
	Vertical
}
