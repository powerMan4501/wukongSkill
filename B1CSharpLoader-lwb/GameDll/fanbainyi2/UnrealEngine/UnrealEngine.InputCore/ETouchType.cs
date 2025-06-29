using UnrealEngine.Runtime;

namespace UnrealEngine.InputCore;

[UEnum]
[UMetaPath("/Script/InputCore.ETouchType", "InputCore", UnrealModuleType.Engine)]
public enum ETouchType
{
	Began,
	Moved,
	Stationary,
	ForceChanged,
	FirstMove,
	Ended,
	NumTypes
}
