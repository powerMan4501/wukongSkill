using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/UnrealExtent.ERRIndicatorType", "UnrealExtent", UnrealModuleType.Game)]
public enum ERRIndicatorType
{
	Top,
	Bottom,
	Left,
	Right,
	Middle
}
