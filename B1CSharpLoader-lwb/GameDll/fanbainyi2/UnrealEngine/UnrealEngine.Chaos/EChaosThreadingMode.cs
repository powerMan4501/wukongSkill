using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EChaosThreadingMode", "Chaos", UnrealModuleType.Engine)]
public enum EChaosThreadingMode
{
	DedicatedThread,
	TaskGraph,
	SingleThread,
	Num,
	Invalid
}
